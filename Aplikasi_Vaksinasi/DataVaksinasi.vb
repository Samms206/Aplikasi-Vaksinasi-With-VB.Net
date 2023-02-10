Imports System.Data.SqlClient
Public Class DataVaksinasi
    Private Sub DataVaksinasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        ComboBox1.Items.Add("proses")
        ComboBox1.Items.Add("selesai")
    End Sub
    Sub tampil()
        Dim sql = "select a.nik,nama,tanggal,d.periode,keterangan,d.id_vaksinasi from warga_tbl a, tbl_admin b, jenin_vaksin c, detail_vaksinasi d, vaksinasi e where (a.nik = e.nik and e.id = d.id_vaksinasi and d.id_jenisvaksin = c.id and d.id_dokter = b.id) "
        da = New SqlDataAdapter(sql, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Viewvaksinasi")
        DataGridView1.DataSource = ds.Tables("Viewvaksinasi")
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
        ComboBox1.Text = DataGridView1.Item(4, i).Value
        idvaksin.Text = DataGridView1.Item(5, i).Value
        TextBox4.Text = DataGridView1.Item(3, i).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Konfirmasi_Click(sender As Object, e As EventArgs) Handles Konfirmasi.Click
        If ComboBox1.Text = "" Then
            MsgBox("formmasih")
        Else
            Dim sql = "update detail_vaksinasi set keterangan ='" & ComboBox1.Text & "' where id_vaksinasi = '" & idvaksin.Text & "'"
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("berhasil")
            tampil()
        End If
    End Sub
End Class