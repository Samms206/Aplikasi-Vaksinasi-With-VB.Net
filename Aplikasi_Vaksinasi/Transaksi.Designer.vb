<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.id_vaksinasi2 = New System.Windows.Forms.Label()
        Me.id_dokter = New System.Windows.Forms.TextBox()
        Me.tgl_now = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.masukanNIK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tf_dokter = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_periode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_jenis = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tf_ttl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tf_nama = New System.Windows.Forms.TextBox()
        Me.tf_nik = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.id_vaksinasi2)
        Me.GroupBox1.Controls.Add(Me.id_dokter)
        Me.GroupBox1.Controls.Add(Me.tgl_now)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.masukanNIK)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 268)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Warga"
        '
        'id_vaksinasi2
        '
        Me.id_vaksinasi2.AutoSize = True
        Me.id_vaksinasi2.ForeColor = System.Drawing.Color.White
        Me.id_vaksinasi2.Location = New System.Drawing.Point(178, 122)
        Me.id_vaksinasi2.Name = "id_vaksinasi2"
        Me.id_vaksinasi2.Size = New System.Drawing.Size(42, 25)
        Me.id_vaksinasi2.TabIndex = 8
        Me.id_vaksinasi2.Text = "000"
        '
        'id_dokter
        '
        Me.id_dokter.BackColor = System.Drawing.Color.White
        Me.id_dokter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_dokter.Enabled = False
        Me.id_dokter.ForeColor = System.Drawing.Color.Black
        Me.id_dokter.Location = New System.Drawing.Point(207, 121)
        Me.id_dokter.Name = "id_dokter"
        Me.id_dokter.Size = New System.Drawing.Size(56, 24)
        Me.id_dokter.TabIndex = 7
        Me.id_dokter.Visible = False
        '
        'tgl_now
        '
        Me.tgl_now.AutoSize = True
        Me.tgl_now.ForeColor = System.Drawing.Color.White
        Me.tgl_now.Location = New System.Drawing.Point(275, 225)
        Me.tgl_now.Name = "tgl_now"
        Me.tgl_now.Size = New System.Drawing.Size(156, 25)
        Me.tgl_now.TabIndex = 4
        Me.tgl_now.Text = "tanggal_sekarang"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(27, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CEK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'masukanNIK
        '
        Me.masukanNIK.Location = New System.Drawing.Point(27, 67)
        Me.masukanNIK.Name = "masukanNIK"
        Me.masukanNIK.Size = New System.Drawing.Size(404, 31)
        Me.masukanNIK.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Masukan NIK"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tf_dokter)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmb_periode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmb_jenis)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tf_ttl)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tf_nama)
        Me.GroupBox2.Controls.Add(Me.tf_nik)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(494, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(758, 331)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daftar"
        '
        'tf_dokter
        '
        Me.tf_dokter.BackColor = System.Drawing.Color.White
        Me.tf_dokter.Enabled = False
        Me.tf_dokter.ForeColor = System.Drawing.Color.Black
        Me.tf_dokter.Location = New System.Drawing.Point(521, 214)
        Me.tf_dokter.Name = "tf_dokter"
        Me.tf_dokter.Size = New System.Drawing.Size(256, 31)
        Me.tf_dokter.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(17, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(722, 42)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Proses Vaksinasi"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(478, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nama Dokter"
        '
        'cmb_periode
        '
        Me.cmb_periode.FormattingEnabled = True
        Me.cmb_periode.Location = New System.Drawing.Point(250, 217)
        Me.cmb_periode.Name = "cmb_periode"
        Me.cmb_periode.Size = New System.Drawing.Size(227, 33)
        Me.cmb_periode.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Periode"
        '
        'cmb_jenis
        '
        Me.cmb_jenis.FormattingEnabled = True
        Me.cmb_jenis.Location = New System.Drawing.Point(17, 217)
        Me.cmb_jenis.Name = "cmb_jenis"
        Me.cmb_jenis.Size = New System.Drawing.Size(227, 33)
        Me.cmb_jenis.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jenis Vaksin"
        '
        'tf_ttl
        '
        Me.tf_ttl.Location = New System.Drawing.Point(17, 142)
        Me.tf_ttl.Name = "tf_ttl"
        Me.tf_ttl.Size = New System.Drawing.Size(722, 31)
        Me.tf_ttl.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tempat Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nama"
        '
        'tf_nama
        '
        Me.tf_nama.Location = New System.Drawing.Point(391, 69)
        Me.tf_nama.Name = "tf_nama"
        Me.tf_nama.Size = New System.Drawing.Size(348, 31)
        Me.tf_nama.TabIndex = 5
        '
        'tf_nik
        '
        Me.tf_nik.Location = New System.Drawing.Point(17, 69)
        Me.tf_nik.Name = "tf_nik"
        Me.tf_nik.Size = New System.Drawing.Size(348, 31)
        Me.tf_nik.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NIK"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 349)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1240, 262)
        Me.DataGridView1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 303)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 26)
        Me.TextBox1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(281, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "*cari berdasarkan nama!"
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 623)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents masukanNIK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tf_dokter As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_periode As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_jenis As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tf_ttl As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tf_nama As TextBox
    Friend WithEvents tf_nik As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tgl_now As Label
    Friend WithEvents id_dokter As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents id_vaksinasi2 As Label
End Class
