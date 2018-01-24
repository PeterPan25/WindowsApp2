Public Class BerichtAnzeigen
    Private Sub BerichtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BerichtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub BerichtAnzeigen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.SchulBericht". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.SchulBerichtTableAdapter.Fill(Me.DataSet1.SchulBericht)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.ElternBericht". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.ElternBerichtTableAdapter.Fill(Me.DataSet1.ElternBericht)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.ElternBericht". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.ElternBerichtTableAdapter.Fill(Me.DataSet1.ElternBericht)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Bericht". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.BerichtTableAdapter.Fill(Me.DataSet1.Bericht)

    End Sub


    '**Arztbericht
    Public Sub Daten_laden(a As String, b As String)
        ' Me.BerichtTableAdapter.Fill(Me.DataSet1.Bericht)
        Dim r1() As DataRow
        ' Dim c1 As DataColumn


        r1 = DataSet1.Bericht.Select("Praxis  = '" & a & "'")
        ' And "Art = '" & b & "'"
        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                Label1.Text = r1(k)(0)
                Label2.Text = r1(k)(1)
                Label3.Text = r1(k)(2)
                Label4.Text = r1(k)(3)
                Label5.Text = r1(k)(4)
                Label6.Text = r1(k)(6)
                Label7.Text = r1(k)(7)
                Label8.Text = r1(k)(8)
                RichTextBox1.Text = r1(k)(5)
                ' RichTextBox1.Enabled = False

                'TextBox3.Text = r1(k)(1)
                'TextBox4.Text = r1(k)(5)

            Catch ex As Exception
                MsgBox("nö")
            End Try


        Next k
    End Sub

    '****Schulbericht
    Public Sub SBDaten_laden(a As String, b As String)
        Dim r1() As DataRow
        Label2.Visible = False

        r1 = DataSet1.SchulBericht.Select("Thema  = '" & a & "'")
        ' And "Kind = '" & b & "'"
        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                Label1.Text = r1(k)(0)
                Label5.Text = r1(k)(1)
                Label3.Text = r1(k)(2)
                Label6.Text = r1(k)(5)
                Label4.Text = r1(k)(4)
                Label7.Text = r1(k)(3)
                Label8.Text = r1(k)(6)
                RichTextBox1.Text = r1(k)(7)
                ' RichTextBox1.Enabled = False

                'TextBox3.Text = r1(k)(1)
                'TextBox4.Text = r1(k)(5)

            Catch ex As Exception
            End Try


        Next k
    End Sub

    '***Elternbericht
    Public Sub EBDaten_laden(a As String, b As String)
        Dim r1() As DataRow

        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False

        r1 = DataSet1.ElternBericht.Select("Thema  = '" & a & "'")
        ' And "Kind = '" & b & "'"
        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                Label1.Text = r1(k)(0)
                Label2.Text = r1(k)(2)
                Label3.Text = r1(k)(1)
                Label5.Text = r1(k)(3)

                RichTextBox1.Text = r1(k)(4)
                ' RichTextBox1.Enabled = False

                'TextBox3.Text = r1(k)(1)
                'TextBox4.Text = r1(k)(5)

            Catch ex As Exception
            End Try


        Next k
    End Sub
End Class