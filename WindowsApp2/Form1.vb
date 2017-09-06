Public Class Form1
    Dim form() As Form

    Private Sub B_öffnen_Click(sender As Object, e As EventArgs) Handles B_öffnen.Click
        Dim name As String
        name = "F_" + TextBox1.Text
        form(name).Show()



    End Sub
End Class
