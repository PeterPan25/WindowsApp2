<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schuleanlegen
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PlatzhalterText1 = New WindowsApp2.PlatzhalterText()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PlatzhalterText2 = New WindowsApp2.PlatzhalterText()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PlatzhalterText3 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText4 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText5 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText6 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText7 = New WindowsApp2.PlatzhalterText()
        Me.SchuleDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SchuleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(-80, -60)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlatzhalterText1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlatzhalterText2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlatzhalterText3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlatzhalterText4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlatzhalterText5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlatzhalterText6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlatzhalterText7)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.SchuleDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(1124, 797)
        Me.SplitContainer2.SplitterDistance = 241
        Me.SplitContainer2.TabIndex = 3
        '
        'PlatzhalterText1
        '
        Me.PlatzhalterText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText1.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText1.Location = New System.Drawing.Point(116, 75)
        Me.PlatzhalterText1.Name = "PlatzhalterText1"
        Me.PlatzhalterText1.PlatzHalterText = Nothing
        Me.PlatzhalterText1.Size = New System.Drawing.Size(218, 26)
        Me.PlatzhalterText1.TabIndex = 21
        Me.PlatzhalterText1.Text = "Schule"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "von:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(684, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Bis:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(725, 107)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(181, 22)
        Me.DateTimePicker2.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(413, 107)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 22)
        Me.DateTimePicker1.TabIndex = 16
        '
        'PlatzhalterText2
        '
        Me.PlatzhalterText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText2.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText2.Location = New System.Drawing.Point(116, 139)
        Me.PlatzhalterText2.Name = "PlatzhalterText2"
        Me.PlatzhalterText2.PlatzHalterText = "Schulart"
        Me.PlatzhalterText2.Size = New System.Drawing.Size(218, 26)
        Me.PlatzhalterText2.TabIndex = 7
        Me.PlatzhalterText2.Text = "Schulart"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(746, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 40)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Speichern"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PlatzhalterText3
        '
        Me.PlatzhalterText3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText3.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText3.Location = New System.Drawing.Point(368, 75)
        Me.PlatzhalterText3.Name = "PlatzhalterText3"
        Me.PlatzhalterText3.PlatzHalterText = "Straße & Hausnummer"
        Me.PlatzhalterText3.Size = New System.Drawing.Size(195, 26)
        Me.PlatzhalterText3.TabIndex = 8
        Me.PlatzhalterText3.Text = "Straße & Hausnummer"
        '
        'PlatzhalterText4
        '
        Me.PlatzhalterText4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText4.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText4.Location = New System.Drawing.Point(569, 75)
        Me.PlatzhalterText4.Name = "PlatzhalterText4"
        Me.PlatzhalterText4.PlatzHalterText = "Postleitzahl"
        Me.PlatzhalterText4.Size = New System.Drawing.Size(100, 26)
        Me.PlatzhalterText4.TabIndex = 9
        Me.PlatzhalterText4.Text = "Postleitzahl"
        '
        'PlatzhalterText5
        '
        Me.PlatzhalterText5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText5.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText5.Location = New System.Drawing.Point(688, 75)
        Me.PlatzhalterText5.Name = "PlatzhalterText5"
        Me.PlatzhalterText5.PlatzHalterText = "Ort"
        Me.PlatzhalterText5.Size = New System.Drawing.Size(218, 26)
        Me.PlatzhalterText5.TabIndex = 10
        Me.PlatzhalterText5.Text = "Ort"
        '
        'PlatzhalterText6
        '
        Me.PlatzhalterText6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText6.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText6.Location = New System.Drawing.Point(368, 139)
        Me.PlatzhalterText6.Name = "PlatzhalterText6"
        Me.PlatzhalterText6.PlatzHalterText = "Klasse"
        Me.PlatzhalterText6.Size = New System.Drawing.Size(102, 26)
        Me.PlatzhalterText6.TabIndex = 11
        Me.PlatzhalterText6.Text = "Klasse"
        '
        'PlatzhalterText7
        '
        Me.PlatzhalterText7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText7.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText7.Location = New System.Drawing.Point(476, 139)
        Me.PlatzhalterText7.Name = "PlatzhalterText7"
        Me.PlatzhalterText7.PlatzHalterText = "Klassenlehrer/-in"
        Me.PlatzhalterText7.Size = New System.Drawing.Size(193, 26)
        Me.PlatzhalterText7.TabIndex = 12
        Me.PlatzhalterText7.Text = "Klassenlehrer/-in"
        '
        'SchuleDataGridView
        '
        Me.SchuleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SchuleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchuleDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.SchuleDataGridView.Name = "SchuleDataGridView"
        Me.SchuleDataGridView.Size = New System.Drawing.Size(1124, 552)
        Me.SchuleDataGridView.TabIndex = 1
        '
        'Schuleanlegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "Schuleanlegen"
        Me.Size = New System.Drawing.Size(1044, 740)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SchuleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PlatzhalterText2 As PlatzhalterText
    Friend WithEvents Button2 As Button
    Friend WithEvents PlatzhalterText3 As PlatzhalterText
    Friend WithEvents PlatzhalterText4 As PlatzhalterText
    Friend WithEvents PlatzhalterText5 As PlatzhalterText
    Friend WithEvents PlatzhalterText6 As PlatzhalterText
    Friend WithEvents PlatzhalterText7 As PlatzhalterText
    Friend WithEvents SchuleDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PlatzhalterText1 As PlatzhalterText
End Class
