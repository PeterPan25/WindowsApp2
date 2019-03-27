Public Class BerichtAnlegen
    'Private Sub ElternBerichtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.ElternBerichtBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    Public Sub SchulBericht()
        Label1.Text = Form1.CB_name.Text
        Label2.Text = "Schulbericht"

        PlatzhalterText2.Visible = True
        PlatzhalterText2.Enabled = True
        PlatzhalterText3.Visible = True
        PlatzhalterText3.Enabled = True
        PlatzhalterText4.Visible = True
        PlatzhalterText4.Enabled = True
        PlatzhalterText5.Visible = True
        PlatzhalterText5.Enabled = True
        ComboBox1.Visible = False
    End Sub

    Public Sub ElternBericht()
        Dim Eltern() As String = {"Vater", "Mutter", "Vater + Mutter", "Erziehungsberechtigter"}

        Label1.Text = Form1.CB_name.Text
        Label2.Text = "Elternbericht"
        PlatzhalterText2.Visible = False
        PlatzhalterText2.Enabled = False
        PlatzhalterText3.Visible = False
        PlatzhalterText3.Enabled = False
        PlatzhalterText4.Visible = False
        PlatzhalterText4.Enabled = False
        PlatzhalterText5.Visible = False
        PlatzhalterText5.Enabled = False
        ComboBox1.Visible = True
        ComboBox1.DataSource = Eltern
    End Sub




    '***Speichern****
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As DataRow

        If Label2.Text = "Schulbericht" Then
            Dim SB As New Bericht

            a = Me.DataSet1.SchulBericht.NewRow()

            Try
                a("Kind") = Label1.Text
                a("Thema") = PlatzhalterText1.Text
                a("Schule") = PlatzhalterText2.Text
                a("Klasse") = PlatzhalterText3.Text
                a("Lehrer") = PlatzhalterText4.Text
                a("Fach") = PlatzhalterText5.Text
                a("Datum") = DateTimePicker1.Value
                a("Bericht") = RichTextBox1.Text

                Me.DataSet1.SchulBericht.AddSchulBerichtRow(a)
                Me.SchulBerichtTableAdapter.Update(DataSet1.SchulBericht)
                Me.TableAdapterManager.UpdateAll(DataSet1)
                Form1.Schule1.SBDaten_laden()

            Catch ex As Exception
                MsgBox("Fehler")
            End Try
            SB.Daten_laden()
            SB.BerichtKind()

            Me.Visible = False


        ElseIf Label2.Text = "Elternbericht" Then

            Me.TableAdapterManager.ElternBerichtTableAdapter.Fill(DataSet1.ElternBericht)
            a = Me.DataSet1.ElternBericht.NewRow()

            Try
                a("Kind") = Label1.Text
                a("Thema") = PlatzhalterText1.Text
                a("Elternteil") = ComboBox1.Text
                a("Datum") = DateTimePicker1.Value
                a("Bericht") = RichTextBox1.Text

                Me.DataSet1.ElternBericht.AddElternBerichtRow(a)
                Me.ElternBerichtTableAdapter.Update(DataSet1)
                '  Me.TableAdapterManager.UpdateAll(DataSet1)
                Form1.Eltern1.EBDaten_laden()

            Catch ex As Exception

                MsgBox("Fehler")
            End Try


            Me.Validate()
            Me.Visible = False

        End If

        setzeZurueck()

    End Sub

    Private Sub setzeZurueck()
        Label1.Text = Form1.CB_name.Text
        Label2.Text = "Elternbericht"
        PlatzhalterText1.ResetText()
        PlatzhalterText2.ResetText()
        PlatzhalterText3.ResetText()
        PlatzhalterText4.ResetText()
        PlatzhalterText5.ResetText()
        ComboBox1.Refresh()
        DateTimePicker1.ResetText()

    End Sub

End Class
