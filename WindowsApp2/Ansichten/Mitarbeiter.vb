Public Class Mitarbeiter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatenAendern()
    End Sub

    Public Sub Daten_Load()
        Me.TableAdapterManager.MitarbeiterTableAdapter.Fill(DataSet1.Mitarbeiter)
    End Sub

    Private Sub DatenAendern()
        Dim a As DataSet1.MitarbeiterRow
        a = Me.DataSet1.Mitarbeiter.FindByNachnameVorname(PlatzhalterText2.Text, PlatzhalterText1.Text)

        Try
            a.Benutzername = PlatzhalterText3.Text
            a.Vorname = PlatzhalterText1.Text
            a.Nachname = PlatzhalterText2.Text
            a.Passwort = PlatzhalterText4.Text
            'so auch mit den weiteren Eigenschaften
            Me.MitarbeiterTableAdapter.Update(Me.DataSet1.Mitarbeiter)

            MsgBox("Jou")

        Catch ex As Exception
            MsgBox("Nöhö")
        End Try

    End Sub
    Public Sub First()
        Dim a As DataRow
        a = DataSet1.Mitarbeiter.NewRow()

        Try
            a("Benutzername") = "a"
            a("Passwort") = "a"
            a("Vorname") = "Peter"
            a("Nachname") = "Hans"
            DataSet1.Mitarbeiter.AddMitarbeiterRow(a)
            Me.MitarbeiterTableAdapter.Update(Me.DataSet1.Mitarbeiter)
        Catch ex As Exception
            MsgBox("n")
        End Try
    End Sub

End Class
