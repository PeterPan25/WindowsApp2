<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ArztAnlegen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.AugenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AugenarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.AugenarztTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        Me.FrauenarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.FrauenarztTableAdapter()
        Me.HautarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.HautarztTableAdapter()
        Me.HNOTableAdapter = New WindowsApp2.DataSet1TableAdapters.HNOTableAdapter()
        Me.KindAugenarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindAugenarztTableAdapter()
        Me.KinderarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.KinderarztTableAdapter()
        Me.KindFrauenarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindFrauenarztTableAdapter()
        Me.KindHautarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindHautarztTableAdapter()
        Me.KindHNOTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindHNOTableAdapter()
        Me.KindKinderarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindKinderarztTableAdapter()
        Me.KindZahnarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.KindZahnarztTableAdapter()
        Me.ZahnarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.ZahnarztTableAdapter()
        Me.KindAugenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrauenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindFrauenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HautarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindHautarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindHNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KinderarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindKinderarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZahnarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindZahnarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PlatzhalterText1 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText5 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText4 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText3 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText2 = New WindowsApp2.PlatzhalterText()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AugenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindAugenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrauenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindFrauenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HautarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindHautarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindHNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KinderarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindKinderarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZahnarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindZahnarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(358, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ärzte"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Augenarzt", "Kinderarzt", "HNO-Arzt", "Zahnarzt", "Frauenarzt", "Hautarzt"})
        Me.ComboBox1.Location = New System.Drawing.Point(134, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fachrichtung:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AugenarztBindingSource
        '
        Me.AugenarztBindingSource.DataMember = "Augenarzt"
        Me.AugenarztBindingSource.DataSource = Me.DataSet1
        '
        'AugenarztTableAdapter
        '
        Me.AugenarztTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AugenarztTableAdapter = Me.AugenarztTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BerichtTableAdapter = Nothing
        Me.TableAdapterManager.FrauenarztTableAdapter = Me.FrauenarztTableAdapter
        Me.TableAdapterManager.HautarztTableAdapter = Me.HautarztTableAdapter
        Me.TableAdapterManager.HilfenTableAdapter = Nothing
        Me.TableAdapterManager.HNOTableAdapter = Me.HNOTableAdapter
        Me.TableAdapterManager.HobbyTableAdapter = Nothing
        Me.TableAdapterManager.KindAugenarztTableAdapter = Me.KindAugenarztTableAdapter
        Me.TableAdapterManager.KinderarztTableAdapter = Me.KinderarztTableAdapter
        Me.TableAdapterManager.KindFrauenarztTableAdapter = Me.KindFrauenarztTableAdapter
        Me.TableAdapterManager.KindHautarztTableAdapter = Me.KindHautarztTableAdapter
        Me.TableAdapterManager.KindHilfenTableAdapter = Nothing
        Me.TableAdapterManager.KindHNOTableAdapter = Me.KindHNOTableAdapter
        Me.TableAdapterManager.KindHobbyTableAdapter = Nothing
        Me.TableAdapterManager.KindKinderarztTableAdapter = Me.KindKinderarztTableAdapter
        Me.TableAdapterManager.KindKontakteTableAdapter = Nothing
        Me.TableAdapterManager.KindKrankenhausTableAdapter = Nothing
        Me.TableAdapterManager.KindPsychoTableAdapter = Nothing
        Me.TableAdapterManager.KindSchuleTableAdapter = Nothing
        Me.TableAdapterManager.KindTableAdapter = Nothing
        Me.TableAdapterManager.KindZahnarztTableAdapter = Me.KindZahnarztTableAdapter
        Me.TableAdapterManager.KontakteTableAdapter = Nothing
        Me.TableAdapterManager.KrankenhausTableAdapter = Nothing
        Me.TableAdapterManager.MitarbeiterTableAdapter = Nothing
        Me.TableAdapterManager.PsychoTableAdapter = Nothing
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Me.ZahnarztTableAdapter
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
        'KindAugenarztTableAdapter
        '
        Me.KindAugenarztTableAdapter.ClearBeforeFill = True
        '
        'KinderarztTableAdapter
        '
        Me.KinderarztTableAdapter.ClearBeforeFill = True
        '
        'KindFrauenarztTableAdapter
        '
        Me.KindFrauenarztTableAdapter.ClearBeforeFill = True
        '
        'KindHautarztTableAdapter
        '
        Me.KindHautarztTableAdapter.ClearBeforeFill = True
        '
        'KindHNOTableAdapter
        '
        Me.KindHNOTableAdapter.ClearBeforeFill = True
        '
        'KindKinderarztTableAdapter
        '
        Me.KindKinderarztTableAdapter.ClearBeforeFill = True
        '
        'KindZahnarztTableAdapter
        '
        Me.KindZahnarztTableAdapter.ClearBeforeFill = True
        '
        'ZahnarztTableAdapter
        '
        Me.ZahnarztTableAdapter.ClearBeforeFill = True
        '
        'KindAugenarztBindingSource
        '
        Me.KindAugenarztBindingSource.DataMember = "KindAugenarzt"
        Me.KindAugenarztBindingSource.DataSource = Me.DataSet1
        '
        'FrauenarztBindingSource
        '
        Me.FrauenarztBindingSource.DataMember = "Frauenarzt"
        Me.FrauenarztBindingSource.DataSource = Me.DataSet1
        '
        'KindFrauenarztBindingSource
        '
        Me.KindFrauenarztBindingSource.DataMember = "KindFrauenarzt"
        Me.KindFrauenarztBindingSource.DataSource = Me.DataSet1
        '
        'HautarztBindingSource
        '
        Me.HautarztBindingSource.DataMember = "Hautarzt"
        Me.HautarztBindingSource.DataSource = Me.DataSet1
        '
        'KindHautarztBindingSource
        '
        Me.KindHautarztBindingSource.DataMember = "KindHautarzt"
        Me.KindHautarztBindingSource.DataSource = Me.DataSet1
        '
        'HNOBindingSource
        '
        Me.HNOBindingSource.DataMember = "HNO"
        Me.HNOBindingSource.DataSource = Me.DataSet1
        '
        'KindHNOBindingSource
        '
        Me.KindHNOBindingSource.DataMember = "KindHNO"
        Me.KindHNOBindingSource.DataSource = Me.DataSet1
        '
        'KinderarztBindingSource
        '
        Me.KinderarztBindingSource.DataMember = "Kinderarzt"
        Me.KinderarztBindingSource.DataSource = Me.DataSet1
        '
        'KindKinderarztBindingSource
        '
        Me.KindKinderarztBindingSource.DataMember = "KindKinderarzt"
        Me.KindKinderarztBindingSource.DataSource = Me.DataSet1
        '
        'ZahnarztBindingSource
        '
        Me.ZahnarztBindingSource.DataMember = "Zahnarzt"
        Me.ZahnarztBindingSource.DataSource = Me.DataSet1
        '
        'KindZahnarztBindingSource
        '
        Me.KindZahnarztBindingSource.DataMember = "KindZahnarzt"
        Me.KindZahnarztBindingSource.DataSource = Me.DataSet1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(502, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(249, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(502, 212)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(249, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(502, 247)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(249, 20)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(502, 287)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(249, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(502, 331)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(249, 20)
        Me.TextBox5.TabIndex = 14
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(502, 77)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(249, 21)
        Me.ComboBox2.TabIndex = 15
        '
        'PlatzhalterText1
        '
        Me.PlatzhalterText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText1.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText1.Location = New System.Drawing.Point(73, 170)
        Me.PlatzhalterText1.Name = "PlatzhalterText1"
        Me.PlatzhalterText1.PlatzHalterText = "Name der Praxis"
        Me.PlatzhalterText1.Size = New System.Drawing.Size(249, 20)
        Me.PlatzhalterText1.TabIndex = 8
        Me.PlatzhalterText1.Text = "Name der Praxis"
        '
        'PlatzhalterText5
        '
        Me.PlatzhalterText5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText5.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText5.Location = New System.Drawing.Point(73, 331)
        Me.PlatzhalterText5.Name = "PlatzhalterText5"
        Me.PlatzhalterText5.PlatzHalterText = "Straße & Hausnummer"
        Me.PlatzhalterText5.Size = New System.Drawing.Size(249, 20)
        Me.PlatzhalterText5.TabIndex = 7
        Me.PlatzhalterText5.Text = "Straße und Hausnummer"
        '
        'PlatzhalterText4
        '
        Me.PlatzhalterText4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText4.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText4.Location = New System.Drawing.Point(73, 287)
        Me.PlatzhalterText4.Name = "PlatzhalterText4"
        Me.PlatzhalterText4.PlatzHalterText = "Ort"
        Me.PlatzhalterText4.Size = New System.Drawing.Size(249, 20)
        Me.PlatzhalterText4.TabIndex = 6
        Me.PlatzhalterText4.Text = "Ort"
        '
        'PlatzhalterText3
        '
        Me.PlatzhalterText3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText3.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText3.Location = New System.Drawing.Point(73, 248)
        Me.PlatzhalterText3.Name = "PlatzhalterText3"
        Me.PlatzhalterText3.PlatzHalterText = "Postleitzahl"
        Me.PlatzhalterText3.Size = New System.Drawing.Size(249, 20)
        Me.PlatzhalterText3.TabIndex = 5
        Me.PlatzhalterText3.Text = "Postleitzahl"
        '
        'PlatzhalterText2
        '
        Me.PlatzhalterText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText2.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText2.Location = New System.Drawing.Point(73, 212)
        Me.PlatzhalterText2.Name = "PlatzhalterText2"
        Me.PlatzhalterText2.PlatzHalterText = "Telefonnummer"
        Me.PlatzhalterText2.Size = New System.Drawing.Size(249, 20)
        Me.PlatzhalterText2.TabIndex = 4
        Me.PlatzhalterText2.Text = "Telefonnummer"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(675, 405)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Ändern"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ArztAnlegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PlatzhalterText1)
        Me.Controls.Add(Me.PlatzhalterText5)
        Me.Controls.Add(Me.PlatzhalterText4)
        Me.Controls.Add(Me.PlatzhalterText3)
        Me.Controls.Add(Me.PlatzhalterText2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ArztAnlegen"
        Me.Size = New System.Drawing.Size(920, 550)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AugenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindAugenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrauenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindFrauenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HautarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindHautarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindHNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KinderarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindKinderarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZahnarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindZahnarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents AugenarztBindingSource As BindingSource
    Friend WithEvents AugenarztTableAdapter As DataSet1TableAdapters.AugenarztTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents FrauenarztTableAdapter As DataSet1TableAdapters.FrauenarztTableAdapter
    Friend WithEvents HautarztTableAdapter As DataSet1TableAdapters.HautarztTableAdapter
    Friend WithEvents HNOTableAdapter As DataSet1TableAdapters.HNOTableAdapter
    Friend WithEvents KindAugenarztTableAdapter As DataSet1TableAdapters.KindAugenarztTableAdapter
    Friend WithEvents KinderarztTableAdapter As DataSet1TableAdapters.KinderarztTableAdapter
    Friend WithEvents KindFrauenarztTableAdapter As DataSet1TableAdapters.KindFrauenarztTableAdapter
    Friend WithEvents KindHautarztTableAdapter As DataSet1TableAdapters.KindHautarztTableAdapter
    Friend WithEvents KindHNOTableAdapter As DataSet1TableAdapters.KindHNOTableAdapter
    Friend WithEvents KindKinderarztTableAdapter As DataSet1TableAdapters.KindKinderarztTableAdapter
    Friend WithEvents KindZahnarztTableAdapter As DataSet1TableAdapters.KindZahnarztTableAdapter
    Friend WithEvents ZahnarztTableAdapter As DataSet1TableAdapters.ZahnarztTableAdapter
    Friend WithEvents KindAugenarztBindingSource As BindingSource
    Friend WithEvents FrauenarztBindingSource As BindingSource
    Friend WithEvents KindFrauenarztBindingSource As BindingSource
    Friend WithEvents HautarztBindingSource As BindingSource
    Friend WithEvents KindHautarztBindingSource As BindingSource
    Friend WithEvents HNOBindingSource As BindingSource
    Friend WithEvents KindHNOBindingSource As BindingSource
    Friend WithEvents KinderarztBindingSource As BindingSource
    Friend WithEvents KindKinderarztBindingSource As BindingSource
    Friend WithEvents ZahnarztBindingSource As BindingSource
    Friend WithEvents KindZahnarztBindingSource As BindingSource
    Friend WithEvents PlatzhalterText2 As PlatzhalterText
    Friend WithEvents PlatzhalterText3 As PlatzhalterText
    Friend WithEvents PlatzhalterText4 As PlatzhalterText
    Friend WithEvents PlatzhalterText5 As PlatzhalterText
    Friend WithEvents PlatzhalterText1 As PlatzhalterText
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
End Class
