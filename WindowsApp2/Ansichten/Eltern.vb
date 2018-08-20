Public Class Eltern
    Dim ButtonName As New ToolTip
    Dim KindName As DataSet1.KindRow

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.BerichtAnlegen1.ElternBericht()
        Form1.BerichtAnlegen1.Visible = True
        Form1.BerichtAnlegen1.BringToFront()


    End Sub

    Private Sub ElternBerichtDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ElternBerichtDataGridView.RowHeaderMouseClick

        Dim str As String
        Dim str1 As String




        str = Me.ElternBerichtDataGridView.Rows(e.RowIndex).Cells(3).Value
        str1 = Me.ElternBerichtDataGridView.Rows(e.RowIndex).Cells(1).Value

        BerichtAnzeigen.Show()

        BerichtAnzeigen.EBDaten_laden(str, str1)


    End Sub

    Public Sub EBDaten_laden()

        Me.KindTableAdapter.Fill(DataSet1.Kind)
        Me.ElternBerichtTableAdapter.Fill(Me.DataSet1.ElternBericht)
        Me.ElternBerichtDataGridView.Update()

        Try
            KindName = DataSet1.Kind.FindByName(Form1.CB_name.Text)
            Label5.Text = KindName.Vater
            Label6.Text = KindName.Mutter
            '  KindName.Erziehungsberechtigter

        Catch ex As Exception
            MsgBox("Fehler")

        End Try


    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        ButtonName.AutoPopDelay = 5000 'wie lange sichtbar
        ButtonName.InitialDelay = 500 'wie lange bis sichtbar
        ButtonName.ReshowDelay = 500 'einblenden nächster Text
        ButtonName.ShowAlways = True
        ButtonName.SetToolTip(Me.Button3, "3")
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        ButtonName.AutoPopDelay = 5000 'wie lange sichtbar
        ButtonName.InitialDelay = 500 'wie lange bis sichtbar
        ButtonName.ReshowDelay = 500 'einblenden nächster Text
        ButtonName.ShowAlways = True
        ButtonName.SetToolTip(Me.Button2, "2")
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        ButtonName.AutoPopDelay = 5000 'wie lange sichtbar
        ButtonName.InitialDelay = 500 'wie lange bis sichtbar
        ButtonName.ReshowDelay = 500 'einblenden nächster Text
        ButtonName.ShowAlways = True
        ButtonName.SetToolTip(Me.Button1, "1")
    End Sub


    'Private Sub ElternBerichtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBerichtBindingNavigatorSaveItem.Click, MyBaseBerichtBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.ElternBerichtBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub
End Class
