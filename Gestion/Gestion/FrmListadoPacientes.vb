Imports CapaLogica
Imports Clases
Public Class FrmListadoPacientes
    Private Sub FrmListadoPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarPacientes()
    End Sub

    Private Sub ActualizarPacientes()
        tblPacientes.Rows.Clear()
        Try
            For Each paciente As Paciente In CargarTodosLosPacientes()
                tblPacientes.Rows.Add(paciente, paciente.CI, paciente.Nombre, paciente.Apellido, paciente.Correo, paciente.Localidad, paciente.TelefonoMovil, paciente.TelefonoFijo, paciente.Sexo, paciente.FechaNacimiento.ToString("d/M/yyyy"), If(paciente.FechaDefuncion <> Date.MinValue, paciente.FechaDefuncion.ToString("d/M/yyyy"), ""), paciente.Calle, paciente.NumeroPuerta, paciente.Apartamento)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        tblPacientes.ClearSelection()
    End Sub

    'Abre un formulario con los detalles de un paciente
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        If tblPacientes.SelectedRows.Count <> 1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Seleccione una sola fila para ver los detalles del paciente.", "Error", "Select a single row to view details about a patient.", "Error")
            Return
        End If

        Dim Paciente As Paciente = tblPacientes.SelectedRows(0).Cells(0).Value
        Dim frm As New FrmVerPaciente(Paciente)
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    'Vuelve a la ventana anterior
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If tblPacientes.SelectedRows.Count <> 1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Seleccione una sola fila para modificar el paciente correspondiente.", "Error", "Select a single row to modify the data of a patient.", "Error")
            Return
        End If

        Dim paciente As Paciente = tblPacientes.SelectedRows(0).Cells(0).Value
        Dim frm As New FrmModificacionPaciente(paciente)
        Me.Hide()
        frm.ShowDialog()
        ActualizarPacientes()
        Me.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If tblPacientes.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Seleccione al menos una fila para eliminar el o los pacientes.", "", "Select at least one row to delete patients.", "")
            Return
        End If

        If MostrarMensaje(MsgBoxStyle.YesNo, "¿Confirma que desea eliminar este/os paciente(s)?" & vbNewLine & "Estos cambios no podrán deshacerse.", "Advertencia", "Are you sure you wish to delete this/these patient(s)?" & vbNewLine & "These changes cannot be undone.", "Warning") = MsgBoxResult.Yes Then
            Try
                For Each r As DataGridViewRow In tblPacientes.SelectedRows
                    EliminarPaciente(r.Cells(0).Value)
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
            ActualizarPacientes()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New FrmAltaPaciente
        Me.Hide()
        frm.ShowDialog()
        ActualizarPacientes()
        Me.Show()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub OcultarPacientes()
        tblPacientes.ClearSelection()

        Dim filtroCI As String = txtBP_CI.Text
        Dim filtroLocalidad As String = txtBP_Localidad.Text
        For Each r As DataGridViewRow In tblPacientes.Rows
            If r.Cells(1).Value.ToString.ToLower Like ("*" & filtroCI & "*").ToLower And r.Cells(5).Value.ToString.ToLower Like ("*" & filtroLocalidad & "*").ToLower Then
                r.Visible = True
            Else
                r.Visible = False
                If r.Selected Then
                    r.Selected = False
                End If
            End If
        Next
    End Sub

    Private Sub txtBP_CI_TextChanged(sender As Object, e As EventArgs) Handles txtBP_CI.TextChanged
        OcultarPacientes()
    End Sub

    Private Sub txtBP_Localidad_TextChanged(sender As Object, e As EventArgs) Handles txtBP_Localidad.TextChanged

        OcultarPacientes()
    End Sub

    Private Sub FrmListadoPacientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class