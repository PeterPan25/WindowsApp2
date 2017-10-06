Public Class Augenarzt
    'Private Sub AugenarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.AugenarztBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mild1 As String
        Dim mild2 As String
        Dim mild3 As String
        Dim mild4 As String
        Dim mild5 As String
        Dim mild6 As Date
        Dim a As DataRow
        a = Me.DataSet1.Augenarzt.NewRow()
        'Dim b As DataRow
        'b = Me.DataSet1.Augenarzt.NewRow()
        'Dim c As DataRow
        'c = Me.DataSet1.Augenarzt.NewRow()
        'Dim d As DataRow
        'd = Me.DataSet1.Augenarzt.NewRow()
        'Dim e As DataRow
        'e = Me.DataSet1.Augenarzt.NewRow()

        mild1 = TextBox1.Text
        mild2 = TextBox2.Text
        mild3 = TextBox3.Text
        mild4 = TextBox4.Text
        mild5 = TextBox5.Text
        mild6 = DateTimePicker1.Value


        a("A_Name") = mild1
        a("Name") = mild2
        a("Ort") = mild3
        a("Plz") = mild4
        a("Strasse") = mild5
        a("Datum") = mild6
        Me.DataSet1.Augenarzt.AddAugenarztRow(a)
        ' Me.DataSet1.Augenarzt.AddAugenarztRow("Name")


        Me.Validate()
        Me.AugenarztBindingSource.EndEdit()
        Me.AugenarztTableAdapter.Update(Me.DataSet1.Augenarzt)
        '  Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    End Sub



    Private Sub AugenarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AugenarztBindingSource.EndEdit()
        '  Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.AugenarztTableAdapter.FillBy(Me.DataSet1.Augenarzt)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
