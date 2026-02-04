Imports System.Net.Http
Imports System.Text.Json ' Usamos esta librería que es la estándar en .NET actual
Imports System.Threading.Tasks

Public Class Form4
    Private Const usuarioGithub As String = "ryodan14"

    Private Async Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await ObtenerDatosGithub()
    End Sub

    Private Async Function ObtenerDatosGithub() As Task
        Using client As New HttpClient()
            Try
                client.DefaultRequestHeaders.Add("User-Agent", "request")
                Dim response As String = Await client.GetStringAsync("https://api.github.com/users/" & usuarioGithub)
                Dim jsonDoc As JsonDocument = JsonDocument.Parse(response)
                Dim root = jsonDoc.RootElement
                Dim nombre As String = root.GetProperty("login").GetString()
                Dim repos As Integer = root.GetProperty("public_repos").GetInt32()
                Dim urlFoto As String = root.GetProperty("avatar_url").GetString()

                Label1.Text = "Usuario: " & nombre
                Label2.Text = "Repositorios públicos: " & repos
                PictureBox1.Load(urlFoto)
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

            Catch ex As Exception
                MessageBox.Show("Error al conectar con la API: " & ex.Message)
            End Try
        End Using
    End Function


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Process.Start(New ProcessStartInfo("https://github.com/" & usuarioGithub) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el navegador: " & ex.Message)
        End Try
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Me.Close()
    End Sub
End Class