Imports System.Data.SqlClient
Public Class AdminForm

    Dim status As String = ""
    Dim level As String = ""
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Tidak Aktif")
        ComboBox1.Items.Add("Aktif")
        ComboBox2.Items.Add("Operator")
        ComboBox2.Items.Add("Dokter")
        tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If username.Text = "" Or pass.Text = "" Or ulangi.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Form masih kosong", MsgBoxStyle.Information)
        ElseIf pass.Text = ulangi.Text Then
            Dim sql = "insert into tbl_admin values('" + username.Text + "','" + pass.Text + "','" + Label7.Text + "','" + Label8.Text + "')"
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Menambahkan!")
            tampil()
            bersih()
        Else
            MsgBox("password tidak sama", MsgBoxStyle.Information)

        End If
    End Sub
    Sub tampil()
        Dim sql = "select*from tbl_admin"
        da = New SqlDataAdapter(sql, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_admin")
        DataGridView1.DataSource = ds.Tables("tbl_admin")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If username.Text = "" Or pass.Text = "" Or ulangi.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Form masih kosong", MsgBoxStyle.Information)
        ElseIf pass.Text = ulangi.Text Then
            Dim sql = "update tbl_admin set username ='" + username.Text + "', password = '" + pass.Text + "', status_aktif='" + Label7.Text + "', tingkat='" + Label8.Text + "' where id='" + Label5.Text + "'"
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Mengubah!")
            tampil()
            bersih()
        Else
            MsgBox("Password tidak Sama!!", MsgBoxStyle.Information)
            pass.Focus()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tanya
        If username.Text = "" Then
            MsgBox("form masih kosong!!")
        Else
            tanya = MsgBox("yakin ingin menghapus data ini?", MessageBoxButtons.YesNo)
            If tanya = vbYes Then
                Dim sql = "delete from tbl_admin where id='" + Label5.Text + "'"
                cmd = New SqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil Menghapus!")
                bersih()
                tampil()
            Else

            End If
        End If

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Label5.Text = DataGridView1.Item(0, i).Value
        username.Text = DataGridView1.Item(1, i).Value
        pass.Text = DataGridView1.Item(2, i).Value
        ComboBox1.Text = DataGridView1.Item(3, i).Value
        ComboBox2.Text = DataGridView1.Item(4, i).Value

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bersih()
    End Sub
    Sub bersih()
        username.Text = ""
        pass.Text = ""
        ulangi.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        tampil()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        Dim key As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse key = Keys.Back) Then
            key = 0
        Else
            e.Handled = CBool(key)
        End If
        ComboBox1.MaxLength = 1
        If e.KeyChar = Chr(13) Then
            ComboBox2.Focus()
        End If
    End Sub
    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        Dim key As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse key = Keys.Back) Then
            key = 0
        Else
            e.Handled = CBool(key)
        End If
        ComboBox1.MaxLength = 1
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        If e.KeyChar = Chr(13) Then
            pass.Focus()
        End If
    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub

    Private Sub pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pass.KeyPress
        If e.KeyChar = Chr(13) Then
            ulangi.Focus()
        End If
    End Sub




    Private Sub ulangi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ulangi.KeyPress
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()
        End If
    End Sub


    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Tidak Aktif" Then
            status = "0"
            Label7.Text = status
        Else
            status = "1"
            Label7.Text = status
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Operator" Then
            level = "1"
            Label8.Text = level
        Else
            level = "2"
            Label8.Text = level
        End If
    End Sub
End Class