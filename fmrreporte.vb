Public Class fmrreporte
    Private Sub fmrreporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rpt_prueba As New CrystalReport1
        'Dim ocInforme As New ReportDocument
        rpt_prueba.Load(Nothing)
        rpt_prueba.DataSourceConnections.Item(0).SetConnection("CESARPC\SQLEXPRESS", "SistemaEstudiosMedicos", False)
        'rpt_prueba.DataSourceConnections.Item(0).SetLogon("sa", "Gestion123456")
        rpt_prueba.DataSourceConnections.Item(0).IntegratedSecurity = True

        CrystalReportViewer1.ReportSource = rpt_prueba
        CrystalReportViewer1.RefreshReport()

    End Sub
End Class