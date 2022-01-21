Imports CapaLogica
Imports Clases

Public Class FrmInicio
    Dim appPacientes As FrmLogin
    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appPacientes = New FrmLogin
        InicializarConfig(TiposUsuario.Paciente)
    End Sub

    Private Sub tmrSplashWindow_Tick(sender As Object, e As EventArgs) Handles tmrSplashWindow.Tick
        tmrSplashWindow.Enabled = False
        appPacientes.Show()
        Me.Close()
    End Sub
End Class
