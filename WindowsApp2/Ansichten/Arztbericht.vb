Public Class Arztbericht

    Dim name3 As String() = {"a"}



    Private Sub BerichtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BerichtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Public Sub BerichtAnlegen_Load()
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Zahnarzt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.ZahnarztTableAdapter.Fill(Me.DataSet1.Zahnarzt)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Krankenhaus". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.KrankenhausTableAdapter.Fill(Me.DataSet1.Krankenhaus)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Kinderarzt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KinderarztTableAdapter.Fill(Me.DataSet1.Kinderarzt)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Hautarzt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.HautarztTableAdapter.Fill(Me.DataSet1.Hautarzt)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Augenarzt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.AugenarztTableAdapter.Fill(Me.DataSet1.Augenarzt)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Frauenarzt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.FrauenarztTableAdapter.Fill(Me.DataSet1.Frauenarzt)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Bericht". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.BerichtTableAdapter.Fill(Me.DataSet1.Bericht)
        Me.KindAugenarztTableAdapter.Fill(Me.DataSet1.KindAugenarzt)
        Me.KindFrauenarztTableAdapter.Fill(Me.DataSet1.KindFrauenarzt)
        Me.KindHautarztTableAdapter.Fill(Me.DataSet1.KindHautarzt)
        Me.KindKinderarztTableAdapter.Fill(Me.DataSet1.KindKinderarzt)
        Me.KindZahnarztTableAdapter.Fill(Me.DataSet1.KindZahnarzt)
        Me.KindKrankenhausTableAdapter.Fill(Me.DataSet1.KindKrankenhaus)

        Me.KindHNOTableAdapter.Fill(Me.DataSet1.KindHNO)
        Me.HNOTableAdapter.Fill(Me.DataSet1.HNO)
        Me.PsychoTableAdapter.Fill(Me.DataSet1.Psycho)
        Me.KindPsychoTableAdapter.Fill(Me.DataSet1.KindPsycho)
        Label1.Text = Form1.CB_name.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SpeichernButton.Click
        Dim a As DataRow = DataSet1.Bericht.NewRow()

        a("Datum") = DateTimePicker1.Value
        a("Praxis") = ArztNameCombobox.Text
        a("Art") = ArztArtComboBox.Text
        a("Arzt") = PlatzhalterText1.Text
        a("Kind") = Label1.Text
        a("Text") = RichTextBox1.Text
        a("Strasse") = TextBox1.Text
        a("Plz") = TextBox2.Text
        a("Ort") = TextBox3.Text

        DataSet1.Bericht.AddBerichtRow(a)
        Me.BerichtTableAdapter.Update(DataSet1)
        Form1.Bericht1.Daten_laden()

        MsgBox("Speichern erfolgreich")


        Reset()




    End Sub

    Private Sub Reset()
        DateTimePicker1.Value = Date.Now
        RichTextBox1.ResetText()

        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        TextBox4.ResetText()
        ArztArtComboBox.ResetText()
        ArztNameCombobox.ResetText()

    End Sub

    Public Sub KindWechsel()
        DateTimePicker1.Value = Date.Now
        RichTextBox1.ResetText()
        Label1.Text = Form1.CB_name.Text
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        TextBox4.ResetText()
        ArztArtComboBox.ResetText()
        ArztNameCombobox.ResetText()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArztArtComboBox.SelectedIndexChanged
        ArztArt()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArztNameCombobox.SelectedIndexChanged
        ArztArt2()

    End Sub
    ' Je nach Auswahl bei welcher Art Arzt das Kind war, kann man folgend die Praxis/den Arzt in der nächsten Box auswählen
    Public Sub ArztArt()
        Dim ArtText As String = ArztArtComboBox.Text
        Dim name As String = Form1.CB_name.Text

        'If ArtText = "Augenarzt" Then
        '    ReDim name3(DataSet1.Augenarzt.Rows.Count - 1)

        '    For z = 0 To (DataSet1.Augenarzt.Rows.Count - 1)
        '        If name = (DataSet1.KindAugenarzt.Rows(z)("Name")) Then


        '            name3(z) = DataSet1.Augenarzt.Rows(z)("A_Name")
        '        Else
        '            name3(z) = ""
        '        End If

        '    Next

        If ArtText = "Augenarzt" Then
            ReDim name3(DataSet1.KindAugenarzt.Rows.Count - 1)
            Dim name4() As String = {}
            '  ReDim name3() = {}

            For z = 0 To (DataSet1.KindAugenarzt.Rows.Count - 1)
                If name = (DataSet1.KindAugenarzt.Rows(z)("Name")) Then

                    ReDim Preserve name4(0)

                    name4(0) = DataSet1.KindAugenarzt.Rows(z)("A_Name")
                    'If name4.Count = 0 Then


                    '    name4.SetValue(DataSet1.KindAugenarzt.Rows(z)("A_Name"), 0)

                    'Else
                    '    Dim anzahl As Integer = name4.Count
                    '    name4.SetValue(DataSet1.KindAugenarzt.Rows(z)("A_Name"), anzahl)


                    'End If

                End If

            Next
            Label2.Text = "Augenarztbericht"

            ArztNameCombobox.DataSource = name4
            Me.AArztDaten()

        ElseIf ArtText = "Frauenarzt" Then
            ReDim name3(0)

            For z = 0 To (DataSet1.KindFrauenarzt.Rows.Count - 1)
                If name = (DataSet1.KindFrauenarzt.Rows(z)("Name")) Then

                    name3.SetValue(DataSet1.KindFrauenarzt.Rows(z)("F_Name"), 0)

                    ' name3(z) = DataSet1.Augenarzt.Rows(z)("A_Name")
                    '  Else
                    '     name3(z) = ""

                End If

            Next
            Label2.Text = "Frauenarztbericht"

            ArztNameCombobox.DataSource = name3
            Me.FArztDaten()

        ElseIf ArtText = "Kinderarzt" Then
            ReDim name3(0)

            For z = 0 To (DataSet1.KindKinderarzt.Rows.Count - 1)
                If name = (DataSet1.KindKinderarzt.Rows(z)("Name")) Then

                    name3.SetValue(DataSet1.KindKinderarzt.Rows(z)("K_Name"), 0)

                    ' name3(z) = DataSet1.Augenarzt.Rows(z)("A_Name")
                    '  Else
                    '     name3(z) = ""

                End If

            Next
            Label2.Text = "Kinderarztbericht"

            ArztNameCombobox.DataSource = name3
            Me.KArztDaten()

        ElseIf ArtText = "Hautarzt" Then
            ReDim name3(0)

            For z = 0 To (DataSet1.KindHautarzt.Rows.Count - 1)
                If name = (DataSet1.KindHautarzt.Rows(z)("Name")) Then

                    name3.SetValue(DataSet1.KindHautarzt.Rows(z)("H_Name"), 0)

                    ' name3(z) = DataSet1.Augenarzt.Rows(z)("A_Name")
                    '  Else
                    '     name3(z) = ""

                End If

            Next
            Label2.Text = "Hautarztbericht"

            ArztNameCombobox.DataSource = name3
            Me.HArztDaten()

        ElseIf ArtText = "Zahnarzt" Then
            ReDim name3(0)

            For z = 0 To (DataSet1.KindZahnarzt.Rows.Count - 1)
                If name = (DataSet1.KindZahnarzt.Rows(z)("Name")) Then

                    name3.SetValue(DataSet1.KindZahnarzt.Rows(z)("Z_Name"), 0)

                    ' name3(z) = DataSet1.Augenarzt.Rows(z)("A_Name")
                    '  Else
                    '     name3(z) = ""

                End If

            Next
            Label2.Text = "Zahnarztbericht"

            ArztNameCombobox.DataSource = name3
            ZArztDaten()


        ElseIf ArtText = "Krankenhaus" Then
            ReDim name3(0)

            For z = 0 To (DataSet1.KindKrankenhaus.Rows.Count - 1)
                If name = (DataSet1.KindKrankenhaus.Rows(z)("Name")) Then

                    name3.SetValue(DataSet1.KindKrankenhaus.Rows(z)("Kh_Name"), 0)

                    ' name3(z) = DataSet1.Augenarzt.Rows(z)("A_Name")
                    '  Else
                    '     name3(z) = ""

                End If

            Next
            ArztNameCombobox.DataSource = name3
            KhArztDaten()


        ElseIf ArtText = "HNO" Then
            ReDim name3(0)

            For z = 0 To (DataSet1.KindHNO.Rows.Count - 1)
                If name = (DataSet1.KindHNO.Rows(z)("Name")) Then

                    name3.SetValue(DataSet1.KindHNO.Rows(z)("HNO_Name"), 0)

                    ' name3(z) = DataSet1.Augenarzt.Rows(z)("A_Name")
                    '  Else
                    '     name3(z) = ""

                End If

            Next






            'For z = 0 To (DataSet1.KindAugenarzt.Rows.Count - 1)
            '    If name = (DataSet1.KindAugenarzt.Rows(z)("Name")) Then

            '        If name3.Count = 0 Then


            '            name3.SetValue(DataSet1.KindAugenarzt.Rows(z)("A_Name"), 0)

            '        Else
            '            Dim anzahl As Integer = name3.Count
            '            name3.SetValue(DataSet1.KindAugenarzt.Rows(z)("HNO_Name"), anzahl)

            '            ' name3(z) = DataSet1.Augenarzt.Rows(z)("A_Name")
            '            '  Else
            '            '     name3(z) = ""
            '        End If
            '    End If

            ' Next
            Label2.Text = "HNO"
            ArztNameCombobox.DataSource = name3
            HNOArztDaten()

        ElseIf ArtText = "Psychologe" Then
            ReDim name3(0)

            For z = 0 To (DataSet1.KindPsycho.Rows.Count - 1)
                If name = (DataSet1.KindPsycho.Rows(z)("Name")) Then

                    name3.SetValue(DataSet1.KindPsycho.Rows(z)("P_Name"), 0)

                End If

            Next
            Label2.Text = "Psychologe"
            ArztNameCombobox.DataSource = name3
            PsychoArztDaten()


        End If


    End Sub
    'Bei Auswahl eines Arztes/einer Praxis werden die dazugehörigen Kontaktdaten in die Textfelder geladen
    Private Sub ArztArt2()
        Dim ArtText As String = ArztArtComboBox.Text

        If ArtText = "Augenarzt" Then

            Me.AArztDaten()

        ElseIf ArtText = "Frauenarzt" Then

            Me.FArztDaten()

        ElseIf ArtText = "Kinderarzt" Then

            Me.KArztDaten()

        ElseIf ArtText = "Hautarzt" Then

            Me.HArztDaten()

        ElseIf ArtText = "Zahnarzt" Then

            ZArztDaten()


        ElseIf ArtText = "Krankenhaus" Then

            KhArztDaten()


        ElseIf ArtText = "HNO" Then

            HNOArztDaten()

        ElseIf ArtText = "Psychologe" Then
            PsychoArztDaten()

        End If


    End Sub
    ' Kontaktdaten der verschiedenen Ärzte
    Private Sub AArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ArztNameCombobox.Text

        r1 = DataSet1.Augenarzt.Select("A_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)
            Catch ex As Exception
            End Try


        Next k
    End Sub

    Private Sub FArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ArztNameCombobox.Text

        r1 = DataSet1.Frauenarzt.Select("F_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception
            End Try


        Next k
    End Sub

    Private Sub HArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ArztNameCombobox.Text

        r1 = DataSet1.Hautarzt.Select("H_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception


            End Try


        Next k
    End Sub

    Private Sub KArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ArztNameCombobox.Text

        r1 = DataSet1.Kinderarzt.Select("K_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception
            End Try


        Next k
    End Sub

    Private Sub KhArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ArztNameCombobox.Text

        r1 = DataSet1.Krankenhaus.Select("Kh_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception
            End Try


        Next k
    End Sub
    Private Sub ZArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ArztNameCombobox.Text

        r1 = DataSet1.Zahnarzt.Select("Z_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception
            End Try


        Next k
    End Sub
    Private Sub HNOArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ArztNameCombobox.Text

        r1 = DataSet1.HNO.Select("HNO_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception
            End Try


        Next k
    End Sub

    Private Sub PsychoArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ArztNameCombobox.Text

        r1 = DataSet1.Psycho.Select("P_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(4)

            Catch ex As Exception
            End Try


        Next k

    End Sub
End Class
