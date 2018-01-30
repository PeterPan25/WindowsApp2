<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stammdaten
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
        Me.Überschrift = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.KindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Überschrift
        '
        Me.Überschrift.Dock = System.Windows.Forms.DockStyle.Top
        Me.Überschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Überschrift.Location = New System.Drawing.Point(0, 0)
        Me.Überschrift.Name = "Überschrift"
        Me.Überschrift.Size = New System.Drawing.Size(796, 33)
        Me.Überschrift.TabIndex = 1
        Me.Überschrift.Text = "Stammdaten"
        Me.Überschrift.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.94975!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.89447!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.51256!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.39196!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox6, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox7, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox9, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox10, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox11, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox12, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox13, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker2, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 33)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(796, 464)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Geburtsdatum"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nationalität"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jugendamt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 48)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Aufnahmedatum"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Schule"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 48)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Besonderheiten"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(449, 58)
        Me.Label9.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Geburtsort"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(449, 116)
        Me.Label10.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Konfession"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(449, 174)
        Me.Label11.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 24)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Hilfe nach"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(449, 232)
        Me.Label12.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 48)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Sorgerechtsstatus"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(449, 290)
        Me.Label13.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 48)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Krankenversicherung"
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(122, 119)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(224, 29)
        Me.TextBox3.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(122, 177)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(224, 29)
        Me.TextBox4.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(122, 293)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(224, 29)
        Me.TextBox6.TabIndex = 18
        '
        'TextBox7
        '
        Me.TextBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(122, 351)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(224, 29)
        Me.TextBox7.TabIndex = 19
        '
        'TextBox9
        '
        Me.TextBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(571, 61)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(222, 29)
        Me.TextBox9.TabIndex = 21
        '
        'TextBox10
        '
        Me.TextBox10.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(571, 119)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(222, 29)
        Me.TextBox10.TabIndex = 22
        '
        'TextBox11
        '
        Me.TextBox11.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(571, 177)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(222, 29)
        Me.TextBox11.TabIndex = 23
        '
        'TextBox12
        '
        Me.TextBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox12.Enabled = False
        Me.TextBox12.Location = New System.Drawing.Point(571, 235)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(222, 29)
        Me.TextBox12.TabIndex = 24
        '
        'TextBox13
        '
        Me.TextBox13.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox13.Enabled = False
        Me.TextBox13.Location = New System.Drawing.Point(571, 293)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(222, 29)
        Me.TextBox13.TabIndex = 25
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(122, 61)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(224, 29)
        Me.DateTimePicker1.TabIndex = 27
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(122, 235)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(224, 29)
        Me.DateTimePicker2.TabIndex = 28
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KindBindingSource
        '
        Me.KindBindingSource.DataMember = "Kind"
        Me.KindBindingSource.DataSource = Me.DataSet1
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
        Me.TableAdapterManager.PsychoTableAdapter = Nothing
        Me.TableAdapterManager.SchulBerichtTableAdapter = Nothing
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Nothing
        '
        'Stammdaten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Überschrift)
        Me.Name = "Stammdaten"
        Me.Size = New System.Drawing.Size(796, 497)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Überschrift As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents KindBindingSource As BindingSource
    Friend WithEvents KindTableAdapter As DataSet1TableAdapters.KindTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
End Class
