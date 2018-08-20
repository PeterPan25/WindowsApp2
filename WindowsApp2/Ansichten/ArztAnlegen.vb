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
        ElseIf ArtText = "Psychologe" Then
            PsychoAnlegen()

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
        Catch ex As Exception
            MsgBox("Schade123")
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
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub
    Private Sub PsychoAnlegen()
        Dim a As DataRow = Me.DataSet1.Psycho.NewRow()

        Try
            a("P_Name") = PlatzhalterText1.Text
            a("Art") = ComboBox1.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Plz") = PlatzhalterText3.Text
            a("Telefon") = PlatzhalterText2.Text

            Me.DataSet1.Psycho.AddPsychoRow(a)
            Me.PsychoTableAdapter.Update(Me.DataSet1)


        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub


    Private Sub KADaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindAugenarzt.NewRow()

        Try

            b("A_Name") = TextBox1.Text
            b("Name") = Form1.CB_name.Text
            Me.DataSet1.KindAugenarzt.AddKindAugenarztRow(b)
            Me.Validate()

            '
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Catch ex As Exception
            MsgBox("Fehler")
        End Try

        'Reset()
        ResetTextbox()



    End Sub
    Private Sub KKDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindKinderarzt.NewRow()
        Try
            b("K_Name") = TextBox1.Text
            b("Name") = Form1.CB_name.Text
            Me.DataSet1.KindKinderarzt.AddKindKinderarztRow(b)
            Me.Validate()


            Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Catch ex As Exception
            MsgBox("Fehler")

        End Try

        'Reset()
        ResetTextbox()


    End Sub
    Private Sub KZDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindZahnarzt.NewRow()
        Try
            b("Z_Name") = TextBox1.Text
            b("Name") = Form1.CB_name.Text
            Me.DataSet1.KindZahnarzt.AddKindZahnarztRow(b)
            Me.Validate()

            Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Catch ex As Exception
            MsgBox("Schade")
        End Try


        'Reset()
        ResetTextbox()


    End Sub
    Private Sub KFDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindFrauenarzt.NewRow()
        Try
            b("F_Name") = TextBox1.Text
            b("Name") = Form1.CB_name.Text
            Me.DataSet1.KindFrauenarzt.AddKindFrauenarztRow(b)
            Me.Validate()


            Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Catch ex As Exception
            MsgBox("Fehler")
        End Try

        'Reset()
        ResetTextbox()

    End Sub
    Private Sub KHDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindHautarzt.NewRow()
        Try
            b("H_Name") = TextBox1.Text
            b("Name") = Form1.CB_name.Text
            Me.DataSet1.KindHautarzt.AddKindHautarztRow(b)
            Me.Validate()


            Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Catch ex As Exception
            MsgBox("Fehler")
        End Try

        'Reset()
        ResetTextbox()


    End Sub
    Private Sub KHNODaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindHNO.NewRow()
        Try
            b("HNO_Name") = TextBox1.Text
            b("Name") = Form1.CB_name.Text
            Me.DataSet1.KindHNO.AddKindHNORow(b)
            Me.Validate()

            Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Catch ex As Exception
            MsgBox("Schade")
        End Try

        'Reset()
        ResetTextbox()
    End Sub

    Private Sub KPsychoAnlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindPsycho.NewRow()
        Try
            b("P_Name") = TextBox1.Text
            b("Name") = Form1.CB_name.Text
            Me.DataSet1.KindPsycho.AddKindPsychoRow(b)
            Me.Validate()

            Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Catch ex As Exception
            MsgBox("Schade")
        End Try

        'Reset()
        ResetTextbox()
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
    ' ********************************ab hier Daten anzeigen**************
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

        ElseIf ArtText = "Psychologe" Then
            ReDim name3(DataSet1.Psycho.Rows.Count - 1)
            For z = 0 To (DataSet1.Psycho.Rows.Count - 1)
                name3(z) = DataSet1.Psycho.Rows(z)("P_Name")
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
            ReDim name3(DataSet1.Augenarzt.Rows.Count - 1)
            For z = 0 To (DataSet1.Augenarzt.Rows.Count - 1)
                If name = DataSet1.Augenarzt.Rows(z)("A_Name") Then 'And name5 = DataSet1.KindAugenarzt.Rows(z)("Name") Then
                    TextBox5.Text = DataSet1.Augenarzt.Rows(z)("Straße")
                    TextBox3.Text = DataSet1.Augenarzt.Rows(z)("Plz")
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
                    TextBox3.Text = DataSet1.Frauenarzt.Rows(z)("Plz")
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
                    TextBox3.Text = DataSet1.Kinderarzt.Rows(z)("Plz")
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
                    TextBox3.Text = DataSet1.Hautarzt.Rows(z)("Plz")
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
                    TextBox3.Text = DataSet1.Zahnarzt.Rows(z)("Plz")
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
                    TextBox3.Text = DataSet1.HNO.Rows(z)("Plz")
                    TextBox4.Text = DataSet1.HNO.Rows(z)("Ort")
                    TextBox2.Text = DataSet1.HNO.Rows(z)("Telefon")
                    TextBox1.Text = DataSet1.HNO.Rows(z)("HNO_Name")

                End If
            Next

        ElseIf ArtText = "Psychologe" Then
            ReDim name3(DataSet1.Psycho.Rows.Count - 1)

            For z = 0 To (DataSet1.Psycho.Rows.Count - 1)
                If name = DataSet1.Psycho.Rows(z)("P_Name") Then
                    TextBox5.Text = DataSet1.Psycho.Rows(z)("Straße")
                    TextBox3.Text = DataSet1.Psycho.Rows(z)("Plz")
                    TextBox4.Text = DataSet1.Psycho.Rows(z)("Ort")
                    TextBox2.Text = DataSet1.Psycho.Rows(z)("Telefon")
                    TextBox1.Text = DataSet1.Psycho.Rows(z)("P_Name")
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
    '**************************Daten ändern**********************************
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ArtText As String = ComboBox1.Text
        If ArtText = "Augenarzt" Then
            AugenarztAendern()
            DatenAnzeigen()


        ElseIf ArtText = "Frauenarzt" Then
            FrauenarztAendern()
            DatenAnzeigen()
        ElseIf ArtText = "Kinderarzt" Then
            KinderarztAendern()
            DatenAnzeigen()
        ElseIf ArtText = "Hautarzt" Then
            HautarztAendern()
            DatenAnzeigen()
        ElseIf ArtText = "Zahnarzt" Then
            ZahnarztAendern()
            DatenAnzeigen()
        ElseIf ArtText = "HNO-Arzt" Then

            HNOArztAendern()
            DatenAnzeigen()

        ElseIf ArtText = "Psychologe" Then
            PsychoAendern()
            DatenAnzeigen()
        End If
        Combotext()
        ResetTextbox()
    End Sub

    Private Sub HautarztAendern()
        Dim a As DataSet1.HautarztRow
        a = DataSet1.Hautarzt.FindByH_Name(ComboBox2.Text)
        Try
            a("H_Name") = TextBox1.Text
            a("Plz") = TextBox3.Text
            a("Ort") = TextBox4.Text
            a("Strasse") = TextBox5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = TextBox2.Text


            KHDaten_aendern()

            Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub AugenarztAendern()
        Dim a As DataSet1.AugenarztRow
        a = DataSet1.Augenarzt.FindByA_Name(ComboBox2.Text)
        Try
            a("A_Name") = TextBox1.Text
            a("Plz") = TextBox3.Text
            a("Ort") = TextBox4.Text
            a("Strasse") = TextBox5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = TextBox2.Text


            KADaten_aendern()
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub ZahnarztAendern()
        Dim a As DataSet1.ZahnarztRow
        a = DataSet1.Zahnarzt.FindByZ_Name(ComboBox2.Text)
        Try
            a("Z_Name") = TextBox1.Text
            a("Plz") = TextBox3.Text
            a("Ort") = TextBox4.Text
            a("Strasse") = TextBox5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = TextBox2.Text

            KZDaten_aendern()
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub KinderarztAendern()
        Dim a As DataSet1.KinderarztRow
        a = DataSet1.Kinderarzt.FindByK_Name(ComboBox2.Text)
        Try
            a("K_Name") = TextBox1.Text
            a("Plz") = TextBox3.Text
            a("Ort") = TextBox4.Text
            a("Strasse") = TextBox5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = TextBox2.Text


            KKDaten_aendern()
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub FrauenarztAendern()
        Dim a As DataSet1.FrauenarztRow
        a = DataSet1.Frauenarzt.FindByF_Name(ComboBox2.Text)
        Try
            a("F_Name") = TextBox1.Text
            a("Plz") = TextBox3.Text
            a("Ort") = TextBox4.Text
            a("Strasse") = TextBox5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = TextBox2.Text

            KFDaten_aendern()
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub HNOArztAendern()
        Dim a As DataSet1.HNORow
        a = DataSet1.HNO.FindByHNO_Name(ComboBox2.Text)
        Try
            a("HNO_Name") = TextBox1.Text
            a("Plz") = TextBox3.Text
            a("Ort") = TextBox4.Text
            a("Strasse") = TextBox5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = TextBox2.Text

            KHNODaten_aendern()
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub PsychoAendern()
        Dim a As DataSet1.PsychoRow
        a = DataSet1.Psycho.FindByP_Name(ComboBox2.Text)
        Try
            a("P_Name") = TextBox1.Text
            a("Plz") = TextBox3.Text
            a("Ort") = TextBox4.Text
            a("Strasse") = TextBox5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = TextBox2.Text

            KPsychoDaten_aendern()
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub KADaten_aendern()
        Dim b As DataSet1.KindAugenarztRow
        b = Me.DataSet1.KindAugenarzt.FindByNameA_Name(Form1.CB_name.Text, ComboBox2.Text)
        Dim c As DataRow
        c = Me.DataSet1.KindAugenarzt.NewRow()
        b.Delete()
        Me.KindAugenarztTableAdapter.Update(Me.DataSet1.KindAugenarzt)
        c("A_Name") = TextBox1.Text
        c("Name") = Form1.CB_name.Text
        Me.AugenarztTableAdapter.Update(Me.DataSet1.Augenarzt)
        Me.DataSet1.KindAugenarzt.AddKindAugenarztRow(c)
        Me.KindAugenarztTableAdapter.Update(Me.DataSet1.KindAugenarzt)
        Me.Validate()

        '
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    End Sub
    Private Sub KKDaten_aendern()
        Dim b As DataSet1.KindKinderarztRow
        b = Me.DataSet1.KindKinderarzt.FindByNameK_Name(Form1.CB_name.Text, ComboBox2.Text)
        Dim c As DataRow
        c = Me.DataSet1.KindKinderarzt.NewRow()
        b.Delete()
        Me.KindKinderarztTableAdapter.Update(Me.DataSet1.KindKinderarzt)


        c("K_Name") = TextBox1.Text
        c("Name") = Form1.CB_name.Text
        Me.KinderarztTableAdapter.Update(Me.DataSet1.Kinderarzt)
        Me.DataSet1.KindKinderarzt.AddKindKinderarztRow(c)
        Me.KindKinderarztTableAdapter.Update(Me.DataSet1.KindKinderarzt)
        Me.Validate()

        '
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub
    Private Sub KZDaten_aendern()
        Dim b As DataSet1.KindZahnarztRow
        b = Me.DataSet1.KindZahnarzt.FindByNameZ_Name(Form1.CB_name.Text, ComboBox2.Text)
        Dim c As DataRow
        c = Me.DataSet1.KindZahnarzt.NewRow()
        b.Delete()
        Me.KindZahnarztTableAdapter.Update(Me.DataSet1.KindZahnarzt)

        c("Z_Name") = TextBox1.Text
        c("Name") = Form1.CB_name.Text
        Me.ZahnarztTableAdapter.Update(Me.DataSet1.Zahnarzt)
        Me.DataSet1.KindZahnarzt.AddKindZahnarztRow(c)
        Me.KindZahnarztTableAdapter.Update(Me.DataSet1.KindZahnarzt)
        Me.Validate()

        '
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub
    Private Sub KFDaten_aendern()
        Dim b As DataSet1.KindFrauenarztRow
        b = Me.DataSet1.KindFrauenarzt.FindByNameF_Name(Form1.CB_name.Text, ComboBox2.Text)
        Dim c As DataRow
        c = Me.DataSet1.KindFrauenarzt.NewRow()
        b.Delete()
        Me.KindFrauenarztTableAdapter.Update(Me.DataSet1.KindFrauenarzt)

        c("F_Name") = TextBox1.Text
        c("Name") = Form1.CB_name.Text
        Me.FrauenarztTableAdapter.Update(Me.DataSet1.Frauenarzt)

        Me.DataSet1.KindFrauenarzt.AddKindFrauenarztRow(c)
        Me.KindFrauenarztTableAdapter.Update(Me.DataSet1.KindFrauenarzt)
        Me.Validate()

        '
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub
    Private Sub KHDaten_aendern()
        Dim b As DataSet1.KindHautarztRow
        b = Me.DataSet1.KindHautarzt.FindByNameH_Name(Form1.CB_name.Text, ComboBox2.Text)
        Dim c As DataRow
        c = Me.DataSet1.KindHautarzt.NewRow()

        b.Delete()
        Me.KindHautarztTableAdapter.Update(Me.DataSet1.KindHautarzt)

        c("H_Name") = TextBox1.Text
        c("Name") = Form1.CB_name.Text
        Me.HautarztTableAdapter.Update(Me.DataSet1.Hautarzt)

        Me.DataSet1.KindHautarzt.AddKindHautarztRow(c)
        Me.KindHautarztTableAdapter.Update(Me.DataSet1.KindHautarzt)
        Me.Validate()

        '
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    End Sub
    Private Sub KHNODaten_aendern()
        Dim b As DataSet1.KindHNORow
        b = Me.DataSet1.KindHNO.FindByNameHNO_Name(Form1.CB_name.Text, ComboBox2.Text)
        Dim c As DataRow
        c = Me.DataSet1.KindHNO.NewRow()

        b.Delete()
        Me.KindHNOTableAdapter.Update(Me.DataSet1.KindHNO)
        c("HNO_Name") = TextBox1.Text
        c("Name") = Form1.CB_name.Text
        Me.HNOTableAdapter.Update(Me.DataSet1.HNO)

        Me.DataSet1.KindHNO.AddKindHNORow(c)
        Me.KindHNOTableAdapter.Update(Me.DataSet1.KindHNO)
        Me.Validate()

        '
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub

    Private Sub KPsychoDaten_aendern()
        Dim b As DataSet1.KindPsychoRow
        b = Me.DataSet1.KindPsycho.FindByNameP_Name(Form1.CB_name.Text, ComboBox2.Text)
        Dim c As DataRow
        c = Me.DataSet1.KindPsycho.NewRow()

        b.Delete()
        Me.KindPsychoTableAdapter.Update(Me.DataSet1.KindPsycho)
        c("P_Name") = TextBox1.Text
        c("Name") = Form1.CB_name.Text
        Me.PsychoTableAdapter.Update(Me.DataSet1.Psycho)

        Me.DataSet1.KindPsycho.AddKindPsychoRow(c)
        Me.KindPsychoTableAdapter.Update(Me.DataSet1.KindPsycho)
        Me.Validate()

        '
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub
    '*****Daten löschen***
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim arztart As String = ComboBox1.Text
        Dim c As DataRow
        Dim d As DataRow

        If arztart = "Augenarzt" Then
            Try
                c = Me.DataSet1.Augenarzt.FindByA_Name(ComboBox2.Text)
                c.Delete()
                d = Me.DataSet1.KindAugenarzt.FindByNameA_Name(Form1.CB_name.Text, ComboBox2.Text)
                d.Delete()
                Me.KindAugenarztTableAdapter.Update(DataSet1.KindAugenarzt)
                Me.AugenarztTableAdapter.Update(DataSet1.Augenarzt)
                Me.TableAdapterManager.UpdateAll(Me.DataSet1)
                MsgBox("Erfolgreich entfernt")
                ResetAnzeigeBoxen()
            Catch ex As Exception
                MsgBox("Fehler")
            End Try



        ElseIf arztart = "Kinderarzt" Then
            Try
                c = Me.DataSet1.Kinderarzt.FindByK_Name(ComboBox2.Text)
                c.Delete()
                d = Me.DataSet1.KindKinderarzt.FindByNameK_Name(Form1.CB_name.Text, ComboBox2.Text)
                d.Delete()
                Me.KindKinderarztTableAdapter.Update(DataSet1.KindKinderarzt)
                Me.KinderarztTableAdapter.Update(DataSet1.Kinderarzt)
                Me.TableAdapterManager.UpdateAll(Me.DataSet1)
                MsgBox("Erfolgreich entfernt")
                ResetAnzeigeBoxen()

            Catch ex As Exception
                MsgBox("Fehler")
            End Try


        ElseIf arztart = "Frauenarzt" Then
            Try
                c = Me.DataSet1.Frauenarzt.FindByF_Name(ComboBox2.Text)
                c.Delete()
                d = Me.DataSet1.KindFrauenarzt.FindByNameF_Name(Form1.CB_name.Text, ComboBox2.Text)
                d.Delete()
                Me.KindFrauenarztTableAdapter.Update(DataSet1.KindFrauenarzt)
                Me.FrauenarztTableAdapter.Update(DataSet1.Frauenarzt)
                Me.TableAdapterManager.UpdateAll(Me.DataSet1)
                MsgBox("Erfolgreich entfernt")
                ResetAnzeigeBoxen()

            Catch ex As Exception
                MsgBox("Fehler")
            End Try


        ElseIf arztart = "Zahnarzt" Then
            Try
                c = Me.DataSet1.Zahnarzt.FindByZ_Name(ComboBox2.Text)
                c.Delete()
                d = Me.DataSet1.KindZahnarzt.FindByNameZ_Name(Form1.CB_name.Text, ComboBox2.Text)
                d.Delete()
                Me.KindZahnarztTableAdapter.Update(DataSet1.KindZahnarzt)
                Me.ZahnarztTableAdapter.Update(DataSet1.Zahnarzt)
                Me.TableAdapterManager.UpdateAll(Me.DataSet1)
                MsgBox("Erfolgreich entfernt")
                ResetAnzeigeBoxen()

            Catch ex As Exception
                MsgBox("Fehler")
            End Try


        ElseIf arztart = "HNO-Arzt" Then
            Try
                c = Me.DataSet1.HNO.FindByHNO_Name(ComboBox2.Text)
                c.Delete()
                d = Me.DataSet1.KindHNO.FindByNameHNO_Name(Form1.CB_name.Text, ComboBox2.Text)
                d.Delete()
                Me.KindHNOTableAdapter.Update(DataSet1.KindHNO)
                Me.HNOTableAdapter.Update(DataSet1.HNO)
                Me.TableAdapterManager.UpdateAll(Me.DataSet1)
                MsgBox("Erfolgreich entfernt")
                ResetAnzeigeBoxen()

            Catch ex As Exception
                MsgBox("Fehler")
            End Try


        ElseIf arztart = "Hautarzt" Then
            Try
                c = Me.DataSet1.Hautarzt.FindByH_Name(ComboBox2.Text)
                c.Delete()
                d = Me.DataSet1.KindHautarzt.FindByNameH_Name(Form1.CB_name.Text, ComboBox2.Text)
                d.Delete()
                Me.KindHautarztTableAdapter.Update(DataSet1.KindHautarzt)
                Me.HautarztTableAdapter.Update(DataSet1.Hautarzt)
                Me.TableAdapterManager.UpdateAll(Me.DataSet1)
                MsgBox("Erfolgreich entfernt")
                ResetAnzeigeBoxen()

            Catch ex As Exception
                MsgBox("Fehler")

            End Try

        ElseIf arztart = "Psychologe" Then

            Try
                c = Me.DataSet1.Psycho.FindByP_Name(ComboBox2.Text)
                c.Delete()
                d = Me.DataSet1.KindPsycho.FindByNameP_Name(Form1.CB_name.Text, ComboBox2.Text)
                d.Delete()
                Me.KindPsychoTableAdapter.Update(DataSet1.KindPsycho)
                Me.PsychoTableAdapter.Update(DataSet1.Psycho)
                Me.TableAdapterManager.UpdateAll(Me.DataSet1)
                MsgBox("Erfolgreich entfernt")
                ResetAnzeigeBoxen()

            Catch ex As Exception
                MsgBox("Fehler")

            End Try



        End If

    End Sub
    'Einen bereits in der Datenbank vorhandenen Arzt einem Kind zuweisen
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ArtText As String = ComboBox1.Text

        If ArtText = "Augenarzt" Then
            KADaten_anlegen()


        ElseIf ArtText = "Frauenarzt" Then
            KFDaten_anlegen()


        ElseIf ArtText = "Kinderarzt" Then
            KKDaten_anlegen()


        ElseIf ArtText = "Hautarzt" Then
            KHDaten_anlegen()


        ElseIf ArtText = "Zahnarzt" Then
            KZDaten_anlegen()


        ElseIf ArtText = "HNO-Arzt" Then

            KHNODaten_anlegen()

        ElseIf ArtText = "Psychologe" Then

            KPsychoAnlegen()


        End If
    End Sub
End Class
