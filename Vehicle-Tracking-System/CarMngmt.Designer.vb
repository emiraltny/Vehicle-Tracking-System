<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarMngmt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarMngmt))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.PlateTextBox = New System.Windows.Forms.TextBox()
        Me.KMTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListViewContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ListViewContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(5, 21)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(229, 156)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PLAKA"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "KM"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NewButton)
        Me.GroupBox2.Controls.Add(Me.PlateTextBox)
        Me.GroupBox2.Controls.Add(Me.KMTextBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.AddButton)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(252, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 183)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "YENİ ARAÇ EKLE"
        '
        'NewButton
        '
        Me.NewButton.Enabled = False
        Me.NewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.NewButton.Location = New System.Drawing.Point(7, 111)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(141, 30)
        Me.NewButton.TabIndex = 5
        Me.NewButton.Text = "Yeni"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'PlateTextBox
        '
        Me.PlateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PlateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PlateTextBox.Location = New System.Drawing.Point(7, 38)
        Me.PlateTextBox.Name = "PlateTextBox"
        Me.PlateTextBox.Size = New System.Drawing.Size(141, 22)
        Me.PlateTextBox.TabIndex = 0
        '
        'KMTextBox
        '
        Me.KMTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.KMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.KMTextBox.Location = New System.Drawing.Point(7, 82)
        Me.KMTextBox.Name = "KMTextBox"
        Me.KMTextBox.Size = New System.Drawing.Size(141, 22)
        Me.KMTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Araç Güncel KMsi:"
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.AddButton.Location = New System.Drawing.Point(7, 146)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(141, 30)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Aracı Ekle"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Araç Plakası:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 183)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KAYITLI ARAÇLAR"
        '
        'ListViewContextMenu
        '
        Me.ListViewContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ListViewContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SilToolStripMenuItem})
        Me.ListViewContextMenu.Name = "ListViewContextMenu"
        Me.ListViewContextMenu.Size = New System.Drawing.Size(99, 30)
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Image = Global.VehicleTrackingSystem.My.Resources.Resources.remove
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(98, 26)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'CarMngmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 193)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CarMngmt"
        Me.Text = "Araç Yönetimi"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ListViewContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PlateTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListViewContextMenu As ContextMenuStrip
    Friend WithEvents SilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents KMTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NewButton As Button
End Class
