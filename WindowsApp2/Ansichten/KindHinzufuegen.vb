Public Class KindHinzufuegen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As DataRow



        a = Me.DataSet1.Kind.NewRow()

        ' DateTimePicker1.Format = DateTimePickerFormat.Short



        a("Name") = String.Concat(PlatzhalterText1.Text, " ", PlatzhalterText2.Text)
        ' a("Geburtsdatum") = CDate(TextBox2.Text)
        a("Nationalität") = PlatzhalterText4.Text
        a("Geburtsdatum") = DateTimePicker1.Value
        a("Jugendamt") = PlatzhalterText6.Text
        a("Aufnahmedatum") = DateTimePicker2.Value
        a("Schule") = PlatzhalterText9.Text
        a("Besonderheiten") = PlatzhalterText11.Text
        a("Geburtsort") = PlatzhalterText3.Text
        a("Konfession") = PlatzhalterText5.Text
        a("Hilfe_nach") = PlatzhalterText7.Text
        a("Sorgerechtsstatus") = PlatzhalterText8.Text
        a("Krankenversicherung") = PlatzhalterText10.Text

        Me.DataSet1.Kind.AddKindRow(a)
        Me.KindTableAdapter.Update(DataSet1)


        ResetText()
        Me.Validate()


        Form1.Combotext()

        ResetTextbox()



    End Sub

    Private Sub ResetTextbox()
        PlatzhalterText1.Clear()
        PlatzhalterText2.Clear()
        PlatzhalterText3.Clear()
        PlatzhalterText4.Clear()
        PlatzhalterText5.Clear()
        PlatzhalterText6.Clear()
        PlatzhalterText7.Clear()
        PlatzhalterText8.Clear()
        PlatzhalterText9.Clear()

        PlatzhalterText10.Clear()
        PlatzhalterText11.Clear()
        DateTimePicker1.ResetText()
        DateTimePicker2.ResetText()
        PlatzhalterText1.PlatzHalterText = PlatzhalterText1.PlatzHalterText
        PlatzhalterText2.PlatzHalterText = PlatzhalterText2.PlatzHalterText
        PlatzhalterText3.PlatzHalterText = PlatzhalterText3.PlatzHalterText
        PlatzhalterText4.PlatzHalterText = PlatzhalterText4.PlatzHalterText
        PlatzhalterText5.PlatzHalterText = PlatzhalterText5.PlatzHalterText
        PlatzhalterText6.PlatzHalterText = PlatzhalterText6.PlatzHalterText
        PlatzhalterText7.PlatzHalterText = PlatzhalterText7.PlatzHalterText
        PlatzhalterText8.PlatzHalterText = PlatzhalterText8.PlatzHalterText
        PlatzhalterText9.PlatzHalterText = PlatzhalterText9.PlatzHalterText
        PlatzhalterText10.PlatzHalterText = PlatzhalterText10.PlatzHalterText
        PlatzhalterText11.PlatzHalterText = PlatzhalterText11.PlatzHalterText

    End Sub

    'Private Sub KindBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.KindBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
