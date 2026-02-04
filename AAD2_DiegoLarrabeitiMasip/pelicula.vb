Public Class Peliculas
    Public Property Titulo As String
    Public Property Anio As Integer
    Public Property Duracion As Integer
    Public Property Sinopsis As String
    Public Property UrlImagen As String
    Public Property EntradasDisponibles As Integer
    Public Property Precio As Decimal

    Public Function ValidarCompra(cantidad As Integer) As String
        If cantidad > 10 Or cantidad <= 0 Then
            Return "Cantidad no válida. Debe comprar entre 1 y 10 entradas."
        End If


        If cantidad > Me.EntradasDisponibles Then
            Return "No hay suficientes entradas disponibles en esta sala."
        End If

        Me.EntradasDisponibles -= cantidad

        Return String.Empty
    End Function
End Class