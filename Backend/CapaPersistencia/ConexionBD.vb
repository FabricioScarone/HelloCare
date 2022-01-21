Imports MySql.Data.MySqlClient

Public NotInheritable Class ConexionBD
    Private Shared _Conexion As MySqlConnection
    Private Shared Adaptador As MySqlDataAdapter

    Public Shared ReadOnly Property Conexion() As MySqlConnection
        Get
            ' Si no se inicializó la conexión, lo hace con los datos de login en la BD
            If _Conexion Is Nothing Then
                Dim url As String = "vdo.dyndns.org"
                Dim nombreBD As String = "hellocare"
                Dim usuario As String = "hellocare"
                Dim contrasena As String = "h3llocar3"

                Dim cadenaConexion As String = String.Format("server={0};database={1};userid={2};password={3};allowzerodatetime=True;convertzerodatetime=True;charset=utf8;",
                                                              url, nombreBD, usuario, contrasena)

                _Conexion = New MySqlConnection(cadenaConexion)
            End If

            Return _Conexion
        End Get
    End Property

    ' Ejecuta una consulta contra la BD y retorna el DataTable con los datos devueltos por la BD
    Public Shared Function EjecutarConsulta(comando As MySqlCommand) As DataTable
        Dim datos As New DataSet
        comando.Connection = Conexion
        Adaptador = New MySqlDataAdapter(comando)
        Adaptador.Fill(datos)
        Dim tabla As DataTable = datos.Tables(0)
        datos.Tables.Remove(tabla)
        Return tabla
    End Function

    ' Sobrecarga de la función anterior que especifica el nombre del DataTable devuelto
    Public Shared Function EjecutarConsulta(comando As MySqlCommand, nombreTabla As String) As DataTable
        Dim datos As New DataSet
        comando.Connection = Conexion
        Adaptador = New MySqlDataAdapter(comando)
        Adaptador.Fill(datos, nombreTabla)
        Adaptador.FillSchema(datos, SchemaType.Mapped, nombreTabla)
        Dim tabla As DataTable = datos.Tables(nombreTabla)
        datos.Tables.Remove(tabla)
        Return tabla
    End Function

    ' Ejecuta una sentencia SQL contra la BD que no retorna ningún resultado
    Public Shared Sub EjecutarTransaccion(comando As MySqlCommand)
        Try
            comando.Connection = Conexion
            comando.ExecuteNonQuery()
        Catch ex As MySqlException
            If ex.Number = 1042 Then
                Throw New Exception("No se puede establecer la conexión con la base de datos.")
            Else
                Throw ex
            End If
        End Try
    End Sub

    ' Retorna el ID correspondiente al último INSERT realizado en la BD, para inserciones que dependan de un ID que a la vez sea Foreign Key
    Public Shared Function ObtenerUltimoIdInsertado() As Integer
        Dim datos As DataTable = EjecutarConsulta(New MySqlCommand("SELECT LAST_INSERT_ID();"))
        Return datos.Rows(0)(0)
    End Function
End Class
