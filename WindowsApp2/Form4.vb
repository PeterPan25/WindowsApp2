Public Class F_Hans
    Dim vorname As String
    Dim nachname As String
    Dim datum As String
    Dim schule As String
    Dim daten As New Dictionary(Of String, String)
    Dim testDataTable As New DataSet1.TestDataTable
    Dim testRow As DataSet1.TestRow = testDataTable.NewRow()
    Dim myCol As DataColumn
    Dim myRow As DataRow
    '

    Dim currRows() As DataRow = testDataTable.Select("vorname", "nachname", DataViewRowState.CurrentRows)




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vorname = TextBox1.Text
        nachname = TextBox4.Text
        schule = TextBox2.Text
        datum = TextBox3.Text



        ' daten.Add(key:="schule", value:=schule)

        'customersRow.vorname = vorname
        'customersRow.nachname = nachname
        'customersRow.datum = datum
        'customersRow.schule = schule

        testRow("vorname") = vorname
        testRow("nachname") = nachname
        testRow("schule") = schule
        testRow("datum") = datum

        testDataTable.Rows.Add(testRow)

        For Each myCol In testDataTable.Columns
            Console.Write(testRow.vorname & testRow.nachname & testRow.datum & testRow.schule)
        Next

        Console.WriteLine(vbTab)

        For Each myRow In currRows
            For Each myCol In testDataTable.Columns
                Console.Write(vbTab & myRow(myCol).ToString())
            Next

            Dim rowState As String = System.Enum.GetName(myRow.RowState.GetType(), myRow.RowState)
            Console.WriteLine(vbTab & rowState)
        Next

        ' F_Peter.Show()
    End Sub
End Class