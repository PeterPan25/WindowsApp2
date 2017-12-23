Public Class ArztUebersicht
    Dim name3 As String() = {"a"}
    Private Sub AugenarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AugenarztBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Anzeige() Handles ComboBox1.SelectedIndexChanged
        Combotext()

    End Sub

    Private Sub Combotext()

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

    Private Sub DatenAnzeigen() Handles ComboBox2.SelectedIndexChanged
        Dim name As String = ComboBox2.Text

        Dim ArtText As String = ComboBox1.Text
        If ArtText = "Augenarzt" Then
            ReDim name3(DataSet1.Augenarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Augenarzt.Rows.Count - 1)
                If name = DataSet1.Augenarzt.Rows(z)("A_Name") Then
                    Label6.Text = DataSet1.Kontakte.Rows(z)("Straße")
                    Label4.Text = DataSet1.Kontakte.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Kontakte.Rows(z)("Ort")
                    Label3.Text = DataSet1.Kontakte.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Kontakte.Rows(z)("A_Name")

                End If
            Next

        ElseIf ArtText = "Frauenarzt" Then
            ReDim name3(DataSet1.Frauenarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Frauenarzt.Rows.Count - 1)
                If name = DataSet1.Frauenarzt.Rows(z)("F_Name") Then
                    Label6.Text = DataSet1.Kontakte.Rows(z)("Straße")
                    Label4.Text = DataSet1.Kontakte.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Kontakte.Rows(z)("Ort")
                    Label3.Text = DataSet1.Kontakte.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Kontakte.Rows(z)("F_Name")
                End If
            Next

        ElseIf ArtText = "Kinderarzt" Then
            ReDim name3(DataSet1.Kinderarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Kinderarzt.Rows.Count - 1)
                If name = DataSet1.Kinderarzt.Rows(z)("K_Name") Then
                    Label6.Text = DataSet1.Kontakte.Rows(z)("Straße")
                    Label4.Text = DataSet1.Kontakte.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Kontakte.Rows(z)("Ort")
                    Label3.Text = DataSet1.Kontakte.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Kontakte.Rows(z)("K_Name")
                End If
            Next

        ElseIf ArtText = "Hautarzt" Then
            ReDim name3(DataSet1.Hautarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Hautarzt.Rows.Count - 1)
                If name = DataSet1.Hautarzt.Rows(z)("H_Name") Then
                    Label6.Text = DataSet1.Kontakte.Rows(z)("Straße")
                    Label4.Text = DataSet1.Kontakte.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Kontakte.Rows(z)("Ort")
                    Label3.Text = DataSet1.Kontakte.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Kontakte.Rows(z)("H_Name")
                End If
            Next

        ElseIf ArtText = "Zahnarzt" Then
            ReDim name3(DataSet1.Zahnarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Zahnarzt.Rows.Count - 1)
                If name = DataSet1.Zahnarzt.Rows(z)("Z_Name") Then
                    Label6.Text = DataSet1.Kontakte.Rows(z)("Straße")
                    Label4.Text = DataSet1.Kontakte.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Kontakte.Rows(z)("Ort")
                    Label3.Text = DataSet1.Kontakte.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Kontakte.Rows(z)("Z_Name")
                End If
            Next

        ElseIf ArtText = "HNO-Arzt" Then
            ReDim name3(DataSet1.HNO.Rows.Count - 1)

            For z = 0 To (DataSet1.HNO.Rows.Count - 1)
                If name = DataSet1.HNO.Rows(z)("HNO_Name") Then
                    Label6.Text = DataSet1.Kontakte.Rows(z)("Straße")
                    Label4.Text = DataSet1.Kontakte.Rows(z)("PLZ")
                    Label5.Text = DataSet1.Kontakte.Rows(z)("Ort")
                    Label3.Text = DataSet1.Kontakte.Rows(z)("Telefon")
                    Label2.Text = DataSet1.Kontakte.Rows(z)("HNO_Name")

                End If
            Next



        End If


    End Sub
End Class
