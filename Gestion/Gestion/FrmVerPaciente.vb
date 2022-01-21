Imports CapaLogica
Imports Clases
Public Class FrmVerPaciente
    Sub New(paciente As Paciente)
        InitializeComponent()

        ' Muestra los datos del paciente seleccionado en la ventana anterior
        txtCi.Text = paciente.CI
        txtNombre.Text = paciente.Nombre
        txtApellido.Text = paciente.Apellido
        txtCorreo.Text = paciente.Correo
        txtTelMovil.Text = paciente.TelefonoMovil
        txtTelFijo.Text = paciente.TelefonoFijo
        txtSexo.Text = paciente.Sexo.ToString
        txtFechaNacimiento.Text = paciente.FechaNacimiento.ToString("dd-MM-yyyy")

        If paciente.FechaDefuncion <> Nothing Then
            txtFechaDefuncion.Text = paciente.FechaDefuncion.ToString("dd-MM-yyyy")
        Else
            txtFechaDefuncion.Visible = False
        End If

        txtCalle.Text = paciente.Calle
        txtNumeroPuerta.Text = paciente.NumeroPuerta
        txtApartamento.Text = paciente.Apartamento
        txtLocalidad.Text = paciente.Localidad.ToString
        txtDepartamento.Text = paciente.Localidad.Departamento.ToString
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    ' Evita que algún control quede seleccionado 
    Private Sub FrmVerPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Nothing
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmVerPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class