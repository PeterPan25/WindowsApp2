Public Class ArztUebersicht
    Dim name3 As String() = {"a"}
    Private Sub AugenarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AugenarztBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub
    '*****
    ' Private Sub Anzeige() Handles ComboBox1.SelectedIndexChanged
    ' Me.AugenarztTableAdapter.Fill(DataSet1.Augenarzt)

    '  Combotext()


    ' End Sub
    Public Sub Arzt_Load()
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
        Reset()

    End Sub



    Private Sub Combotext() Handles ComboBox1.SelectedIndexChanged
        Reset()
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

    End Sub
    Private Sub Reset()
        ComboBox2.Text = ""
        Label6.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label3.Text = ""
        Label2.Text = ""
    End Sub
    Private Sub DatenAnzeigen() Handles ComboBox2.SelectedIndexChanged
        Dim name As String = ComboBox2.Text

        Dim ArtText2 As String = ComboBox1.Text
        If ArtText2 = "Augenarzt" Then
            ReDim name3(DataSet1.Augenarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Augenarzt.Rows.Count - 1)
                If name = DataSet1.Augenarzt.Rows(z)("A_Name") Then
                    Label6.Text = DataSet1.Augenarzt.Rows(z)("Straße")
                    Label4.Text = DataSet1.Augenarzt.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Augenarzt.Rows(z)("Ort")
                    Label3.Text = DataSet1.Augenarzt.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Augenarzt.Rows(z)("A_Name")

                End If
            Next

        ElseIf ArtText2 = "Frauenarzt" Then
            ReDim name3(DataSet1.Frauenarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Frauenarzt.Rows.Count - 1)
                If name = DataSet1.Frauenarzt.Rows(z)("F_Name") Then
                    Label6.Text = DataSet1.Frauenarzt.Rows(z)("Straße")
                    Label4.Text = DataSet1.Frauenarzt.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Frauenarzt.Rows(z)("Ort")
                    Label3.Text = DataSet1.Frauenarzt.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Frauenarzt.Rows(z)("F_Name")
                End If
            Next

        ElseIf ArtText2 = "Kinderarzt" Then
            ReDim name3(DataSet1.Kinderarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Kinderarzt.Rows.Count - 1)
                If name = DataSet1.Kinderarzt.Rows(z)("K_Name") Then
                    Label6.Text = DataSet1.Kinderarzt.Rows(z)("Straße")
                    Label4.Text = DataSet1.Kinderarzt.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Kinderarzt.Rows(z)("Ort")
                    Label3.Text = DataSet1.Kinderarzt.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Kinderarzt.Rows(z)("K_Name")
                End If
            Next

        ElseIf ArtText2 = "Hautarzt" Then
            ReDim name3(DataSet1.Hautarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Hautarzt.Rows.Count - 1)
                If name = DataSet1.Hautarzt.Rows(z)("H_Name") Then
                    Label6.Text = DataSet1.Hautarzt.Rows(z)("Straße")
                    Label4.Text = DataSet1.Hautarzt.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Hautarzt.Rows(z)("Ort")
                    Label3.Text = DataSet1.Hautarzt.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Hautarzt.Rows(z)("H_Name")
                End If
            Next

        ElseIf ArtText2 = "Zahnarzt" Then
            ReDim name3(DataSet1.Zahnarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Zahnarzt.Rows.Count - 1)
                If name = DataSet1.Zahnarzt.Rows(z)("Z_Name") Then
                    Label6.Text = DataSet1.Zahnarzt.Rows(z)("Straße")
                    Label4.Text = DataSet1.Zahnarzt.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Zahnarzt.Rows(z)("Ort")
                    Label3.Text = DataSet1.Zahnarzt.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Zahnarzt.Rows(z)("Z_Name")
                End If
            Next

        ElseIf ArtText2 = "HNO-Arzt" Then
            ReDim name3(DataSet1.HNO.Rows.Count - 1)

            For z = 0 To (DataSet1.HNO.Rows.Count - 1)
                If name = DataSet1.HNO.Rows(z)("HNO_Name") Then
                    Label6.Text = DataSet1.HNO.Rows(z)("Straße")
                    Label4.Text = DataSet1.HNO.Rows(z)("PLZ")
                    Label5.Text = DataSet1.HNO.Rows(z)("Ort")
                    Label3.Text = DataSet1.HNO.Rows(z)("Telefon")
                    Label2.Text = DataSet1.HNO.Rows(z)("HNO_Name")

                End If
            Next



        End If


    End Sub
End Class
