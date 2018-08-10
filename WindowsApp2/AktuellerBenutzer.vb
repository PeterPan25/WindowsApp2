Public Class AktuellerBenutzer
    Public Shared Property Benutzer As String

    Public Sub Benutzer_angemeldet(AB As String)
        Benutzer = AB
        Form1.Label11.Text = Benutzer
    End Sub

    Public Sub Benutzer_abgemeldet()

    End Sub

    Public Function Benutzer_nennen() As String
        Dim B As String = Benutzer
        B = Benutzer
        Return B
    End Function


End Class
