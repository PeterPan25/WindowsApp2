Public Class LoginForm2

    ' TODO: Code zum Durchf�hren der benutzerdefinierten Authentifizierung mithilfe des angegebenen Benutzernamens und des Kennworts hinzuf�gen 
    ' (Siehe https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Der benutzerdefinierte Prinzipal kann anschlie�end wie folgt an den Prinzipal des aktuellen Threads angef�gt werden: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' wobei CustomPrincipal die IPrincipal-Implementierung ist, die f�r die Durchf�hrung der Authentifizierung verwendet wird. 
    ' Anschlie�end gibt My.User Identit�tsinformationen zur�ck, die in das CustomPrincipal-Objekt gekapselt sind,
    ' z. B. den Benutzernamen, den Anzeigenamen usw.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ProfilAnlegen()

        Me.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ProfilAnlegen()
        Dim a As DataRow = Me.DataSet1.Mitarbeiter.NewRow()
        Dim b As String = PlatzhalterText1.Text + " " + PlatzhalterText2.Text

        Try
            a("Name") = b
            a("Benutzername") = UsernameTextBox.Text
            a("Passwort") = PasswordTextBox.Text


            Me.DataSet1.Mitarbeiter.AddMitarbeiterRow(a)

            Me.MitarbeiterTableAdapter.Update(Me.DataSet1)
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub MitarbeiterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MitarbeiterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub LoginForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile l�dt Daten in die Tabelle "DataSet1.Mitarbeiter". Sie k�nnen sie bei Bedarf verschieben oder entfernen.
        Me.MitarbeiterTableAdapter.Fill(Me.DataSet1.Mitarbeiter)

    End Sub
End Class
