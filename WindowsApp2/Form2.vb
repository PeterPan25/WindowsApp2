Public Class F_Aaliyah
    Dim name3 As String() = {"a"}


    Private Sub F_Aaliyah_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.KontakteTableAdapter.Fill(Me.DataSet1.Kontakte)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.KindKontakte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KindKontakteTableAdapter.Fill(Me.DataSet1.KindKontakte)



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


        Try
            a("Ko_Name") = String.Concat(PlatzhalterText2.Text, " ", PlatzhalterText1.Text)

            ' a("Geburtsdatum") = CDate(TextBox2.Text)

            a("Rolle") = PlatzhalterText3.Text
            a("Straße") = PlatzhalterText10.Text
            a("Telefon") = PlatzhalterText5.Text
            a("Mail") = PlatzhalterText6.Text
            a("Sonstiges") = PlatzhalterText7.Text
            a("Ort") = PlatzhalterText9.Text
            a("Hausnummer") = PlatzhalterText11.Text
            a("PLZ") = PlatzhalterText8.Text

            Me.DataSet1.Kontakte.AddKontakteRow(a)




            Me.Validate()


            Me.TableAdapterManager.UpdateAll(Me.DataSet1)
            Form1.Kontakte1.Daten_laden()
            Me.Daten_anlegen()

        Catch ex As Exception

            ReDim name3(Me.DataSet1.Kontakte.Rows.Count - 1)


            For z = 0 To (Me.DataSet1.Kontakte.Rows.Count - 1)
                name3(z) = Me.DataSet1.Kontakte.Rows(z)("Ko_Name")
                If a("Ko_Name") = name3(z) Then
                    Daten_anlegen()
                End If
            Next


        End Try





    End Sub

    Private Sub KontakteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.KontakteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub
    Private Sub Daten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindKontakte.NewRow()

        b("Ko_Name") = String.Concat(PlatzhalterText2.Text, " ", PlatzhalterText1.Text)
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