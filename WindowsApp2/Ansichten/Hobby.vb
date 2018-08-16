Public Class Hobby


    Private Sub NachrichtDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles NachrichtDataGridView.RowHeaderMouseClick
        Dim str As String
        Dim str1 As String
        Dim str2 As String
        Dim str3 As Date



        '  Me.BerichtDataGridView.Rows(e.RowIndex).Selected = True

        str = Me.NachrichtDataGridView.Rows(e.RowIndex).Cells(5).Value
        str1 = Me.NachrichtDataGridView.Rows(e.RowIndex).Cells(4).Value
        str2 = Me.NachrichtDataGridView.Rows(e.RowIndex).Cells(0).Value
        str3 = Me.NachrichtDataGridView.Rows(e.RowIndex).Cells(1).Value

        Form5.Show()
        Form5.Nachricht_laden(str, str1, str2, str3)
    End Sub

    Public Sub Daten_laden()
        Dim EmpfängerInfo As New AktuellerBenutzer
        Dim Empfänger As String
        Dim k As Integer
        Dim Name As String = ""

        Dim r2() As DataRow

        MitarbeiterTableAdapter.Fill(DataSet1.Mitarbeiter)

        Empfänger = EmpfängerInfo.Benutzer_nennen

        r2 = DataSet1.Mitarbeiter.Select("Benutzername = '" & Empfänger & "'")

        For k = 0 To r2.GetUpperBound(0)
            Name = r2(k)(1)
        Next



        ' NachrichtDataGridView.DataSource = NachrichtBindingSource.Filter

        NachrichtTableAdapter.Fill(DataSet1.Nachricht)

        NachrichtBindingSource.Filter = "Empfänger = '" & Name & "'"

        ''Nachrichten je nach Nutzer
        'Dim r1() As DataRow

        'r1 =
        'r1 = DataSet1.Nachricht.Select("Empfänger = '" & Name & "'")
        'Me.NachrichtDataGridView.DataSource = r1

        NachrichtDataGridView.Update()

    End Sub


End Class
