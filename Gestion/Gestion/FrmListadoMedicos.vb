Imports CapaLogica
Imports Clases
Public Class FrmListadoMedicos
    Private Sub FrmListadoMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarMedicos()
    End Sub

    'Metodo para actualizar el datagrid con los medicos
    Private Sub ActualizarMedicos()
        tblMedicos.Rows.Clear()

        Try
            For Each Medico As Medico In CargarTodosLosMedicos()
                tblMedicos.Rows.Add(Medico, Medico.CI, Medico.Nombre, Medico.Apellido, Medico.Correo, Medico.Localidad)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        tblMedicos.ClearSelection()

        ' ???
        'For intI = tblMedicos.Rows.Count - 1 To 0 Step -1
        '    For intJ = intI - 1 To 0 Step -1
        '        If tblMedicos.Rows(intI).Cells(1).Value = tblMedicos.Rows(intJ).Cells(1).Value Then
        '            tblMedicos.Rows.RemoveAt(intI)
        '            Exit For
        '        End If
        '    Next
        'Next
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        If tblMedicos.SelectedRows.Count <> 1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Seleccione una sola fila para ver los detalles del médico.", "Error", "Select a single row to view details of the doctor.", "Error")
            Return
        End If

        Dim Medico As Medico = tblMedicos.SelectedRows(0).Cells(0).Value
        Dim frm As New FrmVerMedicos(Medico)
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If tblMedicos.SelectedRows.Count <> 1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Seleccione una sola fila para modificar datos de un médico.", "Error", "Select a single row to modify the data of a doctor.", "Error")
            Return
        End If

        Dim Medico As Medico = tblMedicos.SelectedRows(0).Cells(0).Value
        Dim frm As New FrmModificacionMedico(Medico)
        Me.Hide()
        frm.ShowDialog()
        ActualizarMedicos()
        Me.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New FrmAltaMedico
        Me.Hide()
        frm.ShowDialog()
        ActualizarMedicos()
        Me.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If tblMedicos.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Seleccione al menos una fila para eliminar el o los medicos.", "", "Select at least one row to delete doctors.", "")
            Return
        End If

        If MostrarMensaje(MsgBoxStyle.YesNo, "¿Confirma que desea eliminar este/os Medico/s?" & vbNewLine & "Estos cambios no podrán deshacerse.", "Advertencia", "Are you sure to delete this/these doctor(s)?" & vbNewLine & "These changes cannot be undone.", "Warning") = MsgBoxResult.Yes Then

            Try
                For Each r As DataGridViewRow In tblMedicos.SelectedRows
                    EliminarMedico(r.Cells(0).Value)
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
            ActualizarMedicos()
        End If
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub OcultarMedicos()
        tblMedicos.ClearSelection()

        Dim filtroCI As String = txtBM_CI.Text
        Dim filtroLocalidad As String = txtBM_Localidad.Text
        For Each r As DataGridViewRow In tblMedicos.Rows
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

    Private Sub txtBM_CI_TextChanged(sender As Object, e As EventArgs) Handles txtBM_CI.TextChanged
        OcultarMedicos()
    End Sub

    Private Sub txtBM_Localidad_TextChanged(sender As Object, e As EventArgs) Handles txtBM_Localidad.TextChanged
        OcultarMedicos()
    End Sub

    Private Sub FrmListadoMedicos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class