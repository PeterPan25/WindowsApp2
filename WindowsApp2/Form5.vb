Public Class Form5
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
        Dim e1 As String
        Dim e2 As String
        Dim e3 As String
        Dim e4 As String

        e1 = "Empfänger  = '" & a & "'"
        e2 = "Verfasser  = '" & b & "'"
        e3 = "Betreff  = '" & c & "'"
        e4 = "Datum  = '" & d & "'"

        NachrichtRow = DataSet1.Nachricht.Select("Empfänger  = '" & a & "' AND Verfasser  = '" & b & "' AND Betreff  = '" & c & "' AND Datum  = '" & d & "'")
        '  NachrichtRow = DataSet1.Nachricht.Select(e1 & e2 & e3 & e4)

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
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Wert für gelesen ändern
        Me.Close()

    End Sub
End Class