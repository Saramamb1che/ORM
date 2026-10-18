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
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.lblCarrera = New System.Windows.Forms.Label()
        Me.cboCarrera = New System.Windows.Forms.ComboBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.pnlAcciones = New System.Windows.Forms.Panel()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPdf = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.pnlFiltros.SuspendLayout()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pnlFiltros.Controls.Add(Me.lblCarrera)
        Me.pnlFiltros.Controls.Add(Me.cboCarrera)
        Me.pnlFiltros.Controls.Add(Me.btnCargar)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltros.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(900, 56)
        Me.pnlFiltros.TabIndex = 0
        '
        'lblCarrera
        '
        Me.lblCarrera.AutoSize = True
        Me.lblCarrera.Location = New System.Drawing.Point(16, 19)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Text = "Carrera:"
        '
        'cboCarrera
        '
        Me.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCarrera.Location = New System.Drawing.Point(80, 15)
        Me.cboCarrera.Name = "cboCarrera"
        Me.cboCarrera.Size = New System.Drawing.Size(260, 23)
        Me.cboCarrera.TabIndex = 0
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(356, 11)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(150, 32)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Cargar datos"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.AllowUserToAddRows = False
        Me.dgvAlumnos.AllowUserToDeleteRows = False
        Me.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlumnos.Location = New System.Drawing.Point(0, 56)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.ReadOnly = True
        Me.dgvAlumnos.RowHeadersVisible = False
        Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlumnos.Size = New System.Drawing.Size(900, 488)
        Me.dgvAlumnos.TabIndex = 1
        '
        'pnlAcciones
        '
        Me.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pnlAcciones.Controls.Add(Me.btnExcel)
        Me.pnlAcciones.Controls.Add(Me.btnPdf)
        Me.pnlAcciones.Controls.Add(Me.lblEstado)
        Me.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAcciones.Location = New System.Drawing.Point(0, 544)
        Me.pnlAcciones.Name = "pnlAcciones"
        Me.pnlAcciones.Size = New System.Drawing.Size(900, 56)
        Me.pnlAcciones.TabIndex = 2
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(16, 11)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(160, 32)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "Exportar a Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnPdf
        '
        Me.btnPdf.Location = New System.Drawing.Point(186, 11)
        Me.btnPdf.Name = "btnPdf"
        Me.btnPdf.Size = New System.Drawing.Size(160, 32)
        Me.btnPdf.TabIndex = 1
        Me.btnPdf.Text = "Exportar a PDF"
        Me.btnPdf.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(366, 19)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Text = "Sin datos cargados"
        '
        'FrmExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.dgvAlumnos)
        Me.Controls.Add(Me.pnlAcciones)
        Me.Controls.Add(Me.pnlFiltros)
        Me.MinimumSize = New System.Drawing.Size(720, 480)
        Me.Name = "FrmExportar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar alumnos – ClosedXML y QuestPDF"
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAcciones.ResumeLayout(False)
        Me.pnlAcciones.PerformLayout()
        Me.ResumeLayout(False)
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
End Class
