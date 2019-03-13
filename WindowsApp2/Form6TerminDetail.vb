Public Class Form6TerminDetail

    Dim ersterTermin As Date

    'Ändern
    Private Sub Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        DatenAendern()

    End Sub
    'Ok
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        Me.Close()

    End Sub

    Private Sub TerminBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TerminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form6TerminDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Termin". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.TerminTableAdapter.Fill(Me.DataSet1.Termin)

    End Sub

    Public Sub Termin_laden(a As String, b As String, d As Date)
        Dim TerminRow() As DataRow
        TerminRow = DataSet1.Termin.Select("Name  = '" & a & "' AND Art  = '" & b & "'  AND Datum  = '" & d & "'")


        Dim k As Integer

        For k = 0 To TerminRow.GetUpperBound(0)

            Try
                Label1.Text = TerminRow(k)(0) 'Name
                DateTimePicker1.Value = TerminRow(k)(2)
                ersterTermin = TerminRow(k)(2)

                Label3.Text = TerminRow(k)(1) 'Art
                RichTextBox1.Text = TerminRow(k)(3) 'Betreff
                Label2.Text = "Eingetragen von: " + TerminRow(k)(4) 'eingetragenvon



            Catch ex As Exception
                MsgBox("nö")
            End Try


        Next k




    End Sub

    Private Sub DatenAendern()
        Dim TerminRow1 As DataSet1.TerminRow



        Try
            TerminRow1 = DataSet1.Termin.FindByNameArtDatum(Label1.Text, Label3.Text, ersterTermin)
            TerminRow1.Datum = DateTimePicker1.Value
            TerminRow1.Betreff = RichTextBox1.Text
            Me.TerminTableAdapter.Update(DataSet1)

        Catch ex As Exception
            MsgBox("Ne")
        End Try
        Form1.Übersicht1.Daten_laden()
        Me.Close()

    End Sub

    'Termin löschen
    Private Sub Button3_MouseClick(sender As Object, e As MouseEventArgs) Handles Button3.MouseClick
        Dim TerminRow1 As DataSet1.TerminRow



        Try
            TerminRow1 = DataSet1.Termin.FindByNameArtDatum(Label1.Text, Label3.Text, ersterTermin)
            TerminRow1.Delete()

            Me.TerminTableAdapter.Update(DataSet1)

        Catch ex As Exception
            MsgBox("Ne")
        End Try
        Form1.Übersicht1.Daten_laden()
        Me.Close()


    End Sub
End Class