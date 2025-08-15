Imports System.IO
Imports Microsoft.Office.Interop

Public Class Form1
    Dim currentTime As DateTime

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionLabel.Text = My.Settings.version + "v"
        currentTime = DateTime.Now.ToString("dd/MM/yyyy")

        DaySelector.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DaySelector.Format = DateTimePickerFormat.Custom
        DaySelector.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "HH:mm"
        DateTimePicker3.CustomFormat = "HH:mm"
        DaySelector.CustomFormat = "dd/MM/yyyy"

        ResetInputs()
        SearchDayFunc()
        LoadItems("araclar")
        LoadItems("soforler")
        LoadItems("guvenlikler")
    End Sub

    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        CarMngmt.Close()
        DriverMngmt.Close()
        SecurityMngmt.Close()
        'ID'li kayıt zaten varsa güncelle
        For Each item As ListViewItem In ListView1.Items
            If item.Text = IDLabel.Text Then
                item.Selected = True
                If DriverSelector.Text = "" Or CarSelector.Text = "" Or FirstKMTextbox.Text.Trim = "" Or SecuritySelector.Text = "" Or LocationTextBox.Text.Trim = "" Then
                    MsgBox("Lütfen tüm boş alanları doldurun!", vbCritical, "Adalı")
                    Return
                End If
                If Not DateTimePicker2.Value.ToString("HH:mm") = DateTimePicker3.Value.ToString("HH:mm") Then
                    Dim num1 As Double
                    Dim num2 As Double
                    Double.TryParse(LastKMTextbox.Text, num1)
                    Double.TryParse(FirstKMTextbox.Text, num2)
                    If LastKMTextbox.Text = "" Then
                        ListView1.SelectedItems(0).SubItems(7).Text = "0"
                        TotalKMLabel.Text = "0"
                        ListView1.SelectedItems(0).SubItems(8).Text = TotalKMLabel.Text
                    ElseIf num1 = "0" Then
                        ListView1.SelectedItems(0).SubItems(6).Text = DateTimePicker3.Value.ToString("HH:mm")
                        ListView1.SelectedItems(0).SubItems(7).Text = "0"
                        TotalKMLabel.Text = FirstKMTextbox.Text
                        ListView1.SelectedItems(0).SubItems(8).Text = TotalKMLabel.Text
                        ListView1.SelectedItems(0).BackColor = Color.LightGreen
                    ElseIf num1 < num2 Then
                        MsgBox("Araç geliş kilometresi, araç çıkış kilometresinden küçük olamaz!", vbCritical, "Adalı")
                        LastKMTextbox.Select()
                        Return
                    Else
                        'Araba km güncelle
                        For Each car As ListViewItem In CarList.Items
                            If car.SubItems(1).Text = CarSelector.Text Then
                                car.SubItems(2).Text = LastKMTextbox.Text
                                Exit For
                            End If
                        Next
                        ListView1.SelectedItems(0).SubItems(7).Text = LastKMTextbox.Text
                        Try
                            TotalKMLabel.Text = LastKMTextbox.Text - FirstKMTextbox.Text
                        Catch
                            TotalKMLabel.Text = 0
                        End Try
                        ListView1.SelectedItems(0).SubItems(8).Text = TotalKMLabel.Text
                    End If
                    ListView1.SelectedItems(0).BackColor = Color.LightGreen
                    ListView1.SelectedItems(0).SubItems(6).Text = DateTimePicker3.Value.ToString("HH:mm")
                Else
                    If Not (LastKMTextbox.Text = "" Or LastKMTextbox.Text = "0") Then
                        MsgBox("Araç çıkış saati ve dakikası, giriş saati ve dakikasıyla aynı olduğu için Araç Geliş KM'si kaydedilmedi!", vbInformation, "Adalı")
                    End If
                End If
                ListView1.SelectedItems(0).SubItems(1).Text = DaySelector.Value.ToString("dd/MM/yyyy")
                ListView1.SelectedItems(0).SubItems(2).Text = DriverSelector.Text
                ListView1.SelectedItems(0).SubItems(3).Text = CarSelector.Text
                ListView1.SelectedItems(0).SubItems(4).Text = DateTimePicker2.Value.ToString("HH:mm")
                ListView1.SelectedItems(0).SubItems(5).Text = FirstKMTextbox.Text
                ListView1.SelectedItems(0).SubItems(9).Text = SecuritySelector.Text
                ListView1.SelectedItems(0).SubItems(10).Text = LocationTextBox.Text.Trim
                SaveData()
                SaveItems("soforler", DriverList)
                SaveItems("araclar", CarList)
                SaveItems("guvenlikler", SecurityList)
                ListView1.Select()
                Return
            End If
        Next
        'Yoksa yeni oluştur
        If DriverSelector.Text = "" Or CarSelector.Text = "" Or FirstKMTextbox.Text.Trim = "" Or SecuritySelector.Text = "" Or LocationTextBox.Text.Trim = "" Then
            MsgBox("Lütfen tüm boş alanları doldurun!", vbCritical, "Adalı")
            Return
        End If
        Dim counter As Integer = ListView1.Items.Count
        ListView1.Items.Add(counter)
        ListView1.Items(counter).SubItems.Add(DaySelector.Value.ToString("dd/MM/yyyy"))
        ListView1.Items(counter).SubItems.Add(DriverSelector.Text)
        ListView1.Items(counter).SubItems.Add(CarSelector.Text)
        ListView1.Items(counter).SubItems.Add(DateTimePicker2.Value.ToString("HH:mm"))
        ListView1.Items(counter).SubItems.Add(FirstKMTextbox.Text)
        ListView1.Items(counter).SubItems.Add("-")
        ListView1.Items(counter).SubItems.Add("-")
        ListView1.Items(counter).SubItems.Add("-")
        ListView1.Items(counter).SubItems.Add(SecuritySelector.Text)
        ListView1.Items(counter).SubItems.Add(LocationTextBox.Text.Trim)
        ListView1.Items(counter).BackColor = Color.LightPink
        SelectLastItem()
        SaveData()
        ListView1.Select()
    End Sub

    Private Sub SelectLastItem()
        If ListView1.Items.Count > 0 Then
            ListView1.Items(ListView1.Items.Count - 1).Selected = True
            ListView1.EnsureVisible(ListView1.Items.Count - 1)
        End If
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        'DaySelector.Value = DateTime.Now
        DriverSelector.SelectedItem = Nothing
        CarSelector.SelectedItem = Nothing
        FirstKMTextbox.Text = ""
        DateTimePicker2.Value = DateTime.Now
        'İlk çıkış olacağı için aktif olmayacaklar
        DateTimePicker3.Value = DateTime.Now
        LastKMTextbox.Text = ""
        GroupBox3.Enabled = False

        TotalKMLabel.Text = "-"
        SecuritySelector.SelectedItem = Nothing
        LocationTextBox.Text = ""
        IDLabel.Text = ListView1.Items.Count
        AddUpdateButton.Text = "Kaydı Ekle"
        For Each item As ListViewItem In ListView1.SelectedItems
            item.Selected = False
        Next
        AddUpdateButton.Enabled = True
        NewButton.Enabled = False
        DeleteButton.Enabled = False
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            AddUpdateButton.Enabled = True
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            DriverSelector.Text = selectedItem.SubItems(2).Text
            CarSelector.Text = selectedItem.SubItems(3).Text
            SecuritySelector.Text = selectedItem.SubItems(9).Text
            DaySelector.Value = DateTime.Parse(selectedItem.SubItems(1).Text)
            FirstKMTextbox.Text = selectedItem.SubItems(5).Text
            Dim timeValue As DateTime
            DateTime.TryParseExact(selectedItem.SubItems(4).Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, timeValue)
            DateTimePicker2.Value = timeValue
            LastKMTextbox.Text = ""
            DateTimePicker3.Value = DateTimePicker2.Value
            If Not selectedItem.SubItems(6).Text = "-" Then
                DateTime.TryParseExact(selectedItem.SubItems(6).Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, timeValue)
                DateTimePicker3.Value = timeValue
                If Not selectedItem.SubItems(7).Text = "0" Then
                    LastKMTextbox.Text = selectedItem.SubItems(7).Text
                Else
                    LastKMTextbox.Text = "0"
                End If
            End If
            TotalKMLabel.Text = selectedItem.SubItems(8).Text
            LocationTextBox.Text = selectedItem.SubItems(10).Text
            IDLabel.Text = selectedItem.Text

            GroupBox3.Enabled = True
            AddUpdateButton.Text = "Kaydı Güncelle"
            NewButton.Enabled = True
            DeleteButton.Enabled = True

            ' Datalar kayıp mı kontrol et
            If Not DriverSelector.Text = selectedItem.SubItems(2).Text Then
                MsgBox("Bu kayıttaki şoför, kayıtlı şoförlerde bulunmadığı için düzenlenemez!", vbCritical, "Adalı")
                AddUpdateButton.Enabled = False
                Return
            End If
            If Not CarSelector.Text = selectedItem.SubItems(3).Text Then
                MsgBox("Bu kayıttaki aracın plakası, kayıtlı araçlarda bulunmadığı için düzenlenemez!", vbCritical, "Adalı")
                AddUpdateButton.Enabled = False
                Return
            End If
            If Not SecuritySelector.Text = selectedItem.SubItems(9).Text Then
                MsgBox("Bu kayıttaki güvenlik, kayıtlı güvenliklerde bulunmadığı için düzenlenemez!", vbCritical, "Adalı")
                AddUpdateButton.Enabled = False
                Return
            End If
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show(ListView1.SelectedItems(0).Text + " ID'li kaydı silmek istediğinize emin misiniz?", "Adalı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ListView1.Items.Remove(ListView1.SelectedItems(0))
                'counter = counter - 1
                Dim newCounter As Integer = 0
                For Each item As ListViewItem In ListView1.Items
                    item.Text = newCounter
                    newCounter += 1
                Next
                SaveData()
                ResetAll()
            End If
        Else
            MsgBox("Lütfen silmek için bir kayıt seçin.", vbInformation, "Adalı")
        End If
    End Sub

    Private Sub ResetInputs()
        DaySelector.Value = currentTime
        DriverSelector.SelectedItem = Nothing
        CarSelector.SelectedItem = Nothing
        FirstKMTextbox.Text = ""
        DateTimePicker2.Value = DateTime.Now
        'İlk çıkış olacağı için aktif olmayacaklar
        DateTimePicker3.Value = DateTime.Now
        LastKMTextbox.Text = ""
        GroupBox3.Enabled = False

        TotalKMLabel.Text = "-"
        SecuritySelector.SelectedItem = Nothing
        LocationTextBox.Text = ""
        IDLabel.Text = ListView1.Items.Count
        AddUpdateButton.Enabled = True
    End Sub

    Private Sub ResetAll()
        ResetInputs()
        AddUpdateButton.Text = "Kaydı Ekle"
        NewButton.Enabled = False
        DeleteButton.Enabled = False
    End Sub

    Private Sub DışaAktarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DışaAktarToolStripMenuItem.Click
        Try
            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
            Dim worksheet As Excel.Worksheet = workbook.Sheets(1)

            ' Başlıkları ekle
            For i As Integer = 0 To ListView1.Columns.Count - 1
                Dim headerCell As Excel.Range = worksheet.Cells(1, i + 1)
                headerCell.Value = ListView1.Columns(i).Text
                headerCell.Font.Bold = True
                headerCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                headerCell.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)
                headerCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                headerCell.RowHeight = 30
            Next

            ' Verileri ekle
            For i As Integer = 0 To ListView1.Items.Count - 1
                For j As Integer = 0 To ListView1.Items(i).SubItems.Count - 1
                    Dim dataCell As Excel.Range = worksheet.Cells(i + 2, j + 1)
                    dataCell.Value = ListView1.Items(i).SubItems(j).Text
                    dataCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    If ListView1.Items(i).SubItems(7).Text = "-" Then
                        dataCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightPink)
                    Else
                        dataCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen)
                    End If
                    dataCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                Next
            Next

            ' Sütunları genişlet
            worksheet.Columns.AutoFit()

            ' Excel'i göster
            excelApp.Visible = True

            ' Temizlik
            workbook = Nothing
            worksheet = Nothing
            excelApp = Nothing
        Catch ex As Exception
            MsgBox("Dışa aktarmada bir hata oluştu!" & vbNewLine & "Excel bilgisayrınızda yüklü olmayabilir." & vbNewLine & "HATA: " & ex.Message, vbCritical, "Adalı")
        End Try
    End Sub

    Private Sub SaveData()
        Dim savesFolderPath As String = Path.Combine(Application.StartupPath, "kayitlar")
        ' kayitlar klasörünün var olup olmadığını kontrol et
        If Not Directory.Exists(savesFolderPath) Then
            ' Klasör yoksa oluştur
            Directory.CreateDirectory(savesFolderPath)
        End If
        Dim filePath As String = Path.Combine(savesFolderPath, DaySelector.Value.ToString("dd/MM/yyyy") + ".txt")
        ' ListView'deki öğeleri dışarı aktarma
        Try
            Using writer As New StreamWriter(filePath)
                For Each item As ListViewItem In ListView1.Items
                    ' Item'ları ve alt öğeleri yaz
                    Dim line As String = String.Join(", ", item.SubItems.Cast(Of ListViewItem.ListViewSubItem)().Select(Function(subItem) subItem.Text))
                    writer.WriteLine(line)
                Next
            End Using
        Catch ex As Exception
            MsgBox("Bir hata oluştu: " & ex.Message, vbCritical, "Adalı")
        End Try
    End Sub

    Private Sub SearchDayFunc()
        ' Önce ListView'i temizle
        ListView1.Items.Clear()
        Dim savesFolderPath As String = Path.Combine(Application.StartupPath, "kayitlar")
        ' kayitlar klasörünün var olup olmadığını kontrol et
        If Not Directory.Exists(savesFolderPath) Then
            ' Klasör yoksa oluştur
            Directory.CreateDirectory(savesFolderPath)
            Return
        End If
        ' O günün dosyası var mı kontrol et
        Dim folderPath As String = Path.Combine(Application.StartupPath, "kayitlar")
        Dim filePath As String = Path.Combine(folderPath, DaySelector.Value.ToString("dd/MM/yyyy") + ".txt")
        If Not File.Exists(Path.Combine(filePath)) Then
            Return
        End If
        Try
            ' Dosyayı oku
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    ' Satırı virgüllere göre ayır
                    Dim values As String() = line.Split(New String() {", "}, StringSplitOptions.None)
                    ' Yeni bir ListViewItem oluştur
                    Dim listViewItem As New ListViewItem(values(0)) ' İlk değer ana öğe olarak eklenir
                    ' Diğer değerleri alt öğeler olarak ekle
                    For i As Integer = 1 To values.Length - 1
                        listViewItem.SubItems.Add(values(i))
                    Next
                    ' ListView'e ekle
                    ListView1.Items.Add(listViewItem)
                    If Not listViewItem.SubItems(7).Text = "-" Then
                        listViewItem.BackColor = Color.LightGreen
                    Else
                        listViewItem.BackColor = Color.LightPink
                    End If
                End While
                IDLabel.Text = ListView1.Items.Count
            End Using
        Catch ex As Exception
            MsgBox("Bir hata oluştu: " & ex.Message, vbCritical, "Adalı")
        End Try
    End Sub

    Private Sub DaySelector_ValueChanged(sender As Object, e As EventArgs) Handles DaySelector.ValueChanged
        If Not currentTime = DaySelector.Value.ToString("dd/MM/yyyy") Then
            SearchDayFunc()
            DriverSelector.SelectedItem = Nothing
            CarSelector.SelectedItem = Nothing
            FirstKMTextbox.Text = ""
            LastKMTextbox.Text = ""
            SecuritySelector.SelectedItem = Nothing
            LocationTextBox.Text = ""
            TotalKMLabel.Text = "-"
            IDLabel.Text = ListView1.Items.Count
            DateTimePicker2.Value = DateTime.Now
            DateTimePicker3.Value = DateTime.Now
            GroupBox3.Enabled = False
            AddUpdateButton.Text = "Kaydı Ekle"
        End If
        currentTime = DaySelector.Value.ToString("dd/MM/yyyy")
    End Sub

    ' Sadece sayı girmesine izin ver
    Private Sub FirstKMTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstKMTextbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub LastKMTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastKMTextbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub VersionLabel_MouseEnter(sender As Object, e As EventArgs) Handles VersionLabel.MouseEnter
        VersionLabel.ForeColor = Color.DarkOrange
        InfoLabel.Visible = True
    End Sub

    Private Sub VersionLabel_MouseLeave(sender As Object, e As EventArgs) Handles VersionLabel.MouseLeave
        VersionLabel.ForeColor = Color.Black
        InfoLabel.Visible = False
    End Sub

    Private Sub ListView1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim item As ListViewItem = ListView1.GetItemAt(e.X, e.Y)
            If item IsNot Nothing Then
                ListView1.ContextMenuStrip = ListViewContextMenu
                SilToolStripMenuItem.Enabled = True
                ListView1.ContextMenuStrip.Show(ListView1, e.Location)
                ListView1.ContextMenuStrip.Tag = item
            Else
                ListView1.ContextMenuStrip = ListViewContextMenu
                SilToolStripMenuItem.Enabled = False
                ListView1.ContextMenuStrip.Show(ListView1, e.Location)
                ListView1.ContextMenuStrip.Tag = item
            End If
        End If

        Dim hitTest As ListViewHitTestInfo = ListView1.HitTest(e.X, e.Y)
        If hitTest.Item Is Nothing Then
            If NewButton.Enabled = False Then
                Return
            End If
            ResetAll()
        End If
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        Dim item As ListViewItem = CType(ListView1.ContextMenuStrip.Tag, ListViewItem)
        If item IsNot Nothing Then
            Dim result As DialogResult = MessageBox.Show(ListView1.SelectedItems(0).Text + " ID'li kaydı silmek istediğinize emin misiniz?", "Adalı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ListView1.Items.Remove(item)
                Dim newCounter As Integer = 0
                For Each items As ListViewItem In ListView1.Items
                    items.Text = newCounter
                    newCounter += 1
                Next
                SaveData()
                ResetAll()
            End If
        End If
    End Sub

    Private Sub AraçYönetimiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AraçYönetimiToolStripMenuItem.Click
        CarMngmt.Show()
        CarMngmt.BringToFront()
    End Sub
    Private Sub ŞoförYönetimiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞoförYönetimiToolStripMenuItem.Click
        DriverMngmt.Show()
        DriverMngmt.BringToFront()
    End Sub
    Private Sub GüvenlikYönetimiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GüvenlikYönetimiToolStripMenuItem.Click
        SecurityMngmt.Show()
        SecurityMngmt.BringToFront()
    End Sub

    Private Sub CarSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarSelector.SelectedIndexChanged
        If CarSelector.Text <> String.Empty Then
            For Each car As ListViewItem In CarList.Items
                If car.SubItems(1).Text = CarSelector.Text Then
                    FirstKMTextbox.Text = car.SubItems(2).Text
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub DriverSelector_Click(sender As Object, e As EventArgs) Handles DriverSelector.Click
        If DriverSelector.Items.Count <= 0 Then
            MsgBox("Kayıtlı herhangi bir şoför bulunmamaktadır, lütfen bir şoför ekleyin.", vbInformation, "Adalı")
            DriverMngmt.Show()
        End If
    End Sub
    Private Sub CarSelector_Click(sender As Object, e As EventArgs) Handles CarSelector.Click
        If CarSelector.Items.Count <= 0 Then
            MsgBox("Kayıtlı herhangi bir araç bulunmamaktadır, lütfen bir araç ekleyin.", vbInformation, "Adalı")
            CarMngmt.Show()
        End If
    End Sub
    Private Sub SecuritySelector_Click(sender As Object, e As EventArgs) Handles SecuritySelector.Click
        If SecuritySelector.Items.Count <= 0 Then
            MsgBox("Kayıtlı herhangi bir güvenlik bulunmamaktadır, lütfen bir güvenlik ekleyin.", vbInformation, "Adalı")
            SecurityMngmt.Show()
        End If
    End Sub

    Private Sub SaveItems(itemName As String, itemList As ListView)
        Dim savesFolderPath As String = Path.Combine(Application.StartupPath, itemName)
        If Not Directory.Exists(savesFolderPath) Then
            Directory.CreateDirectory(savesFolderPath)
        End If
        Dim filePath As String = Path.Combine(savesFolderPath, itemName + ".txt")
        Try
            Using writer As New StreamWriter(filePath)
                For Each item As ListViewItem In itemList.Items
                    Dim line As String = String.Join(", ", item.SubItems.Cast(Of ListViewItem.ListViewSubItem)().Select(Function(subItem) subItem.Text))
                    writer.WriteLine(line)
                Next
            End Using
        Catch ex As Exception
            MsgBox("Bir hata oluştu: " & ex.Message, vbCritical, "Adalı")
        End Try
    End Sub
    Public Sub LoadItems(itemName As String)
        If itemName = "araclar" Then
            CarList.Items.Clear()
            CarSelector.Items.Clear()
        ElseIf itemName = "soforler" Then
            DriverList.Items.Clear()
            DriverSelector.Items.Clear()
        ElseIf itemName = "guvenlikler" Then
            SecurityList.Items.Clear()
            SecuritySelector.Items.Clear()
        End If
        Dim savesFolderPath As String = Path.Combine(Application.StartupPath, itemName)
        If Not Directory.Exists(savesFolderPath) Then
            Directory.CreateDirectory(savesFolderPath)
            Return
        End If
        Dim folderPath As String = Path.Combine(Application.StartupPath, itemName)
        Dim filePath As String = Path.Combine(folderPath, itemName + ".txt")
        If Not File.Exists(Path.Combine(filePath)) Then
            Return
        End If
        Try
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values As String() = line.Split(New String() {", "}, StringSplitOptions.None)
                    Dim listViewItem As New ListViewItem(values(0))
                    For i As Integer = 1 To values.Length - 1
                        listViewItem.SubItems.Add(values(i))
                    Next
                    If itemName = "araclar" Then
                        CarList.Items.Add(listViewItem)
                        CarSelector.Items.Add(listViewItem.SubItems(1).Text)
                    ElseIf itemName = "soforler" Then
                        DriverList.Items.Add(listViewItem)
                        DriverSelector.Items.Add(listViewItem.SubItems(1).Text)
                    ElseIf itemName = "guvenlikler" Then
                        SecurityList.Items.Add(listViewItem)
                        SecuritySelector.Items.Add(listViewItem.SubItems(1).Text)
                    End If
                End While
            End Using
        Catch ex As Exception
            MsgBox("Bir hata oluştu: " & ex.Message, vbCritical, "Adalı")
        End Try
    End Sub

    Private Sub YenileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YenileToolStripMenuItem.Click
        SearchDayFunc()
        ResetInputs()
    End Sub
End Class
