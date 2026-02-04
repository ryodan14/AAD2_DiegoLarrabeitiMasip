Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Principal
    Dim connectionString As String = "server=localhost;database=CINE;user=root;password=;"

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPeliculas()
    End Sub

    Private Sub CargarPeliculas()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM PELICULA ", conn)
            Dim reader = cmd.ExecuteReader()
            Dim i As Integer = 1

            While reader.Read()
                Dim p As New Peliculas()
                p.Titulo = reader("titulo").ToString()
                p.Anio = Convert.ToInt32(reader("AnioEstreno"))
                p.Duracion = Convert.ToInt32(reader("Duracion"))
                p.Sinopsis = reader("sinopsis").ToString()
                p.UrlImagen = reader("url_imagen")
                p.Precio = reader("precio")
                p.EntradasDisponibles = Convert.ToInt32(reader("CantidadEntradas"))
                Dim pb As PictureBox = Me.Controls.Find("PictureBox" & i, True).FirstOrDefault()
                If pb IsNot Nothing Then
                    pb.Tag = p
                    pb.Load(reader("url_imagen").ToString())
                End If
                i += 1
            End While
        End Using
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click
        Dim pb = DirectCast(sender, PictureBox)
        Dim p = DirectCast(pb.Tag, Peliculas)
        Dim ventana As New Form2()
        ventana.PeliculaSeleccionada = p
        ventana.Show()
    End Sub

    Private Sub btCreditos_Click(sender As Object, e As EventArgs) Handles btCreditos.Click
        Form4.ShowDialog()
    End Sub
End Class