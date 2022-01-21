Imports System.ComponentModel
Imports System.Globalization
Imports CapaLogica
Imports Clases

Public Class FrmListadoSintomas
    Private Sub FrmListadoSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarSintomas()
    End Sub

    Private Sub ActualizarSintomas()
        tblSintomas.Rows.Clear()
        Try
            For Each sintoma As Sintoma In CargarTodosLosSintomas()
                tblSintomas.Rows.Add(sintoma, sintoma.Nombre, sintoma.Descripcion, sintoma.Urgencia, sintoma.Recomendaciones)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        tblSintomas.ClearSelection()
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        exploradorArchivos.FileName = ""
        exploradorArchivos.ShowDialog()
        Dim nombreArchivo As String = exploradorArchivos.FileName

        If nombreArchivo = "" Then
            MostrarMensaje(MsgBoxStyle.Exclamation, "No se seleccionó ningún archivo CSV para importar.", "", "No CSV file was selected.", "")
            Exit Sub
        End If

        If Not nombreArchivo.EndsWith(".csv") Then
            MostrarMensaje(MsgBoxStyle.Critical, "El archivo seleccionado no es de formato CSV.", "", "The selected file does not have the required CSV format.", "")
            Exit Sub
        End If

        Try
            ImportarSintomas(nombreArchivo)
            MostrarMensaje(MsgBoxStyle.Information, "¡Importación finalizada!", "Tarea completada", "Import complete!", "Task complete")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        ActualizarSintomas()
    End Sub

    ' Abre un formulario con los detalles de un síntoma
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        If tblSintomas.SelectedRows.Count <> 1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Seleccione una sola fila para ver los detalles del síntoma.", "Error", "Select a single row to see details of the symptom.", "Error")
            Return
        End If

        Dim sintoma As Sintoma = tblSintomas.SelectedRows(0).Cells(0).Value
        Dim frm As New FrmVerSintomas(sintoma)
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    ' Abre un formulario que permite al usuario ingresar un nuevo síntoma
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New FrmAltaSintomas
        Me.Hide()
        frm.ShowDialog()
        ActualizarSintomas()
        Me.Show()
    End Sub

    ' Abre un formulario para que el usuario pueda ingresar nuevos datos para un síntoma ya almacenado
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If tblSintomas.SelectedRows.Count <> 1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Seleccione una sola fila para modificar un síntoma.", "Error", "Select a single row to modify a symptom.", "Error")
            Return
        End If

        Dim sintoma As Sintoma = tblSintomas.SelectedRows(0).Cells(0).Value
        Dim frm As New FrmModificacionSintomas(sintoma)
        Me.Hide()
        frm.ShowDialog()
        ActualizarSintomas()
        Me.Show()
    End Sub

    ' Permite eliminar uno o varios de los síntomas del sistema, luego de recibir confirmación del usuario
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If tblSintomas.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Information, "Seleccione al menos una fila para eliminar el/los síntoma(s).", "", "Select at least one row to delete the symptom(s).", "")
            Return
        End If

        If MostrarMensaje(MsgBoxStyle.YesNo, "¿Confirma que desea eliminar esto(s) síntoma(s)?" & vbNewLine & "Estos cambios no podrán deshacerse.", "Advertencia", "Are you sure you wish to delete this symptom(s)?" & vbNewLine & "These changes cannot be undone.", "Warning") = DialogResult.Yes Then

            Try
                For Each r As DataGridViewRow In tblSintomas.SelectedRows
                    EliminarSintoma(r.Cells(0).Value)
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
            ActualizarSintomas()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub txtBuscarSintomas_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarSintomas.TextChanged
        For Each r As DataGridViewRow In tblSintomas.Rows
            If r.Cells(0).Value.ToString.ToLower Like ("*" & txtBuscarSintomas.Text & "*").ToLower Then
                r.Visible = True
            Else
                r.Visible = False
                If r.Selected Then
                    r.Selected = False
                End If
            End If
        Next
    End Sub

    Private Sub FrmListadoSintomas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class
