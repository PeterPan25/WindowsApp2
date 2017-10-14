Public Class Stammdaten
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow

        Dim data2 As New DataSet1.KindDataTable
        Dim myRow As DataRow
        Dim myCol As DataColumn
        TableAdapterManager.KindTableAdapter.Fill(data2)
        a = data2.NewRow()

        DateTimePicker1.Format = DateTimePickerFormat.Short





        a("Name") = String.Concat(TextBox1.Text, " ", TextBox8.Text)
        ' a("Geburtsdatum") = CDate(TextBox2.Text)
        a("Nationalität") = TextBox3.Text
        a("Geburtsdatum") = DateTimePicker1.Value
        a("Jugendamt") = TextBox4.Text
        a("Aufnahmedatum") = DateTimePicker2.Value
        a("Schule") = TextBox6.Text
        a("Besonderheiten") = TextBox7.Text
        a("Geburtsort") = TextBox9.Text
        a("Konfession") = TextBox10.Text
        a("Hilfe_nach") = TextBox11.Text
        a("Sorgerechtsstatus") = TextBox12.Text
        a("Krankenversicherung") = TextBox13.Text


        data2.AddKindRow(a)



        Me.Validate()

        Me.KindTableAdapter.Update(data2)
        Me.TableAdapterManager.UpdateAll(Me.DataSet11)
        Form1.Combotext()
        TextBox1.Clear()
        TextBox8.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()



        For Each myRow In data2.Rows
            For Each myCol In data2.Columns
                Console.WriteLine(vbTab & myRow(myCol).ToString())
            Next
        Next

    End Sub
End Class
