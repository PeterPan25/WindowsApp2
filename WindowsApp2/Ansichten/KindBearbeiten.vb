Public Class KindBearbeiten
    Dim name3 As String() = {"a"}

    'Private Sub KindBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.KindBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatenÄndern()

    End Sub

    Private Sub DatenÄndern()

        Dim a As DataSet1.KindRow
        a = DataSet1.Kind.FindByName(Form1.CB_name.Text)

        Try
            ' kein Unterschied ob a.Ort oder a("Ort")

            a.Schule = TextBox1.Text
            a.Besonderheiten = TextBox2.Text
            a.Sorgerechtsstatus = TextBox3.Text


            Me.KindTableAdapter.Update(Me.DataSet1.Kind)

        Catch ex As Exception
            MsgBox("Nöhö")

        End Try




        Form1.Combotext()


    End Sub

    Public Sub DatenAnzeigen()
        Dim name As String = Form1.CB_name.Text

        ReDim name3(DataSet1.Kind.Rows.Count - 1)

        For z = 0 To (DataSet1.Kind.Rows.Count - 1)
            If name = DataSet1.Kind.Rows(z)("Name") Then
                Try


                    TextBox1.Text = DataSet1.Kind.Rows(z)("Schule")
                    TextBox2.Text = DataSet1.Kind.Rows(z)("Besonderheiten")

                    TextBox3.Text = DataSet1.Kind.Rows(z)("Sorgerechtsstatus")

                Catch ex As Exception
                    MsgBox("Hoppla")
                End Try



            End If

        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KindEntfernen()
    End Sub

    Private Sub KindEntfernen()
        Dim name As String = Form1.CB_name.Text


        Dim a As DataSet1.KindRow
        a = DataSet1.Kind.FindByName(Form1.CB_name.Text)

        Try


            a.Delete()


            Me.KindTableAdapter.Update(Me.DataSet1.Kind)

        Catch ex As Exception
            MsgBox("Nöhö")

        End Try




        Form1.Combotext()
    End Sub
End Class
