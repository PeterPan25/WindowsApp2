﻿Public Class Form1
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

    'Combobox funktioniert
    'Private Sub CB_name_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CB_name.SelectedIndexChanged

    '    Dim names(15) As SplitContainer
    '    'Dim varnames As String

    '    Dim i As Integer
    '    Name = "SC_" + CB_name.Text
    '    For i = 0 To 14


    '        names(0) = SC_Aaliyah
    '        names(1) = SC_Aleks
    '        names(2) = SC_David
    '        names(3) = SC_Dominik
    '        names(4) = SC_Fenya
    '        names(5) = SC_Jan
    '        names(6) = SC_Jeremy
    '        names(7) = SC_Leon
    '        names(8) = SC_Louis
    '        names(9) = SC_Maurice
    '        names(10) = SC_Michelle
    '        names(11) = SC_Natalie
    '        names(12) = SC_Noah
    '        names(13) = SC_Paul
    '        names(14) = SC_Raphael


    '        'varnames = names(i)
    '        If Name <> names(i).Name Then
    '            names(i).Visible = False
    '        Else names(i).Visible = True
    '        End If

    '    Next i
    'End If

    'If Name == names(i).Name Then
    '    names(i).Visible = False
    'End If






    'Dim name As String

    'name = "SC_" + CB_name.Text

    'If name = SC_Aaliyah.Name Then
    '    SC_Aaliyah.Visible = True
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Aleks.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = True
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_David.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = True
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Dominik.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = True
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Fenya.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = True
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Jan.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = True
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Jeremy.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = True
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Leon.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = True
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Louis.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = True
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Maurice.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = True
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Michelle.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = True
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Natalie.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = True
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Noah.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = True
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Paul.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = True
    '    SC_Raphael.Visible = False
    'ElseIf name = SC_Raphael.Name Then
    '    SC_Aaliyah.Visible = False
    '    SC_Aleks.Visible = False
    '    SC_David.Visible = False
    '    SC_Dominik.Visible = False
    '    SC_Fenya.Visible = False
    '    SC_Jan.Visible = False
    '    SC_Jeremy.Visible = False
    '    SC_Leon.Visible = False
    '    SC_Louis.Visible = False
    '    SC_Maurice.Visible = False
    '    SC_Michelle.Visible = False
    '    SC_Natalie.Visible = False
    '    SC_Noah.Visible = False
    '    SC_Paul.Visible = False
    '    SC_Raphael.Visible = True
    'Else


    '    MessageBox.Show("Kind nicht vorhanden")

    'End If
    'End Sub

    Private Sub LL_Aaliyah_Stammdaten_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        P_Aaliyah_Stammdaten.Show()
        P_Aaliyah_Kontakte.Visible = False
        P_Aaliyah_Stammdaten.Visible = True
        P_Aaliyah_Hilfen.Visible = False
        P_Aaliyah_Doku.Visible = False
        P_Aaliyah_Eltern.Visible = False
        P_Aaliyah_Kinderarzt.Visible = False
        P_Aaliyah_Hautarzt.Visible = False
        P_Aaliyah_HNO.Visible = False
        P_Aaliyah_Augenarzt.Visible = False
        P_Aaliyah_Zahnarzt.Visible = False
        P_Aaliyah_Frauenarzt.Visible = False
        P_Aaliyah_Krankenhaus.Visible = False
        P_Aaliyah_Psycho.Visible = False
        P_Aaliyah_Hobby.Visible = False
    End Sub

    Private Sub LL_Aaliyah_Kontakte_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        P_Aaliyah_Kontakte.Show()
        P_Aaliyah_Kontakte.Visible = True
        P_Aaliyah_Stammdaten.Visible = False
        P_Aaliyah_Hilfen.Visible = False
        P_Aaliyah_Doku.Visible = False
        P_Aaliyah_Eltern.Visible = False
        P_Aaliyah_Kinderarzt.Visible = False
        P_Aaliyah_Hautarzt.Visible = False
        P_Aaliyah_HNO.Visible = False
        P_Aaliyah_Augenarzt.Visible = False
        P_Aaliyah_Zahnarzt.Visible = False
        P_Aaliyah_Frauenarzt.Visible = False
        P_Aaliyah_Krankenhaus.Visible = False
        P_Aaliyah_Psycho.Visible = False
        P_Aaliyah_Hobby.Visible = False

    End Sub

    Private Sub LL_Aaliyah_Hilfen_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        P_Aaliyah_Hilfen.Show()
        P_Aaliyah_Kontakte.Visible = False
        P_Aaliyah_Stammdaten.Visible = False
        P_Aaliyah_Hilfen.Visible = True
        P_Aaliyah_Doku.Visible = False
        P_Aaliyah_Eltern.Visible = False
        P_Aaliyah_Kinderarzt.Visible = False
        P_Aaliyah_Hautarzt.Visible = False
        P_Aaliyah_HNO.Visible = False
        P_Aaliyah_Augenarzt.Visible = False
        P_Aaliyah_Zahnarzt.Visible = False
        P_Aaliyah_Frauenarzt.Visible = False
        P_Aaliyah_Krankenhaus.Visible = False
        P_Aaliyah_Hautarzt.Visible = False
        P_Aaliyah_Hobby.Visible = False

        'Dim themes(14) As Panel
        'Dim i As Integer
        'Dim name As String
        ''Dim P_Aaliyah As String


        'name = "L_Aaliyah" + Me.LinkLabel
        'For i = 0 To 13

        '"P_Aaliyah" = "L_Aaliyah"

        'themes(0) = P_Aaliyah_Stammdaten
        '    themes(1) = P_Aaliyah_Kontakte
        '    themes(2) = P_Aaliyah_Hilfen
        '    themes(3) = P_Aaliyah_Psycho
        '    themes(4) = P_Aaliyah_Eltern
        '    themes(5) = P_Aaliyah_Doku
        '    themes(6) = P_Aaliyah_Kinderarzt
        '    themes(7) = P_Aaliyah_Hautarzt
        '    themes(8) = P_Aaliyah_Augenarzt
        '    themes(9) = P_Aaliyah_HNO
        '    themes(10) = P_Aaliyah_Zahnarzt
        '    themes(11) = P_Aaliyah_Krankenhaus
        '    themes(12) = P_Aaliyah_Frauenarzt
        '    themes(13) = P_Aaliyah_Hobby

        '    If themes(i).Name = LinkLabel.(i) Then

        'Next
    End Sub

    Private Sub LL_Aaliyah_Eltern_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        P_Aaliyah_Eltern.Show()
        P_Aaliyah_Kontakte.Visible = False
        P_Aaliyah_Stammdaten.Visible = False
        P_Aaliyah_Hilfen.Visible = False
        P_Aaliyah_Doku.Visible = False
        P_Aaliyah_Eltern.Visible = True
        P_Aaliyah_Kinderarzt.Visible = False
        P_Aaliyah_Hautarzt.Visible = False
        P_Aaliyah_HNO.Visible = False
        P_Aaliyah_Augenarzt.Visible = False
        P_Aaliyah_Zahnarzt.Visible = False
        P_Aaliyah_Frauenarzt.Visible = False
        P_Aaliyah_Krankenhaus.Visible = False
        P_Aaliyah_Psycho.Visible = False
        P_Aaliyah_Hobby.Visible = False
    End Sub

    Private Sub LL_Aaliyah_Doku_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        P_Aaliyah_Doku.Show()
        P_Aaliyah_Kontakte.Visible = False
        P_Aaliyah_Stammdaten.Visible = False
        P_Aaliyah_Hilfen.Visible = False
        P_Aaliyah_Doku.Visible = True
        P_Aaliyah_Eltern.Visible = False
        P_Aaliyah_Kinderarzt.Visible = False
        P_Aaliyah_Hautarzt.Visible = False
        P_Aaliyah_HNO.Visible = False
        P_Aaliyah_Augenarzt.Visible = False
        P_Aaliyah_Zahnarzt.Visible = False
        P_Aaliyah_Frauenarzt.Visible = False
        P_Aaliyah_Krankenhaus.Visible = False
        P_Aaliyah_Psycho.Visible = False
        P_Aaliyah_Hobby.Visible = False
    End Sub

    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        Dim name As String
        Dim name2 As String
        Dim name3(3) As String
        Dim i As Integer
        Dim p As Integer
        Dim s(3) As String

        s(0) = P_Aaliyah_Eltern.Name
        s(1) = P_Aaliyah_HNO.Name
        s(2) = P_Aaliyah_Doku.Name



        name3(0) = "Eltern"
        name3(1) = "HNO"
        name3(2) = "Doku"

        name = e.Node.Text

        For i = 0 To 2
            If e.Node.Text = name3(i) Then
                '  P_Aaliyah_Doku.Visible = False

                name2 = "P_Aaliyah_" + name3(i)

                For p = 0 To 2

                    If name2 = s(p) Then

                        P_Aaliyah_Doku.Visible = False
                        P_Aaliyah_Stammdaten.Visible = True
                        P_Aaliyah_Schule.Visible = False
                        P_Aaliyah_Kontakte.Visible = False
                        P_Aaliyah_Hilfen.Visible = False
                        P_Aaliyah_Eltern.Visible = False
                        P_Aaliyah_Kinderarzt.Visible = False
                        P_Aaliyah_Hautarzt.Visible = False
                        P_Aaliyah_HNO.Visible = False
                        P_Aaliyah_Augenarzt.Visible = False
                        P_Aaliyah_Zahnarzt.Visible = False
                        P_Aaliyah_Frauenarzt.Visible = False
                        P_Aaliyah_Krankenhaus.Visible = False
                        P_Aaliyah_Psycho.Visible = False
                        P_Aaliyah_Hobby.Visible = False


                    End If

                Next






            End If


        Next


    End Sub




    'Private Sub TreeView1_nodemouseclick(sender As Object, e As TreeViewEventArgs) Handles TreeView1.NodeMouseClick

    '    Dim name As String

    '    name = TreeNode.Name


    '    P_Aaliyah_Doku.Show()
    '    P_Aaliyah_Kontakte.Visible = False
    '    P_Aaliyah_Stammdaten.Visible = False
    '    P_Aaliyah_Hilfen.Visible = False
    '    P_Aaliyah_Doku.Visible = True
    '    P_Aaliyah_Eltern.Visible = False
    '    P_Aaliyah_Kinderarzt.Visible = False
    '    P_Aaliyah_Hautarzt.Visible = False
    '    P_Aaliyah_HNO.Visible = False
    '    P_Aaliyah_Augenarzt.Visible = False
    '    P_Aaliyah_Zahnarzt.Visible = False
    '    P_Aaliyah_Frauenarzt.Visible = False
    '    P_Aaliyah_Krankenhaus.Visible = False
    '    P_Aaliyah_Psycho.Visible = False
    '    P_Aaliyah_Hobby.Visible = False
    'End Sub

    'Private Sub start_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    TreeView1.Nodes.AddRange(New System.Windows.Forms.SplitContainer.treenode() _
    '    (New system.windows.forms.splitcontainer.treenode("allgemeine Daten",_
    '    New System.Windows.Forms.SplitContainer.treenode()_
    '    (New system.windows.forms.splitcontainer.treenode("Stammdaten"),_
    '    New system.windows.forms.splitcontainer.treenode("Kontakte"))
    '    TreeView1.SelectedImageKey = -1

    '    TreeView1.Nodes(0).Nodes(0).Tag = SC_Aaliyah.P_Aaliyah_Stammdaten
    '    TreeView1.Nodes(0).Nodes(1).Tag = SC_Aaliyah.P_Aaliyah_Kontakte
    'End Sub



    'Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    '    If Not e.Node.Tag Is Nothing Then
    '        Dim p As Panel = DirectCast(e.Node.Tag, Panel)
    '        p.Show()
    '        p.Dispose()
    '    End If


    '    If e.Node.Name = "Knotenstammdaten" Then
    '        P_Aaliyah_Stammdaten.Show()
    '        P_Aaliyah_Kontakte.Visible = False
    '        P_Aaliyah_Hilfen.Visible = False
    '        P_Aaliyah_Doku.Visible = False
    '        P_Aaliyah_Eltern.Visible = False
    '        P_Aaliyah_Kinderarzt.Visible = False
    '        P_Aaliyah_Hautarzt.Visible = False
    '        P_Aaliyah_HNO.Visible = False
    '        P_Aaliyah_Augenarzt.Visible = False
    '        P_Aaliyah_Zahnarzt.Visible = False
    '        P_Aaliyah_Frauenarzt.Visible = False
    '        P_Aaliyah_Krankenhaus.Visible = False
    '        P_Aaliyah_Psycho.Visible = False
    '        P_Aaliyah_Hobby.Visible = False
    '        P_Aaliyah_Stammdaten.Visible = True
    '    End If

    'End Sub


End Class
