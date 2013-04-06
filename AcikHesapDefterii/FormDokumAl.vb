Imports Microsoft.Reporting.WinForms

Public Class FormDokumAl

    Public data As DataTable
    Public adsoyad As String
    Public toplam As String
    Public telefon As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim f As New Font("Arial", 12)
        ' e.Graphics.DrawString("denemece", f, Brushes.Black, 80.0, 1000.0)
        Dim ods As New ODSMusteriler
        ods.tumMusteriler()

    End Sub

    Private Sub FormYazdirTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim toplammetin = ""
        Dim d_toplam
        If Double.TryParse(toplam, d_toplam) Then
            If d_toplam = 0 Then toplammetin = "Dökümdeki tarih aralığı için Hesap denk"
            If d_toplam > 0 Then toplammetin = "Dökümdeki tarih aralığı için Toplam " & toplam & " TL borcunuz var."
            If d_toplam < 0 Then toplammetin = "Dökümdeki tarih aralığı için Toplam " & toplam * -1 & " TL alacağınız var."
        Else
            toplammetin = "Hesap denk"

        End If
        

        ' local report kullanıyoruz
        ReportViewer1.ProcessingMode = ProcessingMode.Local
        'ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report2.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ' dataset bağlamaca
        ' ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", Sorgula("select * from islemler where musteriID = 2")))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", data))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet2", data))
        ReportViewer1.DocumentMapCollapsed = True

        If (telefon.Length < 1) Then telefon = "   "

        ' düz stringler için report daha kısmından yeni parameter ekleyip böyle atama yapıyoruz
        ' Dim p1 As ReportParameter = New ReportParameter("ad", "test")
        Dim p1 As ReportParameter = New ReportParameter("ad", adsoyad.ToString())
        Dim p2 As ReportParameter = New ReportParameter("toplammetni", toplammetin.ToString())
        Dim p3 As ReportParameter = New ReportParameter("telefon", telefon.ToString())

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3})
        ReportViewer1.RefreshReport()


        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth



    End Sub

    Private Sub ÜrünlerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class