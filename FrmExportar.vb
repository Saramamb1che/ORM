Imports System.IO
Imports MySqlConnector

Public Class FrmExportar

#Region "1. Datos del formulario"

    Private tablaAlumnos As New DataTable()
    Private carreraCargada As String = ""          ' filtro con el que se cargó la tabla

    Private Const TODAS As String = "(Todas)"
    Private ReadOnly rutaLogo As String =
        Path.Combine(Application.StartupPath, "Recursos", "logo-uni.png")

#End Region

#Region "2. Carga de datos"

    Private Sub FrmExportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarExportar(False)
        CargarCarreras()
    End Sub

    Private Sub CargarCarreras()
        cboCarrera.Items.Clear()
        cboCarrera.Items.Add(TODAS)
        Try
            Using cn As MySqlConnection = ObtenerConexion(),
                  cmd As New MySqlCommand("SELECT DISTINCT carrera FROM alumnos ORDER BY carrera", cn)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        cboCarrera.Items.Add(dr.GetString(0))
                    End While
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al consultar MariaDB:" & vbCrLf & ex.Message,
                            "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cboCarrera.SelectedIndex = 0
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim carrera As String = cboCarrera.Text
        Dim filtrar As Boolean = (carrera <> TODAS)
        Dim sql As String = "SELECT carnet, nombres, apellidos, carrera, promedio FROM alumnos"
        If filtrar Then sql &= " WHERE carrera = @carrera"
        sql &= " ORDER BY apellidos, nombres"

        Try
            Dim tabla As New DataTable()
            Using cn As MySqlConnection = ObtenerConexion(),
                  da As New MySqlDataAdapter(sql, cn)
                If filtrar Then da.SelectCommand.Parameters.AddWithValue("@carrera", carrera)
                da.Fill(tabla)
            End Using

            tablaAlumnos = tabla
            carreraCargada = carrera
            dgvAlumnos.DataSource = tablaAlumnos
            lblEstado.Text = "Registros cargados: " & tablaAlumnos.Rows.Count
            HabilitarExportar(tablaAlumnos.Rows.Count > 0)
        Catch ex As MySqlException
            MessageBox.Show("Error al consultar MariaDB:" & vbCrLf & ex.Message,
                            "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "3. Exportar a Excel (ClosedXML)"

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim ruta As String = PedirRuta("Libro de Excel (*.xlsx)|*.xlsx", "Alumnos.xlsx")
        If ruta = "" Then Return

        Try
            ExportadorExcel.Exportar(tablaAlumnos, carreraCargada, ruta, rutaLogo)
            Terminar(ruta)
        Catch ex As IOException
            ' El caso más común: el archivo sigue abierto en Excel
            MessageBox.Show("No se pudo guardar el archivo. Ciérralo si está abierto en Excel." &
                            vbCrLf & vbCrLf & ex.Message, "Exportar a Excel",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error al generar el archivo:" & vbCrLf & ex.Message, "Exportar a Excel",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "4. Exportar a PDF (QuestPDF)"

    Private Sub btnPdf_Click(sender As Object, e As EventArgs) Handles btnPdf.Click
        Dim ruta As String = PedirRuta("Documento PDF (*.pdf)|*.pdf", "Alumnos.pdf")
        If ruta = "" Then Return

        Try
            ExportadorPdf.Exportar(tablaAlumnos, carreraCargada, ruta, rutaLogo)
            Terminar(ruta)
        Catch ex As IOException
            MessageBox.Show("No se pudo guardar el archivo. Ciérralo si está abierto en el visor de PDF." &
                            vbCrLf & vbCrLf & ex.Message, "Exportar a PDF",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error al generar el archivo:" & vbCrLf & ex.Message, "Exportar a PDF",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "5. Métodos auxiliares"

    ' Muestra "Guardar como" y devuelve la ruta elegida ("" si se cancela)
    Private Function PedirRuta(filtro As String, nombre As String) As String
        Using dlg As New SaveFileDialog() With {.Filter = filtro, .FileName = nombre}
            If dlg.ShowDialog(Me) = DialogResult.OK Then Return dlg.FileName
        End Using
        Return ""
    End Function

    ' Informa el resultado y ofrece abrir el archivo con el programa predeterminado
    Private Sub Terminar(ruta As String)
        lblEstado.Text = "Archivo generado: " & Path.GetFileName(ruta)
        Dim r As DialogResult = MessageBox.Show("Archivo generado:" & vbCrLf & ruta & vbCrLf & vbCrLf &
                                                "¿Deseas abrirlo?", "Exportar",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If r = DialogResult.Yes Then
            Process.Start(New ProcessStartInfo(ruta) With {.UseShellExecute = True})
        End If
    End Sub

    Private Sub HabilitarExportar(valor As Boolean)
        btnExcel.Enabled = valor
        btnPdf.Enabled = valor
    End Sub

#End Region

End Class
