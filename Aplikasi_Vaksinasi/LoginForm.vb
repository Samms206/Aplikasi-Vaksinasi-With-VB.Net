Imports System.Data.SqlClient
Public Class Login
    Dim level As String = ""
    Dim iddokter As String = ""
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tf_username.Focus()
        Call koneksi()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sql = "select*from tbl_admin where username='" & tf_username.Text & "' and password='" & tf_pasword.Text & "'"
            cmd = New SqlCommand(sql, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If rd("tingkat") = "1" Then
                    MsgBox("Selamat Datang Operator", MsgBoxStyle.Information)
                    Form1.Show()
                    Me.Hide()
                    Transaksi.tf_dokter.Text = tf_username.Text
                    coba()
                Else
                    MsgBox("Selamat Datang Dokter", MsgBoxStyle.Information)
                    Form1.Show()
                    Me.Hide()
                    Form1.DataJenisVaksinToolStripMenuItem.Enabled = "false"
                    Form1.DataOperatorToolStripMenuItem.Enabled = "false"
                    Form1.LaporanToolStripMenuItem.Enabled = "false"
                    Form1.Periode2ToolStripMenuItem.Enabled = False
                    WargaForm.Button3.Enabled = False
                    Transaksi.tf_dokter.Text = tf_username.Text
                    coba()
                End If
            Else
                MsgBox("Username/Password Salah!", MsgBoxStyle.Critical)
                tf_username.Focus()
            End If

        Catch ex As Exception
            MsgBox("gagal " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub tf_username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tf_username.KeyPress
        If e.KeyChar = Chr(13) Then
            tf_pasword.Focus()

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            tf_pasword.PasswordChar = ""
        Else
            tf_pasword.PasswordChar = "*"

        End If
    End Sub

    Private Sub tf_username_TextChanged(sender As Object, e As EventArgs) Handles tf_username.TextChanged

    End Sub

    Private Sub tf_pasword_TextChanged(sender As Object, e As EventArgs) Handles tf_pasword.TextChanged

    End Sub

    Private Sub tf_pasword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tf_pasword.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub
    Sub coba()
        If tf_username.Text = "operator2" Then
            iddokter = "1"
            Transaksi.id_dokter.Text = iddokter
        ElseIf tf_username.Text = "dokter1" Then
            iddokter = "2"
            Transaksi.id_dokter.Text = iddokter
        ElseIf tf_username.Text = "samsul" Then
            iddokter = "7"
            Transaksi.id_dokter.Text = iddokter
        ElseIf tf_username.Text = "husnul" Then
            iddokter = "8"
            Transaksi.id_dokter.Text = iddokter
        End If
    End Sub
End Class