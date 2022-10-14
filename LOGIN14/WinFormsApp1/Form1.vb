Public Class Form1
    Private Sub txtingresar_Click(sender As Object, e As EventArgs) Handles txtingresar.Click
        Dim usuario, password As String

        usuario = txtemail.Text
        password = txtpass.Text

        If (usuario = "tromex156@gmail.com") And (password = "1234") Then
            MsgBox("Bienvenido")
            'form2.show()'

        Else
            MsgBox("Email o password incorrecto")


        End If


    End Sub


End Class
