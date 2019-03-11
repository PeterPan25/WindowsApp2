<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Aaliyah
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Aaliyah))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.KindKontakteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindKontakteTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindKontakteTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        Me.KontakteTableAdapter = New WindowsApp2.DataSet1TableAdapters.KontakteTableAdapter()
        Me.KontakteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindKontakteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontakteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(292, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Kontakt hinzufügen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KindKontakteBindingSource
        '
        Me.KindKontakteBindingSource.DataMember = "KindKontakte"
        Me.KindKontakteBindingSource.DataSource = Me.DataSet1
        '
        'KindKontakteTableAdapter
        '
        Me.KindKontakteTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.KindKontakteTableAdapter = Me.KindKontakteTableAdapter
        Me.TableAdapterManager.KindKrankenhausTableAdapter = Nothing
        Me.TableAdapterManager.KindPsychoTableAdapter = Nothing
        Me.TableAdapterManager.KindSchuleTableAdapter = Nothing
        Me.TableAdapterManager.KindTableAdapter = Nothing
        Me.TableAdapterManager.KindZahnarztTableAdapter = Nothing
        Me.TableAdapterManager.KontakteTableAdapter = Me.KontakteTableAdapter
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
        'KontakteTableAdapter
        '
        Me.KontakteTableAdapter.ClearBeforeFill = True
        '
        'KontakteBindingSource
        '
        Me.KontakteBindingSource.DataMember = "Kontakte"
        Me.KontakteBindingSource.DataSource = Me.DataSet1
        '
        'PlatzhalterText1
        '
        Me.PlatzhalterText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText1.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText1.Location = New System.Drawing.Point(12, 45)
        Me.PlatzhalterText1.Name = "PlatzhalterText1"
        Me.PlatzhalterText1.PlatzHalterText = "Name"
        Me.PlatzhalterText1.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText1.TabIndex = 7
        Me.PlatzhalterText1.Text = "Hallo"
        '
        'PlatzhalterText2
        '
        Me.PlatzhalterText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText2.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText2.Location = New System.Drawing.Point(162, 45)
        Me.PlatzhalterText2.Name = "PlatzhalterText2"
        Me.PlatzhalterText2.PlatzHalterText = "Vorname"
        Me.PlatzhalterText2.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText2.TabIndex = 8
        Me.PlatzhalterText2.Text = "Vorname"
        '
        'PlatzhalterText3
        '
        Me.PlatzhalterText3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText3.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText3.Location = New System.Drawing.Point(12, 77)
        Me.PlatzhalterText3.Name = "PlatzhalterText3"
        Me.PlatzhalterText3.PlatzHalterText = "Rolle"
        Me.PlatzhalterText3.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText3.TabIndex = 9
        Me.PlatzhalterText3.Text = "Rolle"
        '
        'PlatzhalterText4
        '
        Me.PlatzhalterText4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText4.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText4.Location = New System.Drawing.Point(162, 77)
        Me.PlatzhalterText4.Name = "PlatzhalterText4"
        Me.PlatzhalterText4.PlatzHalterText = "Kind"
        Me.PlatzhalterText4.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText4.TabIndex = 10
        Me.PlatzhalterText4.Text = "Kind"
        '
        'PlatzhalterText5
        '
        Me.PlatzhalterText5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText5.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText5.Location = New System.Drawing.Point(12, 109)
        Me.PlatzhalterText5.Name = "PlatzhalterText5"
        Me.PlatzhalterText5.PlatzHalterText = "Telefon"
        Me.PlatzhalterText5.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText5.TabIndex = 11
        Me.PlatzhalterText5.Text = "Telefon"
        '
        'PlatzhalterText6
        '
        Me.PlatzhalterText6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText6.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText6.Location = New System.Drawing.Point(162, 109)
        Me.PlatzhalterText6.Name = "PlatzhalterText6"
        Me.PlatzhalterText6.PlatzHalterText = "Mail"
        Me.PlatzhalterText6.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText6.TabIndex = 12
        Me.PlatzhalterText6.Text = "Mail"
        '
        'PlatzhalterText7
        '
        Me.PlatzhalterText7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText7.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText7.Location = New System.Drawing.Point(12, 141)
        Me.PlatzhalterText7.Name = "PlatzhalterText7"
        Me.PlatzhalterText7.PlatzHalterText = "Sonstiges"
        Me.PlatzhalterText7.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText7.TabIndex = 13
        Me.PlatzhalterText7.Text = "Sonstiges"
        '
        'PlatzhalterText8
        '
        Me.PlatzhalterText8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText8.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText8.Location = New System.Drawing.Point(12, 173)
        Me.PlatzhalterText8.Name = "PlatzhalterText8"
        Me.PlatzhalterText8.PlatzHalterText = "Postleitzahl"
        Me.PlatzhalterText8.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText8.TabIndex = 14
        Me.PlatzhalterText8.Text = "Postleitzahl"
        '
        'PlatzhalterText9
        '
        Me.PlatzhalterText9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText9.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText9.Location = New System.Drawing.Point(162, 173)
        Me.PlatzhalterText9.Name = "PlatzhalterText9"
        Me.PlatzhalterText9.PlatzHalterText = "Ort"
        Me.PlatzhalterText9.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText9.TabIndex = 15
        Me.PlatzhalterText9.Text = "Ort"
        '
        'PlatzhalterText10
        '
        Me.PlatzhalterText10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText10.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText10.Location = New System.Drawing.Point(12, 205)
        Me.PlatzhalterText10.Name = "PlatzhalterText10"
        Me.PlatzhalterText10.PlatzHalterText = "Straße"
        Me.PlatzhalterText10.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText10.TabIndex = 16
        Me.PlatzhalterText10.Text = "Straße"
        '
        'PlatzhalterText11
        '
        Me.PlatzhalterText11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText11.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText11.Location = New System.Drawing.Point(162, 205)
        Me.PlatzhalterText11.Name = "PlatzhalterText11"
        Me.PlatzhalterText11.PlatzHalterText = "Hausnummer"
        Me.PlatzhalterText11.Size = New System.Drawing.Size(120, 26)
        Me.PlatzhalterText11.TabIndex = 17
        Me.PlatzhalterText11.Text = "Hausnummer"
        '
        'F_Aaliyah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(440, 382)
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
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Aaliyah"
        Me.Text = "neuer Kontakt"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindKontakteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontakteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents KindKontakteBindingSource As BindingSource
    Friend WithEvents KindKontakteTableAdapter As DataSet1TableAdapters.KindKontakteTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents KontakteTableAdapter As DataSet1TableAdapters.KontakteTableAdapter
    Friend WithEvents KontakteBindingSource As BindingSource
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
End Class
