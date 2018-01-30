<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Psycho
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Überschrift = New System.Windows.Forms.Label()
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.PsychoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PsychoTableAdapter = New WindowsApp2.DataSet1TableAdapters.PsychoTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.DataSet1TableAdapters.TableAdapterManager()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PsychoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Überschrift)
        Me.SplitContainer1.Size = New System.Drawing.Size(831, 521)
        Me.SplitContainer1.SplitterDistance = 159
        Me.SplitContainer1.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(592, 102)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 40)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Eintrag löschen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(344, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Eintrag bearbeiten"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(98, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Neuer Eintrag"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Überschrift
        '
        Me.Überschrift.Dock = System.Windows.Forms.DockStyle.Top
        Me.Überschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Überschrift.Location = New System.Drawing.Point(0, 0)
        Me.Überschrift.Name = "Überschrift"
        Me.Überschrift.Size = New System.Drawing.Size(831, 32)
        Me.Überschrift.TabIndex = 5
        Me.Überschrift.Text = "Psycho"
        Me.Überschrift.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PsychoBindingSource
        '
        Me.PsychoBindingSource.DataMember = "Psycho"
        Me.PsychoBindingSource.DataSource = Me.DataSet1
        '
        'PsychoTableAdapter
        '
        Me.PsychoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PsychoTableAdapter = Me.PsychoTableAdapter
        Me.TableAdapterManager.SchulBerichtTableAdapter = Nothing
        Me.TableAdapterManager.SchuleTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZahnarztTableAdapter = Nothing
        '
        'Psycho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Psycho"
        Me.Size = New System.Drawing.Size(831, 521)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PsychoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Überschrift As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents PsychoBindingSource As BindingSource
    Friend WithEvents PsychoTableAdapter As DataSet1TableAdapters.PsychoTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
