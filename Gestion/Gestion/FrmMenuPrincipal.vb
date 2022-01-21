Imports System.ComponentModel
Imports System.Globalization
Imports CapaLogica
Imports Clases

Public Class FrmMenuPrincipal
    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not administrativoLogeado.EsEncargado Then
            btnConfiguracion.Visible = False
        End If
    End Sub

    Private Sub btnABMSintomas_Click(sender As Object, e As EventArgs) Handles btnABMSintomas.Click
        Dim frm As New FrmListadoSintomas
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnABMEnfermedades_Click(sender As Object, e As EventArgs) Handles btnABMEnfermedades.Click
        Dim frm As New FrmListadoEnfermedades
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnABMUsuarios_Click(sender As Object, e As EventArgs) Handles btnABMUsuarios.Click
        Dim frm As New FrmTipoUsuario
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    ' Pide confirmación al usuario antes de cerrar sesión
    Private Sub FrmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MostrarMensaje(MsgBoxStyle.YesNo, "¿Confirma que desea cerrar su sesión?", "Cerrar sesión", "Are you sure you wish to sign out?", "Sign out") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        Dim frm As New FrmConfiguracion
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub lblLogeado_TextChanged(sender As Object, e As EventArgs) Handles lblLogeado.TextChanged
        If lblLogeado.Text.Contains("#") Then
            lblLogeado.Text = lblLogeado.Text.Replace("#", administrativoLogeado.ToString)
        End If
    End Sub

    Private Sub FrmMenuPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class
