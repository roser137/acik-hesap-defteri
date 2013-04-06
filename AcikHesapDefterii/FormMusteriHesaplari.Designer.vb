<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMusteriHesaplari
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbAra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvMusteriHesaplari = New System.Windows.Forms.DataGridView()
        Me.cMusteriID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAdSoyad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTutar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKaraListe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvMusteriHesaplari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbAra)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 24)
        Me.Panel1.TabIndex = 0
        '
        'tbAra
        '
        Me.tbAra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbAra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAra.Location = New System.Drawing.Point(34, 0)
        Me.tbAra.Name = "tbAra"
        Me.tbAra.Size = New System.Drawing.Size(411, 22)
        Me.tbAra.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ara"
        '
        'dgvMusteriHesaplari
        '
        Me.dgvMusteriHesaplari.AllowUserToAddRows = False
        Me.dgvMusteriHesaplari.AllowUserToDeleteRows = False
        Me.dgvMusteriHesaplari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMusteriHesaplari.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cMusteriID, Me.cAdSoyad, Me.cTutar, Me.cKaraListe})
        Me.dgvMusteriHesaplari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMusteriHesaplari.Location = New System.Drawing.Point(0, 24)
        Me.dgvMusteriHesaplari.Name = "dgvMusteriHesaplari"
        Me.dgvMusteriHesaplari.ReadOnly = True
        Me.dgvMusteriHesaplari.RowHeadersVisible = False
        Me.dgvMusteriHesaplari.Size = New System.Drawing.Size(445, 355)
        Me.dgvMusteriHesaplari.TabIndex = 1
        '
        'cMusteriID
        '
        Me.cMusteriID.HeaderText = "Müşteri ID"
        Me.cMusteriID.Name = "cMusteriID"
        Me.cMusteriID.ReadOnly = True
        Me.cMusteriID.Visible = False
        '
        'cAdSoyad
        '
        Me.cAdSoyad.FillWeight = 250.0!
        Me.cAdSoyad.HeaderText = "Ad Soyad"
        Me.cAdSoyad.Name = "cAdSoyad"
        Me.cAdSoyad.ReadOnly = True
        Me.cAdSoyad.Width = 300
        '
        'cTutar
        '
        Me.cTutar.HeaderText = "Tutar"
        Me.cTutar.Name = "cTutar"
        Me.cTutar.ReadOnly = True
        '
        'cKaraListe
        '
        Me.cKaraListe.HeaderText = "Kara Liste"
        Me.cKaraListe.Name = "cKaraListe"
        Me.cKaraListe.ReadOnly = True
        Me.cKaraListe.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cKaraListe.Width = 35
        '
        'FormMusteriHesaplari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 379)
        Me.Controls.Add(Me.dgvMusteriHesaplari)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMusteriHesaplari"
        Me.ShowIcon = False
        Me.Text = "Müşteri Hesap Özetleri"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvMusteriHesaplari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvMusteriHesaplari As System.Windows.Forms.DataGridView
    Friend WithEvents tbAra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cMusteriID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAdSoyad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTutar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKaraListe As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
