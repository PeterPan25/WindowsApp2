Public Class F_Hans
    Dim vorname As System.String
    Dim nachname As System.String
    Dim datum As System.String
    Dim schule As System.String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = vorname
        TextBox2.Text = nachname
        TextBox3.Text = schule
        TextBox4.Text = datum
    End Sub
End Class