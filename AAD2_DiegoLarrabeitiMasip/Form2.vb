Public Class Form2
    Public Property PeliculaSeleccionada As Peliculas

    Private Sub Pelicula(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblTituloD.Text = PeliculaSeleccionada.Titulo
        Me.lblAnioD.Text = "Año: " & PeliculaSeleccionada.Anio.ToString()
        Me.lblDuracion.Text = PeliculaSeleccionada.Duracion.ToString() & " min"
        Me.lblPrecioD.Text = "Precio: " & PeliculaSeleccionada.Precio.ToString("C2")
        Me.lblSipnosisD.Text = PeliculaSeleccionada.Sinopsis

        If Not String.IsNullOrEmpty(PeliculaSeleccionada.UrlImagen) Then
            Me.PictureBox1.Load(PeliculaSeleccionada.UrlImagen)
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub btVenta_Click(sender As Object, e As EventArgs) Handles btVenta.Click
        Dim ventanaVenta As New Form3()
        ventanaVenta.PeliculaSeleccionada = PeliculaSeleccionada
        ventanaVenta.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Me.Close()
    End Sub
End Class