Imports System.ComponentModel
Imports System.Globalization
Imports CapaLogica
Imports Clases

Public Class FrmVerSintomas
    Sub New(sintoma As Sintoma)
        InitializeComponent()

        ' Muestra los datos del síntoma seleccionado en la ventana anterior
        txtNombre.Text = sintoma.Nombre
        txtDescripcion.Text = sintoma.Descripcion
        txtRecomendaciones.Text = sintoma.Recomendaciones
        txtUrgencia.Text = sintoma.Urgencia

        For i = 0 To sintoma.Enfermedades.Count - 1
            tblPatologias.Rows.Add(sintoma.Enfermedades(i), sintoma.Enfermedades(i).Descripcion, sintoma.FrecuenciaEnfermedad(i))
        Next
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    ' Evita que algún control quede seleccionado y distraiga al usuario
    Private Sub FrmVerSintomas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ActiveControl = Nothing
        tblPatologias.ClearSelection()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmVerSintomas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class
