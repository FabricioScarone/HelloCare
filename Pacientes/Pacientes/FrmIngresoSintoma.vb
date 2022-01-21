Imports System.Windows.Forms
Imports CapaLogica
Imports Clases

Public Class FrmIngresoSintoma
    ' Esta bandera se implementa para indicar al evento FormClosing 
    ' si el formulario se cierra para volver sin guardar o habiendo ingresado datos
    'Private requiereConfirmacionSalida As Boolean = True

    ' Carga ambos DataGridView con los síntomas disponibles, y oculta todos en tblSeleccionados
    Private Sub FrmIngresoSintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sintomas As List(Of Sintoma)
        Try
            sintomas = CargarTodosLosSintomas()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try
        For Each s As Sintoma In sintomas
            tblDisponibles.Rows.Add(s, s.Nombre)
        Next
    End Sub

    ' Seleccionar síntomas
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        For Each r As DataGridViewRow In tblDisponibles.SelectedRows
            tblSeleccionados.Rows.Add(DuplicarFila(r))
            tblDisponibles.Rows.Remove(r)
        Next
        DeseleccionarTablas()
    End Sub

    ' Deseleccionar síntomas
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        For Each r As DataGridViewRow In tblSeleccionados.SelectedRows
            tblDisponibles.Rows.Add(DuplicarFila(r))
            tblSeleccionados.Rows.Remove(r)
        Next
        DeseleccionarTablas()
    End Sub

    ' Filtra las enfermedades que el usuario puede elegir según su nombre
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        For Each r As DataGridViewRow In tblDisponibles.Rows
            If r.Cells(1).Value.ToString.ToLower Like ("*" & txtBuscar.Text & "*").ToLower Then
                r.Visible = True
            Else
                r.Visible = False
                If r.Selected Then
                    r.Selected = False
                End If
            End If
        Next
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If tblSeleccionados.Rows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Debe ingresar al menos un síntoma para recibir un diagnóstico.", "Error", "You must select at least one symptom to receive a diagnosis.", "Error")
            Return
        End If

        Dim sintomasSeleccionados As New List(Of Sintoma)
        For Each r As DataGridViewRow In tblSeleccionados.Rows
            sintomasSeleccionados.Add(r.Cells(0).Value)
        Next

        'Abre la ventana de diagnostico y cierra la actual
        Dim frm As New FrmDiagnosticoPrimario(sintomasSeleccionados)
        Me.Hide()
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmIngresoSintoma_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MostrarMensaje(MsgBoxStyle.YesNo, "Advertencia: no se guardaron los cambios." & vbNewLine & "¿Confirma que desea cerrar la ventana?", "Salir", "Warning: changes have not been saved." & vbNewLine & "Are you sure you want to close the window?", "Exit") =
                MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DeseleccionarTablas()
        tblDisponibles.ClearSelection()
        tblSeleccionados.ClearSelection()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmIngresoSintoma_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Paciente, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class