Public Class Benutzer
    Private Sub MitarbeiterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MitarbeiterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Public Sub Daten_Load()
        Me.MitarbeiterTableAdapter.Fill(DataSet1.Mitarbeiter)
        Me.MitarbeiterDataGridView.Update()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataSet1.MitarbeiterRow
        Dim Vname As String
        Dim Nname As String

        Vname = MitarbeiterDataGridView.SelectedRows.Item(0).Cells(0).Value
        Nname = MitarbeiterDataGridView.SelectedRows.Item(0).Cells(1).Value

        Try
            a = DataSet1.Mitarbeiter.FindByNachnameVorname(Nname, Vname)

            a.Delete()


            Me.MitarbeiterTableAdapter.Update(Me.DataSet1.Mitarbeiter)

            MitarbeiterDataGridView.Update()

        Catch ex As Exception
            MsgBox("Nöhö")

        End Try
    End Sub
End Class
