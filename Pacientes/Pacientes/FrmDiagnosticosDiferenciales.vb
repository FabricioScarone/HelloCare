Imports System.ComponentModel
Imports System.Globalization
Imports System.Windows.Forms
Imports CapaLogica
Imports Clases

Public Class FrmDiagnosticosDiferenciales
    Public Sub New(diagnosticoPrimario As DiagnosticoPrimarioConConsulta)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim diagnosticosDiferenciales As List(Of DiagnosticoDiferencial)
        Try
            diagnosticosDiferenciales = CargarDiagnosticosDiferenciales(diagnosticoPrimario)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        For i = 0 To diagnosticosDiferenciales.Count - 1
            tblDiagnosticosDiferenciales.Rows.Add(i + 1, diagnosticosDiferenciales(i).EnfermedadDiagnosticada, diagnosticosDiferenciales(i).ConductaASeguir, diagnosticosDiferenciales(i).FechaHora)
        Next

        lblNombreMedico.Text = lblNombreMedico.Text.Replace("#", diagnosticoPrimario.Medico.ToString)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmDiagnosticosDiferenciales_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Paciente, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class