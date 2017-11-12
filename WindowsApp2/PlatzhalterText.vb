Public Class PlatzhalterText

    Inherits TextBox
    Dim istPlatzhalter As Boolean = True
    Dim _PlatzHalterText As String
    Public Property PlatzHalterText As String
        Get
            Return _PlatzHalterText
        End Get
        Set(value As String)
            _PlatzHalterText = value
            setPlatzhalter()
        End Set
    End Property

    Private Sub setPlatzhalter() Handles Me.LostFocus
        If Me.Text = "" Then
            Me.Text = PlatzHalterText
            Me.ForeColor = Color.Gray
            Me.Font = New Font(Me.Font, FontStyle.Italic)
            istPlatzhalter = True
        End If
    End Sub

    Private Sub entfernePlatzHalter() Handles Me.GotFocus

        If istPlatzhalter Then
            Me.Text = ""
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Font = New Font(Me.Font, FontStyle.Regular)
            istPlatzhalter = False
        End If
    End Sub

End Class
