Public Class BerichtAnlegen
    'Private Sub ElternBerichtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.ElternBerichtBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    Public Sub SchulBericht()
        Label1.Text = Form1.CB_name.Text
        Label2.Text = "Schulbericht"
    End Sub

    Public Sub ElternBericht()
        Label1.Text = Form1.CB_name.Text
        Label2.Text = "Elternbericht"

    End Sub




    '***Speichern****
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As DataRow

        If Label2.Text = "Schulbericht" Then
            a = Me.DataSet1.SchulBericht.NewRow()

            Try
                a("Kind") = Label1.Text
                a("Thema") = PlatzhalterText1
                a("Schule") = PlatzhalterText2.Text
                a("Klasse") = PlatzhalterText3.Text
                a("Lehrer") = PlatzhalterText4.Text
                a("Fach") = PlatzhalterText5.Text
                a("Datum") = DateTimePicker1.Value

                Me.DataSet1.SchulBericht.AddSchulBerichtRow(a)
                Me.SchulBerichtTableAdapter.Update(DataSet1.SchulBericht)
                Me.TableAdapterManager.UpdateAll(DataSet1)
            Catch ex As Exception
                MsgBox("Fehler")
            End Try


        ElseIf Label2.Text = "Elternbericht" Then
            a = Me.DataSet1.ElternBericht.NewRow()

            Try
                a("Kind") = Label1.Text
                a("Thema") = PlatzhalterText2
                a("Elternteil") = ComboBox1.Text
                a("Datum") = DateTimePicker1.Value

                Me.DataSet1.ElternBericht.AddElternBerichtRow(a)
                Me.ElternBerichtTableAdapter.Update(DataSet1.ElternBericht)
                Me.TableAdapterManager.UpdateAll(DataSet1)
            Catch ex As Exception
                MsgBox("Fehler")
            End Try

            Me.Visible = False

        End If


    End Sub
End Class
