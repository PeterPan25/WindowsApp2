Public Class Stammdaten
    Dim name3 As String() = {"a"}

    Public Sub Stammdaten_Load()
        Me.TableAdapterManager.KindTableAdapter.Fill(DataSet1.Kind)

        Daten_Anzeigen()

    End Sub




    Public Sub Daten_Anzeigen()
        Dim name As String = Form1.CB_name.Text
        If DataSet1.Kind.Rows.Count >= 0 Then


            ReDim name3(DataSet1.Kind.Rows.Count - 1)

            For z = 0 To (DataSet1.Kind.Rows.Count - 1)
                If name = DataSet1.Kind.Rows(z)("Name") Then
                    Try
                        DateTimePicker1.Value = DataSet1.Kind.Rows(z)("Geburtsdatum")
                        DateTimePicker2.Value = DataSet1.Kind.Rows(z)("Aufnahmedatum")
                        TextBox3.Text = DataSet1.Kind.Rows(z)("Nationalität")
                        TextBox4.Text = DataSet1.Kind.Rows(z)("Jugendamt")
                        TextBox6.Text = DataSet1.Kind.Rows(z)("Schule")
                        TextBox7.Text = DataSet1.Kind.Rows(z)("Besonderheiten")
                        TextBox9.Text = DataSet1.Kind.Rows(z)("Geburtsort")
                        TextBox10.Text = DataSet1.Kind.Rows(z)("Konfession")
                        TextBox11.Text = DataSet1.Kind.Rows(z)("Hilfe_nach")
                        TextBox12.Text = DataSet1.Kind.Rows(z)("Sorgerechtsstatus")
                        TextBox13.Text = DataSet1.Kind.Rows(z)("Krankenversicherung")
                    Catch ex As Exception
                        MsgBox("Hoppla")
                    End Try



                End If

            Next
        Else
            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            TextBox3.Text = "-"
            TextBox4.Text = "-"
            TextBox6.Text = "-"
            TextBox7.Text = "-"
            TextBox9.Text = "-"
            TextBox10.Text = "-"
            TextBox11.Text = "-"
            TextBox12.Text = "-"
            TextBox13.Text = "-"
        End If



    End Sub



    'Private Sub KindBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.KindBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
