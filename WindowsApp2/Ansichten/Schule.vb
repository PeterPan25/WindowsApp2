Public Class Schule
    Private Sub Schule1_Load(sender As Object, e As EventArgs) Handles schule1.Load
        'Dim textbox6 As New TextBox
        If TextBox6.Text Is Nothing Then TextBox6.Text = "Schule"
        TextBox6.ForeColor = Color.Gray
    End Sub

    Private Sub TextBox6_textchanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "Schule" Then TextBox6.Clear()
    End Sub


End Class
