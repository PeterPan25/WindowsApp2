Public Class AktuellerBenutzer
    Public Shared Property Benutzer As String

    ' Setzt den aktuellen Benutzer

    Public Sub Benutzer_angemeldet(AB As String)
        Benutzer = AB
        Form1.Label11.Text = Benutzer





        '  Form1.ToolStripLabel1.Text = "Eingeloggt als:" + " " + Benutzer
    End Sub

    ' Meldet den Benutzer ab, sperrt die relevanten Bereiche und wechselt auf die Login Ansicht

    Public Sub Benutzer_abgemeldet()

        Benutzer = ""
        Form1.CB_name.Enabled = False
        Form1.Label11.Visible = False
        Form1.Label1.Visible = False
        Form1.Label2.Visible = False
        Form1.Label3.Visible = False

        Form1.Label4.Visible = False
        Form1.Label5.Visible = False
        Form1.Label6.Visible = False
        Form1.Button2.Visible = False
        Form1.TreeView1.Enabled = False
        Form1.Splitcontainer2.Panel1Collapsed = True
        Form1.LogoutButton.Visible = False
        Form1.UserControl11.Visible = True
        Form1.UserControl11.BringToFront()
        Form1.Label11.Text = Benutzer


    End Sub

    ' Liefert den aktuellen Benutzer anhand des in der Datenbank vorhandenen "Benutzername", sodass weitere Eigenschaften des Mitarbeiters abgefragt werden können

    Public Function Benutzer_nennen() As String
        Dim B As String = Benutzer
        B = Benutzer
        Return B
    End Function


End Class
