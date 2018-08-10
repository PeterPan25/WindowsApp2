Public Class AktuellerBenutzer
    Dim Benutzer As String

    Public Sub Benutzer_angemeldet(AB As String)
        Benutzer = AB
        Form1.Label11.Text = Benutzer
    End Sub

    Public Sub Benutzer_abgemeldet()

    End Sub


End Class
