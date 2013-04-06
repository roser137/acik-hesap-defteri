Public Class FormUrunDetay

    Public urunID As String
    Public acan As FormUrunler

    Private Sub btnGuncelle_Click(sender As System.Object, e As System.EventArgs) Handles btnGuncelle.Click
        tbFiyat.Text = tbFiyat.Text.Replace(".", ",")
        Try
            Dim sorgu = "update urunler set urun='" & tbUrun.Text & "', fiyat='" & tbFiyat.Text & "' where urunID = " & urunID
            Sorgula(sorgu)
            MessageBox.Show("Başarı ile güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            acan.Guncelle()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Silem işlemi esnasında bir hata oluştu. Muhtemelen veritabanı bağlantısında bir sıkıntı var. Detaylar : " & ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub FormUrunDetay_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Guncelle()
    End Sub

    Private Sub Guncelle()
        Dim urun = Sorgula("select * from urunler where urunID=" & urunID)
        tbUrun.Text = urun.Rows(0)("urun")
        tbFiyat.Text = urun.Rows(0)("fiyat")

    End Sub

    Private Sub btnSil_Click(sender As System.Object, e As System.EventArgs) Handles btnSil.Click
        If MessageBox.Show("Ürünü SİLMEK İSTEDİĞİNİZDEN emin misiniz", "Emin misiniz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Sorgula("delete from urunler where urunID = " & urunID)
                MessageBox.Show("Başarı ile silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                acan.Guncelle()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Silem işlemi esnasında bir hata oluştu. Muhtemelen veritabanı bağlantısında bir sıkıntı var. Detaylar : " & ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class