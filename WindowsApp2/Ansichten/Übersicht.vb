﻿Public Class Übersicht

    Private Shared Property Empfänger As String
    Dim k As Integer
    Private Shared Property r2 As DataRow()
    Private Shared Property BenutzerName As String = ""


    Private Sub NachrichtDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles NachrichtDataGridView.RowHeaderMouseClick
        Dim str As String
        Dim str1 As String
        Dim str2 As String
        Dim str3 As Date



        '  Me.BerichtDataGridView.Rows(e.RowIndex).Selected = True

        str = BenutzerName
        str1 = Me.NachrichtDataGridView.Rows(e.RowIndex).Cells(2).Value
        str2 = Me.NachrichtDataGridView.Rows(e.RowIndex).Cells(0).Value
        str3 = Me.NachrichtDataGridView.Rows(e.RowIndex).Cells(1).Value

        Form5.Show()
        Form5.Nachricht_laden(str, str1, str2, str3)
    End Sub


    Private Sub Filtern()
        Dim EmpfängerInfo As New AktuellerBenutzer
        'Dim Empfänger As String

        '   Dim Name As String = ""

        '   Dim r2() As DataRow

        '   MitarbeiterTableAdapter.Fill(DataSet1.Mitarbeiter)

        ' Empfänger = EmpfängerInfo.Benutzer_nennen


        If Me.RadioButton1.Checked = True Then
            'r2 = DataSet1.Mitarbeiter.Select("Benutzername = '" & Empfänger & "'")

            'For k = 0 To r2.GetUpperBound(0)
            '    Name = r2(k)(1)
            'Next 


            NachrichtTableAdapter.Fill(DataSet1.Nachricht)

            NachrichtBindingSource.Filter = "Empfänger = '" & BenutzerName & "' AND Gelesen = '" & 0 & "'"
            If NachrichtBindingSource.Count > 0 Then

                NotifyIcon1.Icon = SystemIcons.Exclamation


                NotifyIcon1.BalloonTipText = "Sie haben ungelesene Nachrichten!"
                NotifyIcon1.ShowBalloonTip(3)

            End If
            NachrichtDataGridView.Update()

        ElseIf RadioButton2.Checked = True Then
            'r2 = DataSet1.Mitarbeiter.Select("Benutzername = '" & Empfänger & "'")

            'For k = 0 To r2.GetUpperBound(0)
            '    Name = r2(k)(1)
            'Next

            NachrichtTableAdapter.Fill(DataSet1.Nachricht)


            NachrichtBindingSource.Filter = "Empfänger = '" & BenutzerName & "'"


            NachrichtDataGridView.Update()
        End If



    End Sub

    Public Sub Filtern2()
        TerminTableAdapter.Fill(DataSet1.Termin)
        Try
            TerminBindingSource.Filter = "Name = '" & Form1.CB_name.Text & "'" ' AND Gelesen = '" & 0 & "'"
            TerminDataGridView.Update()

        Catch ex As Exception

        End Try


    End Sub

    Public Sub Daten_laden()
        Dim EmpfängerInfo As New AktuellerBenutzer
        'Dim Empfänger As String
        ' Dim k As Integer
        ' Dim Name As String = ""

        ' Dim r2() As DataRow
        TerminTableAdapter.Fill(DataSet1.Termin)
        TerminDataGridView.Update()

        MitarbeiterTableAdapter.Fill(DataSet1.Mitarbeiter)

        Empfänger = EmpfängerInfo.Benutzer_nennen
        Label1.Text = "Moin " + Empfänger

        Me.RadioButton1.Checked = True

        r2 = DataSet1.Mitarbeiter.Select("Benutzername = '" & Empfänger & "'")

        For k = 0 To r2.GetUpperBound(0)
            BenutzerName = r2(k)(9) + " " + r2(k)(8)
        Next

        NachrichtTableAdapter.Fill(DataSet1.Nachricht)

        NachrichtBindingSource.Filter = "Empfänger = '" & BenutzerName & "' AND Gelesen = '" & 0 & "'"
        NachrichtDataGridView.Update()


    End Sub



    Private Sub MitarbeiterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MitarbeiterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Filtern()

    End Sub

    Private Sub TerminDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TerminDataGridView.RowHeaderMouseClick
        Dim str As String
        Dim str1 As String
        Dim str3 As Date



        '  Me.BerichtDataGridView.Rows(e.RowIndex).Selected = True

        str = Me.TerminDataGridView.Rows(e.RowIndex).Cells(0).Value
        str1 = Me.TerminDataGridView.Rows(e.RowIndex).Cells(1).Value
        str3 = Me.TerminDataGridView.Rows(e.RowIndex).Cells(2).Value

        Form6TerminDetail.Show()
        Form6TerminDetail.Termin_laden(str, str1, str3)

    End Sub
End Class
