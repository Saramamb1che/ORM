Imports System.IO
Imports QuestPDF.Fluent
Imports QuestPDF.Helpers
Imports QuestPDF.Infrastructure

' Genera un PDF con el listado de alumnos.
' Usa QuestPDF: el documento se describe con código (encabezado, contenido y pie).
Module ExportadorPdf

    Private Const AZUL As String = "#0A3A7A"
    Private Const GRIS As String = "#4A5568"
    Private Const TINTA As String = "#16233A"
    Private Const BORDE As String = "#D5DCE6"
    Private Const ALTERNO As String = "#F4F7FB"
    Private Const ROJO As String = "#B3261E"

    Public Sub Exportar(tabla As DataTable, carrera As String, ruta As String, rutaLogo As String)
        Dim documento = Document.Create(
            Sub(contenedor)
                contenedor.Page(
                    Sub(pagina)
                        pagina.Size(PageSizes.Letter)
                        pagina.Margin(1.5F, Unit.Centimetre)
                        pagina.DefaultTextStyle(Function(estilo) estilo.FontSize(9).FontColor(TINTA))

                        pagina.Header().Element(Sub(c) ComponerEncabezado(c, carrera, rutaLogo))
                        pagina.Content().PaddingVertical(10).Element(Sub(c) ComponerTabla(c, tabla))
                        pagina.Footer().Element(Sub(c) ComponerPie(c))
                    End Sub)
            End Sub)

        documento.GeneratePdf(ruta)
    End Sub

    ' Logo + textos, con una línea azul debajo
    Private Sub ComponerEncabezado(c As IContainer, carrera As String, rutaLogo As String)
        c.BorderBottom(1.5F).BorderColor(AZUL).PaddingBottom(6).Row(
            Sub(fila)
                fila.Spacing(12)
                If File.Exists(rutaLogo) Then
                    fila.ConstantItem(70).Height(40).Image(rutaLogo).FitArea()
                End If
                fila.RelativeItem().Column(
                    Sub(col)
                        col.Item().Text("Universidad Nacional de Ingeniería").FontSize(8).FontColor(GRIS)
                        col.Item().Text("Listado de alumnos").FontSize(16).Bold().FontColor(AZUL)
                        col.Item().Text("Carrera: " & carrera & "    Generado: " &
                                        Date.Now.ToString("dd/MM/yyyy HH:mm")).FontSize(8).FontColor(GRIS)
                    End Sub)
            End Sub)
    End Sub

    ' Tabla de alumnos: el encabezado se repite en cada página automáticamente
    Private Sub ComponerTabla(c As IContainer, tabla As DataTable)
        c.Table(
            Sub(t)
                t.ColumnsDefinition(
                    Sub(columnas)
                        columnas.ConstantColumn(75)     ' Carnet
                        columnas.RelativeColumn(2)      ' Nombres
                        columnas.RelativeColumn(2)      ' Apellidos
                        columnas.RelativeColumn(2.4F)   ' Carrera
                        columnas.ConstantColumn(55)     ' Promedio
                    End Sub)

                t.Header(
                    Sub(encabezado)
                        For Each titulo As String In {"Carnet", "Nombres", "Apellidos", "Carrera"}
                            encabezado.Cell().Background(AZUL).Padding(4).Text(titulo).Bold().FontColor(Colors.White)
                        Next
                        encabezado.Cell().Background(AZUL).Padding(4).AlignRight().Text("Promedio").Bold().FontColor(Colors.White)
                    End Sub)

                Dim i As Integer = 0
                For Each fila As DataRow In tabla.Rows
                    Dim fondo As String = If(i Mod 2 = 1, ALTERNO, "#FFFFFF")
                    Dim promedio As Decimal = CDec(fila("promedio"))

                    Celda(t.Cell(), fondo).Text(fila("carnet").ToString())
                    Celda(t.Cell(), fondo).Text(fila("nombres").ToString())
                    Celda(t.Cell(), fondo).Text(fila("apellidos").ToString())
                    Celda(t.Cell(), fondo).Text(fila("carrera").ToString())
                    Celda(t.Cell(), fondo).AlignRight().Text(promedio.ToString("0.00")) _
                        .FontColor(If(promedio < 75D, ROJO, TINTA))
                    i += 1
                Next

                ' Fila de total: 4 columnas combinadas + promedio general
                Dim promedioGeneral As Decimal = CDec(tabla.Compute("AVG(promedio)", ""))
                t.Cell().ColumnSpan(4).BorderTop(1.5F).BorderColor(AZUL).PaddingVertical(4).AlignRight() _
                    .Text($"Total: {tabla.Rows.Count} alumnos    Promedio general:").Bold().FontColor(AZUL)
                t.Cell().BorderTop(1.5F).BorderColor(AZUL).Padding(4).AlignRight() _
                    .Text(promedioGeneral.ToString("0.00")).Bold().FontColor(AZUL)
            End Sub)
    End Sub

    ' Estilo común de las celdas de detalle
    Private Function Celda(c As IContainer, fondo As String) As IContainer
        Return c.Background(fondo).BorderBottom(0.5F).BorderColor(BORDE).PaddingVertical(3).PaddingHorizontal(4)
    End Function

    ' Nombre del curso a la izquierda; "Página N de M" a la derecha
    Private Sub ComponerPie(c As IContainer)
        c.BorderTop(0.5F).BorderColor(BORDE).PaddingTop(4).Row(
            Sub(fila)
                fila.RelativeItem().Text("Programación de Aplicaciones de Escritorio").FontSize(8).FontColor(GRIS)
                fila.RelativeItem().AlignRight().Text(
                    Sub(texto)
                        texto.DefaultTextStyle(Function(estilo) estilo.FontSize(8).FontColor(GRIS))
                        texto.Span("Página ")
                        texto.CurrentPageNumber()
                        texto.Span(" de ")
                        texto.TotalPages()
                    End Sub)
            End Sub)
    End Sub

End Module
