﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Übersicht")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("hinzufügen")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("bearbeiten")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("entfernen")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kinder", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("hinzufügen")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("bearbeiten")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("entfernen")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Benutzer", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mitarbeiter")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arzt Übersicht")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Krankenhaus")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arzt anlegen")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ärzte", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("admin", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode9, TreeNode10, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tagesbericht")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stammdaten")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kontakte")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("allgemeine Daten", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hilfen")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doku")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Schule")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Psycho")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eltern")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Berichte")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arztbericht anlegen")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arztberichte", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hobby")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Formulare")
        Me.Splitcontainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CB_name = New System.Windows.Forms.ComboBox()
        Me.KindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New WindowsApp2.DataSet1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Übersicht1 = New WindowsApp2.Übersicht()
        Me.BerichtAnlegen1 = New WindowsApp2.BerichtAnlegen()
        Me.KindBearbeiten1 = New WindowsApp2.KindBearbeiten()
        Me.KindHinzufuegen1 = New WindowsApp2.KindHinzufuegen()
        Me.ArztUebersicht1 = New WindowsApp2.ArztUebersicht()
        Me.ArztAnlegen1 = New WindowsApp2.ArztAnlegen()
        Me.UserControl11 = New WindowsApp2.UserControl1()
        Me.Bericht1 = New WindowsApp2.Bericht()
        Me.Arztbericht1 = New WindowsApp2.Arztbericht()
        Me.Tagesbericht1 = New WindowsApp2.Tagesbericht()
        Me.Formulare1 = New WindowsApp2.Formulare()
        Me.Psycho1 = New WindowsApp2.Psycho()
        Me.Stammdaten1 = New WindowsApp2.Stammdaten()
        Me.Schule1 = New WindowsApp2.Schule()
        Me.Krankenhaus1 = New WindowsApp2.Krankenhaus()
        Me.Kontakte1 = New WindowsApp2.Kontakte()
        Me.Hobby1 = New WindowsApp2.Hobby()
        Me.Hilfen1 = New WindowsApp2.Hilfen()
        Me.Eltern1 = New WindowsApp2.Eltern()
        Me.Doku1 = New WindowsApp2.Doku()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.KindTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        CType(Me.Splitcontainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitcontainer2.Panel1.SuspendLayout()
        Me.Splitcontainer2.Panel2.SuspendLayout()
        Me.Splitcontainer2.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitcontainer2
        '
        Me.Splitcontainer2.BackColor = System.Drawing.SystemColors.Control
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
        Me.Splitcontainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.Splitcontainer2.Size = New System.Drawing.Size(1484, 632)
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
        Me.Panel15.Size = New System.Drawing.Size(145, 632)
        Me.Panel15.TabIndex = 7
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.RoyalBlue
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.SystemColors.Menu
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.LineColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Knoten40"
        TreeNode1.Text = "Übersicht"
        TreeNode1.ToolTipText = "Startseite"
        TreeNode2.Name = "Knoten31"
        TreeNode2.Text = "hinzufügen"
        TreeNode3.Name = "Knoten32"
        TreeNode3.Text = "bearbeiten"
        TreeNode4.Name = "Knoten33"
        TreeNode4.Text = "entfernen"
        TreeNode5.Name = "Knoten29"
        TreeNode5.Text = "Kinder"
        TreeNode6.Name = "Knoten34"
        TreeNode6.Text = "hinzufügen"
        TreeNode7.Name = "Knoten35"
        TreeNode7.Text = "bearbeiten"
        TreeNode8.Name = "Knoten36"
        TreeNode8.Text = "entfernen"
        TreeNode9.Name = "Knoten30"
        TreeNode9.Text = "Benutzer"
        TreeNode10.Name = "Knoten1"
        TreeNode10.Text = "Mitarbeiter"
        TreeNode11.Name = "Knoten16"
        TreeNode11.Text = "Arzt Übersicht"
        TreeNode12.Name = "Knoten19"
        TreeNode12.Text = "Krankenhaus"
        TreeNode13.Name = "Knoten20"
        TreeNode13.Text = "Arzt anlegen"
        TreeNode14.Name = "Knoten33"
        TreeNode14.Text = "Ärzte"
        TreeNode15.Checked = True
        TreeNode15.Name = "Knoten27"
        TreeNode15.Text = "admin"
        TreeNode16.Checked = True
        TreeNode16.Name = "Knoten28"
        TreeNode16.Text = "Tagesbericht"
        TreeNode17.Name = "Knoten10"
        TreeNode17.Text = "Stammdaten"
        TreeNode18.Name = "Knoten11"
        TreeNode18.Text = "Kontakte"
        TreeNode19.Name = "Knoten9"
        TreeNode19.Text = "allgemeine Daten"
        TreeNode20.Name = "Knoten2"
        TreeNode20.Text = "Hilfen"
        TreeNode21.Name = "Knoten6"
        TreeNode21.Text = "Doku"
        TreeNode22.Name = "Knoten3"
        TreeNode22.Text = "Schule"
        TreeNode23.Name = "Knoten4"
        TreeNode23.Text = "Psycho"
        TreeNode24.Name = "Knoten5"
        TreeNode24.Text = "Eltern"
        TreeNode25.Name = ""
        TreeNode25.Text = "Berichte"
        TreeNode26.Name = "Knoten32"
        TreeNode26.Text = "Arztbericht anlegen"
        TreeNode27.Name = "Knoten8"
        TreeNode27.Text = "Arztberichte"
        TreeNode28.Name = "Knoten7"
        TreeNode28.Text = "Hobby"
        TreeNode29.Name = "Knoten0"
        TreeNode29.Text = "Formulare"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode15, TreeNode16, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode27, TreeNode28, TreeNode29})
        Me.TreeView1.Size = New System.Drawing.Size(145, 632)
        Me.TreeView1.TabIndex = 1
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.CB_name)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer3.Size = New System.Drawing.Size(1335, 632)
        Me.SplitContainer3.SplitterDistance = 175
        Me.SplitContainer3.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(320, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Label6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(320, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Label6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1041, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hinweis"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1044, 50)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 113)
        Me.TextBox1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Aufnahme"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Jugendamt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Sorgerecht"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Geburtsdatum"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(38, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 108)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'CB_name
        '
        Me.CB_name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CB_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KindBindingSource, "Name", True))
        Me.CB_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_name.FormattingEnabled = True
        Me.CB_name.Location = New System.Drawing.Point(492, 77)
        Me.CB_name.Name = "CB_name"
        Me.CB_name.Size = New System.Drawing.Size(262, 21)
        Me.CB_name.TabIndex = 8
        '
        'KindBindingSource
        '
        Me.KindBindingSource.DataMember = "Kind"
        Me.KindBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Übersicht1)
        Me.Panel1.Controls.Add(Me.BerichtAnlegen1)
        Me.Panel1.Controls.Add(Me.KindBearbeiten1)
        Me.Panel1.Controls.Add(Me.KindHinzufuegen1)
        Me.Panel1.Controls.Add(Me.ArztUebersicht1)
        Me.Panel1.Controls.Add(Me.ArztAnlegen1)
        Me.Panel1.Controls.Add(Me.UserControl11)
        Me.Panel1.Controls.Add(Me.Bericht1)
        Me.Panel1.Controls.Add(Me.Arztbericht1)
        Me.Panel1.Controls.Add(Me.Tagesbericht1)
        Me.Panel1.Controls.Add(Me.Formulare1)
        Me.Panel1.Controls.Add(Me.Psycho1)
        Me.Panel1.Controls.Add(Me.Stammdaten1)
        Me.Panel1.Controls.Add(Me.Schule1)
        Me.Panel1.Controls.Add(Me.Krankenhaus1)
        Me.Panel1.Controls.Add(Me.Kontakte1)
        Me.Panel1.Controls.Add(Me.Hobby1)
        Me.Panel1.Controls.Add(Me.Hilfen1)
        Me.Panel1.Controls.Add(Me.Eltern1)
        Me.Panel1.Controls.Add(Me.Doku1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1335, 453)
        Me.Panel1.TabIndex = 0
        '
        'Übersicht1
        '
        Me.Übersicht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Übersicht1.Location = New System.Drawing.Point(0, 0)
        Me.Übersicht1.Name = "Übersicht1"
        Me.Übersicht1.Size = New System.Drawing.Size(1335, 453)
        Me.Übersicht1.TabIndex = 26
        Me.Übersicht1.Visible = False
        '
        'BerichtAnlegen1
        '
        Me.BerichtAnlegen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BerichtAnlegen1.Location = New System.Drawing.Point(0, 0)
        Me.BerichtAnlegen1.Name = "BerichtAnlegen1"
        Me.BerichtAnlegen1.Size = New System.Drawing.Size(1335, 453)
        Me.BerichtAnlegen1.TabIndex = 25
        Me.BerichtAnlegen1.Visible = False
        '
        'KindBearbeiten1
        '
        Me.KindBearbeiten1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KindBearbeiten1.Location = New System.Drawing.Point(0, 0)
        Me.KindBearbeiten1.Name = "KindBearbeiten1"
        Me.KindBearbeiten1.Size = New System.Drawing.Size(1335, 453)
        Me.KindBearbeiten1.TabIndex = 24
        Me.KindBearbeiten1.Visible = False
        '
        'KindHinzufuegen1
        '
        Me.KindHinzufuegen1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.KindHinzufuegen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KindHinzufuegen1.Location = New System.Drawing.Point(0, 0)
        Me.KindHinzufuegen1.Name = "KindHinzufuegen1"
        Me.KindHinzufuegen1.Size = New System.Drawing.Size(1335, 453)
        Me.KindHinzufuegen1.TabIndex = 23
        Me.KindHinzufuegen1.Visible = False
        '
        'ArztUebersicht1
        '
        Me.ArztUebersicht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArztUebersicht1.Location = New System.Drawing.Point(0, 0)
        Me.ArztUebersicht1.Name = "ArztUebersicht1"
        Me.ArztUebersicht1.Size = New System.Drawing.Size(1335, 453)
        Me.ArztUebersicht1.TabIndex = 22
        Me.ArztUebersicht1.Visible = False
        '
        'ArztAnlegen1
        '
        Me.ArztAnlegen1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ArztAnlegen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArztAnlegen1.Location = New System.Drawing.Point(0, 0)
        Me.ArztAnlegen1.Name = "ArztAnlegen1"
        Me.ArztAnlegen1.Size = New System.Drawing.Size(1335, 453)
        Me.ArztAnlegen1.TabIndex = 21
        Me.ArztAnlegen1.Visible = False
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UserControl11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControl11.Location = New System.Drawing.Point(0, 0)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(1335, 453)
        Me.UserControl11.TabIndex = 10
        '
        'Bericht1
        '
        Me.Bericht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bericht1.Location = New System.Drawing.Point(0, 0)
        Me.Bericht1.Name = "Bericht1"
        Me.Bericht1.Size = New System.Drawing.Size(1335, 453)
        Me.Bericht1.TabIndex = 19
        Me.Bericht1.Visible = False
        '
        'Arztbericht1
        '
        Me.Arztbericht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Arztbericht1.Location = New System.Drawing.Point(0, 0)
        Me.Arztbericht1.Name = "Arztbericht1"
        Me.Arztbericht1.Size = New System.Drawing.Size(1335, 453)
        Me.Arztbericht1.TabIndex = 20
        Me.Arztbericht1.Visible = False
        '
        'Tagesbericht1
        '
        Me.Tagesbericht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tagesbericht1.Location = New System.Drawing.Point(0, 0)
        Me.Tagesbericht1.Name = "Tagesbericht1"
        Me.Tagesbericht1.Size = New System.Drawing.Size(1335, 453)
        Me.Tagesbericht1.TabIndex = 17
        Me.Tagesbericht1.Visible = False
        '
        'Formulare1
        '
        Me.Formulare1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Formulare1.Location = New System.Drawing.Point(0, 0)
        Me.Formulare1.Name = "Formulare1"
        Me.Formulare1.Size = New System.Drawing.Size(1335, 453)
        Me.Formulare1.TabIndex = 18
        Me.Formulare1.Visible = False
        '
        'Psycho1
        '
        Me.Psycho1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Psycho1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Psycho1.Location = New System.Drawing.Point(0, 0)
        Me.Psycho1.Name = "Psycho1"
        Me.Psycho1.Size = New System.Drawing.Size(1335, 453)
        Me.Psycho1.TabIndex = 16
        Me.Psycho1.Visible = False
        '
        'Stammdaten1
        '
        Me.Stammdaten1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Stammdaten1.Location = New System.Drawing.Point(0, 0)
        Me.Stammdaten1.Name = "Stammdaten1"
        Me.Stammdaten1.Size = New System.Drawing.Size(1335, 453)
        Me.Stammdaten1.TabIndex = 14
        Me.Stammdaten1.Visible = False
        '
        'Schule1
        '
        Me.Schule1.AutoSize = True
        Me.Schule1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Schule1.Location = New System.Drawing.Point(0, 0)
        Me.Schule1.Name = "Schule1"
        Me.Schule1.Size = New System.Drawing.Size(1335, 453)
        Me.Schule1.TabIndex = 13
        Me.Schule1.Visible = False
        '
        'Krankenhaus1
        '
        Me.Krankenhaus1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Krankenhaus1.Location = New System.Drawing.Point(0, 0)
        Me.Krankenhaus1.Name = "Krankenhaus1"
        Me.Krankenhaus1.Size = New System.Drawing.Size(1335, 453)
        Me.Krankenhaus1.TabIndex = 12
        Me.Krankenhaus1.Visible = False
        '
        'Kontakte1
        '
        Me.Kontakte1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Kontakte1.Location = New System.Drawing.Point(0, 0)
        Me.Kontakte1.Name = "Kontakte1"
        Me.Kontakte1.Size = New System.Drawing.Size(1335, 453)
        Me.Kontakte1.TabIndex = 11
        Me.Kontakte1.Visible = False
        '
        'Hobby1
        '
        Me.Hobby1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hobby1.Location = New System.Drawing.Point(0, 0)
        Me.Hobby1.Name = "Hobby1"
        Me.Hobby1.Size = New System.Drawing.Size(1335, 453)
        Me.Hobby1.TabIndex = 9
        Me.Hobby1.Visible = False
        '
        'Hilfen1
        '
        Me.Hilfen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hilfen1.Location = New System.Drawing.Point(0, 0)
        Me.Hilfen1.Name = "Hilfen1"
        Me.Hilfen1.Size = New System.Drawing.Size(1335, 453)
        Me.Hilfen1.TabIndex = 7
        Me.Hilfen1.Visible = False
        '
        'Eltern1
        '
        Me.Eltern1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Eltern1.Location = New System.Drawing.Point(0, 0)
        Me.Eltern1.Name = "Eltern1"
        Me.Eltern1.Size = New System.Drawing.Size(1335, 453)
        Me.Eltern1.TabIndex = 3
        Me.Eltern1.Visible = False
        '
        'Doku1
        '
        Me.Doku1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Doku1.Location = New System.Drawing.Point(0, 0)
        Me.Doku1.Name = "Doku1"
        Me.Doku1.Size = New System.Drawing.Size(1335, 453)
        Me.Doku1.TabIndex = 2
        Me.Doku1.Visible = False
        '
        'LogoutButton
        '
        Me.LogoutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutButton.AutoSize = True
        Me.LogoutButton.Location = New System.Drawing.Point(1112, 51)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 14
        Me.LogoutButton.Text = "Abmelden"
        Me.LogoutButton.UseVisualStyleBackColor = True
        Me.LogoutButton.Visible = False
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
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SplitContainer1.Panel1.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.Logo
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LogoutButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitcontainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1484, 812)
        Me.SplitContainer1.SplitterDistance = 176
        Me.SplitContainer1.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(1112, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Nachricht"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(176, 5)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(1388, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 118)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1208, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1074, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Eingeloggt als:"
        '
        'KindTableAdapter
        '
        Me.KindTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AugenarztTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BerichtTableAdapter = Nothing
        Me.TableAdapterManager.ElternBerichtTableAdapter = Nothing
        Me.TableAdapterManager.FrauenarztTableAdapter = Nothing
        Me.TableAdapterManager.HautarztTableAdapter = Nothing
        Me.TableAdapterManager.HilfenTableAdapter = Nothing
        Me.TableAdapterManager.HNOTableAdapter = Nothing
        Me.TableAdapterManager.HobbyTableAdapter = Nothing
        Me.TableAdapterManager.KindAugenarztTableAdapter = Nothing
        Me.TableAdapterManager.KinderarztTableAdapter = Nothing
        Me.TableAdapterManager.KindFrauenarztTableAdapter = Nothing
        Me.TableAdapterManager.KindHautarztTableAdapter = Nothing
        Me.TableAdapterManager.KindHilfenTableAdapter = Nothing
        Me.TableAdapterManager.KindHNOTableAdapter = Nothing
        Me.TableAdapterManager.KindHobbyTableAdapter = Nothing
        Me.TableAdapterManager.KindKinderarztTableAdapter = Nothing
        Me.TableAdapterManager.KindKontakteTableAdapter = Nothing
        Me.TableAdapterManager.KindKrankenhausTableAdapter = Nothing
        Me.TableAdapterManager.KindPsychoTableAdapter = Nothing
        Me.TableAdapterManager.KindSchuleTableAdapter = Nothing
        Me.TableAdapterManager.KindTableAdapter = Me.KindTableAdapter
        Me.TableAdapterManager.KindZahnarztTableAdapter = Nothing
        Me.TableAdapterManager.KontakteTableAdapter = Nothing
        Me.TableAdapterManager.KrankenhausTableAdapter = Nothing
        Me.TableAdapterManager.MitarbeiterTableAdapter = Nothing
        Me.TableAdapterManager.NachrichtTableAdapter = Nothing
        Me.TableAdapterManager.PsychoTableAdapter = Nothing
        Me.TableAdapterManager.SchulBerichtTableAdapter = Nothing
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1484, 812)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Start"
        Me.Splitcontainer2.Panel1.ResumeLayout(False)
        Me.Splitcontainer2.Panel2.ResumeLayout(False)
        CType(Me.Splitcontainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitcontainer2.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Stammdaten1 As Stammdaten
    Friend WithEvents Schule1 As Schule
    Friend WithEvents Krankenhaus1 As Krankenhaus
    Friend WithEvents Kontakte1 As Kontakte
    Friend WithEvents Hobby1 As Hobby
    Friend WithEvents Hilfen1 As Hilfen
    Friend WithEvents Eltern1 As Eltern
    Friend WithEvents Doku1 As Doku

    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents Tagesbericht1 As Tagesbericht
    Friend WithEvents Formulare1 As Formulare
    Friend WithEvents KindBindingSource As BindingSource
    Friend WithEvents KindTableAdapter As DataSet1TableAdapters.KindTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents Bericht1 As Bericht
    Friend WithEvents Arztbericht1 As Arztbericht
    Friend WithEvents ArztAnlegen1 As ArztAnlegen
    Friend WithEvents ArztUebersicht1 As ArztUebersicht
    Friend WithEvents KindHinzufuegen1 As KindHinzufuegen
    Friend WithEvents KindBearbeiten1 As KindBearbeiten
    Friend WithEvents BerichtAnlegen1 As BerichtAnlegen
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Übersicht1 As Übersicht
End Class
