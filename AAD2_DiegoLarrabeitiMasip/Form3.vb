Imports System.IO
Imports MySqlConnector

Public Class Form3
    Public Property PeliculaSeleccionada As Peliculas

    Private Sub btCompra_Click(sender As Object, e As EventArgs) Handles btCompra.Click
        Dim cantidad As Integer = CInt(NumericUpDown1.Value)

        Dim mensajeError As String = PeliculaSeleccionada.ValidarCompra(cantidad)

        If Not String.IsNullOrEmpty(mensajeError) Then
            MessageBox.Show(mensajeError)
            Return
        End If

        Try
            Using sw As StreamWriter = File.AppendText("ventas.txt")
                sw.WriteLine("Película: " & PeliculaSeleccionada.Titulo & " | Cantidad: " & cantidad)
            End Using


            Dim connectionString As String = "server=localhost;database=CINE;user=root;password=;"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "UPDATE PELICULA SET CantidadEntradas = CantidadEntradas - @cantidad WHERE titulo = @titulo"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cantidad", cantidad)
                cmd.Parameters.AddWithValue("@titulo", PeliculaSeleccionada.Titulo)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("¡Gracias por confiar en este cine!")

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error en la operación: " & ex.Message)
        End Try
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class