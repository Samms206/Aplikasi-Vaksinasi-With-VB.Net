Imports System.Data.SqlClient
Public Class WargaForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim query = "select*from warga_tbl where nik = '" & nik.Text & "'"
            cmd = New SqlCommand(query, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("NIK yang anda masukan sudah Ada", MsgBoxStyle.Information)
                nik.Focus()
            ElseIf nik.Text = "" Or nama.Text = "" Or tempat.Text = "" Or tglLahir.Text = "" Or alamat.Text = "" Or nohp.Text = "" Then
                MsgBox("form belum terisi!!", MsgBoxStyle.Information)
            ElseIf nik.TextLength < 16 Then
                MsgBox("NIK yang anda masukan tidak lengkap!!", MsgBoxStyle.Information)
                nik.Focus()
            Else
                Dim sql = "insert into warga_tbl values('" & nik.Text & "','" & nama.Text & "','" & tempat.Text & "','" & tglLahir.Text & "','" & alamat.Text & "','" & nohp.Text & "','" & id_operator.Text & "')"
                cmd = New SqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil menambahkan Warga")
                tampil()
                bersih()
            End If
        Catch ex As Exception
            MsgBox("gagal" + ex.Message)
        End Try
    End Sub

    Private Sub WargaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tanggal.Text = Today
        waktu.Text = TimeOfDay
        tampil()
        id_operator.Text = Login.Label6.Text

    End Sub
    Sub tampil()
        Dim sql = "select*from warga_tbl"
        da = New SqlDataAdapter(sql, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "warga_tbl")
        DataGridView1.DataSource = ds.Tables("warga_tbl")

    End Sub

    Private Sub nik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nik.KeyPress
        Dim key As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse key = Keys.Back) Then
            key = 0
        Else
            e.Handled = CBool(key)
        End If
        If e.KeyChar = Chr(13) Then
            nama.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim query = "select*from warga_tbl where nik = '" & nik.Text & "'"
            cmd = New SqlCommand(query, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If nik.Text = "" Or nama.Text = "" Or tempat.Text = "" Or tglLahir.Text = "" Or alamat.Text = "" Or nohp.Text = "" Then
                    MsgBox("form belum terisi!!", MsgBoxStyle.Information)
                Else
                    Dim sql = "update warga_tbl set nama = '" & nama.Text & "', tempat_lahir = '" + tempat.Text + "', tanggal_lahir = '" & tglLahir.Text & "', alamat = '" & alamat.Text & "', nohp = '" & nohp.Text & "' where nik = '" & nik.Text & "'"
                    cmd = New SqlCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Berhasil Mengupdate Data")
                    tampil()
                    bersih()
                End If
            Else
                MsgBox("Data Tidak Ada!!, silahkan cek NIK yang anda Inputkan!!!", MsgBoxStyle.Information)
                nik.Focus()
            End If
        Catch ex As Exception
            MsgBox("gagal")
        End Try
    End Sub
    Sub bersih()
        nama.Text = ""
        nik.Text = ""
        alamat.Text = ""
        nohp.Text = ""
        tempat.Text = ""
        tglLahir.Text = ""

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        nik.Text = DataGridView1.Item(0, i).Value
        nama.Text = DataGridView1.Item(1, i).Value
        tempat.Text = DataGridView1.Item(2, i).Value
        tglLahir.Text = DataGridView1.Item(3, i).Value
        alamat.Text = DataGridView1.Item(4, i).Value
        nohp.Text = DataGridView1.Item(5, i).Value

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If nik.Text = "" Then
                MsgBox("form belum terisi!!", MsgBoxStyle.Information)
            Else
                Dim tanya
                tanya = MsgBox("yakin ingin menghapus data ini?", MessageBoxButtons.YesNo, MsgBoxStyle.Question)
                If tanya = vbYes Then
                    Dim sql = "delete from warga_tbl where nik = '" + nik.Text + "'"
                    cmd = New SqlCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Berhasil Menghapus Data")
                    tampil()
                    bersih()
                Else
                End If
            End If
        Catch ex As Exception
            MsgBox("gagal")
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bersih()
        tampil()
    End Sub

    Private Sub nohp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nohp.KeyPress
        Dim key As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse key = Keys.Back) Then
            key = 0
        Else
            e.Handled = CBool(key)
        End If
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub nik_TextChanged(sender As Object, e As EventArgs) Handles nik.TextChanged
        nik.MaxLength = 16
    End Sub

    Private Sub nohp_TextChanged(sender As Object, e As EventArgs) Handles nohp.TextChanged
        nohp.MaxLength = 15
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim sql = "select*from warga_tbl where nama like '%" & TextBox1.Text & "%'"
        cmd = New SqlCommand(sql, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Dim sqli = "select*from warga_tbl where nama like '%" & TextBox1.Text & "%'"
            da = New SqlDataAdapter(sqli, conn)
            ds = New DataSet
            da.Fill(ds, "warga_tbl")
            DataGridView1.DataSource = ds.Tables("warga_tbl")
        End If
    End Sub

    Private Sub nama_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged

    End Sub

    Private Sub nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nama.KeyPress
        If e.KeyChar = Chr(13) Then
            tempat.Focus()
        End If
    End Sub

    Private Sub tempat_TextChanged(sender As Object, e As EventArgs) Handles tempat.TextChanged

    End Sub

    Private Sub tempat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tempat.KeyPress
        If e.KeyChar = Chr(13) Then
            tglLahir.Focus()
        End If
    End Sub

    Private Sub tglLahir_ValueChanged(sender As Object, e As EventArgs) Handles tglLahir.ValueChanged

    End Sub

    Private Sub tglLahir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tglLahir.KeyPress
        If e.KeyChar = Chr(13) Then
            alamat.Focus()
        End If
    End Sub

    Private Sub alamat_TextChanged(sender As Object, e As EventArgs) Handles alamat.TextChanged

    End Sub

    Private Sub alamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alamat.KeyPress
        If e.KeyChar = Chr(13) Then
            nohp.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class