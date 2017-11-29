


Public Class Form1
    Dim form As Form

    Dim data3 As New DataSet1.KindDataTable
    Dim name3 As String() = {"a"}
    Dim z As Integer

    Dim i As Integer

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
        "hinzufügen",
        "Berichte"}



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




        'Me.TableAdapterManager.KindTableAdapter.Fill(data3)
        'test = data3.NameColumn.ToString()

        ''name per dropdown auswählen - funktioniert

        'Dim name As String
        'name = "F_" + CB_name.Text


        'If name = My.Forms.F_Aaliyah.Name Then
        '    F_Aaliyah.Show()
        'ElseIf name = My.Forms.F_Peter.Name Then
        '    F_Peter.Show()
        'ElseIf name = My.Forms.F_Hans.Name Then
        '    F_Hans.Show()

        'Else


        '    MessageBox.Show("Kind nicht vorhanden")

        'End If
    End Sub

    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick



        For i = 0 To 18
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
                    Case 18
                        Bericht1.Visible = True
                        Bericht1.BringToFront()

                End Select


            End If

        Next

    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet11.Kind". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KindTableAdapter.Fill(Me.DataSet11.Kind)

        Combotext()





    End Sub

    'Private Sub Tagesbericht1_Load(sender As Object, e As EventArgs) Handles Tagesbericht1.Load
    '    Label16.Text = Now.Date

    'End Sub

    Public Sub Combotext()
        Me.TableAdapterManager.KindTableAdapter.Fill(data3)

        ReDim name3(data3.Rows.Count - 1)

        For z = 0 To (data3.Rows.Count - 1)
            name3(z) = data3.Rows(z)("Name")
        Next

        CB_name.DataSource = name3
    End Sub

    Public Sub Datentest()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        Me.TableAdapterManager.KindTableAdapter.Fill(data3)
        n1 = CB_name.Text


        r1 = data3.Select("Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                Console.WriteLine(r1(k)(3))
                Label1.Text = r1(k)(8)
            Catch ex As Exception
                Label1.Text = "Henner mieft"
            End Try


        Next k


    End Sub

    Private Sub CB_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_name.SelectedIndexChanged
        Datentest()

    End Sub

    Private Sub Schule1_Load(sender As Object, e As EventArgs)

    End Sub


End Class
