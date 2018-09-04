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
        Me.SchuleTableAdapter.Fill(DataSet1.Schule)
        Me.KindSchuleTableAdapter.Fill(DataSet1.KindSchule)
        Me.SchulBerichtTableAdapter.Fill(DataSet1.SchulBericht)
        Me.SchulBerichtBindingSource.Filter = "Kind = '" & Form1.CB_name.Text & "'"
        Me.SchulBerichtDataGridView.Update()


    End Sub

    Private Sub SchulDaten()
        Dim dr1 As DataSet1.KindSchuleRow
        Dim dr2() As DataRow
        Dim dr3() As String = {}
        Dim dr4 As String = Form1.CB_name.Text

        For z = 0 To (DataSet1.KindSchule.Count - 1)
            If dr4 = (DataSet1.KindSchule.Rows(z)("Name")) Then

                ReDim Preserve dr3(0)

                dr3(0) = DataSet1.KindSchule.Rows(z)("S_Name")

                For Each e In dr3

                    dr2 = DataSet1.Schule.Select("S_Name = '" & e & "'")

                Next

                'SchuleDataGridView.DataSource = dr2

                'If name4.Count = 0 Then


                '    name4.SetValue(DataSet1.KindAugenarzt.Rows(z)("A_Name"), 0)

                'Else
                '    Dim anzahl As Integer = name4.Count
                '    name4.SetValue(DataSet1.KindAugenarzt.Rows(z)("A_Name"), anzahl)


                'End If

            End If
        Next



    End Sub



    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub
End Class
