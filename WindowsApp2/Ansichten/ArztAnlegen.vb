Public Class ArztAnlegen
    Private Sub AugenarztBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AugenarztBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub AugenarztBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AugenarztBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ArtText As String = ComboBox1.Text
        If ArtText = "Augenarzt" Then
            AugenarztAnlegen()

        ElseIf ArtText = "Frauenarzt" Then
            FrauenarztAnlegen()

        ElseIf ArtText = "Kinderarzt" Then
            KinderarztAnlegen()

        ElseIf ArtText = "Hautarzt" Then
            HautarztAnlegen()

        ElseIf ArtText = "Zahnarzt" Then
            ZahnarztAnlegen()

        ElseIf ArtText = "HNO-Arzt" Then

            HNOArztAnlegen()

        End If
    End Sub

    Private Sub HautarztAnlegen()
        Dim a As DataRow = Me.DataSet1.Hautarzt.NewRow()

        Try
            a("A_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.Hautarzt.AddHautarztRow(a)
            Me.HautarztTableAdapter.Update(Me.DataSet1)
            KHDaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub AugenarztAnlegen()
        Dim a As DataRow = Me.DataSet1.Augenarzt.NewRow()

        Try
            a("A_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.Augenarzt.AddAugenarztRow(a)
            Me.AugenarztTableAdapter.Update(Me.DataSet1)
            KADaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub ZahnarztAnlegen()
        Dim a As DataRow = Me.DataSet1.Zahnarzt.NewRow()

        Try
            a("A_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.Zahnarzt.AddZahnarztRow(a)
            Me.ZahnarztTableAdapter.Update(Me.DataSet1)
            KZDaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub KinderarztAnlegen()
        Dim a As DataRow = Me.DataSet1.Kinderarzt.NewRow()

        Try
            a("A_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.Kinderarzt.AddKinderarztRow(a)
            Me.KinderarztTableAdapter.Update(Me.DataSet1)
            KKDaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub FrauenarztAnlegen()
        Dim a As DataRow = Me.DataSet1.Frauenarzt.NewRow()

        Try
            a("A_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.Frauenarzt.AddFrauenarztRow(a)
            Me.FrauenarztTableAdapter.Update(Me.DataSet1)
            KFDaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub HNOArztAnlegen()
        Dim a As DataRow = Me.DataSet1.HNO.NewRow()

        Try
            a("A_Name") = PlatzhalterText1.Text
            a("Plz") = PlatzhalterText3.Text
            a("Ort") = PlatzhalterText4.Text
            a("Strasse") = PlatzhalterText5.Text
            a("Art") = ComboBox1.Text
            a("Telefon") = PlatzhalterText2.Text


            Me.DataSet1.HNO.AddHNORow(a)
            Me.HNOTableAdapter.Update(Me.DataSet1)
            KHNODaten_anlegen()
        Catch ex As Exception
            MsgBox("Schade")
        End Try
    End Sub

    Private Sub KADaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindAugenarzt.NewRow()

        b("A_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindAugenarzt.AddKindAugenarztRow(b)
        Me.Validate()

        '
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    End Sub
    Private Sub KKDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindKinderarzt.NewRow()

        b("K_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindKinderarzt.AddKindKinderarztRow(b)
        Me.Validate()


        Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    End Sub
    Private Sub KZDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindZahnarzt.NewRow()

        b("Z_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindZahnarzt.AddKindZahnarztRow(b)
        Me.Validate()

        Me.TableAdapterManager.UpdateAll(Me.DataSet1)



    End Sub
    Private Sub KFDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindFrauenarzt.NewRow()

        b("F_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindFrauenarzt.AddKindFrauenarztRow(b)
        Me.Validate()


        Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    End Sub
    Private Sub KHDaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindHautarzt.NewRow()

        b("H_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindHautarzt.AddKindHautarztRow(b)
        Me.Validate()


        Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    End Sub
    Private Sub KHNODaten_anlegen()
        Dim b As DataRow
        b = Me.DataSet1.KindHNO.NewRow()

        b("HNO_Name") = PlatzhalterText1.Text
        b("Name") = Form1.CB_name.Text
        Me.DataSet1.KindHNO.AddKindHNORow(b)
        Me.Validate()

        Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    End Sub
End Class
