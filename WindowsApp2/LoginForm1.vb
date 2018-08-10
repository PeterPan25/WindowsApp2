Public Class LoginForm1

    ' TODO: Code zum Durchführen der benutzerdefinierten Authentifizierung mithilfe des angegebenen Benutzernamens und des Kennworts hinzufügen 
    ' (Siehe https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Der benutzerdefinierte Prinzipal kann anschließend wie folgt an den Prinzipal des aktuellen Threads angefügt werden: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' wobei CustomPrincipal die IPrincipal-Implementierung ist, die für die Durchführung der Authentifizierung verwendet wird. 
    ' Anschließend gibt My.User Identitätsinformationen zurück, die in das CustomPrincipal-Objekt gekapselt sind,
    ' z. B. den Benutzernamen, den Anzeigenamen usw.
    Dim name3 As String() = {"a"}
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Anmelden()



    End Sub

    Private Sub Anmelden()
        Dim name As String = UsernameTextBox.Text
        Dim passwort As String = PasswordTextBox.Text
        Dim ab As New AktuellerBenutzer

        ReDim name3(DataSet1.Mitarbeiter.Rows.Count - 1)
        For z = 0 To (DataSet1.Mitarbeiter.Rows.Count - 1)
            If name = DataSet1.Mitarbeiter.Rows(z)("Benutzername") And passwort = DataSet1.Mitarbeiter.Rows(z)("passwort") Then
                Me.Close()
                Form1.UserControl11.Visible = False
                Form1.Anmelden_erfolgreich()
                ab.Benutzer_angemeldet(name)

            Else

                MsgBox("Schade Benutzer nicht vorhanden oder falsches Passwort")

            End If

        Next

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub MitarbeiterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MitarbeiterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Mitarbeiter". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.MitarbeiterTableAdapter.Fill(Me.DataSet1.Mitarbeiter)

    End Sub
End Class
