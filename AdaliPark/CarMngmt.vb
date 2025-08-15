Imports System.IO

Public Class CarMngmt
    Dim selectedId As Integer = -1

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        ' Mevcut aracı güncelle
        If Not selectedId = -1 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            selectedItem.Selected = True
            If PlateTextBox.Text.Trim = "" Or KMTextBox.Text.Trim = "" Then
                MsgBox("Lütfen tüm boş alanları doldurun!", vbCritical, "Adalı")
                Return
            End If
            selectedItem.SubItems(1).Text = PlateTextBox.Text
            selectedItem.SubItems(2).Text = KMTextBox.Text
            SaveData()
            ListView1.Select()
            Form1.LoadItems("araclar")
            Return
        End If
        ' Yeni araç ekle
        If PlateTextBox.Text.Trim = "" Or KMTextBox.Text.Trim = "" Then
            MsgBox("Lütfen tüm boş alanları doldurun!", vbCritical, "Adalı")
            Return
        End If
        Dim counter As Integer = ListView1.Items.Count
        ListView1.Items.Add(counter)
        ListView1.Items(counter).SubItems.Add(PlateTextBox.Text.Trim)
        ListView1.Items(counter).SubItems.Add(KMTextBox.Text.Trim)
        SelectLastItem()
        SaveData()
        ListView1.Select()
        Form1.LoadItems("araclar")
    End Sub

    Private Sub SelectLastItem()
        If ListView1.Items.Count > 0 Then
            ListView1.Items(ListView1.Items.Count - 1).Selected = True
            ListView1.EnsureVisible(ListView1.Items.Count - 1)
        End If
    End Sub

    Private Sub ResetInputs()
        PlateTextBox.Text = ""
        KMTextBox.Text = ""
        AddButton.Text = "Aracı Ekle"
        GroupBox2.Text = "YENİ ARAÇ EKLE"
        NewButton.Enabled = False
        selectedId = -1
    End Sub

    Private Sub SaveData()
        Dim savesFolderPath As String = Path.Combine(Application.StartupPath, "araclar")
        ' araclar klasörünün var olup olmadığını kontrol et
        If Not Directory.Exists(savesFolderPath) Then
            ' Klasör yoksa oluştur
            Directory.CreateDirectory(savesFolderPath)
        End If
        Dim filePath As String = Path.Combine(savesFolderPath, "araclar.txt")
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

    Private Sub LoadData()
        ' Önce ListView'i temizle
        ListView1.Items.Clear()
        Dim savesFolderPath As String = Path.Combine(Application.StartupPath, "araclar")
        ' araclar klasörünün var olup olmadığını kontrol et
        If Not Directory.Exists(savesFolderPath) Then
            ' Klasör yoksa oluştur
            Directory.CreateDirectory(savesFolderPath)
            Return
        End If
        Dim folderPath As String = Path.Combine(Application.StartupPath, "araclar")
        Dim filePath As String = Path.Combine(folderPath, "araclar.txt")
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
                End While
            End Using
        Catch ex As Exception
            MsgBox("Bir hata oluştu: " & ex.Message, vbCritical, "Adalı")
        End Try
    End Sub

    Private Sub CarMngmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub ListView1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim item As ListViewItem = ListView1.GetItemAt(e.X, e.Y)
            If item IsNot Nothing Then
                ListView1.ContextMenuStrip = ListViewContextMenu
                ListView1.ContextMenuStrip.Show(ListView1, e.Location)
                ListView1.ContextMenuStrip.Tag = item
            Else
                ' Eğer öğe yoksa bağlam menüsünü gizle
                ListView1.ContextMenuStrip = Nothing
            End If
        End If

        Dim hitTest As ListViewHitTestInfo = ListView1.HitTest(e.X, e.Y)
        If hitTest.Item Is Nothing Then
            If selectedId = -1 Then
                Return
            End If
            ResetInputs()
        End If
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        Dim item As ListViewItem = CType(ListView1.ContextMenuStrip.Tag, ListViewItem)
        If item IsNot Nothing Then
            Dim result As DialogResult = MessageBox.Show(ListView1.SelectedItems(0).SubItems(1).Text + " Plakalı aracı silmek istediğinize emin misiniz?", "Adalı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ListView1.Items.Remove(item)
                Dim newCounter As Integer = 0
                For Each items As ListViewItem In ListView1.Items
                    items.Text = newCounter
                    newCounter += 1
                Next
                SaveData()
                ResetInputs()
                Form1.LoadItems("araclar")
            End If
        End If
    End Sub

    Private Sub KMTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KMTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            PlateTextBox.Text = selectedItem.SubItems(1).Text
            KMTextBox.Text = selectedItem.SubItems(2).Text
            AddButton.Text = "Güncelle"
            GroupBox2.Text = "ARACI GÜNCELLE"
            NewButton.Enabled = True
            selectedId = selectedItem.Text
        End If
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        ResetInputs()
        ListView1.SelectedItems(0).Selected = False
    End Sub
End Class