Public Class Form1
    Dim form As Form

    Dim i As Integer
    Dim name3(18) As String
    Dim name2 As String() = {"Eltern",
        "HNO",
        "Doku",
        "Stammdaten",
        "Schule",
        "Kontakte",
        "Hilfen",
        "Kinderarzt",
        "Hautarzt",
        "Augenarzt",
        "Zahnarzt",
        "Frauenarzt",
        "Krankenhaus",
        "Psycho",
        "Hobby",
        "Tagesbericht",
        "Formulare",
        "hinzufügen"}



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



        For i = 0 To 17
            If e.Node.Text = name2(i) Then


                Select Case i
                    Case 0
                        Eltern1.Visible = True
                        Eltern1.BringToFront()

                    Case 1

                        HNO1.Visible = True
                        HNO1.BringToFront()

                    Case 2

                        Doku1.Visible = True
                        Doku1.BringToFront()

                    Case 3

                        Stammdaten1.Visible = True
                        Stammdaten1.BringToFront()

                    Case 4

                        Schule1.Visible = True
                        Schule1.BringToFront()

                    Case 5

                        Kontakte1.Visible = True
                        Kontakte1.BringToFront()

                    Case 6

                        Hilfen1.Visible = True
                        Hilfen1.BringToFront()

                    Case 7

                        Kinderarzt1.Visible = True
                        Kinderarzt1.BringToFront()

                    Case 8

                        Hautarzt1.Visible = True
                        Hautarzt1.BringToFront()

                    Case 9

                        Augenarzt1.Visible = True
                        Augenarzt1.BringToFront()

                    Case 10

                        Zahnarzt1.Visible = True
                        Zahnarzt1.BringToFront()

                    Case 11

                        Frauenarzt1.Visible = True
                        Frauenarzt1.BringToFront()

                    Case 12

                        Krankenhaus1.Visible = True
                        Krankenhaus1.BringToFront()

                    Case 13

                        Psycho1.Visible = True
                        Psycho1.BringToFront()

                    Case 14

                        Hobby1.Visible = True
                        Hobby1.BringToFront()

                    Case 15

                        Tagesbericht1.Visible = True
                        Tagesbericht1.BringToFront()

                    Case 16

                        Formulare1.Visible = True
                        Formulare1.BringToFront()
                    Case 17

                        Panel1.Visible = True
                        Panel1.BringToFront()
                End Select


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
