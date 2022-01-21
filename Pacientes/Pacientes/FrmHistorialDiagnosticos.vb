Imports System.ComponentModel
Imports System.Globalization
Imports System.Windows.Forms
Imports CapaLogica
Imports Clases

Public Class FrmHistorialDiagnosticos
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim diagnosticosPrimarios As List(Of DiagnosticoPrimario)
        Try
            diagnosticosPrimarios = CargarDiagnosticosPrimariosDelPaciente(pacienteLogeado)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        For Each d As DiagnosticoPrimario In diagnosticosPrimarios
            If d.Enfermedades.Count > 0 Then
                tblDiagnosticos.Rows.Add(d, d.Enfermedades(0), d.Probabilidad(0) & "%", d.FechaHora)
            Else
                tblDiagnosticos.Rows.Add(d, "Sin diagnóstico.", "", d.FechaHora)
            End If
        Next
    End Sub

    Private Sub btnVerDetalles_Click(sender As Object, e As EventArgs) Handles btnVerDetalles.Click
        If tblDiagnosticos.SelectedRows.Count = 1 Then
            Dim diagnosticoSeleccionado As DiagnosticoPrimario = CType(tblDiagnosticos.SelectedRows(0).Cells(0).Value, DiagnosticoPrimario)
            Dim frm As New FrmDiagnosticoPrimario(diagnosticoSeleccionado)
            Me.Hide()
            frm.ShowDialog()
            Me.Show()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmHistorialDiagnosticos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Paciente, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class