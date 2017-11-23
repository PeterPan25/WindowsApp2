Public Class Augenarzt


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow = Me.DataSet1.Augenarzt.NewRow()

        Try
            a("A_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText2.Text
            a("Ort") = PlatzhalterText3.Text
            a("Strasse") = PlatzhalterText4.Text

            Me.DataSet1.Augenarzt.AddAugenarztRow(a)
            Me.AugenarztTableAdapter.Update(Me.DataSet1)
            Me.DatenLaden()

        Catch ex As Exception
            MsgBox("Schade")
        End Try


    End Sub


    Private Sub DatenLaden()

        Me.AugenarztDataGridView.Update()

    End Sub
    'Private Sub AugenarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.AugenarztBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
