Imports System.ComponentModel
Imports System.Globalization
Imports System.Windows.Forms
Imports Clases

' Este módulo provee métodos que permiten la localización de la UI.
Public Module Localizacion
    Public Sub TraducirAplicacion()
        Dim idioma As String
        Select Case idiomaSeleccionado                  ' Cambia el idioma y almacena en una variable el nombre de la cultura a la cual se cambia el idioma
            Case Idiomas.Espanol
                idiomaSeleccionado = Idiomas.Ingles
                idioma = "en"
            Case Idiomas.Ingles
                idiomaSeleccionado = Idiomas.Espanol
                idioma = "es"
            Case Else
                Throw New Exception("Error de idioma seleccionado.")
        End Select

        ' Configura cultura para elementos de la UI que se abran a partir del momento que se ejecuta este código
        Dim infoCultura As CultureInfo = CultureInfo.GetCultureInfo(idioma)
        CultureInfo.DefaultThreadCurrentCulture = infoCultura
        CultureInfo.DefaultThreadCurrentUICulture = infoCultura

        ' Configura cultura para elementos ya inicializados de la UI
        For Each f As Form In Application.OpenForms
            Dim crmLang As New ComponentResourceManager(f.GetType)
            For Each obj As Object In ObtenerControles(f)
                crmLang.ApplyResources(obj, obj.Name, infoCultura)
            Next
        Next
    End Sub

    ' Retorna todos los controles de un formulario o control
    Private Function ObtenerControles(control As Control) As List(Of Object)
        Dim lista As New List(Of Object)
        For Each c As Control In control.Controls       ' Para cada control del control recibido como parámetro
            lista.Add(c)                                ' añade el control a la lista.
            If c.Controls.Count > 0 Then                ' Si es un contenedor y tiene controles anidados,
                lista.AddRange(ObtenerControles(c))     ' Llama la función recursivamente para el contenedor
            End If

            If TryCast(c, DataGridView) IsNot Nothing Then                                  ' Si el control es un DataGridView,
                For Each col As DataGridViewColumn In CType(c, DataGridView).Columns        ' añade las columnas a la lista.
                    lista.Add(col)
                Next
            End If
        Next
        Return lista        ' Retorna la lista de controles obtenida.
    End Function

    ' Esta función es un wrapper del MsgBox básico. Dependiendo del idioma seleccionado, muestra el MessageBox con el texto en español o inglés. Retorna el resultado de mostrar dicho MessageBox.
    Public Function MostrarMensaje(tipoMensaje As MsgBoxStyle, textoES As String, tituloES As String, textoEN As String, tituloEN As String) As DialogResult
        Select Case idiomaSeleccionado
            Case Idiomas.Espanol
                Return MsgBox(textoES, tipoMensaje, tituloES)
            Case Idiomas.Ingles
                Return MsgBox(textoEN, tipoMensaje, tituloEN)
            Case Else
                Throw New Exception("Error de idioma seleccionado.")
        End Select
    End Function
End Module
