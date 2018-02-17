<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Schule
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PlatzhalterText2 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText1 = New WindowsApp2.PlatzhalterText()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PlatzhalterText3 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText4 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText5 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText6 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText7 = New WindowsApp2.PlatzhalterText()
        Me.SchuleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchuleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.Berichte = New System.Windows.Forms.Label()
        Me.SchulBerichtDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchulBerichtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Überschrift = New System.Windows.Forms.Label()
        Me.SchuleTableAdapter = New WindowsApp2.DataSet1TableAdapters.SchuleTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        Me.SchulBerichtTableAdapter = New WindowsApp2.DataSet1TableAdapters.SchulBerichtTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SchuleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchuleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchulBerichtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchulBerichtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.Berichte)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SchulBerichtDataGridView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1208, 655)
        Me.SplitContainer1.SplitterDistance = 732
        Me.SplitContainer1.TabIndex = 13
        '
        'SplitContainer2
        '
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 41)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlatzhalterText2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlatzhalterText1)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(729, 611)
        Me.SplitContainer2.SplitterDistance = 279
        Me.SplitContainer2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Bis:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Von:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(363, 100)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(181, 22)
        Me.DateTimePicker2.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(51, 104)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 22)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Bericht anlegen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlatzhalterText2
        '
        Me.PlatzhalterText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText2.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText2.Location = New System.Drawing.Point(326, 36)
        Me.PlatzhalterText2.Name = "PlatzhalterText2"
        Me.PlatzhalterText2.PlatzHalterText = "Schulart"
        Me.PlatzhalterText2.Size = New System.Drawing.Size(218, 26)
        Me.PlatzhalterText2.TabIndex = 7
        Me.PlatzhalterText2.Text = "Schulart"
        '
        'PlatzhalterText1
        '
        Me.PlatzhalterText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText1.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText1.Location = New System.Drawing.Point(6, 36)
        Me.PlatzhalterText1.Name = "PlatzhalterText1"
        Me.PlatzhalterText1.PlatzHalterText = "Schule"
        Me.PlatzhalterText1.Size = New System.Drawing.Size(301, 26)
        Me.PlatzhalterText1.TabIndex = 6
        Me.PlatzhalterText1.Text = "Schule"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(384, 180)
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
        Me.PlatzhalterText3.Location = New System.Drawing.Point(6, 68)
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
        Me.PlatzhalterText4.Location = New System.Drawing.Point(207, 68)
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
        Me.PlatzhalterText5.Location = New System.Drawing.Point(326, 68)
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
        Me.PlatzhalterText6.Location = New System.Drawing.Point(6, 132)
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
        Me.PlatzhalterText7.Location = New System.Drawing.Point(114, 132)
        Me.PlatzhalterText7.Name = "PlatzhalterText7"
        Me.PlatzhalterText7.PlatzHalterText = "Klassenlehrer/-in"
        Me.PlatzhalterText7.Size = New System.Drawing.Size(193, 26)
        Me.PlatzhalterText7.TabIndex = 12
        Me.PlatzhalterText7.Text = "Klassenlehrer/-in"
        '
        'SchuleDataGridView
        '
        Me.SchuleDataGridView.AutoGenerateColumns = False
        Me.SchuleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SchuleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.SchuleDataGridView.DataSource = Me.SchuleBindingSource
        Me.SchuleDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.SchuleDataGridView.Name = "SchuleDataGridView"
        Me.SchuleDataGridView.Size = New System.Drawing.Size(729, 373)
        Me.SchuleDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "S_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "S_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Strasse"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Strasse"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Plz"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Plz"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ort"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ort"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Schulart"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Schulart"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "vDatum"
        Me.DataGridViewTextBoxColumn12.HeaderText = "vDatum"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "bDatum"
        Me.DataGridViewTextBoxColumn13.HeaderText = "bDatum"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'SchuleBindingSource
        '
        Me.SchuleBindingSource.DataMember = "Schule"
        Me.SchuleBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Berichte
        '
        Me.Berichte.AutoSize = True
        Me.Berichte.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Berichte.Location = New System.Drawing.Point(190, 55)
        Me.Berichte.Name = "Berichte"
        Me.Berichte.Size = New System.Drawing.Size(110, 29)
        Me.Berichte.TabIndex = 2
        Me.Berichte.Text = "Berichte"
        '
        'SchulBerichtDataGridView
        '
        Me.SchulBerichtDataGridView.AutoGenerateColumns = False
        Me.SchulBerichtDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.SchulBerichtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SchulBerichtDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7})
        Me.SchulBerichtDataGridView.DataSource = Me.SchulBerichtBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SchulBerichtDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.SchulBerichtDataGridView.Location = New System.Drawing.Point(3, 166)
        Me.SchulBerichtDataGridView.Name = "SchulBerichtDataGridView"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SchulBerichtDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SchulBerichtDataGridView.RowHeadersWidth = 40
        Me.SchulBerichtDataGridView.RowTemplate.Height = 40
        Me.SchulBerichtDataGridView.Size = New System.Drawing.Size(500, 489)
        Me.SchulBerichtDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Datum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Datum"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Thema"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Thema"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Lehrer"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lehrer"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fach"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fach"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'SchulBerichtBindingSource
        '
        Me.SchulBerichtBindingSource.DataMember = "SchulBericht"
        Me.SchulBerichtBindingSource.DataSource = Me.DataSet1
        '
        'Überschrift
        '
        Me.Überschrift.Dock = System.Windows.Forms.DockStyle.Top
        Me.Überschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Überschrift.Location = New System.Drawing.Point(0, 0)
        Me.Überschrift.Name = "Überschrift"
        Me.Überschrift.Size = New System.Drawing.Size(1208, 38)
        Me.Überschrift.TabIndex = 5
        Me.Überschrift.Text = "Schule"
        Me.Überschrift.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SchuleTableAdapter
        '
        Me.SchuleTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.KindTableAdapter = Nothing
        Me.TableAdapterManager.KindZahnarztTableAdapter = Nothing
        Me.TableAdapterManager.KontakteTableAdapter = Nothing
        Me.TableAdapterManager.KrankenhausTableAdapter = Nothing
        Me.TableAdapterManager.MitarbeiterTableAdapter = Nothing
        Me.TableAdapterManager.PsychoTableAdapter = Nothing
        Me.TableAdapterManager.SchulBerichtTableAdapter = Me.SchulBerichtTableAdapter
        Me.TableAdapterManager.SchuleTableAdapter = Me.SchuleTableAdapter
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Nothing
        '
        'SchulBerichtTableAdapter
        '
        Me.SchulBerichtTableAdapter.ClearBeforeFill = True
        '
        'Schule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.Überschrift)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Schule"
        Me.Size = New System.Drawing.Size(1208, 655)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SchuleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchuleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchulBerichtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchulBerichtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Überschrift As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents SchuleTableAdapter As DataSet1TableAdapters.SchuleTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents SchulBerichtDataGridView As DataGridView
    Friend WithEvents SchulBerichtBindingSource As BindingSource
    Friend WithEvents SchulBerichtTableAdapter As DataSet1TableAdapters.SchulBerichtTableAdapter
    Friend WithEvents SchuleBindingSource As BindingSource
    Friend WithEvents PlatzhalterText1 As PlatzhalterText
    Friend WithEvents PlatzhalterText7 As PlatzhalterText
    Friend WithEvents PlatzhalterText6 As PlatzhalterText
    Friend WithEvents PlatzhalterText5 As PlatzhalterText
    Friend WithEvents PlatzhalterText4 As PlatzhalterText
    Friend WithEvents PlatzhalterText3 As PlatzhalterText
    Friend WithEvents PlatzhalterText2 As PlatzhalterText
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SchuleDataGridView As DataGridView
    Friend WithEvents Berichte As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
