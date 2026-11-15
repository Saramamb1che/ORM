Imports System.IO
Imports ClosedXML.Excel

' Genera un libro de Excel (.xlsx) con el listado de alumnos.
' Usa ClosedXML: no necesita Excel instalado en la computadora.
Module ExportadorExcel

    Private Const FILA_TITULOS As Integer = 5      ' fila donde empieza la tabla
    Private Const AZUL As String = "#0A3A7A"
    Private Const GRIS As String = "#4A5568"
    Private Const BORDE As String = "#D5DCE6"
    Private Const ROJO As String = "#B3261E"

    Public Sub Exportar(tabla As DataTable, carrera As String, ruta As String, rutaLogo As String)
        Using libro As New XLWorkbook()
            Dim hoja As IXLWorksheet = libro.Worksheets.Add("Alumnos")

            ' 1) Encabezado del documento: logo en A1, textos en la columna B
            If File.Exists(rutaLogo) Then
                hoja.AddPicture(rutaLogo).MoveTo(hoja.Cell("A1")).WithSize(84, 48)
            End If
            hoja.Cell("B1").Value = "Universidad Nacional de Ingeniería"
            hoja.Cell("B2").Value = "Listado de alumnos"
            hoja.Cell("B3").Value = "Carrera: " & carrera & "    Generado: " & Date.Now.ToString("dd/MM/yyyy HH:mm")
            hoja.Cell("B1").Style.Font.FontColor = XLColor.FromHtml(GRIS)
            hoja.Cell("B2").Style.Font.SetBold().Font.SetFontSize(16).Font.SetFontColor(XLColor.FromHtml(AZUL))
            hoja.Cell("B3").Style.Font.FontColor = XLColor.FromHtml(GRIS)

            ' 2) Títulos de columna
            Dim titulos() As String = {"Carnet", "Nombres", "Apellidos", "Carrera", "Promedio", "Estado"}
            For c As Integer = 0 To titulos.Length - 1
                hoja.Cell(FILA_TITULOS, c + 1).Value = titulos(c)

            Next

            ' 3) Datos: InsertData copia todas las filas del DataTable (sin encabezados)
            ' --- INICIO COLUMNA ESTADO ---
            If Not tabla.Columns.Contains("Estado") Then
                tabla.Columns.Add("Estado", GetType(String))
            End If

            For Each fila As DataRow In tabla.Rows
                If Convert.ToDouble(fila("promedio")) >= 75 Then
                    fila("Estado") = "Aprobado"
                Else
                    fila("Estado") = "Reprobado"
                End If
            Next
            ' --- FIN COLUMNA ESTADO ---
            hoja.Cell(FILA_TITULOS + 1, 1).InsertData(tabla)
            Dim primera As Integer = FILA_TITULOS + 1
            Dim ultima As Integer = FILA_TITULOS + tabla.Rows.Count
            Dim filaTotal As Integer = ultima + 2

            ' 4) Formato de la tabla
            Dim rTitulos As IXLRange = hoja.Range(FILA_TITULOS, 1, FILA_TITULOS, 5)
            rTitulos.Style.Font.Bold = True
            rTitulos.Style.Font.FontColor = XLColor.White
            rTitulos.Style.Fill.BackgroundColor = XLColor.FromHtml(AZUL)

            Dim rTabla As IXLRange = hoja.Range(FILA_TITULOS, 1, ultima, 6)
            rTabla.Style.Border.OutsideBorder = XLBorderStyleValues.Thin
            rTabla.Style.Border.InsideBorder = XLBorderStyleValues.Thin
            rTabla.Style.Border.OutsideBorderColor = XLColor.FromHtml(BORDE)
            rTabla.Style.Border.InsideBorderColor = XLColor.FromHtml(BORDE)
            rTabla.SetAutoFilter()                          ' flechas de filtro en los títulos

            Dim rPromedios As IXLRange = hoja.Range(primera, 5, ultima, 5)
            rPromedios.Style.NumberFormat.Format = "0.00"
            rPromedios.AddConditionalFormat().WhenLessThan(75).Font.SetFontColor(XLColor.FromHtml(ROJO))

            ' 5) Totales con fórmulas: Excel los recalcula si se editan los datos
            hoja.Cell(filaTotal, 1).Value = "Total de alumnos:"
            hoja.Cell(filaTotal, 2).FormulaA1 = $"COUNTA(A{primera}:A{ultima})"
            hoja.Cell(filaTotal, 4).Value = "Promedio general:"
            hoja.Cell(filaTotal, 4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right
            hoja.Cell(filaTotal, 5).FormulaA1 = $"AVERAGE(E{primera}:E{ultima})"
            hoja.Cell(filaTotal, 5).Style.NumberFormat.Format = "0.00"
            hoja.Range(filaTotal, 1, filaTotal, 5).Style.Font.SetBold().Font.SetFontColor(XLColor.FromHtml(AZUL))

            ' 6) Ajustes finales y guardar
            hoja.Columns(1, 5).AdjustToContents(FILA_TITULOS, filaTotal)
            hoja.SheetView.FreezeRows(FILA_TITULOS)         ' los títulos quedan fijos al desplazarse
            hoja.PageSetup.FitToPages(1, 0)                 ' al imprimir: 1 página de ancho
            Dim hojaResumen = libro.Worksheets.Add("Resumen")

            hojaResumen.Cell(1, 1).Value = "Carrera"
            hojaResumen.Cell(1, 2).Value = "Alumnos"
            hojaResumen.Cell(1, 3).Value = "Promedio"

            Dim carreras = tabla.AsEnumerable().Select(Function(r) r.Field(Of String)("carrera")).Distinct().ToList()

            Dim filaResumen As Integer = 2
            For Each carrera In carreras
                hojaResumen.Cell(filaResumen, 1).Value = carrera
                hojaResumen.Cell(filaResumen, 2).FormulaA1 = $"=COUNTIF(Alumnos!D:D, ""{carrera}"")"
                hojaResumen.Cell(filaResumen, 3).FormulaA1 = $"=AVERAGEIF(Alumnos!D:D, ""{carrera}"", Alumnos!E:E)"
                filaResumen += 1
            Next

            hojaResumen.Columns().AdjustToContents()
            hojaResumen.Range(1, 1, 1, 3).Style.Font.Bold = True
            hojaResumen.Range(2, 3, filaResumen - 1, 3).Style.NumberFormat.Format = "0.00"
            libro.SaveAs(ruta)
        End Using

    End Sub

End Module
