Public Class ODSMusteriler
    Public musteriID As Integer
    Public aciklama As String
    Public tutar As Double
    Public islemtarihi As String
    Public eknot As String

    Public Function tumMusteriler() As DataTable
        Dim sonuc = Sorgula("select * from islemler")
        Return sonuc
        'Dim liste As New List(Of ODSMusteriler)
        'For Each r In sonuc.Rows
        '    Dim m = New ODSMusteriler()
        '    m.aciklama = r("aciklama")
        '    m.musteriID = r("musteriID")
        '    m.tutar = r("tutar")
        '    m.islemtarihi = r("islemtarihi")
        '    m.eknot = r("eknot")

        '    liste.Add(m)
        'Next
        'Return liste
    End Function

End Class
