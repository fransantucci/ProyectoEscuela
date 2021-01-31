Imports Microsoft.Reporting.WinForms
Public Class frmTotalAprobados
    Private Sub frmTotalAprobados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()

        DA = New SqlClient.SqlDataAdapter(Informe, Conexion)
        DT = New DataTable
        DA.Fill(DT)

        ReportViewer1.LocalReport.ReportPath = "C:\Users\Fran\source\repos\TP_Final_DYADM_BD\TP_Final_DYADM_BD\repAlumnosAprobados.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetAprobados", DT))

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class

