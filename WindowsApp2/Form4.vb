Public Class F_Hans
    Dim vorname As String
    Dim nachname As String
    Dim datum As String
    Dim schule As String
    Dim daten As New Dictionary(Of String, String)
    Dim testDataTable As New DataSet1.TestDataTable

    Dim testRow2 As DataSet1.TestRow = testDataTable.NewRow()

    Dim myCol As DataColumn
    Dim myRow As DataRow

    Dim testColumn As DataColumn = testDataTable.Columns.Add




    Dim currRows() As DataRow = testDataTable.Select("vorname", "nachname", DataViewRowState.CurrentRows)

    'https://msdn.microsoft.com/de-de/library/system.data.datatable.newrow(v=vs.110).aspx


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'testColumn.AutoIncrement = True
        'testColumn.AutoIncrementSeed = 0
        'testColumn.AutoIncrementStep = 1
        Dim testRow As DataSet1.TestRow = testDataTable.NewRow()

        vorname = TextBox1.Text
        nachname = TextBox4.Text
        schule = TextBox2.Text
        datum = TextBox3.Text


        ' daten.Add(key:="schule", value:=schule)

        testRow.vorname = vorname
        testRow.nachname = nachname
        testRow.datum = datum
        testRow.schule = schule

        'testRow("vorname") = vorname
        'testRow("nachname") = nachname
        'testRow("schule") = schule
        'testRow("datum") = datum

        testDataTable.Rows.Add(testRow)

        ' For Each myCol In testDataTable.Columns
        Console.Write(testRow.vorname & vbTab & testRow.nachname) '& testRow.datum & testRow.schule)
        'Next

        Console.WriteLine(vbTab & "Hallo")

        For Each myRow In currRows
            For Each myCol In testDataTable.Columns
                Console.Write(vbTab & myRow(myCol).ToString())
            Next

            Dim rowState As String = System.Enum.GetName(myRow.RowState.GetType(), myRow.RowState)
            Console.WriteLine(vbTab & rowState)
        Next

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub jaklar()


        For Each myRow In testDataTable.Rows
            For Each myCol In testDataTable.Columns
                Console.WriteLine(myRow(myCol))
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        jaklar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        F_Peter.Show()
    End Sub
End Class