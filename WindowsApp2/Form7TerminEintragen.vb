Public Class Form7TerminEintragen
    Dim Datum As Date = Date.Now

    Private Sub TerminBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TerminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Public Sub KalenderDatum(a As Date)
        Datum = a
    End Sub

    Private Sub Form7TerminEintragen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Termin". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.TerminTableAdapter.Fill(Me.DataSet1.Termin)
        Label1.Text = Form1.CB_name.Text
        Label2.Text = AktuellerBenutzer.Benutzer
        DateTimePicker1.Value = Datum
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        TerminSpeichern()

    End Sub

    Private Sub Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        Me.Close()

    End Sub

    Private Sub TerminSpeichern()
        Dim NeuerTermin As DataRow

        Try
            NeuerTermin = DataSet1.Termin.NewRow
            NeuerTermin("Art") = PlatzhalterText1.Text
            NeuerTermin("EingetragenVon") = Label2.Text
            NeuerTermin("Name") = Label1.Text
            NeuerTermin("Datum") = DateTimePicker1.Value
            NeuerTermin("Betreff") = RichTextBox1.Text

            DataSet1.Termin.AddTerminRow(NeuerTermin)
            TerminTableAdapter.Update(Me.DataSet1)


            MsgBox("Erfolgreich gespeichert")
        Catch ex As Exception
            MsgBox("Hoppla da ist was schief gelaufen")
        End Try

        Form1.Übersicht1.Daten_laden()

        Me.Close()
    End Sub
End Class