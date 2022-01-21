Imports CapaLogica
Imports Clases

Public Class FrmInicio
    Dim frmLogin As FrmLogin
    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin = New FrmLogin
        InicializarConfig(TiposUsuario.Medico)
    End Sub

    Private Sub tmrSplashWindow_Tick(sender As Object, e As EventArgs) Handles tmrSplashWindow.Tick
        tmrSplashWindow.Enabled = False
        frmLogin.Show()
        Me.Close()
    End Sub
End Class
