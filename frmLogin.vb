Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        cmbUsuarioTipo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbUsuarioTipo.SelectedIndex = 0
    End Sub

    Private Sub btnMostrarContrasenia_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMostrarContrasenia.MouseDown
        txtContrasenia.PasswordChar = ""
    End Sub

    Private Sub btnMostrarContrasenia_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMostrarContrasenia.MouseUp
        txtContrasenia.PasswordChar = "*"
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'en la base de datos, poner un campo Tipo_Usuario (Profesor y Administrador con su 
        '"Acceso Log" para mostrar distintos menúes según usuario. Por hora solucionado 
        'con un combo box.

        'por ahora lo dejo para no tener que ingresar las contraseñas cada vez que pruebo algo.
        Select Case cmbUsuarioTipo.SelectedIndex
            Case 0 'Alumno
                AccesoLog = "Alumno"
                frmPrincipal.Show()
                Me.Dispose()

            Case 1 'Profesor
                AccesoLog = "Profesor"
                txtUsuario.Text = GenerarHash256("12345")
                frmPrincipal.Show()
                Me.Dispose()
            Case 2 'Alumno
                '0 = pruebas sin solcitar usuario y contraseña (se ve lo mismo que 
                'como administrador, o sea, todos los menúes)
                AccesoLog = "Administrador"
                frmPrincipal.Show()
                Me.Dispose()
        End Select
    End Sub
End Class
