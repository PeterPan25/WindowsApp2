Public Class Eltern

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.BerichtAnlegen1.ElternBericht()
        Form1.BerichtAnlegen1.Visible = True
        Form1.BerichtAnlegen1.BringToFront()


    End Sub
    'Private Sub ElternBerichtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBerichtBindingNavigatorSaveItem.Click, MyBaseBerichtBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.ElternBerichtBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
