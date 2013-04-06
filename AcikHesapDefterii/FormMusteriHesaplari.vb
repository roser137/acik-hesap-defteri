Public Class FormMusteriHesaplari

    Private Sub FormMusteriHesaplari_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvMusteriHesaplari.Columns("cTutar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Guncelle()
        
    End Sub

    Public Sub Guncelle()
        dgvMusteriHesaplari.Rows.Clear()


        Dim hesaplar = Sorgula("SELECT  musteriler.musteriID, musteriler.adsoyad, sum(islemler.tutar) as toplam, karaliste " &
            " FROM musteriler LEFT JOIN islemler ON musteriler.musteriID = islemler.musteriID " &
            " where musteriler.silindi = false and musteriler.adsoyad like '%" & Temizle(tbAra.Text) & "%' " &
            " group by musteriler.musteriID,musteriler.adsoyad, musteriler.karaliste" &
            " order by sum(islemler.tutar) desc ")

        For Each r In hesaplar.Rows
            Dim toplam As Double
            If Not Double.TryParse(r("toplam").ToString, toplam) Then
                toplam = 0
            End If
            dgvMusteriHesaplari.Rows.Add(r("musteriID"), r("adsoyad"), toplam, r("karaliste"))
        Next

    End Sub

    Private Sub tbAra_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbAra.TextChanged
        Guncelle()
    End Sub


    Private Sub dgvMusteriHesaplari_DoubleClick(sender As System.Object, e As System.EventArgs) Handles dgvMusteriHesaplari.DoubleClick
        Dim idx = dgvMusteriHesaplari.SelectedCells(0).RowIndex
        Dim musteriID = dgvMusteriHesaplari.Rows(idx).Cells("cMusteriID").Value
        Dim f As New FormMusteriDetay
        f.MdiParent = MdiParent
        f.acan = Me
        f.musteriID = musteriID
        f.Show()
    End Sub
End Class