Imports CapaLogica
Imports Clases

Public Class FrmPeticionesChat
    Private Sub FrmPeticionesChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrescarPeticiones()
    End Sub

    Private Sub RefrescarPeticiones()
        tblPeticiones.Rows.Clear()
        Dim consultas As List(Of DiagnosticoPrimarioConConsulta)
        Try
            consultas = CargarConsultasSinAtenderParaMedicoLogeado()            ' Obtiene las consultas que el medico actual puede aceptar
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        For Each d As DiagnosticoPrimarioConConsulta In consultas
            If d.Enfermedades.Count > 0 Then            ' Si tiene alguna enfermedad en el diagnóstico primario, se le asigna una prioridad específica
                Dim enfermedadMasProbable As Enfermedad = d.Enfermedades(d.IndiceEnfermedadMasProbable)
                Dim color As Color
                Dim etiqueta As String = ""

                If d.FechaHora.AddDays(1) < Now Then                ' Si la consulta lleva más de un día sin ser atendida, se marca como urgente,
                    etiqueta = "Atrasada"
                    color = Color.FromArgb(255, 97, 97)     ' Rojo claro
                Else
                    Select Case enfermedadMasProbable.Gravedad      ' sino se marca su prioridad de acuerdo a la gravedad de la enfermedad más probable
                        Case 0 To 30
                            etiqueta = "Baja"
                            color = Color.LightGreen
                        Case 31 To 70
                            etiqueta = "Media"
                            color = Color.Yellow
                        Case 71 To 100
                            etiqueta = "Alta"
                            color = Color.FromArgb(255, 97, 97)     ' Rojo claro
                    End Select
                End If

                tblPeticiones.Rows.Add(d, d.Paciente, enfermedadMasProbable, etiqueta, d.ComentariosAdicionales, d.FechaHora)

                ' Pinta las celdas de la fila de la consulta según la prioridad asignada
                For Each c As DataGridViewCell In tblPeticiones.Rows(tblPeticiones.Rows.Count - 1).Cells
                    c.Style.BackColor = color
                Next

            Else
                tblPeticiones.Rows.Add(d, d.Paciente, "", "", d.ComentariosAdicionales, d.FechaHora)
            End If

        Next
        tblPeticiones.ClearSelection()
    End Sub

    Private Sub btnAceptarConsulta_Click(sender As Object, e As EventArgs) Handles btnAceptarConsulta.Click
        If tblPeticiones.SelectedRows.Count <> 1 Then
            MostrarMensaje(MsgBoxStyle.Information, "Seleccione un diagnóstico para aceptar la petición e iniciar el chat.", "", "Select a diagnosis to accept the chat request.", "")
            Return
        End If

        Dim peticion As DiagnosticoPrimarioConConsulta = tblPeticiones.SelectedRows(0).Cells(0).Value
        Dim consultasActuales As List(Of DiagnosticoPrimarioConConsulta)
        Try
            consultasActuales = CargarConsultasSinAtenderParaMedicoLogeado()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        For Each c As DiagnosticoPrimarioConConsulta In consultasActuales
            If peticion.ID = c.ID And c.Medico IsNot Nothing Then           ' Verifica que la consulta no haya sido aceptada por otro doctor
                MostrarMensaje(MsgBoxStyle.Information, "La petición seleccionada ya fue atendida por un doctor. Por favor, seleccione otra.", "Petición ya aceptada", "The selected chat request has already been accepted by a doctor. Please, select another one.", "Request already accepted")
                Return
            End If
        Next

        Dim frm As New FrmChatMedico(peticion)
        Me.Hide()
        frm.ShowDialog()
        RefrescarPeticiones()
        Me.Show()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmPeticionesChat_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Medico, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class