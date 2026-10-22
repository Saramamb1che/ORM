<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporte))
        lblTitulo = New Label()
        btnCargar = New Button()
        btnConfigurar = New Button()
        btnVistaPrevia = New Button()
        btnImprimir = New Button()
        dgvAlumnos = New DataGridView()
        lblEstado = New Label()
        pdReporte = New Printing.PrintDocument()
        ppdVista = New PrintPreviewDialog()
        psdPagina = New PageSetupDialog()
        dlgImprimir = New PrintDialog()
        cboCarrera = New ComboBox()
        chkHorizontal = New CheckBox()
        CType(dgvAlumnos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTitulo.Location = New Point(16, 12)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(294, 25)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Listado de alumnos – Impresión"
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(16, 52)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(150, 34)
        btnCargar.TabIndex = 0
        btnCargar.Text = "Cargar datos"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' btnConfigurar
        ' 
        btnConfigurar.Location = New Point(176, 52)
        btnConfigurar.Name = "btnConfigurar"
        btnConfigurar.Size = New Size(150, 34)
        btnConfigurar.TabIndex = 1
        btnConfigurar.Text = "Configurar página"
        btnConfigurar.UseVisualStyleBackColor = True
        ' 
        ' btnVistaPrevia
        ' 
        btnVistaPrevia.Location = New Point(336, 52)
        btnVistaPrevia.Name = "btnVistaPrevia"
        btnVistaPrevia.Size = New Size(150, 34)
        btnVistaPrevia.TabIndex = 2
        btnVistaPrevia.Text = "Vista previa"
        btnVistaPrevia.UseVisualStyleBackColor = True
        ' 
        ' btnImprimir
        ' 
        btnImprimir.Location = New Point(496, 52)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New Size(150, 34)
        btnImprimir.TabIndex = 3
        btnImprimir.Text = "Imprimir"
        btnImprimir.UseVisualStyleBackColor = True
        ' 
        ' dgvAlumnos
        ' 
        dgvAlumnos.AllowUserToAddRows = False
        dgvAlumnos.AllowUserToDeleteRows = False
        dgvAlumnos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlumnos.Location = New Point(16, 96)
        dgvAlumnos.Name = "dgvAlumnos"
        dgvAlumnos.ReadOnly = True
        dgvAlumnos.RowHeadersVisible = False
        dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAlumnos.Size = New Size(868, 420)
        dgvAlumnos.TabIndex = 4
        ' 
        ' lblEstado
        ' 
        lblEstado.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(16, 528)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(106, 15)
        lblEstado.TabIndex = 5
        lblEstado.Text = "Sin datos cargados"
        ' 
        ' pdReporte
        ' 
        pdReporte.DocumentName = "Listado de alumnos"
        ' 
        ' ppdVista
        ' 
        ppdVista.AutoScrollMargin = New Size(0, 0)
        ppdVista.AutoScrollMinSize = New Size(0, 0)
        ppdVista.ClientSize = New Size(400, 300)
        ppdVista.Document = pdReporte
        ppdVista.Enabled = True
        ppdVista.Icon = CType(resources.GetObject("ppdVista.Icon"), Icon)
        ppdVista.Name = "ppdVista"
        ppdVista.UseAntiAlias = True
        ppdVista.Visible = False
        ' 
        ' psdPagina
        ' 
        psdPagina.Document = pdReporte
        psdPagina.EnableMetric = True
        ' 
        ' dlgImprimir
        ' 
        dlgImprimir.Document = pdReporte
        dlgImprimir.UseEXDialog = True
        ' 
        ' cboCarrera
        ' 
        cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList
        cboCarrera.DropDownWidth = 200
        cboCarrera.FormattingEnabled = True
        cboCarrera.Location = New Point(652, 59)
        cboCarrera.Name = "cboCarrera"
        cboCarrera.Size = New Size(121, 23)
        cboCarrera.TabIndex = 6
        ' 
        ' chkHorizontal
        ' 
        chkHorizontal.AutoSize = True
        chkHorizontal.Location = New Point(790, 61)
        chkHorizontal.Name = "chkHorizontal"
        chkHorizontal.Size = New Size(81, 19)
        chkHorizontal.TabIndex = 7
        chkHorizontal.Text = "Horizontal"
        chkHorizontal.UseVisualStyleBackColor = True
        ' 
        ' FrmReporte
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 560)
        Controls.Add(chkHorizontal)
        Controls.Add(cboCarrera)
        Controls.Add(lblTitulo)
        Controls.Add(btnCargar)
        Controls.Add(btnConfigurar)
        Controls.Add(btnVistaPrevia)
        Controls.Add(btnImprimir)
        Controls.Add(dgvAlumnos)
        Controls.Add(lblEstado)
        MinimumSize = New Size(760, 480)
        Name = "FrmReporte"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reporte de alumnos – PrintDocument"
        CType(dgvAlumnos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents btnConfigurar As System.Windows.Forms.Button
    Friend WithEvents btnVistaPrevia As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents pdReporte As System.Drawing.Printing.PrintDocument
    Friend WithEvents ppdVista As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents psdPagina As System.Windows.Forms.PageSetupDialog
    Friend WithEvents dlgImprimir As System.Windows.Forms.PrintDialog
    Friend WithEvents cboCarrera As ComboBox
    Friend WithEvents chkHorizontal As CheckBox
End Class
