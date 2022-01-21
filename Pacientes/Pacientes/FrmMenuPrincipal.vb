Imports System.ComponentModel
Imports System.Globalization
Imports System.Windows.Forms
Imports CapaLogica
Imports Clases

Public Class FrmMenuPrincipal

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLogeado.Text = lblLogeado.Text.Replace("#", pacienteLogeado.ToString)
    End Sub

    Private Sub btnIngresoSintoma_Click(sender As Object, e As EventArgs) Handles btnIngresoSintoma.Click
        Dim frm As New FrmIngresoSintoma
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MostrarMensaje(MsgBoxStyle.YesNo, "¿Confirma que desea cerrar su sesión?", "Cerrar sesión", "Are you sure you wish to sign out?", "Sign out") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnHistorialDiagnosticos_Click(sender As Object, e As EventArgs) Handles btnHistorialDiagnosticos.Click
        Dim frm As New FrmHistorialDiagnosticos
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub lblLogeado_TextChanged(sender As Object, e As EventArgs) Handles lblLogeado.TextChanged
        If lblLogeado.Text.Contains("#") Then
            lblLogeado.Text = lblLogeado.Text.Replace("#", pacienteLogeado.ToString)
        End If
    End Sub

    Private Sub FrmMenuPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Paciente, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class