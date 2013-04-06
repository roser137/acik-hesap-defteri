Imports System.Data.OleDb

Module Veritabani
    ' Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bin\Debug\db.accdb

    Dim baglanti As OleDbConnection = Nothing

    Function Sorgula(ByVal sorgu As String) As DataTable
        ' If baglanti Is Nothing Then baglan()
        sorgu = Replace(sorgu, "''", "NULL")


        baglanti = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb")

            Dim ds As New DataSet
            Dim adapter As New OleDbDataAdapter(sorgu, baglanti)
            adapter.Fill(ds)
            If ds.Tables.Count < 1 Then
                Return Nothing
            End If
            Return ds.Tables(0)
        Return Nothing
    End Function

    Sub baglan()
        baglanti = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb")

    End Sub

    Function Temizle(ByVal str As String)
        Dim temiz = str.Replace("'", " ")

        Return temiz
    End Function
End Module
