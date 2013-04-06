Public Class FormUrunler

    Private Sub FormUrunler_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvUrunler.Columns("cFiyat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim s As New DataGridViewCellStyle()
        s.Format = "0.00 TL"
        dgvUrunler.Columns("cFiyat").DefaultCellStyle = s

        Guncelle()
    End Sub

    Public Sub Guncelle()
        dgvUrunler.Rows.Clear()
        Dim urunler = Sorgula("select urunID, urun,fiyat from urunler")

        For Each u In urunler.Rows
            dgvUrunler.Rows.Add(u("urunID"), u("urun"), u("fiyat"))
        Next
    End Sub

    Private Sub btnEkle_Click(sender As System.Object, e As System.EventArgs) Handles btnEkle.Click
        Ekle()
    End Sub

    Private Sub Ekle()
        tbFiyat.Text = tbFiyat.Text.Replace(".", ",")

        Dim urun = tbUrun.Text.Trim()
        Dim fiyat As Double

        If urun.Length < 2 Then
            MessageBox.Show("Ürün adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return


        End If
        If Not Double.TryParse(tbFiyat.Text, fiyat) Then
            MessageBox.Show("Geçersiz fiyat", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Sorgula("insert into urunler (urun,fiyat) values ('" & Temizle(urun) & "', '" & fiyat & "')")
            MessageBox.Show("Başarı ile eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Veritabanı işlemi esnasında hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        tbFiyat.Text = ""
        tbUrun.Text = ""
        tbUrun.Focus()
        Guncelle()
    End Sub

    Private Sub tbFiyat_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbFiyat.KeyPress, tbUrun.KeyPress, tbAra.KeyPress
        

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Ekle()
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub tbAra_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbAra.TextChanged
        dgvUrunler.Rows.Clear()
        Dim urunler = Sorgula("select * from urunler where urun like '%" + tbAra.Text + "%'")

        For Each u In urunler.Rows
            dgvUrunler.Rows.Add(u("urunID"), u("urun"), u("fiyat"))
        Next

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Close()
    End Sub

  
    Private Sub dgvUrunler_DoubleClick(sender As System.Object, e As System.EventArgs) Handles dgvUrunler.DoubleClick
        Dim idx = dgvUrunler.SelectedCells(0).RowIndex
        Dim urunID = dgvUrunler.Rows(idx).Cells("cUrunID").Value.ToString
        Dim f As New FormUrunDetay
        f.acan = Me
        f.urunID = urunID
        f.Show()
    End Sub


End Class