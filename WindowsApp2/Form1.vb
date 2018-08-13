


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
        "Arztbericht anlegen",
        "Arzt Übersicht",
        "hinzufügen",
        "bearbeiten"
        }


    'Public Sub HighlightCheckedNodes()
    '    Dim countIndex As Integer = 0
    '    Dim selectedNode As String = "Selected customer nodes are : "
    '    Dim myNode As TreeNode
    '    For Each myNode In TreeView1.Nodes(0).Nodes
    '        ' Check whether the tree node is checked.
    '        If myNode.Checked Then
    '            ' Set the node's backColor.
    '            myNode.BackColor = Color.Yellow
    '            selectedNode += myNode.Text + " "
    '            countIndex += 1
    '        Else
    '            myNode.BackColor = Color.White
    '        End If
    '    Next myNode

    '    If countIndex > 0 Then
    '        MessageBox.Show(selectedNode)
    '    Else
    '        MessageBox.Show("No nodes are selected")
    '    End If
    'End Sub

    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick


        For i = 0 To 17




            If e.Node.Text = name2(i) Then
                '  TreeView1.Nodes(i).BackColor = Color.DarkRed
                'Dim countIndex As Integer = 0
                'Dim selectedNode As String = "Selected customer nodes are : "
                'countIndex = TreeView1.Nodes.Count
                '   TreeView1.SelectedNode = e.Node
                '  TreeView1.SelectedNode.BackColor = Color.DarkRed
                ' e.Node.BackColor = Color.Red
                'Dim myNode As TreeNode
                'myNode = e.Node
                'For Each myNode In TreeView1.Nodes(0).Nodes
                '    ' Check whether the tree node is checked.
                '    If myNode.Checked = True Then
                '        ' Set the node's backColor.
                '        myNode.BackColor = Color.Yellow
                '        selectedNode += myNode.Text + " "
                '        countIndex += 1
                '    Else
                '        myNode.BackColor = Color.White
                '    End If
                'Next myNode

                'If countIndex > 0 Then
                ' MessageBox.Show(countIndex)
                'Else
                '    MessageBox.Show("No nodes are selected")
                'End If

                Select Case i

                        Case 0
                            Eltern1.EBDaten_laden()

                            Eltern1.Visible = True
                        Eltern1.BringToFront()


                    Case 1

                            ArztAnlegen1.Visible = True
                            ArztAnlegen1.BringToFront()

                        Case 2

                            Doku1.Visible = True
                            Doku1.BringToFront()

                        Case 3
                            Stammdaten1.Stammdaten_Load()
                            Stammdaten1.Visible = True
                            Stammdaten1.BringToFront()


                        Case 4
                            Schule1.SBDaten_laden()
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
                            Bericht1.BerichtKind()


                            Bericht1.BringToFront()

                        Case 14

                            Arztbericht1.BerichtAnlegen_Load()
                            Arztbericht1.Visible = True
                            Arztbericht1.BringToFront()

                        Case 15
                            ArztUebersicht1.Arzt_Load()
                            ArztUebersicht1.Visible = True
                            ArztUebersicht1.BringToFront()

                        Case 16
                            KindHinzufuegen1.Datenkontrolle()
                            KindHinzufuegen1.Visible = True
                            KindHinzufuegen1.BringToFront()

                        Case 17
                            KindBearbeiten1.Daten_Load()
                            KindBearbeiten1.Visible = True
                            KindBearbeiten1.BringToFront()

                            ' For Each case In TreeView1
                            'TreeView1.Nodes(i).BackColor = Color.DarkRed
                            'Next
                    End Select

                '                HighlightCheckedNodes()



            End If

            Next

    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet11.Kind". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KindTableAdapter.Fill(Me.DataSet11.Kind)

        Combotext()
        Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.TreeView1.Enabled = False
        Me.CB_name.Enabled = False
        ' Me.LogoutButton.Visible = False

    End Sub

    Public Sub Anmelden_erfolgreich()
        Me.TreeView1.Enabled = True
        Me.CB_name.Enabled = True
        Me.LogoutButton.Visible = True

    End Sub


    Public Sub Combotext()
        Me.KindTableAdapter.Fill(Me.DataSet11.Kind)

        Me.TableAdapterManager.KindTableAdapter.Fill(data3)

        ReDim name3(data3.Rows.Count - 1)

        For z = 0 To (data3.Rows.Count - 1)
            name3(z) = data3.Rows(z)("Name")
        Next

        CB_name.DataSource = name3
        KinderDaten()
    End Sub



    Private Sub CB_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_name.SelectedIndexChanged
        Bericht1.BerichtKind()
        KindBearbeiten1.DatenAnzeigen()
        KinderDaten()
        Stammdaten1.Daten_Anzeigen()
    End Sub

    Private Sub SplitContainer3_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer3.Panel1.Paint

    End Sub

    Private Sub KinderDaten()
        Dim Kind As String = CB_name.Text

        Try


            For z = 0 To (data3.Rows.Count - 1)
                If Kind = data3.Rows(z)("Name") Then
                    Label1.Text = data3.Rows(z)("Geburtsdatum")
                    Label2.Text = data3.Rows(z)("Sorgerechtsstatus")
                    Label4.Text = data3.Rows(z)("Jugendamt")
                    Label5.Text = data3.Rows(z)("Aufnahmedatum")

                End If

            Next
        Catch ex As Exception
            MsgBox("nenene")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim ab As New AktuellerBenutzer
        Dim name As String

        ab.Benutzer_abgemeldet()


        name = ab.Benutzer_nennen()
        Me.Label6.Text = name

    End Sub

    'Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
    '    '  TreeView1.SelectedNode = e.Node

    '    TreeView1.SelectedNode.BackColor = Color.DarkGray

    '    'If TreeView1.SelectedNode.IsSelected = True Then
    '    '    TreeView1.SelectedNode.BackColor = Color.DarkGreen
    '    'Else
    '    '    TreeView1.SelectedNode.BackColor = Color.Black

    '    'End If
    'End Sub

    'Private Sub TreeView1_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
    '    '    e.Node.BackColor = Color.DarkRed
    'End Sub
End Class
