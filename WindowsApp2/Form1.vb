Public Class Form1
    Dim form() As Form

    Private Sub B_öffnen_Click(sender As Object, e As EventArgs) Handles B_öffnen.Click
        Dim name As String
        name = "F" + TextBox1.Text
        form(name) = New Windows.Forms.Form(name)

        form.show()



    End Sub
End Class
