<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Augenarzt
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PlatzhalterText4 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText3 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText2 = New WindowsApp2.PlatzhalterText()
        Me.PlatzhalterText1 = New WindowsApp2.PlatzhalterText()
        Me.AugenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.AugenarztTableAdapter = New WindowsApp2.DataSet1TableAdapters.AugenarztTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        Me.PlatzhalterText5 = New WindowsApp2.PlatzhalterText()
        Me.AugenarztDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AugenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AugenarztDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Überschrift
        '
        Me.Überschrift.Dock = System.Windows.Forms.DockStyle.Top
        Me.Überschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Überschrift.Location = New System.Drawing.Point(0, 0)
        Me.Überschrift.Name = "Überschrift"
        Me.Überschrift.Size = New System.Drawing.Size(920, 24)
        Me.Überschrift.TabIndex = 5
        Me.Überschrift.Text = "Augenarzt"
        Me.Überschrift.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.PlatzhalterText5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PlatzhalterText4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PlatzhalterText3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PlatzhalterText2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PlatzhalterText1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Überschrift)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.AugenarztDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(920, 550)
        Me.SplitContainer1.SplitterDistance = 159
        Me.SplitContainer1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlatzhalterText4
        '
        Me.PlatzhalterText4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText4.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText4.Location = New System.Drawing.Point(265, 70)
        Me.PlatzhalterText4.Name = "PlatzhalterText4"
        Me.PlatzhalterText4.PlatzHalterText = Nothing
        Me.PlatzhalterText4.Size = New System.Drawing.Size(100, 20)
        Me.PlatzhalterText4.TabIndex = 9
        Me.PlatzhalterText4.Text = "Straße und HausNr"
        '
        'PlatzhalterText3
        '
        Me.PlatzhalterText3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText3.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText3.Location = New System.Drawing.Point(159, 70)
        Me.PlatzhalterText3.Name = "PlatzhalterText3"
        Me.PlatzhalterText3.PlatzHalterText = Nothing
        Me.PlatzhalterText3.Size = New System.Drawing.Size(100, 20)
        Me.PlatzhalterText3.TabIndex = 8
        Me.PlatzhalterText3.Text = "Ort"
        '
        'PlatzhalterText2
        '
        Me.PlatzhalterText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText2.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText2.Location = New System.Drawing.Point(53, 70)
        Me.PlatzhalterText2.Name = "PlatzhalterText2"
        Me.PlatzhalterText2.PlatzHalterText = Nothing
        Me.PlatzhalterText2.Size = New System.Drawing.Size(100, 20)
        Me.PlatzhalterText2.TabIndex = 7
        Me.PlatzhalterText2.Text = "Postleitzahl"
        '
        'PlatzhalterText1
        '
        Me.PlatzhalterText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText1.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText1.Location = New System.Drawing.Point(53, 44)
        Me.PlatzhalterText1.Name = "PlatzhalterText1"
        Me.PlatzhalterText1.PlatzHalterText = Nothing
        Me.PlatzhalterText1.Size = New System.Drawing.Size(100, 20)
        Me.PlatzhalterText1.TabIndex = 6
        Me.PlatzhalterText1.Text = "Name"
        '
        'AugenarztBindingSource
        '
        Me.AugenarztBindingSource.DataMember = "Augenarzt"
        Me.AugenarztBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Nothing
        '
        'PlatzhalterText5
        '
        Me.PlatzhalterText5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.PlatzhalterText5.ForeColor = System.Drawing.Color.Gray
        Me.PlatzhalterText5.Location = New System.Drawing.Point(159, 44)
        Me.PlatzhalterText5.Name = "PlatzhalterText5"
        Me.PlatzhalterText5.PlatzHalterText = "Telefon"
        Me.PlatzhalterText5.Size = New System.Drawing.Size(100, 20)
        Me.PlatzhalterText5.TabIndex = 11
        Me.PlatzhalterText5.Text = "Telefon"
        '
        'AugenarztDataGridView
        '
        Me.AugenarztDataGridView.AutoGenerateColumns = False
        Me.AugenarztDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AugenarztDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AugenarztDataGridView.DataSource = Me.AugenarztBindingSource
        Me.AugenarztDataGridView.Location = New System.Drawing.Point(65, 73)
        Me.AugenarztDataGridView.Name = "AugenarztDataGridView"
        Me.AugenarztDataGridView.Size = New System.Drawing.Size(642, 220)
        Me.AugenarztDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "A_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "A_Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ort"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ort"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Plz"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Plz"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Strasse"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Strasse"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Art"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Art"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telefon"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Augenarzt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Augenarzt"
        Me.Size = New System.Drawing.Size(920, 550)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AugenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AugenarztDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Überschrift As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents AugenarztBindingSource As BindingSource
    Friend WithEvents AugenarztTableAdapter As DataSet1TableAdapters.AugenarztTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents PlatzhalterText4 As PlatzhalterText
    Friend WithEvents PlatzhalterText3 As PlatzhalterText
    Friend WithEvents PlatzhalterText2 As PlatzhalterText
    Friend WithEvents PlatzhalterText1 As PlatzhalterText
    Friend WithEvents PlatzhalterText5 As PlatzhalterText
    Friend WithEvents AugenarztDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
