Public Class Formulare
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If PictureBox1.Image = ImageList1.Images.Item(0) Then
            Process.Start("Z:\Software\Formularvorlagen\Ämterplan.doc")
        Else
            PictureBox1.Image = ImageList1.Images.Item(0)
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        PictureBox1.Image = ImageList1.Images.Item(1)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        PictureBox1.Image = ImageList1.Images.Item(2)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        PictureBox1.Image = ImageList1.Images.Item(3)
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        PictureBox1.Image = ImageList1.Images.Item(4)
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        PictureBox1.Image = ImageList1.Images.Item(5)
    End Sub
End Class
