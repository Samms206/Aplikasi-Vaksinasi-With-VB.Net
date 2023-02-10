Public Class FormLaporan
    Private Sub Cetak_Click(sender As Object, e As EventArgs) Handles Cetak.Click
        acrx.ReportFileName = "LaporanDataWarga.rpt"
        acrx.WindowState = Crystal.WindowStateConstants.crptMaximized
        acrx.RetrieveDataFiles()
        acrx.Action = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        acrx.SelectionFormula = "{asdsd.tanggal} <= '" & daritanggal.Value & "' and {adsa.tanggal} >= '" & sampaitanggal.Value & "'"
        acrx.ReportFileName = "LaporanDataWarga.rpt"
        acrx.WindowState = Crystal.WindowStateConstants.crptMaximized
        acrx.RetrieveDataFiles()
        acrx.Action = 1
    End Sub
End Class