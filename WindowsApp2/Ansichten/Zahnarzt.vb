Public Class Zahnarzt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow = Me.DataSet1.Zahnarzt.NewRow()

        Try
            a("Z_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText2.Text
            a("Ort") = PlatzhalterText3.Text
            a("Strasse") = PlatzhalterText4.Text

            Me.DataSet1.Zahnarzt.AddZahnarztRow(a)
            Me.ZahnarztTableAdapter.Update(Me.DataSet1)
            Me.DatenLaden()

        Catch ex As Exception
            MsgBox("Schade")
        End Try


    End Sub


    Private Sub DatenLaden()
        ' Me.FrauenarztTableAdapter.Fill(DataSet1.Frauenarzt)
        Me.ZahnarztDataGridView.Update()

    End Sub

    'Private Sub ZahnarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.ZahnarztBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
