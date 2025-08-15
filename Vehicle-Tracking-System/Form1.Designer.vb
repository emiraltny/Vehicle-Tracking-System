<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.IDColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.TotalKMLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.AddUpdateButton = New System.Windows.Forms.Button()
        Me.DaySelector = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.LastKMTextbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SecuritySelector = New System.Windows.Forms.ComboBox()
        Me.DriverSelector = New System.Windows.Forms.ComboBox()
        Me.CarSelector = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FirstKMTextbox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DışaAktarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YönetimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AraçYönetimiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ŞoförYönetimiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GüvenlikYönetimiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.ListViewContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YenileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarList = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DriverList = New System.Windows.Forms.ListView()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SecurityList = New System.Windows.Forms.ListView()
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ListViewContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDColumn, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(196, 36)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(995, 663)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'IDColumn
        '
        Me.IDColumn.Text = "ID"
        Me.IDColumn.Width = 40
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "TARİH"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ŞOFÖR ADI"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PLAKA"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ÇIKIŞ"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ÇIKIŞ KM"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 66
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "GİRİŞ"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "GİRİŞ KM"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "YAPILAN KM"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 93
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "GÜVENLİK ADI"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 150
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "GİDECEĞİ YER"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 109
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IDLabel)
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.TotalKMLabel)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.NewButton)
        Me.GroupBox1.Controls.Add(Me.AddUpdateButton)
        Me.GroupBox1.Controls.Add(Me.DaySelector)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 670)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(28, 557)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(11, 16)
        Me.IDLabel.TabIndex = 26
        Me.IDLabel.Text = "-"
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.Red
        Me.DeleteButton.Location = New System.Drawing.Point(94, 589)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(84, 32)
        Me.DeleteButton.TabIndex = 12
        Me.DeleteButton.Text = "Sil"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'TotalKMLabel
        '
        Me.TotalKMLabel.AutoSize = True
        Me.TotalKMLabel.Location = New System.Drawing.Point(91, 530)
        Me.TotalKMLabel.Name = "TotalKMLabel"
        Me.TotalKMLabel.Size = New System.Drawing.Size(11, 16)
        Me.TotalKMLabel.TabIndex = 18
        Me.TotalKMLabel.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 557)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 530)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Yapılan KM:"
        '
        'NewButton
        '
        Me.NewButton.Enabled = False
        Me.NewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.NewButton.Location = New System.Drawing.Point(6, 589)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(82, 32)
        Me.NewButton.TabIndex = 11
        Me.NewButton.Text = "Yeni"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.AddUpdateButton.Location = New System.Drawing.Point(6, 627)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(172, 32)
        Me.AddUpdateButton.TabIndex = 10
        Me.AddUpdateButton.Text = "Kaydı Ekle"
        Me.AddUpdateButton.UseVisualStyleBackColor = True
        '
        'DaySelector
        '
        Me.DaySelector.CustomFormat = ""
        Me.DaySelector.Location = New System.Drawing.Point(6, 31)
        Me.DaySelector.Name = "DaySelector"
        Me.DaySelector.Size = New System.Drawing.Size(172, 22)
        Me.DaySelector.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox3.Controls.Add(Me.LastKMTextbox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 401)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(172, 121)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ARAÇ GİRİŞİ"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = ""
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker3.Location = New System.Drawing.Point(6, 45)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.ShowUpDown = True
        Me.DateTimePicker3.Size = New System.Drawing.Size(160, 22)
        Me.DateTimePicker3.TabIndex = 8
        '
        'LastKMTextbox
        '
        Me.LastKMTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LastKMTextbox.Location = New System.Drawing.Point(6, 91)
        Me.LastKMTextbox.Name = "LastKMTextbox"
        Me.LastKMTextbox.Size = New System.Drawing.Size(160, 22)
        Me.LastKMTextbox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Araç Giriş Saati:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Araç Giriş KM:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tarih:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.SecuritySelector)
        Me.GroupBox2.Controls.Add(Me.DriverSelector)
        Me.GroupBox2.Controls.Add(Me.CarSelector)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.FirstKMTextbox)
        Me.GroupBox2.Controls.Add(Me.LocationTextBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 336)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ARAÇ ÇIKIŞI"
        '
        'SecuritySelector
        '
        Me.SecuritySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SecuritySelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SecuritySelector.FormattingEnabled = True
        Me.SecuritySelector.Location = New System.Drawing.Point(6, 253)
        Me.SecuritySelector.Name = "SecuritySelector"
        Me.SecuritySelector.Size = New System.Drawing.Size(160, 24)
        Me.SecuritySelector.TabIndex = 6
        '
        'DriverSelector
        '
        Me.DriverSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DriverSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DriverSelector.FormattingEnabled = True
        Me.DriverSelector.Location = New System.Drawing.Point(6, 46)
        Me.DriverSelector.Name = "DriverSelector"
        Me.DriverSelector.Size = New System.Drawing.Size(160, 24)
        Me.DriverSelector.TabIndex = 2
        '
        'CarSelector
        '
        Me.CarSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CarSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CarSelector.FormattingEnabled = True
        Me.CarSelector.Location = New System.Drawing.Point(6, 98)
        Me.CarSelector.Name = "CarSelector"
        Me.CarSelector.Size = New System.Drawing.Size(160, 24)
        Me.CarSelector.TabIndex = 3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 150)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowUpDown = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(160, 22)
        Me.DateTimePicker2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Araç Plakası:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Araç Çıkış Saati:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Araç Çıkış KM:"
        '
        'FirstKMTextbox
        '
        Me.FirstKMTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FirstKMTextbox.Location = New System.Drawing.Point(6, 201)
        Me.FirstKMTextbox.Name = "FirstKMTextbox"
        Me.FirstKMTextbox.Size = New System.Drawing.Size(160, 22)
        Me.FirstKMTextbox.TabIndex = 5
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(6, 305)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(160, 22)
        Me.LocationTextBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Şoför Adı:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Gideceği Yer:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Güvenlik Adı:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.YönetimToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1196, 30)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DışaAktarToolStripMenuItem})
        Me.DosyaToolStripMenuItem.Image = Global.VehicleTrackingSystem.My.Resources.Resources.document
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(84, 26)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'DışaAktarToolStripMenuItem
        '
        Me.DışaAktarToolStripMenuItem.Image = Global.VehicleTrackingSystem.My.Resources.Resources.sheet
        Me.DışaAktarToolStripMenuItem.Name = "DışaAktarToolStripMenuItem"
        Me.DışaAktarToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.DışaAktarToolStripMenuItem.Text = "Günü Dışa Aktar"
        '
        'YönetimToolStripMenuItem
        '
        Me.YönetimToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AraçYönetimiToolStripMenuItem, Me.ŞoförYönetimiToolStripMenuItem, Me.GüvenlikYönetimiToolStripMenuItem})
        Me.YönetimToolStripMenuItem.Image = Global.VehicleTrackingSystem.My.Resources.Resources.cogwheel
        Me.YönetimToolStripMenuItem.Name = "YönetimToolStripMenuItem"
        Me.YönetimToolStripMenuItem.Size = New System.Drawing.Size(97, 26)
        Me.YönetimToolStripMenuItem.Text = "Yönetim"
        '
        'AraçYönetimiToolStripMenuItem
        '
        Me.AraçYönetimiToolStripMenuItem.Image = Global.VehicleTrackingSystem.My.Resources.Resources.car
        Me.AraçYönetimiToolStripMenuItem.Name = "AraçYönetimiToolStripMenuItem"
        Me.AraçYönetimiToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.AraçYönetimiToolStripMenuItem.Text = "Araç Yönetimi"
        '
        'ŞoförYönetimiToolStripMenuItem
        '
        Me.ŞoförYönetimiToolStripMenuItem.Image = Global.VehicleTrackingSystem.My.Resources.Resources.driver
        Me.ŞoförYönetimiToolStripMenuItem.Name = "ŞoförYönetimiToolStripMenuItem"
        Me.ŞoförYönetimiToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.ŞoförYönetimiToolStripMenuItem.Text = "Şoför Yönetimi"
        '
        'GüvenlikYönetimiToolStripMenuItem
        '
        Me.GüvenlikYönetimiToolStripMenuItem.Image = Global.VehicleTrackingSystem.My.Resources.Resources.guard
        Me.GüvenlikYönetimiToolStripMenuItem.Name = "GüvenlikYönetimiToolStripMenuItem"
        Me.GüvenlikYönetimiToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.GüvenlikYönetimiToolStripMenuItem.Text = "Güvenlik Yönetimi"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.VersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(1155, 5)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(31, 16)
        Me.VersionLabel.TabIndex = 3
        Me.VersionLabel.Text = "1.0v"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.InfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.InfoLabel.Location = New System.Drawing.Point(875, 5)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(253, 16)
        Me.InfoLabel.TabIndex = 4
        Me.InfoLabel.Text = "Yusuf Emir Altunay (+905079675085)"
        Me.InfoLabel.Visible = False
        '
        'ListViewContextMenu
        '
        Me.ListViewContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ListViewContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SilToolStripMenuItem, Me.YenileToolStripMenuItem})
        Me.ListViewContextMenu.Name = "ListViewContextMenu"
        Me.ListViewContextMenu.Size = New System.Drawing.Size(122, 56)
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Image = Global.VehicleTrackingSystem.My.Resources.Resources.remove
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'YenileToolStripMenuItem
        '
        Me.YenileToolStripMenuItem.Image = Global.VehicleTrackingSystem.My.Resources.Resources.loading_arrow
        Me.YenileToolStripMenuItem.Name = "YenileToolStripMenuItem"
        Me.YenileToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.YenileToolStripMenuItem.Text = "Yenile"
        '
        'CarList
        '
        Me.CarList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.CarList.Cursor = System.Windows.Forms.Cursors.Default
        Me.CarList.FullRowSelect = True
        Me.CarList.HideSelection = False
        Me.CarList.Location = New System.Drawing.Point(261, 0)
        Me.CarList.MultiSelect = False
        Me.CarList.Name = "CarList"
        Me.CarList.Size = New System.Drawing.Size(181, 28)
        Me.CarList.TabIndex = 27
        Me.CarList.UseCompatibleStateImageBehavior = False
        Me.CarList.View = System.Windows.Forms.View.Details
        Me.CarList.Visible = False
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID"
        Me.ColumnHeader11.Width = 40
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "PLAKA"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 69
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "KM"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DriverList
        '
        Me.DriverList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader15})
        Me.DriverList.Cursor = System.Windows.Forms.Cursors.Default
        Me.DriverList.FullRowSelect = True
        Me.DriverList.HideSelection = False
        Me.DriverList.Location = New System.Drawing.Point(448, 0)
        Me.DriverList.MultiSelect = False
        Me.DriverList.Name = "DriverList"
        Me.DriverList.Size = New System.Drawing.Size(206, 28)
        Me.DriverList.TabIndex = 28
        Me.DriverList.UseCompatibleStateImageBehavior = False
        Me.DriverList.View = System.Windows.Forms.View.Details
        Me.DriverList.Visible = False
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ID"
        Me.ColumnHeader14.Width = 40
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "ŞOFÖR"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 150
        '
        'SecurityList
        '
        Me.SecurityList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader17})
        Me.SecurityList.Cursor = System.Windows.Forms.Cursors.Default
        Me.SecurityList.FullRowSelect = True
        Me.SecurityList.HideSelection = False
        Me.SecurityList.Location = New System.Drawing.Point(660, 0)
        Me.SecurityList.MultiSelect = False
        Me.SecurityList.Name = "SecurityList"
        Me.SecurityList.Size = New System.Drawing.Size(209, 28)
        Me.SecurityList.TabIndex = 29
        Me.SecurityList.UseCompatibleStateImageBehavior = False
        Me.SecurityList.View = System.Windows.Forms.View.Details
        Me.SecurityList.Visible = False
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "ID"
        Me.ColumnHeader16.Width = 40
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "GÜVENLİK"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader17.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 704)
        Me.Controls.Add(Me.SecurityList)
        Me.Controls.Add(Me.DriverList)
        Me.Controls.Add(Me.CarList)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Tracking System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ListViewContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DaySelector As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FirstKMTextbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LastKMTextbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AddUpdateButton As Button
    Friend WithEvents TotalKMLabel As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NewButton As Button
    Friend WithEvents IDColumn As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents IDLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DışaAktarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionLabel As Label
    Friend WithEvents InfoLabel As Label
    Friend WithEvents ListViewContextMenu As ContextMenuStrip
    Friend WithEvents SilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YönetimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AraçYönetimiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarList As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents CarSelector As ComboBox
    Friend WithEvents DriverList As ListView
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents DriverSelector As ComboBox
    Friend WithEvents ŞoförYönetimiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GüvenlikYönetimiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecurityList As ListView
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents SecuritySelector As ComboBox
    Friend WithEvents YenileToolStripMenuItem As ToolStripMenuItem
End Class
