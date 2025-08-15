Imports System.IO

Public Class DriverMngmt

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If DriverTextBox.Text.Trim = "" Then
            MsgBox("Lütfen şoför adı girin!", vbCritical, "Adalı")
            Return
        End If
        Dim counter As Integer = ListView1.Items.Count
        ListView1.Items.Add(counter)
        ListView1.Items(counter).SubItems.Add(DriverTextBox.Text.Trim)
        SelectLastItem()
        SaveData()
        ListView1.Select()
        DriverTextBox.Text = ""
        Form1.LoadItems("soforler")
    End Sub

    Private Sub SelectLastItem()
        If ListView1.Items.Count > 0 Then
            ListView1.Items(ListView1.Items.Count - 1).Selected = True
            ListView1.EnsureVisible(ListView1.Items.Count - 1)
        End If
    End Sub

    Private Sub SaveData()
        Dim savesFolderPath As String = Path.Combine(Application.StartupPath, "soforler")
        ' soforler klasörünün var olup olmadığını kontrol et
        If Not Directory.Exists(savesFolderPath) Then
            ' Klasör yoksa oluştur
            Directory.CreateDirectory(savesFolderPath)
        End If
        Dim filePath As String = Path.Combine(savesFolderPath, "soforler.txt")
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
        Dim savesFolderPath As String = Path.Combine(Application.StartupPath, "soforler")
        ' soforler klasörünün var olup olmadığını kontrol et
        If Not Directory.Exists(savesFolderPath) Then
            ' Klasör yoksa oluştur
            Directory.CreateDirectory(savesFolderPath)
            Return
        End If
        Dim folderPath As String = Path.Combine(Application.StartupPath, "soforler")
        Dim filePath As String = Path.Combine(folderPath, "soforler.txt")
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

    Private Sub DriverMngmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        Dim item As ListViewItem = CType(ListView1.ContextMenuStrip.Tag, ListViewItem)
        If item IsNot Nothing Then
            Dim result As DialogResult = MessageBox.Show(ListView1.SelectedItems(0).SubItems(1).Text + " adlı şoförü silmek istediğinize emin misiniz?", "Adalı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ListView1.Items.Remove(item)
                Dim newCounter As Integer = 0
                For Each items As ListViewItem In ListView1.Items
                    items.Text = newCounter
                    newCounter += 1
                Next
                SaveData()
                Form1.LoadItems("soforler")
            End If
        End If
    End Sub
End Class