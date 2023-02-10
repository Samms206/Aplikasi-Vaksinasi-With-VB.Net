Imports System.Data.SqlClient
Public Class JenisVaksinForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql = "select*from jenin_vaksin where nama_vaksin = '" + TextBox1.Text + "'"
        cmd = New SqlCommand(sql, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Vaksin yang anda inputkan sudah Tersedia!!!", MsgBoxStyle.Information)
        ElseIf TextBox1.Text = "" Then
            MsgBox("Form masih kosong", MsgBoxStyle.Information)
        Else
            Dim sqli = "insert into jenin_vaksin values('" + TextBox1.Text + "')"
            cmd = New SqlCommand(sqli, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Menambahkan!")
            TextBox1.Text = ""
            tampil()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Form masih kosong", MsgBoxStyle.Information)
        Else
            Dim sql = "update jenin_vaksin set nama_vaksin = '" + TextBox1.Text + "' where id='" + Label2.Text + "'"
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Mengupdate!")
            TextBox1.Text = ""
            tampil()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("form masih kosong!!")
        Else
            Dim tanya
            tanya = MsgBox("Yakin ingin menghapus Data Ini ? ", MessageBoxButtons.YesNo)
            If tanya = vbYes Then
                Dim sql = "delete from jenin_vaksin where id = '" + Label2.Text + "'"
                cmd = New SqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil Menghapus!")
                TextBox1.Text = ""
                tampil()
            Else

            End If
        End If
    End Sub

    Sub tampil()
        Dim sql = "select*from jenin_vaksin"
        da = New SqlDataAdapter(sql, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "jenin_vaksin")
        DataGridView1.DataSource = ds.Tables("jenin_vaksin")
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Label2.Text = DataGridView1.Item(0, i).Value
        TextBox1.Text = DataGridView1.Item(1, i).Value

    End Sub

    Private Sub JenisVaksinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub
End Class