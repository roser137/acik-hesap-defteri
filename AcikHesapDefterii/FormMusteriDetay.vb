Public Class FormMusteriDetay
    Public musteriID As Integer
    Public acan As FormMusteriHesaplari

    Private Sub FormMusteriDetay_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Guncelle()
    End Sub

    Private Sub Guncelle()
        Dim musteri = Sorgula("select * from musteriler where musteriID = " & musteriID)
        lbAdSoyad.Text = musteri.Rows(0)("adsoyad").ToString

        If musteri.Rows(0)("karaliste") = 1 Then cbKaraListe.Checked = True

        tbTelefon.Text = musteri.Rows(0)("telefon").ToString
        tbEkNot.Text = musteri.Rows(0)("eknot").ToString

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim karaliste As Integer
        karaliste = 0
        If (cbKaraListe.Checked) Then karaliste = 1

        Try
            Dim sorgu = "update musteriler set karaliste = '" & karaliste & "', telefon='" & tbTelefon.Text & "', eknot='" & tbEkNot.Text & "' where musteriID = " & musteriID
            Sorgula(sorgu)
            MessageBox.Show("Başarı ile güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Güncelleme esnasında hata oluştu. Muhtemelen veritabanı bağlantısı ile ilgili: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        acan.Guncelle()

    End Sub

    Private Sub btnMusteriSil_Click(sender As System.Object, e As System.EventArgs) Handles btnMusteriSil.Click
        If MessageBox.Show("MÜŞTERİYİ SİLMEK İSTEDİĞİNİZDEN emin misiniz ?", "DİKKAT !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim sorgu = "update musteriler set silindi = true where musteriID = " & musteriID
                Sorgula(sorgu)
                MessageBox.Show("Başarı ile silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Silme esnasında hata oluştu. Muhtemelen veritabanı bağlantısı ile ilgili: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            acan.Guncelle()

            Dim liste = acan.MdiParent.MdiChildren.OfType(Of FormMusteriListesi)()

            Try
                If liste.Count > 0 Then
                    liste(0).Guncelle()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
End Class