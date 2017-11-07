Public Class Krankenhaus
    'Private Sub KindKontakteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.KindKontakteBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub

    Public Sub Daten1_laden()

        Me.KindKontakteTableAdapter.FillBy(Me.DataSet1.KindKontakte)

        Dim data2 As New DataTable
        data2 = Me.DataSet1.KindKontakte




        Me.KindKontakteDataGridView.Update()
    End Sub



    'Private Sub KindKontakteBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.KindKontakteBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
