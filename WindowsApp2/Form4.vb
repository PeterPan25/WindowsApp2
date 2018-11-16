Public Class Nachrichten



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SendenButton.Click

        Dim NeueNachricht As DataRow

        Try
            NeueNachricht = DataSet11.Nachricht.NewRow
            NeueNachricht("Empfänger") = ComboBox1.Text
            NeueNachricht("Verfasser") = AbsenderLabel.Text
            NeueNachricht("Datum") = DateTimePicker1.Value
            NeueNachricht("Text") = RichTextBox1.Text
            NeueNachricht("Gelesen") = 0
            NeueNachricht("Betreff") = BetreffTextbox.Text

            DataSet11.Nachricht.AddNachrichtRow(NeueNachricht)
            NachrichtTableAdapter.Update(Me.DataSet11)


            MsgBox("Erfolgreich versendet")
        Catch ex As Exception
            MsgBox("Hoppla da ist was schief gelaufen")
        End Try


        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AbbruchButton.Click
        Me.Close()
    End Sub


    Private Sub Nachrichten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet11.Nachricht". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.NachrichtTableAdapter.Fill(Me.DataSet11.Nachricht)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet11.Mitarbeiter". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.MitarbeiterTableAdapter.Fill(Me.DataSet11.Mitarbeiter)

        Empfänger()



    End Sub

    Private Sub Empfänger()
        Dim EmpfängerArray As String()
        Dim EmpfängerArray1(DataSet11.Mitarbeiter.Rows.Count - 1) As String
        Dim EmpfängerArray2(DataSet11.Mitarbeiter.Rows.Count - 1) As String
        ReDim EmpfängerArray(Me.DataSet11.Mitarbeiter.Rows.Count - 1)
        Dim AbsenderInfo As New AktuellerBenutzer

        For a = 0 To (DataSet11.Mitarbeiter.Rows.Count - 1)
            EmpfängerArray1(a) = DataSet11.Mitarbeiter.Rows(a)("Vorname")
            EmpfängerArray2(a) = DataSet11.Mitarbeiter.Rows(a)("Nachname")
            EmpfängerArray(a) = EmpfängerArray1(a) + " " + EmpfängerArray2(a)
        Next

        ComboBox1.DataSource = EmpfängerArray

        AbsenderLabel.Text = AbsenderInfo.Benutzer_nennen


    End Sub

End Class