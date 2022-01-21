Imports CapaLogica
Imports Clases

Public Class FrmInicio
    Dim appGestion As FrmLogin
    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appGestion = New FrmLogin
        InicializarConfig(TiposUsuario.Administrativo)
    End Sub

    Private Sub tmrSplashWindow_Tick(sender As Object, e As EventArgs) Handles tmrSplashWindow.Tick
        tmrSplashWindow.Enabled = False
        appGestion.Show()
        Me.Close()
    End Sub
End Class
