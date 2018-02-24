Public Class Psycho
    Dim ButtonName As New ToolTip



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        ButtonName.AutoPopDelay = 5000 'wie lange sichtbar
        ButtonName.InitialDelay = 500 'wie lange bis sichtbar
        ButtonName.ReshowDelay = 500 'einblenden nächster Text
        ButtonName.ShowAlways = True
        ButtonName.SetToolTip(Me.Button1, "1")

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
    'Private Sub PsychoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.PsychoBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub 


End Class
