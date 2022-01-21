Imports System.ComponentModel
Imports System.Globalization
Imports CapaLogica
Imports Clases

Public Class FrmNuevoDiagnostico
    Private consulta As DiagnosticoPrimarioConConsulta
    Public diagnosticoRealizado As DiagnosticoDiferencial

    Public Sub New(consultaEnCurso As DiagnosticoPrimarioConConsulta)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        consulta = consultaEnCurso

        Dim enfermedades As List(Of Enfermedad)
        Try
            enfermedades = CargarTodasLasEnfermedades()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try
        For Each e As Enfermedad In enfermedades
            tblEnfermedades.Rows.Add(e)
        Next
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        For Each r As DataGridViewRow In tblEnfermedades.Rows
            If r.Cells(0).Value.ToString.ToLower Like ("*" & txtBuscar.Text & "*").ToLower Then
                r.Visible = True
            Else
                r.Visible = False
                If r.Selected Then
                    r.Selected = False
                End If
            End If
        Next
    End Sub

    Private Sub btnEnviarDiagnostico_Click(sender As Object, e As EventArgs) Handles btnEnviarDiagnostico.Click
        If tblEnfermedades.SelectedRows.Count <> 1 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Seleccione una sola enfermedad para realizar el diagnóstico.", "", "Select a single illness to make a diagnosis.", "")
            Return
        End If

        Dim enfermedadDiagnosticada As Enfermedad = tblEnfermedades.SelectedRows(0).Cells(0).Value
        Try
            diagnosticoRealizado = CrearDiagnosticoDiferencial(consulta, enfermedadDiagnosticada, txtConductaASeguir.Text)
            Me.DialogResult = DialogResult.OK
            MostrarMensaje(MsgBoxStyle.Information, "Diagnóstico enviado con éxito.", "", "Diagnosis has been successfully sent.", "")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmNuevoDiagnostico_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Medico, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class