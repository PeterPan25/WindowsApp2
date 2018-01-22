<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ab
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlatzhalterText1 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText2 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText3 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText4 = New WindowsApp2.PlatzhalterText()
        Me.ElternBerichtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElternBerichtTableAdapter = New WindowsApp2.DataSet1TableAdapters.ElternBerichtTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        Me.SchulBerichtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchulBerichtTableAdapter = New WindowsApp2.DataSet1TableAdapters.SchulBerichtTableAdapter()
        Me.PlatzhalterText5 = New WindowsApp2.PlatzhalterText()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElternBerichtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchulBerichtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(746, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 154)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(819, 278)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(164, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(631, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(376, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'PlatzhalterText1
        '
        Me.PlatzhalterText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText1.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText1.Location = New System.Drawing.Point(326, 40)
        Me.PlatzhalterText1.Name = "PlatzhalterText1"
        Me.PlatzhalterText1.PlatzHalterText = "Thema"
        Me.PlatzhalterText1.Size = New System.Drawing.Size(194, 20)
        Me.PlatzhalterText1.TabIndex = 6
        Me.PlatzhalterText1.Text = "Thema"
        '
        'PlatzhalterText2
        '
        Me.PlatzhalterText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText2.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText2.Location = New System.Drawing.Point(12, 73)
        Me.PlatzhalterText2.Name = "PlatzhalterText2"
        Me.PlatzhalterText2.PlatzHalterText = "Schule"
        Me.PlatzhalterText2.Size = New System.Drawing.Size(168, 20)
        Me.PlatzhalterText2.TabIndex = 7
        Me.PlatzhalterText2.Text = "Schule"
        '
        'PlatzhalterText3
        '
        Me.PlatzhalterText3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText3.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText3.Location = New System.Drawing.Point(12, 100)
        Me.PlatzhalterText3.Name = "PlatzhalterText3"
        Me.PlatzhalterText3.PlatzHalterText = "Klasse"
        Me.PlatzhalterText3.Size = New System.Drawing.Size(168, 20)
        Me.PlatzhalterText3.TabIndex = 8
        Me.PlatzhalterText3.Text = "Klasse"
        '
        'PlatzhalterText4
        '
        Me.PlatzhalterText4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText4.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText4.Location = New System.Drawing.Point(12, 128)
        Me.PlatzhalterText4.Name = "PlatzhalterText4"
        Me.PlatzhalterText4.PlatzHalterText = "Lehrer/-in"
        Me.PlatzhalterText4.Size = New System.Drawing.Size(168, 20)
        Me.PlatzhalterText4.TabIndex = 9
        Me.PlatzhalterText4.Text = "Lehrer/-in"
        '
        'ElternBerichtBindingSource
        '
        Me.ElternBerichtBindingSource.DataMember = "ElternBericht"
        Me.ElternBerichtBindingSource.DataSource = Me.DataSet1
        '
        'ElternBerichtTableAdapter
        '
        Me.ElternBerichtTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AugenarztTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BerichtTableAdapter = Nothing
        Me.TableAdapterManager.ElternBerichtTableAdapter = Me.ElternBerichtTableAdapter
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
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Nothing
        '
        'SchulBerichtBindingSource
        '
        Me.SchulBerichtBindingSource.DataMember = "SchulBericht"
        Me.SchulBerichtBindingSource.DataSource = Me.DataSet1
        '
        'SchulBerichtTableAdapter
        '
        Me.SchulBerichtTableAdapter.ClearBeforeFill = True
        '
        'PlatzhalterText5
        '
        Me.PlatzhalterText5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText5.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText5.Location = New System.Drawing.Point(186, 128)
        Me.PlatzhalterText5.Name = "PlatzhalterText5"
        Me.PlatzhalterText5.PlatzHalterText = "Fach"
        Me.PlatzhalterText5.Size = New System.Drawing.Size(168, 20)
        Me.PlatzhalterText5.TabIndex = 10
        Me.PlatzhalterText5.Text = "Fach"
        '
        'BerichtAnlegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PlatzhalterText5)
        Me.Controls.Add(Me.PlatzhalterText4)
        Me.Controls.Add(Me.PlatzhalterText3)
        Me.Controls.Add(Me.PlatzhalterText2)
        Me.Controls.Add(Me.PlatzhalterText1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "BerichtAnlegen"
        Me.Size = New System.Drawing.Size(851, 491)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElternBerichtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchulBerichtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PlatzhalterText1 As PlatzhalterText
    Friend WithEvents PlatzhalterText2 As PlatzhalterText
    Friend WithEvents PlatzhalterText3 As PlatzhalterText
    Friend WithEvents PlatzhalterText4 As PlatzhalterText
    Friend WithEvents ElternBerichtBindingSource As BindingSource
    Friend WithEvents ElternBerichtTableAdapter As DataSet1TableAdapters.ElternBerichtTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents SchulBerichtTableAdapter As DataSet1TableAdapters.SchulBerichtTableAdapter
    Friend WithEvents SchulBerichtBindingSource As BindingSource
    Friend WithEvents PlatzhalterText5 As PlatzhalterText
End Class
