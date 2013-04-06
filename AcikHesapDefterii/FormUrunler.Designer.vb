<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUrunler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUrunler))
        Me.dgvUrunler = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.tbUrun = New System.Windows.Forms.TextBox()
        Me.tbFiyat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cUrunID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUrun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFiyat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvUrunler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUrunler
        '
        Me.dgvUrunler.AllowUserToAddRows = False
        Me.dgvUrunler.AllowUserToDeleteRows = False
        Me.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUrunler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cUrunID, Me.cUrun, Me.cFiyat})
        Me.dgvUrunler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUrunler.Location = New System.Drawing.Point(0, 171)
        Me.dgvUrunler.Name = "dgvUrunler"
        Me.dgvUrunler.ReadOnly = True
        Me.dgvUrunler.RowHeadersVisible = False
        Me.dgvUrunler.Size = New System.Drawing.Size(894, 220)
        Me.dgvUrunler.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbAra)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(894, 171)
        Me.Panel1.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(73, 20)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Geri Dön"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightCyan
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnEkle)
        Me.GroupBox1.Controls.Add(Me.tbUrun)
        Me.GroupBox1.Controls.Add(Me.tbFiyat)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 94)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ürün Ekle"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ürün"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fiyat"
        '
        'btnEkle
        '
        Me.btnEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEkle.Location = New System.Drawing.Point(405, 48)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(75, 26)
        Me.btnEkle.TabIndex = 3
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'tbUrun
        '
        Me.tbUrun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUrun.Location = New System.Drawing.Point(10, 48)
        Me.tbUrun.Name = "tbUrun"
        Me.tbUrun.Size = New System.Drawing.Size(316, 26)
        Me.tbUrun.TabIndex = 1
        '
        'tbFiyat
        '
        Me.tbFiyat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFiyat.Location = New System.Drawing.Point(330, 48)
        Me.tbFiyat.Name = "tbFiyat"
        Me.tbFiyat.Size = New System.Drawing.Size(69, 26)
        Me.tbFiyat.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(415, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(470, 102)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'tbAra
        '
        Me.tbAra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAra.Location = New System.Drawing.Point(62, 131)
        Me.tbAra.Name = "tbAra"
        Me.tbAra.Size = New System.Drawing.Size(347, 26)
        Me.tbAra.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Ara"
        '
        'cUrunID
        '
        Me.cUrunID.HeaderText = "cUrunID"
        Me.cUrunID.Name = "cUrunID"
        Me.cUrunID.ReadOnly = True
        Me.cUrunID.Visible = False
        '
        'cUrun
        '
        Me.cUrun.HeaderText = "Ürün"
        Me.cUrun.Name = "cUrun"
        Me.cUrun.ReadOnly = True
        Me.cUrun.Width = 300
        '
        'cFiyat
        '
        Me.cFiyat.HeaderText = "Fiyat"
        Me.cFiyat.Name = "cFiyat"
        Me.cFiyat.ReadOnly = True
        '
        'FormUrunler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 391)
        Me.Controls.Add(Me.dgvUrunler)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormUrunler"
        Me.ShowIcon = False
        Me.Text = "Ürünler"
        CType(Me.dgvUrunler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvUrunler As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEkle As System.Windows.Forms.Button
    Friend WithEvents tbFiyat As System.Windows.Forms.TextBox
    Friend WithEvents tbUrun As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbAra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents cUrunID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUrun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cFiyat As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
