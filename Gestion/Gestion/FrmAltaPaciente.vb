Imports Clases
Imports CapaLogica
Public Class FrmAltaPaciente
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If MostrarMensaje(MsgBoxStyle.YesNo, "Advertencia: no se guardaron los cambios." & vbNewLine & "¿Confirma que desea cerrar la ventana?", "Cerrar", "Warning: no changes have been saved." & vbNewLine & "Are you sure you wish to close this window?", "Close") =
            MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmAltaPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To tblLocalidad.Rows.Count - 1
            tblLocalidad.Rows(i).Visible = False
        Next
        cmbSexo.Items.AddRange([Enum].GetNames(GetType(TiposSexo)))

        cmbDepartamento.Items.AddRange(CargarTodosLosDepartamentos.ToArray)

        For Each localidad As Localidad In CargarTodasLasLocalidades()
            tblLocalidad.Rows.Add(localidad)
            tblLocalidad.Rows(tblLocalidad.Rows.Count - 1).Visible = False
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim localidad As Localidad
        If tblLocalidad.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó ninguna localidad.", "Error", "No location was selected.", "Error")
            Return
        Else
            localidad = tblLocalidad.SelectedRows(0).Cells(0).Value
        End If

        Dim sexo As TiposSexo
        If cmbSexo.SelectedIndex = -1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Debe seleccionar el sexo del paciente.", "Error", "You must indicate the patient's sex.", "Error")
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
        Dim fechaNecimiento As Date = dtpFecha.Value
        Dim calle As String = txtCalle.Text
        Dim numeroPuerta As String = txtNumeroPuerta.Text
        Dim apartamento As String = txtApartamento.Text

        Try
            CrearPaciente(ci, nombre, apellido, correo, localidad, movil, fijo, sexo, fechaNecimiento, Nothing, calle, numeroPuerta, apartamento)
            MostrarMensaje(MsgBoxStyle.OkOnly, "Paciente agregado con éxito.", "Éxito", "Patient successfully added.", "Success")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class