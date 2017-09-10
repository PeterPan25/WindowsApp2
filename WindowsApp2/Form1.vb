Public Class Form1
    Dim form As Form




    ' Private Sub B_öffnen_Click(sender As Object, e As EventArgs) Handles B_öffnen.Click

    ' Funktioniert für Textbox
    'Dim name As String
    'name = "F_" + TextBox1.Text

    'If name = My.Forms.F_Aaliyah.Name Then
    '    F_Aaliyah.Show()
    'ElseIf name = My.Forms.F_Peter.Name Then
    '    F_Peter.Show()
    'ElseIf name = My.Forms.F_Hans.Name Then
    '    F_Hans.Show()

    'Else


    '    MessageBox.Show("Kind nicht vorhanden")

    'End If

    '   End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        'name per dropdown auswählen - funktioniert

        Dim name As String
        name = "F_" + ComboBox1.Text


        If name = My.Forms.F_Aaliyah.Name Then
            F_Aaliyah.Show()
        ElseIf name = My.Forms.F_Peter.Name Then
            F_Peter.Show()
        ElseIf name = My.Forms.F_Hans.Name Then
            F_Hans.Show()

        Else


            MessageBox.Show("Kind nicht vorhanden")

        End If
    End Sub
End Class
