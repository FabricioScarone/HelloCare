Imports Clases
Imports CapaLogica
Public Class FrmAltaMedico
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If MostrarMensaje(MsgBoxStyle.YesNo, "Advertencia: no se guardaron los cambios." & vbNewLine & "¿Confirma que desea cerrar la ventana?", "Cerrar", "Warning: no changes have been saved." & vbNewLine & "Are you sure you wish to close this window?", "Close") =
            MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmAltaMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Añade todas las especialidades 
        For Each especialidad As Especialidad In CargarTodasLasEspecialidades()
            tblEspecialidades.Rows.Add(especialidad)
        Next
        tblEspecialidades.ClearSelection()

        'Añade todas las localidades existentes al data grid y las oculta
        For Each localidad As Localidad In CargarTodasLasLocalidades()
            tblLocalidad.Rows.Add(localidad)
            tblLocalidad.Rows(tblLocalidad.Rows.Count - 1).Visible = False
        Next

        'Añade al combo box de departamento los departamentos existentes
        cmbDepartamento.Items.AddRange(CargarTodosLosDepartamentos.ToArray)
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        'Dependiendo del departamento seleccionado, se muetras las respectivas localidades a seleccionar
        For Each r As DataGridViewRow In tblLocalidad.Rows
            If CType(r.Cells(0).Value, Localidad).Departamento = cmbDepartamento.SelectedItem Then
                r.Visible = True
            Else
                r.Visible = False
            End If
        Next
        tblLocalidad.ClearSelection()
    End Sub

    Private Sub txtBuscarEspecialidades_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEspecialidades.TextChanged
        For Each r As DataGridViewRow In tblEspecialidades.Rows
            If r.Cells(0).Value.ToString.ToLower Like ("*" & txtBuscarEspecialidades.Text & "*").ToLower Then
                r.Visible = True
            Else
                r.Visible = False
                If r.Selected Then
                    r.Selected = False
                End If
            End If
        Next
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim localidad As Localidad
        If tblLocalidad.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó ninguna localidad.", "Error", "No location was selected.", "Error")
            Return
        Else
            localidad = tblLocalidad.SelectedRows(0).Cells(0).Value
        End If

        Dim listaEspecialidades As New List(Of Especialidad)
        If tblAsociados.Rows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó ninguna especialidad.", "Error", "No specialties were selected.", "Error")
            Return
        Else
            For Each r As DataGridViewRow In tblAsociados.Rows
                listaEspecialidades.Add(r.Cells(0).Value)
            Next
        End If

        Dim ci As String = txtCI.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim correo As String = txtCorreo.Text

        Try
            CrearMedico(ci, nombre, apellido, correo, localidad, listaEspecialidades)
            MostrarMensaje(MsgBoxStyle.OkOnly, "Médico agregado con éxito.", "Éxito", "Doctor successfully added.", "Success")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnQuitarE_Click(sender As Object, e As EventArgs) Handles btnQuitarE.Click
        If tblAsociados.SelectedRows.Count > 0 Then
            For Each rAsociada As DataGridViewRow In tblAsociados.SelectedRows
                For Each rEspecialidad As DataGridViewRow In tblEspecialidades.Rows
                    If rEspecialidad.Cells(0).Value = rAsociada.Cells(0).Value Then
                        rEspecialidad.Visible = True
                    End If
                Next
                tblAsociados.Rows.Remove(rAsociada)
            Next
            OcultarEspecialidadesSeleccionadasOFiltradas()
        Else
            MsgBox("Debe seleccionar al menos uno de las especialidades asociadas.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub OcultarEspecialidadesSeleccionadasOFiltradas()
        ' Oculta por filtro de texto
        For Each r As DataGridViewRow In tblEspecialidades.Rows
            If r.Cells(0).Value.ToString.ToLower Like ("*" & txtBuscarEspecialidades.Text & "*").ToLower Then
                r.Visible = True
            Else
                r.Visible = False
            End If
        Next

        ' Oculta las especialidades ya seleccionadas
        For Each rAsociado As DataGridViewRow In tblAsociados.Rows
            For Each rEspecialidad As DataGridViewRow In tblEspecialidades.Rows
                If rAsociado.Cells(0).Value = rEspecialidad.Cells(0).Value Then
                    rEspecialidad.Visible = False
                End If
            Next
        Next
        DeseleccionarTablas()
    End Sub

    Private Sub DeseleccionarTablas()
        tblAsociados.ClearSelection()
        tblEspecialidades.ClearSelection()
    End Sub

    Private Sub btnAgregarE_Click(sender As Object, e As EventArgs) Handles btnAgregarE.Click
        If tblEspecialidades.SelectedRows.Count > 0 Then
            For Each r As DataGridViewRow In tblEspecialidades.SelectedRows
                tblAsociados.Rows.Add(r.Cells(0).Value)

            Next
            OcultarEspecialidadesSeleccionadasOFiltradas()
        Else
            MsgBox("Debe seleccionar al menos uno de las especialidades disponibles.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmAltaMedico_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class