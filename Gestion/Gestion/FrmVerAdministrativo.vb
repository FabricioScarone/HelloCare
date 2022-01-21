Imports CapaLogica
Imports Clases
Public Class FrmVerAdministrativo

    Sub New(administrativo As Administrativo)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        txtCI.Text = administrativo.CI
        txtNombre.Text = administrativo.Nombre
        txtApellido.Text = administrativo.Apellido
        txtCorreo.Text = administrativo.Correo
        txtLocalidad.Text = administrativo.Localidad.ToString
        checkEncargado.Checked = administrativo.EsEncargado
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmVerAdministrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Nothing
    End Sub

    Private Sub FrmVerAdministrativo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class