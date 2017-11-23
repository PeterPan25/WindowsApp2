Public Class Krankenhaus
    'Private Sub KindKontakteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.KindKontakteBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub

    Public Sub Daten1_laden()

        Me.KindKontakteTableAdapter.FillBy(Me.DataSet1.KindKontakte)

        Dim data2 As New DataTable
        data2 = Me.DataSet1.KindKontakte

        'gggg


        Me.KindKontakteDataGridView.Update()
    End Sub

    Private Sub Daten2_laden()
        Me.KrankenhausTableAdapter.Fill(Me.DataSet1.Krankenhaus)

        Me.KrankenhausDataGridView.Update()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow = Me.DataSet1.Krankenhaus.NewRow()

        Try
            a("Kh_Name") = PlatzhalterText1.Text
            a("Station") = PlatzhalterText2.Text
            a("Plz") = PlatzhalterText3.Text
            a("Strasse") = PlatzhalterText6.Text
            a("Ort") = PlatzhalterText4.Text
            a("Aufenthaltsgrund") = PlatzhalterText5.Text

            Me.DataSet1.Krankenhaus.AddKrankenhausRow(a)

            Me.KrankenhausTableAdapter.Update(DataSet1)


        Catch ex As Exception
            MsgBox("Hoppla...da is was schief gelaufen")
        End Try

    End Sub



    'Private Sub KindKontakteBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.KindKontakteBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
