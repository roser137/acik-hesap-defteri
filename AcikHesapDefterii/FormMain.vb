Imports System.Windows.Forms
Imports System.Management
Imports System.IO
Public Class FormMain
    Private f_urunler As FormUrunler = Nothing
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        '  Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    Public mListesi As FormMusteriListesi
    Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not File.Exists("db.mdb") Then
            MessageBox.Show("Programı ilk defa çalıştırıldığınız tesipt edildi. Test verileriyle dolu bir veritabanı oluşturuluyor. Bunu sıfırlamak ve kendi kayıtlarınızı eklemek için yukardaki 'Veritabanını Sıfırla' seçeneğini kullanabilirsiniz. ", "Kurulum", MessageBoxButtons.OK, MessageBoxIcon.Information)
            File.Copy("vt/db.mdb", "db.mdb")
            MessageBox.Show("Veritabanınız başarı ile oluşturuldu. Artık programı kullanmaya başlanabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        

        StartDetection()
        ' ToolStrip.Hide()
        mListesi = New FormMusteriListesi
        mListesi.StartPosition = FormStartPosition.CenterScreen
        'mListesi.WindowState = FormWindowState.Maximized
        mListesi.MdiParent = Me
        mListesi.Show()
        ' Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÇıkışToolStripMenuItem.Click
        If MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub ÜrünlerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÜrünlerToolStripMenuItem.Click
        '  If f_urunler Is Nothing Then
        f_urunler = New FormUrunler
        f_urunler.MdiParent = Me
        ' End If
        f_urunler.Show()
    End Sub













    ''''''''''''''' otomatik kapatmaca
    Private WithEvents m_MediaConnectWatcher As ManagementEventWatcher
    Public USBDriveName As String
    Public USBDriveLetter As String

    Public Sub StartDetection()
        ' __InstanceOperationEvent will trap both Creation and Deletion of class instances
        Dim query2 As New WqlEventQuery("SELECT * FROM __InstanceOperationEvent WITHIN 1 " _
  & "WHERE TargetInstance ISA 'Win32_DiskDrive'")

        m_MediaConnectWatcher = New ManagementEventWatcher
        m_MediaConnectWatcher.Query = query2
        m_MediaConnectWatcher.Start()
    End Sub


    Private Sub Arrived(ByVal sender As Object, ByVal e As System.Management.EventArrivedEventArgs) Handles m_MediaConnectWatcher.EventArrived

        Dim mbo, obj As ManagementBaseObject

        ' the first thing we have to do is figure out if this is a creation or deletion event
        mbo = CType(e.NewEvent, ManagementBaseObject)
        ' next we need a copy of the instance that was either created or deleted
        obj = CType(mbo("TargetInstance"), ManagementBaseObject)

        Select Case mbo.ClassPath.ClassName
            Case "__InstanceCreationEvent"
                If obj("InterfaceType") = "USB" Then
                    'MsgBox(obj("Caption") & " (Drive letter " & GetDriveLetterFromDisk(obj("Name")) & ") has been plugged in")
                Else
                    ' MsgBox(obj("InterfaceType"))
                End If
            Case "__InstanceDeletionEvent"
                If obj("InterfaceType") = "USB" Then
                    'MsgBox(obj("Caption") & " has been unplugged")
                    Application.Exit()
                    If obj("Caption") = USBDriveName Then
                        USBDriveLetter = ""
                        USBDriveName = ""
                    End If
                Else
                    MsgBox(obj("InterfaceType"))
                End If
            Case Else
                MsgBox("nope: " & obj("Caption"))
        End Select
    End Sub

    Private Function GetDriveLetterFromDisk(ByVal Name As String) As String
        Dim oq_part, oq_disk As ObjectQuery
        Dim mos_part, mos_disk As ManagementObjectSearcher
        Dim obj_part, obj_disk As ManagementObject
        Dim ans As String = ""

        ' WMI queries use the "\" as an escape charcter
        Name = Replace(Name, "\", "\\")

        ' First we map the Win32_DiskDrive instance with the association called
        ' Win32_DiskDriveToDiskPartition. Then we map the Win23_DiskPartion
        ' instance with the assocation called Win32_LogicalDiskToPartition

        oq_part = New ObjectQuery("ASSOCIATORS OF {Win32_DiskDrive.DeviceID=""" & Name & """} WHERE AssocClass = Win32_DiskDriveToDiskPartition")
        mos_part = New ManagementObjectSearcher(oq_part)
        For Each obj_part In mos_part.Get()

            oq_disk = New ObjectQuery("ASSOCIATORS OF {Win32_DiskPartition.DeviceID=""" & obj_part("DeviceID") & """} WHERE AssocClass = Win32_LogicalDiskToPartition")
            mos_disk = New ManagementObjectSearcher(oq_disk)
            For Each obj_disk In mos_disk.Get()
                ans &= obj_disk("Name") & ","
            Next
        Next

        Return ans.Trim(","c)
    End Function

    Private Sub MüşteriListesiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MüşteriListesiToolStripMenuItem.Click
        mListesi = New FormMusteriListesi
        'mListesi.WindowState = FormWindowState.Maximized
        mListesi.MdiParent = Me
        mListesi.Show()
    End Sub

    Private Sub MüşteriHesaplarıToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MüşteriHesaplarıToolStripMenuItem.Click
        Dim f As New FormMusteriHesaplari
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Function veritabaniYedekle() As Boolean
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Access Veritabanı (*.mdb)|*.mdb"
        Dim dosyaadi = DateTime.Now.ToString("yyyy-MM-dd--HH-mm")
        dialog.FileName = dosyaadi
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                FileCopy("db.mdb", dialog.FileName)
                MessageBox.Show("Veritabanı başarı ile yedeklendi", "Yedekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Catch ex As Exception
                MessageBox.Show("Veritabanı yedekleme esnasında hata oluştu. Detaylar: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try

        End If
        Return False
    End Function

    Private Sub VeritabanıYedekleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VeritabanıYedekleToolStripMenuItem.Click
        veritabaniYedekle()
    End Sub

    Private Sub VeritabanınıSIFIRLAToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VeritabanınıSIFIRLAToolStripMenuItem.Click

        Dim dosyaadi = DateTime.Now.ToString("yyyy-MM-dd--HH-mm") & ".mdb"

        If MessageBox.Show("Bu işlem veritabanınızdaki HER ŞEYİ SİLEREK PROGRAMIN SIFIRLANMASINI sağlayacaktır. Devam etmek istiyor musunuz ?", "EMİN MİSİNİZ ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Bu işlemi gerçekleştirmeden önce veritabanınızı yedeklemelisiniz. Şimdi veritabanı yedekleme ekranına yönlendiriliyorsunuz", "Veritabanı yedekleme işlemi gerekiyor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If veritabaniYedekle() Then
                If Not Directory.Exists("yedekler") Then Directory.CreateDirectory("yedekler")
                FileCopy("db.mdb", "yedekler\\" & dosyaadi)

                Sorgula("Delete from musteriler")
                Sorgula("Delete from urunler")
                Sorgula("Delete from islemler")
                MessageBox.Show("Veritabanı başarı ile yedeklendi ve sıfırlandı. Program sıfırlanmak için kapatılacak. Lütfen tekrar başlatın.", "Sıfırlama işlemi başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Application.Exit()
            Else
                MessageBox.Show("Yedekleme işlemi yapılmadığı için veritabanınızı sıfırlamadık.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub HakkındaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HakkındaToolStripMenuItem.Click
        Dim f As New FormHakkinda
        f.StartPosition = FormStartPosition.CenterScreen
        f.ShowDialog()

    End Sub
End Class
