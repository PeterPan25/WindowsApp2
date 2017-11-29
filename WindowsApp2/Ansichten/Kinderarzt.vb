Public Class Kinderarzt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow = Me.DataSet1.Kinderarzt.NewRow()

        Try
            a("K_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText2.Text
            a("Ort") = PlatzhalterText3.Text
            a("Strasse") = PlatzhalterText4.Text
            a("Art") = Überschrift.Text
            a("Telefon") = PlatzhalterText5.Text

            Me.DataSet1.Kinderarzt.AddKinderarztRow(a)
            Me.KinderarztTableAdapter.Update(Me.DataSet1)
            Me.DatenLaden()

        Catch ex As Exception
            MsgBox("Schade")
        End Try


    End Sub


    Private Sub DatenLaden()
        ' Me.FrauenarztTableAdapter.Fill(DataSet1.Frauenarzt)
        Me.KinderarztDataGridView.Update()


    End Sub
    'Private Sub KinderarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.KinderarztBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
