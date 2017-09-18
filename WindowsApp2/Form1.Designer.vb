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
        Me.P_Aaliyah_Stammdaten = New System.Windows.Forms.Panel()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.L_Stammdaten = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Kontakte = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.L_Aaliyah_Kontakte = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Eltern = New System.Windows.Forms.Panel()
        Me.RichTextBox17 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox18 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox16 = New System.Windows.Forms.RichTextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.L_Aaliyah_Elternkontakte = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Schule = New System.Windows.Forms.Panel()
        Me.RichTextBox25 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox24 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox23 = New System.Windows.Forms.RichTextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Hilfen = New System.Windows.Forms.Panel()
        Me.RichTextBox22 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox21 = New System.Windows.Forms.RichTextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.L_Aaliyah_Hilfen = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Krankenhaus = New System.Windows.Forms.Panel()
        Me.RichTextBox20 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox19 = New System.Windows.Forms.RichTextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.L_Aaliyah_Krankenhaus = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Psycho = New System.Windows.Forms.Panel()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.RichTextBox15 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox14 = New System.Windows.Forms.RichTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.L_Aaliyah_Psycho = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Kinderarzt = New System.Windows.Forms.Panel()
        Me.RichTextBox13 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox12 = New System.Windows.Forms.RichTextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.L_Aaliyah_KInderarzt = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Zahnarzt = New System.Windows.Forms.Panel()
        Me.RichTextBox11 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox10 = New System.Windows.Forms.RichTextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.L_Aaliyah_Zahnarzt = New System.Windows.Forms.Label()
        Me.P_Aaliyah_HNO = New System.Windows.Forms.Panel()
        Me.RichTextBox9 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox8 = New System.Windows.Forms.RichTextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.L_Aaliyah_HNO = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Augenarzt = New System.Windows.Forms.Panel()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.L_Aaliyah_Augenarzt = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Hautarzt = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.L_Aaliyah_Hautarzt = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Hobby = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_Aaliyah_Hobby = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Frauenarzt = New System.Windows.Forms.Panel()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.L_Aaliyah_Frauenarzt = New System.Windows.Forms.Label()
        Me.P_Aaliyah_Doku = New System.Windows.Forms.Panel()
        Me.RichTextBoxdoku = New System.Windows.Forms.RichTextBox()
        Me.L_Aaliyah_Doku = New System.Windows.Forms.Label()
        Me.CB_name = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.Splitcontaineraaliyah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitcontaineraaliyah.Panel1.SuspendLayout()
        Me.Splitcontaineraaliyah.Panel2.SuspendLayout()
        Me.Splitcontaineraaliyah.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.P_Aaliyah_Stammdaten.SuspendLayout()
        Me.P_Aaliyah_Kontakte.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.P_Aaliyah_Eltern.SuspendLayout()
        Me.P_Aaliyah_Schule.SuspendLayout()
        Me.P_Aaliyah_Hilfen.SuspendLayout()
        Me.P_Aaliyah_Krankenhaus.SuspendLayout()
        Me.P_Aaliyah_Psycho.SuspendLayout()
        Me.P_Aaliyah_Kinderarzt.SuspendLayout()
        Me.P_Aaliyah_Zahnarzt.SuspendLayout()
        Me.P_Aaliyah_HNO.SuspendLayout()
        Me.P_Aaliyah_Augenarzt.SuspendLayout()
        Me.P_Aaliyah_Hautarzt.SuspendLayout()
        Me.P_Aaliyah_Hobby.SuspendLayout()
        Me.P_Aaliyah_Frauenarzt.SuspendLayout()
        Me.P_Aaliyah_Doku.SuspendLayout()
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
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Doku)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Hobby)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Zahnarzt)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Kinderarzt)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Psycho)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Krankenhaus)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Schule)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Eltern)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Kontakte)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Hilfen)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Stammdaten)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_HNO)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Augenarzt)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Hautarzt)
        Me.Splitcontaineraaliyah.Panel2.Controls.Add(Me.P_Aaliyah_Frauenarzt)
        Me.Splitcontaineraaliyah.Size = New System.Drawing.Size(1098, 476)
        Me.Splitcontaineraaliyah.SplitterDistance = 267
        Me.Splitcontaineraaliyah.TabIndex = 7
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.Control
        Me.Panel15.Controls.Add(Me.TreeView1)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(267, 476)
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
        TreeNode18.Text = "Psycho/SPZ"
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
        Me.TreeView1.Size = New System.Drawing.Size(267, 476)
        Me.TreeView1.TabIndex = 1
        '
        'P_Aaliyah_Stammdaten
        '
        Me.P_Aaliyah_Stammdaten.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox33)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox32)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox27)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox31)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox26)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox30)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox25)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox29)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox24)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox34)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox28)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox23)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.TextBox22)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label44)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label42)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label40)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label43)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label41)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label38)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label39)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label37)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label36)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label35)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label34)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label33)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.Label32)
        Me.P_Aaliyah_Stammdaten.Controls.Add(Me.L_Stammdaten)
        Me.P_Aaliyah_Stammdaten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Stammdaten.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Stammdaten.Name = "P_Aaliyah_Stammdaten"
        Me.P_Aaliyah_Stammdaten.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Stammdaten.TabIndex = 13
        '
        'TextBox33
        '
        Me.TextBox33.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox33.Location = New System.Drawing.Point(182, 71)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(100, 20)
        Me.TextBox33.TabIndex = 5
        '
        'TextBox32
        '
        Me.TextBox32.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox32.Location = New System.Drawing.Point(182, 106)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(100, 20)
        Me.TextBox32.TabIndex = 5
        '
        'TextBox27
        '
        Me.TextBox27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox27.Location = New System.Drawing.Point(409, 71)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(100, 20)
        Me.TextBox27.TabIndex = 5
        '
        'TextBox31
        '
        Me.TextBox31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox31.Location = New System.Drawing.Point(182, 141)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(100, 20)
        Me.TextBox31.TabIndex = 5
        '
        'TextBox26
        '
        Me.TextBox26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox26.Location = New System.Drawing.Point(409, 106)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(100, 20)
        Me.TextBox26.TabIndex = 5
        '
        'TextBox30
        '
        Me.TextBox30.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox30.Location = New System.Drawing.Point(182, 176)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(100, 20)
        Me.TextBox30.TabIndex = 5
        '
        'TextBox25
        '
        Me.TextBox25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox25.Location = New System.Drawing.Point(409, 141)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(100, 20)
        Me.TextBox25.TabIndex = 5
        '
        'TextBox29
        '
        Me.TextBox29.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox29.Location = New System.Drawing.Point(182, 211)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(100, 20)
        Me.TextBox29.TabIndex = 5
        '
        'TextBox24
        '
        Me.TextBox24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox24.Location = New System.Drawing.Point(409, 176)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 20)
        Me.TextBox24.TabIndex = 5
        '
        'TextBox34
        '
        Me.TextBox34.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox34.Location = New System.Drawing.Point(181, 281)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(100, 20)
        Me.TextBox34.TabIndex = 5
        '
        'TextBox28
        '
        Me.TextBox28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox28.Location = New System.Drawing.Point(182, 246)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(100, 20)
        Me.TextBox28.TabIndex = 5
        '
        'TextBox23
        '
        Me.TextBox23.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox23.Location = New System.Drawing.Point(409, 211)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(100, 20)
        Me.TextBox23.TabIndex = 5
        '
        'TextBox22
        '
        Me.TextBox22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox22.Location = New System.Drawing.Point(409, 246)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(100, 20)
        Me.TextBox22.TabIndex = 5
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(342, 246)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(58, 20)
        Me.Label44.TabIndex = 4
        Me.Label44.Text = "Schule"
        '
        'Label42
        '
        Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(17, 246)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(158, 20)
        Me.Label42.TabIndex = 4
        Me.Label42.Text = "Krankenversicherung"
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(315, 141)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(88, 20)
        Me.Label40.TabIndex = 4
        Me.Label40.Text = "Konfession"
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(324, 176)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(80, 20)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "Hilfe nach"
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(53, 281)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(122, 20)
        Me.Label41.TabIndex = 4
        Me.Label41.Text = "Besonderheiten"
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(311, 211)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(89, 20)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "Jugendamt"
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(318, 106)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(86, 20)
        Me.Label39.TabIndex = 4
        Me.Label39.Text = "Geburtsort"
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(35, 211)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(140, 20)
        Me.Label37.TabIndex = 4
        Me.Label37.Text = "Sorgerechtsstatus"
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(47, 176)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(128, 20)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "Aufnahmedatum"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(88, 141)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(89, 20)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Nationalität"
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(103, 71)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(74, 20)
        Me.Label34.TabIndex = 3
        Me.Label34.Text = "Vorname"
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(65, 106)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(112, 20)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Geburtsdatum"
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(352, 71)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(51, 20)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "Name"
        '
        'L_Stammdaten
        '
        Me.L_Stammdaten.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Stammdaten.AutoSize = True
        Me.L_Stammdaten.Font = New System.Drawing.Font("Times New Roman", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Stammdaten.Location = New System.Drawing.Point(256, 10)
        Me.L_Stammdaten.Name = "L_Stammdaten"
        Me.L_Stammdaten.Size = New System.Drawing.Size(112, 22)
        Me.L_Stammdaten.TabIndex = 0
        Me.L_Stammdaten.Text = "Stammdaten"
        '
        'P_Aaliyah_Kontakte
        '
        Me.P_Aaliyah_Kontakte.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Kontakte.Controls.Add(Me.TabControl1)
        Me.P_Aaliyah_Kontakte.Controls.Add(Me.L_Aaliyah_Kontakte)
        Me.P_Aaliyah_Kontakte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Kontakte.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Kontakte.Name = "P_Aaliyah_Kontakte"
        Me.P_Aaliyah_Kontakte.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Kontakte.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(23, 65)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(775, 382)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(767, 356)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Familie"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(767, 356)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Freunde"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(767, 356)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sonstige"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'L_Aaliyah_Kontakte
        '
        Me.L_Aaliyah_Kontakte.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Kontakte.AutoSize = True
        Me.L_Aaliyah_Kontakte.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Kontakte.Location = New System.Drawing.Point(270, 10)
        Me.L_Aaliyah_Kontakte.Name = "L_Aaliyah_Kontakte"
        Me.L_Aaliyah_Kontakte.Size = New System.Drawing.Size(86, 22)
        Me.L_Aaliyah_Kontakte.TabIndex = 0
        Me.L_Aaliyah_Kontakte.Text = "Kontakte"
        '
        'P_Aaliyah_Eltern
        '
        Me.P_Aaliyah_Eltern.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Eltern.Controls.Add(Me.RichTextBox17)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.RichTextBox18)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.RichTextBox16)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.TextBox12)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.TextBox13)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.TextBox11)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.Label23)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.Label22)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.Label21)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.Label20)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.Label19)
        Me.P_Aaliyah_Eltern.Controls.Add(Me.L_Aaliyah_Elternkontakte)
        Me.P_Aaliyah_Eltern.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Eltern.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Eltern.Name = "P_Aaliyah_Eltern"
        Me.P_Aaliyah_Eltern.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Eltern.TabIndex = 10
        '
        'RichTextBox17
        '
        Me.RichTextBox17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox17.Location = New System.Drawing.Point(432, 102)
        Me.RichTextBox17.Name = "RichTextBox17"
        Me.RichTextBox17.Size = New System.Drawing.Size(100, 56)
        Me.RichTextBox17.TabIndex = 7
        Me.RichTextBox17.Text = ""
        '
        'RichTextBox18
        '
        Me.RichTextBox18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox18.Location = New System.Drawing.Point(156, 106)
        Me.RichTextBox18.Name = "RichTextBox18"
        Me.RichTextBox18.Size = New System.Drawing.Size(100, 60)
        Me.RichTextBox18.TabIndex = 7
        Me.RichTextBox18.Text = ""
        '
        'RichTextBox16
        '
        Me.RichTextBox16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox16.Location = New System.Drawing.Point(34, 185)
        Me.RichTextBox16.Name = "RichTextBox16"
        Me.RichTextBox16.Size = New System.Drawing.Size(764, 274)
        Me.RichTextBox16.TabIndex = 7
        Me.RichTextBox16.Text = ""
        '
        'TextBox12
        '
        Me.TextBox12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox12.Location = New System.Drawing.Point(34, 102)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(84, 20)
        Me.TextBox12.TabIndex = 6
        '
        'TextBox13
        '
        Me.TextBox13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox13.Location = New System.Drawing.Point(619, 106)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.TextBox13.TabIndex = 6
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox11.Location = New System.Drawing.Point(312, 104)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(94, 20)
        Me.TextBox11.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(615, 65)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 20)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Sorgerecht"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(428, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 20)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Anschrift"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(158, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 20)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Anschrift"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(308, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 20)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Vater"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(30, 65)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 20)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Mutter"
        '
        'L_Aaliyah_Elternkontakte
        '
        Me.L_Aaliyah_Elternkontakte.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Elternkontakte.AutoSize = True
        Me.L_Aaliyah_Elternkontakte.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Elternkontakte.Location = New System.Drawing.Point(234, 10)
        Me.L_Aaliyah_Elternkontakte.Name = "L_Aaliyah_Elternkontakte"
        Me.L_Aaliyah_Elternkontakte.Size = New System.Drawing.Size(134, 22)
        Me.L_Aaliyah_Elternkontakte.TabIndex = 0
        Me.L_Aaliyah_Elternkontakte.Text = "Elternkontakte"
        '
        'P_Aaliyah_Schule
        '
        Me.P_Aaliyah_Schule.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Schule.Controls.Add(Me.RichTextBox25)
        Me.P_Aaliyah_Schule.Controls.Add(Me.RichTextBox24)
        Me.P_Aaliyah_Schule.Controls.Add(Me.RichTextBox23)
        Me.P_Aaliyah_Schule.Controls.Add(Me.TextBox21)
        Me.P_Aaliyah_Schule.Controls.Add(Me.TextBox20)
        Me.P_Aaliyah_Schule.Controls.Add(Me.Label49)
        Me.P_Aaliyah_Schule.Controls.Add(Me.Label48)
        Me.P_Aaliyah_Schule.Controls.Add(Me.Label47)
        Me.P_Aaliyah_Schule.Controls.Add(Me.Label46)
        Me.P_Aaliyah_Schule.Controls.Add(Me.Label45)
        Me.P_Aaliyah_Schule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Schule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_Aaliyah_Schule.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Schule.Name = "P_Aaliyah_Schule"
        Me.P_Aaliyah_Schule.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Schule.TabIndex = 5
        '
        'RichTextBox25
        '
        Me.RichTextBox25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox25.Location = New System.Drawing.Point(34, 162)
        Me.RichTextBox25.Name = "RichTextBox25"
        Me.RichTextBox25.Size = New System.Drawing.Size(764, 285)
        Me.RichTextBox25.TabIndex = 2
        Me.RichTextBox25.Text = ""
        '
        'RichTextBox24
        '
        Me.RichTextBox24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox24.Location = New System.Drawing.Point(166, 97)
        Me.RichTextBox24.Name = "RichTextBox24"
        Me.RichTextBox24.Size = New System.Drawing.Size(100, 48)
        Me.RichTextBox24.TabIndex = 2
        Me.RichTextBox24.Text = ""
        '
        'RichTextBox23
        '
        Me.RichTextBox23.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox23.Location = New System.Drawing.Point(45, 99)
        Me.RichTextBox23.Name = "RichTextBox23"
        Me.RichTextBox23.Size = New System.Drawing.Size(100, 25)
        Me.RichTextBox23.TabIndex = 2
        Me.RichTextBox23.Text = ""
        '
        'TextBox21
        '
        Me.TextBox21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox21.Location = New System.Drawing.Point(304, 93)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 26)
        Me.TextBox21.TabIndex = 1
        '
        'TextBox20
        '
        Me.TextBox20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox20.Location = New System.Drawing.Point(466, 96)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 26)
        Me.TextBox20.TabIndex = 1
        '
        'Label49
        '
        Me.Label49.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(464, 62)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(73, 20)
        Me.Label49.TabIndex = 0
        Me.Label49.Text = "Lehrkraft"
        '
        'Label48
        '
        Me.Label48.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(162, 62)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 20)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Anschrift"
        '
        'Label47
        '
        Me.Label47.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(300, 62)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(56, 20)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Klasse"
        '
        'Label46
        '
        Me.Label46.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(41, 62)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(58, 20)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "Schule"
        '
        'Label45
        '
        Me.Label45.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(259, 11)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(64, 22)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "Schule"
        '
        'P_Aaliyah_Hilfen
        '
        Me.P_Aaliyah_Hilfen.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.RichTextBox22)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.RichTextBox21)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.TextBox19)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.TextBox18)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.TextBox17)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.TextBox16)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.TextBox15)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.Label31)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.Label30)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.Label29)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.Label28)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.Label27)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.Label24)
        Me.P_Aaliyah_Hilfen.Controls.Add(Me.L_Aaliyah_Hilfen)
        Me.P_Aaliyah_Hilfen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Hilfen.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Hilfen.Name = "P_Aaliyah_Hilfen"
        Me.P_Aaliyah_Hilfen.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Hilfen.TabIndex = 11
        '
        'RichTextBox22
        '
        Me.RichTextBox22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox22.Location = New System.Drawing.Point(23, 245)
        Me.RichTextBox22.Name = "RichTextBox22"
        Me.RichTextBox22.Size = New System.Drawing.Size(775, 202)
        Me.RichTextBox22.TabIndex = 8
        Me.RichTextBox22.Text = ""
        '
        'RichTextBox21
        '
        Me.RichTextBox21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox21.Location = New System.Drawing.Point(85, 162)
        Me.RichTextBox21.Name = "RichTextBox21"
        Me.RichTextBox21.Size = New System.Drawing.Size(100, 60)
        Me.RichTextBox21.TabIndex = 8
        Me.RichTextBox21.Text = ""
        '
        'TextBox19
        '
        Me.TextBox19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox19.Location = New System.Drawing.Point(213, 162)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.TextBox19.TabIndex = 7
        '
        'TextBox18
        '
        Me.TextBox18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox18.Location = New System.Drawing.Point(447, 92)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 7
        '
        'TextBox17
        '
        Me.TextBox17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox17.Location = New System.Drawing.Point(447, 162)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 20)
        Me.TextBox17.TabIndex = 7
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox16.Location = New System.Drawing.Point(213, 92)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 20)
        Me.TextBox16.TabIndex = 7
        '
        'TextBox15
        '
        Me.TextBox15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox15.Location = New System.Drawing.Point(85, 92)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.TextBox15.TabIndex = 7
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(443, 125)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 20)
        Me.Label31.TabIndex = 6
        Me.Label31.Text = "Hilfe nach"
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(443, 65)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(186, 20)
        Me.Label30.TabIndex = 5
        Me.Label30.Text = "Sorgeberechtigte Person"
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(84, 122)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 20)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Anschrift"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(209, 62)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(118, 20)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Sachbearbeiter"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(211, 125)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 20)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Durchwahl"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(81, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(89, 20)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Jugendamt"
        '
        'L_Aaliyah_Hilfen
        '
        Me.L_Aaliyah_Hilfen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Hilfen.AutoSize = True
        Me.L_Aaliyah_Hilfen.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Hilfen.Location = New System.Drawing.Point(272, 8)
        Me.L_Aaliyah_Hilfen.Name = "L_Aaliyah_Hilfen"
        Me.L_Aaliyah_Hilfen.Size = New System.Drawing.Size(59, 22)
        Me.L_Aaliyah_Hilfen.TabIndex = 0
        Me.L_Aaliyah_Hilfen.Text = "Hilfen"
        '
        'P_Aaliyah_Krankenhaus
        '
        Me.P_Aaliyah_Krankenhaus.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Krankenhaus.Controls.Add(Me.RichTextBox20)
        Me.P_Aaliyah_Krankenhaus.Controls.Add(Me.RichTextBox19)
        Me.P_Aaliyah_Krankenhaus.Controls.Add(Me.TextBox14)
        Me.P_Aaliyah_Krankenhaus.Controls.Add(Me.Label26)
        Me.P_Aaliyah_Krankenhaus.Controls.Add(Me.Label25)
        Me.P_Aaliyah_Krankenhaus.Controls.Add(Me.L_Aaliyah_Krankenhaus)
        Me.P_Aaliyah_Krankenhaus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Krankenhaus.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Krankenhaus.Name = "P_Aaliyah_Krankenhaus"
        Me.P_Aaliyah_Krankenhaus.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Krankenhaus.TabIndex = 2
        '
        'RichTextBox20
        '
        Me.RichTextBox20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox20.Location = New System.Drawing.Point(34, 170)
        Me.RichTextBox20.Name = "RichTextBox20"
        Me.RichTextBox20.Size = New System.Drawing.Size(764, 277)
        Me.RichTextBox20.TabIndex = 6
        Me.RichTextBox20.Text = ""
        '
        'RichTextBox19
        '
        Me.RichTextBox19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox19.Location = New System.Drawing.Point(252, 100)
        Me.RichTextBox19.Name = "RichTextBox19"
        Me.RichTextBox19.Size = New System.Drawing.Size(100, 58)
        Me.RichTextBox19.TabIndex = 6
        Me.RichTextBox19.Text = ""
        '
        'TextBox14
        '
        Me.TextBox14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox14.Location = New System.Drawing.Point(109, 102)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.TextBox14.TabIndex = 4
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(251, 62)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 20)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Anschrift"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(105, 62)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 20)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Station"
        '
        'L_Aaliyah_Krankenhaus
        '
        Me.L_Aaliyah_Krankenhaus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Krankenhaus.AutoSize = True
        Me.L_Aaliyah_Krankenhaus.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Krankenhaus.Location = New System.Drawing.Point(248, 10)
        Me.L_Aaliyah_Krankenhaus.Name = "L_Aaliyah_Krankenhaus"
        Me.L_Aaliyah_Krankenhaus.Size = New System.Drawing.Size(120, 22)
        Me.L_Aaliyah_Krankenhaus.TabIndex = 0
        Me.L_Aaliyah_Krankenhaus.Text = "Krankenhaus"
        '
        'P_Aaliyah_Psycho
        '
        Me.P_Aaliyah_Psycho.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Psycho.Controls.Add(Me.TextBox10)
        Me.P_Aaliyah_Psycho.Controls.Add(Me.RichTextBox15)
        Me.P_Aaliyah_Psycho.Controls.Add(Me.RichTextBox14)
        Me.P_Aaliyah_Psycho.Controls.Add(Me.Label18)
        Me.P_Aaliyah_Psycho.Controls.Add(Me.Label17)
        Me.P_Aaliyah_Psycho.Controls.Add(Me.L_Aaliyah_Psycho)
        Me.P_Aaliyah_Psycho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Psycho.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Psycho.Name = "P_Aaliyah_Psycho"
        Me.P_Aaliyah_Psycho.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Psycho.TabIndex = 8
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox10.Location = New System.Drawing.Point(162, 102)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(78, 20)
        Me.TextBox10.TabIndex = 5
        '
        'RichTextBox15
        '
        Me.RichTextBox15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox15.Location = New System.Drawing.Point(23, 185)
        Me.RichTextBox15.Name = "RichTextBox15"
        Me.RichTextBox15.Size = New System.Drawing.Size(775, 262)
        Me.RichTextBox15.TabIndex = 4
        Me.RichTextBox15.Text = ""
        '
        'RichTextBox14
        '
        Me.RichTextBox14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox14.Location = New System.Drawing.Point(292, 106)
        Me.RichTextBox14.Name = "RichTextBox14"
        Me.RichTextBox14.Size = New System.Drawing.Size(100, 56)
        Me.RichTextBox14.TabIndex = 3
        Me.RichTextBox14.Text = ""
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(288, 69)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Anschrift"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(158, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 20)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Name"
        '
        'L_Aaliyah_Psycho
        '
        Me.L_Aaliyah_Psycho.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Psycho.AutoSize = True
        Me.L_Aaliyah_Psycho.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Psycho.Location = New System.Drawing.Point(288, 10)
        Me.L_Aaliyah_Psycho.Name = "L_Aaliyah_Psycho"
        Me.L_Aaliyah_Psycho.Size = New System.Drawing.Size(68, 22)
        Me.L_Aaliyah_Psycho.TabIndex = 0
        Me.L_Aaliyah_Psycho.Text = "Psycho"
        '
        'P_Aaliyah_Kinderarzt
        '
        Me.P_Aaliyah_Kinderarzt.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Kinderarzt.Controls.Add(Me.RichTextBox13)
        Me.P_Aaliyah_Kinderarzt.Controls.Add(Me.RichTextBox12)
        Me.P_Aaliyah_Kinderarzt.Controls.Add(Me.TextBox9)
        Me.P_Aaliyah_Kinderarzt.Controls.Add(Me.Label15)
        Me.P_Aaliyah_Kinderarzt.Controls.Add(Me.Label14)
        Me.P_Aaliyah_Kinderarzt.Controls.Add(Me.L_Aaliyah_KInderarzt)
        Me.P_Aaliyah_Kinderarzt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Kinderarzt.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Kinderarzt.Name = "P_Aaliyah_Kinderarzt"
        Me.P_Aaliyah_Kinderarzt.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Kinderarzt.TabIndex = 7
        '
        'RichTextBox13
        '
        Me.RichTextBox13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox13.Location = New System.Drawing.Point(23, 185)
        Me.RichTextBox13.Name = "RichTextBox13"
        Me.RichTextBox13.Size = New System.Drawing.Size(775, 262)
        Me.RichTextBox13.TabIndex = 5
        Me.RichTextBox13.Text = ""
        '
        'RichTextBox12
        '
        Me.RichTextBox12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox12.Location = New System.Drawing.Point(265, 106)
        Me.RichTextBox12.Name = "RichTextBox12"
        Me.RichTextBox12.Size = New System.Drawing.Size(100, 56)
        Me.RichTextBox12.TabIndex = 4
        Me.RichTextBox12.Text = ""
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox9.Location = New System.Drawing.Point(105, 105)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(261, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Anschrift"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(101, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Name"
        '
        'L_Aaliyah_KInderarzt
        '
        Me.L_Aaliyah_KInderarzt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_KInderarzt.AutoSize = True
        Me.L_Aaliyah_KInderarzt.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_KInderarzt.Location = New System.Drawing.Point(270, 10)
        Me.L_Aaliyah_KInderarzt.Name = "L_Aaliyah_KInderarzt"
        Me.L_Aaliyah_KInderarzt.Size = New System.Drawing.Size(98, 22)
        Me.L_Aaliyah_KInderarzt.TabIndex = 0
        Me.L_Aaliyah_KInderarzt.Text = "Kinderarzt"
        '
        'P_Aaliyah_Zahnarzt
        '
        Me.P_Aaliyah_Zahnarzt.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Zahnarzt.Controls.Add(Me.RichTextBox11)
        Me.P_Aaliyah_Zahnarzt.Controls.Add(Me.RichTextBox10)
        Me.P_Aaliyah_Zahnarzt.Controls.Add(Me.TextBox8)
        Me.P_Aaliyah_Zahnarzt.Controls.Add(Me.Label13)
        Me.P_Aaliyah_Zahnarzt.Controls.Add(Me.Label12)
        Me.P_Aaliyah_Zahnarzt.Controls.Add(Me.L_Aaliyah_Zahnarzt)
        Me.P_Aaliyah_Zahnarzt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Zahnarzt.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Zahnarzt.Name = "P_Aaliyah_Zahnarzt"
        Me.P_Aaliyah_Zahnarzt.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Zahnarzt.TabIndex = 6
        '
        'RichTextBox11
        '
        Me.RichTextBox11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox11.Location = New System.Drawing.Point(23, 185)
        Me.RichTextBox11.Name = "RichTextBox11"
        Me.RichTextBox11.Size = New System.Drawing.Size(775, 274)
        Me.RichTextBox11.TabIndex = 14
        Me.RichTextBox11.Text = ""
        '
        'RichTextBox10
        '
        Me.RichTextBox10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox10.Location = New System.Drawing.Point(288, 102)
        Me.RichTextBox10.Name = "RichTextBox10"
        Me.RichTextBox10.Size = New System.Drawing.Size(100, 60)
        Me.RichTextBox10.TabIndex = 13
        Me.RichTextBox10.Text = ""
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox8.Location = New System.Drawing.Point(156, 102)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(284, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Anschrift"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(152, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Name"
        '
        'L_Aaliyah_Zahnarzt
        '
        Me.L_Aaliyah_Zahnarzt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Zahnarzt.AutoSize = True
        Me.L_Aaliyah_Zahnarzt.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Zahnarzt.Location = New System.Drawing.Point(284, 10)
        Me.L_Aaliyah_Zahnarzt.Name = "L_Aaliyah_Zahnarzt"
        Me.L_Aaliyah_Zahnarzt.Size = New System.Drawing.Size(84, 22)
        Me.L_Aaliyah_Zahnarzt.TabIndex = 9
        Me.L_Aaliyah_Zahnarzt.Text = "Zahnarzt"
        '
        'P_Aaliyah_HNO
        '
        Me.P_Aaliyah_HNO.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_HNO.Controls.Add(Me.RichTextBox9)
        Me.P_Aaliyah_HNO.Controls.Add(Me.RichTextBox8)
        Me.P_Aaliyah_HNO.Controls.Add(Me.TextBox7)
        Me.P_Aaliyah_HNO.Controls.Add(Me.Label11)
        Me.P_Aaliyah_HNO.Controls.Add(Me.Label10)
        Me.P_Aaliyah_HNO.Controls.Add(Me.L_Aaliyah_HNO)
        Me.P_Aaliyah_HNO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_HNO.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_HNO.Name = "P_Aaliyah_HNO"
        Me.P_Aaliyah_HNO.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_HNO.TabIndex = 5
        '
        'RichTextBox9
        '
        Me.RichTextBox9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox9.Location = New System.Drawing.Point(23, 185)
        Me.RichTextBox9.Name = "RichTextBox9"
        Me.RichTextBox9.Size = New System.Drawing.Size(775, 274)
        Me.RichTextBox9.TabIndex = 5
        Me.RichTextBox9.Text = ""
        '
        'RichTextBox8
        '
        Me.RichTextBox8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox8.Location = New System.Drawing.Point(296, 102)
        Me.RichTextBox8.Name = "RichTextBox8"
        Me.RichTextBox8.Size = New System.Drawing.Size(100, 60)
        Me.RichTextBox8.TabIndex = 4
        Me.RichTextBox8.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox7.Location = New System.Drawing.Point(130, 88)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(292, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Anschrift"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(126, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Name"
        '
        'L_Aaliyah_HNO
        '
        Me.L_Aaliyah_HNO.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_HNO.AutoSize = True
        Me.L_Aaliyah_HNO.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_HNO.Location = New System.Drawing.Point(292, 8)
        Me.L_Aaliyah_HNO.Name = "L_Aaliyah_HNO"
        Me.L_Aaliyah_HNO.Size = New System.Drawing.Size(53, 22)
        Me.L_Aaliyah_HNO.TabIndex = 0
        Me.L_Aaliyah_HNO.Text = "HNO"
        '
        'P_Aaliyah_Augenarzt
        '
        Me.P_Aaliyah_Augenarzt.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Augenarzt.Controls.Add(Me.RichTextBox7)
        Me.P_Aaliyah_Augenarzt.Controls.Add(Me.RichTextBox6)
        Me.P_Aaliyah_Augenarzt.Controls.Add(Me.TextBox6)
        Me.P_Aaliyah_Augenarzt.Controls.Add(Me.Label9)
        Me.P_Aaliyah_Augenarzt.Controls.Add(Me.Label8)
        Me.P_Aaliyah_Augenarzt.Controls.Add(Me.L_Aaliyah_Augenarzt)
        Me.P_Aaliyah_Augenarzt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Augenarzt.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Augenarzt.Name = "P_Aaliyah_Augenarzt"
        Me.P_Aaliyah_Augenarzt.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Augenarzt.TabIndex = 4
        '
        'RichTextBox7
        '
        Me.RichTextBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox7.Location = New System.Drawing.Point(23, 185)
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.Size = New System.Drawing.Size(775, 274)
        Me.RichTextBox7.TabIndex = 5
        Me.RichTextBox7.Text = ""
        '
        'RichTextBox6
        '
        Me.RichTextBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox6.Location = New System.Drawing.Point(255, 102)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.Size = New System.Drawing.Size(100, 60)
        Me.RichTextBox6.TabIndex = 4
        Me.RichTextBox6.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox6.Location = New System.Drawing.Point(118, 102)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(251, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Anschrift"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(114, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Name"
        '
        'L_Aaliyah_Augenarzt
        '
        Me.L_Aaliyah_Augenarzt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Augenarzt.AutoSize = True
        Me.L_Aaliyah_Augenarzt.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Augenarzt.Location = New System.Drawing.Point(251, 10)
        Me.L_Aaliyah_Augenarzt.Name = "L_Aaliyah_Augenarzt"
        Me.L_Aaliyah_Augenarzt.Size = New System.Drawing.Size(94, 22)
        Me.L_Aaliyah_Augenarzt.TabIndex = 0
        Me.L_Aaliyah_Augenarzt.Text = "Augenarzt"
        '
        'P_Aaliyah_Hautarzt
        '
        Me.P_Aaliyah_Hautarzt.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Hautarzt.Controls.Add(Me.TextBox5)
        Me.P_Aaliyah_Hautarzt.Controls.Add(Me.RichTextBox5)
        Me.P_Aaliyah_Hautarzt.Controls.Add(Me.RichTextBox4)
        Me.P_Aaliyah_Hautarzt.Controls.Add(Me.Label7)
        Me.P_Aaliyah_Hautarzt.Controls.Add(Me.Label6)
        Me.P_Aaliyah_Hautarzt.Controls.Add(Me.L_Aaliyah_Hautarzt)
        Me.P_Aaliyah_Hautarzt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Hautarzt.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Hautarzt.Name = "P_Aaliyah_Hautarzt"
        Me.P_Aaliyah_Hautarzt.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Hautarzt.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox5.Location = New System.Drawing.Point(118, 105)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 5
        '
        'RichTextBox5
        '
        Me.RichTextBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichTextBox5.Location = New System.Drawing.Point(275, 104)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.Size = New System.Drawing.Size(118, 38)
        Me.RichTextBox5.TabIndex = 4
        Me.RichTextBox5.Text = ""
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox4.Location = New System.Drawing.Point(23, 168)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(775, 292)
        Me.RichTextBox4.TabIndex = 3
        Me.RichTextBox4.Text = ""
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(274, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Anschrift"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Name"
        '
        'L_Aaliyah_Hautarzt
        '
        Me.L_Aaliyah_Hautarzt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Hautarzt.AutoSize = True
        Me.L_Aaliyah_Hautarzt.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Hautarzt.Location = New System.Drawing.Point(274, 10)
        Me.L_Aaliyah_Hautarzt.Name = "L_Aaliyah_Hautarzt"
        Me.L_Aaliyah_Hautarzt.Size = New System.Drawing.Size(82, 22)
        Me.L_Aaliyah_Hautarzt.TabIndex = 0
        Me.L_Aaliyah_Hautarzt.Text = "Hautarzt"
        '
        'P_Aaliyah_Hobby
        '
        Me.P_Aaliyah_Hobby.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Hobby.Controls.Add(Me.RichTextBox1)
        Me.P_Aaliyah_Hobby.Controls.Add(Me.TextBox3)
        Me.P_Aaliyah_Hobby.Controls.Add(Me.TextBox2)
        Me.P_Aaliyah_Hobby.Controls.Add(Me.TextBox1)
        Me.P_Aaliyah_Hobby.Controls.Add(Me.Label3)
        Me.P_Aaliyah_Hobby.Controls.Add(Me.Label2)
        Me.P_Aaliyah_Hobby.Controls.Add(Me.Label1)
        Me.P_Aaliyah_Hobby.Controls.Add(Me.L_Aaliyah_Hobby)
        Me.P_Aaliyah_Hobby.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Hobby.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Hobby.Name = "P_Aaliyah_Hobby"
        Me.P_Aaliyah_Hobby.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Hobby.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(23, 170)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(775, 290)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox3.Location = New System.Drawing.Point(244, 104)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 58)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.Location = New System.Drawing.Point(474, 105)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 57)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Location = New System.Drawing.Point(81, 102)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(470, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Trainingszeiten"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ansprechpartner"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Verein"
        '
        'L_Aaliyah_Hobby
        '
        Me.L_Aaliyah_Hobby.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Hobby.AutoSize = True
        Me.L_Aaliyah_Hobby.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Hobby.Location = New System.Drawing.Point(271, 10)
        Me.L_Aaliyah_Hobby.Name = "L_Aaliyah_Hobby"
        Me.L_Aaliyah_Hobby.Size = New System.Drawing.Size(63, 22)
        Me.L_Aaliyah_Hobby.TabIndex = 0
        Me.L_Aaliyah_Hobby.Text = "Hobby"
        '
        'P_Aaliyah_Frauenarzt
        '
        Me.P_Aaliyah_Frauenarzt.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Frauenarzt.Controls.Add(Me.RichTextBox3)
        Me.P_Aaliyah_Frauenarzt.Controls.Add(Me.TextBox4)
        Me.P_Aaliyah_Frauenarzt.Controls.Add(Me.Label5)
        Me.P_Aaliyah_Frauenarzt.Controls.Add(Me.Label4)
        Me.P_Aaliyah_Frauenarzt.Controls.Add(Me.RichTextBox2)
        Me.P_Aaliyah_Frauenarzt.Controls.Add(Me.L_Aaliyah_Frauenarzt)
        Me.P_Aaliyah_Frauenarzt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Frauenarzt.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Frauenarzt.Name = "P_Aaliyah_Frauenarzt"
        Me.P_Aaliyah_Frauenarzt.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Frauenarzt.TabIndex = 1
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(260, 102)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(100, 60)
        Me.RichTextBox3.TabIndex = 5
        Me.RichTextBox3.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox4.Location = New System.Drawing.Point(85, 102)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Anschrift"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.Location = New System.Drawing.Point(23, 185)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(775, 274)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = ""
        '
        'L_Aaliyah_Frauenarzt
        '
        Me.L_Aaliyah_Frauenarzt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Frauenarzt.AutoSize = True
        Me.L_Aaliyah_Frauenarzt.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Frauenarzt.Location = New System.Drawing.Point(251, 8)
        Me.L_Aaliyah_Frauenarzt.Name = "L_Aaliyah_Frauenarzt"
        Me.L_Aaliyah_Frauenarzt.Size = New System.Drawing.Size(101, 22)
        Me.L_Aaliyah_Frauenarzt.TabIndex = 0
        Me.L_Aaliyah_Frauenarzt.Text = "Frauenarzt"
        '
        'P_Aaliyah_Doku
        '
        Me.P_Aaliyah_Doku.BackColor = System.Drawing.SystemColors.Control
        Me.P_Aaliyah_Doku.Controls.Add(Me.RichTextBoxdoku)
        Me.P_Aaliyah_Doku.Controls.Add(Me.L_Aaliyah_Doku)
        Me.P_Aaliyah_Doku.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Aaliyah_Doku.Location = New System.Drawing.Point(0, 0)
        Me.P_Aaliyah_Doku.Name = "P_Aaliyah_Doku"
        Me.P_Aaliyah_Doku.Size = New System.Drawing.Size(827, 476)
        Me.P_Aaliyah_Doku.TabIndex = 9
        '
        'RichTextBoxdoku
        '
        Me.RichTextBoxdoku.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxdoku.Location = New System.Drawing.Point(3, 45)
        Me.RichTextBoxdoku.Name = "RichTextBoxdoku"
        Me.RichTextBoxdoku.Size = New System.Drawing.Size(821, 428)
        Me.RichTextBoxdoku.TabIndex = 1
        Me.RichTextBoxdoku.Text = ""
        '
        'L_Aaliyah_Doku
        '
        Me.L_Aaliyah_Doku.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L_Aaliyah_Doku.AutoSize = True
        Me.L_Aaliyah_Doku.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Aaliyah_Doku.Location = New System.Drawing.Point(334, 10)
        Me.L_Aaliyah_Doku.Name = "L_Aaliyah_Doku"
        Me.L_Aaliyah_Doku.Size = New System.Drawing.Size(55, 22)
        Me.L_Aaliyah_Doku.TabIndex = 0
        Me.L_Aaliyah_Doku.Text = "Doku"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 650)
        Me.Controls.Add(Me.CB_name)
        Me.Controls.Add(Me.Splitcontaineraaliyah)
        Me.Name = "Form1"
        Me.Text = "Start"
        Me.Splitcontaineraaliyah.Panel1.ResumeLayout(False)
        Me.Splitcontaineraaliyah.Panel2.ResumeLayout(False)
        CType(Me.Splitcontaineraaliyah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitcontaineraaliyah.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.P_Aaliyah_Stammdaten.ResumeLayout(False)
        Me.P_Aaliyah_Stammdaten.PerformLayout()
        Me.P_Aaliyah_Kontakte.ResumeLayout(False)
        Me.P_Aaliyah_Kontakte.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.P_Aaliyah_Eltern.ResumeLayout(False)
        Me.P_Aaliyah_Eltern.PerformLayout()
        Me.P_Aaliyah_Schule.ResumeLayout(False)
        Me.P_Aaliyah_Schule.PerformLayout()
        Me.P_Aaliyah_Hilfen.ResumeLayout(False)
        Me.P_Aaliyah_Hilfen.PerformLayout()
        Me.P_Aaliyah_Krankenhaus.ResumeLayout(False)
        Me.P_Aaliyah_Krankenhaus.PerformLayout()
        Me.P_Aaliyah_Psycho.ResumeLayout(False)
        Me.P_Aaliyah_Psycho.PerformLayout()
        Me.P_Aaliyah_Kinderarzt.ResumeLayout(False)
        Me.P_Aaliyah_Kinderarzt.PerformLayout()
        Me.P_Aaliyah_Zahnarzt.ResumeLayout(False)
        Me.P_Aaliyah_Zahnarzt.PerformLayout()
        Me.P_Aaliyah_HNO.ResumeLayout(False)
        Me.P_Aaliyah_HNO.PerformLayout()
        Me.P_Aaliyah_Augenarzt.ResumeLayout(False)
        Me.P_Aaliyah_Augenarzt.PerformLayout()
        Me.P_Aaliyah_Hautarzt.ResumeLayout(False)
        Me.P_Aaliyah_Hautarzt.PerformLayout()
        Me.P_Aaliyah_Hobby.ResumeLayout(False)
        Me.P_Aaliyah_Hobby.PerformLayout()
        Me.P_Aaliyah_Frauenarzt.ResumeLayout(False)
        Me.P_Aaliyah_Frauenarzt.PerformLayout()
        Me.P_Aaliyah_Doku.ResumeLayout(False)
        Me.P_Aaliyah_Doku.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Splitcontaineraaliyah As SplitContainer
    Friend WithEvents Panel15 As Panel
    Friend WithEvents CB_name As ComboBox

    Friend WithEvents P_Aaliyah_Stammdaten As Panel
    Friend WithEvents L_Stammdaten As Label
    Friend WithEvents P_Aaliyah_Kontakte As Panel
    Friend WithEvents P_Aaliyah_Hilfen As Panel
    Friend WithEvents P_Aaliyah_Eltern As Panel
    Friend WithEvents P_Aaliyah_Doku As Panel
    Friend WithEvents P_Aaliyah_Psycho As Panel
    Friend WithEvents P_Aaliyah_Kinderarzt As Panel
    Friend WithEvents P_Aaliyah_Zahnarzt As Panel
    Friend WithEvents P_Aaliyah_HNO As Panel
    Friend WithEvents P_Aaliyah_Augenarzt As Panel
    Friend WithEvents P_Aaliyah_Hautarzt As Panel
    Friend WithEvents P_Aaliyah_Krankenhaus As Panel
    Friend WithEvents P_Aaliyah_Frauenarzt As Panel
    Friend WithEvents P_Aaliyah_Hobby As Panel
    Friend WithEvents L_Aaliyah_Kontakte As Label
    Friend WithEvents L_Aaliyah_Hilfen As Label
    Friend WithEvents L_Aaliyah_Hautarzt As Label
    Friend WithEvents L_Aaliyah_Augenarzt As Label
    Friend WithEvents L_Aaliyah_HNO As Label
    Friend WithEvents L_Aaliyah_Zahnarzt As Label
    Friend WithEvents L_Aaliyah_KInderarzt As Label
    Friend WithEvents L_Aaliyah_Psycho As Label
    Friend WithEvents L_Aaliyah_Doku As Label
    Friend WithEvents L_Aaliyah_Elternkontakte As Label
    Friend WithEvents L_Aaliyah_Krankenhaus As Label
    Friend WithEvents L_Aaliyah_Hobby As Label
    Friend WithEvents L_Aaliyah_Frauenarzt As Label

    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBoxdoku As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RichTextBox7 As RichTextBox
    Friend WithEvents RichTextBox6 As RichTextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RichTextBox9 As RichTextBox
    Friend WithEvents RichTextBox8 As RichTextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RichTextBox11 As RichTextBox
    Friend WithEvents RichTextBox10 As RichTextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RichTextBox13 As RichTextBox
    Friend WithEvents RichTextBox12 As RichTextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents RichTextBox15 As RichTextBox
    Friend WithEvents RichTextBox14 As RichTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents RichTextBox17 As RichTextBox
    Friend WithEvents RichTextBox18 As RichTextBox
    Friend WithEvents RichTextBox16 As RichTextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents RichTextBox20 As RichTextBox
    Friend WithEvents RichTextBox19 As RichTextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents RichTextBox22 As RichTextBox
    Friend WithEvents RichTextBox21 As RichTextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents P_Aaliyah_Schule As Panel
    Friend WithEvents RichTextBox25 As RichTextBox
    Friend WithEvents RichTextBox24 As RichTextBox
    Friend WithEvents RichTextBox23 As RichTextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents TextBox31 As TextBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents TextBox30 As TextBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents TextBox29 As TextBox
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents TextBox34 As TextBox
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents TextBox22 As TextBox
End Class
