' Este módulo define varios enumerados utilizados por el sistema para reducir la tasa de errores en los casos en que los valores posibles son finitos

Public Module Enumerados
#Region "Atributos de clases"
    Public Enum TiposObjeto
        DiagnosticoPrimario = 1
        DiagnosticoDiferencial = 2
        Enfermedad = 3
        Especialidad = 4
        Departamento = 5
        Localidad = 6
        Sintoma = 7
        Usuario = 8
        Mensaje = 9
        Administrativo = 10
        Paciente = 11
        Medico = 12
        DiagnosticoPrimarioConConsulta = 13
    End Enum

    Public Enum TiposPersona
        Funcionario = 1
        Paciente = 2
    End Enum

    Public Enum TiposFuncionario
        Administrativo = 1
        Medico = 2
    End Enum

    Public Enum TiposSexo
        M = 1
        F = 2
        O = 3
    End Enum

    Public Enum TiposDiagnosticosPrimarios
        Sin_Consulta = 1
        Con_Consulta = 2
    End Enum

    Public Enum TiposUsuario
        Paciente = 1
        Medico = 2
        Administrativo = 3
    End Enum

    Public Enum FormatosMensajeAdmitidos
        PDF = 1
        JPG = 2
        JPEG = 3
        PNG = 4
        TXT = 5
    End Enum

    Public Enum TiposRemitente
        Medico = 1
        Paciente = 2
    End Enum
#End Region

    Public Enum ResultadosLogin
        PersonaNoExiste = 1
        ContrasenaIncorrecta = 2
        OK = 3
        SinUsuario = 4
    End Enum

    Public Enum Idiomas
        Espanol = 1
        Ingles = 2
    End Enum
End Module
