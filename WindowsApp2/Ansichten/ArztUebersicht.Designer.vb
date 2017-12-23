<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArztUebersicht
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.FrauenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HautarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindAugenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KinderarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindFrauenarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindHautarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindHNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindKinderarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KindZahnarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZahnarztBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AugenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrauenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HautarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindAugenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KinderarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindFrauenarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindHautarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindHNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindKinderarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindZahnarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZahnarztBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(381, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Arzt Übersicht"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Augenarzt", "Frauenarzt", "Hautarzt", "HNO", "Kinderarzt", "Zahnarzt"})
        Me.ComboBox1.Location = New System.Drawing.Point(100, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(100, 148)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'HNOBindingSource
        '
        Me.HNOBindingSource.DataMember = "HNO"
        Me.HNOBindingSource.DataSource = Me.DataSet1
        '
        'KindAugenarztBindingSource
        '
        Me.KindAugenarztBindingSource.DataMember = "KindAugenarzt"
        Me.KindAugenarztBindingSource.DataSource = Me.DataSet1
        '
        'KinderarztBindingSource
        '
        Me.KinderarztBindingSource.DataMember = "Kinderarzt"
        Me.KinderarztBindingSource.DataSource = Me.DataSet1
        '
        'KindFrauenarztBindingSource
        '
        Me.KindFrauenarztBindingSource.DataMember = "KindFrauenarzt"
        Me.KindFrauenarztBindingSource.DataSource = Me.DataSet1
        '
        'KindHautarztBindingSource
        '
        Me.KindHautarztBindingSource.DataMember = "KindHautarzt"
        Me.KindHautarztBindingSource.DataSource = Me.DataSet1
        '
        'KindHNOBindingSource
        '
        Me.KindHNOBindingSource.DataMember = "KindHNO"
        Me.KindHNOBindingSource.DataSource = Me.DataSet1
        '
        'KindKinderarztBindingSource
        '
        Me.KindKinderarztBindingSource.DataMember = "KindKinderarzt"
        Me.KindKinderarztBindingSource.DataSource = Me.DataSet1
        '
        'KindZahnarztBindingSource
        '
        Me.KindZahnarztBindingSource.DataMember = "KindZahnarzt"
        Me.KindZahnarztBindingSource.DataSource = Me.DataSet1
        '
        'ZahnarztBindingSource
        '
        Me.ZahnarztBindingSource.DataMember = "Zahnarzt"
        Me.ZahnarztBindingSource.DataSource = Me.DataSet1
        '
        'ArztUebersicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ArztUebersicht"
        Me.Size = New System.Drawing.Size(920, 550)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AugenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrauenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HautarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindAugenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KinderarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindFrauenarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindHautarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindHNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindKinderarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindZahnarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZahnarztBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
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
    Friend WithEvents FrauenarztBindingSource As BindingSource
    Friend WithEvents HautarztBindingSource As BindingSource
    Friend WithEvents HNOBindingSource As BindingSource
    Friend WithEvents KindAugenarztBindingSource As BindingSource
    Friend WithEvents KinderarztBindingSource As BindingSource
    Friend WithEvents KindFrauenarztBindingSource As BindingSource
    Friend WithEvents KindHautarztBindingSource As BindingSource
    Friend WithEvents KindHNOBindingSource As BindingSource
    Friend WithEvents KindKinderarztBindingSource As BindingSource
    Friend WithEvents KindZahnarztBindingSource As BindingSource
    Friend WithEvents ZahnarztBindingSource As BindingSource
End Class
