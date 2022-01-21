Imports System.ComponentModel
Imports System.Globalization
Imports CapaLogica
Imports Clases

Public Class FrmVerEnfermedades
    Sub New(enfermedad As Enfermedad)
        InitializeComponent()

        ' Muestra los datos de la enfermedad seleccionada en la ventana anterior
        txtNombre.Text = enfermedad.Nombre
        txtDescripcion.Text = enfermedad.Descripcion
        txtRecomendaciones.Text = enfermedad.Recomendaciones
        txtGravedad.Text = enfermedad.Gravedad

        For i = 0 To enfermedad.Sintomas.Count - 1
            tblSintomas.Rows.Add(enfermedad.Sintomas(i), enfermedad.Sintomas(i).Descripcion, enfermedad.FrecuenciaSintoma(i))
        Next
    End Sub

    ' Evita que algún control quede seleccionado y distraiga al usuario
    Private Sub FrmVerEnfermedades_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ActiveControl = Nothing
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmVerEnfermedades_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class
