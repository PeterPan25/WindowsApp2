Public Class Frauenarzt


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow = Me.DataSet1.Frauenarzt.NewRow()

        Try
            a("F_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText2.Text
            a("Ort") = PlatzhalterText3.Text
            a("Strasse") = PlatzhalterText4.Text
            a("Art") = Überschrift.Text
            Me.DataSet1.Frauenarzt.AddFrauenarztRow(a)
            Me.FrauenarztTableAdapter.Update(Me.DataSet1)
            Me.DatenLaden()

        Catch ex As Exception
            MsgBox("Schade")
        End Try


    End Sub


    Private Sub DatenLaden()
        ' Me.FrauenarztTableAdapter.Fill(DataSet1.Frauenarzt)
        Me.FrauenarztDataGridView.Update()

    End Sub


    'Private Sub FrauenarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.FrauenarztBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
