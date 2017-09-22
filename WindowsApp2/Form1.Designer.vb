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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("hinzufügen")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("bearbeiten")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("entfernen")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kinder", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("hinzufügen")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("bearbeiten")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("entfernen")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Benutzer", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mitarbeiter")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("admin", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tagesbericht")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stammdaten")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kontakte")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("allgemeine Daten", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hilfen")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doku")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Schule")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Psycho/SPZ")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eltern")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kinderarzt")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hautarzt")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Augenarzt")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Zahnarzt")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HNO")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Krankenhaus")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Frauenarzt")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ärzte", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hobby")
        Me.Splitcontaineraaliyah = New System.Windows.Forms.SplitContainer()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CB_name = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Hautarzt1 = New WindowsApp2.Hautarzt()
        Me.Hilfen1 = New WindowsApp2.Hilfen()
        Me.Doku1 = New WindowsApp2.Doku()
        Me.Eltern1 = New WindowsApp2.Eltern()
        Me.Frauenarzt1 = New WindowsApp2.Frauenarzt()
        Me.Hno1 = New WindowsApp2.HNO()
        Me.Hobby1 = New WindowsApp2.Hobby()
        Me.Kinderarzt1 = New WindowsApp2.Kinderarzt()
        Me.Kontakte1 = New WindowsApp2.Kontakte()
        Me.Krankenhaus1 = New WindowsApp2.Krankenhaus()
        Me.Psycho1 = New WindowsApp2.Psycho()
        Me.Schule1 = New WindowsApp2.Schule()
        Me.Stammdaten1 = New WindowsApp2.Stammdaten()
        Me.Zahnarzt1 = New WindowsApp2.Zahnarzt()
        Me.Augenarzt1 = New WindowsApp2.Augenarzt()
        Me.Anlegen1 = New WindowsApp2.anlegen()
        CType(Me.Splitcontaineraaliyah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitcontaineraaliyah.Panel1.SuspendLayout()
        Me.Splitcontaineraaliyah.Panel2.SuspendLayout()
        Me.Splitcontaineraaliyah.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitcontaineraaliyah
        '
        Me.Splitcontaineraaliyah.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Splitcontaineraaliyah.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Splitcontaineraaliyah.Location = New System.Drawing.Point(0, 150)
        Me.Splitcontaineraaliyah.Name = "Splitcontaineraaliyah"
        '
        'Splitcontaineraaliyah.Panel1
        '
        Me.Splitcontaineraaliyah.Panel1.Controls.Add(Me.Panel15)
        '
        'Splitcontaineraaliyah.Panel2
        '
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.Panel1)
        Me.Splitcontaineraaliyah.Size = New System.Drawing.Size(1227, 547)
        Me.Splitcontaineraaliyah.SplitterDistance = 297
        Me.Splitcontaineraaliyah.TabIndex = 7
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.Control
        Me.Panel15.Controls.Add(Me.TreeView1)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(297, 547)
        Me.Panel15.TabIndex = 7
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Knoten31"
        TreeNode1.Text = "hinzufügen"
        TreeNode2.Name = "Knoten32"
        TreeNode2.Text = "bearbeiten"
        TreeNode3.Name = "Knoten33"
        TreeNode3.Text = "entfernen"
        TreeNode4.Name = "Knoten29"
        TreeNode4.Text = "Kinder"
        TreeNode5.Name = "Knoten34"
        TreeNode5.Text = "hinzufügen"
        TreeNode6.Name = "Knoten35"
        TreeNode6.Text = "bearbeiten"
        TreeNode7.Name = "Knoten36"
        TreeNode7.Text = "entfernen"
        TreeNode8.Name = "Knoten30"
        TreeNode8.Text = "Benutzer"
        TreeNode9.Name = "Knoten1"
        TreeNode9.Text = "Mitarbeiter"
        TreeNode10.Name = "Knoten27"
        TreeNode10.Text = "admin"
        TreeNode11.Name = "Knoten28"
        TreeNode11.Text = "Tagesbericht"
        TreeNode12.Name = "Knoten10"
        TreeNode12.Text = "Stammdaten"
        TreeNode13.Name = "Knoten11"
        TreeNode13.Text = "Kontakte"
        TreeNode14.Name = "Knoten9"
        TreeNode14.Text = "allgemeine Daten"
        TreeNode15.Name = "Knoten2"
        TreeNode15.Text = "Hilfen"
        TreeNode16.Name = "Knoten6"
        TreeNode16.Text = "Doku"
        TreeNode17.Name = "Knoten3"
        TreeNode17.Text = "Schule"
        TreeNode18.Name = "Knoten4"
        TreeNode18.Text = "Psycho"
        TreeNode19.Name = "Knoten5"
        TreeNode19.Text = "Eltern"
        TreeNode20.Name = "Knoten12"
        TreeNode20.Text = "Kinderarzt"
        TreeNode21.Name = "Knoten13"
        TreeNode21.Text = "Hautarzt"
        TreeNode22.Name = "Knoten14"
        TreeNode22.Text = "Augenarzt"
        TreeNode23.Name = "Knoten15"
        TreeNode23.Text = "Zahnarzt"
        TreeNode24.Name = "Knoten16"
        TreeNode24.Text = "HNO"
        TreeNode25.Name = "Knoten19"
        TreeNode25.Text = "Krankenhaus"
        TreeNode26.Name = "Knoten20"
        TreeNode26.Text = "Frauenarzt"
        TreeNode27.Name = "Knoten8"
        TreeNode27.Text = "Ärzte"
        TreeNode28.Name = "Knoten7"
        TreeNode28.Text = "Hobby"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode27, TreeNode28})
        Me.TreeView1.Size = New System.Drawing.Size(297, 547)
        Me.TreeView1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Hautarzt1)
        Me.Panel1.Controls.Add(Me.Hilfen1)
        Me.Panel1.Controls.Add(Me.Doku1)
        Me.Panel1.Controls.Add(Me.Eltern1)
        Me.Panel1.Controls.Add(Me.Frauenarzt1)
        Me.Panel1.Controls.Add(Me.Hno1)
        Me.Panel1.Controls.Add(Me.Hobby1)
        Me.Panel1.Controls.Add(Me.Kinderarzt1)
        Me.Panel1.Controls.Add(Me.Kontakte1)
        Me.Panel1.Controls.Add(Me.Krankenhaus1)
        Me.Panel1.Controls.Add(Me.Psycho1)
        Me.Panel1.Controls.Add(Me.Schule1)
        Me.Panel1.Controls.Add(Me.Stammdaten1)
        Me.Panel1.Controls.Add(Me.Zahnarzt1)
        Me.Panel1.Controls.Add(Me.Augenarzt1)
        Me.Panel1.Controls.Add(Me.Anlegen1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 476)
        Me.Panel1.TabIndex = 4
        '
        'CB_name
        '
        Me.CB_name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CB_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_name.FormattingEnabled = True
        Me.CB_name.Items.AddRange(New Object() {"Aaliyah"})
        Me.CB_name.Location = New System.Drawing.Point(480, 65)
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
        'Hautarzt1
        '
        Me.Hautarzt1.Location = New System.Drawing.Point(-6, -1)
        Me.Hautarzt1.Name = "Hautarzt1"
        Me.Hautarzt1.Size = New System.Drawing.Size(929, 545)
        Me.Hautarzt1.TabIndex = 15
        '
        'Hilfen1
        '
        Me.Hilfen1.Location = New System.Drawing.Point(-4, -1)
        Me.Hilfen1.Name = "Hilfen1"
        Me.Hilfen1.Size = New System.Drawing.Size(930, 545)
        Me.Hilfen1.TabIndex = 14
        '
        'Doku1
        '
        Me.Doku1.Location = New System.Drawing.Point(-6, -1)
        Me.Doku1.Name = "Doku1"
        Me.Doku1.Size = New System.Drawing.Size(928, 545)
        Me.Doku1.TabIndex = 13
        '
        'Eltern1
        '
        Me.Eltern1.Location = New System.Drawing.Point(-6, 0)
        Me.Eltern1.Name = "Eltern1"
        Me.Eltern1.Size = New System.Drawing.Size(932, 547)
        Me.Eltern1.TabIndex = 12
        '
        'Frauenarzt1
        '
        Me.Frauenarzt1.Location = New System.Drawing.Point(-6, -1)
        Me.Frauenarzt1.Name = "Frauenarzt1"
        Me.Frauenarzt1.Size = New System.Drawing.Size(931, 548)
        Me.Frauenarzt1.TabIndex = 11
        '
        'Hno1
        '
        Me.Hno1.Location = New System.Drawing.Point(0, -1)
        Me.Hno1.Name = "Hno1"
        Me.Hno1.Size = New System.Drawing.Size(923, 548)
        Me.Hno1.TabIndex = 10
        '
        'Hobby1
        '
        Me.Hobby1.Location = New System.Drawing.Point(-6, 3)
        Me.Hobby1.Name = "Hobby1"
        Me.Hobby1.Size = New System.Drawing.Size(928, 541)
        Me.Hobby1.TabIndex = 9
        '
        'Kinderarzt1
        '
        Me.Kinderarzt1.Location = New System.Drawing.Point(-6, -1)
        Me.Kinderarzt1.Name = "Kinderarzt1"
        Me.Kinderarzt1.Size = New System.Drawing.Size(932, 548)
        Me.Kinderarzt1.TabIndex = 8
        '
        'Kontakte1
        '
        Me.Kontakte1.Location = New System.Drawing.Point(-6, -1)
        Me.Kontakte1.Name = "Kontakte1"
        Me.Kontakte1.Size = New System.Drawing.Size(931, 548)
        Me.Kontakte1.TabIndex = 7
        '
        'Krankenhaus1
        '
        Me.Krankenhaus1.Location = New System.Drawing.Point(0, -1)
        Me.Krankenhaus1.Name = "Krankenhaus1"
        Me.Krankenhaus1.Size = New System.Drawing.Size(923, 545)
        Me.Krankenhaus1.TabIndex = 6
        '
        'Psycho1
        '
        Me.Psycho1.Location = New System.Drawing.Point(-6, 0)
        Me.Psycho1.Name = "Psycho1"
        Me.Psycho1.Size = New System.Drawing.Size(931, 544)
        Me.Psycho1.TabIndex = 5
        '
        'Schule1
        '
        Me.Schule1.Location = New System.Drawing.Point(-10, 0)
        Me.Schule1.Name = "Schule1"
        Me.Schule1.Size = New System.Drawing.Size(932, 547)
        Me.Schule1.TabIndex = 4
        '
        'Stammdaten1
        '
        Me.Stammdaten1.Location = New System.Drawing.Point(-10, 0)
        Me.Stammdaten1.Name = "Stammdaten1"
        Me.Stammdaten1.Size = New System.Drawing.Size(932, 544)
        Me.Stammdaten1.TabIndex = 3
        '
        'Zahnarzt1
        '
        Me.Zahnarzt1.Location = New System.Drawing.Point(-10, 0)
        Me.Zahnarzt1.Name = "Zahnarzt1"
        Me.Zahnarzt1.Size = New System.Drawing.Size(935, 547)
        Me.Zahnarzt1.TabIndex = 2
        '
        'Augenarzt1
        '
        Me.Augenarzt1.Location = New System.Drawing.Point(-10, 0)
        Me.Augenarzt1.Name = "Augenarzt1"
        Me.Augenarzt1.Size = New System.Drawing.Size(932, 547)
        Me.Augenarzt1.TabIndex = 1
        '
        'Anlegen1
        '
        Me.Anlegen1.Location = New System.Drawing.Point(0, 0)
        Me.Anlegen1.Name = "Anlegen1"
        Me.Anlegen1.Size = New System.Drawing.Size(925, 547)
        Me.Anlegen1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 721)
        Me.Controls.Add(Me.CB_name)
        Me.Controls.Add(Me.Splitcontaineraaliyah)
        Me.Name = "Form1"
        Me.Text = "Start"
        Me.Splitcontaineraaliyah.Panel1.ResumeLayout(False)
        Me.Splitcontaineraaliyah.Panel2.ResumeLayout(False)
        CType(Me.Splitcontaineraaliyah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitcontaineraaliyah.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Splitcontaineraaliyah As SplitContainer
    Friend WithEvents Panel15 As Panel
    Friend WithEvents CB_name As ComboBox

    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Anlegen1 As anlegen
    Friend WithEvents Psycho1 As Psycho
    Friend WithEvents Schule1 As Schule
    Friend WithEvents Stammdaten1 As Stammdaten
    Friend WithEvents Zahnarzt1 As Zahnarzt
    Friend WithEvents Augenarzt1 As Augenarzt
    Friend WithEvents Doku1 As Doku
    Friend WithEvents Eltern1 As Eltern
    Friend WithEvents Frauenarzt1 As Frauenarzt
    Friend WithEvents Hno1 As HNO
    Friend WithEvents Hobby1 As Hobby
    Friend WithEvents Kinderarzt1 As Kinderarzt
    Friend WithEvents Kontakte1 As Kontakte
    Friend WithEvents Krankenhaus1 As Krankenhaus
    Friend WithEvents Hilfen1 As Hilfen
    Friend WithEvents Hautarzt1 As Hautarzt
End Class
