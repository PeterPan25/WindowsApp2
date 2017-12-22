


Public Class Form1
    Dim form As Form

    Dim data3 As New DataSet1.KindDataTable
    Dim name3 As String() = {"a"}
    Dim z As Integer

    Dim i As Integer

    Dim name2 As String() = {"Eltern",
                "Arzt anlegen",
                "Doku",
        "Stammdaten",
        "Schule",
        "Kontakte",
        "Hilfen",
        "Krankenhaus",
        "Psycho",
        "Hobby",
        "Tagesbericht",
        "Formulare",
        "hinzufügen",
        "Berichte",
        "Arztbericht anlegen"
        }






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



        For i = 0 To 14
            If e.Node.Text = name2(i) Then


                Select Case i
                    Case 0
                        Eltern1.Visible = True
                        Eltern1.BringToFront()

                    Case 1

                        ArztAnlegen1.Visible = True
                        ArztAnlegen1.BringToFront()

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

                        Krankenhaus1.Visible = True
                        Krankenhaus1.BringToFront()

                    Case 8

                        Psycho1.Visible = True
                        Psycho1.BringToFront()

                    Case 9

                        Hobby1.Visible = True
                        Hobby1.BringToFront()

                    Case 10

                        Tagesbericht1.Visible = True
                        Tagesbericht1.BringToFront()

                    Case 11

                        Formulare1.Visible = True
                        Formulare1.BringToFront()
                    Case 12

                        Panel1.Visible = True
                        Panel1.BringToFront()
                    Case 13
                        Bericht1.Visible = True
                        Bericht1.BringToFront()

                    Case 14

                        Arztbericht1.BerichtAnlegen_Load()
                        Arztbericht1.Visible = True
                        Arztbericht1.BringToFront()

                End Select


            End If

        Next

    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet11.Kind". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KindTableAdapter.Fill(Me.DataSet11.Kind)

        Combotext()





    End Sub



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
        Bericht1.BerichtKind()

    End Sub



End Class
