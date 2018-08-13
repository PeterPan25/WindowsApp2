Public Class Bericht
    'Private Sub BerichtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.BerichtBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)***********

    'End Sub




    Public Sub Daten_laden()
        Me.BerichtTableAdapter.Fill(DataSet1.Bericht)

        Me.BerichtDataGridView.Update()


    End Sub


    Public Sub BerichtKind()
        Dim str2 As String
        Dim r1() As DataRow
        str2 = Form1.CB_name.Text


        r1 = DataSet1.Bericht.Select("Kind = '" & str2 & "'")
        Me.BerichtDataGridView.DataSource = r1
    End Sub



    Private Sub BerichtDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BerichtDataGridView.RowHeaderMouseClick
        Dim str As String
        Dim str1 As String



        '  Me.BerichtDataGridView.Rows(e.RowIndex).Selected = True

        str = Me.BerichtDataGridView.Rows(e.RowIndex).Cells(1).Value
        str1 = Me.BerichtDataGridView.Rows(e.RowIndex).Cells(2).Value

        BerichtAnzeigen.Show()
        BerichtAnzeigen.Daten_laden(str, str1)


    End Sub
End Class
