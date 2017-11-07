Public Class F_Aaliyah


    Private Sub F_Aaliyah_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KontakteTableAdapter.Fill(Me.DataSet1.Kontakte)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.KindKontakte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KindKontakteTableAdapter.Fill(Me.DataSet1.KindKontakte)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KontakteTableAdapter.Fill(Me.DataSet1.Kontakte)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.KindKontakte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KindKontakteTableAdapter.Fill(Me.DataSet1.KindKontakte)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.KindKontakte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KindKontakteTableAdapter.Fill(Me.DataSet1.KindKontakte)


        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KontakteTableAdapter.Fill(Me.DataSet1.Kontakte)
        If TextBox1.Text = Nothing Then TextBox1.Text = "Name"
        If TextBox2.Text = Nothing Then TextBox2.Text = "Kind"
        If TextBox3.Text = Nothing Then TextBox3.Text = "Rolle"
        If TextBox4.Text = Nothing Then TextBox4.Text = "Straße"
        If TextBox5.Text = Nothing Then TextBox5.Text = "Telefon"
        If TextBox6.Text = Nothing Then TextBox6.Text = "Mail"
        If TextBox7.Text = Nothing Then TextBox7.Text = "Sonstiges"
        If TextBox8.Text = Nothing Then TextBox8.Text = "Postleitzahl"
        If TextBox9.Text = Nothing Then TextBox9.Text = "Ort"
        If TextBox10.Text = Nothing Then TextBox10.Text = "Hausnummer"
        If TextBox11.Text = Nothing Then TextBox11.Text = "Vorname"
        TextBox1.ForeColor = Color.Gray
        TextBox2.ForeColor = Color.Gray
        TextBox3.ForeColor = Color.Gray
        TextBox4.ForeColor = Color.Gray
        TextBox5.ForeColor = Color.Gray
        TextBox6.ForeColor = Color.Gray
        TextBox7.ForeColor = Color.Gray
        TextBox8.ForeColor = Color.Gray
        TextBox9.ForeColor = Color.Gray
        TextBox10.ForeColor = Color.Gray
        TextBox11.ForeColor = Color.Gray



    End Sub

    Private Sub TextBox1_doubleclick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        If TextBox1.Text = "Name" Then TextBox1.Clear()
        TextBox1.ForeColor = Color.Black
    End Sub
    Private Sub TextBox2_doubleclick(sender As Object, e As EventArgs) Handles TextBox2.DoubleClick
        If TextBox2.Text = "Kind" Then TextBox2.Clear()
        TextBox2.ForeColor = Color.Black
    End Sub
    Private Sub TextBox3_doubleclick(sender As Object, e As EventArgs) Handles TextBox3.DoubleClick
        If TextBox3.Text = "Rolle" Then TextBox3.Clear()
        TextBox3.ForeColor = Color.Black
    End Sub


    Private Sub TextBox4_doubleclick(sender As Object, e As EventArgs) Handles TextBox4.DoubleClick
        If TextBox4.Text = "Straße" Then TextBox4.Clear()
        TextBox4.ForeColor = Color.Black
    End Sub

    Private Sub TextBox5_doubleclick(sender As Object, e As EventArgs) Handles TextBox5.DoubleClick
        If TextBox5.Text = "Telefon" Then TextBox5.Clear()
        TextBox5.ForeColor = Color.Black
    End Sub
    Private Sub TextBox6_doubleclick(sender As Object, e As EventArgs) Handles TextBox6.DoubleClick, TextBox7.DoubleClick
        If TextBox6.Text = "Mail" Then TextBox6.Clear()
        TextBox6.ForeColor = Color.Black
    End Sub
    Private Sub TextBox7_doubleclick(sender As Object, e As EventArgs) Handles TextBox7.DoubleClick
        If TextBox7.Text = "Sonstiges" Then TextBox7.Clear()
        TextBox7.ForeColor = Color.Black
    End Sub

    Private Sub TextBox8_doubleclick(sender As Object, e As EventArgs) Handles TextBox8.DoubleClick
        If TextBox8.Text = "Postleitzahl" Then TextBox8.Clear()
        TextBox8.ForeColor = Color.Black
    End Sub
    Private Sub TextBox9_doubleclick(sender As Object, e As EventArgs) Handles TextBox9.DoubleClick
        If TextBox9.Text = "Ort" Then TextBox9.Clear()
        TextBox9.ForeColor = Color.Black
    End Sub
    Private Sub TextBox10_doubleclick(sender As Object, e As EventArgs) Handles TextBox10.DoubleClick
        If TextBox10.Text = "Hausnummer" Then TextBox10.Clear()
        TextBox10.ForeColor = Color.Black
    End Sub
    Private Sub TextBox11_doubleclick(sender As Object, e As EventArgs)
        If TextBox11.Text = "Vorname" Then TextBox10.Clear()
        TextBox11.ForeColor = Color.Black
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow


        'Dim data2 As New DataSet1.KontakteDataTable
        'Dim data3 As New DataSet1.KindKontakteDataTable
        ''Dim myRow As DataRow
        ''Dim myCol As DataColumn
        'TableAdapterManager.KontakteTableAdapter.Fill(data2)
        'TableAdapterManager.KindKontakteTableAdapter.Fill(data3)
        'a = data2.NewRow()
        'b = data3.NewRow()
        a = Me.DataSet1.Kontakte.NewRow()





        a("Ko_Name") = String.Concat(TextBox11.Text, " ", TextBox1.Text)

        ' a("Geburtsdatum") = CDate(TextBox2.Text)

        a("Rolle") = TextBox3.Text
        a("Straße") = TextBox4.Text
        a("Telefon") = TextBox5.Text
        a("Mail") = TextBox6.Text
        a("Sonstiges") = TextBox7.Text
        a("Ort") = TextBox9.Text
        a("Hausnummer") = TextBox10.Text
        a("PLZ") = TextBox8.Text

        Me.DataSet1.Kontakte.AddKontakteRow(a)

        Console.WriteLine("1")
        'data2.AddKontakteRow(a)
        'data3.AddKindKontakteRow(b)


        Me.Validate()

        'Me.KontakteTableAdapter.Update(data2)
        'Me.KindKontakteTableAdapter.Update(data3)
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Form1.Kontakte1.Daten_laden()
        Me.daten_anlegen()
        ' Form1.Kontakte1.KontakteDataGridView.Update()


    End Sub

    Private Sub KontakteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.KontakteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub
    Private Sub daten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindKontakte.NewRow()

        b("Ko_Name") = String.Concat(TextBox11.Text, " ", TextBox1.Text)
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindKontakte.AddKindKontakteRow(b)
        Console.WriteLine("2")
        Me.Validate()

        'Me.KontakteTableAdapter.Update(data2)
        'Me.KindKontakteTableAdapter.Update(data3)
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        Form1.Krankenhaus1.Daten1_laden()

        Me.Close()
    End Sub

    Private Sub KindKontakteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.KindKontakteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub KindKontakteBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.KindKontakteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim item As New ListViewItem
    'With Kontakte.ListView1.Items.add(Me.TextBox1.Text)
    '    item.SubItems.Add(Me.TextBox2.Text)
    '    item.SubItems.Add(Me.TextBox3.Text)
    '    item.SubItems.Add(Me.TextBox4.Text)
    '    item.SubItems.Add(Me.TextBox5.Text)
    '    item.SubItems.Add(Me.TextBox6.Text)
    '    item.SubItems.Add(Me.TextBox7.Text)
    '    End With
    'End Sub
End Class