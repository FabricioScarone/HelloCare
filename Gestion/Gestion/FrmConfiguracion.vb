Imports Clases
Imports CapaLogica
Imports System.ComponentModel
Imports System.Globalization

Public Class FrmConfiguracion
    Private departamentos As List(Of Departamento)
    Private localidades As List(Of Localidad)
    Private especialidades As List(Of Especialidad)
    Private Sub FrmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDatosSistema()
    End Sub

    Private Sub ActualizarDatosSistema()
        grdDepartamentos.Rows.Clear()
        grdLocalidades.Rows.Clear()
        grdEspecialidades.Rows.Clear()
        cbxNuevoDepartamentoDeLocalidad.Items.Clear()

        Try
            departamentos = CargarTodosLosDepartamentos()
            localidades = CargarTodasLasLocalidades()
            especialidades = CargarTodasLasEspecialidades()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try


        cbxDepartamentos.Items.AddRange(departamentos.ToArray)
        cbxNuevoDepartamentoDeLocalidad.Items.AddRange(departamentos.ToArray)

        For i = 0 To localidades.Count - 1
            grdLocalidades.Rows.Add(localidades(i))
        Next
        For i = 0 To especialidades.Count - 1
            grdEspecialidades.Rows.Add(especialidades(i))
        Next
    End Sub

    Private Sub txtBuscarDepartamento_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarDepartamento.TextChanged
        For Each fila As DataGridViewRow In grdDepartamentos.Rows
            If fila.Cells(0).Value.ToString.ToLower Like "*" & txtBuscarDepartamento.Text.ToLower & "*" Then
                fila.Visible = True
            Else
                fila.Visible = False
            End If
        Next
    End Sub

    Private Sub cbxDepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDepartamentos.SelectedIndexChanged
        For Each fila As DataGridViewRow In grdLocalidades.Rows
            If fila.Cells(0).Value.ToString.ToLower Like "*" & txtBuscarLocalidades.Text.ToLower & "*" And
                CType(fila.Cells(0).Value, Localidad).Departamento = cbxDepartamentos.SelectedItem Then

                fila.Visible = True
            Else
                fila.Visible = False
            End If
        Next
    End Sub

    Private Sub txtBuscarEspecialidad_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEspecialidad.TextChanged
        For Each fila As DataGridViewRow In grdEspecialidades.Rows
            If fila.Cells(0).Value.ToString.ToLower Like "*" & txtBuscarEspecialidad.Text.ToLower & "*" Then
                fila.Visible = True
            Else
                fila.Visible = False
            End If
        Next
    End Sub

    Private Sub btnAgregarDepartamento_Click(sender As Object, e As EventArgs) Handles btnAgregarDepartamento.Click

        Dim nombre As String = txtAgregarDepartamento.Text.Trim
        For Each d As Departamento In departamentos
            If nombre.ToLower = d.Nombre.ToLower Then
                MostrarMensaje(MsgBoxStyle.Critical, "Ya existe un departamento con este nombre.", "Error", "A department with this name already exists.", "Error")
                Return
            End If
        Next

        Try
            CrearDepartamento(nombre)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ActualizarDatosSistema()
    End Sub

    Private Sub btnAgregarLocalidad_Click(sender As Object, e As EventArgs) Handles btnAgregarLocalidad.Click

        Dim nombreIngresado As String = txtAgregarLocalidad.Text.Trim

        Dim departamentoSeleccionado As Departamento
        If cbxDepartamentoDeNuevaLocalidad.SelectedIndex = -1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó ningún departamento.", "Error", "No department was selected.", "Error")
            Return
        Else
            departamentoSeleccionado = cbxDepartamentoDeNuevaLocalidad.SelectedItem
        End If

        Dim localidadesDelDepartamentoSeleccionado As New List(Of Localidad)
        For Each l As Localidad In localidades
            If l.Departamento = departamentoSeleccionado Then
                localidadesDelDepartamentoSeleccionado.Add(l)
            End If
        Next
        For Each l As Localidad In localidadesDelDepartamentoSeleccionado
            If nombreIngresado.ToLower = l.Nombre.ToLower Then
                MostrarMensaje(MsgBoxStyle.Critical, "Ya existe una localidad en este departamento con este nombre.", "Error", "A location with this name already exists in this department.", "Error")
                Return
            End If
        Next

        Try
            CrearLocalidad(nombreIngresado, departamentoSeleccionado)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ActualizarDatosSistema()
    End Sub

    Private Sub btnAgregarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnAgregarEspecialidad.Click

        Dim nombreIngresado As String = txtAgregarEspecialidad.Text.Trim
        For Each especialidad As Especialidad In especialidades
            If nombreIngresado.ToLower = especialidad.Nombre.ToLower Then
                MostrarMensaje(MsgBoxStyle.Critical, "Ya existe una especialidad con este nombre.", "Error", "A specialty with this name already exists.", "Error")
                Return
            End If
        Next

        Try
            CrearEspecialidad(nombreIngresado)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ActualizarDatosSistema()
    End Sub

    Private Sub grdDepartamentos_SelectionChanged(sender As Object, e As EventArgs) Handles grdDepartamentos.SelectionChanged
        If grdDepartamentos.SelectedRows.Count > 0 Then
            Dim departamentoSeleccionado As String = grdDepartamentos.SelectedRows(0).Cells(0).Value.ToString
            txtNombreDepartamentoAModificar.Text = departamentoSeleccionado
            txtEliminarDepartamento.Text = departamentoSeleccionado
        End If
    End Sub

    Private Sub grdLocalidades_SelectionChanged(sender As Object, e As EventArgs) Handles grdLocalidades.SelectionChanged

        If grdLocalidades.SelectedRows.Count > 0 Then
            Dim localidadSeleccionada As String = grdLocalidades.SelectedRows(0).Cells(0).Value.ToString
            txtNombreLocalidadAModificar.Text = localidadSeleccionada
            txtEliminarLocalidad.Text = localidadSeleccionada
            txtLocalidadParaCambiarDepartamento.Text = localidadSeleccionada
            If cbxDepartamentos.SelectedIndex <> -1 Then
                txtDepartamentoActual.Text = cbxDepartamentos.SelectedItem.ToString
            End If
        End If
    End Sub

    Private Sub grdEspecialidades_SelectionChanged(sender As Object, e As EventArgs) Handles grdEspecialidades.SelectionChanged

        If grdEspecialidades.SelectedRows.Count > 0 Then
            Dim especialidadSeleccionada As String = grdEspecialidades.SelectedRows(0).Cells(0).Value.ToString
            txtNombreEspecialidadAModificar.Text = especialidadSeleccionada
            txtEliminarEspecialidad.Text = especialidadSeleccionada
        End If
    End Sub

    Private Sub btnModificarDepartamento_Click(sender As Object, e As EventArgs) Handles btnModificarDepartamento.Click
        Dim nombreActual As String = txtNombreDepartamentoAModificar.Text
        Dim nombreNuevo As String = txtNuevoNombreDepartamento.Text.Trim

        If nombreActual = nombreNuevo Then
            MostrarMensaje(MsgBoxStyle.Information, "Se ha ingresado el mismo nombre de departamento. No se realizó ningún cambio.", "Aviso", "The same department name has been entered. No changes have been done.", "Warning")
            Return
        End If

        For Each d As Departamento In departamentos
            If nombreNuevo.ToLower = d.Nombre.ToLower Then
                MostrarMensaje(MsgBoxStyle.Critical, "Ya existe un departamento con este nombre.", "Error", "A department with this name already exists.", "Error")
                Return
            End If
        Next

        Dim departamento As Departamento = Nothing
        For Each d As Departamento In departamentos
            If d.Nombre = nombreActual Then
                departamento = d
            End If
        Next

        Try
            ActualizarDepartamento(departamento, nombreNuevo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ActualizarDatosSistema()
    End Sub

    Private Sub btnModificarLocalidad_Click(sender As Object, e As EventArgs) Handles btnModificarLocalidad.Click

        Dim nombreActual As String = txtNombreLocalidadAModificar.Text
        Dim nombreNuevo As String = txtNuevoNombreLocalidad.Text.Trim

        If nombreActual = nombreNuevo Then
            MostrarMensaje(MsgBoxStyle.Information, "Se ha ingresado el mismo nombre de localidad. No se realizó ningún cambio.", "Aviso", "The same location name has been entered. No changes have been done.", "Warning")
            Return
        End If

        Dim departamentoSeleccionado As Departamento
        If cbxDepartamentoDeNuevaLocalidad.SelectedIndex = -1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se ha seleccionado ningún departamento para la localidad.", "Error", "No department has been selected for the location.", "Error")
            Return
        Else
            departamentoSeleccionado = cbxDepartamentoDeNuevaLocalidad.SelectedItem
        End If

        Dim localidadesDelDepartamento As New List(Of Localidad)
        For Each l As Localidad In localidades
            If l.Departamento = departamentoSeleccionado Then
                localidadesDelDepartamento.Add(l)
            End If
        Next
        For Each l As Localidad In localidadesDelDepartamento
            If nombreNuevo.ToLower = l.Nombre.ToLower Then
                MostrarMensaje(MsgBoxStyle.Critical, "Ya existe una localidad en este departamento con este nombre.", "Error", "A location with this name already exists.", "Error")
                Return
            End If
        Next

        Dim localidad As Localidad = Nothing
        For Each l As Localidad In localidades
            If l.Nombre = nombreActual And l.Departamento = departamentoSeleccionado Then
                localidad = l
            End If
        Next

        Try
            ActualizarLocalidad(localidad, nombreNuevo, localidad.Departamento)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ActualizarDatosSistema()
    End Sub

    Private Sub btnModificarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnModificarEspecialidad.Click

        Dim nombreActual As String = txtNombreEspecialidadAModificar.Text
        Dim nombreNuevo As String = txtNuevoNombreEspecialidad.Text.Trim

        If nombreActual = nombreNuevo Then
            MostrarMensaje(MsgBoxStyle.Information, "Se ha ingresado el mismo nombre de especialidad. No se realizó ningún cambio.", "Aviso", "The same specialty name has been entered. No changes have been done.", "Warning")
            Return
        End If

        For Each esp As Especialidad In especialidades
            If nombreNuevo.ToLower = esp.Nombre.ToLower Then
                MostrarMensaje(MsgBoxStyle.Information, "Se ha ingresado el mismo nombre de especialidad. No se realizó ningún cambio.", "Aviso", "The same specialty name has been entered. No changes have been done.", "Warning")
            End If
        Next

        Dim especialidad As Especialidad = Nothing
        For Each esp As Especialidad In especialidades
            If esp.Nombre = nombreActual Then
                especialidad = esp
            End If
        Next

        Try
            ActualizarEspecialidad(especialidad, nombreNuevo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ActualizarDatosSistema()
    End Sub

    Private Sub btnCambiarDepartamentoDeLocalidad_Click(sender As Object, e As EventArgs) Handles btnCambiarDepartamentoDeLocalidad.Click

        Dim departamentoActual As String = txtDepartamentoActual.Text
        Dim nombreLocalidad As String = txtLocalidadParaCambiarDepartamento.Text

        Dim nuevoDepartamento As Departamento
        If cbxNuevoDepartamentoDeLocalidad.SelectedIndex = -1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó un nuevo departamento.", "Error", "No new department was selected.", "Error")
            Return
        Else
            nuevoDepartamento = cbxNuevoDepartamentoDeLocalidad.SelectedItem
        End If

        If departamentoActual = nuevoDepartamento.ToString Then
            MostrarMensaje(MsgBoxStyle.Information, "Se seleccionó el mismo departamento. No se realizó ningún cambio.", "Aviso", "The same department has been selected. No changes have been done.", "Warning")
            Return
        End If

        Dim localidadesDelNuevoDepartamento As New List(Of Localidad)
        For Each l As Localidad In localidades
            If l.Departamento = nuevoDepartamento Then
                localidadesDelNuevoDepartamento.Add(l)
            End If
        Next
        For Each l As Localidad In localidadesDelNuevoDepartamento
            If nombreLocalidad.ToLower = l.Nombre.ToLower Then
                MostrarMensaje(MsgBoxStyle.Critical, "Ya existe una localidad en este departamento con este nombre.", "Error", "A location with this name already exists in this department.", "Error")
                Return
            End If
        Next

        Dim localidad As Localidad = Nothing
        For Each l As Localidad In localidades
            If l.Nombre = nombreLocalidad And l.Departamento.ToString = departamentoActual Then
                localidad = l
            End If
        Next

        Try
            ActualizarLocalidad(localidad, localidad.Nombre, nuevoDepartamento)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ActualizarDatosSistema()
    End Sub

    Private Sub btnEliminarDepartamento_Click(sender As Object, e As EventArgs) Handles btnEliminarDepartamento.Click

        Dim nombreDepartamento As String = txtEliminarDepartamento.Text

        Dim departamento As Departamento = Nothing
        For Each d As Departamento In departamentos
            If d.Nombre = nombreDepartamento Then
                departamento = d
            End If
        Next

        For Each l As Localidad In localidades
            If l.Departamento = departamento Then
                MostrarMensaje(MsgBoxStyle.Critical, "No se puede eliminar un departamento que tenga localidades registradas. Elimine las localidades asociadas y reintente.", "Error", "A department with registered locations cannot be deleted. Delete the associated locations and retry.", "Error")
                Return
            End If
        Next

        Try
            EliminarDepartamento(departamento)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ActualizarDatosSistema()
    End Sub

    Private Sub btnEliminarLocalidad_Click(sender As Object, e As EventArgs) Handles btnEliminarLocalidad.Click

        Dim nombreLocalidad As String = txtEliminarLocalidad.Text

        Dim departamento As Departamento
        If cbxDepartamentos.SelectedIndex = -1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó el departamento de la localidad.", "Error", "The department of the location was not selected.", "Error")
            Return
        Else
            departamento = cbxDepartamentos.SelectedItem
        End If

        Dim localidad As Localidad = Nothing
        For Each l As Localidad In localidades
            If l.Nombre = nombreLocalidad And l.Departamento = departamento Then
                localidad = l
            End If
        Next

        Dim tienePersonas As Boolean
        Try
            tienePersonas = ExistenPersonasEnLocalidad(localidad)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        If tienePersonas Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se puede eliminar una localidad que tenga personas registradas. Elimine las personas registradas y reintente.", "Error", "A location with registered people cannot be deleted. Delete all people registered in the location and retry.", "Error")
            Return
        End If

        Try
            EliminarLocalidad(localidad)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ActualizarDatosSistema()
    End Sub

    Private Sub btnEliminarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnEliminarEspecialidad.Click

        Dim nombreEspecialidad As String = txtEliminarEspecialidad.Text

        Dim especialidad As Especialidad = Nothing
        For Each esp As Especialidad In especialidades
            If esp.Nombre = nombreEspecialidad Then
                especialidad = esp
            End If
        Next

        If especialidad.Medicos.Count > 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se puede eliminar una especialidad que tenga médicos practicantes. Elimine la asociación y reintente.", "Error", "A specialty with associated doctors cannot be deleted. Modify the doctors' specialties and retry.", "Error")
            Return
        End If

        For Each enfermedad As Enfermedad In CargarTodasLasEnfermedades()
            If enfermedad.Especialidad = especialidad Then
                MostrarMensaje(MsgBoxStyle.Critical, "No se puede eliminar una especialidad que tenga enfermedades asociadas. Elimine o modifique las enfermedades y reintente.", "Error", "A specialty with associated illnesses cannot be deleted. Delete or modify these illnesses and retry.", "Error")
                Return
            End If
        Next

        Try
            EliminarEspecialidad(especialidad)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ActualizarDatosSistema()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmConfiguracion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class