<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Nachrichten
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nachrichten))
        Me.AbsenderLabel = New System.Windows.Forms.Label()
        Me.SendenButton = New System.Windows.Forms.Button()
        Me.AbbruchButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MitarbeiterTableAdapter = New WindowsApp2.DataSet1TableAdapters.MitarbeiterTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        Me.NachrichtTableAdapter = New WindowsApp2.DataSet1TableAdapters.NachrichtTableAdapter()
        Me.DataSet11 = New WindowsApp2.DataSet1()
        Me.NachrichtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BetreffTextbox = New WindowsApp2.PlatzhalterText()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NachrichtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AbsenderLabel
        '
        Me.AbsenderLabel.AutoSize = True
        Me.AbsenderLabel.Location = New System.Drawing.Point(9, 9)
        Me.AbsenderLabel.Name = "AbsenderLabel"
        Me.AbsenderLabel.Size = New System.Drawing.Size(39, 13)
        Me.AbsenderLabel.TabIndex = 0
        Me.AbsenderLabel.Text = "Label1"
        '
        'SendenButton
        '
        Me.SendenButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.SendenButton.FlatAppearance.BorderSize = 2
        Me.SendenButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SendenButton.Font = New System.Drawing.Font("Sitka Small", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendenButton.Location = New System.Drawing.Point(433, 348)
        Me.SendenButton.Name = "SendenButton"
        Me.SendenButton.Size = New System.Drawing.Size(75, 23)
        Me.SendenButton.TabIndex = 5
        Me.SendenButton.Text = "Senden"
        Me.SendenButton.UseVisualStyleBackColor = True
        '
        'AbbruchButton
        '
        Me.AbbruchButton.Location = New System.Drawing.Point(340, 348)
        Me.AbbruchButton.Name = "AbbruchButton"
        Me.AbbruchButton.Size = New System.Drawing.Size(75, 23)
        Me.AbbruchButton.TabIndex = 6
        Me.AbbruchButton.Text = "Abbrechen"
        Me.AbbruchButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(270, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 171)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(495, 158)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'MitarbeiterTableAdapter
        '
        Me.MitarbeiterTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.MitarbeiterTableAdapter = Me.MitarbeiterTableAdapter
        Me.TableAdapterManager.NachrichtTableAdapter = Me.NachrichtTableAdapter
        Me.TableAdapterManager.PsychoTableAdapter = Nothing
        Me.TableAdapterManager.SchulBerichtTableAdapter = Nothing
        Me.TableAdapterManager.SchulDatenTableAdapter = Nothing
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Nothing
        '
        'NachrichtTableAdapter
        '
        Me.NachrichtTableAdapter.ClearBeforeFill = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NachrichtBindingSource
        '
        Me.NachrichtBindingSource.DataMember = "Nachricht"
        Me.NachrichtBindingSource.DataSource = Me.DataSet11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(308, 105)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'BetreffTextbox
        '
        Me.BetreffTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.BetreffTextbox.ForeColor = System.Drawing.Color.Gray
        Me.BetreffTextbox.Location = New System.Drawing.Point(12, 105)
        Me.BetreffTextbox.Name = "BetreffTextbox"
        Me.BetreffTextbox.PlatzHalterText = "Betreff"
        Me.BetreffTextbox.Size = New System.Drawing.Size(271, 20)
        Me.BetreffTextbox.TabIndex = 7
        Me.BetreffTextbox.Text = "Betreff"
        '
        'Nachrichten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(536, 391)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BetreffTextbox)
        Me.Controls.Add(Me.AbbruchButton)
        Me.Controls.Add(Me.SendenButton)
        Me.Controls.Add(Me.AbsenderLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Nachrichten"
        Me.Text = "Nachricht"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NachrichtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AbsenderLabel As Label
    Friend WithEvents SendenButton As Button
    Friend WithEvents AbbruchButton As Button
    Friend WithEvents BetreffTextbox As PlatzhalterText
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MitarbeiterTableAdapter As DataSet1TableAdapters.MitarbeiterTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents NachrichtTableAdapter As DataSet1TableAdapters.NachrichtTableAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents NachrichtBindingSource As BindingSource
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
