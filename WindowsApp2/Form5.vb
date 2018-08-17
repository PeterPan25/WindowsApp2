Public Class Form5
    Dim NachrichtRow1 As DataSet1.NachrichtRow


    Private Sub NachrichtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.NachrichtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Nachricht". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.NachrichtTableAdapter.Fill(Me.DataSet1.Nachricht)

    End Sub

    Public Sub Nachricht_laden(a As String, b As String, c As String, d As Date)
        Dim NachrichtRow() As DataRow
        NachrichtRow = DataSet1.Nachricht.Select("Empfänger  = '" & a & "' AND Verfasser  = '" & b & "' AND Betreff  = '" & c & "' AND Datum  = '" & d & "'")


        Dim k As Integer

        For k = 0 To NachrichtRow.GetUpperBound(0)

            Try
                Label1.Text = NachrichtRow(k)(4) 'Verfasser
                DateTimePicker1.Value = NachrichtRow(k)(1)
                TextBox1.Text = NachrichtRow(k)(0) 'Betreff
                RichTextBox1.Text = NachrichtRow(k)(2)


            Catch ex As Exception
                MsgBox("nö")
            End Try


        Next k
        Gelesen_Markieren(a, b, c, d)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Wert für gelesen ändern
        Me.Close()

    End Sub

    Private Sub Gelesen_Markieren(a As String, b As String, c As String, d As Date)
        Dim NachrichtRow1 As DataSet1.NachrichtRow


        Try
            NachrichtRow1 = DataSet1.Nachricht.FindByBetreffDatumVerfasserEmpfänger(c, d, b, a)
            NachrichtRow1.Gelesen = 1
            Me.NachrichtTableAdapter.Update(DataSet1)

        Catch ex As Exception
            MsgBox("Ne")
        End Try
    End Sub

End Class