<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMusteri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMusteri))
        Me.dgvIslemler = New System.Windows.Forms.DataGridView()
        Me.cIslemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIslemTarihi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAciklama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBirim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fiyat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIskontoFiyat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIskontoOran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tutar2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEkNot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tutar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aciklama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.islemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eknot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.islemtarihi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbEkNot = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbKaraListe = New System.Windows.Forms.Label()
        Me.btnGelismisCikti = New System.Windows.Forms.Button()
        Me.btnDökümAl = New System.Windows.Forms.Button()
        Me.btnOdemeAl = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbIskontoluFiyat = New System.Windows.Forms.TextBox()
        Me.lbTamamla = New System.Windows.Forms.ListBox()
        Me.cbBirim = New System.Windows.Forms.ComboBox()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.dtpTarih = New System.Windows.Forms.DateTimePicker()
        Me.tbEkNot = New System.Windows.Forms.TextBox()
        Me.tbSaat = New System.Windows.Forms.TextBox()
        Me.tbIskonto = New System.Windows.Forms.TextBox()
        Me.tbTutar = New System.Windows.Forms.TextBox()
        Me.tbFiyat = New System.Windows.Forms.TextBox()
        Me.tbAdet = New System.Windows.Forms.TextBox()
        Me.tbAciklama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbAdSoyad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTelefon = New System.Windows.Forms.Label()
        Me.lbHesap = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvIslemler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvIslemler
        '
        Me.dgvIslemler.AllowUserToAddRows = False
        Me.dgvIslemler.AllowUserToDeleteRows = False
        Me.dgvIslemler.AllowUserToResizeColumns = False
        Me.dgvIslemler.AllowUserToResizeRows = False
        Me.dgvIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIslemler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIslemID, Me.cIslemTarihi, Me.DataGridViewTextBoxColumn2, Me.cAciklama, Me.adet, Me.cBirim, Me.fiyat, Me.cIskontoFiyat, Me.cIskontoOran, Me.tutar2, Me.cEkNot})
        Me.dgvIslemler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIslemler.Location = New System.Drawing.Point(0, 227)
        Me.dgvIslemler.Name = "dgvIslemler"
        Me.dgvIslemler.ReadOnly = True
        Me.dgvIslemler.RowHeadersVisible = False
        Me.dgvIslemler.Size = New System.Drawing.Size(1030, 259)
        Me.dgvIslemler.TabIndex = 9
        '
        'cIslemID
        '
        Me.cIslemID.HeaderText = "islemID"
        Me.cIslemID.Name = "cIslemID"
        Me.cIslemID.ReadOnly = True
        Me.cIslemID.Visible = False
        '
        'cIslemTarihi
        '
        Me.cIslemTarihi.FillWeight = 150.0!
        Me.cIslemTarihi.HeaderText = "İşlem Tarihi"
        Me.cIslemTarihi.Name = "cIslemTarihi"
        Me.cIslemTarihi.ReadOnly = True
        Me.cIslemTarihi.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipi"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'cAciklama
        '
        Me.cAciklama.HeaderText = "Açıklama"
        Me.cAciklama.Name = "cAciklama"
        Me.cAciklama.ReadOnly = True
        Me.cAciklama.Width = 200
        '
        'adet
        '
        Me.adet.HeaderText = "Adet"
        Me.adet.Name = "adet"
        Me.adet.ReadOnly = True
        Me.adet.Width = 75
        '
        'cBirim
        '
        Me.cBirim.HeaderText = "Birim"
        Me.cBirim.Name = "cBirim"
        Me.cBirim.ReadOnly = True
        Me.cBirim.Width = 70
        '
        'fiyat
        '
        Me.fiyat.HeaderText = "Satış Fiyatı"
        Me.fiyat.Name = "fiyat"
        Me.fiyat.ReadOnly = True
        Me.fiyat.Width = 75
        '
        'cIskontoFiyat
        '
        Me.cIskontoFiyat.HeaderText = "İskonto Fiyat"
        Me.cIskontoFiyat.Name = "cIskontoFiyat"
        Me.cIskontoFiyat.ReadOnly = True
        Me.cIskontoFiyat.Width = 75
        '
        'cIskontoOran
        '
        Me.cIskontoOran.HeaderText = "İskonto Oran"
        Me.cIskontoOran.Name = "cIskontoOran"
        Me.cIskontoOran.ReadOnly = True
        Me.cIskontoOran.Width = 50
        '
        'tutar2
        '
        Me.tutar2.HeaderText = "Tutar"
        Me.tutar2.Name = "tutar2"
        Me.tutar2.ReadOnly = True
        Me.tutar2.Width = 75
        '
        'cEkNot
        '
        Me.cEkNot.HeaderText = "Ek Not"
        Me.cEkNot.Name = "cEkNot"
        Me.cEkNot.ReadOnly = True
        Me.cEkNot.Width = 200
        '
        'Tutar
        '
        Me.Tutar.HeaderText = "tutar"
        Me.Tutar.Name = "Tutar"
        '
        'aciklama
        '
        Me.aciklama.HeaderText = "Açıklama"
        Me.aciklama.Name = "aciklama"
        Me.aciklama.Width = 200
        '
        'islemID
        '
        Me.islemID.HeaderText = "islemID"
        Me.islemID.Name = "islemID"
        Me.islemID.Visible = False
        '
        'eknot
        '
        Me.eknot.HeaderText = "Ek Not"
        Me.eknot.Name = "eknot"
        Me.eknot.Width = 200
        '
        'tipi
        '
        Me.tipi.HeaderText = "Tipi"
        Me.tipi.Name = "tipi"
        '
        'islemtarihi
        '
        Me.islemtarihi.FillWeight = 150.0!
        Me.islemtarihi.HeaderText = "İşlem Tarihi"
        Me.islemtarihi.Name = "islemtarihi"
        Me.islemtarihi.Width = 150
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbEkNot)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lbKaraListe)
        Me.Panel1.Controls.Add(Me.btnGelismisCikti)
        Me.Panel1.Controls.Add(Me.btnDökümAl)
        Me.Panel1.Controls.Add(Me.btnOdemeAl)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbAdSoyad)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbTelefon)
        Me.Panel1.Controls.Add(Me.lbHesap)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 227)
        Me.Panel1.TabIndex = 4
        '
        'lbEkNot
        '
        Me.lbEkNot.AutoSize = True
        Me.lbEkNot.Location = New System.Drawing.Point(325, 175)
        Me.lbEkNot.MaximumSize = New System.Drawing.Size(550, 0)
        Me.lbEkNot.Name = "lbEkNot"
        Me.lbEkNot.Size = New System.Drawing.Size(540, 39)
        Me.lbEkNot.TabIndex = 25
        Me.lbEkNot.Text = resources.GetString("lbEkNot.Text")
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(197, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Excel"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lbKaraListe
        '
        Me.lbKaraListe.AutoSize = True
        Me.lbKaraListe.BackColor = System.Drawing.Color.Black
        Me.lbKaraListe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbKaraListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKaraListe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbKaraListe.Location = New System.Drawing.Point(788, 41)
        Me.lbKaraListe.Margin = New System.Windows.Forms.Padding(10)
        Me.lbKaraListe.Name = "lbKaraListe"
        Me.lbKaraListe.Padding = New System.Windows.Forms.Padding(10)
        Me.lbKaraListe.Size = New System.Drawing.Size(104, 82)
        Me.lbKaraListe.TabIndex = 24
        Me.lbKaraListe.Text = "MÜŞTERİ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KARA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LİSTEDE"
        Me.lbKaraListe.Visible = False
        '
        'btnGelismisCikti
        '
        Me.btnGelismisCikti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGelismisCikti.Location = New System.Drawing.Point(180, 150)
        Me.btnGelismisCikti.Name = "btnGelismisCikti"
        Me.btnGelismisCikti.Size = New System.Drawing.Size(139, 35)
        Me.btnGelismisCikti.TabIndex = 23
        Me.btnGelismisCikti.Text = "Gelişmiş Çıktı Al"
        Me.btnGelismisCikti.UseVisualStyleBackColor = True
        '
        'btnDökümAl
        '
        Me.btnDökümAl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDökümAl.Location = New System.Drawing.Point(106, 150)
        Me.btnDökümAl.Name = "btnDökümAl"
        Me.btnDökümAl.Size = New System.Drawing.Size(69, 35)
        Me.btnDökümAl.TabIndex = 23
        Me.btnDökümAl.Text = "Çıktı Al"
        Me.btnDökümAl.UseVisualStyleBackColor = True
        '
        'btnOdemeAl
        '
        Me.btnOdemeAl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOdemeAl.Location = New System.Drawing.Point(12, 150)
        Me.btnOdemeAl.Name = "btnOdemeAl"
        Me.btnOdemeAl.Size = New System.Drawing.Size(88, 35)
        Me.btnOdemeAl.TabIndex = 23
        Me.btnOdemeAl.Text = "Ödeme Al"
        Me.btnOdemeAl.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbTamamla)
        Me.GroupBox1.Controls.Add(Me.cbBirim)
        Me.GroupBox1.Controls.Add(Me.btnEkle)
        Me.GroupBox1.Controls.Add(Me.dtpTarih)
        Me.GroupBox1.Controls.Add(Me.tbEkNot)
        Me.GroupBox1.Controls.Add(Me.tbSaat)
        Me.GroupBox1.Controls.Add(Me.tbIskonto)
        Me.GroupBox1.Controls.Add(Me.tbTutar)
        Me.GroupBox1.Controls.Add(Me.tbAdet)
        Me.GroupBox1.Controls.Add(Me.tbAciklama)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbIskontoluFiyat)
        Me.GroupBox1.Controls.Add(Me.tbFiyat)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(325, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 169)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "İşlem Ekle"
        '
        'tbIskontoluFiyat
        '
        Me.tbIskontoluFiyat.Location = New System.Drawing.Point(355, 75)
        Me.tbIskontoluFiyat.Name = "tbIskontoluFiyat"
        Me.tbIskontoluFiyat.Size = New System.Drawing.Size(80, 22)
        Me.tbIskontoluFiyat.TabIndex = 7
        '
        'lbTamamla
        '
        Me.lbTamamla.FormattingEnabled = True
        Me.lbTamamla.ItemHeight = 16
        Me.lbTamamla.Location = New System.Drawing.Point(436, 126)
        Me.lbTamamla.Name = "lbTamamla"
        Me.lbTamamla.Size = New System.Drawing.Size(36, 20)
        Me.lbTamamla.TabIndex = 9
        Me.lbTamamla.Visible = False
        '
        'cbBirim
        '
        Me.cbBirim.FormattingEnabled = True
        Me.cbBirim.Items.AddRange(New Object() {"Adet", "Metre", "Diğer"})
        Me.cbBirim.Location = New System.Drawing.Point(183, 47)
        Me.cbBirim.Name = "cbBirim"
        Me.cbBirim.Size = New System.Drawing.Size(61, 24)
        Me.cbBirim.TabIndex = 3
        Me.cbBirim.Text = "Adet"
        '
        'btnEkle
        '
        Me.btnEkle.Location = New System.Drawing.Point(358, 129)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(77, 23)
        Me.btnEkle.TabIndex = 11
        Me.btnEkle.Text = "&Ekle"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'dtpTarih
        '
        Me.dtpTarih.Location = New System.Drawing.Point(93, 129)
        Me.dtpTarih.Name = "dtpTarih"
        Me.dtpTarih.Size = New System.Drawing.Size(188, 22)
        Me.dtpTarih.TabIndex = 9
        '
        'tbEkNot
        '
        Me.tbEkNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEkNot.Location = New System.Drawing.Point(93, 103)
        Me.tbEkNot.Name = "tbEkNot"
        Me.tbEkNot.Size = New System.Drawing.Size(342, 22)
        Me.tbEkNot.TabIndex = 8
        '
        'tbSaat
        '
        Me.tbSaat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSaat.Location = New System.Drawing.Point(287, 129)
        Me.tbSaat.Name = "tbSaat"
        Me.tbSaat.Size = New System.Drawing.Size(65, 22)
        Me.tbSaat.TabIndex = 10
        '
        'tbIskonto
        '
        Me.tbIskonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIskonto.Location = New System.Drawing.Point(225, 75)
        Me.tbIskonto.Name = "tbIskonto"
        Me.tbIskonto.Size = New System.Drawing.Size(59, 22)
        Me.tbIskonto.TabIndex = 6
        '
        'tbTutar
        '
        Me.tbTutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTutar.Location = New System.Drawing.Point(93, 75)
        Me.tbTutar.Name = "tbTutar"
        Me.tbTutar.Size = New System.Drawing.Size(56, 22)
        Me.tbTutar.TabIndex = 5
        '
        'tbFiyat
        '
        Me.tbFiyat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFiyat.Location = New System.Drawing.Point(326, 47)
        Me.tbFiyat.Name = "tbFiyat"
        Me.tbFiyat.Size = New System.Drawing.Size(109, 22)
        Me.tbFiyat.TabIndex = 4
        '
        'tbAdet
        '
        Me.tbAdet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAdet.Location = New System.Drawing.Point(93, 47)
        Me.tbAdet.Name = "tbAdet"
        Me.tbAdet.Size = New System.Drawing.Size(48, 22)
        Me.tbAdet.TabIndex = 2
        '
        'tbAciklama
        '
        Me.tbAciklama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAciklama.Location = New System.Drawing.Point(93, 19)
        Me.tbAciklama.Name = "tbAciklama"
        Me.tbAciklama.Size = New System.Drawing.Size(342, 22)
        Me.tbAciklama.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tarih/Saat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ek Not"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(292, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 32)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "İskontolu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fiyat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(160, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "İskonto: % "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(147, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Birim"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tutar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(247, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Satış Fiyatı"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Adet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ürün/Hizmet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Hesap"
        '
        'lbAdSoyad
        '
        Me.lbAdSoyad.AutoSize = True
        Me.lbAdSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdSoyad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbAdSoyad.Location = New System.Drawing.Point(8, 23)
        Me.lbAdSoyad.Name = "lbAdSoyad"
        Me.lbAdSoyad.Size = New System.Drawing.Size(77, 25)
        Me.lbAdSoyad.TabIndex = 19
        Me.lbAdSoyad.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Telefon:"
        '
        'lbTelefon
        '
        Me.lbTelefon.AutoSize = True
        Me.lbTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefon.ForeColor = System.Drawing.Color.Blue
        Me.lbTelefon.Location = New System.Drawing.Point(103, 70)
        Me.lbTelefon.MaximumSize = New System.Drawing.Size(250, 0)
        Me.lbTelefon.Name = "lbTelefon"
        Me.lbTelefon.Size = New System.Drawing.Size(217, 80)
        Me.lbTelefon.TabIndex = 20
        Me.lbTelefon.Text = "Label2 Label2 Label2 Label2 Label2 Label2 Label2 Label2 Label2 Label2 Label2 Labe" & _
    "l2 Label2 Label2 Label2 Label2 "
        '
        'lbHesap
        '
        Me.lbHesap.AutoSize = True
        Me.lbHesap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHesap.ForeColor = System.Drawing.Color.Blue
        Me.lbHesap.Location = New System.Drawing.Point(103, 50)
        Me.lbHesap.Name = "lbHesap"
        Me.lbHesap.Size = New System.Drawing.Size(57, 20)
        Me.lbHesap.TabIndex = 20
        Me.lbHesap.Text = "Label2"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(162, 20)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Müşteri Listesine Dön"
        '
        'FormMusteri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 486)
        Me.Controls.Add(Me.dgvIslemler)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMusteri"
        Me.ShowIcon = False
        Me.Text = "İşlemler"
        CType(Me.dgvIslemler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvIslemler As System.Windows.Forms.DataGridView
    Friend WithEvents Tutar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aciklama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents islemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents eknot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents islemtarihi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEkle As System.Windows.Forms.Button
    Friend WithEvents dtpTarih As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbEkNot As System.Windows.Forms.TextBox
    Friend WithEvents tbSaat As System.Windows.Forms.TextBox
    Friend WithEvents tbAdet As System.Windows.Forms.TextBox
    Friend WithEvents tbAciklama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbHesap As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents tbTutar As System.Windows.Forms.TextBox
    Friend WithEvents tbFiyat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnOdemeAl As System.Windows.Forms.Button
    Friend WithEvents lbAdSoyad As System.Windows.Forms.Label
    Friend WithEvents btnDökümAl As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbTamamla As System.Windows.Forms.ListBox
    Friend WithEvents lbKaraListe As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnGelismisCikti As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbBirim As System.Windows.Forms.ComboBox
    Friend WithEvents lbEkNot As System.Windows.Forms.Label
    Friend WithEvents lbTelefon As System.Windows.Forms.Label
    Friend WithEvents tbIskonto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbIskontoluFiyat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cIslemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIslemTarihi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAciklama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBirim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fiyat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIskontoFiyat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIskontoOran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tutar2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEkNot As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
