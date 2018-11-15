Public Class Mitarbeiter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatenAendern()
    End Sub

    Private Sub DatenAendern()
        Dim a As DataSet1.MitarbeiterRow
        a = Me.DataSet1.Mitarbeiter.FindByNachnameVorname(PlatzhalterText2.Text, PlatzhalterText1.Text)

        Try
            a.Benutzername = PlatzhalterText3.Text
            a.Vorname = PlatzhalterText1.Text
            a.Nachname = PlatzhalterText2.Text
            a.Passwort = PlatzhalterText4.Text

            Me.MitarbeiterTableAdapter.Update(Me.DataSet1.Mitarbeiter)

            MsgBox("Jou")

        Catch ex As Exception
            MsgBox("Nöhö")
        End Try

    End Sub

End Class
