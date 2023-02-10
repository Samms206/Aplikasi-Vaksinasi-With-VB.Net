Public Class LaporanVaksinasi
    Private Sub LaporanVaksinasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        axr.ReportFileName = "LaopranVaksinasi.rpt"
        axr.WindowState = Crystal.WindowStateConstants.crptMaximized
        axr.RetrieveDataFiles()
        axr.Action = 1
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If DateTimePicker1.Value < DateTimePicker2.Value Then
            TextBox1.Text = DateDiff(DateInterval.Day, CDate(DateTimePicker1.Text), CDate(DateTimePicker2.Text))
        End If
    End Sub
End Class