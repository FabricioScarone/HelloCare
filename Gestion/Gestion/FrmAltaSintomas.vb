Imports System.ComponentModel
Imports System.Globalization
Imports CapaLogica
Imports Clases

Public Class FrmAltaSintomas
    Private Sub FrmAltaSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each enfermedad As Enfermedad In CargarTodasLasEnfermedades()
            tblPatologias.Rows.Add(enfermedad, False, enfermedad.Nombre, "")
        Next
        tblPatologias.ClearSelection()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If MostrarMensaje(MsgBoxStyle.YesNo, "Advertencia: no se guardaron los cambios." & vbNewLine & "¿Confirma que desea cerrar la ventana?", "Salir", "Warning: no changes have been saved." & vbNewLine & "Are you sure you wish to close the window?", "Exit") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Determina si se asociaron patologías, si no se hizo mostrará una advertencia
        Dim hayPatologiasAsociadas As Boolean = False
        For Each r As DataGridViewRow In tblPatologias.Rows
            If r.Cells(1).Value = True Then
                hayPatologiasAsociadas = True
            End If
        Next

        ' Procede a insertar el nuevo síntoma si se ingresaron patologías o si se confirma que se desea insertarlo sin patologías asociadas
        If hayPatologiasAsociadas OrElse
           (Not hayPatologiasAsociadas And MostrarMensaje(MsgBoxStyle.YesNo, "Advertencia: no se asoció el nuevo síntoma a ninguna patología del sistema." & vbNewLine & "¿Desea continuar de todas formas?", "Aviso", "Warning: the new symptom has not been associated with any illness in the system." & vbNewLine & "Do you wish to continue anyway?", "Warning") = MsgBoxResult.Yes) Then


            Dim listaEnfermedades As New List(Of Enfermedad)
            Dim listaFrecuencias As New List(Of Decimal)
            For Each r As DataGridViewRow In tblPatologias.Rows
                If r.Cells(1).Value = True Then
                    Dim frecuencia As Decimal
                    If Not Decimal.TryParse(r.Cells(3).Value.ToString.Replace("%", ""), frecuencia) Then
                        MostrarMensaje(MsgBoxStyle.Critical, "Las frecuencias solo pueden ser valores numéricos.", "Error", "Frequencies can only be numeric values.", "Error")
                        Return
                    Else
                        listaEnfermedades.Add(r.Cells(0).Value)
                        listaFrecuencias.Add(frecuencia)
                    End If
                End If
            Next

            Dim urgencia As Integer
            If Not Integer.TryParse(txtUrgencia.Text, urgencia) Then
                MostrarMensaje(MsgBoxStyle.Critical, "La urgencia debe ser un valor numérico entero.", "Error", "Urgency must be an integer value.", "Error")
                Return
            End If

            Dim nombre As String = txtNombre.Text
            Dim descripcion As String = txtDescripcion.Text
            Dim recomendaciones As String = txtRecomendaciones.Text

            Try
                CrearSintoma(nombre, descripcion, recomendaciones, urgencia, listaEnfermedades, listaFrecuencias)
                MostrarMensaje(MsgBoxStyle.OkOnly, "Síntoma agregado con éxito.", "Éxito", "Symptom has been successfully created.", "Success")
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmAltaSintomas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class
