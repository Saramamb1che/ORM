<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExportar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento.
    'Se puede modificar usando el Diseñador; no lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlFiltros = New Panel()
        lblCarrera = New Label()
        cboCarrera = New ComboBox()
        btnCargar = New Button()
        dgvAlumnos = New DataGridView()
        pnlAcciones = New Panel()
        btnExportarCsv = New Button()
        btnExcel = New Button()
        btnPdf = New Button()
        lblEstado = New Label()
        pnlFiltros.SuspendLayout()
        CType(dgvAlumnos, ComponentModel.ISupportInitialize).BeginInit()
        pnlAcciones.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlFiltros
        ' 
        pnlFiltros.BackColor = Color.FromArgb(CByte(231), CByte(236), CByte(243))
        pnlFiltros.Controls.Add(lblCarrera)
        pnlFiltros.Controls.Add(cboCarrera)
        pnlFiltros.Controls.Add(btnCargar)
        pnlFiltros.Dock = DockStyle.Top
        pnlFiltros.Location = New Point(0, 0)
        pnlFiltros.Name = "pnlFiltros"
        pnlFiltros.Size = New Size(900, 56)
        pnlFiltros.TabIndex = 0
        ' 
        ' lblCarrera
        ' 
        lblCarrera.AutoSize = True
        lblCarrera.Location = New Point(16, 19)
        lblCarrera.Name = "lblCarrera"
        lblCarrera.Size = New Size(48, 15)
        lblCarrera.TabIndex = 0
        lblCarrera.Text = "Carrera:"
        ' 
        ' cboCarrera
        ' 
        cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList
        cboCarrera.Location = New Point(80, 15)
        cboCarrera.Name = "cboCarrera"
        cboCarrera.Size = New Size(260, 23)
        cboCarrera.TabIndex = 0
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(356, 11)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(150, 32)
        btnCargar.TabIndex = 1
        btnCargar.Text = "Cargar datos"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' dgvAlumnos
        ' 
        dgvAlumnos.AllowUserToAddRows = False
        dgvAlumnos.AllowUserToDeleteRows = False
        dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlumnos.Dock = DockStyle.Fill
        dgvAlumnos.Location = New Point(0, 56)
        dgvAlumnos.Name = "dgvAlumnos"
        dgvAlumnos.ReadOnly = True
        dgvAlumnos.RowHeadersVisible = False
        dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAlumnos.Size = New Size(900, 488)
        dgvAlumnos.TabIndex = 1
        ' 
        ' pnlAcciones
        ' 
        pnlAcciones.BackColor = Color.FromArgb(CByte(231), CByte(236), CByte(243))
        pnlAcciones.Controls.Add(btnExportarCsv)
        pnlAcciones.Controls.Add(btnExcel)
        pnlAcciones.Controls.Add(btnPdf)
        pnlAcciones.Controls.Add(lblEstado)
        pnlAcciones.Dock = DockStyle.Bottom
        pnlAcciones.Location = New Point(0, 544)
        pnlAcciones.Name = "pnlAcciones"
        pnlAcciones.Size = New Size(900, 56)
        pnlAcciones.TabIndex = 2
        ' 
        ' btnExportarCsv
        ' 
        btnExportarCsv.Location = New Point(514, 20)
        btnExportarCsv.Name = "btnExportarCsv"
        btnExportarCsv.Size = New Size(108, 23)
        btnExportarCsv.TabIndex = 3
        btnExportarCsv.Text = "Exportar a CSV"
        btnExportarCsv.UseVisualStyleBackColor = True
        ' 
        ' btnExcel
        ' 
        btnExcel.Location = New Point(16, 11)
        btnExcel.Name = "btnExcel"
        btnExcel.Size = New Size(160, 32)
        btnExcel.TabIndex = 0
        btnExcel.Text = "Exportar a Excel"
        btnExcel.UseVisualStyleBackColor = True
        ' 
        ' btnPdf
        ' 
        btnPdf.Location = New Point(186, 11)
        btnPdf.Name = "btnPdf"
        btnPdf.Size = New Size(160, 32)
        btnPdf.TabIndex = 1
        btnPdf.Text = "Exportar a PDF"
        btnPdf.UseVisualStyleBackColor = True
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(366, 19)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(106, 15)
        lblEstado.TabIndex = 2
        lblEstado.Text = "Sin datos cargados"
        ' 
        ' FrmExportar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 600)
        Controls.Add(dgvAlumnos)
        Controls.Add(pnlAcciones)
        Controls.Add(pnlFiltros)
        MinimumSize = New Size(720, 480)
        Name = "FrmExportar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Exportar alumnos – ClosedXML y QuestPDF"
        pnlFiltros.ResumeLayout(False)
        pnlFiltros.PerformLayout()
        CType(dgvAlumnos, ComponentModel.ISupportInitialize).EndInit()
        pnlAcciones.ResumeLayout(False)
        pnlAcciones.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents lblCarrera As System.Windows.Forms.Label
    Friend WithEvents cboCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents pnlAcciones As System.Windows.Forms.Panel
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPdf As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents btnExportarCsv As Button
End Class
