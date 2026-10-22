Imports Microsoft.EntityFrameworkCore

Public Class FrmCategorias
    Private categoriaSeleccionadaId As Integer = 0

    Private Async Sub FrmCategorias_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        dgvCategorias.ReadOnly = True
        dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCategorias.MultiSelect = False
        dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Await CargarCategoriasAsync()


    End Sub

    Private Async Function CargarCategoriasAsync() As Task

        Try
            Using db As New AppDbContext()

                Dim lista = Await db.Categorias.
                    AsNoTracking().
                    OrderBy(Function(c) c.Nombre).
                    Select(Function(c) New With {
                        .Id = c.Id,
                        .Nombre = c.Nombre
                    }).
                    ToListAsync()

                dgvCategorias.DataSource = lista

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Error al cargar categorías: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Function

    Private Sub dgvCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellClick

        If e.RowIndex < 0 Then Return

        Dim fila = dgvCategorias.Rows(e.RowIndex)

        categoriaSeleccionadaId = Convert.ToInt32(fila.Cells("Id").Value)
        txtNombre.Text = fila.Cells("Nombre").Value.ToString()

    End Sub
    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nombre As String = txtNombre.Text.Trim()

        If nombre = "" Then
            MessageBox.Show("Ingrese el nombre de la categoría.")
            txtNombre.Focus()
            Return
        End If

        If nombre.Length > 60 Then
            MessageBox.Show("El nombre no puede superar los 60 caracteres.")
            Return
        End If

        Try
            btnGuardar.Enabled = False

            Using db As New AppDbContext()

                Dim existe = Await db.Categorias.AnyAsync(
                    Function(c) c.Nombre = nombre)

                If existe Then
                    MessageBox.Show("Esta categoría ya existe.")
                    Return
                End If

                Dim nueva As New Categoria With {
                    .Nombre = nombre
                }

                db.Categorias.Add(nueva)
                Await db.SaveChangesAsync()

            End Using

            MessageBox.Show("Categoría registrada correctamente.")

            txtNombre.Clear()
            Await CargarCategoriasAsync()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)

        Finally
            btnGuardar.Enabled = True
        End Try

    End Sub
    Private Async Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        If categoriaSeleccionadaId = 0 Then
            MessageBox.Show("Seleccione una categoría.")
            Return
        End If

        Dim nombre As String = txtNombre.Text.Trim()

        If nombre = "" OrElse nombre.Length > 60 Then
            MessageBox.Show("Ingrese un nombre válido de máximo 60 caracteres.")
            Return
        End If

        Try
            btnActualizar.Enabled = False

            Using db As New AppDbContext()

                Dim categoria = Await db.Categorias.FindAsync(categoriaSeleccionadaId)

                If categoria Is Nothing Then
                    MessageBox.Show("La categoría ya no existe.")
                    Return
                End If

                Dim duplicado = Await db.Categorias.AnyAsync(
                    Function(c) c.Nombre = nombre AndAlso c.Id <> categoriaSeleccionadaId)

                If duplicado Then
                    MessageBox.Show("Ya existe otra categoría con ese nombre.")
                    Return
                End If

                categoria.Nombre = nombre
                Await db.SaveChangesAsync()

            End Using

            MessageBox.Show("Categoría actualizada correctamente.")

            categoriaSeleccionadaId = 0
            txtNombre.Clear()

            Await CargarCategoriasAsync()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message)

        Finally
            btnActualizar.Enabled = True
        End Try

    End Sub
    Private Async Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If categoriaSeleccionadaId = 0 Then
            MessageBox.Show("Seleccione una categoría para eliminar.")
            Return
        End If

        Try
            btnEliminar.Enabled = False

            Using db As New AppDbContext()

                ' Verificar cuántos productos tiene la categoría
                Dim cantidad = Await db.Productos.CountAsync(
                    Function(p) p.CategoriaId = categoriaSeleccionadaId)

                If cantidad > 0 Then
                    MessageBox.Show(
                        "No se puede eliminar esta categoría porque tiene " &
                        cantidad & " productos asociados.",
                        "Eliminación no permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
                    Return
                End If

                Dim respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar esta categoría?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)

                If respuesta <> DialogResult.Yes Then Return

                Dim categoria = Await db.Categorias.FindAsync(categoriaSeleccionadaId)

                If categoria Is Nothing Then
                    MessageBox.Show("La categoría ya no existe.")
                    Return
                End If

                db.Categorias.Remove(categoria)
                Await db.SaveChangesAsync()

            End Using

            MessageBox.Show("Categoría eliminada correctamente.")

            categoriaSeleccionadaId = 0
            txtNombre.Clear()

            Await CargarCategoriasAsync()

        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)

        Finally
            btnEliminar.Enabled = True
        End Try

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        categoriaSeleccionadaId = 0
        txtNombre.Clear()
        dgvCategorias.ClearSelection()
        txtNombre.Focus()

    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Close()

    End Sub

End Class