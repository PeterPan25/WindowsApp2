<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kontakte
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Familie = New System.Windows.Forms.TabPage()
        Me.Freunde = New System.Windows.Forms.TabPage()
        Me.Sonstige = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Familie)
        Me.TabControl1.Controls.Add(Me.Freunde)
        Me.TabControl1.Controls.Add(Me.Sonstige)
        Me.TabControl1.Location = New System.Drawing.Point(25, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(900, 387)
        Me.TabControl1.TabIndex = 0
        '
        'Familie
        '
        Me.Familie.AccessibleName = "Familie"
        Me.Familie.Location = New System.Drawing.Point(4, 22)
        Me.Familie.Name = "Familie"
        Me.Familie.Padding = New System.Windows.Forms.Padding(3)
        Me.Familie.Size = New System.Drawing.Size(892, 361)
        Me.Familie.TabIndex = 0
        Me.Familie.Text = "Familie"
        Me.Familie.UseVisualStyleBackColor = True
        '
        'Freunde
        '
        Me.Freunde.Location = New System.Drawing.Point(4, 22)
        Me.Freunde.Name = "Freunde"
        Me.Freunde.Padding = New System.Windows.Forms.Padding(3)
        Me.Freunde.Size = New System.Drawing.Size(892, 361)
        Me.Freunde.TabIndex = 1
        Me.Freunde.Text = "Freunde"
        Me.Freunde.UseVisualStyleBackColor = True
        '
        'Sonstige
        '
        Me.Sonstige.Location = New System.Drawing.Point(4, 22)
        Me.Sonstige.Name = "Sonstige"
        Me.Sonstige.Size = New System.Drawing.Size(892, 361)
        Me.Sonstige.TabIndex = 2
        Me.Sonstige.Text = "Sonstige"
        Me.Sonstige.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(414, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kontakte"
        '
        'Kontakte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Kontakte"
        Me.Size = New System.Drawing.Size(949, 482)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Familie As TabPage
    Friend WithEvents Freunde As TabPage
    Friend WithEvents Sonstige As TabPage
    Friend WithEvents Label1 As Label
End Class
