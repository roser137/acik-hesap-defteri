<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIslemDetay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbIslemNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbAciklama = New System.Windows.Forms.TextBox()
        Me.tbTutar = New System.Windows.Forms.TextBox()
        Me.tbTarih = New System.Windows.Forms.TextBox()
        Me.tbEkNot = New System.Windows.Forms.TextBox()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbAdSoyad = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbAdet = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbFiyat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbBirim = New System.Windows.Forms.ComboBox()
        Me.tbIskonto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbIskontoluFiyat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(148, 20)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "İşlem Listesine Dön"
        '
        'lbIslemNo
        '
        Me.lbIslemNo.AutoSize = True
        Me.lbIslemNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIslemNo.ForeColor = System.Drawing.Color.Blue
        Me.lbIslemNo.Location = New System.Drawing.Point(103, 38)
        Me.lbIslemNo.Name = "lbIslemNo"
        Me.lbIslemNo.Size = New System.Drawing.Size(79, 20)
        Me.lbIslemNo.TabIndex = 4
        Me.lbIslemNo.Text = "lbIslemNo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IslemNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Açıklama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tutar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tarih"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ek Not"
        '
        'tbAciklama
        '
        Me.tbAciklama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAciklama.Location = New System.Drawing.Point(107, 110)
        Me.tbAciklama.Multiline = True
        Me.tbAciklama.Name = "tbAciklama"
        Me.tbAciklama.Size = New System.Drawing.Size(322, 38)
        Me.tbAciklama.TabIndex = 6
        '
        'tbTutar
        '
        Me.tbTutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTutar.Location = New System.Drawing.Point(107, 269)
        Me.tbTutar.Name = "tbTutar"
        Me.tbTutar.Size = New System.Drawing.Size(322, 26)
        Me.tbTutar.TabIndex = 6
        '
        'tbTarih
        '
        Me.tbTarih.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTarih.Location = New System.Drawing.Point(107, 315)
        Me.tbTarih.Name = "tbTarih"
        Me.tbTarih.Size = New System.Drawing.Size(322, 26)
        Me.tbTarih.TabIndex = 6
        '
        'tbEkNot
        '
        Me.tbEkNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEkNot.Location = New System.Drawing.Point(107, 350)
        Me.tbEkNot.Multiline = True
        Me.tbEkNot.Name = "tbEkNot"
        Me.tbEkNot.Size = New System.Drawing.Size(322, 48)
        Me.tbEkNot.TabIndex = 6
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuncelle.Location = New System.Drawing.Point(327, 415)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(102, 32)
        Me.btnGuncelle.TabIndex = 7
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Red
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.White
        Me.btnIptal.Location = New System.Drawing.Point(174, 415)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(147, 32)
        Me.btnIptal.TabIndex = 7
        Me.btnIptal.Text = "İşlemi İptal Et"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Ad Soyad"
        '
        'lbAdSoyad
        '
        Me.lbAdSoyad.AutoSize = True
        Me.lbAdSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdSoyad.ForeColor = System.Drawing.Color.Blue
        Me.lbAdSoyad.Location = New System.Drawing.Point(103, 72)
        Me.lbAdSoyad.Name = "lbAdSoyad"
        Me.lbAdSoyad.Size = New System.Drawing.Size(86, 20)
        Me.lbAdSoyad.TabIndex = 4
        Me.lbAdSoyad.Text = "lbAdSoyad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Adet"
        '
        'tbAdet
        '
        Me.tbAdet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAdet.Location = New System.Drawing.Point(107, 190)
        Me.tbAdet.Name = "tbAdet"
        Me.tbAdet.Size = New System.Drawing.Size(115, 26)
        Me.tbAdet.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(242, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Fiyat"
        '
        'tbFiyat
        '
        Me.tbFiyat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFiyat.Location = New System.Drawing.Point(314, 190)
        Me.tbFiyat.Name = "tbFiyat"
        Me.tbFiyat.Size = New System.Drawing.Size(115, 26)
        Me.tbFiyat.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Birim"
        '
        'cbBirim
        '
        Me.cbBirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBirim.FormattingEnabled = True
        Me.cbBirim.Items.AddRange(New Object() {"Adet", "Metre", "Diğer"})
        Me.cbBirim.Location = New System.Drawing.Point(107, 155)
        Me.cbBirim.Name = "cbBirim"
        Me.cbBirim.Size = New System.Drawing.Size(115, 28)
        Me.cbBirim.TabIndex = 8
        '
        'tbIskonto
        '
        Me.tbIskonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIskonto.Location = New System.Drawing.Point(107, 226)
        Me.tbIskonto.Name = "tbIskonto"
        Me.tbIskonto.Size = New System.Drawing.Size(115, 26)
        Me.tbIskonto.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "İskonto: % "
        '
        'tbIskontoluFiyat
        '
        Me.tbIskontoluFiyat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIskontoluFiyat.Location = New System.Drawing.Point(321, 226)
        Me.tbIskontoluFiyat.Name = "tbIskontoluFiyat"
        Me.tbIskontoluFiyat.Size = New System.Drawing.Size(108, 26)
        Me.tbIskontoluFiyat.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(241, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 40)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "İskontolu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fiyat"
        '
        'FormIslemDetay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 473)
        Me.Controls.Add(Me.tbIskontoluFiyat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbIskonto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbBirim)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.tbEkNot)
        Me.Controls.Add(Me.tbTarih)
        Me.Controls.Add(Me.tbFiyat)
        Me.Controls.Add(Me.tbAdet)
        Me.Controls.Add(Me.tbTutar)
        Me.Controls.Add(Me.tbAciklama)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lbAdSoyad)
        Me.Controls.Add(Me.lbIslemNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormIslemDetay"
        Me.ShowIcon = False
        Me.Text = "İşlem Detayı"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lbIslemNo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbAciklama As System.Windows.Forms.TextBox
    Friend WithEvents tbTutar As System.Windows.Forms.TextBox
    Friend WithEvents tbTarih As System.Windows.Forms.TextBox
    Friend WithEvents tbEkNot As System.Windows.Forms.TextBox
    Friend WithEvents btnGuncelle As System.Windows.Forms.Button
    Friend WithEvents btnIptal As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbAdSoyad As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbAdet As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbFiyat As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbBirim As System.Windows.Forms.ComboBox
    Friend WithEvents tbIskonto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbIskontoluFiyat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
