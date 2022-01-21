Imports CapaLogica
Imports Clases

Public Class FrmTipoUsuario
    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        Dim frm As New FrmListadoPacientes
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnMedico_Click(sender As Object, e As EventArgs) Handles btnMedico.Click
        Dim frm As New FrmListadoMedicos
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnAdministrativo_Click(sender As Object, e As EventArgs) Handles btnAdministrativo.Click
        Dim frm As New FrmListadoAdministrativos
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmTipoUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class