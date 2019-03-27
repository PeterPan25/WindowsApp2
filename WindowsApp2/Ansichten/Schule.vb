﻿Public Class Schule
    'Private Sub Schule1_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    If TextBox6.Text = Nothing Then TextBox6.Text = "Schule"
    '    TextBox6.ForeColor = Color.Gray
    'End Sub

    'Private Sub TextBox6_doubleclick(sender As Object, e As EventArgs)
    '    If TextBox6.Text = "Schule" Then TextBox6.Clear()
    '    TextBox6.ForeColor = Color.Black
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.BerichtAnlegen1.SchulBericht()
        Form1.BerichtAnlegen1.Visible = True
        Form1.BerichtAnlegen1.BringToFront()

    End Sub

    'Private Sub SchuleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.SchuleBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub

    Private Sub SchulBerichtDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SchulBerichtDataGridView.RowHeaderMouseClick
        Dim str As String
        Dim str1 As String




        str = Me.SchulBerichtDataGridView.Rows(e.RowIndex).Cells(1).Value
        str1 = Me.SchulBerichtDataGridView.Rows(e.RowIndex).Cells(0).Value

        BerichtAnzeigen.Show()

        BerichtAnzeigen.SBDaten_laden(str, str1)

    End Sub

    Public Sub SBDaten_laden()
        Me.SchuleTableAdapter.Fill(DataSet1.Schule)
        Me.KindSchuleTableAdapter.Fill(DataSet1.KindSchule)
        Me.SchulDatenTableAdapter.Fill(DataSet1.SchulDaten)

        Me.SchulBerichtTableAdapter.Fill(DataSet1.SchulBericht)
        Me.SchulBerichtBindingSource.Filter = "Kind = '" & Form1.CB_name.Text & "'"
        Me.SchulBerichtDataGridView.Update()
        Me.SchulDatenBindingSource.Filter = "Name = '" & Form1.CB_name.Text & "'"

        SchulDatenDataGridView.Sort(SchulDatenDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)

        Me.SchulDatenDataGridView.Update()


    End Sub





End Class
