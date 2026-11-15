<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategorias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitulo = New Label()
        lblNombre = New Label()
        txtNombre = New TextBox()
        dgvCategorias = New DataGridView()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
        btnCerrar = New Button()
        CType(dgvCategorias, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(320, 9)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(120, 15)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Gestión de categorías"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(12, 55)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(119, 15)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre de categoría"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(12, 73)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(776, 23)
        txtNombre.TabIndex = 2
        ' 
        ' dgvCategorias
        ' 
        dgvCategorias.AllowUserToAddRows = False
        dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCategorias.Location = New Point(12, 256)
        dgvCategorias.MultiSelect = False
        dgvCategorias.Name = "dgvCategorias"
        dgvCategorias.ReadOnly = True
        dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCategorias.Size = New Size(776, 182)
        dgvCategorias.TabIndex = 3
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(96, 125)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 4
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(348, 125)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 5
        btnGuardar.Text = " Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(628, 125)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(75, 23)
        btnActualizar.TabIndex = 6
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(96, 214)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 7
        btnEliminar.Text = "Eliminar "
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(348, 214)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(75, 23)
        btnCerrar.TabIndex = 8
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' FrmCategorias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCerrar)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(dgvCategorias)
        Controls.Add(txtNombre)
        Controls.Add(lblNombre)
        Controls.Add(lblTitulo)
        Name = "FrmCategorias"
        Text = "FrmCategorias"
        CType(dgvCategorias, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dgvCategorias As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCerrar As Button
End Class
