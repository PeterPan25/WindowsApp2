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
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Übersicht")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("hinzufügen")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("bearbeiten")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kinder", New System.Windows.Forms.TreeNode() {TreeNode54, TreeNode55})
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Verwaltung")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Benutzer", New System.Windows.Forms.TreeNode() {TreeNode57})
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mitarbeiter")
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arzt Übersicht")
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Krankenhaus")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arzt anlegen")
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ärzte", New System.Windows.Forms.TreeNode() {TreeNode60, TreeNode61, TreeNode62})
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("admin", New System.Windows.Forms.TreeNode() {TreeNode56, TreeNode58, TreeNode59, TreeNode63})
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tagesbericht")
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stammdaten")
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kontakte")
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("allgemeine Daten", New System.Windows.Forms.TreeNode() {TreeNode66, TreeNode67})
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hilfen")
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doku")
        Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Schule")
        Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Psycho")
        Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eltern")
        Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Berichte")
        Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arztbericht anlegen")
        Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arztberichte", New System.Windows.Forms.TreeNode() {TreeNode74, TreeNode75})
        Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hobby")
        Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Formulare")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Splitcontainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CB_name = New System.Windows.Forms.ComboBox()
        Me.KindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New WindowsApp2.DataSet1()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.KindTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Übersicht1 = New WindowsApp2.Übersicht()
        Me.BerichtAnlegen1 = New WindowsApp2.BerichtAnlegen()
        Me.Benutzer1 = New WindowsApp2.Benutzer()
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
        Me.Mitarbeiter1 = New WindowsApp2.Mitarbeiter()
        CType(Me.Splitcontainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitcontainer2.Panel1.SuspendLayout()
        Me.Splitcontainer2.Panel2.SuspendLayout()
        Me.Splitcontainer2.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        Me.Splitcontainer2.Panel2.Controls.Add(Me.Panel1)
        Me.Splitcontainer2.Size = New System.Drawing.Size(1484, 573)
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
        Me.Panel15.Size = New System.Drawing.Size(145, 573)
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
        TreeNode53.Name = "Knoten40"
        TreeNode53.Text = "Übersicht"
        TreeNode53.ToolTipText = "Startseite"
        TreeNode54.Name = "Knoten31"
        TreeNode54.Text = "hinzufügen"
        TreeNode55.Name = "Knoten32"
        TreeNode55.Text = "bearbeiten"
        TreeNode56.Name = "Knoten29"
        TreeNode56.Text = "Kinder"
        TreeNode57.Name = "Knoten34"
        TreeNode57.Text = "Verwaltung"
        TreeNode58.Name = "Knoten30"
        TreeNode58.Text = "Benutzer"
        TreeNode59.Name = "Knoten1"
        TreeNode59.Text = "Mitarbeiter"
        TreeNode60.Name = "Knoten16"
        TreeNode60.Text = "Arzt Übersicht"
        TreeNode61.Name = "Knoten19"
        TreeNode61.Text = "Krankenhaus"
        TreeNode62.Name = "Knoten20"
        TreeNode62.Text = "Arzt anlegen"
        TreeNode63.Name = "Knoten33"
        TreeNode63.Text = "Ärzte"
        TreeNode64.Checked = True
        TreeNode64.Name = "Knoten27"
        TreeNode64.Text = "admin"
        TreeNode65.Checked = True
        TreeNode65.Name = "Knoten28"
        TreeNode65.Text = "Tagesbericht"
        TreeNode66.Name = "Knoten10"
        TreeNode66.Text = "Stammdaten"
        TreeNode67.Name = "Knoten11"
        TreeNode67.Text = "Kontakte"
        TreeNode68.Name = "Knoten9"
        TreeNode68.Text = "allgemeine Daten"
        TreeNode69.Name = "Knoten2"
        TreeNode69.Text = "Hilfen"
        TreeNode70.Name = "Knoten6"
        TreeNode70.Text = "Doku"
        TreeNode71.Name = "Knoten3"
        TreeNode71.Text = "Schule"
        TreeNode72.Name = "Knoten4"
        TreeNode72.Text = "Psycho"
        TreeNode73.Name = "Knoten5"
        TreeNode73.Text = "Eltern"
        TreeNode74.Name = ""
        TreeNode74.Text = "Berichte"
        TreeNode75.Name = "Knoten32"
        TreeNode75.Text = "Arztbericht anlegen"
        TreeNode76.Name = "Knoten8"
        TreeNode76.Text = "Arztberichte"
        TreeNode77.Name = "Knoten7"
        TreeNode77.Text = "Hobby"
        TreeNode78.Name = "Knoten0"
        TreeNode78.Text = "Formulare"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode53, TreeNode64, TreeNode65, TreeNode68, TreeNode69, TreeNode70, TreeNode71, TreeNode72, TreeNode73, TreeNode76, TreeNode77, TreeNode78})
        Me.TreeView1.Size = New System.Drawing.Size(145, 573)
        Me.TreeView1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Übersicht1)
        Me.Panel1.Controls.Add(Me.BerichtAnlegen1)
        Me.Panel1.Controls.Add(Me.Benutzer1)
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
        Me.Panel1.Controls.Add(Me.Mitarbeiter1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1335, 573)
        Me.Panel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 114)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 113)
        Me.TextBox1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1340, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 152)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'CB_name
        '
        Me.CB_name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CB_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KindBindingSource, "Name", True))
        Me.CB_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_name.FormattingEnabled = True
        Me.CB_name.Location = New System.Drawing.Point(1048, 53)
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
        'LogoutButton
        '
        Me.LogoutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutButton.AutoSize = True
        Me.LogoutButton.Location = New System.Drawing.Point(16, 56)
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
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CB_name)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LogoutButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitcontainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1484, 812)
        Me.SplitContainer1.SplitterDistance = 235
        Me.SplitContainer1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1196, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1071, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1196, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1071, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1196, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1071, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(16, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Nachricht"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(183, 65)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(444, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(349, 118)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(582, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(440, 179)
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
        Me.TableAdapterManager.SchulDatenTableAdapter = Nothing
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Nothing
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1484, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Abmelden"
        '
        'Übersicht1
        '
        Me.Übersicht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Übersicht1.Location = New System.Drawing.Point(0, 0)
        Me.Übersicht1.Name = "Übersicht1"
        Me.Übersicht1.Size = New System.Drawing.Size(1335, 573)
        Me.Übersicht1.TabIndex = 26
        Me.Übersicht1.Visible = False
        '
        'BerichtAnlegen1
        '
        Me.BerichtAnlegen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BerichtAnlegen1.Location = New System.Drawing.Point(0, 0)
        Me.BerichtAnlegen1.Name = "BerichtAnlegen1"
        Me.BerichtAnlegen1.Size = New System.Drawing.Size(1335, 573)
        Me.BerichtAnlegen1.TabIndex = 25
        Me.BerichtAnlegen1.Visible = False
        '
        'Benutzer1
        '
        Me.Benutzer1.Location = New System.Drawing.Point(38, 3)
        Me.Benutzer1.Name = "Benutzer1"
        Me.Benutzer1.Size = New System.Drawing.Size(875, 532)
        Me.Benutzer1.TabIndex = 27
        Me.Benutzer1.Visible = False
        '
        'KindBearbeiten1
        '
        Me.KindBearbeiten1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KindBearbeiten1.Location = New System.Drawing.Point(0, 0)
        Me.KindBearbeiten1.Name = "KindBearbeiten1"
        Me.KindBearbeiten1.Size = New System.Drawing.Size(1335, 573)
        Me.KindBearbeiten1.TabIndex = 24
        Me.KindBearbeiten1.Visible = False
        '
        'KindHinzufuegen1
        '
        Me.KindHinzufuegen1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.KindHinzufuegen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KindHinzufuegen1.Location = New System.Drawing.Point(0, 0)
        Me.KindHinzufuegen1.Name = "KindHinzufuegen1"
        Me.KindHinzufuegen1.Size = New System.Drawing.Size(1335, 573)
        Me.KindHinzufuegen1.TabIndex = 23
        Me.KindHinzufuegen1.Visible = False
        '
        'ArztUebersicht1
        '
        Me.ArztUebersicht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArztUebersicht1.Location = New System.Drawing.Point(0, 0)
        Me.ArztUebersicht1.Name = "ArztUebersicht1"
        Me.ArztUebersicht1.Size = New System.Drawing.Size(1335, 573)
        Me.ArztUebersicht1.TabIndex = 22
        Me.ArztUebersicht1.Visible = False
        '
        'ArztAnlegen1
        '
        Me.ArztAnlegen1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ArztAnlegen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArztAnlegen1.Location = New System.Drawing.Point(0, 0)
        Me.ArztAnlegen1.Name = "ArztAnlegen1"
        Me.ArztAnlegen1.Size = New System.Drawing.Size(1335, 573)
        Me.ArztAnlegen1.TabIndex = 21
        Me.ArztAnlegen1.Visible = False
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UserControl11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControl11.Location = New System.Drawing.Point(0, 0)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(1335, 573)
        Me.UserControl11.TabIndex = 10
        '
        'Bericht1
        '
        Me.Bericht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bericht1.Location = New System.Drawing.Point(0, 0)
        Me.Bericht1.Name = "Bericht1"
        Me.Bericht1.Size = New System.Drawing.Size(1335, 573)
        Me.Bericht1.TabIndex = 19
        Me.Bericht1.Visible = False
        '
        'Arztbericht1
        '
        Me.Arztbericht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Arztbericht1.Location = New System.Drawing.Point(0, 0)
        Me.Arztbericht1.Name = "Arztbericht1"
        Me.Arztbericht1.Size = New System.Drawing.Size(1335, 573)
        Me.Arztbericht1.TabIndex = 20
        Me.Arztbericht1.Visible = False
        '
        'Tagesbericht1
        '
        Me.Tagesbericht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tagesbericht1.Location = New System.Drawing.Point(0, 0)
        Me.Tagesbericht1.Name = "Tagesbericht1"
        Me.Tagesbericht1.Size = New System.Drawing.Size(1335, 573)
        Me.Tagesbericht1.TabIndex = 17
        Me.Tagesbericht1.Visible = False
        '
        'Formulare1
        '
        Me.Formulare1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Formulare1.Location = New System.Drawing.Point(0, 0)
        Me.Formulare1.Name = "Formulare1"
        Me.Formulare1.Size = New System.Drawing.Size(1335, 573)
        Me.Formulare1.TabIndex = 18
        Me.Formulare1.Visible = False
        '
        'Psycho1
        '
        Me.Psycho1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Psycho1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Psycho1.Location = New System.Drawing.Point(0, 0)
        Me.Psycho1.Name = "Psycho1"
        Me.Psycho1.Size = New System.Drawing.Size(1335, 573)
        Me.Psycho1.TabIndex = 16
        Me.Psycho1.Visible = False
        '
        'Stammdaten1
        '
        Me.Stammdaten1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Stammdaten1.Location = New System.Drawing.Point(0, 0)
        Me.Stammdaten1.Name = "Stammdaten1"
        Me.Stammdaten1.Size = New System.Drawing.Size(1335, 573)
        Me.Stammdaten1.TabIndex = 14
        Me.Stammdaten1.Visible = False
        '
        'Schule1
        '
        Me.Schule1.AutoSize = True
        Me.Schule1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Schule1.Location = New System.Drawing.Point(0, 0)
        Me.Schule1.Name = "Schule1"
        Me.Schule1.Size = New System.Drawing.Size(1335, 573)
        Me.Schule1.TabIndex = 13
        Me.Schule1.Visible = False
        '
        'Krankenhaus1
        '
        Me.Krankenhaus1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Krankenhaus1.Location = New System.Drawing.Point(0, 0)
        Me.Krankenhaus1.Name = "Krankenhaus1"
        Me.Krankenhaus1.Size = New System.Drawing.Size(1335, 573)
        Me.Krankenhaus1.TabIndex = 12
        Me.Krankenhaus1.Visible = False
        '
        'Kontakte1
        '
        Me.Kontakte1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Kontakte1.Location = New System.Drawing.Point(0, 0)
        Me.Kontakte1.Name = "Kontakte1"
        Me.Kontakte1.Size = New System.Drawing.Size(1335, 573)
        Me.Kontakte1.TabIndex = 11
        Me.Kontakte1.Visible = False
        '
        'Hobby1
        '
        Me.Hobby1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hobby1.Location = New System.Drawing.Point(0, 0)
        Me.Hobby1.Name = "Hobby1"
        Me.Hobby1.Size = New System.Drawing.Size(1335, 573)
        Me.Hobby1.TabIndex = 9
        Me.Hobby1.Visible = False
        '
        'Hilfen1
        '
        Me.Hilfen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hilfen1.Location = New System.Drawing.Point(0, 0)
        Me.Hilfen1.Name = "Hilfen1"
        Me.Hilfen1.Size = New System.Drawing.Size(1335, 573)
        Me.Hilfen1.TabIndex = 7
        Me.Hilfen1.Visible = False
        '
        'Eltern1
        '
        Me.Eltern1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Eltern1.Location = New System.Drawing.Point(0, 0)
        Me.Eltern1.Name = "Eltern1"
        Me.Eltern1.Size = New System.Drawing.Size(1335, 573)
        Me.Eltern1.TabIndex = 3
        Me.Eltern1.Visible = False
        '
        'Doku1
        '
        Me.Doku1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Doku1.Location = New System.Drawing.Point(0, 0)
        Me.Doku1.Name = "Doku1"
        Me.Doku1.Size = New System.Drawing.Size(1335, 573)
        Me.Doku1.TabIndex = 2
        Me.Doku1.Visible = False
        '
        'Mitarbeiter1
        '
        Me.Mitarbeiter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mitarbeiter1.Location = New System.Drawing.Point(0, 0)
        Me.Mitarbeiter1.Name = "Mitarbeiter1"
        Me.Mitarbeiter1.Size = New System.Drawing.Size(1335, 573)
        Me.Mitarbeiter1.TabIndex = 20
        Me.Mitarbeiter1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1484, 812)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "InariHof Doku"
        Me.Splitcontainer2.Panel1.ResumeLayout(False)
        Me.Splitcontainer2.Panel2.ResumeLayout(False)
        CType(Me.Splitcontainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitcontainer2.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Splitcontainer2 As SplitContainer
    Friend WithEvents Panel15 As Panel
    Friend WithEvents CB_name As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TreeView1 As TreeView
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
    Friend WithEvents Mitarbeiter1 As Mitarbeiter

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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Übersicht1 As Übersicht
    Friend WithEvents Benutzer1 As Benutzer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
