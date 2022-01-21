Imports System.Drawing
Imports Clases
Imports CapaLogica
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Globalization

Public Class FrmRegistro
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtContrasena.Text.Length < 8 Or txtContrasena.Text.Length > 50 Then
            MostrarMensaje(MsgBoxStyle.Critical, "El largo de la contraseña debe ser de entre 8 y 50 caracteres.", "Error", "The length of the password must be between 8 and 50 characters.", "Error")
            Return
        End If

        If txtContrasena.Text <> txtRepetir.Text Then
            MostrarMensaje(MsgBoxStyle.Exclamation, "Las contraseñas no coinciden. Verifique los datos ingresados y reintente.", "Error", "Passwords don't match. Verify your entered passwords and retry.", "Error")
            Return
        End If

        Try
            RegistrarUsuario(pacienteLogeado, txtContrasena.Text)
            MostrarMensaje(MsgBoxStyle.Information, "Su contraseña ha sido guardada. Se envió un correo electrónico a la dirección de correo proporcionada por usted con los datos de su registro. Cierre este mensaje para continuar al menú principal." & vbNewLine & vbNewLine & "¡Muchas gracias por utilizar HelloCare!", "Usuario registrado", "Your password has been saved. An e-mail has been sent to your e-mail address with information about your registration. Close this message to continue to the main menu." & vbNewLine & vbNewLine & "¡Muchas gracias por utilizar HelloCare!", "User created")
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkMostrarContrasena_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarContrasena.CheckedChanged
        If chkMostrarContrasena.Checked Then
            txtContrasena.UseSystemPasswordChar = False
            txtRepetir.UseSystemPasswordChar = False
        Else
            txtContrasena.UseSystemPasswordChar = True
            txtRepetir.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmRegistro_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Paciente, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class