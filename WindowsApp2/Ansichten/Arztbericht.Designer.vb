<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arztbericht
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.BerichtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BerichtTableAdapter = New WindowsApp2.DataSet1TableAdapters.BerichtTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        Me.AugenarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.AugenarztTableAdapter()
        Me.FrauenarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.FrauenarztTableAdapter()
        Me.HautarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.HautarztTableAdapter()
        Me.HNOTableAdapter = New WindowsApp2.DataSet1TableAdapters.HNOTableAdapter()
        Me.KinderarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.KinderarztTableAdapter()
        Me.ZahnarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.ZahnarztTableAdapter()
        Me.FrauenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HautarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AugenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZahnarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KinderarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlatzhalterText1 = New WindowsApp2.PlatzhalterText()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BerichtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrauenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HautarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AugenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZahnarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KinderarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Kinderarzt", "HNO", "Zahnarzt", "Frauenarzt", "Hautarzt", "Augenarzt", "Krankenhaus"})
        Me.ComboBox1.Location = New System.Drawing.Point(97, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(97, 104)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(241, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(395, 142)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(548, 142)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(712, 142)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(121, 20)
        Me.TextBox4.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 193)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(958, 261)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(880, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(755, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 10
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BerichtBindingSource
        '
        Me.BerichtBindingSource.DataMember = "Bericht"
        Me.BerichtBindingSource.DataSource = Me.DataSet1
        '
        'BerichtTableAdapter
        '
        Me.BerichtTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AugenarztTableAdapter = Me.AugenarztTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BerichtTableAdapter = Me.BerichtTableAdapter
        Me.TableAdapterManager.FrauenarztTableAdapter = Me.FrauenarztTableAdapter
        Me.TableAdapterManager.HautarztTableAdapter = Me.HautarztTableAdapter
        Me.TableAdapterManager.HilfenTableAdapter = Nothing
        Me.TableAdapterManager.HNOTableAdapter = Me.HNOTableAdapter
        Me.TableAdapterManager.HobbyTableAdapter = Nothing
        Me.TableAdapterManager.KindAugenarztTableAdapter = Nothing
        Me.TableAdapterManager.KinderarztTableAdapter = Me.KinderarztTableAdapter
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
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Me.ZahnarztTableAdapter
        '
        'AugenarztTableAdapter
        '
        Me.AugenarztTableAdapter.ClearBeforeFill = True
        '
        'FrauenarztTableAdapter
        '
        Me.FrauenarztTableAdapter.ClearBeforeFill = True
        '
        'HautarztTableAdapter
        '
        Me.HautarztTableAdapter.ClearBeforeFill = True
        '
        'HNOTableAdapter
        '
        Me.HNOTableAdapter.ClearBeforeFill = True
        '
        'KinderarztTableAdapter
        '
        Me.KinderarztTableAdapter.ClearBeforeFill = True
        '
        'ZahnarztTableAdapter
        '
        Me.ZahnarztTableAdapter.ClearBeforeFill = True
        '
        'FrauenarztBindingSource
        '
        Me.FrauenarztBindingSource.DataMember = "Frauenarzt"
        Me.FrauenarztBindingSource.DataSource = Me.DataSet1
        '
        'HautarztBindingSource
        '
        Me.HautarztBindingSource.DataMember = "Hautarzt"
        Me.HautarztBindingSource.DataSource = Me.DataSet1
        '
        'AugenarztBindingSource
        '
        Me.AugenarztBindingSource.DataMember = "Augenarzt"
        Me.AugenarztBindingSource.DataSource = Me.DataSet1
        '
        'HNOBindingSource
        '
        Me.HNOBindingSource.DataMember = "HNO"
        Me.HNOBindingSource.DataSource = Me.DataSet1
        '
        'ZahnarztBindingSource
        '
        Me.ZahnarztBindingSource.DataMember = "Zahnarzt"
        Me.ZahnarztBindingSource.DataSource = Me.DataSet1
        '
        'KinderarztBindingSource
        '
        Me.KinderarztBindingSource.DataMember = "Kinderarzt"
        Me.KinderarztBindingSource.DataSource = Me.DataSet1
        '
        'PlatzhalterText1
        '
        Me.PlatzhalterText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText1.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText1.Location = New System.Drawing.Point(97, 142)
        Me.PlatzhalterText1.Name = "PlatzhalterText1"
        Me.PlatzhalterText1.PlatzHalterText = "Behandelnder Arzt"
        Me.PlatzhalterText1.Size = New System.Drawing.Size(121, 20)
        Me.PlatzhalterText1.TabIndex = 2
        Me.PlatzhalterText1.Text = "Behandelnder Arzt"
        '
        'Arztbericht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PlatzhalterText1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Arztbericht"
        Me.Size = New System.Drawing.Size(978, 490)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BerichtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrauenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HautarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AugenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZahnarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KinderarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PlatzhalterText1 As PlatzhalterText
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents BerichtBindingSource As BindingSource
    Friend WithEvents BerichtTableAdapter As DataSet1TableAdapters.BerichtTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AugenarztTableAdapter As DataSet1TableAdapters.AugenarztTableAdapter
    Friend WithEvents FrauenarztTableAdapter As DataSet1TableAdapters.FrauenarztTableAdapter
    Friend WithEvents HautarztTableAdapter As DataSet1TableAdapters.HautarztTableAdapter
    Friend WithEvents HNOTableAdapter As DataSet1TableAdapters.HNOTableAdapter
    Friend WithEvents KinderarztTableAdapter As DataSet1TableAdapters.KinderarztTableAdapter
    Friend WithEvents ZahnarztTableAdapter As DataSet1TableAdapters.ZahnarztTableAdapter
    Friend WithEvents FrauenarztBindingSource As BindingSource
    Friend WithEvents HautarztBindingSource As BindingSource
    Friend WithEvents AugenarztBindingSource As BindingSource
    Friend WithEvents HNOBindingSource As BindingSource
    Friend WithEvents ZahnarztBindingSource As BindingSource
    Friend WithEvents KinderarztBindingSource As BindingSource
End Class
