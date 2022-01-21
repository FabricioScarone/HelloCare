Imports System.ComponentModel
Imports System.Globalization
Imports CapaLogica
Imports Clases

Public Class FrmContrasenaOlvidada
    Private Sub btnEnviarCodigo_Click(sender As Object, e As EventArgs) Handles btnEnviarCodigo.Click
        Dim ci As String = txtCedula.Text

        Dim estadoPersonaEnBD As ResultadosLogin
        Try
            estadoPersonaEnBD = AutenticarUsuarioAdministrativo(ci, ".")
        Catch ex As Exception
            MostrarMensaje(MsgBoxStyle.Critical, "No se han encontrado datos registrados para un administrativo con esta cédula.", "Error", "No registered data was found for an administrative with this ID card.", "Error")
            Return
        End Try

        Try
            EnviarCorreoRestauracionContrasena(CargarAdministrativoPorCI(ci))
            MostrarMensaje(MsgBoxStyle.Information, "Se ha enviado un correo electrónico a su casilla con pasos para restaurar su contraseña. No cierre esta ventana.", "", "An e-mail has been sent to your e-mail address with steps to restore your password. Don't close this window.", "")
            txtCedula.Enabled = False
            btnEnviarCodigo.Enabled = False
            lblCodigo.Visible = True
            txtCodigo.Visible = True
            btnConfirmar.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        EliminarUsuarioConCodigo(txtCedula.Text, TiposUsuario.Administrativo, txtCodigo.Text)
        MostrarMensaje(MsgBoxStyle.Information, "Se ha eliminado tu contraseña exitosamente. Por favor, inicia sesión utilizando únicamente tu cédula.", "", "Your password has been successfully deleted. Please sign in using only your ID card.", "")
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmContrasenaOlvidada_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class