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
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("hinzufügen")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("bearbeiten")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("entfernen")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kinder", New System.Windows.Forms.TreeNode() {TreeNode29, TreeNode30, TreeNode31})
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("hinzufügen")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("bearbeiten")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("entfernen")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Benutzer", New System.Windows.Forms.TreeNode() {TreeNode33, TreeNode34, TreeNode35})
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mitarbeiter")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("admin", New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode36, TreeNode37})
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tagesbericht")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stammdaten")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kontakte")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("allgemeine Daten", New System.Windows.Forms.TreeNode() {TreeNode40, TreeNode41})
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hilfen")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doku")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Schule")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Psycho")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eltern")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kinderarzt")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hautarzt")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Augenarzt")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Zahnarzt")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HNO")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Krankenhaus")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Frauenarzt")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ärzte", New System.Windows.Forms.TreeNode() {TreeNode48, TreeNode49, TreeNode50, TreeNode51, TreeNode52, TreeNode53, TreeNode54})
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hobby")
        Me.Splitcontainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Augenarzt1 = New WindowsApp2.Augenarzt()
        Me.Psycho1 = New WindowsApp2.Psycho()
        Me.Zahnarzt1 = New WindowsApp2.Zahnarzt()
        Me.Stammdaten1 = New WindowsApp2.Stammdaten()
        Me.Schule1 = New WindowsApp2.Schule()
        Me.Krankenhaus1 = New WindowsApp2.Krankenhaus()
        Me.Kontakte1 = New WindowsApp2.Kontakte()
        Me.Kinderarzt1 = New WindowsApp2.Kinderarzt()
        Me.Hobby1 = New WindowsApp2.Hobby()
        Me.HNO1 = New WindowsApp2.HNO()
        Me.Hilfen1 = New WindowsApp2.Hilfen()
        Me.Hautarzt1 = New WindowsApp2.Hautarzt()
        Me.Frauenarzt1 = New WindowsApp2.Frauenarzt()
        Me.Eltern1 = New WindowsApp2.Eltern()
        Me.Doku1 = New WindowsApp2.Doku()
        Me.Anlegen1 = New WindowsApp2.anlegen()
        Me.CB_name = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.Splitcontainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitcontainer2.Panel1.SuspendLayout()
        Me.Splitcontainer2.Panel2.SuspendLayout()
        Me.Splitcontainer2.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitcontainer2
        '
        Me.Splitcontainer2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Splitcontainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Splitcontainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Splitcontainer2.Location = New System.Drawing.Point(0, 0)
        Me.Splitcontainer2.Name = "Splitcontainer2"
        '
        'Splitcontainer2.Panel1
        '
        Me.Splitcontainer2.Panel1.Controls.Add(Me.Panel15)
        '
        'Splitcontainer2.Panel2
        '
        Me.Splitcontainer2.Panel2.Controls.Add(Me.Panel1)
        Me.Splitcontainer2.Size = New System.Drawing.Size(1127, 490)
        Me.Splitcontainer2.SplitterDistance = 145
        Me.Splitcontainer2.TabIndex = 7
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.Control
        Me.Panel15.Controls.Add(Me.TreeView1)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(145, 490)
        Me.Panel15.TabIndex = 7
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode29.Name = "Knoten31"
        TreeNode29.Text = "hinzufügen"
        TreeNode30.Name = "Knoten32"
        TreeNode30.Text = "bearbeiten"
        TreeNode31.Name = "Knoten33"
        TreeNode31.Text = "entfernen"
        TreeNode32.Name = "Knoten29"
        TreeNode32.Text = "Kinder"
        TreeNode33.Name = "Knoten34"
        TreeNode33.Text = "hinzufügen"
        TreeNode34.Name = "Knoten35"
        TreeNode34.Text = "bearbeiten"
        TreeNode35.Name = "Knoten36"
        TreeNode35.Text = "entfernen"
        TreeNode36.Name = "Knoten30"
        TreeNode36.Text = "Benutzer"
        TreeNode37.Name = "Knoten1"
        TreeNode37.Text = "Mitarbeiter"
        TreeNode38.Name = "Knoten27"
        TreeNode38.Text = "admin"
        TreeNode39.Name = "Knoten28"
        TreeNode39.Text = "Tagesbericht"
        TreeNode40.Name = "Knoten10"
        TreeNode40.Text = "Stammdaten"
        TreeNode41.Name = "Knoten11"
        TreeNode41.Text = "Kontakte"
        TreeNode42.Name = "Knoten9"
        TreeNode42.Text = "allgemeine Daten"
        TreeNode43.Name = "Knoten2"
        TreeNode43.Text = "Hilfen"
        TreeNode44.Name = "Knoten6"
        TreeNode44.Text = "Doku"
        TreeNode45.Name = "Knoten3"
        TreeNode45.Text = "Schule"
        TreeNode46.Name = "Knoten4"
        TreeNode46.Text = "Psycho"
        TreeNode47.Name = "Knoten5"
        TreeNode47.Text = "Eltern"
        TreeNode48.Name = "Knoten12"
        TreeNode48.Text = "Kinderarzt"
        TreeNode49.Name = "Knoten13"
        TreeNode49.Text = "Hautarzt"
        TreeNode50.Name = "Knoten14"
        TreeNode50.Text = "Augenarzt"
        TreeNode51.Name = "Knoten15"
        TreeNode51.Text = "Zahnarzt"
        TreeNode52.Name = "Knoten16"
        TreeNode52.Text = "HNO"
        TreeNode53.Name = "Knoten19"
        TreeNode53.Text = "Krankenhaus"
        TreeNode54.Name = "Knoten20"
        TreeNode54.Text = "Frauenarzt"
        TreeNode55.Name = "Knoten8"
        TreeNode55.Text = "Ärzte"
        TreeNode56.Name = "Knoten7"
        TreeNode56.Text = "Hobby"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode39, TreeNode42, TreeNode43, TreeNode44, TreeNode45, TreeNode46, TreeNode47, TreeNode55, TreeNode56})
        Me.TreeView1.Size = New System.Drawing.Size(145, 490)
        Me.TreeView1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Augenarzt1)
        Me.Panel1.Controls.Add(Me.Psycho1)
        Me.Panel1.Controls.Add(Me.Zahnarzt1)
        Me.Panel1.Controls.Add(Me.Stammdaten1)
        Me.Panel1.Controls.Add(Me.Schule1)
        Me.Panel1.Controls.Add(Me.Krankenhaus1)
        Me.Panel1.Controls.Add(Me.Kontakte1)
        Me.Panel1.Controls.Add(Me.Kinderarzt1)
        Me.Panel1.Controls.Add(Me.Hobby1)
        Me.Panel1.Controls.Add(Me.HNO1)
        Me.Panel1.Controls.Add(Me.Hilfen1)
        Me.Panel1.Controls.Add(Me.Hautarzt1)
        Me.Panel1.Controls.Add(Me.Frauenarzt1)
        Me.Panel1.Controls.Add(Me.Eltern1)
        Me.Panel1.Controls.Add(Me.Doku1)
        Me.Panel1.Controls.Add(Me.Anlegen1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 490)
        Me.Panel1.TabIndex = 4
        '
        'Augenarzt1
        '
        Me.Augenarzt1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Augenarzt1.Location = New System.Drawing.Point(0, 0)
        Me.Augenarzt1.Name = "Augenarzt1"
        Me.Augenarzt1.Size = New System.Drawing.Size(978, 490)
        Me.Augenarzt1.TabIndex = 1
        '
        'Psycho1
        '
        Me.Psycho1.BackColor = System.Drawing.SystemColors.Control
        Me.Psycho1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Psycho1.Location = New System.Drawing.Point(0, 0)
        Me.Psycho1.Name = "Psycho1"
        Me.Psycho1.Size = New System.Drawing.Size(978, 490)
        Me.Psycho1.TabIndex = 16
        '
        'Zahnarzt1
        '
        Me.Zahnarzt1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Zahnarzt1.Location = New System.Drawing.Point(0, 0)
        Me.Zahnarzt1.Name = "Zahnarzt1"
        Me.Zahnarzt1.Size = New System.Drawing.Size(978, 490)
        Me.Zahnarzt1.TabIndex = 15
        '
        'Stammdaten1
        '
        Me.Stammdaten1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Stammdaten1.Location = New System.Drawing.Point(0, 0)
        Me.Stammdaten1.Name = "Stammdaten1"
        Me.Stammdaten1.Size = New System.Drawing.Size(978, 490)
        Me.Stammdaten1.TabIndex = 14
        '
        'Schule1
        '
        Me.Schule1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Schule1.Location = New System.Drawing.Point(0, 0)
        Me.Schule1.Name = "Schule1"
        Me.Schule1.Size = New System.Drawing.Size(978, 490)
        Me.Schule1.TabIndex = 13
        '
        'Krankenhaus1
        '
        Me.Krankenhaus1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Krankenhaus1.Location = New System.Drawing.Point(0, 0)
        Me.Krankenhaus1.Name = "Krankenhaus1"
        Me.Krankenhaus1.Size = New System.Drawing.Size(978, 490)
        Me.Krankenhaus1.TabIndex = 12
        '
        'Kontakte1
        '
        Me.Kontakte1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Kontakte1.Location = New System.Drawing.Point(0, 0)
        Me.Kontakte1.Name = "Kontakte1"
        Me.Kontakte1.Size = New System.Drawing.Size(978, 490)
        Me.Kontakte1.TabIndex = 11
        '
        'Kinderarzt1
        '
        Me.Kinderarzt1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Kinderarzt1.Location = New System.Drawing.Point(0, 0)
        Me.Kinderarzt1.Name = "Kinderarzt1"
        Me.Kinderarzt1.Size = New System.Drawing.Size(978, 490)
        Me.Kinderarzt1.TabIndex = 10
        '
        'Hobby1
        '
        Me.Hobby1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hobby1.Location = New System.Drawing.Point(0, 0)
        Me.Hobby1.Name = "Hobby1"
        Me.Hobby1.Size = New System.Drawing.Size(978, 490)
        Me.Hobby1.TabIndex = 9
        '
        'HNO1
        '
        Me.HNO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HNO1.Location = New System.Drawing.Point(0, 0)
        Me.HNO1.Name = "HNO1"
        Me.HNO1.Size = New System.Drawing.Size(978, 490)
        Me.HNO1.TabIndex = 8
        '
        'Hilfen1
        '
        Me.Hilfen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hilfen1.Location = New System.Drawing.Point(0, 0)
        Me.Hilfen1.Name = "Hilfen1"
        Me.Hilfen1.Size = New System.Drawing.Size(978, 490)
        Me.Hilfen1.TabIndex = 7
        '
        'Hautarzt1
        '
        Me.Hautarzt1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hautarzt1.Location = New System.Drawing.Point(0, 0)
        Me.Hautarzt1.Name = "Hautarzt1"
        Me.Hautarzt1.Size = New System.Drawing.Size(978, 490)
        Me.Hautarzt1.TabIndex = 6
        '
        'Frauenarzt1
        '
        Me.Frauenarzt1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frauenarzt1.Location = New System.Drawing.Point(0, 0)
        Me.Frauenarzt1.Name = "Frauenarzt1"
        Me.Frauenarzt1.Size = New System.Drawing.Size(978, 490)
        Me.Frauenarzt1.TabIndex = 4
        '
        'Eltern1
        '
        Me.Eltern1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Eltern1.Location = New System.Drawing.Point(0, 0)
        Me.Eltern1.Name = "Eltern1"
        Me.Eltern1.Size = New System.Drawing.Size(978, 490)
        Me.Eltern1.TabIndex = 3
        '
        'Doku1
        '
        Me.Doku1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Doku1.Location = New System.Drawing.Point(0, 0)
        Me.Doku1.Name = "Doku1"
        Me.Doku1.Size = New System.Drawing.Size(978, 490)
        Me.Doku1.TabIndex = 2
        '
        'Anlegen1
        '
        Me.Anlegen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Anlegen1.Location = New System.Drawing.Point(0, 0)
        Me.Anlegen1.Name = "Anlegen1"
        Me.Anlegen1.Size = New System.Drawing.Size(978, 490)
        Me.Anlegen1.TabIndex = 0
        '
        'CB_name
        '
        Me.CB_name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CB_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_name.FormattingEnabled = True
        Me.CB_name.Items.AddRange(New Object() {"Aaliyah"})
        Me.CB_name.Location = New System.Drawing.Point(415, 65)
        Me.CB_name.Name = "CB_name"
        Me.CB_name.Size = New System.Drawing.Size(262, 21)
        Me.CB_name.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1040, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(534, 358)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Label16"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitcontainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1127, 650)
        Me.SplitContainer1.SplitterDistance = 156
        Me.SplitContainer1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 650)
        Me.Controls.Add(Me.CB_name)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Start"
        Me.Splitcontainer2.Panel1.ResumeLayout(False)
        Me.Splitcontainer2.Panel2.ResumeLayout(False)
        CType(Me.Splitcontainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitcontainer2.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Splitcontainer2 As SplitContainer
    Friend WithEvents Panel15 As Panel
    Friend WithEvents CB_name As ComboBox

    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Psycho1 As Psycho
    Friend WithEvents Zahnarzt1 As Zahnarzt
    Friend WithEvents Stammdaten1 As Stammdaten
    Friend WithEvents Schule1 As Schule
    Friend WithEvents Krankenhaus1 As Krankenhaus
    Friend WithEvents Kontakte1 As Kontakte
    Friend WithEvents Kinderarzt1 As Kinderarzt
    Friend WithEvents Hobby1 As Hobby
    Friend WithEvents HNO1 As HNO
    Friend WithEvents Hilfen1 As Hilfen
    Friend WithEvents Hautarzt1 As Hautarzt
    Friend WithEvents Frauenarzt1 As Frauenarzt
    Friend WithEvents Eltern1 As Eltern
    Friend WithEvents Doku1 As Doku
    Friend WithEvents Augenarzt1 As Augenarzt
    Friend WithEvents Anlegen1 As anlegen
End Class
