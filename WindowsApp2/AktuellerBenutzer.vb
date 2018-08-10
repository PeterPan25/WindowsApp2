Public Class AktuellerBenutzer
    Dim Benutzer As String

    Public Sub Benutzer_angemeldet(AB As String)
        Benutzer = AB
        Form1.Label11.Text = Benutzer
    End Sub

    Public Sub Benutzer_abgemeldet()

    End Sub

    Public Function Benutzer_nennen()
        Dim B As String = Benutzer

        Return B
    End Function


End Class
