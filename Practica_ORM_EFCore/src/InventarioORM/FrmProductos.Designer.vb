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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.nudPrecio = New System.Windows.Forms.NumericUpDown()
        Me.nudExistencia = New System.Windows.Forms.NumericUpDown()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblExistencia = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.txtBuscar.Location = New System.Drawing.Point(78, 22)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(696, 23)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Location = New System.Drawing.Point(790, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 28)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.UseVisualStyleBackColor = True
        Me.dgvProductos.Location = New System.Drawing.Point(18, 64)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(884, 270)
        Me.dgvProductos.TabIndex = 2
        Me.dgvProductos.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(88, 356)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(380, 23)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.cboCategoria.Location = New System.Drawing.Point(592, 356)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(310, 23)
        Me.cboCategoria.TabIndex = 4
        Me.cboCategoria.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.nudPrecio.Location = New System.Drawing.Point(88, 398)
        Me.nudPrecio.Name = "nudPrecio"
        Me.nudPrecio.Size = New System.Drawing.Size(160, 23)
        Me.nudPrecio.TabIndex = 5
        Me.nudPrecio.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.nudExistencia.Location = New System.Drawing.Point(376, 398)
        Me.nudExistencia.Name = "nudExistencia"
        Me.nudExistencia.Size = New System.Drawing.Size(160, 23)
        Me.nudExistencia.TabIndex = 6
        Me.nudExistencia.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Location = New System.Drawing.Point(18, 448)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(108, 32)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.UseVisualStyleBackColor = True
        Me.btnGuardar.Location = New System.Drawing.Point(138, 448)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 32)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.UseVisualStyleBackColor = True
        Me.btnActualizar.Location = New System.Drawing.Point(258, 448)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(108, 32)
        Me.btnActualizar.TabIndex = 9
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.UseVisualStyleBackColor = True
        Me.btnEliminar.Location = New System.Drawing.Point(378, 448)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 32)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.UseVisualStyleBackColor = True
        Me.lblEstado.Location = New System.Drawing.Point(0, 492)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(920, 28)
        Me.lblEstado.TabIndex = 11
        Me.lblEstado.Text = "Listo."
        Me.lblBuscar.Location = New System.Drawing.Point(18, 25)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(60, 20)
        Me.lblBuscar.TabIndex = 12
        Me.lblBuscar.Text = "Buscar:"
        Me.lblNombre.Location = New System.Drawing.Point(18, 359)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(70, 20)
        Me.lblNombre.TabIndex = 13
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.lblCategoria.Location = New System.Drawing.Point(512, 359)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(80, 20)
        Me.lblCategoria.TabIndex = 14
        Me.lblCategoria.Text = "Categoría:"
        Me.lblCategoria.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.lblPrecio.Location = New System.Drawing.Point(18, 401)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(70, 20)
        Me.lblPrecio.TabIndex = 15
        Me.lblPrecio.Text = "Precio C$:"
        Me.lblPrecio.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.lblExistencia.Location = New System.Drawing.Point(280, 401)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(96, 20)
        Me.lblExistencia.TabIndex = 16
        Me.lblExistencia.Text = "Existencia:"
        Me.lblExistencia.Anchor = CType(System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left, System.Windows.Forms.AnchorStyles)
        Me.txtNombre.MaxLength = 100
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nudPrecio.DecimalPlaces = 2
        Me.nudPrecio.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nudPrecio.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudExistencia.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.lblEstado.AutoSize = False
        Me.lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblEstado.Padding = New System.Windows.Forms.Padding(12, 6, 0, 0)
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 520)
        Me.Controls.Add(Me.lblExistencia)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.nudExistencia)
        Me.Controls.Add(Me.nudPrecio)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.MinimumSize = New System.Drawing.Size(936, 559)
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de productos - Librería y Papelería Segovia"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
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
End Class
