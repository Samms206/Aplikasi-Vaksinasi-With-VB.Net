<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataWargaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataJenisVaksinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataOperatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VaksinasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VaksinasiPeriode1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Periode2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataWargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanVaksinasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMasterToolStripMenuItem, Me.VaksinasiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1001, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataWargaToolStripMenuItem1, Me.DataJenisVaksinToolStripMenuItem, Me.DataOperatorToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(124, 29)
        Me.DataMasterToolStripMenuItem.Text = "&Data Master"
        '
        'DataWargaToolStripMenuItem1
        '
        Me.DataWargaToolStripMenuItem1.Name = "DataWargaToolStripMenuItem1"
        Me.DataWargaToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.DataWargaToolStripMenuItem1.Size = New System.Drawing.Size(310, 34)
        Me.DataWargaToolStripMenuItem1.Text = "Data Warga"
        '
        'DataJenisVaksinToolStripMenuItem
        '
        Me.DataJenisVaksinToolStripMenuItem.Name = "DataJenisVaksinToolStripMenuItem"
        Me.DataJenisVaksinToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.DataJenisVaksinToolStripMenuItem.Size = New System.Drawing.Size(310, 34)
        Me.DataJenisVaksinToolStripMenuItem.Text = "Data Jenis Vaksin"
        '
        'DataOperatorToolStripMenuItem
        '
        Me.DataOperatorToolStripMenuItem.Name = "DataOperatorToolStripMenuItem"
        Me.DataOperatorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.DataOperatorToolStripMenuItem.Size = New System.Drawing.Size(310, 34)
        Me.DataOperatorToolStripMenuItem.Text = "Data Operator"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(307, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(310, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'VaksinasiToolStripMenuItem
        '
        Me.VaksinasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VaksinasiPeriode1ToolStripMenuItem, Me.Periode2ToolStripMenuItem})
        Me.VaksinasiToolStripMenuItem.Name = "VaksinasiToolStripMenuItem"
        Me.VaksinasiToolStripMenuItem.Size = New System.Drawing.Size(99, 29)
        Me.VaksinasiToolStripMenuItem.Text = "&Vaksinasi"
        '
        'VaksinasiPeriode1ToolStripMenuItem
        '
        Me.VaksinasiPeriode1ToolStripMenuItem.Name = "VaksinasiPeriode1ToolStripMenuItem"
        Me.VaksinasiPeriode1ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.VaksinasiPeriode1ToolStripMenuItem.Size = New System.Drawing.Size(288, 34)
        Me.VaksinasiPeriode1ToolStripMenuItem.Text = "Daftar"
        '
        'Periode2ToolStripMenuItem
        '
        Me.Periode2ToolStripMenuItem.Name = "Periode2ToolStripMenuItem"
        Me.Periode2ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.Periode2ToolStripMenuItem.Size = New System.Drawing.Size(288, 34)
        Me.Periode2ToolStripMenuItem.Text = "Data Vaksinasi"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataWargaToolStripMenuItem, Me.LaporanVaksinasiToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.LaporanToolStripMenuItem.Text = "&Laporan"
        '
        'LaporanDataWargaToolStripMenuItem
        '
        Me.LaporanDataWargaToolStripMenuItem.Name = "LaporanDataWargaToolStripMenuItem"
        Me.LaporanDataWargaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LaporanDataWargaToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.LaporanDataWargaToolStripMenuItem.Text = "Laporan Data Warga"
        '
        'LaporanVaksinasiToolStripMenuItem
        '
        Me.LaporanVaksinasiToolStripMenuItem.Name = "LaporanVaksinasiToolStripMenuItem"
        Me.LaporanVaksinasiToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.LaporanVaksinasiToolStripMenuItem.Text = "Laporan Vaksinasi"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1001, 557)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Aplikasi Vaksinasi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataJenisVaksinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataWargaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataOperatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VaksinasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents VaksinasiPeriode1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Periode2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanDataWargaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanVaksinasiToolStripMenuItem As ToolStripMenuItem
End Class
