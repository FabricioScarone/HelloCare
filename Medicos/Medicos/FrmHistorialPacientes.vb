Imports System.ComponentModel
Imports System.Globalization
Imports CapaLogica
Imports Clases

Public Class FrmHistorialPacientes
    Private Sub FrmHistorialPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ultimasConsultas As List(Of DiagnosticoPrimarioConConsulta)
        Try
            ultimasConsultas = CargarConsultasMedico()              ' Carga las últimas consultas atendidas por el médico
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        For Each d As DiagnosticoPrimarioConConsulta In ultimasConsultas
            If d.Enfermedades.Count > 0 Then
                ' Si la consulta tiene enfermedades diagnosticadas, registra sus datos
                tblUltimasConsultas.Rows.Add(d, d.Paciente, d.Enfermedades(d.IndiceEnfermedadMasProbable), d.FechaHora)
            Else
                ' sino agrega la consulta sin datos de diagnóstico
                tblUltimasConsultas.Rows.Add(d, d.Paciente, "Sin diagnóstico.", d.FechaHora)
            End If
        Next
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmHistorialPacientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Medico, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class