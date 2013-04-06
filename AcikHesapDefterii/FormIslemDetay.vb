Public Class FormIslemDetay
    Public islemNo As Integer
    Public acanform As Form
    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' CType(MdiParent, FormMain).mListesi.tbAra.Text = ""
        Me.Close()

    End Sub

    Private Sub islemDetaylariGoruntule()
        lbIslemNo.Text = islemNo
        Dim sorgu = "select top 1 musteriler.* from islemler left join musteriler on (musteriler.musteriID = islemler.musteriID) where islemler.islemID = " & islemNo
        Dim musteri = Veritabani.Sorgula(sorgu)
        lbAdSoyad.Text = musteri.Rows(0)("adsoyad")

        sorgu = "select * from islemler where islemID = " & islemNo
        Dim islem = Veritabani.Sorgula(sorgu)
        'If Not (islem.Rows(0)("aciklama").Equals(DBNull.Value)) Then tbAciklama.Text = islem.Rows(0)("aciklama")
        'If Not (islem.Rows(0)("adet").Equals(DBNull.Value)) Then tbAdet.Text = islem.Rows(0)("adet")
        'If Not (islem.Rows(0)("fiyat").Equals(DBNull.Value)) Then tbFiyat.Text = islem.Rows(0)("fiyat")
        'If Not (islem.Rows(0)("tutar").Equals(DBNull.Value)) Then tbTutar.Text = islem.Rows(0)("tutar")
        'If Not (islem.Rows(0)("islemtarihi").Equals(DBNull.Value)) Then tbTarih.Text = islem.Rows(0)("islemtarihi")
        'If Not (islem.Rows(0)("eknot").Equals(DBNull.Value)) Then tbEkNot.Text = islem.Rows(0)("eknot")

        tbAciklama.Text = islem.Rows(0)("aciklama").ToString()
        tbAdet.Text = islem.Rows(0)("adet").ToString()
        tbFiyat.Text = islem.Rows(0)("fiyat").ToString()
        tbTutar.Text = islem.Rows(0)("tutar").ToString()
        tbTarih.Text = islem.Rows(0)("islemtarihi").ToString()
        tbEkNot.Text = islem.Rows(0)("eknot").ToString()
        tbIskonto.Text = islem.Rows(0)("iskontooran").ToString()
        tbIskontoluFiyat.Text = islem.Rows(0)("iskontofiyat").ToString()
        cbBirim.Text = islem.Rows(0)("birim").ToString()
    End Sub

    Private Sub FormIslemDetay_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        islemDetaylariGoruntule()
    End Sub


    Private Sub btnGuncelle_Click(sender As System.Object, e As System.EventArgs) Handles btnGuncelle.Click
        Dim temp As Double
        tbFiyat.Text = tbFiyat.Text.Replace(".", ",")
        tbAdet.Text = tbAdet.Text.Replace(".", ",")
        tbTutar.Text = tbTutar.Text.Replace(".", ",")
        tbIskontoluFiyat.Text = tbIskontoluFiyat.Text.Replace(".", ",")
        tbIskonto.Text = tbIskonto.Text.Replace(".", ",")


        Dim fiyat = tbFiyat.Text.Trim()
        Dim adet = tbAdet.Text.Trim()
        Dim tutar = tbTutar.Text.Trim()


        'If Double.TryParse(fiyat, temp) Then fiyat = "'" & fiyat & "'"
        'If Double.TryParse(adet, temp) Then adet = "'" & adet & "'"
        'If Double.TryParse(tutar, temp) Then tutar = "'" & tutar & "'"

        Dim sorgu = "update islemler set aciklama='" & Veritabani.Temizle(tbAciklama.Text) &
            "', adet='" & Veritabani.Temizle(adet) & "' " &
            ", birim='" & Veritabani.Temizle(cbBirim.Text) & "' " &
            ", fiyat='" & Veritabani.Temizle(fiyat) & "' " &
            ", iskontofiyat='" & Veritabani.Temizle(tbIskontoluFiyat.Text.Trim()) & "' " &
            ", iskontooran='" & Veritabani.Temizle(tbIskonto.Text.Trim()) & "' " &
            ", tutar='" & Veritabani.Temizle(tutar) & "' " &
            ", islemtarihi = '" & Veritabani.Temizle(tbTarih.Text) &
            "', eknot='" & Veritabani.Temizle(tbEkNot.Text) &
            "' where islemID = " & islemNo
        Try
            Sorgula(sorgu)
            MessageBox.Show("Başarı ile güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu, muhtemelen bir alana geçersiz bir girdi yapıldı ya da veritabanı bağlantısında sorun var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        islemDetaylariGoruntule()
        CType(acanform, FormMusteri).islemleriGuncelle()
        Me.Close()
    End Sub

    Private Sub btnIptal_Click(sender As System.Object, e As System.EventArgs) Handles btnIptal.Click
        If MessageBox.Show("İŞLEMİ İPTAL ETMEK istediğinizden emin misiniz ?", "Emin misinzi ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sorgu = "update islemler set iptal=1 where islemID = " & islemNo
            Try
                Sorgula(sorgu)
                MessageBox.Show("Başarı ile iptal edildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("İptal esnasında hata Oluştu, veritabanı bağlantısında sorun olabilir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            islemDetaylariGoruntule()
            CType(acanform, FormMusteri).islemleriGuncelle()
            Me.Close()

        End If

    End Sub

    Private Sub TutarGuncelle(sender As System.Object, e As System.EventArgs) Handles tbAdet.TextChanged, tbFiyat.TextChanged
        Dim fiyat As Double
        Dim adet As Double

        tbFiyat.Text = tbFiyat.Text.Replace(".", ",")
        tbAdet.Text = tbAdet.Text.Replace(".", ",")

        If Double.TryParse(tbFiyat.Text, fiyat) And Double.TryParse(tbAdet.Text, adet) Then
            tbTutar.Text = fiyat * adet
        End If
      
    End Sub


    Private Sub tbTutar_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbTutar.KeyUp
        tbTutar.Text = tbTutar.Text.Replace(".", ",")

        Dim tutar As Double
        iskontolufiyatagore = False
        If Double.TryParse(tbTutar.Text, tutar) Then
            tutaraGore = True
            iskontoyaGore = False
            If tutaraGore Then
                Dim adet As Double
                Dim fiyat As Double
                If Double.TryParse(tbAdet.Text, adet) And Double.TryParse(tbFiyat.Text, fiyat) Then
                    tbIskonto.Text = ((1 - (tutar / (adet * fiyat))) * 100).ToString("0.00")
                    tbIskontoluFiyat.Text = ((1 - (tbIskonto.Text / 100)) * Double.Parse(tbFiyat.Text)).ToString("0.00")
                End If
            End If
        Else
        End If
    End Sub

    Dim iskontoyaGore As Boolean = False
    Dim tutaraGore As Boolean = False
    Private Sub tbIskonto_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbIskonto.KeyUp, tbAdet.KeyUp
        iskontayaGoreTutarHesapla()
        iskontolufiyatagore = False
    End Sub

    Private Sub iskontayaGoreTutarHesapla()
        Dim iskonto As Double
        Dim tutar As Double
        Dim adet As Double
        Dim fiyat As Double

        If Double.TryParse(tbIskonto.Text, iskonto) And Double.TryParse(tbTutar.Text, tutar) And Double.TryParse(tbAdet.Text, adet) And Double.TryParse(tbFiyat.Text, fiyat) Then
            tutaraGore = False
            iskontoyaGore = True
            If iskontoyaGore Then
                If Not iskontolufiyatagore Then
                    tbIskontoluFiyat.Text = ((1 - (tbIskonto.Text / 100)) * Double.Parse(tbFiyat.Text)).ToString("0.00")

                Else
                    'tbTutar.Text = fiyat * adet * ((100 - iskonto) / 100)

                End If
                tbTutar.Text = (Double.Parse(tbIskontoluFiyat.Text) * adet).ToString("0.00")
            End If
        End If
    End Sub

    Dim iskontolufiyatagore = False
    Private Sub tbIskontoluFiyat_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbIskontoluFiyat.KeyUp
        iskontolufiyatagore = True
        Dim fiyat As Double
        Dim iskontofiyat As Double
        If Double.TryParse(tbFiyat.Text, fiyat) And Double.TryParse(tbIskontoluFiyat.Text, iskontofiyat) Then
            Dim iskonto As Double = (1 - iskontofiyat / fiyat) * 100
            tbIskonto.Text = iskonto.ToString("0.00")
            iskontayaGoreTutarHesapla()
        End If
    End Sub

    Private Sub tbIskontoluFiyat_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles tbIskontoluFiyat.TextChanged
        tbIskontoluFiyat.Text = tbIskontoluFiyat.Text.Replace(".", ",")
    End Sub

    Private Sub tbIskonto_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles tbIskonto.TextChanged
        tbIskonto.Text = tbIskonto.Text.Replace(".", ",")
    End Sub
End Class