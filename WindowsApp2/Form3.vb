Public Class F_Peter
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim name As String
        name = ComboBox1.Text

        If name = SplitContainer1.Name Then
            SplitContainer1.Show()
        ElseIf name = SplitContainer2.Name Then
            SplitContainer2.Show()
        ElseIf name = SplitContainer3.Name Then
            SplitContainer3.Show()
        End If
    End Sub
End Class