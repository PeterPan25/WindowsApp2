


Public Class Form1
    Dim form As Form

    Dim name3 As String() = {"a"}
    Dim z As Integer
    Public Shared Property NameKind As String
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
        "bearbeiten",
        "Übersicht",
        "Mitarbeiter",
        "Verwaltung"
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

        Dim ab As New AktuellerBenutzer
        Dim b As String

        For i = 0 To 20




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

                        b = ab.Benutzer_nennen
                        If b = "ABC" Then
                            ArztAnlegen1.Visible = True
                            ArztAnlegen1.BringToFront()
                        Else
                            MsgBox("Keine Berechtigung")

                        End If



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

                    Case 18

                        Übersicht1.Daten_laden()
                        Übersicht1.Visible = True
                        Übersicht1.BringToFront()

                    Case 19
                        Mitarbeiter1.Daten_Load()
                        Mitarbeiter1.Visible = True
                        Mitarbeiter1.BringToFront()

                    Case 20
                        Benutzer1.Daten_Load()
                        Benutzer1.Visible = True
                        Benutzer1.BringToFront()


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
        Me.CB_name.Visible = False
        ' Me.ToolStrip1.Visible = False
        Me.Splitcontainer2.Panel1Collapsed = True
        Mitarbeiter1.First()
        ' Me.LogoutButton.Visible = False

    End Sub

    Public Sub Anmelden_erfolgreich()
        Me.CB_name.Visible = True

        Me.TextBox1.Visible = True

        Me.Splitcontainer2.Panel1Collapsed = False
        Me.TreeView1.Enabled = True
        Me.CB_name.Enabled = True
        Me.LogoutButton.Visible = True
        Me.Label11.Visible = True
        Me.Label10.Visible = True

        Me.Label1.Visible = True
        Me.Label2.Visible = True
        Me.Label3.Visible = True
        Me.MonthCalendar1.Visible = True

        '  Me.Label4.Visible = True
        Me.Label5.Visible = True
        '  Me.Label6.Visible = True
        Übersicht1.Daten_laden()
        Übersicht1.Visible = True
        Übersicht1.BringToFront()
        Me.Button2.Visible = True
        '   Me.ToolStrip1.Visible = True
    End Sub


    Public Sub Combotext()
        Me.KindTableAdapter.Fill(Me.DataSet11.Kind)



        ReDim name3(DataSet11.Kind.Rows.Count - 1)


        For z = 0 To (DataSet11.Kind.Rows.Count - 1)
            name3(z) = DataSet11.Kind.Rows(z)("Name")
        Next



        If name3.Count > 0 Then
            NameKind = name3.ElementAt(0)

            CB_name.DataSource = name3
            '  NameKind = name3(0)
        End If


        KinderDaten()
    End Sub



    Private Sub CB_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_name.SelectedIndexChanged
        Bericht1.BerichtKind()
        KindBearbeiten1.DatenAnzeigen()

        Stammdaten1.Daten_Anzeigen()
        Schule1.SBDaten_laden()



        KinderDaten()


        Arztbericht1.KindWechsel()

    End Sub

    'Private Sub SplitContainer3_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer3.Panel1.Paint

    'End Sub

    Private Sub KinderDaten()
        Dim Kind As String = NameKind
        Dim Pfad As String
        Dim bg As New BildGroesse


        Try


            For z = 0 To (DataSet11.Kind.Rows.Count - 1)
                If Kind = DataSet11.Kind.Rows(z)("Name") Then
                    Label2.Text = "Geboren am " + DataSet11.Kind.Rows(z)("Geburtsdatum")
                    Label3.Text = "Sorgerechtsstatus: " + DataSet11.Kind.Rows(z)("Sorgerechtsstatus")
                    'Label4.Text = DataSet11.Kind.Rows(z)("Jugendamt")
                    Label5.Text = "Aufnahmedatum: " + DataSet11.Kind.Rows(z)("Aufnahmedatum")
                    Pfad = DataSet11.Kind.Rows(z)("Bild")

                    If Pfad IsNot "" Then

                        Dim abc As New Bitmap(Pfad)

                        With PictureBox1
                            .Image = bg.AutoSizeImage(abc, 150, 160)
                        End With
                        ' PictureBox1.ImageLocation = Pfad

                    ElseIf Pfad Is "" Then

                        PictureBox1.Image = Nothing



                    End If




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
        'Me.Label6.Text = name

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Nachrichten.Show()

    End Sub

    Private Sub TreeView1_EnabledChanged(sender As Object, e As EventArgs) Handles TreeView1.EnabledChanged
        Dim tn As TreeNode

        For Each tn In TreeView1.Nodes
            tn.BackColor = Color.RoyalBlue
        Next


    End Sub



    Public Function NameKindNennen()
        Return NameKind
    End Function

    Private Sub CB_name_TextChanged(sender As Object, e As EventArgs) Handles CB_name.TextChanged

        If CB_name.Text IsNot "" Then
            NameKind = CB_name.Text
            Eltern1.EBDaten_laden()
        End If






    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Dim ab As New AktuellerBenutzer
        Dim name As String

        ab.Benutzer_abgemeldet()


        name = ab.Benutzer_nennen()
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        LoginForm2.Show()
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
