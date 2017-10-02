Public Class Formulare
    Dim d(6) As String




    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'If PictureBox1.Image = ImageList1.Images.Item(0) Then
        '    Process.Start("Z:\Software\Formularvorlagen\Ämterplan.doc")
        'Else
        '    PictureBox1.Image = ImageList1.Images.Item(0)
        'End If
        PictureBox1.Image = ImageList1.Images.Item(0)
        Process.Start(fileName:="E:\a.mp3")


    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        PictureBox1.Image = ImageList1.Images.Item(1)
        PictureBox1.Image.Tag = 1
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        PictureBox1.Image = ImageList1.Images.Item(2)
        PictureBox1.Image.Tag = 2
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        PictureBox1.Image = ImageList1.Images.Item(3)
        PictureBox1.Image.Tag = 3
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        PictureBox1.Image = ImageList1.Images.Item(4)
        PictureBox1.Image.Tag = 4
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        PictureBox1.Image = ImageList1.Images.Item(5)
        PictureBox1.Image.Tag = 5
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim i As Integer


        d(0) = "E:\a.mp3"
        d(1) = "E:\b.mp3"
        d(2) = "E:\c.mp3"
        d(3) = "E:\d.mp3"
        d(4) = "E:\e.mp3"
        d(5) = "E:\f.mp3"




        For i = 0 To 5
            ' ImageList1.Images.Keys(i) =
            If PictureBox1.Image.Tag = i Then
                Process.Start(fileName:=d(i))
            End If
        Next



    End Sub
End Class
