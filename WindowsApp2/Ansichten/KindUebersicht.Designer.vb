<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KindUebersicht
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
        Me.PlatzhalterText1 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText2 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText3 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText4 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText5 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText6 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText7 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText8 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText9 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText10 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText11 = New WindowsApp2.PlatzhalterText()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.KindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlatzhalterText1
        '
        Me.PlatzhalterText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText1.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText1.Location = New System.Drawing.Point(269, 56)
        Me.PlatzhalterText1.Name = "PlatzhalterText1"
        Me.PlatzhalterText1.PlatzHalterText = "Vorname"
        Me.PlatzhalterText1.Size = New System.Drawing.Size(251, 20)
        Me.PlatzhalterText1.TabIndex = 0
        Me.PlatzhalterText1.Text = "Vorname"
        '
        'PlatzhalterText2
        '
        Me.PlatzhalterText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText2.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText2.Location = New System.Drawing.Point(551, 56)
        Me.PlatzhalterText2.Name = "PlatzhalterText2"
        Me.PlatzhalterText2.PlatzHalterText = "Name"
        Me.PlatzhalterText2.Size = New System.Drawing.Size(261, 20)
        Me.PlatzhalterText2.TabIndex = 1
        Me.PlatzhalterText2.Text = "Name"
        '
        'PlatzhalterText3
        '
        Me.PlatzhalterText3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText3.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText3.Location = New System.Drawing.Point(551, 108)
        Me.PlatzhalterText3.Name = "PlatzhalterText3"
        Me.PlatzhalterText3.PlatzHalterText = "Geburtsort"
        Me.PlatzhalterText3.Size = New System.Drawing.Size(261, 20)
        Me.PlatzhalterText3.TabIndex = 2
        Me.PlatzhalterText3.Text = "Geburtsort"
        '
        'PlatzhalterText4
        '
        Me.PlatzhalterText4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText4.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText4.Location = New System.Drawing.Point(269, 152)
        Me.PlatzhalterText4.Name = "PlatzhalterText4"
        Me.PlatzhalterText4.PlatzHalterText = "Nationalität"
        Me.PlatzhalterText4.Size = New System.Drawing.Size(251, 20)
        Me.PlatzhalterText4.TabIndex = 3
        Me.PlatzhalterText4.Text = "Nationalität"
        '
        'PlatzhalterText5
        '
        Me.PlatzhalterText5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText5.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText5.Location = New System.Drawing.Point(551, 152)
        Me.PlatzhalterText5.Name = "PlatzhalterText5"
        Me.PlatzhalterText5.PlatzHalterText = "Konfession"
        Me.PlatzhalterText5.Size = New System.Drawing.Size(261, 20)
        Me.PlatzhalterText5.TabIndex = 4
        Me.PlatzhalterText5.Text = "Konfession"
        '
        'PlatzhalterText6
        '
        Me.PlatzhalterText6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText6.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText6.Location = New System.Drawing.Point(269, 198)
        Me.PlatzhalterText6.Name = "PlatzhalterText6"
        Me.PlatzhalterText6.PlatzHalterText = "Jugendamt"
        Me.PlatzhalterText6.Size = New System.Drawing.Size(251, 20)
        Me.PlatzhalterText6.TabIndex = 5
        Me.PlatzhalterText6.Text = "Jugendamt"
        '
        'PlatzhalterText7
        '
        Me.PlatzhalterText7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText7.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText7.Location = New System.Drawing.Point(551, 198)
        Me.PlatzhalterText7.Name = "PlatzhalterText7"
        Me.PlatzhalterText7.PlatzHalterText = "Hilfe nach"
        Me.PlatzhalterText7.Size = New System.Drawing.Size(261, 20)
        Me.PlatzhalterText7.TabIndex = 6
        Me.PlatzhalterText7.Text = "Hilfe nach"
        '
        'PlatzhalterText8
        '
        Me.PlatzhalterText8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText8.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText8.Location = New System.Drawing.Point(551, 250)
        Me.PlatzhalterText8.Name = "PlatzhalterText8"
        Me.PlatzhalterText8.PlatzHalterText = "Sorgerechtsstatus"
        Me.PlatzhalterText8.Size = New System.Drawing.Size(261, 20)
        Me.PlatzhalterText8.TabIndex = 7
        Me.PlatzhalterText8.Text = "Sorgerechtsstatus"
        '
        'PlatzhalterText9
        '
        Me.PlatzhalterText9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText9.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText9.Location = New System.Drawing.Point(269, 305)
        Me.PlatzhalterText9.Name = "PlatzhalterText9"
        Me.PlatzhalterText9.PlatzHalterText = "Schule"
        Me.PlatzhalterText9.Size = New System.Drawing.Size(251, 20)
        Me.PlatzhalterText9.TabIndex = 8
        Me.PlatzhalterText9.Text = "Schule"
        '
        'PlatzhalterText10
        '
        Me.PlatzhalterText10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText10.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText10.Location = New System.Drawing.Point(551, 305)
        Me.PlatzhalterText10.Name = "PlatzhalterText10"
        Me.PlatzhalterText10.PlatzHalterText = "Krankenversicherung"
        Me.PlatzhalterText10.Size = New System.Drawing.Size(261, 20)
        Me.PlatzhalterText10.TabIndex = 9
        Me.PlatzhalterText10.Text = "Krankenversicherung"
        '
        'PlatzhalterText11
        '
        Me.PlatzhalterText11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText11.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText11.Location = New System.Drawing.Point(269, 369)
        Me.PlatzhalterText11.Name = "PlatzhalterText11"
        Me.PlatzhalterText11.PlatzHalterText = "Besonderheiten"
        Me.PlatzhalterText11.Size = New System.Drawing.Size(251, 20)
        Me.PlatzhalterText11.TabIndex = 10
        Me.PlatzhalterText11.Text = "Besonderheiten"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(269, 108)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(251, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(269, 250)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(251, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Geburtsdatum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Aufnahmedatum"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(737, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
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
        'KindUebersicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PlatzhalterText11)
        Me.Controls.Add(Me.PlatzhalterText10)
        Me.Controls.Add(Me.PlatzhalterText9)
        Me.Controls.Add(Me.PlatzhalterText8)
        Me.Controls.Add(Me.PlatzhalterText7)
        Me.Controls.Add(Me.PlatzhalterText6)
        Me.Controls.Add(Me.PlatzhalterText5)
        Me.Controls.Add(Me.PlatzhalterText4)
        Me.Controls.Add(Me.PlatzhalterText3)
        Me.Controls.Add(Me.PlatzhalterText2)
        Me.Controls.Add(Me.PlatzhalterText1)
        Me.Name = "KindUebersicht"
        Me.Size = New System.Drawing.Size(920, 613)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlatzhalterText1 As PlatzhalterText
    Friend WithEvents PlatzhalterText2 As PlatzhalterText
    Friend WithEvents PlatzhalterText3 As PlatzhalterText
    Friend WithEvents PlatzhalterText4 As PlatzhalterText
    Friend WithEvents PlatzhalterText5 As PlatzhalterText
    Friend WithEvents PlatzhalterText6 As PlatzhalterText
    Friend WithEvents PlatzhalterText7 As PlatzhalterText
    Friend WithEvents PlatzhalterText8 As PlatzhalterText
    Friend WithEvents PlatzhalterText9 As PlatzhalterText
    Friend WithEvents PlatzhalterText10 As PlatzhalterText
    Friend WithEvents PlatzhalterText11 As PlatzhalterText
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents KindBindingSource As BindingSource
    Friend WithEvents KindTableAdapter As DataSet1TableAdapters.KindTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
End Class
