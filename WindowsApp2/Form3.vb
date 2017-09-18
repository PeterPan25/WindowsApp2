Public Class F_Peter
    Dim myCol As DataColumn
    Dim myRow As DataRow
    Dim testtable As New DataSet1.TestDataTable

    Dim currRows() As DataRow = testtable.Select("vorname", "nachname", DataViewRowState.CurrentRows)

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim name As String
        ' Dim testzeile As DataRow = DataSet1.TestDataTable.Select


        name = ComboBox1.Text

        If name = SplitContainer1.Name Then
            SplitContainer1.Show()
        ElseIf name = SplitContainer2.Name Then
            SplitContainer2.Show()
        ElseIf name = SplitContainer3.Name Then
            SplitContainer3.Show()
        End If
    End Sub

    Private Sub labeltext()
        If (currRows.Length < 1) Then
            Console.WriteLine("No Current Rows Found")
        Else
            For Each myCol In testtable.Columns
                Console.Write(vbTab & myCol.ColumnName)
            Next

            Console.WriteLine(vbTab & "RowState")

            For Each myRow In currRows
                For Each myCol In testtable.Columns
                    Console.Write(vbTab & myRow(myCol).ToString())
                Next

                Dim rowState As String = System.Enum.GetName(myRow.RowState.GetType(), myRow.RowState)
                Console.WriteLine(vbTab & rowState)
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        labeltext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        F_Hans.Show()
    End Sub
End Class