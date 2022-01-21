Imports System.ComponentModel
Imports System.Globalization
Imports CapaLogica
Imports Clases

Public Class FrmModificacionEnfermedades
    ' Esta bandera se implementa para indicar al evento FormClosing 
    ' si el formulario se cierra para volver sin guardar o habiendo ingresado datos
    Private requiereConfirmacionSalida As Boolean = True

    Dim enfermedadAModificar As Enfermedad

    Sub New(enfermedad As Enfermedad)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Precarga los datos de la enfermedad en los campos de texto correspondientes
        txtNombre.Text = enfermedad.Nombre
        txtDescripcion.Text = enfermedad.Descripcion
        txtGravedad.Text = enfermedad.Gravedad
        txtRecomendaciones.Text = enfermedad.Recomendaciones

        ' Precarga los datos de los síntomas asociados a la enfermedad
        For i = 0 To enfermedad.Sintomas.Count - 1
            tblAsociados.Rows.Add(enfermedad.Sintomas(i), enfermedad.Sintomas(i).Nombre, enfermedad.FrecuenciaSintoma(i) & "%")
        Next

        ' Almacena la enfermedad que se va a estar modificando
        enfermedadAModificar = enfermedad

        Dim sintomas As List(Of Sintoma)
        Try
            sintomas = CargarTodosLosSintomas()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        For Each sintoma As Sintoma In sintomas
            tblSintomas.Rows.Add(sintoma, sintoma.Nombre)
        Next
        OcultarSintomasSeleccionadosOFiltrados()

        Dim especialidades As List(Of Especialidad)
        Try
            especialidades = CargarTodasLasEspecialidades()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try
        For Each especialidad As Especialidad In especialidades
            tblEspecialidades.Rows.Add(especialidad)
        Next

        For Each r As DataGridViewRow In tblEspecialidades.Rows
            If CType(r.Cells(0).Value, Especialidad).ID = enfermedad.Especialidad.ID Then
                r.Selected = True
            End If
        Next
    End Sub

    Private Sub txtBuscarSintoma_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarSintoma.TextChanged
        OcultarSintomasSeleccionadosOFiltrados()
    End Sub

    Private Sub txtBuscarEspecialidades_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEspecialidades.TextChanged
        For Each r As DataGridViewRow In tblEspecialidades.Rows
            If r.Cells(0).Value.ToString.ToLower Like ("*" & txtBuscarEspecialidades.Text & "*").ToLower Then
                r.Visible = True
            Else
                r.Visible = False
                If r.Selected Then
                    r.Selected = False
                End If
            End If
        Next
    End Sub

    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        If tblSintomas.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Debe seleccionar al menos uno de los síntomas disponibles.", "Error", "You must select at least one of the available symptoms.", "Error")
            Return
        End If

        For Each r As DataGridViewRow In tblSintomas.SelectedRows
            tblAsociados.Rows.Add(r.Cells(0).Value, r.Cells(1).Value, "")
        Next
        OcultarSintomasSeleccionadosOFiltrados()
    End Sub

    Private Sub btnQuitarSintoma_Click(sender As Object, e As EventArgs) Handles btnQuitarSintoma.Click
        If tblAsociados.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "Debe seleccionar al menos uno de los síntomas asociados.", "Error", "You must select at least one of the associated symptoms.", "Error")
            Return
        End If

        For Each rAsociada As DataGridViewRow In tblAsociados.SelectedRows
            For Each rPatologia As DataGridViewRow In tblSintomas.Rows
                If rPatologia.Cells(1).Value = rAsociada.Cells(1).Value Then
                    rPatologia.Visible = True
                End If
            Next
            tblAsociados.Rows.Remove(rAsociada)
        Next
        OcultarSintomasSeleccionadosOFiltrados()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim listaSintomas As New List(Of Sintoma)
        Dim listaFrecuencias As New List(Of Decimal)
        For Each r As DataGridViewRow In tblAsociados.Rows
            Dim frecuencia As Decimal
            If Not Decimal.TryParse(r.Cells(2).Value.ToString.Replace("%", ""), frecuencia) Then
                MostrarMensaje(MsgBoxStyle.Critical, "Las frecuencias solo pueden ser valores numéricos.", "Error", "Frequencies can only be numeric values.", "Error")
                Return
            Else
                listaSintomas.Add(r.Cells(0).Value)
                listaFrecuencias.Add(frecuencia)
            End If
        Next

        Dim especialidad As Especialidad
        If tblEspecialidades.SelectedRows.Count = 0 Then
            MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó ninguna especialidad.", "Error", "No specialty was selected.", "Error")
            Return
        Else
            especialidad = tblEspecialidades.SelectedRows(0).Cells(0).Value
        End If

        Dim nombre As String = txtNombre.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim recomendaciones As String = txtRecomendaciones.Text

        Dim gravedad As Integer
        If Not Integer.TryParse(txtGravedad.Text, gravedad) Then
            MostrarMensaje(MsgBoxStyle.Critical, "La gravedad debe ser un valor numérico entero.", "Error", "Severity must be an integer value.", "Error")
            Return
        End If

        Try
            ActualizarEnfermedad(enfermedadAModificar, nombre, descripcion, recomendaciones, gravedad, listaSintomas, listaFrecuencias, especialidad)
            MostrarMensaje(MsgBoxStyle.Information, "Modificación realizada con éxito", "Éxito", "Illness has been successfully modified.", "Success")
            requiereConfirmacionSalida = False
            Me.Close()
        Catch ex As Exception
            MostrarMensaje(MsgBoxStyle.Critical, ex.Message, "Error", ex.Message, "Error")
        End Try
    End Sub

    Private Sub OcultarSintomasSeleccionadosOFiltrados()
        ' Oculta por filtro de texto
        For Each r As DataGridViewRow In tblSintomas.Rows
            If r.Cells(1).Value.ToString.ToLower Like ("*" & txtBuscarSintoma.Text & "*").ToLower Then
                r.Visible = True
            Else
                r.Visible = False
                If r.Selected Then
                    r.Selected = False
                End If
            End If
        Next

        ' Oculta los síntomas ya seleccionadas
        For Each rAsociado As DataGridViewRow In tblAsociados.Rows
            For Each rSintoma As DataGridViewRow In tblSintomas.Rows
                If rAsociado.Cells(1).Value = rSintoma.Cells(1).Value Then
                    rSintoma.Visible = False
                End If
            Next
        Next
        DeseleccionarTablas()
    End Sub

    Private Sub DeseleccionarTablas()
        tblAsociados.ClearSelection()
        tblSintomas.ClearSelection()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    ' Si intenta cerrar el formulario sin guardar cambios, solicita confirmación
    Private Sub FrmModificacionEnfermedades_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If requiereConfirmacionSalida Then
            If MostrarMensaje(MsgBoxStyle.YesNo, "Advertencia: no se guardaron los cambios." & vbNewLine & "¿Confirma que desea cerrar la ventana?", "Salir", "Warning: no changes have been saved." & vbNewLine & "Are you sure you wish to close the window?", "Exit") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmModificacionEnfermedades_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Administrativo, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class
