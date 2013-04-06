Public Class FormMusteriListesi
    Private Sub FormMusteriListesi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Guncelle()
    End Sub

    Public Sub Guncelle()
        lbMusteriler.DataSource = Sorgula("select musteriID, adsoyad from musteriler where silindi = false order by adsoyad asc")
        lbMusteriler.DisplayMember = "adsoyad"
        lbMusteriler.ValueMember = "musteriID"
    End Sub

    Private Sub lbMusteriler_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lbMusteriler.DoubleClick
        Dim fMusteri As New FormMusteri
        fMusteri.musteriNo = lbMusteriler.SelectedValue.ToString
        fMusteri.MdiParent = MdiParent
        'CType(fMusteri.MdiParent, FormMain).ToolStrip.Show()

        'fMusteri.WindowState = FormWindowState.Maximized
        fMusteri.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim adsoyad As String = Temizle(tbAra.Text.Trim())
        Dim tarih = DateTime.Now.ToString("dd/MM/yyyy")
        If adsoyad.Length < 3 Then
            MessageBox.Show("Müşteri adı bu kadar kısa olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim sorgu = "insert into musteriler (adsoyad,karaliste,kayittarihi) values ('" &
            adsoyad & "', 0, '" & tarih & "')"
        Try
            Sorgula(sorgu)
            MessageBox.Show("Müşteri başarı ile eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Guncelle()
        Catch ex As Exception
            MessageBox.Show("Ekleme hatası. Veritabanı bağlantısı sorunu veya müşteri adınadaki geçersiz karakterlerden dolayı hata oluşmuş olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbAra_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbAra.TextChanged
        Dim sorgu = "select musteriID, adsoyad from musteriler where adsoyad like '%" + tbAra.Text + "%' and silindi = 0"
        lbMusteriler.DataSource = Sorgula(sorgu)
    End Sub

End Class
