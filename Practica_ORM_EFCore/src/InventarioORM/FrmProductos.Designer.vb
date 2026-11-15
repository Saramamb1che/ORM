<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProductos
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtBuscar = New TextBox()
        btnBuscar = New Button()
        dgvProductos = New DataGridView()
        txtNombre = New TextBox()
        cboCategoria = New ComboBox()
        nudPrecio = New NumericUpDown()
        nudExistencia = New NumericUpDown()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
        lblEstado = New Label()
        lblBuscar = New Label()
        lblNombre = New Label()
        lblCategoria = New Label()
        lblPrecio = New Label()
        lblExistencia = New Label()
        cboFiltroCategoria = New ComboBox()
        chkSoloMenor10 = New CheckBox()
        LbLTotalInventario = New Label()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrecio, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudExistencia, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBuscar.Location = New Point(78, 22)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(696, 23)
        txtBuscar.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscar.Location = New Point(790, 20)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(112, 28)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvProductos
        ' 
        dgvProductos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProductos.Location = New Point(18, 64)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.Size = New Size(884, 270)
        dgvProductos.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtNombre.Location = New Point(88, 356)
        txtNombre.MaxLength = 100
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(380, 23)
        txtNombre.TabIndex = 3
        ' 
        ' cboCategoria
        ' 
        cboCategoria.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategoria.Location = New Point(592, 356)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New Size(310, 23)
        cboCategoria.TabIndex = 4
        ' 
        ' nudPrecio
        ' 
        nudPrecio.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        nudPrecio.DecimalPlaces = 2
        nudPrecio.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        nudPrecio.Location = New Point(88, 398)
        nudPrecio.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        nudPrecio.Name = "nudPrecio"
        nudPrecio.Size = New Size(160, 23)
        nudPrecio.TabIndex = 5
        ' 
        ' nudExistencia
        ' 
        nudExistencia.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        nudExistencia.Location = New Point(376, 398)
        nudExistencia.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudExistencia.Name = "nudExistencia"
        nudExistencia.Size = New Size(160, 23)
        nudExistencia.TabIndex = 6
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnNuevo.Location = New Point(18, 448)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(108, 32)
        btnNuevo.TabIndex = 7
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnGuardar.Location = New Point(138, 448)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(108, 32)
        btnGuardar.TabIndex = 8
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnActualizar.Location = New Point(258, 448)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(108, 32)
        btnActualizar.TabIndex = 9
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnEliminar.Location = New Point(378, 448)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(108, 32)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' lblEstado
        ' 
        lblEstado.Dock = DockStyle.Bottom
        lblEstado.Location = New Point(0, 492)
        lblEstado.Name = "lblEstado"
        lblEstado.Padding = New Padding(12, 6, 0, 0)
        lblEstado.Size = New Size(920, 28)
        lblEstado.TabIndex = 11
        lblEstado.Text = "Listo."
        ' 
        ' lblBuscar
        ' 
        lblBuscar.Location = New Point(18, 25)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(60, 20)
        lblBuscar.TabIndex = 12
        lblBuscar.Text = "Buscar:"
        ' 
        ' lblNombre
        ' 
        lblNombre.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblNombre.Location = New Point(18, 359)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(70, 20)
        lblNombre.TabIndex = 13
        lblNombre.Text = "Nombre:"
        ' 
        ' lblCategoria
        ' 
        lblCategoria.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblCategoria.Location = New Point(512, 359)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(80, 20)
        lblCategoria.TabIndex = 14
        lblCategoria.Text = "Categoría:"
        ' 
        ' lblPrecio
        ' 
        lblPrecio.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblPrecio.Location = New Point(18, 401)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(70, 20)
        lblPrecio.TabIndex = 15
        lblPrecio.Text = "Precio C$:"
        ' 
        ' lblExistencia
        ' 
        lblExistencia.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblExistencia.Location = New Point(280, 401)
        lblExistencia.Name = "lblExistencia"
        lblExistencia.Size = New Size(96, 20)
        lblExistencia.TabIndex = 16
        lblExistencia.Text = "Existencia:"
        ' 
        ' 
        ' 
        ' cboFiltroCategoria
        ' 
        cboFiltroCategoria.FormattingEnabled = True
        cboFiltroCategoria.Location = New Point(535, 448)
        cboFiltroCategoria.Name = "cboFiltroCategoria"
        cboFiltroCategoria.Size = New Size(121, 23)
        cboFiltroCategoria.TabIndex = 18
        ' 
        ' chkSoloMenor10
        ' 
        chkSoloMenor10.AutoSize = True
        chkSoloMenor10.Location = New Point(704, 450)
        chkSoloMenor10.Name = "chkSoloMenor10"
        chkSoloMenor10.Size = New Size(166, 19)
        chkSoloMenor10.TabIndex = 19
        chkSoloMenor10.Text = "Solo existencia menor a 10"
        chkSoloMenor10.UseVisualStyleBackColor = True
        ' 
        ' LbLTotalInventario
        ' 
        LbLTotalInventario.AutoSize = True
        LbLTotalInventario.Location = New Point(535, 492)
        LbLTotalInventario.Name = "LbLTotalInventario"
        LbLTotalInventario.Size = New Size(59, 15)
        LbLTotalInventario.TabIndex = 20
        LbLTotalInventario.Text = "Total: 0.00"
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(920, 520)
        Controls.Add(LbLTotalInventario)
        Controls.Add(chkSoloMenor10)
        Controls.Add(cboFiltroCategoria)
        Controls.Add(lblExistencia)
        Controls.Add(lblPrecio)
        Controls.Add(lblCategoria)
        Controls.Add(lblNombre)
        Controls.Add(lblBuscar)
        Controls.Add(lblEstado)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(nudExistencia)
        Controls.Add(nudPrecio)
        Controls.Add(cboCategoria)
        Controls.Add(txtNombre)
        Controls.Add(dgvProductos)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscar)
        MinimumSize = New Size(936, 559)
        Name = "FrmProductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventario de productos - Librería y Papelería Segovia"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrecio, ComponentModel.ISupportInitialize).EndInit()
        CType(nudExistencia, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents nudPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudExistencia As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents cboFiltroCategoria As ComboBox
    Friend WithEvents chkSoloMenor10 As CheckBox
    Friend WithEvents LbLTotalInventario As Label
End Class
