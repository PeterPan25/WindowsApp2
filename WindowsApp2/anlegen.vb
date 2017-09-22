Public Class anlegen
    Dim testtable As New DataSet1.TestDataTable
    Dim test As String
    Dim myCol As DataColumn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim testrow As DataRow
        testrow = testtable.NewRow()

        Label1.Text = TextBox1.Text
        test = TextBox1.Text

        testrow("vorname") = test
        testtable.Rows.Add(testrow)
        testtable.AcceptChanges()


        For Each testrow In testtable.Rows
            For Each myCol In testtable.Columns
                Console.WriteLine(testrow(myCol))
            Next
        Next


    End Sub
End Class
