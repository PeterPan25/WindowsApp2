Public Class Schule
    'Private Sub Schule1_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    If TextBox6.Text = Nothing Then TextBox6.Text = "Schule"
    '    TextBox6.ForeColor = Color.Gray
    'End Sub

    'Private Sub TextBox6_doubleclick(sender As Object, e As EventArgs)
    '    If TextBox6.Text = "Schule" Then TextBox6.Clear()
    '    TextBox6.ForeColor = Color.Black
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.BerichtAnlegen1.SchulBericht()
        Form1.BerichtAnlegen1.Visible = True
        Form1.BerichtAnlegen1.BringToFront()

    End Sub

    'Private Sub SchuleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.SchuleBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub

    Private Sub SchulBerichtDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SchulBerichtDataGridView.RowHeaderMouseClick
        Dim str As String
        Dim str1 As String




        str = Me.SchulBerichtDataGridView.Rows(e.RowIndex).Cells(1).Value
        str1 = Me.SchulBerichtDataGridView.Rows(e.RowIndex).Cells(0).Value

        BerichtAnzeigen.Show()

        BerichtAnzeigen.SBDaten_laden(str, str1)

    End Sub

    Public Sub SBDaten_laden()
        Me.SchulBerichtTableAdapter.Fill(DataSet1.SchulBericht)
        Me.SchulBerichtDataGridView.Update()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As DataRow
        a = Me.DataSet1.Schule.NewRow()

        Try
            a("S_Name") = PlatzhalterText1.Text
            a("Schulart") = PlatzhalterText2.Text
            a("Strasse") = PlatzhalterText3.Text
            a("Plz") = PlatzhalterText4.Text
            a("Ort") = PlatzhalterText5.Text
            a("Klasse") = PlatzhalterText6.Text
            a("Klassenlehrer") = PlatzhalterText7.Text
            a("vDatum") = DateTimePicker1.Value
            a("bDatum") = DateTimePicker2.Value

            Me.DataSet1.Schule.AddSchuleRow(a)
            Me.SchuleTableAdapter.Update(Me.DataSet1.Schule)
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)
            Me.SchuleDataGridView.Update()


            MsgBox("Speichern erfolgreich")

        Catch ex As Exception
            MsgBox("Speichern fehlgeschlagen")

        End Try
    End Sub


End Class
