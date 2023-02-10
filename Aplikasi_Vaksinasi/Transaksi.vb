Imports System.Data.SqlClient
Public Class Transaksi
    Dim jenis As String = ""
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampiljenisvaksin()
        cmb_periode.Items.Add("1")
        cmb_periode.Items.Add("2")
        tgl_now.Text = Today
        tampil()
        transaksi()
        Button2.Enabled = False
    End Sub
    Sub transaksi()
        Dim sql = "select*from vaksinasi where id in(select max(id) from vaksinasi) order by id desc"
        cmd = New SqlCommand(sql, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            id_vaksinasi2.Text = rd.Item("id")

        End If
    End Sub
    Sub tampil()
        Dim sql = "select * from warga_tbl"
        da = New SqlDataAdapter(sql, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "warga_tbl")
        DataGridView1.DataSource = ds.Tables("warga_tbl")
    End Sub

    Sub tampiljenisvaksin()
        'cmb_jenis.Items.Add("Omnicron 2")
        'cmb_jenis.Items.Add("Delta")
        'cmb_jenis.Items.Add("Ultron")
        'cmb_jenis.Items.Add("Astra Zeneca")
        'cmb_jenis.Items.Add("Vincon Delta 2")
        Dim sql = "select*from jenin_vaksin"
        cmd = New SqlCommand(sql, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Do While rd.Read
                cmb_jenis.Items.Add(rd("nama_vaksin"))
            Loop
        End If
    End Sub
    Sub coba()

    End Sub
    Sub bersih()
        tf_nik.Text = ""
        tf_nama.Text = ""
        tf_ttl.Text = ""
        cmb_periode.Text = ""
        cmb_jenis.Text = ""
        masukanNIK.Text = ""

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If tf_nik.Text = "" Or tf_nama.Text = "" Or tf_ttl.Text = "" Or cmb_jenis.Text = "" Or cmb_periode.Text = "" Then
            MsgBox("form masih kosong")

        ElseIf tf_nik.TextLength < 16 Then
            MsgBox("NIK yang anda masukkan tidak sesuai, silahkan Cek terlebih dahulu")
        Else
            Dim query = "select b.nik, periode,keterangan from vaksinasi b, detail_vaksinasi c where (b.id = c.id_vaksinasi  and nik = '" & tf_nik.Text & "' and periode = '1' and keterangan = 'proses')"
            cmd = New SqlCommand(query, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Vaksinasi Pertama NIK ini Masih dalam proses, silahkan hubungi Operator!", MsgBoxStyle.Information)
            Else
                Dim sqli = "insert into detail_vaksinasi values('" & id_vaksinasi2.Text & "','" & cmb_periode.Text & "','" & tgl_now.Text & "','" & jenis & "','" & id_dokter.Text & "','proses')"
                cmd = New SqlCommand(sqli, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil", MsgBoxStyle.Information)
                tampil()
                transaksi()
                Button2.Enabled = False
                Button1.Enabled = True
                bersih()
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql = "select id_vaksinasi,b.nik, periode from vaksinasi b, detail_vaksinasi c where (b.id = c.id_vaksinasi and b.nik = '" & masukanNIK.Text & "' and periode = '2')"
        cmd = New SqlCommand(sql, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("NIK ini sudah melakukan Vaksinasi yang ke-Dua!!", MsgBoxStyle.Information)
        Else
            Dim sqli = "select*from warga_tbl where nik = '" & masukanNIK.Text & "'"
            cmd = New SqlCommand(sqli, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim sqlp = "select id_vaksinasi,b.nik, periode from vaksinasi b, detail_vaksinasi c where (b.id = c.id_vaksinasi and b.nik = '" & masukanNIK.Text & "' and periode = '1')"
                cmd = New SqlCommand(sqlp, conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Dim tanya
                    tanya = MsgBox("NIK ini sudah pernah melakukan Vaksinasi Pertama, ingin lanjut ke Periode ke 2 ?", MessageBoxButtons.YesNo, MsgBoxStyle.Question)
                    If tanya = vbYes Then
                        Dim sqliv = "insert into vaksinasi values('" & masukanNIK.Text & "')"
                        cmd = New SqlCommand(sqliv, conn)
                        cmd.ExecuteNonQuery()
                        MsgBox("Berhasil")
                        cmb_periode.Text = 2
                        id_vaksinasi2.Focus()
                        tf_nik.Text = masukanNIK.Text
                        Button1.Enabled = False
                        transaksi()
                        Button2.Enabled = True
                    End If

                Else
                    Dim sqlivi = "insert into vaksinasi values('" & masukanNIK.Text & "')"
                    cmd = New SqlCommand(sqlivi, conn)
                    cmd.ExecuteNonQuery()
                    cmb_periode.Text = 1
                    MsgBox("Berhasil")
                    id_vaksinasi2.Focus()
                    tf_nik.Text = masukanNIK.Text
                    Button1.Enabled = False
                    transaksi()
                    Button2.Enabled = True
                End If
            Else
                MsgBox("NIK tidak ditemukan!!", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Sub test()

    End Sub

    Private Sub masukanNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles masukanNIK.KeyPress
        Dim key As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse key = Keys.Back) Then
            key = 0
        Else
            e.Handled = CBool(key)
        End If
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
        masukanNIK.MaxLength = 16
        If e.KeyChar = Chr(13) Then
            Button1.Focus()

        End If

    End Sub

    Private Sub tf_nik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tf_nik.KeyPress
        Dim key As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse key = Keys.Back) Then
            key = 0
        Else
            e.Handled = CBool(key)
        End If
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
        masukanNIK.MaxLength = 16
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub masukanNIK_TextChanged(sender As Object, e As EventArgs) Handles masukanNIK.TextChanged

    End Sub

    Private Sub id_vaksinasi_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub id_vaksinasi_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            tf_nik.Focus()
        End If
    End Sub


    Private Sub cmb_jenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jenis.SelectedIndexChanged
        If cmb_jenis.Text = "Omnicron 2" Then
            jenis = "4"
        ElseIf cmb_jenis.Text = "Delta" Then
            jenis = "5"
        ElseIf cmb_jenis.Text = "Ultron" Then
            jenis = "6"
        ElseIf cmb_jenis.Text = "Astra Zeneca" Then
            jenis = "7"
        ElseIf cmb_jenis.Text = "Vincon Delta 2" Then
            jenis = "8"
        End If

    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        tf_nik.Text = DataGridView1.Item(0, i).Value
        masukanNIK.Text = DataGridView1.Item(0, i).Value
        tf_nama.Text = DataGridView1.Item(1, i).Value
        tf_ttl.Text = DataGridView1.Item(3, i).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim query = "select * from warga_tbl where nama Like '%" & TextBox1.Text & "%'"
        cmd = New SqlCommand(query, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Dim sql = "select * from warga_tbl where nama Like '%" & TextBox1.Text & "%'"
            da = New SqlDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "warga_tbl")
            DataGridView1.DataSource = ds.Tables("warga_tbl")
        End If
    End Sub
End Class