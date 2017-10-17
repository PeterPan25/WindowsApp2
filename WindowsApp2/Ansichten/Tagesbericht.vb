Public Class Tagesbericht
    Public Function ListViewSave(ByRef LstVw As ListView, ByVal Path As String)
        Dim ListViewContent As String = ""
        For I As Integer = 0 To LstVw.Items.Count - 1
            ListViewContent += LstVw.Items.Item(I).Text & "##"
            For Int As Integer = 0 To LstVw.Items.Item(I).SubItems().Count - 1
                ListViewContent += LstVw.Items.Item(I).SubItems(Int).Text & "##"
            Next
            ListViewContent += vbNewLine
        Next
        If System.IO.File.Exists(Path) Then
            System.IO.File.Delete(Path)
        End If
        System.IO.File.AppendAllText(Path, ListViewContent)
    End Function



    Private Sub Label1_load(sender As Object, e As EventArgs)
        Label16.Text = Now.Date


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With ListView1.Items.Add(InputBox("Name des Kindes"))
            .SubItems.Add(InputBox("Was war heute los?"))
            .SubItems.Add(InputBox("Ist das besonders wichtig?"))
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListViewSave(ListView1, "C: \Users\Regina\Desktop\nicht öffnen\Tagesdoku")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListView1.SelectedItems.Item(0).Remove()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'ListView1.LabelEdit = True
        'ListView1.SelectedItems.

    End Sub
End Class
