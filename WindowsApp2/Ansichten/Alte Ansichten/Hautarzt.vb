Public Class Hautarzt


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow = Me.DataSet1.Hautarzt.NewRow()


        Try
            a("H_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText2.Text
            a("Ort") = PlatzhalterText3.Text
            a("Strasse") = PlatzhalterText4.Text
            a("Art") = Überschrift.Text
            a("Telefon") = PlatzhalterText5.Text

            Me.DataSet1.Hautarzt.AddHautarztRow(a)
            Me.HautarztTableAdapter.Update(DataSet1)

            Me.DatenLaden

        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub DatenLaden()
        Me.HautarztTableAdapter.Fill(Me.DataSet1.Hautarzt)
        Me.HautarztDataGridView.Update()
    End Sub
    'Private Sub HautarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.HautarztBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
