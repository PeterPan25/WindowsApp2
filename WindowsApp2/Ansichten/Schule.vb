Public Class Schule
    Private Sub Schule1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If TextBox6.Text = Nothing Then TextBox6.Text = "Schule"
        TextBox6.ForeColor = Color.Gray
    End Sub

    Private Sub TextBox6_doubleclick(sender As Object, e As EventArgs) Handles TextBox6.DoubleClick
        If TextBox6.Text = "Schule" Then TextBox6.Clear()
        TextBox6.ForeColor = Color.Black
    End Sub


End Class
