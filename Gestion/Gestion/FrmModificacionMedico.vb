Imports CapaLogica
Imports Clases
Public Class FrmModificacionMedico

    Dim medicoAModificar As Medico

    Sub New(medico As Medico)
        'Carga en los txt los datos del medico
        InitializeComponent()
        txtCI.Text = medico.CI
        txtNombre.Text = medico.Nombre
        txtApellido.Text = medico.Apellido
        txtCorreo.Text = medico.Correo

        ' Almacena el medico que se va a estar modificando
        medicoAModificar = medico

        'Añade todas las especialidades
        Dim especialidades As List(Of Especialidad)
        Try
            especialidades = CargarTodasLasEspecialidades()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try
        For Each especialidad As Especialidad In CargarTodasLasEspecialidades()
            tblEspecialidades.Rows.Add(especialidad)
        Next

        'Oculta las especialidades ya asignadas
        OcultarEspecialidadesSeleccionadasOFiltradas()

        'Precarga los datos de las especialidades del medico
        For i = 0 To medicoAModificar.Especialidades.Count - 1
            tblAsociados.Rows.Add(medicoAModificar.Especialidades(i))
        Next

        'Añade todas las localidades existentes al data grid
        Dim localidades As List(Of Localidad)
        Try
            localidades = CargarTodasLasLocalidades()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try
        For Each localidad As Localidad In localidades
            tblLocalidad.Rows.Add(localidad)
        Next
        tblLocalidad.ClearSelection()

        For Each r As DataGridViewRow In tblLocalidad.Rows
            If CType(r.Cells(0).Value, Localidad).ID = medicoAModificar.Localidad.ID Then
                r.Visible = True
                r.Selected = True
            Else
                r.Visible = False
            End If
        Next

        'Añade al combo box de departamento los departamentos existentes
        cmbDepartamento.Items.AddRange(CargarTodosLosDepartamentos.ToArray)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If MostrarMensaje(MsgBoxStyle.YesNo, "Advertencia: no se guardaron los cambios." & vbNewLine & "¿Confirma que desea cerrar la ventana?", "Salir", "Warning: no changes have been saved.", "Exit") =
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

        OcultarEspecialidadesSeleccionadasOFiltradas()
    End Sub


    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim listaEspecialidades As New List(Of Especialidad)
        If tblAsociados.Rows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Debe ingresar al menos una especialidad.", "Error", "You must select at least one medical specialty.", "Error")
            Return
        Else
            For Each r As DataGridViewRow In tblAsociados.Rows
                listaEspecialidades.Add(r.Cells(0).Value)
            Next
        End If

        Dim localidad As Localidad
        If tblLocalidad.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó ninguna localidad.", "Error", "No location was selected.", "Error")
            Return
        Else
            localidad = tblLocalidad.SelectedRows(0).Cells(0).Value
        End If

        Dim ci As String = txtCI.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim correo As String = txtCorreo.Text

        Try
            ActualizarMedico(medicoAModificar, ci, nombre, apellido, correo, localidad, listaEspecialidades)
            MostrarMensaje(MsgBoxStyle.OkOnly, "Médico modificado con éxito.", "Éxito", "Doctor successfully modified.", "Success")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnQuitarE_Click(sender As Object, e As EventArgs) Handles btnQuitarE.Click
        If tblAsociados.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Debe seleccionar al menos una de las especialidades asociadas.", "Error", "You must select at least one of the associated specialties.", "Error")
            Return
        End If

        For Each rAsociada As DataGridViewRow In tblAsociados.SelectedRows
            For Each rEspecialidad As DataGridViewRow In tblEspecialidades.Rows
                If rEspecialidad.Cells(0).Value = rAsociada.Cells(0).Value Then
                    rEspecialidad.Visible = True
                End If
            Next
            tblAsociados.Rows.Remove(rAsociada)
        Next
        OcultarEspecialidadesSeleccionadasOFiltradas()
    End Sub
    Private Sub btnAgregarE_Click(sender As Object, e As EventArgs) Handles btnAgregarE.Click
        If tblEspecialidades.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Debe seleccionar al menos uno de las especialidades disponibles.", "Error", "You must select at least one of the available specialties.", "Error")
            Return
        End If

        For Each r As DataGridViewRow In tblEspecialidades.SelectedRows
            tblAsociados.Rows.Add(r.Cells(0).Value)
        Next
        OcultarEspecialidadesSeleccionadasOFiltradas()
    End Sub

    Private Sub OcultarEspecialidadesSeleccionadasOFiltradas()
        ' Oculta por filtro de texto
        For Each r As DataGridViewRow In tblAsociados.Rows
            If r.Cells(0).Value.ToString.ToLower Like ("*" & txtBuscarEspecialidades.Text & "*").ToLower Then
                r.Visible = True
            Else
                r.Visible = False
            End If
        Next

        ' Oculta las especialidades ya seleccionadas
        For Each rAsociada As DataGridViewRow In tblAsociados.Rows
            For Each rEspecialidad As DataGridViewRow In tblEspecialidades.Rows
                If rAsociada.Cells(0).Value = rEspecialidad.Cells(0).Value Then
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

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmModificacionMedico_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class