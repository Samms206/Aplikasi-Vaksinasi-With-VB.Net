Imports System.Data.SqlClient
Module ModuleKoneksi
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public ds As DataSet
    Public rd As SqlDataReader
    Public da As SqlDataAdapter
    Public lokasi As String
    Sub koneksi()
        Try
            lokasi = "Data Source =LAPTOP-LCO9BIGR;Initial Catalog=vaksinasi;Integrated Security=true;MultipleActiveResultSets=true"
            conn = New SqlConnection(lokasi)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("gagal" + ex.Message)

        End Try
    End Sub
End Module
