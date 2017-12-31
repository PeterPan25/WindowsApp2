Public Class ArztAnlegen
    Dim name3 As String() = {"a"}


    Private Sub AugenarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AugenarztBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub AugenarztBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AugenarztBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ArtText As String = ComboBox1.Text
        If ArtText = "Augenarzt" Then
            AugenarztAnlegen()

        ElseIf ArtText = "Frauenarzt" Then
            FrauenarztAnlegen()

        ElseIf ArtText = "Kinderarzt" Then
            KinderarztAnlegen()

        ElseIf ArtText = "Hautarzt" Then
            HautarztAnlegen()

        ElseIf ArtText = "Zahnarzt" Then
            ZahnarztAnlegen()

        ElseIf ArtText = "HNO-Arzt" Then

            HNOArztAnlegen()

        End If
        Combotext()
        ResetTextbox()
    End Sub

    Private Sub HautarztAnlegen()
        Dim a As DataRow = Me.DataSet1.Hautarzt.NewRow()

        Try
            a("H_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.Hautarzt.AddHautarztRow(a)

            Me.HautarztTableAdapter.Update(Me.DataSet1)
            KHDaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub AugenarztAnlegen()
        Dim a As DataRow = Me.DataSet1.Augenarzt.NewRow()

        Try
            a("A_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.Augenarzt.AddAugenarztRow(a)
            Me.AugenarztTableAdapter.Update(Me.DataSet1)
            KADaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub ZahnarztAnlegen()
        Dim a As DataRow = Me.DataSet1.Zahnarzt.NewRow()

        Try
            a("Z_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.Zahnarzt.AddZahnarztRow(a)
            Me.ZahnarztTableAdapter.Update(Me.DataSet1)
            KZDaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub KinderarztAnlegen()
        Dim a As DataRow = Me.DataSet1.Kinderarzt.NewRow()

        Try
            a("K_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.Kinderarzt.AddKinderarztRow(a)
            Me.KinderarztTableAdapter.Update(Me.DataSet1)
            KKDaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub FrauenarztAnlegen()
        Dim a As DataRow = Me.DataSet1.Frauenarzt.NewRow()

        Try
            a("F_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.Frauenarzt.AddFrauenarztRow(a)
            Me.FrauenarztTableAdapter.Update(Me.DataSet1)
            KFDaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub HNOArztAnlegen()
        Dim a As DataRow = Me.DataSet1.HNO.NewRow()

        Try
            a("HNO_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.HNO.AddHNORow(a)
            Me.HNOTableAdapter.Update(Me.DataSet1)
            KHNODaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub KADaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindAugenarzt.NewRow()

        b("A_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindAugenarzt.AddKindAugenarztRow(b)
        Me.Validate()

        '
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Reset()


    End Sub
    Private Sub KKDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindKinderarzt.NewRow()

        b("K_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindKinderarzt.AddKindKinderarztRow(b)
        Me.Validate()


        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Reset()


    End Sub
    Private Sub KZDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindZahnarzt.NewRow()

        b("Z_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindZahnarzt.AddKindZahnarztRow(b)
        Me.Validate()

        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Reset()


    End Sub
    Private Sub KFDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindFrauenarzt.NewRow()

        b("F_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindFrauenarzt.AddKindFrauenarztRow(b)
        Me.Validate()


        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Reset()


    End Sub
    Private Sub KHDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindHautarzt.NewRow()

        b("H_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindHautarzt.AddKindHautarztRow(b)
        Me.Validate()


        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Reset()


    End Sub
    Private Sub KHNODaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindHNO.NewRow()

        b("HNO_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindHNO.AddKindHNORow(b)
        Me.Validate()

        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Reset()
    End Sub

    Private Sub Reset()
        MsgBox("Speichern erfolgreich")
        ComboBox1.Text = ""
        PlatzhalterText1.Clear()
        PlatzhalterText2.Clear()
        PlatzhalterText3.Clear()
        PlatzhalterText4.Clear()
        PlatzhalterText5.Clear()

    End Sub
    ' ********************************ab hier Daten ändern
    Private Sub Anzeige() Handles ComboBox1.SelectedIndexChanged
        ResetAnzeigeBoxen()
        Combotext()

    End Sub

    Private Sub Combotext()
        Dim name5 As String = Form1.CB_name.Text
        Dim ArtText As String = ComboBox1.Text
        If ArtText = "Augenarzt" Then

            ReDim name3(DataSet1.Augenarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Augenarzt.Rows.Count - 1)
                name3(z) = DataSet1.Augenarzt.Rows(z)("A_Name")

            Next

                ComboBox2.DataSource = name3
            ElseIf ArtText = "Frauenarzt" Then
                ReDim name3(DataSet1.Frauenarzt.Rows.Count - 1)

                For z = 0 To (DataSet1.Frauenarzt.Rows.Count - 1)
                    name3(z) = DataSet1.Frauenarzt.Rows(z)("F_Name")
                Next

                ComboBox2.DataSource = name3
            ElseIf ArtText = "Kinderarzt" Then
                ReDim name3(DataSet1.Kinderarzt.Rows.Count - 1)

                For z = 0 To (DataSet1.Kinderarzt.Rows.Count - 1)
                    name3(z) = DataSet1.Kinderarzt.Rows(z)("K_Name")
                Next

                ComboBox2.DataSource = name3
            ElseIf ArtText = "Hautarzt" Then
                ReDim name3(DataSet1.Hautarzt.Rows.Count - 1)

                For z = 0 To (DataSet1.Hautarzt.Rows.Count - 1)
                    name3(z) = DataSet1.Hautarzt.Rows(z)("H_Name")
                Next

                ComboBox2.DataSource = name3
            ElseIf ArtText = "Zahnarzt" Then
                ReDim name3(DataSet1.Zahnarzt.Rows.Count - 1)

                For z = 0 To (DataSet1.Zahnarzt.Rows.Count - 1)
                    name3(z) = DataSet1.Zahnarzt.Rows(z)("Z_Name")
                Next

                ComboBox2.DataSource = name3
            ElseIf ArtText = "HNO-Arzt" Then

                ReDim name3(DataSet1.HNO.Rows.Count - 1)

            For z = 0 To (DataSet1.HNO.Rows.Count - 1)
                name3(z) = DataSet1.HNO.Rows(z)("HNO_Name")
            Next

            ComboBox2.DataSource = name3

        End If
        DatenAnzeigen()


    End Sub

    Private Sub DatenAnzeigen() Handles ComboBox2.SelectedIndexChanged
        Dim name As String = ComboBox2.Text
        Dim name5 As String = Form1.CB_name.Text

        Dim ArtText As String = ComboBox1.Text
        If ArtText = "Augenarzt" Then
            'ReDim name3(DataSet1.Augenarzt.Rows.Count - 1)

            'For z = 0 To (DataSet1.Augenarzt.Rows.Count - 1)
            '    If name = DataSet1.Augenarzt.Rows(z)("A_Name") Then
            '        TextBox5.Text = DataSet1.Augenarzt.Rows(z)("Straße")
            '        TextBox3.Text = DataSet1.Augenarzt.Rows(z)("PLZ")
            '        TextBox4.Text = DataSet1.Augenarzt.Rows(z)("Ort")
            '        TextBox2.Text = DataSet1.Augenarzt.Rows(z)("Telefon")
            '        TextBox1.Text = DataSet1.Augenarzt.Rows(z)("A_Name")

            '    End If
            'Next
            ReDim name3(DataSet1.KindAugenarzt.Rows.Count - 1)
            For z = 0 To (DataSet1.KindAugenarzt.Rows.Count - 1)
                If name = DataSet1.KindAugenarzt.Rows(z)("A_Name") And name5 = DataSet1.KindAugenarzt.Rows(z)("Name") Then
                    TextBox5.Text = DataSet1.Augenarzt.Rows(z)("Straße")
                    TextBox3.Text = DataSet1.Augenarzt.Rows(z)("PLZ")
                    TextBox4.Text = DataSet1.Augenarzt.Rows(z)("Ort")
                    TextBox2.Text = DataSet1.Augenarzt.Rows(z)("Telefon")
                    TextBox1.Text = DataSet1.Augenarzt.Rows(z)("A_Name")

                End If

            Next

        ElseIf ArtText = "Frauenarzt" Then
            ReDim name3(DataSet1.Frauenarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Frauenarzt.Rows.Count - 1)
                If name = DataSet1.Frauenarzt.Rows(z)("F_Name") Then
                    TextBox5.Text = DataSet1.Frauenarzt.Rows(z)("Straße")
                    TextBox3.Text = DataSet1.Frauenarzt.Rows(z)("PLZ")
                    TextBox4.Text = DataSet1.Frauenarzt.Rows(z)("Ort")
                    TextBox2.Text = DataSet1.Frauenarzt.Rows(z)("Telefon")
                    TextBox1.Text = DataSet1.Frauenarzt.Rows(z)("F_Name")
                End If
            Next

        ElseIf ArtText = "Kinderarzt" Then
            ReDim name3(DataSet1.Kinderarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Kinderarzt.Rows.Count - 1)
                If name = DataSet1.Kinderarzt.Rows(z)("K_Name") Then
                    TextBox5.Text = DataSet1.Kinderarzt.Rows(z)("Straße")
                    TextBox3.Text = DataSet1.Kinderarzt.Rows(z)("PLZ")
                    TextBox4.Text = DataSet1.Kinderarzt.Rows(z)("Ort")
                    TextBox2.Text = DataSet1.Kinderarzt.Rows(z)("Telefon")
                    TextBox1.Text = DataSet1.Kinderarzt.Rows(z)("K_Name")
                End If
            Next

        ElseIf ArtText = "Hautarzt" Then
            ReDim name3(DataSet1.Hautarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Hautarzt.Rows.Count - 1)
                If name = DataSet1.Hautarzt.Rows(z)("H_Name") Then
                    TextBox5.Text = DataSet1.Hautarzt.Rows(z)("Straße")
                    TextBox3.Text = DataSet1.Hautarzt.Rows(z)("PLZ")
                    TextBox4.Text = DataSet1.Hautarzt.Rows(z)("Ort")
                    TextBox2.Text = DataSet1.Hautarzt.Rows(z)("Telefon")
                    TextBox1.Text = DataSet1.Hautarzt.Rows(z)("H_Name")
                End If
            Next

        ElseIf ArtText = "Zahnarzt" Then
            ReDim name3(DataSet1.Zahnarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Zahnarzt.Rows.Count - 1)
                If name = DataSet1.Zahnarzt.Rows(z)("Z_Name") Then
                    TextBox5.Text = DataSet1.Zahnarzt.Rows(z)("Straße")
                    TextBox3.Text = DataSet1.Zahnarzt.Rows(z)("PLZ")
                    TextBox4.Text = DataSet1.Zahnarzt.Rows(z)("Ort")
                    TextBox2.Text = DataSet1.Zahnarzt.Rows(z)("Telefon")
                    TextBox1.Text = DataSet1.Zahnarzt.Rows(z)("Z_Name")

                End If
            Next

        ElseIf ArtText = "HNO-Arzt" Then
            ReDim name3(DataSet1.HNO.Rows.Count - 1)

            For z = 0 To (DataSet1.HNO.Rows.Count - 1)
                If name = DataSet1.HNO.Rows(z)("HNO_Name") Then
                    TextBox5.Text = DataSet1.HNO.Rows(z)("Straße")
                    TextBox3.Text = DataSet1.HNO.Rows(z)("PLZ")
                    TextBox4.Text = DataSet1.HNO.Rows(z)("Ort")
                    TextBox2.Text = DataSet1.HNO.Rows(z)("Telefon")
                    TextBox1.Text = DataSet1.HNO.Rows(z)("HNO_Name")

                End If
            Next



        End If


    End Sub


    Private Sub ResetTextbox()
        PlatzhalterText1.Clear()
        PlatzhalterText2.Clear()
        PlatzhalterText3.Clear()
        PlatzhalterText4.Clear()
        PlatzhalterText5.Clear()



        PlatzhalterText1.PlatzHalterText = PlatzhalterText1.PlatzHalterText
        PlatzhalterText2.PlatzHalterText = PlatzhalterText2.PlatzHalterText
        PlatzhalterText3.PlatzHalterText = PlatzhalterText3.PlatzHalterText
        PlatzhalterText4.PlatzHalterText = PlatzhalterText4.PlatzHalterText
        PlatzhalterText5.PlatzHalterText = PlatzhalterText5.PlatzHalterText

    End Sub

    Private Sub ResetAnzeigeBoxen()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox2.Text = ""

    End Sub

End Class
