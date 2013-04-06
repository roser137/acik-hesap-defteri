<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMusteriDetay
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbKaraListe = New System.Windows.Forms.CheckBox()
        Me.lbAdSoyad = New System.Windows.Forms.Label()
        Me.btnMusteriSil = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTelefon = New System.Windows.Forms.TextBox()
        Me.tbEkNot = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(159, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Kaydet"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbKaraListe
        '
        Me.cbKaraListe.AutoSize = True
        Me.cbKaraListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKaraListe.Location = New System.Drawing.Point(23, 228)
        Me.cbKaraListe.Name = "cbKaraListe"
        Me.cbKaraListe.Size = New System.Drawing.Size(99, 24)
        Me.cbKaraListe.TabIndex = 1
        Me.cbKaraListe.Text = "Kara Liste"
        Me.cbKaraListe.UseVisualStyleBackColor = True
        '
        'lbAdSoyad
        '
        Me.lbAdSoyad.AutoSize = True
        Me.lbAdSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdSoyad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbAdSoyad.Location = New System.Drawing.Point(16, 9)
        Me.lbAdSoyad.Name = "lbAdSoyad"
        Me.lbAdSoyad.Size = New System.Drawing.Size(95, 31)
        Me.lbAdSoyad.TabIndex = 2
        Me.lbAdSoyad.Text = "Label1"
        '
        'btnMusteriSil
        '
        Me.btnMusteriSil.BackColor = System.Drawing.Color.Red
        Me.btnMusteriSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMusteriSil.ForeColor = System.Drawing.Color.White
        Me.btnMusteriSil.Location = New System.Drawing.Point(23, 258)
        Me.btnMusteriSil.Name = "btnMusteriSil"
        Me.btnMusteriSil.Size = New System.Drawing.Size(100, 37)
        Me.btnMusteriSil.TabIndex = 0
        Me.btnMusteriSil.Text = "Müşteriyi Sil"
        Me.btnMusteriSil.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Telefon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ek Not:"
        '
        'tbTelefon
        '
        Me.tbTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefon.Location = New System.Drawing.Point(100, 43)
        Me.tbTelefon.Multiline = True
        Me.tbTelefon.Name = "tbTelefon"
        Me.tbTelefon.Size = New System.Drawing.Size(224, 60)
        Me.tbTelefon.TabIndex = 4
        '
        'tbEkNot
        '
        Me.tbEkNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEkNot.Location = New System.Drawing.Point(100, 109)
        Me.tbEkNot.Multiline = True
        Me.tbEkNot.Name = "tbEkNot"
        Me.tbEkNot.Size = New System.Drawing.Size(224, 106)
        Me.tbEkNot.TabIndex = 4
        '
        'FormMusteriDetay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 330)
        Me.Controls.Add(Me.tbEkNot)
        Me.Controls.Add(Me.tbTelefon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbAdSoyad)
        Me.Controls.Add(Me.cbKaraListe)
        Me.Controls.Add(Me.btnMusteriSil)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormMusteriDetay"
        Me.ShowIcon = False
        Me.Text = "Müşteri Detayları"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbKaraListe As System.Windows.Forms.CheckBox
    Friend WithEvents lbAdSoyad As System.Windows.Forms.Label
    Friend WithEvents btnMusteriSil As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbTelefon As System.Windows.Forms.TextBox
    Friend WithEvents tbEkNot As System.Windows.Forms.TextBox
End Class
