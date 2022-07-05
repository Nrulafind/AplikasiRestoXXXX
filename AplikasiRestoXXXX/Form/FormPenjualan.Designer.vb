<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIDJual = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIDKasir = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNamaKasir = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNamaMenu = New System.Windows.Forms.TextBox()
        Me.txtIDMenu = New System.Windows.Forms.TextBox()
        Me.LVPenjualan = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCariMenu = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblJumlahMenu = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(30, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Jual :"
        '
        'lblIDJual
        '
        Me.lblIDJual.AutoSize = True
        Me.lblIDJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Bold)
        Me.lblIDJual.Location = New System.Drawing.Point(100, 41)
        Me.lblIDJual.Name = "lblIDJual"
        Me.lblIDJual.Size = New System.Drawing.Size(20, 22)
        Me.lblIDJual.TabIndex = 1
        Me.lblIDJual.Text = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(181, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Kasir :"
        '
        'lblIDKasir
        '
        Me.lblIDKasir.AutoSize = True
        Me.lblIDKasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Bold)
        Me.lblIDKasir.Location = New System.Drawing.Point(257, 41)
        Me.lblIDKasir.Name = "lblIDKasir"
        Me.lblIDKasir.Size = New System.Drawing.Size(20, 22)
        Me.lblIDKasir.TabIndex = 3
        Me.lblIDKasir.Text = "x"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(338, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hari/Tanggal :"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Bold)
        Me.lblTanggal.Location = New System.Drawing.Point(452, 25)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(20, 22)
        Me.lblTanggal.TabIndex = 5
        Me.lblTanggal.Text = "x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(359, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total :"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(428, 53)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(21, 24)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "x"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(181, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nama Kasir :"
        '
        'lblNamaKasir
        '
        Me.lblNamaKasir.AutoSize = True
        Me.lblNamaKasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Bold)
        Me.lblNamaKasir.Location = New System.Drawing.Point(283, 81)
        Me.lblNamaKasir.Name = "lblNamaKasir"
        Me.lblNamaKasir.Size = New System.Drawing.Size(20, 22)
        Me.lblNamaKasir.TabIndex = 9
        Me.lblNamaKasir.Text = "x"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.txtNamaMenu)
        Me.GroupBox1.Controls.Add(Me.txtIDMenu)
        Me.GroupBox1.Controls.Add(Me.LVPenjualan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnCariMenu)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 113)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(24)
        Me.GroupBox1.Size = New System.Drawing.Size(609, 331)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputkan Pesanan"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.SteelBlue
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Image = Global.AplikasiRestoXXXX.My.Resources.Resources.icoHapus
        Me.btnHapus.Location = New System.Drawing.Point(514, 221)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(68, 64)
        Me.btnHapus.TabIndex = 9
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Image = Global.AplikasiRestoXXXX.My.Resources.Resources.icoTambah
        Me.btnTambah.Location = New System.Drawing.Point(514, 149)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(68, 64)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(139, 105)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtJumlah.TabIndex = 7
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(139, 73)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(100, 20)
        Me.txtHarga.TabIndex = 6
        '
        'txtNamaMenu
        '
        Me.txtNamaMenu.Location = New System.Drawing.Point(260, 38)
        Me.txtNamaMenu.Name = "txtNamaMenu"
        Me.txtNamaMenu.Size = New System.Drawing.Size(169, 20)
        Me.txtNamaMenu.TabIndex = 5
        '
        'txtIDMenu
        '
        Me.txtIDMenu.Location = New System.Drawing.Point(139, 38)
        Me.txtIDMenu.Name = "txtIDMenu"
        Me.txtIDMenu.Size = New System.Drawing.Size(100, 20)
        Me.txtIDMenu.TabIndex = 4
        '
        'LVPenjualan
        '
        Me.LVPenjualan.HideSelection = False
        Me.LVPenjualan.Location = New System.Drawing.Point(27, 149)
        Me.LVPenjualan.Name = "LVPenjualan"
        Me.LVPenjualan.Size = New System.Drawing.Size(468, 155)
        Me.LVPenjualan.TabIndex = 3
        Me.LVPenjualan.UseCompatibleStateImageBehavior = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga"
        '
        'btnCariMenu
        '
        Me.btnCariMenu.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCariMenu.FlatAppearance.BorderSize = 0
        Me.btnCariMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariMenu.ForeColor = System.Drawing.Color.White
        Me.btnCariMenu.Location = New System.Drawing.Point(27, 31)
        Me.btnCariMenu.Name = "btnCariMenu"
        Me.btnCariMenu.Size = New System.Drawing.Size(97, 35)
        Me.btnCariMenu.TabIndex = 0
        Me.btnCariMenu.Text = "CARI MENU"
        Me.btnCariMenu.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(324, 459)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Bayar"
        '
        'txtBayar
        '
        Me.txtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtBayar.Location = New System.Drawing.Point(406, 456)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(110, 26)
        Me.txtBayar.TabIndex = 11
        '
        'txtKembali
        '
        Me.txtKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtKembali.Location = New System.Drawing.Point(406, 498)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(110, 26)
        Me.txtKembali.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(324, 501)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Kembali"
        '
        'lblJumlahMenu
        '
        Me.lblJumlahMenu.AutoSize = True
        Me.lblJumlahMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Bold)
        Me.lblJumlahMenu.Location = New System.Drawing.Point(253, 441)
        Me.lblJumlahMenu.Name = "lblJumlahMenu"
        Me.lblJumlahMenu.Size = New System.Drawing.Size(20, 22)
        Me.lblJumlahMenu.TabIndex = 14
        Me.lblJumlahMenu.Text = "x"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(141, 446)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Jumlah Menu :"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Image = Global.AplikasiRestoXXXX.My.Resources.Resources.icoSimpan
        Me.btnSimpan.Location = New System.Drawing.Point(21, 460)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(68, 64)
        Me.btnSimpan.TabIndex = 16
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 555)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblJumlahMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNamaKasir)
        Me.Controls.Add(Me.txtKembali)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblIDKasir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblIDJual)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FormPenjualan"
        Me.Text = "FormPenjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblIDJual As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblIDKasir As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNamaKasir As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNamaMenu As TextBox
    Friend WithEvents txtIDMenu As TextBox
    Friend WithEvents LVPenjualan As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCariMenu As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblJumlahMenu As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSimpan As Button
End Class
