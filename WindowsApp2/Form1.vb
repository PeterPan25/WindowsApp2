﻿Public Class Form1
    Dim form As Form








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
        Dim name3(16) As String
        Dim i As Integer
        Dim p As Integer
        Dim s(16) As String

        s(0) = Eltern1.Name
        s(1) = Hno1.Name
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
        s(15) = Panel1.Name

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
        name3(15) = "hinzufügen"

        name = e.Node.Text

        For i = 0 To 15
            If e.Node.Text = name3(i) Then

                name2 = name3(i) + ("1")

                For p = 0 To 15

                    If name2 = s(p) Then

                        Select Case p
                            Case 0
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = True
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False

                            Case 1
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = True
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False

                            Case 2
                                Doku1.Visible = True
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False

                            Case 3
                                Doku1.Visible = False
                                Stammdaten1.Visible = True
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 4
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = True
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 5
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = True
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 6
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = True
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 7
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = True
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 8
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = True
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 9
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = True
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 10
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = True
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 11
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = True
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 12
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = True
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 13
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = True
                                Hobby1.Visible = False
                                Anlegen1.Visible = False
                            Case 14
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = True
                                Anlegen1.Visible = False
                            Case 15
                                Doku1.Visible = False
                                Stammdaten1.Visible = False
                                Schule1.Visible = False
                                Kontakte1.Visible = False
                                Hilfen1.Visible = False
                                Eltern1.Visible = False
                                Kinderarzt1.Visible = False
                                Hautarzt1.Visible = False
                                Hno1.Visible = False
                                Augenarzt1.Visible = False
                                Zahnarzt1.Visible = False
                                Frauenarzt1.Visible = False
                                Krankenhaus1.Visible = False
                                Psycho1.Visible = False
                                Hobby1.Visible = False
                                Anlegen1.Visible = True

                        End Select






                    End If

                Next






            End If


        Next


    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs)
        Dim table As DataSet1.TestDataTable

        Dim row As DataRow
        Dim col As DataColumn



        For Each row In table.Rows
            For Each col In table.Columns
                Console.WriteLine(row(col))
            Next
        Next
    End Sub

End Class
