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



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

        'name per dropdown auswählen - funktioniert

        Dim name As String
        name = "F_" + CB_name.Text


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
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SC_Michelle.Panel1.Paint

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SC_Leon.Panel2.Paint

    End Sub

    Private Sub CB_name_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CB_name.SelectedIndexChanged
        Dim name As String

        name = "SC_" + CB_name.Text


        If name = SC_Aaliyah.Name Then
            SC_Aaliyah.Visible = True
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Aleks.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = True
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_David.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = True
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Dominik.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = True
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Fenya.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = True
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Jan.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = True
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Jeremy.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = True
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Leon.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = True
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Louis.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = True
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Maurice.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = True
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Michelle.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = True
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Natalie.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = True
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Noah.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = True
            SC_Paul.Visible = False
            SC_Raphael.Visible = False
        ElseIf name = SC_Paul.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = True
            SC_Raphael.Visible = False
        ElseIf name = SC_Raphael.Name Then
            SC_Aaliyah.Visible = False
            SC_Aleks.Visible = False
            SC_David.Visible = False
            SC_Dominik.Visible = False
            SC_Fenya.Visible = False
            SC_Jan.Visible = False
            SC_Jeremy.Visible = False
            SC_Leon.Visible = False
            SC_Louis.Visible = False
            SC_Maurice.Visible = False
            SC_Michelle.Visible = False
            SC_Natalie.Visible = False
            SC_Noah.Visible = False
            SC_Paul.Visible = False
            SC_Raphael.Visible = True
        Else


            MessageBox.Show("Kind nicht vorhanden")

        End If
    End Sub

    Private Sub LinkLabel200_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel200.LinkClicked
        Label14.Text = "Hallo"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F_Aaliyah.Show()
    End Sub


End Class
