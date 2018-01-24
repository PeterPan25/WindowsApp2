Public Class Eltern

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.BerichtAnlegen1.ElternBericht()
        Form1.BerichtAnlegen1.Visible = True
        Form1.BerichtAnlegen1.BringToFront()


    End Sub

    Private Sub ElternBerichtDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ElternBerichtDataGridView.RowHeaderMouseClick

        Dim str As String
        Dim str1 As String




        str = Me.ElternBerichtDataGridView.Rows(e.RowIndex).Cells(3).Value
        str1 = Me.ElternBerichtDataGridView.Rows(e.RowIndex).Cells(1).Value

        BerichtAnzeigen.EBDaten_laden(str, str1)

        BerichtAnzeigen.Show()

    End Sub

    Public Sub EBDaten_laden()
        Me.ElternBerichtTableAdapter.Fill(Me.DataSet1.ElternBericht)
        Me.ElternBerichtDataGridView.Update()
    End Sub


    'Private Sub ElternBerichtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBerichtBindingNavigatorSaveItem.Click, MyBaseBerichtBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.ElternBerichtBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
