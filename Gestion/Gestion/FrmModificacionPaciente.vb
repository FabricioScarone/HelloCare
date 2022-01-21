Imports CapaLogica
Imports Clases
Public Class FrmModificacionPaciente

    Dim pacienteAModificar As Paciente

    Sub New(paciente As Paciente)
        InitializeComponent()

        ' Muestra los datos del paciente a modificar en los textos
        pacienteAModificar = paciente

        'carga los datos del paciente en los txt y en los calendarios
        txtCi.Text = pacienteAModificar.CI
        txtNombre.Text = pacienteAModificar.Nombre
        txtApellido.Text = pacienteAModificar.Apellido
        txtCorreo.Text = pacienteAModificar.Correo
        txtTelMovil.Text = pacienteAModificar.TelefonoMovil
        txtTelFijo.Text = pacienteAModificar.TelefonoFijo
        cmbSexo.SelectedItem = pacienteAModificar.Sexo.ToString
        dtpFechaNacimiento.Value = pacienteAModificar.FechaNacimiento.ToString("d-M-yyyy")
        txtCalle.Text = pacienteAModificar.Calle
        txtNumeroPuerta.Text = pacienteAModificar.NumeroPuerta
        txtApartamento.Text = pacienteAModificar.Apartamento
        cmbDepartamento.Text = pacienteAModificar.Localidad.Departamento.ToString

        If pacienteAModificar.FechaDefuncion <> Nothing Then
            cbHabilitarFD.Visible = False
            lblFechaDefuncion.Visible = True
            dtpFechaDefuncion.Visible = True
            dtpFechaDefuncion.Value = pacienteAModificar.FechaDefuncion
        End If

        'Añade los sexos disponibles al combo box
        cmbSexo.Items.AddRange([Enum].GetNames(GetType(TiposSexo)))
        cmbSexo.SelectedItem = pacienteAModificar.Sexo.ToString

        'Añade los departamentos disponibles al combo box
        cmbDepartamento.Items.AddRange(CargarTodosLosDepartamentos.ToArray)

        'Carga todas las localidades al datagrid
        For Each localidad As Localidad In CargarTodasLasLocalidades()
            tblLocalidad.Rows.Add(localidad)
        Next

        'Muestra la localidad actual del pacient en el datagrid
        For Each r As DataGridViewRow In tblLocalidad.Rows
            If CType(r.Cells(0).Value, Localidad).ID = pacienteAModificar.Localidad.ID Then
                r.Visible = True
            Else
                r.Visible = False
            End If
        Next


        'cbHabilitarFD.Visible = False

        'If pacienteAModificar.FechaDefuncion = Nothing Then
        '    dtpFechaDefuncion.Visible = False
        '    cbHabilitarFD.Visible = True
        'Else
        '    dtpFechaDefuncion.Text = pacienteAModificar.FechaDefuncion.ToString("d-M-yyyy")

        'End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If MostrarMensaje(MsgBoxStyle.YesNo, "Advertencia: no se guardaron los cambios." & vbNewLine & "¿Confirma que desea cerrar la ventana?", "Salir", "Warning: no changes have been saved." & vbNewLine & "Are you sure you wish to close this window?", "Exit") =
            MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        For Each r As DataGridViewRow In tblLocalidad.Rows
            If CType(r.Cells(0).Value, Localidad).Departamento = cmbDepartamento.SelectedItem Then
                r.Visible = True
            Else
                r.Visible = False
            End If
        Next
        'Deja sin seleccionar una localidad
        tblLocalidad.ClearSelection()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim localidad As Localidad
        If tblLocalidad.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó ninguna localidad.", "Error", "No location was selected.", "Error")
            Return
        Else
            localidad = tblLocalidad.SelectedRows(0).Cells(0).Value
        End If

        Dim sexo As TiposSexo
        If cmbSexo.SelectedIndex = -1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó el sexo del paciente.", "Error", "You haven't selected the patient's sex.", "Error")
            Return
        Else
            sexo = [Enum].Parse(GetType(TiposSexo), cmbSexo.SelectedItem)
        End If

        Dim ci As String = txtCi.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim correo As String = txtCorreo.Text
        Dim movil As String = txtTelMovil.Text
        Dim fijo As String = txtTelFijo.Text
        Dim fechaNacimiento As Date = dtpFechaNacimiento.Value
        Dim fechaDefuncion As Date = If(dtpFechaDefuncion.Visible, dtpFechaDefuncion.Value, Nothing)
        Dim calle As String = txtCalle.Text
        Dim numeroPuerta As String = txtNumeroPuerta.Text
        Dim apartamento As String = txtApartamento.text

        Try
            ActualizarPaciente(pacienteAModificar, ci, nombre, apellido, correo, localidad, movil, fijo, sexo, fechaNacimiento, fechaDefuncion, calle, numeroPuerta, apartamento)
            MostrarMensaje(MsgBoxStyle.OkOnly, "Paciente modificado con éxito.", "Éxito", "Patient successfully modified.", "Success")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cbHabilitarFD_CheckedChanged(sender As Object, e As EventArgs) Handles cbHabilitarFD.CheckedChanged
        If cbHabilitarFD.Checked Then
            lblFechaDefuncion.Visible = True
            dtpFechaDefuncion.Visible = True
        Else
            lblFechaDefuncion.Visible = False
            dtpFechaDefuncion.Visible = False
        End If
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmModificacionPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class