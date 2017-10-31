Public Class F_Aaliyah


    Private Sub F_Aaliyah_Load(sender As Object, e As EventArgs) Handles Me.Load
        If TextBox1.Text = Nothing Then TextBox1.Text = "Name"
        If TextBox2.Text = Nothing Then TextBox2.Text = "Vorname"
        If TextBox3.Text = Nothing Then TextBox3.Text = "Rolle"
        If TextBox4.Text = Nothing Then TextBox4.Text = "Adresse"
        If TextBox5.Text = Nothing Then TextBox5.Text = "Telefon"
        If TextBox6.Text = Nothing Then TextBox6.Text = "Mail"
        If TextBox7.Text = Nothing Then TextBox7.Text = "Sonstiges"
        TextBox1.ForeColor = Color.Gray
        TextBox2.ForeColor = Color.Gray
        TextBox3.ForeColor = Color.Gray
        TextBox4.ForeColor = Color.Gray
        TextBox5.ForeColor = Color.Gray
        TextBox6.ForeColor = Color.Gray
        TextBox7.ForeColor = Color.Gray

    End Sub

    Private Sub TextBox1_doubleclick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        If TextBox1.Text = "Name" Then TextBox1.Clear()
        TextBox1.ForeColor = Color.Black
    End Sub
    Private Sub TextBox2_doubleclick(sender As Object, e As EventArgs) Handles TextBox2.DoubleClick
        If TextBox2.Text = "Vorname" Then TextBox2.Clear()
        TextBox2.ForeColor = Color.Black
    End Sub
    Private Sub TextBox3_doubleclick(sender As Object, e As EventArgs) Handles TextBox3.DoubleClick
        If TextBox3.Text = "Rolle" Then TextBox3.Clear()
        TextBox3.ForeColor = Color.Black
    End Sub


    Private Sub TextBox4_doubleclick(sender As Object, e As EventArgs) Handles TextBox4.DoubleClick
        If TextBox4.Text = "Adresse" Then TextBox6.Clear()
        TextBox4.ForeColor = Color.Black
    End Sub

    Private Sub TextBox5_doubleclick(sender As Object, e As EventArgs) Handles TextBox5.DoubleClick
        If TextBox5.Text = "Telefon" Then TextBox6.Clear()
        TextBox5.ForeColor = Color.Black
    End Sub
    Private Sub TextBox6_doubleclick(sender As Object, e As EventArgs) Handles TextBox6.DoubleClick, TextBox7.DoubleClick
        If TextBox6.Text = "Mail" Then TextBox6.Clear()
        TextBox6.ForeColor = Color.Black
    End Sub
    Private Sub TextBox7_doubleclick(sender As Object, e As EventArgs) Handles TextBox7.DoubleClick
        If TextBox7.Text = "Sonstiges" Then TextBox6.Clear()
        TextBox7.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim item As New ListViewItem
    'With Kontakte.ListView1.Items.add(Me.TextBox1.Text)
    '    item.SubItems.Add(Me.TextBox2.Text)
    '    item.SubItems.Add(Me.TextBox3.Text)
    '    item.SubItems.Add(Me.TextBox4.Text)
    '    item.SubItems.Add(Me.TextBox5.Text)
    '    item.SubItems.Add(Me.TextBox6.Text)
    '    item.SubItems.Add(Me.TextBox7.Text)
    '    End With
    'End Sub
End Class