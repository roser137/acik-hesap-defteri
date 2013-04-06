Public Class FormOdemeAl

    Public musteriNo As Integer
    Public acanform As FormMusteri

    Private Sub FormOdemeAl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbMusteriNo.Text = musteriNo
        tbSaat.Text = DateTime.Now.ToString("HH:mm")

        Dim sorgu = "select * from musteriler where musteriID = " & musteriNo
        Dim musteri = Sorgula(sorgu)
        lbAdSoyad.Text = musteri.Rows(0)("adsoyad")

    End Sub

    Private Sub btnGuncelle_Click(sender As System.Object, e As System.EventArgs) Handles btnGuncelle.Click
        acanform.islemleriGuncelle()
        Dim tarihsaat = dtpTarih.Value.ToString("dd/MM/yyyy ") + tbSaat.Text
        Dim tutar As Double
        tbTutar.Text = tbTutar.Text.Replace(".", ",")

        If Not Double.TryParse(tbTutar.Text, tutar) Then
            MessageBox.Show("tutar geçersiz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        
        Dim sorgu = "insert into islemler (musteriID, aciklama,tutar,islemtarihi, eknot) values (" &
            musteriNo & ", '" &
            Temizle(tbAciklama.Text) &
            "', '" & tbTutar.Text * -1 & "' " &
            ", '" & tarihsaat & "'" &
            ", '" & tbEkNot.Text & "')"

        Try
            Sorgula(sorgu)
            MessageBox.Show("Ödeme başarı ile kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            acanform.islemleriGuncelle()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Ödeme eklenirken hata oluştu. Muhtemelen geçersiz bir veritipi kullanıldı veya veri tabanı bağlantısında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class