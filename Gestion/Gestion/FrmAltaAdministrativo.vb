Imports CapaLogica
Imports Clases
Public Class FrmAltaAdministrativo
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If MostrarMensaje(MsgBoxStyle.YesNo, "Advertencia: no se guardaron los cambios." & vbNewLine & "¿Confirma que desea cerrar la ventana?", "Cerrar", "Warning: no changes have been saved." & vbNewLine & "Are you sure you wish to close this window?", "Close") =
            MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmAltaAdministrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.Items.AddRange(CargarTodosLosDepartamentos.ToArray)

        Dim localidades As List(Of Localidad) = CargarTodasLasLocalidades()
        For i = 0 To localidades.Count - 1
            tblLocalidad.Rows.Add(localidades(i))
            tblLocalidad.Rows(i).Visible = False
        Next
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        For Each r As DataGridViewRow In tblLocalidad.Rows
            If CType(r.Cells(0).Value, Localidad).Departamento = cmbDepartamento.SelectedItem Then
                r.Visible = True
            Else
                r.Visible = False
            End If
        Next
        tblLocalidad.ClearSelection()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim ci As String = txtCI.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim correo As String = txtCorreo.Text
        Dim esEncargado As Boolean = checkEncargado.Checked

        Dim localidad As Localidad
        If tblLocalidad.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó ninguna localidad.", "Error", "No location was selected.", "Error")
            Exit Sub
        Else
            localidad = tblLocalidad.SelectedRows(0).Cells(0).Value
        End If

        Try
            CrearAdministrativo(ci, nombre, apellido, correo, localidad, esEncargado)
            MostrarMensaje(MsgBoxStyle.OkOnly, "Administrativo agregado con éxito.", "Éxito", "Administrative staff successfully added.", "Success")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmAltaAdministrativo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class