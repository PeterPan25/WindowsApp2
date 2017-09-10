<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LL_Stammdaten = New System.Windows.Forms.LinkLabel()
        Me.LL_Kontakte = New System.Windows.Forms.LinkLabel()
        Me.LL_Hilfen = New System.Windows.Forms.LinkLabel()
        Me.LL_Eltern = New System.Windows.Forms.LinkLabel()
        Me.LL_Doku = New System.Windows.Forms.LinkLabel()
        Me.LL_Psycho = New System.Windows.Forms.LinkLabel()
        Me.LL_Kinderarzt = New System.Windows.Forms.LinkLabel()
        Me.LL_Zahnarzt = New System.Windows.Forms.LinkLabel()
        Me.LL_HNO = New System.Windows.Forms.LinkLabel()
        Me.LL_Augenarzt = New System.Windows.Forms.LinkLabel()
        Me.LL_Hobby = New System.Windows.Forms.LinkLabel()
        Me.LL_Frauenarzt = New System.Windows.Forms.LinkLabel()
        Me.LL_Krankenhaus = New System.Windows.Forms.LinkLabel()
        Me.LL_Hautarzt = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.B_öffnen = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LL_Stammdaten
        '
        Me.LL_Stammdaten.AutoSize = True
        Me.LL_Stammdaten.Location = New System.Drawing.Point(50, 200)
        Me.LL_Stammdaten.Name = "LL_Stammdaten"
        Me.LL_Stammdaten.Size = New System.Drawing.Size(66, 13)
        Me.LL_Stammdaten.TabIndex = 0
        Me.LL_Stammdaten.TabStop = True
        Me.LL_Stammdaten.Text = "Stammdaten"
        '
        'LL_Kontakte
        '
        Me.LL_Kontakte.AutoSize = True
        Me.LL_Kontakte.Location = New System.Drawing.Point(50, 220)
        Me.LL_Kontakte.Name = "LL_Kontakte"
        Me.LL_Kontakte.Size = New System.Drawing.Size(50, 13)
        Me.LL_Kontakte.TabIndex = 0
        Me.LL_Kontakte.TabStop = True
        Me.LL_Kontakte.Text = "Kontakte"
        '
        'LL_Hilfen
        '
        Me.LL_Hilfen.AutoSize = True
        Me.LL_Hilfen.Location = New System.Drawing.Point(50, 240)
        Me.LL_Hilfen.Name = "LL_Hilfen"
        Me.LL_Hilfen.Size = New System.Drawing.Size(34, 13)
        Me.LL_Hilfen.TabIndex = 0
        Me.LL_Hilfen.TabStop = True
        Me.LL_Hilfen.Text = "Hilfen"
        '
        'LL_Eltern
        '
        Me.LL_Eltern.AutoSize = True
        Me.LL_Eltern.Location = New System.Drawing.Point(50, 260)
        Me.LL_Eltern.Name = "LL_Eltern"
        Me.LL_Eltern.Size = New System.Drawing.Size(34, 13)
        Me.LL_Eltern.TabIndex = 0
        Me.LL_Eltern.TabStop = True
        Me.LL_Eltern.Text = "Eltern"
        '
        'LL_Doku
        '
        Me.LL_Doku.AutoSize = True
        Me.LL_Doku.Location = New System.Drawing.Point(50, 280)
        Me.LL_Doku.Name = "LL_Doku"
        Me.LL_Doku.Size = New System.Drawing.Size(33, 13)
        Me.LL_Doku.TabIndex = 0
        Me.LL_Doku.TabStop = True
        Me.LL_Doku.Text = "Doku"
        '
        'LL_Psycho
        '
        Me.LL_Psycho.AutoSize = True
        Me.LL_Psycho.Location = New System.Drawing.Point(50, 300)
        Me.LL_Psycho.Name = "LL_Psycho"
        Me.LL_Psycho.Size = New System.Drawing.Size(42, 13)
        Me.LL_Psycho.TabIndex = 0
        Me.LL_Psycho.TabStop = True
        Me.LL_Psycho.Text = "Psycho"
        '
        'LL_Kinderarzt
        '
        Me.LL_Kinderarzt.AutoSize = True
        Me.LL_Kinderarzt.Location = New System.Drawing.Point(50, 320)
        Me.LL_Kinderarzt.Name = "LL_Kinderarzt"
        Me.LL_Kinderarzt.Size = New System.Drawing.Size(54, 13)
        Me.LL_Kinderarzt.TabIndex = 0
        Me.LL_Kinderarzt.TabStop = True
        Me.LL_Kinderarzt.Text = "Kinderarzt"
        '
        'LL_Zahnarzt
        '
        Me.LL_Zahnarzt.AutoSize = True
        Me.LL_Zahnarzt.Location = New System.Drawing.Point(50, 340)
        Me.LL_Zahnarzt.Name = "LL_Zahnarzt"
        Me.LL_Zahnarzt.Size = New System.Drawing.Size(49, 13)
        Me.LL_Zahnarzt.TabIndex = 0
        Me.LL_Zahnarzt.TabStop = True
        Me.LL_Zahnarzt.Text = "Zahnarzt"
        '
        'LL_HNO
        '
        Me.LL_HNO.AutoSize = True
        Me.LL_HNO.Location = New System.Drawing.Point(50, 360)
        Me.LL_HNO.Name = "LL_HNO"
        Me.LL_HNO.Size = New System.Drawing.Size(31, 13)
        Me.LL_HNO.TabIndex = 0
        Me.LL_HNO.TabStop = True
        Me.LL_HNO.Text = "HNO"
        '
        'LL_Augenarzt
        '
        Me.LL_Augenarzt.AutoSize = True
        Me.LL_Augenarzt.Location = New System.Drawing.Point(50, 380)
        Me.LL_Augenarzt.Name = "LL_Augenarzt"
        Me.LL_Augenarzt.Size = New System.Drawing.Size(55, 13)
        Me.LL_Augenarzt.TabIndex = 0
        Me.LL_Augenarzt.TabStop = True
        Me.LL_Augenarzt.Text = "Augenarzt"
        '
        'LL_Hobby
        '
        Me.LL_Hobby.AutoSize = True
        Me.LL_Hobby.Location = New System.Drawing.Point(50, 460)
        Me.LL_Hobby.Name = "LL_Hobby"
        Me.LL_Hobby.Size = New System.Drawing.Size(38, 13)
        Me.LL_Hobby.TabIndex = 0
        Me.LL_Hobby.TabStop = True
        Me.LL_Hobby.Text = "Hobby"
        '
        'LL_Frauenarzt
        '
        Me.LL_Frauenarzt.AutoSize = True
        Me.LL_Frauenarzt.Location = New System.Drawing.Point(50, 440)
        Me.LL_Frauenarzt.Name = "LL_Frauenarzt"
        Me.LL_Frauenarzt.Size = New System.Drawing.Size(57, 13)
        Me.LL_Frauenarzt.TabIndex = 0
        Me.LL_Frauenarzt.TabStop = True
        Me.LL_Frauenarzt.Text = "Frauenarzt"
        '
        'LL_Krankenhaus
        '
        Me.LL_Krankenhaus.AutoSize = True
        Me.LL_Krankenhaus.Location = New System.Drawing.Point(50, 420)
        Me.LL_Krankenhaus.Name = "LL_Krankenhaus"
        Me.LL_Krankenhaus.Size = New System.Drawing.Size(70, 13)
        Me.LL_Krankenhaus.TabIndex = 0
        Me.LL_Krankenhaus.TabStop = True
        Me.LL_Krankenhaus.Text = "Krankenhaus"
        '
        'LL_Hautarzt
        '
        Me.LL_Hautarzt.AutoSize = True
        Me.LL_Hautarzt.Location = New System.Drawing.Point(50, 400)
        Me.LL_Hautarzt.Name = "LL_Hautarzt"
        Me.LL_Hautarzt.Size = New System.Drawing.Size(47, 13)
        Me.LL_Hautarzt.TabIndex = 0
        Me.LL_Hautarzt.TabStop = True
        Me.LL_Hautarzt.Text = "Hautarzt"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(53, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 115)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(220, 200)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(741, 364)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'B_öffnen
        '
        Me.B_öffnen.Location = New System.Drawing.Point(583, 79)
        Me.B_öffnen.Name = "B_öffnen"
        Me.B_öffnen.Size = New System.Drawing.Size(107, 48)
        Me.B_öffnen.TabIndex = 4
        Me.B_öffnen.Text = "Öffnen"
        Me.B_öffnen.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Aaliyah", "Peter", "Hans"})
        Me.ComboBox1.Location = New System.Drawing.Point(295, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 603)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.B_öffnen)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LL_Hautarzt)
        Me.Controls.Add(Me.LL_Augenarzt)
        Me.Controls.Add(Me.LL_Doku)
        Me.Controls.Add(Me.LL_Krankenhaus)
        Me.Controls.Add(Me.LL_HNO)
        Me.Controls.Add(Me.LL_Eltern)
        Me.Controls.Add(Me.LL_Frauenarzt)
        Me.Controls.Add(Me.LL_Zahnarzt)
        Me.Controls.Add(Me.LL_Hilfen)
        Me.Controls.Add(Me.LL_Kinderarzt)
        Me.Controls.Add(Me.LL_Kontakte)
        Me.Controls.Add(Me.LL_Hobby)
        Me.Controls.Add(Me.LL_Psycho)
        Me.Controls.Add(Me.LL_Stammdaten)
        Me.Name = "Form1"
        Me.Text = "Start"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LL_Stammdaten As LinkLabel
    Friend WithEvents LL_Kontakte As LinkLabel
    Friend WithEvents LL_Hilfen As LinkLabel
    Friend WithEvents LL_Eltern As LinkLabel
    Friend WithEvents LL_Doku As LinkLabel
    Friend WithEvents LL_Psycho As LinkLabel
    Friend WithEvents LL_Kinderarzt As LinkLabel
    Friend WithEvents LL_Zahnarzt As LinkLabel
    Friend WithEvents LL_HNO As LinkLabel
    Friend WithEvents LL_Augenarzt As LinkLabel
    Friend WithEvents LL_Hobby As LinkLabel
    Friend WithEvents LL_Frauenarzt As LinkLabel
    Friend WithEvents LL_Krankenhaus As LinkLabel
    Friend WithEvents LL_Hautarzt As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents B_öffnen As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
