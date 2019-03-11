Imports System.IO
Imports System.Text
Imports System



Public Class Hilfen

    Dim b As String = ""

    Dim ButtonName As New ToolTip


    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        ButtonName.AutoPopDelay = 5000 'wie lange sichtbar
        ButtonName.InitialDelay = 500 'wie lange bis sichtbar
        ButtonName.ReshowDelay = 500 'einblenden nächster Text
        ButtonName.ShowAlways = True
        ButtonName.SetToolTip(Me.Button1, "1")

    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        ButtonName.AutoPopDelay = 5000 'wie lange sichtbar
        ButtonName.InitialDelay = 500 'wie lange bis sichtbar
        ButtonName.ReshowDelay = 500 'einblenden nächster Text
        ButtonName.ShowAlways = True
        ButtonName.SetToolTip(Me.Button3, "3")
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        ButtonName.AutoPopDelay = 5000 'wie lange sichtbar
        ButtonName.InitialDelay = 500 'wie lange bis sichtbar
        ButtonName.ReshowDelay = 500 'einblenden nächster Text
        ButtonName.ShowAlways = True
        ButtonName.SetToolTip(Me.Button2, "2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As New OpenFileDialog
        '  b = "C:\\Benutzer\Lumpi\Desktop\teste.txt"


        a.InitialDirectory = "C:\Benutzer\Lumpi\Desktop"
        a.ShowDialog()

        b = a.FileName
        SaveText()

    End Sub

    Private Sub SaveText()
        Dim sr As StreamWriter = New StreamWriter(b, True, Encoding.ASCII)
        Dim testText As String

        testText = RichTextBox1.Text

        sr.Write(testText)
        sr.Close()

    End Sub
End Class
