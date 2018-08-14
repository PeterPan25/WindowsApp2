Public Class KindBearbeiten
    Dim name3 As String() = {"a"}
    Public Shared Property nBild = ""

    'Private Sub KindBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.KindBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
    Public Sub Daten_Load()
        Me.TableAdapterManager.KindTableAdapter.Fill(DataSet1.Kind)

        DatenAnzeigen()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatenÄndern()

    End Sub

    Private Sub DatenÄndern()

        Dim a As DataSet1.KindRow
        a = DataSet1.Kind.FindByName(Form1.CB_name.Text)

        Try
            ' kein Unterschied ob a.Ort oder a("Ort")


            a.Besonderheiten = TextBox2.Text
            a.Sorgerechtsstatus = TextBox3.Text
            a.Bild = nBild

            Me.KindTableAdapter.Update(Me.DataSet1.Kind)

        Catch ex As Exception
            MsgBox("Nöhö")

        End Try




        Form1.Combotext()


    End Sub

    Public Sub DatenAnzeigen()
        Dim name As String = Form1.CB_name.Text
        Dim Pfad As String
        '   Me.TableAdapterManager.KindTableAdapter.Fill(DataSet1.Kind)

        ReDim name3(DataSet1.Kind.Rows.Count - 1)

        For z = 0 To (DataSet1.Kind.Rows.Count - 1)
            If name = DataSet1.Kind.Rows(z)("Name") Then
                Try

                    Pfad = DataSet1.Kind.Rows(z)("Bild")
                    If Pfad IsNot "" Then

                        PictureBox1.ImageLocation = Pfad
                    Else

                        PictureBox1.Image = Nothing

                    End If

                    TextBox3.Text = DataSet1.Kind.Rows(z)("Besonderheiten")

                    TextBox2.Text = DataSet1.Kind.Rows(z)("Sorgerechtsstatus")

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As DataRow
        a = Me.DataSet1.Schule.NewRow()

        Try
            a("S_Name") = PlatzhalterText1.Text
            a("Schulart") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText2.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText5.Text
            a("Klasse") = PlatzhalterText6.Text
            a("Klassenlehrer") = PlatzhalterText7.Text
            a("vDatum") = DateTimePicker1.Value
            a("bDatum") = DateTimePicker2.Value

            Me.DataSet1.Schule.AddSchuleRow(a)
            Me.SchuleTableAdapter.Update(Me.DataSet1.Schule)
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)
            Me.SchuleDataGridView.Update()


            MsgBox("Speichern erfolgreich")

        Catch ex As Exception
            MsgBox("Speichern fehlgeschlagen")

        End Try
    End Sub

    Private Sub BildÄndernButton_Click(sender As Object, e As EventArgs) Handles NeuesBildButton.Click
        Dim a As New OpenFileDialog
        Dim b As String = ""

        a.InitialDirectory = "C:"
        a.ShowDialog()

        b = a.FileName

        PictureBox1.ImageLocation = b

        nBild = b
    End Sub
End Class
