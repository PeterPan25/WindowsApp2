﻿Imports WindowsApp2

Public Class F_Peter
    Dim name3 As String() = {"a"}

    Private Sub DatenÄndern()
        '  Dim a As DataRow = DataSet1.Kontakte.FindByKo_Name(ComboBox1.Text)
        Dim z As Integer = 0
        Dim a As DataRow
        a = DataSet1.Kontakte.FindByKo_Name(ComboBox1.Text)
        Dim name1 As String = ComboBox1.Text



        'For z = 0 To (DataSet1.Kontakte.Rows.Count - 1)
        '    If name1 = DataSet1.Kontakte.Rows(z)("Ko_Name") Then
        ' Me.DataSet1.Kontakte.Columns("Hausnummer").Expression = PlatzhalterText4.ToString()
        'a("Hausnummer") = PlatzhalterText4.Text
        PlatzhalterText1.Text = a("Ko_Name").ToString
        'Me.DataSet1.Kontakte.AcceptChanges()
        '    End If
        'Next

        'a("Rolle") = PlatzhalterText7.Text
        'a("Straße") = PlatzhalterText3.Text
        'a("Telefon") = PlatzhalterText8.Text
        'a("Mail") = PlatzhalterText9.Text
        'a("Sonstiges") = PlatzhalterText10.Text
        'a("Ort") = PlatzhalterText6.Text
        'a("Hausnummer") = PlatzhalterText4.Text
        'a("PLZ") = PlatzhalterText5.Text
        Me.DataSet1.AcceptChanges()
        Me.KontakteTableAdapter.Update(Me.DataSet1.Kontakte)



        Me.Validate()


        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Form1.Kontakte1.Daten_laden()
        Me.Close()


    End Sub

    Private Sub DatenAnzeigen()
        Dim name As String = ComboBox1.Text


        ReDim name3(DataSet1.Kontakte.Rows.Count - 1)

        For z = 0 To (DataSet1.Kontakte.Rows.Count - 1)
            If name = DataSet1.Kontakte.Rows(z)("Ko_Name") Then
                'PlatzhalterText1.Text = DataSet1.Kontakte.Rows(z)("Rolle")
                'PlatzhalterText1.Text = DataSet1.Kontakte.Rows(z)("Rolle")
                PlatzhalterText3.Text = DataSet1.Kontakte.Rows(z)("Straße")
                PlatzhalterText4.Text = DataSet1.Kontakte.Rows(z)("Hausnummer")
                PlatzhalterText5.Text = DataSet1.Kontakte.Rows(z)("PLZ")
                PlatzhalterText6.Text = DataSet1.Kontakte.Rows(z)("Ort")
                PlatzhalterText7.Text = DataSet1.Kontakte.Rows(z)("Rolle")
                PlatzhalterText8.Text = DataSet1.Kontakte.Rows(z)("Telefon")
                PlatzhalterText9.Text = DataSet1.Kontakte.Rows(z)("Mail")
                PlatzhalterText10.Text = DataSet1.Kontakte.Rows(z)("Sonstiges")

            End If
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Dim name As String
        '' Dim testzeile As DataRow = DataSet1.TestDataTable.Select
        'name = ComboBox1.Text
        DatenAnzeigen()

    End Sub

    Public Sub Combotext()

        ReDim name3(DataSet1.Kontakte.Rows.Count - 1)

        For z = 0 To (DataSet1.Kontakte.Rows.Count - 1)
            name3(z) = DataSet1.Kontakte.Rows(z)("Ko_Name")
        Next

        ComboBox1.DataSource = name3
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DatenÄndern()
    End Sub

    Private Sub KontakteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.KontakteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub F_Peter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KontakteTableAdapter.Fill(Me.DataSet1.Kontakte)
        Combotext()
    End Sub
End Class