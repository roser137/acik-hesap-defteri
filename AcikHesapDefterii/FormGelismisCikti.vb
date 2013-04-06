Public Class FormGelismisCikti
    Public acan As Form
    Public musteriID As Integer
    Dim musteri As DataTable
    Private Sub FormGelişmisCikti_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        musteri = Sorgula("select * from musteriler where musteriID = " & musteriID)
        lbAdSoyad.Text = musteri.Rows(0)("adsoyad")
        'dtpBasla.Value = dtpBasla.Value.AddDays(-365)
        'dtpBitir.Value = dtpBitir.Value.AddDays(1)
    End Sub

    Private Sub btnRaporOlustur_Click(sender As System.Object, e As System.EventArgs) Handles btnRaporOlustur.Click
        Dim f As New FormDokumAl
        f.adsoyad = lbAdSoyad.Text
        f.telefon = musteri.Rows(0)("telefon").ToString
        ' dtpTarih.Value.ToString("dd/MM/yyyy ")

    
        Dim sorgutoplam = "select sum(tutar) as toplam  from islemler where musteriID = " & musteriID &
                     "  and  iptal = false  and islemtarihi  >= #" &
                     dtpBasla.Value.ToString("MM/dd/yyyy 00:00").Replace(".", "/") &
                     "# and islemtarihi <= #" &
                     dtpBitir.Value.ToString("MM/dd/yyyy 23:59").Replace(".", "/") & "#"
            Dim sorgulatoplam = Sorgula(sorgutoplam)
            f.toplam = String.Format("{0:0.00}", sorgulatoplam.Rows(0)("toplam"))


        Dim sorgu = "select * from islemler where musteriID = " & musteriID &
                         "  and  iptal = false  and islemtarihi  >= #" &
                         dtpBasla.Value.ToString("MM/dd/yyyy 00:00").Replace(".", "/") &
                         "# and islemtarihi <= #" &
                         dtpBitir.Value.ToString("MM/dd/yyyy 23:59").Replace(".", "/") & "# " &
                         "order by islemtarihi asc"
            Dim sonuc = Sorgula(sorgu)
            f.data = sonuc

        f.Show()
    End Sub
End Class