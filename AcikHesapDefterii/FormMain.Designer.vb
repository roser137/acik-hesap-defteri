<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MüşteriListesiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜrünlerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MüşteriHesaplarıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VeritabanıYedekleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VeritabanınıSIFIRLAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 504)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(892, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MüşteriListesiToolStripMenuItem, Me.ÜrünlerToolStripMenuItem, Me.MüşteriHesaplarıToolStripMenuItem, Me.VeritabanıYedekleToolStripMenuItem, Me.VeritabanınıSIFIRLAToolStripMenuItem, Me.HakkındaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(892, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÇıkışToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(51, 20)
        Me.ToolStripMenuItem1.Text = "Dosya"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'MüşteriListesiToolStripMenuItem
        '
        Me.MüşteriListesiToolStripMenuItem.Name = "MüşteriListesiToolStripMenuItem"
        Me.MüşteriListesiToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.MüşteriListesiToolStripMenuItem.Text = "Müşteri Listesi"
        '
        'ÜrünlerToolStripMenuItem
        '
        Me.ÜrünlerToolStripMenuItem.Name = "ÜrünlerToolStripMenuItem"
        Me.ÜrünlerToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ÜrünlerToolStripMenuItem.Text = "Ürünler"
        '
        'MüşteriHesaplarıToolStripMenuItem
        '
        Me.MüşteriHesaplarıToolStripMenuItem.Name = "MüşteriHesaplarıToolStripMenuItem"
        Me.MüşteriHesaplarıToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.MüşteriHesaplarıToolStripMenuItem.Text = "Müşteri Hesapları"
        '
        'VeritabanıYedekleToolStripMenuItem
        '
        Me.VeritabanıYedekleToolStripMenuItem.Name = "VeritabanıYedekleToolStripMenuItem"
        Me.VeritabanıYedekleToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.VeritabanıYedekleToolStripMenuItem.Text = "Veritabanı Yedekle"
        '
        'VeritabanınıSIFIRLAToolStripMenuItem
        '
        Me.VeritabanınıSIFIRLAToolStripMenuItem.Name = "VeritabanınıSIFIRLAToolStripMenuItem"
        Me.VeritabanınıSIFIRLAToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.VeritabanınıSIFIRLAToolStripMenuItem.Text = "Veritabanını SIFIRLA"
        '
        'HakkındaToolStripMenuItem
        '
        Me.HakkındaToolStripMenuItem.Name = "HakkındaToolStripMenuItem"
        Me.HakkındaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.HakkındaToolStripMenuItem.Text = "Hakkında"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(892, 526)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.Text = "Açık Hesap Takip"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÜrünlerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MüşteriListesiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MüşteriHesaplarıToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VeritabanıYedekleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VeritabanınıSIFIRLAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HakkındaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
