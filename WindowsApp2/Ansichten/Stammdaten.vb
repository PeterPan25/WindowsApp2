Public Class Stammdaten
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow
        'Dim mild1 As Date
        'Dim mild2 As String
        'Dim mild3 As String
        Dim data2 As New DataSet1.KindDataTable
        Dim myRow As DataRow
        Dim myCol As DataColumn
        TableAdapterManager.KindTableAdapter.Fill(data2)
        a = data2.NewRow()

        DateTimePicker1.Format = DateTimePickerFormat.Short



        'mild1 = TextBox1.Text
        'mild2 = TextBox8.Text
        'mild3 = String.Concat(mild1, " ", mild2)

        a("Name") = String.Concat(TextBox1.Text, " ", TextBox8.Text)
        ' a("Geburtsdatum") = CDate(TextBox2.Text)
        a("Nationalität") = TextBox3.Text
        a("Geburtsdatum") = DateTimePicker1.Value



        data2.AddKindRow(a)
        ' Me.DataSet1.Augenarzt.AddAugenarztRow("Name")


        Me.Validate()

        Me.KindTableAdapter.Update(data2)
        Me.TableAdapterManager.UpdateAll(Me.DataSet11)
        Form1.Combotext()
        TextBox1.Clear()
        TextBox8.Clear()

        For Each myRow In data2.Rows
            For Each myCol In data2.Columns
                Console.WriteLine(vbTab & myRow(myCol).ToString())
            Next
        Next

    End Sub
End Class
