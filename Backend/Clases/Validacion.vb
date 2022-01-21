' Este módulo ofrece varios procedimientos que se utilizan para validar el texto de distintos campos de clases de tipo String
' Cuando el campo de texto no supera la validación, el procedimiento lanza una excepción.

Friend Module Validacion
    Private ReadOnly CaracteresPermitidosTexto() As Char = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789áéíóúÁÉÍÓÚàèìòùÀÈÌÒÙüÜçÇßãÃ-_()/:;""',.%&¿?¡!+<>$= " & vbNewLine).ToCharArray
    Private ReadOnly CaracteresPermitidosNombres() As Char = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyzáéíóúÁÉÍÓÚàèìòùÀÈÌÒÙüÜçÇ- ".ToArray
    Private ReadOnly CaracteresPermitidosCorreos() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+!#$%&'*+-/=?^_`{|.@".ToArray
    Private ReadOnly CaracteresPermitidosNumeros() As Char = "0123456789".ToArray

    Friend Sub ValidarCaracteresTexto(texto As String)
        Dim caracteresInvalidosDetectados As New List(Of Char)
        For Each c As Char In texto.ToCharArray
            If Not CaracteresPermitidosTexto.Contains(c) Then
                caracteresInvalidosDetectados.Add(c)
            End If
        Next

        If caracteresInvalidosDetectados.Count > 0 Then
            Dim listaCaracteres As New List(Of String)
            For Each c As Char In caracteresInvalidosDetectados.Distinct.ToArray
                listaCaracteres.Add(c)
            Next

            Throw New ArgumentException("El texto no puede contener los siguientes caracteres:" & vbNewLine & vbNewLine &
                                        String.Join(" "c, caracteresInvalidosDetectados.Distinct.ToArray))
        End If
    End Sub

    Friend Sub ValidarCaracteresTexto(ParamArray textos() As String)
        For Each s As String In textos
            ValidarCaracteresTexto(s)
        Next
    End Sub

    Friend Sub ValidarCaracteresNombre(nombre As String)
        Dim caracteresInvalidosDetectados As New List(Of Char)
        For Each c As Char In nombre.ToCharArray
            If Not CaracteresPermitidosNombres.Contains(c) Then
                caracteresInvalidosDetectados.Add(c)
            End If
        Next

        If caracteresInvalidosDetectados.Count > 0 Then
            Dim listaCaracteres As New List(Of String)
            For Each c As Char In caracteresInvalidosDetectados.Distinct.ToArray
                listaCaracteres.Add(c)
            Next

            Throw New ArgumentException("El nombre no puede contener los siguientes caracteres:" & vbNewLine & vbNewLine &
                                        String.Join(" "c, caracteresInvalidosDetectados.Distinct.ToArray))
        End If
    End Sub

    Friend Sub ValidarCaracteresNombre(ParamArray nombres() As String)
        For Each s As String In nombres
            ValidarCaracteresNombre(s)
        Next
    End Sub

    Friend Sub ValidarCaracteresCalle(nombreCalle As String)
        Dim caracteresInvalidosDetectados As New List(Of Char)
        For Each c As Char In nombreCalle.ToCharArray
            If Not (CaracteresPermitidosNombres & CaracteresPermitidosNumeros).Contains(c) Then
                caracteresInvalidosDetectados.Add(c)
            End If
        Next

        If caracteresInvalidosDetectados.Count > 0 Then
            Dim listaCaracteres As New List(Of String)
            For Each c As Char In caracteresInvalidosDetectados.Distinct.ToArray
                listaCaracteres.Add(c)
            Next

            Throw New ArgumentException("El nombre de la calle no puede contener los siguientes caracteres:" & vbNewLine & vbNewLine &
                                        String.Join(" "c, caracteresInvalidosDetectados.Distinct.ToArray))
        End If
    End Sub

    Friend Sub ValidarCaracteresCorreo(correo As String)
        Dim caracteresInvalidosDetectados As New List(Of Char)
        For Each c As Char In correo.ToCharArray
            If Not CaracteresPermitidosCorreos.Contains(c) Then
                caracteresInvalidosDetectados.Add(c)
            End If
        Next

        If caracteresInvalidosDetectados.Count > 0 Then
            Dim listaCaracteres As New List(Of String)
            For Each c As Char In caracteresInvalidosDetectados.Distinct.ToArray
                listaCaracteres.Add(c)
            Next

            Throw New ArgumentException("El correo no puede contener los siguientes caracteres:" & vbNewLine & vbNewLine &
                                        String.Join(" "c, caracteresInvalidosDetectados.Distinct.ToArray))
        End If
    End Sub

    Friend Sub ValidarCaracteresNumero(numero As String)
        Dim caracteresInvalidosDetectados As New List(Of Char)
        For Each c As Char In numero.ToCharArray
            If Not CaracteresPermitidosNumeros.Contains(c) Then
                caracteresInvalidosDetectados.Add(c)
            End If
        Next

        If caracteresInvalidosDetectados.Count > 0 Then
            Dim listaCaracteres As New List(Of String)
            For Each c As Char In caracteresInvalidosDetectados.Distinct.ToArray
                listaCaracteres.Add(c)
            Next

            Throw New ArgumentException("El número no puede contener los siguientes caracteres:" & vbNewLine & vbNewLine &
                                        String.Join(" "c, caracteresInvalidosDetectados.Distinct.ToArray))
        End If
    End Sub

    Friend Sub ValidarCaracteresNumero(ParamArray numeros() As String)
        For Each s As String In numeros
            ValidarCaracteresTexto(s)
        Next
    End Sub

    Friend Sub ValidarCaracteresEnfermedadYSintoma(nombre As String)
        Dim caracteresInvalidosDetectados As New List(Of Char)
        For Each c As Char In nombre.ToCharArray
            If Not (CaracteresPermitidosNombres & CaracteresPermitidosNumeros).Contains(c) Then
                caracteresInvalidosDetectados.Add(c)
            End If
        Next

        If caracteresInvalidosDetectados.Count > 0 Then
            Dim listaCaracteres As New List(Of String)
            For Each c As Char In caracteresInvalidosDetectados.Distinct.ToArray
                listaCaracteres.Add(c)
            Next

            Throw New ArgumentException("El nombre del síntoma o enfermedad no puede contener los siguientes caracteres:" & vbNewLine & vbNewLine &
                                        String.Join(" "c, caracteresInvalidosDetectados.Distinct.ToArray))
        End If
    End Sub

    Friend Sub ValidarCaracteresEnfermedadYSintoma(ParamArray nombres() As String)
        For Each s As String In nombres
            ValidarCaracteresTexto(s)
        Next
    End Sub
End Module
