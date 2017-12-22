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
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arzt Übersicht")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Krankenhaus")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arzt anlegen")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ärzte", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("admin", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8, TreeNode9, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tagesbericht")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stammdaten")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kontakte")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("allgemeine Daten", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hilfen")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doku")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Schule")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Psycho")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eltern")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Berichte")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arztbericht anlegen")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arztberichte", New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode29})
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hobby")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Formulare")
        Me.Splitcontainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CB_name = New System.Windows.Forms.ComboBox()
        Me.KindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New WindowsApp2.DataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KindTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
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
        Me.Anlegen1 = New WindowsApp2.anlegen()
        CType(Me.Splitcontainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitcontainer2.Panel1.SuspendLayout()
        Me.Splitcontainer2.Panel2.SuspendLayout()
        Me.Splitcontainer2.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.KindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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

        TreeNode14.Name = "Knoten16"
        TreeNode14.Text = "Arzt Übersicht"
        TreeNode15.Name = "Knoten19"
        TreeNode15.Text = "Krankenhaus"
        TreeNode16.Name = "Knoten20"
        TreeNode16.Text = "Arzt anlegen"
        TreeNode17.Name = "Knoten33"
        TreeNode17.Text = "Ärzte"
        TreeNode18.Name = "Knoten27"
        TreeNode18.Text = "admin"
        TreeNode19.Name = "Knoten28"
        TreeNode19.Text = "Tagesbericht"
        TreeNode20.Name = "Knoten10"
        TreeNode20.Text = "Stammdaten"
        TreeNode21.Name = "Knoten11"
        TreeNode21.Text = "Kontakte"
        TreeNode22.Name = "Knoten9"
        TreeNode22.Text = "allgemeine Daten"
        TreeNode23.Name = "Knoten2"
        TreeNode23.Text = "Hilfen"
        TreeNode24.Name = "Knoten6"
        TreeNode24.Text = "Doku"
        TreeNode25.Name = "Knoten3"
        TreeNode25.Text = "Schule"
        TreeNode26.Name = "Knoten4"
        TreeNode26.Text = "Psycho"
        TreeNode27.Name = "Knoten5"
        TreeNode27.Text = "Eltern"
        TreeNode28.Name = ""
        TreeNode28.Text = "Berichte"
        TreeNode29.Name = "Knoten32"
        TreeNode29.Text = "Arztbericht anlegen"
        TreeNode30.Name = "Knoten8"
        TreeNode30.Text = "Arztberichte"
        TreeNode31.Name = "Knoten7"
        TreeNode31.Text = "Hobby"
        TreeNode32.Name = "Knoten0"
        TreeNode32.Text = "Formulare"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode22, TreeNode23, TreeNode24, TreeNode25, TreeNode26, TreeNode27, TreeNode30, TreeNode31, TreeNode32})
        Me.TreeView1.Size = New System.Drawing.Size(145, 490)
        Me.TreeView1.TabIndex = 1
        '
        'Panel1
        '
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
        Me.Panel1.Controls.Add(Me.Anlegen1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 490)
        Me.Panel1.TabIndex = 0
        '
        'CB_name
        '
        Me.CB_name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CB_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KindBindingSource, "Name", True))
        Me.CB_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_name.FormattingEnabled = True
        Me.CB_name.Location = New System.Drawing.Point(437, 61)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CB_name)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitcontainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1127, 650)
        Me.SplitContainer1.SplitterDistance = 156
        Me.SplitContainer1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(964, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
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
        Me.TableAdapterManager.PsychoTableAdapter = Nothing
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Nothing
        '
        'ArztAnlegen1
        '
        Me.ArztAnlegen1.Location = New System.Drawing.Point(0, 0)
        Me.ArztAnlegen1.Name = "ArztAnlegen1"
        Me.ArztAnlegen1.Size = New System.Drawing.Size(978, 490)
        Me.ArztAnlegen1.TabIndex = 21
        Me.ArztAnlegen1.Visible = False
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.SystemColors.Control
        Me.UserControl11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControl11.Location = New System.Drawing.Point(0, 0)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(978, 490)
        Me.UserControl11.TabIndex = 10
        '
        'Bericht1
        '
        Me.Bericht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bericht1.Location = New System.Drawing.Point(0, 0)
        Me.Bericht1.Name = "Bericht1"
        Me.Bericht1.Size = New System.Drawing.Size(978, 490)
        Me.Bericht1.TabIndex = 19
        Me.Bericht1.Visible = False
        '
        'Arztbericht1
        '
        Me.Arztbericht1.Location = New System.Drawing.Point(0, 0)
        Me.Arztbericht1.Name = "Arztbericht1"
        Me.Arztbericht1.Size = New System.Drawing.Size(978, 490)
        Me.Arztbericht1.TabIndex = 20
        Me.Arztbericht1.Visible = False
        '
        'Tagesbericht1
        '
        Me.Tagesbericht1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tagesbericht1.Location = New System.Drawing.Point(0, 0)
        Me.Tagesbericht1.Name = "Tagesbericht1"
        Me.Tagesbericht1.Size = New System.Drawing.Size(978, 490)
        Me.Tagesbericht1.TabIndex = 17
        Me.Tagesbericht1.Visible = False
        '
        'Formulare1
        '
        Me.Formulare1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Formulare1.Location = New System.Drawing.Point(0, 0)
        Me.Formulare1.Name = "Formulare1"
        Me.Formulare1.Size = New System.Drawing.Size(978, 490)
        Me.Formulare1.TabIndex = 18
        Me.Formulare1.Visible = False
        '
        'Psycho1
        '
        Me.Psycho1.BackColor = System.Drawing.SystemColors.Control
        Me.Psycho1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Psycho1.Location = New System.Drawing.Point(0, 0)
        Me.Psycho1.Name = "Psycho1"
        Me.Psycho1.Size = New System.Drawing.Size(978, 490)
        Me.Psycho1.TabIndex = 16
        Me.Psycho1.Visible = False
        '
        'Stammdaten1
        '
        Me.Stammdaten1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Stammdaten1.Location = New System.Drawing.Point(0, 0)
        Me.Stammdaten1.Name = "Stammdaten1"
        Me.Stammdaten1.Size = New System.Drawing.Size(978, 490)
        Me.Stammdaten1.TabIndex = 14
        Me.Stammdaten1.Visible = False
        '
        'Schule1
        '
        Me.Schule1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Schule1.Location = New System.Drawing.Point(0, 0)
        Me.Schule1.Name = "Schule1"
        Me.Schule1.Size = New System.Drawing.Size(978, 490)
        Me.Schule1.TabIndex = 13
        Me.Schule1.Visible = False
        '
        'Krankenhaus1
        '
        Me.Krankenhaus1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Krankenhaus1.Location = New System.Drawing.Point(0, 0)
        Me.Krankenhaus1.Name = "Krankenhaus1"
        Me.Krankenhaus1.Size = New System.Drawing.Size(978, 490)
        Me.Krankenhaus1.TabIndex = 12
        Me.Krankenhaus1.Visible = False
        '
        'Kontakte1
        '
        Me.Kontakte1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Kontakte1.Location = New System.Drawing.Point(0, 0)
        Me.Kontakte1.Name = "Kontakte1"
        Me.Kontakte1.Size = New System.Drawing.Size(978, 490)
        Me.Kontakte1.TabIndex = 11
        Me.Kontakte1.Visible = False
        '
        'Hobby1
        '
        Me.Hobby1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hobby1.Location = New System.Drawing.Point(0, 0)
        Me.Hobby1.Name = "Hobby1"
        Me.Hobby1.Size = New System.Drawing.Size(978, 490)
        Me.Hobby1.TabIndex = 9
        Me.Hobby1.Visible = False
        '
        'Hilfen1
        '
        Me.Hilfen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hilfen1.Location = New System.Drawing.Point(0, 0)
        Me.Hilfen1.Name = "Hilfen1"
        Me.Hilfen1.Size = New System.Drawing.Size(978, 490)
        Me.Hilfen1.TabIndex = 7
        Me.Hilfen1.Visible = False
        '
        'Eltern1
        '
        Me.Eltern1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Eltern1.Location = New System.Drawing.Point(0, 0)
        Me.Eltern1.Name = "Eltern1"
        Me.Eltern1.Size = New System.Drawing.Size(978, 490)
        Me.Eltern1.TabIndex = 3
        Me.Eltern1.Visible = False
        '
        'Doku1
        '
        Me.Doku1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Doku1.Location = New System.Drawing.Point(0, 0)
        Me.Doku1.Name = "Doku1"
        Me.Doku1.Size = New System.Drawing.Size(978, 490)
        Me.Doku1.TabIndex = 2
        Me.Doku1.Visible = False
        '
        'Anlegen1
        '
        Me.Anlegen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Anlegen1.Location = New System.Drawing.Point(0, 0)
        Me.Anlegen1.Name = "Anlegen1"
        Me.Anlegen1.Size = New System.Drawing.Size(978, 490)
        Me.Anlegen1.TabIndex = 0
        Me.Anlegen1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 650)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Start"
        Me.Splitcontainer2.Panel1.ResumeLayout(False)
        Me.Splitcontainer2.Panel2.ResumeLayout(False)
        CType(Me.Splitcontainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitcontainer2.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.KindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
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
    Friend WithEvents Stammdaten1 As Stammdaten
    Friend WithEvents Schule1 As Schule
    Friend WithEvents Krankenhaus1 As Krankenhaus
    Friend WithEvents Kontakte1 As Kontakte
    Friend WithEvents Hobby1 As Hobby
    Friend WithEvents Hilfen1 As Hilfen
    Friend WithEvents Eltern1 As Eltern
    Friend WithEvents Doku1 As Doku
    Friend WithEvents Anlegen1 As anlegen
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents Tagesbericht1 As Tagesbericht
    Friend WithEvents Formulare1 As Formulare
    Friend WithEvents KindBindingSource As BindingSource
    Friend WithEvents KindTableAdapter As DataSet1TableAdapters.KindTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents Bericht1 As Bericht
    Friend WithEvents Arztbericht1 As Arztbericht
    Friend WithEvents ArztAnlegen1 As ArztAnlegen

End Class
