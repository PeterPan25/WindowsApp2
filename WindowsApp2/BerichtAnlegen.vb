﻿Public Class BerichtAnlegen

    Dim name3 As String() = {"a"}



    Private Sub BerichtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BerichtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub BerichtAnlegen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Zahnarzt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.ZahnarztTableAdapter.Fill(Me.DataSet1.Zahnarzt)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Krankenhaus". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KrankenhausTableAdapter.Fill(Me.DataSet1.Krankenhaus)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Kinderarzt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KinderarztTableAdapter.Fill(Me.DataSet1.Kinderarzt)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Hautarzt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.HautarztTableAdapter.Fill(Me.DataSet1.Hautarzt)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Augenarzt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.AugenarztTableAdapter.Fill(Me.DataSet1.Augenarzt)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Frauenarzt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.FrauenarztTableAdapter.Fill(Me.DataSet1.Frauenarzt)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Bericht". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.BerichtTableAdapter.Fill(Me.DataSet1.Bericht)
        Label1.Text = Form1.CB_name.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ArztArt()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ArztArt2()

    End Sub

    Private Sub ArztArt()
        Dim ArtText As String = ComboBox1.Text

        If ArtText = "Augenarzt" Then
            ReDim name3(DataSet1.Augenarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Augenarzt.Rows.Count - 1)
                name3(z) = DataSet1.Augenarzt.Rows(z)("A_Name")
            Next

            ComboBox2.DataSource = name3
            Me.AArztDaten()

        ElseIf ArtText = "Frauenarzt" Then
            ReDim name3(DataSet1.Frauenarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Frauenarzt.Rows.Count - 1)
                name3(z) = DataSet1.Frauenarzt.Rows(z)("F_Name")
            Next

            ComboBox2.DataSource = name3
            Me.FArztDaten()

        ElseIf ArtText = "Kinderarzt" Then
            ReDim name3(DataSet1.Kinderarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Kinderarzt.Rows.Count - 1)
                name3(z) = DataSet1.Kinderarzt.Rows(z)("K_Name")
            Next

            ComboBox2.DataSource = name3
            Me.KArztDaten()

        ElseIf ArtText = "Hautarzt" Then
            ReDim name3(DataSet1.Hautarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Hautarzt.Rows.Count - 1)
                name3(z) = DataSet1.Hautarzt.Rows(z)("H_Name")
            Next

            ComboBox2.DataSource = name3
            Me.HArztDaten()

        ElseIf ArtText = "Zahnarzt" Then
            ReDim name3(DataSet1.Zahnarzt.Rows.Count - 1)

            For z = 0 To (DataSet1.Zahnarzt.Rows.Count - 1)
                name3(z) = DataSet1.Zahnarzt.Rows(z)("Z_Name")
            Next

            ComboBox2.DataSource = name3
            ZArztDaten()


        ElseIf ArtText = "Krankenhaus" Then
            ReDim name3(DataSet1.Krankenhaus.Rows.Count - 1)

            For z = 0 To (DataSet1.Krankenhaus.Rows.Count - 1)
                name3(z) = DataSet1.Krankenhaus.Rows(z)("Kh_Name")
            Next

            ComboBox2.DataSource = name3
            KhArztDaten()


        ElseIf ArtText = "HNO" Then
            ReDim name3(DataSet1.HNO.Rows.Count - 1)

            For z = 0 To (DataSet1.HNO.Rows.Count - 1)
                name3(z) = DataSet1.HNO.Rows(z)("HNO_Name")
            Next

            ComboBox2.DataSource = name3
            HNOArztDaten()



        End If


    End Sub

    Private Sub ArztArt2()
        Dim ArtText As String = ComboBox1.Text

        If ArtText = "Augenarzt" Then

            Me.AArztDaten()

        ElseIf ArtText = "Frauenarzt" Then

            Me.FArztDaten()

        ElseIf ArtText = "Kinderarzt" Then

            Me.KArztDaten()

        ElseIf ArtText = "Hautarzt" Then

            Me.HArztDaten()

        ElseIf ArtText = "Zahnarzt" Then

            ZArztDaten()


        ElseIf ArtText = "Krankenhaus" Then

            KhArztDaten()


        ElseIf ArtText = "HNO" Then

            HNOArztDaten()

        End If


    End Sub

    Private Sub AArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ComboBox2.Text

        r1 = DataSet1.Augenarzt.Select("A_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)
            Catch ex As Exception
                Label1.Text = "Henner mieft"
            End Try


        Next k
    End Sub

    Private Sub FArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ComboBox2.Text

        r1 = DataSet1.Frauenarzt.Select("F_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception
                Label1.Text = "Henner mieft"
            End Try


        Next k
    End Sub

    Private Sub HArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ComboBox2.Text

        r1 = DataSet1.Hautarzt.Select("H_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception


            End Try


        Next k
    End Sub

    Private Sub KArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ComboBox2.Text

        r1 = DataSet1.Kinderarzt.Select("K_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception
                Label1.Text = "Henner mieft"
            End Try


        Next k
    End Sub

    Private Sub KhArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ComboBox2.Text

        r1 = DataSet1.Krankenhaus.Select("Kh_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception
                Label1.Text = "Henner mieft"
            End Try


        Next k
    End Sub
    Private Sub ZArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ComboBox2.Text

        r1 = DataSet1.Zahnarzt.Select("Z_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception
                Label1.Text = "Henner mieft"
            End Try


        Next k
    End Sub
    Private Sub HNOArztDaten()
        Dim n1 As String
        Dim r1() As DataRow
        ' Dim c1 As DataColumn

        n1 = ComboBox2.Text

        r1 = DataSet1.HNO.Select("HNO_Name  = '" & n1 & "'")

        Dim k As Integer

        ' 3/8 jeweilige Spalte für Name etc.
        For k = 0 To r1.GetUpperBound(0)

            Try
                TextBox1.Text = r1(k)(3)
                TextBox2.Text = r1(k)(2)
                TextBox3.Text = r1(k)(1)
                TextBox4.Text = r1(k)(5)

            Catch ex As Exception
                Label1.Text = "Henner mieft"
            End Try


        Next k
    End Sub
End Class