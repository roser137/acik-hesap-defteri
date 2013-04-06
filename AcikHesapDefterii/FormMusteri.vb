Imports System.IO
Imports System.Web
Imports Excel = Microsoft.Office.Interop.Excel

Public Class FormMusteri

    Public musteriNo As String
    Public toplam As Double
    Dim musteri As DataTable
    Public Sub islemleriGuncelle()
        ' CType(MdiParent, FormMain).ToolStrip.Hide()
        Dim sorgu = "select top 1 * from musteriler where musteriID = " & musteriNo
        musteri = Veritabani.Sorgula(sorgu)
        lbAdSoyad.Text = musteri.Rows(0)("adsoyad").ToString
        lbTelefon.Text = musteri.Rows(0)("telefon").ToString
        lbEkNot.Text = musteri.Rows(0)("eknot").ToString

        If (musteri.Rows(0)("karaliste") = 1) Then
            BackColor = Color.DarkGray
            lbKaraListe.Visible = True
        End If

        Dim islemler = Sorgula("select * from islemler where musteriID = " + musteriNo + "  and  iptal = false order by islemID desc")
        toplam = 0.0
        tbSaat.Text = DateTime.Now.ToString("HH:mm")

        dgvIslemler.Rows.Clear()
        For Each satir In islemler.Rows
            Try
                Dim tip = ""
                If (satir("tutar").ToString < 0) Then
                    tip = "Borç"
                    '  CType(satir, DataGridViewRow).DefaultCellStyle.BackColor = Color.Magenta
                Else
                    tip = "Alacak"
                    ' CType(satir, DataGridViewRow).DefaultCellStyle.BackColor = Color.Pink
                End If

                Dim fiyatstr = "-"
                Dim fiyat As Double

                If Double.TryParse(satir("fiyat").ToString, fiyat) Then
                    fiyatstr = String.Format("{0:0.00}", fiyat) & " TL"
                Else
                    fiyatstr = "-"
                End If

                Dim tutarstr = "-"
                Dim tutar As Double
                If Double.TryParse(satir("tutar").ToString, tutar) Then
                    tutarstr = String.Format("{0:0.00}", tutar) & " TL"
                Else
                    tutarstr = "-"
                End If

                Dim iskontofiyatstr = "-"
                Dim iskontofiyat As Double

                If Double.TryParse(satir("iskontofiyat").ToString, iskontofiyat) Then
                    iskontofiyatstr = String.Format("{0:0.00}", iskontofiyat) & " TL"
                Else
                    iskontofiyatstr = "-"
                End If

                Dim satiradet = ""
                If Not satir("adet") Is DBNull.Value Then satiradet = satir("adet")

                Dim satirbirim = ""
                If Not satir("birim") Is DBNull.Value Then satirbirim = satir("birim")

                Dim satiriskontooran = ""
                If Not satir("iskontoOran") Is DBNull.Value Then satiriskontooran = satir("iskontoOran")


                dgvIslemler.Rows.Add(satir("islemID"), satir("islemtarihi").ToString, tip.ToString, satir("aciklama").ToString, satiradet, satirbirim, fiyatstr, iskontofiyatstr, satiriskontooran, tutar.ToString, satir("eknot").ToString)


                If (satir("tutar").ToString < 0) Then
                    dgvIslemler.Rows(dgvIslemler.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    dgvIslemler.Rows(dgvIslemler.Rows.Count - 1).DefaultCellStyle.BackColor = Color.WhiteSmoke

                End If



                toplam += satir("tutar")
            Catch ex As Exception

            End Try
        Next
        
        If (toplam > 0) Then lbHesap.Text = String.Format("{0:0.00}", toplam) & " TL Alacak"
        If (toplam < 0) Then lbHesap.Text = String.Format("{0:0.00}", toplam * -1) & " TL Borç"
        If (toplam = 0) Then lbHesap.Text = "Alacak verecek yok"

    End Sub

    Private Sub FormMusteri_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        islemleriGuncelle()
        dgvIslemler.Columns("adet").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvIslemler.Columns("fiyat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvIslemler.Columns("tutar2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvIslemler.Columns("adet").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvIslemler.Columns("fiyat").SortMode = DataGridViewColumnSortMode.NotSortable
        'dgvIslemler.Columns("aciklama").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvIslemler.Columns("cEkNot").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvIslemler.Columns("cIskontoFiyat").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvIslemler.Columns("cIskontoOran").SortMode = DataGridViewColumnSortMode.NotSortable

        Dim s As New DataGridViewCellStyle()
        s.Format = "0.00 TL"
        Dim s2 As New DataGridViewCellStyle()
        s2.Format = "0.00 %"


        dgvIslemler.Columns("tutar2").DefaultCellStyle = s
        dgvIslemler.Columns("cIskontofiyat").DefaultCellStyle = s
        dgvIslemler.Columns("cIskontoOran").DefaultCellStyle = s2


    End Sub


    Private Sub btnEkle_Click(sender As System.Object, e As System.EventArgs) Handles btnEkle.Click
        If (musteri.Rows(0)("karaliste") = 1) Then
            MessageBox.Show("Müşteri kara listede olduğu için işlem yapılamıyor, ödeme alındıktan sonra tekrar gözden geçiriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Ekle()
    End Sub

    Private Sub dgvIslemler_DoubleClick(sender As System.Object, e As System.EventArgs) Handles dgvIslemler.CellDoubleClick
        Try
            Dim seciliSatir = dgvIslemler.SelectedCells(0).RowIndex
            Dim islemno = dgvIslemler.Rows(seciliSatir).Cells("cIslemID").Value
            Dim detay As New FormIslemDetay
            detay.islemNo = islemno
            detay.MdiParent = Me.MdiParent
            detay.acanform = Me
            detay.Show()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CType(MdiParent, FormMain).mListesi.tbAra.Text = ""
        'CType(MdiParent, FormMain).ToolStrip.Hide()
        Me.Close()

    End Sub

    Private Sub btnOdemeAl_Click(sender As System.Object, e As System.EventArgs) Handles btnOdemeAl.Click
        Dim f As New FormOdemeAl
        f.musteriNo = musteriNo
        f.acanform = Me

        f.MdiParent = MdiParent
        f.Show()
    End Sub

    Private Sub TutarGuncelle(sender As System.Object, e As System.EventArgs) Handles tbAdet.TextChanged, tbFiyat.TextChanged
        Dim fiyat As Double
        Dim adet As Double
        tbAdet.Text = tbAdet.Text.Replace(".", ",")
        tbFiyat.Text = tbFiyat.Text.Replace(".", ",")
        If Double.TryParse(tbFiyat.Text, fiyat) And Double.TryParse(tbAdet.Text, adet) Then
            tbTutar.Text = fiyat * adet
        End If
        tbIskontoluFiyat.Text = tbFiyat.Text
    End Sub

    Private Sub iskontoSifirla(sender As System.Object, e As System.EventArgs) Handles tbFiyat.TextChanged
        tbIskonto.Text = 0
    End Sub

    Private Sub btnDökümAl_Click(sender As System.Object, e As System.EventArgs) Handles btnDökümAl.Click
        Dim f As New FormDokumAl
        f.adsoyad = lbAdSoyad.Text
        f.telefon = lbTelefon.Text
        f.toplam = String.Format("{0:0.00}", toplam)
        f.data = Sorgula("select * from islemler where musteriID = " + musteriNo + "  and  iptal = false order by islemtarihi asc")
        f.Show()
    End Sub

    Private Sub cmsGelismisRaporlama_Click(sender As System.Object, e As System.EventArgs)
        Dim seciliSatir = dgvIslemler.SelectedCells(0).RowIndex
        Dim islemTarihiBasla = dgvIslemler.Rows(seciliSatir).Cells("cIslemTarihi").Value

    End Sub

    Private Sub tbAciklama_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbAciklama.TextChanged
        lbTamamla.Location = New Point(93, 36)
        lbTamamla.Size = New Size(354, 84)

        lbTamamla.Visible = False

        Dim ara As String = Temizle(tbAciklama.Text.Trim())
        lbTamamla.Items.Clear()
        Dim urunler = Sorgula("select * from urunler where urun like '%" + ara + "%'")

        For Each u In urunler.Rows
            lbTamamla.Items.Add(u("urun") & " (" & u("fiyat") & ")")
        Next

        If lbTamamla.Items.Count > 0 And ara.Length > 0 Then lbTamamla.Visible = True
    End Sub


    Private Sub tbAciklama_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbAciklama.KeyDown

        If e.KeyValue = 40 Then
            lbTamamla.SelectedIndex = 0
            lbTamamla.Focus()
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub lbTamamla_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lbTamamla.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            lbTamamlaSecildi()
            e.Handled = True
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            lbTamamla.Visible = False
            tbAciklama.Focus()
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub tbEkNot_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbTutar.KeyDown, tbSaat.KeyDown, tbFiyat.KeyDown, tbEkNot.KeyDown, tbAdet.KeyDown, dtpTarih.KeyDown, tbIskonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ekle()
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub Ekle()
        If tbAciklama.Text.Trim().Length < 1 Then
            MessageBox.Show("İşlem açıklaması girmelisiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim temp As Double
        tbTutar.Text = tbTutar.Text.Replace(".", ",")
        If Not Double.TryParse(tbTutar.Text, temp) Then
            MessageBox.Show("Tutar belirtmeden işlem yapamazsınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim tarihsaat = dtpTarih.Value.ToString("dd/MM/yyyy ") + tbSaat.Text
        Try
            Dim iskontofiyat = Double.Parse(tbTutar.Text) / Double.Parse(tbAdet.Text)
            Dim sorgu = "insert into islemler (musteriID, aciklama, adet,birim, fiyat,iskontofiyat,iskontooran, tutar, islemtarihi, eknot) values " &
                        "(" & musteriNo & ",'" & Temizle(tbAciklama.Text) &
                        "', '" & tbAdet.Text &
                        "', '" & cbBirim.Text &
                        "', '" & tbFiyat.Text &
                        "', '" & iskontofiyat &
                        "', '" & tbIskonto.Text &
                        "', '" & tbTutar.Text &
                        "', '" & tarihsaat & "', '" &
                        Temizle(tbEkNot.Text) & "')"
            Sorgula(sorgu)
            MsgBox("Başarı ile eklendi", MsgBoxStyle.OkOnly, "Eklendi")

            UrunuGuncelle()

            tbAciklama.Text = ""
            tbFiyat.Text = ""
            tbAdet.Text = ""
            tbTutar.Text = ""
            tbEkNot.Text = ""
            tbAciklama.Focus()
            islemleriGuncelle()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "hata")
        End Try
    End Sub

    Private Sub UrunuGuncelle()
        Dim urun As String = Temizle(tbAciklama.Text.Trim())
        Dim fiyatstr As String = tbFiyat.Text.Trim()
        Dim fiyat As Double

        If fiyatstr.Length < 1 Then
            'MsgBox("fiyat boştu ürün güncellenmiyor")
            Return
        End If

        If Not Double.TryParse(fiyatstr, fiyat) Then
            'MsgBox("fiyat numerik değil ürün güncellenmiyor")
            Return
        End If

        Dim urunvarmiSQL = "select * from urunler where urun = '" & urun & "'"
        Dim urunvarmi = Sorgula(urunvarmiSQL)

        If urunvarmi.Rows.Count > 0 Then
            'MsgBox("urun vardi guncellenecek")
            Dim guncelleSQL = "update urunler set fiyat = '" & fiyat & "' where urun='" & urun & "'"
            Sorgula(guncelleSQL)
        Else
            'MsgBox("urun yoktu eklenecek")
            Dim ekleSQL = "insert into urunler (urun,fiyat) values ('" & urun & "', '" & fiyat & "')"
            Sorgula(ekleSQL)
        End If

    End Sub

    Private Sub lbTamamlaSecildi()
        Dim metin As String = lbTamamla.SelectedItem.ToString
        metin = metin.Substring(0, metin.LastIndexOf("(") - 1).Trim()

        tbAciklama.Text = metin
        lbTamamla.Visible = False
        tbAciklama.Focus()


        Dim urun = Sorgula("select * from urunler where urun = '" & metin & "'")
        tbFiyat.Text = urun.Rows(0)("fiyat")
    End Sub

    Private Sub lbTamamla_Click(sender As System.Object, e As System.EventArgs) Handles lbTamamla.Click
        lbTamamlaSecildi()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlApp = New Excel.ApplicationClass
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            'xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)

            For i = 0 To dgvIslemler.RowCount - 2
                For j = 0 To dgvIslemler.ColumnCount - 1
                    xlWorkSheet.Cells(i + 1, j + 1) = _
                        dgvIslemler(j, i).Value.ToString()
                Next
            Next

            xlWorkSheet.SaveAs(dialog.FileName)
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MsgBox("Dosya '" & dialog.FileName & "' adresine kaydedildi.", MsgBoxStyle.OkOnly)

        End If
        ' MsgBox(dialog.FileName)

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnGelismisCikti_Click(sender As System.Object, e As System.EventArgs) Handles btnGelismisCikti.Click
        Dim f As New FormGelismisCikti
        f.musteriID = musteriNo
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub tbTutar_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbTutar.KeyUp
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
        Dim fiyat As Double
        Dim iskontolu As Double
        If Double.TryParse(tbFiyat.Text, fiyat) And Double.TryParse(tbIskontoluFiyat.Text, iskontolu) Then
            If iskontolu > fiyat Then
                tbIskontoluFiyat.Text = tbFiyat.Text
            End If
        End If
    End Sub

    Private Sub tbTutar_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles tbTutar.TextChanged
        tbTutar.Text = tbTutar.Text.Replace(".", ",")
    End Sub

    Private Sub tbIskonto_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles tbIskonto.TextChanged
        Dim deger As Double
        If Double.TryParse(tbIskonto.Text, deger) Then
            If deger < 0 Then tbIskonto.Text = 0
            If deger > 100 Then tbIskonto.Text = 100
        End If
        tbIskonto.Text = tbIskonto.Text.Replace(".", ",")
    End Sub


    Private Sub tbAdet_Enter(sender As System.Object, e As System.EventArgs) Handles tbTutar.Enter, tbSaat.Enter, tbIskontoluFiyat.Enter, tbIskonto.Enter, tbFiyat.Enter, tbEkNot.Enter, tbAdet.Enter, dtpTarih.Enter, cbBirim.Enter, btnEkle.Enter
        lbTamamla.Visible = False
    End Sub
End Class