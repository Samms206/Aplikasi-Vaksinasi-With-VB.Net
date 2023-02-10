Public Class Form1
    Private Sub DataWargaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataWargaToolStripMenuItem1.Click
        WargaForm.MdiParent = Me
        WargaForm.Show()
    End Sub

    Private Sub DataJenisVaksinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataJenisVaksinToolStripMenuItem.Click
        JenisVaksinForm.MdiParent = Me
        JenisVaksinForm.Show()
    End Sub

    Private Sub DataOperatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataOperatorToolStripMenuItem.Click
        AdminForm.MdiParent = Me
        AdminForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Login.Show()
        Login.tf_username.Text = ""
        Login.tf_pasword.Text = ""

    End Sub

    Private Sub LaporanDataWargaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataWargaToolStripMenuItem.Click
        FormLaporan.MdiParent = Me
        FormLaporan.Show()
    End Sub

    Private Sub VaksinasiPeriode1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VaksinasiPeriode1ToolStripMenuItem.Click
        Transaksi.MdiParent = Me
        Transaksi.Show()
    End Sub

    Private Sub LaporanVaksinasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanVaksinasiToolStripMenuItem.Click
        LaporanVaksinasi.MdiParent = Me
        LaporanVaksinasi.Show()
    End Sub

    Private Sub Periode2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Periode2ToolStripMenuItem.Click
        DataVaksinasi.MdiParent = Me
        DataVaksinasi.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
