Public Class frmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmAluAlta.MdiParent = Me
        frmAluBaja.MdiParent = Me
        frmAluMod.MdiParent = Me
        frmMatAlta.MdiParent = Me
        frmMatBaja.MdiParent = Me
        frmMatMod.MdiParent = Me
        frmProfAlta.MdiParent = Me
        frmProfBaja.MdiParent = Me
        frmProfMod.MdiParent = Me
        frmExamenAlta.MdiParent = Me
        frmExamenBaja.MdiParent = Me
        frmExamenMod.MdiParent = Me
        frmTotAluInsc.MdiParent = Me
        frmTotalAprobados.MdiParent = Me
        frmAluInscMat.MdiParent = Me
        frmDatTurnos.MdiParent = Me
        frmCambiarPass.MdiParent = Me
        Select Case AccesoLog
            Case "Profesor"
                mnuAlumno.Visible = False
                mnuMaterias.Visible = False
                mnuProfesores.Visible = False
                mnuExamenBaja.Visible = False
                mnuExamenMod.Visible = False
            Case "Alumno"
                mnuAlumno.Visible = False
                mnuMaterias.Visible = False
                mnuProfesores.Visible = False
                mnuExamen.Visible = False
                mnuTotAluApro.Visible = False
                mnuTotAluInsc.Visible = False
                mnuAluInscMat.Visible = False
            Case "Administrador"
                mnuAlumno.Visible = True
                mnuMaterias.Visible = True
                mnuProfesores.Visible = True
                mnuExamen.Visible = True
                mnuReportes.Visible = True
                mnuOtros.Visible = True
            Case Else
                MsgBox("Error de loggeo, por favor intente nuevamente", vbOKOnly + vbCritical)
                Me.Dispose()
                frmLogin.Show()
        End Select
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub mnuAluAlta_Click(sender As Object, e As EventArgs) Handles mnuAluAlta.Click
        frmAluAlta.Show()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Me.Dispose()
        frmLogin.ShowDialog()
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Application.Exit()
    End Sub

    Private Sub mnuAluBaja_Click(sender As Object, e As EventArgs) Handles mnuAluBaja.Click
        frmAluAlta.Dispose()
        frmAluBaja.Show()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()
    End Sub

    Private Sub mnuAluMod_Click(sender As Object, e As EventArgs) Handles mnuAluMod.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Show()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()
    End Sub

    Private Sub mnuMatAlta_Click(sender As Object, e As EventArgs) Handles mnuMatAlta.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Show()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuMatBaja_Click(sender As Object, e As EventArgs) Handles mnuMatBaja.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Show()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuMatMod_Click(sender As Object, e As EventArgs) Handles mnuMatMod.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Show()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuProfAlta_Click(sender As Object, e As EventArgs) Handles mnuProfAlta.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Show()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuProfBaja_Click(sender As Object, e As EventArgs) Handles mnuProfBaja.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Show()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuProfMod_Click(sender As Object, e As EventArgs) Handles mnuProfMod.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Show()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuExamenAlta_Click(sender As Object, e As EventArgs) Handles mnuExamenAlta.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Show()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuExamenBaja_Click(sender As Object, e As EventArgs) Handles mnuExamenBaja.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Show()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuExamenMod_Click(sender As Object, e As EventArgs) Handles mnuExamenMod.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Show()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuTotAluInsc_Click(sender As Object, e As EventArgs) Handles mnuTotAluInsc.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Show()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuTotAluApro_Click(sender As Object, e As EventArgs) Handles mnuTotAluApro.Click

        Dim cadenaSql As String

        cadenaSql = "select tur.cod_turno, (select count(exa.nota) from Examenes exa where exa.nota >= 7 and exa.cod_turno = tur.cod_turno) * 100 / count(exa.nota) as 'PercAprobados' from Turnos tur, Examenes exa where exa.cod_turno = tur.cod_turno group by tur.cod_turno"

        Informe = cadenaSql

        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Show()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()



    End Sub

    Private Sub mnuAluInscMat_Click(sender As Object, e As EventArgs) Handles mnuAluInscMat.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Show()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuDatTurnos_Click(sender As Object, e As EventArgs) Handles mnuDatTurnos.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Show()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuCambiarPass_Click(sender As Object, e As EventArgs) Handles mnuCambiarPass.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        frmMatBaja.Dispose()
        frmMatMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmExamenBaja.Dispose()
        frmExamenMod.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Show()
    End Sub
End Class