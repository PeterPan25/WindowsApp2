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
        Me.components = New System.ComponentModel.Container()
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
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Psycho")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.AugenarztDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AugenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AugenarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.AugenarztTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.Splitcontainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitcontainer2.Panel1.SuspendLayout()
        Me.Splitcontainer2.Panel2.SuspendLayout()
        Me.Splitcontainer2.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AugenarztDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AugenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
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
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AugenarztDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitcontainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1127, 650)
        Me.SplitContainer1.SplitterDistance = 156
        Me.SplitContainer1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(278, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'AugenarztDataGridView
        '
        Me.AugenarztDataGridView.AutoGenerateColumns = False
        Me.AugenarztDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AugenarztDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.AugenarztDataGridView.DataSource = Me.AugenarztBindingSource
        Me.AugenarztDataGridView.Location = New System.Drawing.Point(100, 97)
        Me.AugenarztDataGridView.Name = "AugenarztDataGridView"
        Me.AugenarztDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.AugenarztDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "A_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "A_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ort"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ort"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Plz"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Plz"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Strasse"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Strasse"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'AugenarztBindingSource
        '
        Me.AugenarztBindingSource.DataMember = "Augenarzt"
        Me.AugenarztBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(862, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AugenarztTableAdapter
        '
        Me.AugenarztTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AugenarztTableAdapter = Me.AugenarztTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FrauenarztTableAdapter = Nothing
        Me.TableAdapterManager.HautarztTableAdapter = Nothing
        Me.TableAdapterManager.HilfenTableAdapter = Nothing
        Me.TableAdapterManager.HNOTableAdapter = Nothing
        Me.TableAdapterManager.HobbyTableAdapter = Nothing
        Me.TableAdapterManager.KinderarztTableAdapter = Nothing
        Me.TableAdapterManager.KindTableAdapter = Nothing
        Me.TableAdapterManager.KrankenhausTableAdapter = Nothing
        Me.TableAdapterManager.MitarbeiterTableAdapter = Nothing
        Me.TableAdapterManager.PsychoTableAdapter = Nothing
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Nothing
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.AugenarztBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1127, 25)
        Me.BindingNavigator1.TabIndex = 10
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuelle Position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 650)
        Me.Controls.Add(Me.BindingNavigator1)
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
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AugenarztDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AugenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents AugenarztBindingSource As BindingSource
    Friend WithEvents AugenarztTableAdapter As DataSet1TableAdapters.AugenarztTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AugenarztBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AugenarztBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents AugenarztDataGridView As DataGridView
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
