Imports System.Text

Public Class Mensaje
    Private ReadOnly _ID As Integer
    Private ReadOnly _FechaHora As Date
    Private ReadOnly _Formato As FormatosMensajeAdmitidos
    Private ReadOnly _NombreArchivo As String
    Private ReadOnly _Contenido() As Byte
    Private ReadOnly _Remitente As TiposRemitente
    Private ReadOnly _DiagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta

    Public ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property

    Public ReadOnly Property FechaHora As Date
        Get
            Return _FechaHora
        End Get
    End Property

    Public ReadOnly Property Formato As FormatosMensajeAdmitidos
        Get
            Return _Formato
        End Get
    End Property

    Public ReadOnly Property NombreArchivo As String
        Get
            Return _NombreArchivo
        End Get
    End Property

    Public ReadOnly Property Contenido As Byte()
        Get
            Return _Contenido
        End Get
    End Property

    Public ReadOnly Property Remitente As TiposRemitente
        Get
            Return _Remitente
        End Get
    End Property

    Public ReadOnly Property DiagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta
        Get
            Return _DiagnosticoPrimarioConConsulta
        End Get
    End Property

    Public Sub New(fechaHora As Date, formato As FormatosMensajeAdmitidos, contenido As Byte(), nombreArchivo As String,
                   remitente As TiposRemitente, diagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta)

        _ID = Integer.MinValue
        ValidarDatos(fechaHora, contenido, formato, nombreArchivo, remitente)
        _FechaHora = fechaHora
        _Formato = formato
        _NombreArchivo = nombreArchivo
        _Contenido = contenido
        _Remitente = remitente
        _DiagnosticoPrimarioConConsulta = diagnosticoPrimarioConConsulta
    End Sub

    Public Sub New(id As Integer, fechaHora As Date, formato As FormatosMensajeAdmitidos, contenido As Byte(), remitente As TiposRemitente,
                   nombreArchivo As String, diagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta)

        _ID = id
        ValidarDatos(fechaHora, contenido, formato, nombreArchivo, remitente)
        _FechaHora = fechaHora
        _Formato = formato
        _NombreArchivo = nombreArchivo
        _Contenido = contenido
        _Remitente = remitente
        _DiagnosticoPrimarioConConsulta = diagnosticoPrimarioConConsulta
    End Sub

    Private Sub ValidarDatos(fechaHora As Date, contenido As Byte(), formato As FormatosMensajeAdmitidos, nombreArchivo As String, remitente As TiposRemitente)
        If fechaHora = Nothing Or fechaHora < New Date(2010, 1, 1) Or fechaHora > Now Then
            Throw New ArgumentException("La fecha registrada en el mensaje no es válida.")
        End If

        If Not [Enum].IsDefined(GetType(FormatosMensajeAdmitidos), formato) Then
            Throw New ArgumentException("No se especificó un formato válido para el mensaje.")
        End If

        If formato <> FormatosMensajeAdmitidos.TXT And nombreArchivo = Nothing Then
            Throw New ArgumentException("Debe especificarse un nombre para el archivo.")
        End If

        If Not [Enum].IsDefined(GetType(TiposRemitente), remitente) Then
            Throw New ArgumentException("No se especificó un remitente válido para el mensaje.")
        End If

        If formato = FormatosMensajeAdmitidos.TXT Then
            ValidarCaracteresTexto(Encoding.UTF8.GetString(contenido))
        End If
    End Sub

    Public Overrides Function ToString() As String
        If _Formato = FormatosMensajeAdmitidos.TXT Then
            Return Encoding.UTF8.GetString(_Contenido)
        Else
            Return _NombreArchivo
        End If
    End Function
End Class
