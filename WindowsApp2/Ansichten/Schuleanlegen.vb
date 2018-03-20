Public Class Schuleanlegen
    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As DataRow
        a = Me.DataSet1.Schule.NewRow()

        Try
            a("S_Name") = PlatzhalterText1.Text
            a("Schulart") = PlatzhalterText2.Text
            a("Strasse") = PlatzhalterText3.Text
            a("Plz") = PlatzhalterText4.Text
            a("Ort") = PlatzhalterText5.Text
            a("Klasse") = PlatzhalterText6.Text
            a("Klassenlehrer") = PlatzhalterText7.Text
            a("vDatum") = DateTimePicker1.Value
            a("bDatum") = DateTimePicker2.Value

            Me.DataSet1.Schule.AddSchuleRow(a)
            Me.SchuleTableAdapter.Update(Me.DataSet1.Schule)
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)
            Me.SchuleDataGridView.Update()


            MsgBox("Speichern erfolgreich")

        Catch ex As Exception
            MsgBox("Speichern fehlgeschlagen")

        End Try
    End Sub

    Private Sub SchuleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SchuleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub
End Class
