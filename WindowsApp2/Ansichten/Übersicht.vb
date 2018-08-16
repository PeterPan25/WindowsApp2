Public Class Übersicht


    Public Sub Daten()
        Dim AB As New AktuellerBenutzer

        Label1.Text = "Moin " + AB.Benutzer_nennen
    End Sub
End Class
