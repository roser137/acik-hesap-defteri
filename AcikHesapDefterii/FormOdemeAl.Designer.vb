<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOdemeAl
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
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.tbEkNot = New System.Windows.Forms.TextBox()
        Me.tbTutar = New System.Windows.Forms.TextBox()
        Me.tbAciklama = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbAdSoyad = New System.Windows.Forms.Label()
        Me.lbMusteriNo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTarih = New System.Windows.Forms.DateTimePicker()
        Me.tbSaat = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuncelle.Location = New System.Drawing.Point(327, 304)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(102, 32)
        Me.btnGuncelle.TabIndex = 25
        Me.btnGuncelle.Text = "Ödeme Al"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'tbEkNot
        '
        Me.tbEkNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEkNot.Location = New System.Drawing.Point(107, 239)
        Me.tbEkNot.Multiline = True
        Me.tbEkNot.Name = "tbEkNot"
        Me.tbEkNot.Size = New System.Drawing.Size(322, 48)
        Me.tbEkNot.TabIndex = 24
        '
        'tbTutar
        '
        Me.tbTutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTutar.Location = New System.Drawing.Point(107, 158)
        Me.tbTutar.Name = "tbTutar"
        Me.tbTutar.Size = New System.Drawing.Size(322, 26)
        Me.tbTutar.TabIndex = 20
        '
        'tbAciklama
        '
        Me.tbAciklama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAciklama.Location = New System.Drawing.Point(107, 110)
        Me.tbAciklama.Multiline = True
        Me.tbAciklama.Name = "tbAciklama"
        Me.tbAciklama.Size = New System.Drawing.Size(322, 38)
        Me.tbAciklama.TabIndex = 19
        Me.tbAciklama.Text = "Ödeme Alındı"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(148, 20)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "İşlem Listesine Dön"
        '
        'lbAdSoyad
        '
        Me.lbAdSoyad.AutoSize = True
        Me.lbAdSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdSoyad.ForeColor = System.Drawing.Color.Blue
        Me.lbAdSoyad.Location = New System.Drawing.Point(103, 72)
        Me.lbAdSoyad.Name = "lbAdSoyad"
        Me.lbAdSoyad.Size = New System.Drawing.Size(86, 20)
        Me.lbAdSoyad.TabIndex = 17
        Me.lbAdSoyad.Text = "lbAdSoyad"
        '
        'lbMusteriNo
        '
        Me.lbMusteriNo.AutoSize = True
        Me.lbMusteriNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMusteriNo.ForeColor = System.Drawing.Color.Blue
        Me.lbMusteriNo.Location = New System.Drawing.Point(103, 38)
        Me.lbMusteriNo.Name = "lbMusteriNo"
        Me.lbMusteriNo.Size = New System.Drawing.Size(93, 20)
        Me.lbMusteriNo.TabIndex = 16
        Me.lbMusteriNo.Text = "lbMusteriNo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ek Not"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tarih"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tutar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Açıklama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ad Soyad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "MusteriNo"
        '
        'dtpTarih
        '
        Me.dtpTarih.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTarih.Location = New System.Drawing.Point(107, 198)
        Me.dtpTarih.Name = "dtpTarih"
        Me.dtpTarih.Size = New System.Drawing.Size(244, 26)
        Me.dtpTarih.TabIndex = 27
        '
        'tbSaat
        '
        Me.tbSaat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSaat.Location = New System.Drawing.Point(357, 198)
        Me.tbSaat.Name = "tbSaat"
        Me.tbSaat.Size = New System.Drawing.Size(72, 26)
        Me.tbSaat.TabIndex = 28
        '
        'FormOdemeAl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 358)
        Me.Controls.Add(Me.tbSaat)
        Me.Controls.Add(Me.dtpTarih)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.tbEkNot)
        Me.Controls.Add(Me.tbTutar)
        Me.Controls.Add(Me.tbAciklama)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lbAdSoyad)
        Me.Controls.Add(Me.lbMusteriNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormOdemeAl"
        Me.ShowIcon = False
        Me.Text = "Ödeme Al"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuncelle As System.Windows.Forms.Button
    Friend WithEvents tbEkNot As System.Windows.Forms.TextBox
    Friend WithEvents tbTutar As System.Windows.Forms.TextBox
    Friend WithEvents tbAciklama As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lbAdSoyad As System.Windows.Forms.Label
    Friend WithEvents lbMusteriNo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTarih As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbSaat As System.Windows.Forms.TextBox
End Class
