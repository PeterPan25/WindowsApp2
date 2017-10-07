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

    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        Dim name As String
        Dim name2 As String
        Dim name3(18) As String
        Dim i As Integer
        Dim p As Integer
        Dim s(18) As String

        s(0) = Eltern1.Name
        s(1) = HNO1.Name
        s(2) = Doku1.Name
        s(3) = Stammdaten1.Name
        s(4) = Schule1.Name
        s(5) = Kontakte1.Name
        s(6) = Hilfen1.Name
        s(7) = Kinderarzt1.Name
        s(8) = Hautarzt1.Name
        s(9) = Augenarzt1.Name
        s(10) = Zahnarzt1.Name
        s(11) = Frauenarzt1.Name
        s(12) = Krankenhaus1.Name
        s(13) = Psycho1.Name
        s(14) = Hobby1.Name
        s(15) = Tagesbericht1.Name
        s(16) = Formulare1.Name
        s(17) = Panel1.Name

        name3(0) = "Eltern"
        name3(1) = "HNO"
        name3(2) = "Doku"
        name3(3) = "Stammdaten"
        name3(4) = "Schule"
        name3(5) = "Kontakte"
        name3(6) = "Hilfen"
        name3(7) = "Kinderarzt"
        name3(8) = "Hautarzt"
        name3(9) = "Augenarzt"
        name3(10) = "Zahnarzt"
        name3(11) = "Frauenarzt"
        name3(12) = "Krankenhaus"
        name3(13) = "Psycho"
        name3(14) = "Hobby"
        name3(15) = "Tagesbericht"
        name3(16) = "Formulare"
        name3(17) = "hinzufügen"

        name = e.Node.Text

        For i = 0 To 17
            If e.Node.Text = name3(i) Then

                name2 = name3(i) + ("1")

                For p = 0 To 17

                    If name2 = s(p) Then

                        Select Case p
                            Case 0
                                Eltern1.Visible = True
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True

                            Case 1
                                Eltern1.Visible = False
                                HNO1.Visible = True
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True

                            Case 2
                                'Eltern1.Visible = False
                                'HNO1.Visible = False
                                Doku1.Visible = True
                                'Stammdaten1.Visible = False
                                'Schule1.Visible = False
                                'Kontakte1.Visible = False
                                'Hilfen1.Visible = False
                                'Kinderarzt1.Visible = False
                                'Hautarzt1.Visible = False
                                'Augenarzt1.Visible = False
                                'Zahnarzt1.Visible = False
                                'Frauenarzt1.Visible = False
                                'Krankenhaus1.Visible = False
                                'Psycho1.Visible = False
                                'Hobby1.Visible = False
                                'Tagesbericht1.Visible = False
                                'Formulare1.visible = False
                                'Panel1.Visible = True

                            Case 3
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = True
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 4
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = True
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 5
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = True
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 6
                                'Eltern1.Visible = False
                                'HNO1.Visible = False
                                'Doku1.Visible = False
                                'Stammdaten1.Visible = False
                                'Schule1.Visible = False
                                'Kontakte1.Visible = False
                                Hilfen1.Visible = True
                                'Kinderarzt1.Visible = False
                                'Hautarzt1.Visible = False
                                'Augenarzt1.Visible = False
                                'Zahnarzt1.Visible = False
                                'Frauenarzt1.Visible = False
                                'Krankenhaus1.Visible = False
                                'Psycho1.Visible = False
                                'Hobby1.Visible = False
                                'Tagesbericht1.Visible = False
                                'Formulare1.visible = False
                                'Panel1.Visible = True
                            Case 7
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = True
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 8
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = True
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 9
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = True
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 10
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = True
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 11
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = True
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 12
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = True
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 13
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = True
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 14
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = True
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 15
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 16
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = True
                                Formulare1.visible = False
                                Panel1.Visible = True
                            Case 17
                                Eltern1.Visible = False
                                HNO1.Visible = False
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Tagesbericht1.Visible = False
                                Formulare1.Visible = True
                                Panel1.Visible = True
                        End Select






                    End If

                Next






            End If


        Next


    End Sub

    'Private Sub Tagesbericht1_Load(sender As Object, e As EventArgs) Handles Tagesbericht1.Load
    '    Label16.Text = Now.Date

    'End Sub









    'Public Sub Button2_Click(sender As Object, e As EventArgs)
    '    Class1.text()
    'End Sub

    'Public Sub Button3_Click(sender As Object, e As EventArgs)
    '    Dim table As DataSet1.TestDataTable

    '    Dim row As DataRow
    '    Dim col As DataColumn



    '    For Each row In table.Rows
    '        For Each col In table.Columns
    '            Console.WriteLine(row(col))
    '        Next
    '    Next
    'End Sub


End Class
