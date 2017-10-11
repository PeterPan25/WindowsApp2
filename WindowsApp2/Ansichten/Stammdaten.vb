Public Class Stammdaten
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow
        'Dim mild1 As String
        'Dim mild2 As String
        'Dim mild3 As String
        Dim data2 As New DataSet1.KindDataTable

        a = data2.NewRow()


        'mild1 = TextBox1.Text
        'mild2 = TextBox8.Text
        'mild3 = String.Concat(mild1, " ", mild2)

        a("Name") = String.Concat(TextBox1.Text, " ", TextBox8.Text)

        data2.AddKindRow(a)
        ' Me.DataSet1.Augenarzt.AddAugenarztRow("Name")


        Me.Validate()

        Me.KindTableAdapter.Update(data2)
        Me.TableAdapterManager.UpdateAll(Me.DataSet11)
        Form1.Combotext()
        TextBox1.Clear()
        TextBox8.Clear()



    End Sub
End Class
