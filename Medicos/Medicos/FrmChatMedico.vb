Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports CapaLogica
Imports Clases

Public Class FrmChatMedico
    Private consultaEnCurso As DiagnosticoPrimarioConConsulta
    Private cantidadTotalMensajes As Integer
    Private cantidadTotalArchivos As Integer

    Public Sub New(consulta As DiagnosticoPrimarioConConsulta)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        consultaEnCurso = consulta
        If consultaEnCurso.Medico Is Nothing Then
            Try
                consultaEnCurso = AsignarMedicoLogeadoAConsulta(consulta)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return
            End Try
        End If

        lblNombrePaciente.Text = consultaEnCurso.Paciente.ToString

        Try
            cantidadTotalMensajes = ContarMensajes(consulta)
            cantidadTotalArchivos = ContarArchivos(consulta)
            MostrarNuevosMensajes(CargarUltimosMensajesDiagnostico(consultaEnCurso, cantidadTotalMensajes))
            MostrarNuevosMensajes(CargarUltimosMetadatosArchivosDiagnostico(consultaEnCurso, cantidadTotalArchivos))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        tmrActualizar.Enabled = True
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim bytesMensaje As Byte() = Encoding.UTF8.GetBytes(txtMensaje.Text.ToCharArray)

        Try
            EnviarMensaje(FormatosMensajeAdmitidos.TXT, bytesMensaje, TiposRemitente.Medico, consultaEnCurso)
            ActualizarMensajes()
            txtMensaje.Clear()
        Catch ex As Exception
            MostrarMensaje(MsgBoxStyle.Critical, "Hubo un error al enviar el mensaje.", "Error", "There was an error while sending the message.", "Error")
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        expAdjuntar.FileName = ""
        If expAdjuntar.ShowDialog() = DialogResult.OK Then
            Dim ruta As String = expAdjuntar.FileName
            Dim nombreArchivo As String = expAdjuntar.SafeFileName
            Dim extension As String = Path.GetExtension(ruta)
            Dim formato As FormatosMensajeAdmitidos
            Select Case extension.ToLower
                Case ".pdf"
                    formato = FormatosMensajeAdmitidos.PDF
                Case ".jpg"
                    formato = FormatosMensajeAdmitidos.JPG
                Case ".jpeg"
                    formato = FormatosMensajeAdmitidos.JPEG
                Case ".png"
                    formato = FormatosMensajeAdmitidos.PNG
                Case Else
                    MostrarMensaje(MsgBoxStyle.Critical, "No se seleccionó un formato de archivo válido. Los formatos válidos son JPG, JPEG, PNG y PDF.", "Formato de archivo inválido", "The file selected has no valid format. Valid file formats are JPG, JPEG, PNG and PDF.", "Invalid file format")
                    Return
            End Select
            Dim contenidoArchivo As Byte() = File.ReadAllBytes(ruta)
            Try
                EnviarMensaje(FormatosMensajeAdmitidos.TXT, Encoding.UTF8.GetBytes(medicoLogeado.ToString & " envió un archivo " & formato.ToString & " (" & nombreArchivo & ")."), TiposRemitente.Medico, consultaEnCurso)
                EnviarMensaje(formato, contenidoArchivo, TiposRemitente.Medico, consultaEnCurso, nombreArchivo)
            Catch ex As Exception
                MostrarMensaje(MsgBoxStyle.Critical, "Hubo un error al enviar el archivo adjunto.", "Error", "There was an error when sending the attachment.", "Error")
            End Try

            ActualizarMensajes()
        End If
    End Sub

    Private Sub tmrActualizar_Tick(sender As Object, e As EventArgs) Handles tmrActualizar.Tick
        tmrActualizar.Enabled = False
        ActualizarMensajes()
        tmrActualizar.Enabled = True
    End Sub

    Private Sub ActualizarMensajes()
        Try
            Dim cantidadActualizadaMensajes As Integer = ContarMensajes(consultaEnCurso)
            Dim cantidadNuevosMensajes As Integer = cantidadActualizadaMensajes - cantidadTotalMensajes

            If cantidadNuevosMensajes > 0 Then
                Dim nuevosMensajes As List(Of Mensaje) = CargarUltimosMensajesDiagnostico(consultaEnCurso, cantidadNuevosMensajes)
                cantidadTotalMensajes = cantidadActualizadaMensajes
                MostrarNuevosMensajes(nuevosMensajes)
            End If

            Dim cantidadActualizadaArchivos As Integer = ContarArchivos(consultaEnCurso)
            Dim cantidadNuevosArchivos As Integer = cantidadActualizadaArchivos - cantidadTotalArchivos

            If cantidadNuevosArchivos > 0 Then
                Dim nuevosArchivos As List(Of Mensaje) = CargarUltimosMetadatosArchivosDiagnostico(consultaEnCurso, cantidadNuevosArchivos)
                cantidadTotalArchivos = cantidadActualizadaArchivos
                MostrarNuevosMensajes(nuevosArchivos)
            End If
        Catch ex As Exception
            MostrarMensaje(MsgBoxStyle.Critical, "Hubo un error al intentar actualizar los mensajes.", "Error", "There was an error while updating the messages.", "Error")
        End Try
    End Sub

    Private Sub MostrarNuevosMensajes(mensajes As List(Of Mensaje))
        For Each m As Mensaje In mensajes
            If m.Formato = FormatosMensajeAdmitidos.TXT Then
                Dim prefijoMensaje As String = m.FechaHora.ToString("(dd/MM HH:mm:ss) ")
                If m.Remitente = TiposRemitente.Medico Then
                    prefijoMensaje &= "Tú: "
                Else
                    prefijoMensaje &= consultaEnCurso.Paciente.ToString & ": "
                End If
                txtConversacion.Text &= prefijoMensaje & m.ToString & vbNewLine
            Else
                lstArchivos.Items.Add(m)
            End If
        Next
    End Sub

    Private Sub btnDiagnosticar_Click(sender As Object, e As EventArgs) Handles btnDiagnosticar.Click
        Dim frmDiagnosticoDiferencial As New FrmNuevoDiagnostico(consultaEnCurso)
        frmDiagnosticoDiferencial.ShowDialog()
        If frmDiagnosticoDiferencial.DialogResult = DialogResult.OK Then
            Dim bytesMensaje As Byte() = Encoding.UTF8.GetBytes("Diagnóstico realizado: " & frmDiagnosticoDiferencial.diagnosticoRealizado.EnfermedadDiagnosticada.ToString)
            Try
                EnviarMensaje(FormatosMensajeAdmitidos.TXT, bytesMensaje, TiposRemitente.Medico, consultaEnCurso)
            Catch ex As Exception
                MostrarMensaje(MsgBoxStyle.Critical, "Hubo un error al enviar el mensaje.", "Error", "There was an error while sending the message.", "Error")
            End Try
            ActualizarMensajes()
            Dim archivosAdjuntos As New List(Of Mensaje)
            For i = 0 To lstArchivos.Items.Count - 1
                archivosAdjuntos.Add(lstArchivos.Items(i))
            Next

            Try
                EnviarSesionChat(consultaEnCurso.Paciente, frmDiagnosticoDiferencial.diagnosticoRealizado, txtConversacion.Text, archivosAdjuntos)
                MostrarMensaje(MsgBoxStyle.OkOnly, "Se ha enviado una copia de la sesión del chat al paciente.", "", "A copy of the chat session has been sent to the patient.", "")
            Catch ex As Exception
                MostrarMensaje(MsgBoxStyle.Critical, "Hubo un error al enviar la sesión de chat al correo del paciente.", "Error", "There was an error while sending the chat session to the patient's email.", "Error")
            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lstArchivos_DoubleClick(sender As Object, e As EventArgs) Handles lstArchivos.DoubleClick
        If lstArchivos.SelectedItems.Count = 1 Then
            ' Llamada a método para obtener archivo de la BD en base a ID
            Dim metadatos As Mensaje = lstArchivos.SelectedItem
            Dim contenidoArchivo As Byte()
            Try
                contenidoArchivo = CargarContenidoArchivoPorID(metadatos.ID)
            Catch ex As Exception
                MostrarMensaje(MsgBoxStyle.Critical, "Ocurrió un error al recuperar los datos del archivo.", "Error", "An error occured while retrieving the file data.", "Error")
                Return
            End Try

            Dim ruta As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & metadatos.NombreArchivo
            If File.Exists(ruta) Then
                Dim extension As String = ruta.Substring(ruta.Length - 1 - StrReverse(ruta).IndexOf("."))
                Dim nombreArchivo As String = ruta.Substring(0, ruta.Length - extension.Length)
                Dim numeradorArchivo As Integer = 1
                While File.Exists(nombreArchivo & "(" & numeradorArchivo & ")" & extension)
                    numeradorArchivo += 1
                End While
                ruta = nombreArchivo & "(" & numeradorArchivo & ")" & extension
            End If
            File.WriteAllBytes(ruta, contenidoArchivo)
            Dim abrirArchivo As New Process
            abrirArchivo.StartInfo.FileName = ruta
            abrirArchivo.Start()
        End If
        lstArchivos.ClearSelected()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub FrmChatMedico_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Medico, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class