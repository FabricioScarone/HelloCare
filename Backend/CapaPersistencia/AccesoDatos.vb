Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports Clases
Imports System.Text

Public Module AccesoDatos
    ' Recibe un objeto a insertar junto con un valor de TiposObjeto que especifica su tipo.
    ' El parámetro por referencia se utiliza para guardar el ID asignado por la base de datos al objeto, en caso de ser necesario por alguna capa superior.
    Public Sub InsertarObjeto(objetoAInsertar As Object, entidad As TiposObjeto, Optional ByRef idAsignado As Integer = -1)
        ' Intenta abrir la conexión y comienza la transacción
        Dim comando As New MySqlCommand("BEGIN;")
        Try
            ConexionBD.Conexion.Open()
        Catch ex As MySqlException
            Throw New Exception("No se puede establecer la conexión con la base de datos.")
        End Try

        ' Define qué tipo de objeto se va a insertar y lo procesa en consecuencia.
        Try
            Select Case entidad
                Case TiposObjeto.DiagnosticoPrimario
                    Dim diagnosticoPrimario As DiagnosticoPrimario = objetoAInsertar
                    comando.CommandText &= "INSERT INTO diagnosticos_primarios (ID_PACIENTE, FECHA_HORA, TIPO) VALUES (@ID_PACIENTE, @FECHA_HORA, @TIPO);"
                    comando.Parameters.AddWithValue("@ID_PACIENTE", diagnosticoPrimario.Paciente.ID)
                    comando.Parameters.AddWithValue("@FECHA_HORA", diagnosticoPrimario.FechaHora.ToString("yyyy-MM-dd HH:mm:ss"))
                    comando.Parameters.AddWithValue("@TIPO", diagnosticoPrimario.Tipo.ToString)
                    ConexionBD.EjecutarTransaccion(comando)

                    Dim idDiagnosticoPrimarioBD As Integer = ConexionBD.ObtenerUltimoIdInsertado
                    idAsignado = idDiagnosticoPrimarioBD
                    comando.CommandText = ""
                    comando.Parameters.Clear()
                    For i = 0 To diagnosticoPrimario.Enfermedades.Count - 1
                        comando.CommandText &= String.Format("INSERT INTO sistema_diagnostica VALUES (@ID_DIAGNOSTICO_PRIMARIO, @ID_ENFERMEDAD{0}, @PROBABILIDAD{0});", i)
                        comando.Parameters.AddWithValue("@ID_ENFERMEDAD" & i, diagnosticoPrimario.Enfermedades(i).Id)
                        comando.Parameters.AddWithValue("@PROBABILIDAD" & i, diagnosticoPrimario.Probabilidad(i).ToString.Replace(",", "."))
                    Next

                    For i = 0 To diagnosticoPrimario.Sintomas.Count - 1
                        comando.CommandText &= String.Format("INSERT INTO sistema_evalua VALUES (@ID_DIAGNOSTICO_PRIMARIO, @ID_SINTOMA{0});", i)
                        comando.Parameters.AddWithValue("@ID_SINTOMA" & i, diagnosticoPrimario.Sintomas(i).ID)
                    Next
                    comando.Parameters.AddWithValue("@ID_DIAGNOSTICO_PRIMARIO", idDiagnosticoPrimarioBD)


                Case TiposObjeto.DiagnosticoDiferencial
                    Dim diagnosticoDiferencial As DiagnosticoDiferencial = objetoAInsertar
                    comando.CommandText &= "INSERT INTO diagnosticos_diferenciales (ID_DIAGNOSTICO_PRIMARIO_CON_CONSULTA, ID_ENFERMEDAD, CONDUCTA_A_SEGUIR, FECHAHORA) VALUES (@ID_DIAGNOSTICO_PRIMARIO_CON_CONSULTA, @ID_ENFERMEDAD, @CONDUCTA_A_SEGUIR, @FECHAHORA);"
                    comando.Parameters.AddWithValue("@ID_DIAGNOSTICO_PRIMARIO_CON_CONSULTA", diagnosticoDiferencial.DiagnosticoPrimarioConConsulta.ID)
                    comando.Parameters.AddWithValue("@ID_ENFERMEDAD", diagnosticoDiferencial.EnfermedadDiagnosticada.Id)
                    comando.Parameters.AddWithValue("@CONDUCTA_A_SEGUIR", diagnosticoDiferencial.ConductaASeguir)
                    comando.Parameters.AddWithValue("@FECHAHORA", diagnosticoDiferencial.FechaHora.ToString("yyyy-MM-dd HH:mm:ss"))


                Case TiposObjeto.Enfermedad
                    Dim enfermedad As Enfermedad = objetoAInsertar

                    Dim estaDeshabilitado As Boolean = False
                    For Each r As DataRow In ConexionBD.EjecutarConsulta(New MySqlCommand("SELECT * FROM enfermedades WHERE HABILITADO=FALSE;")).Rows
                        If r("NOMBRE") = enfermedad.Nombre Then
                            estaDeshabilitado = True
                            Exit For
                        End If
                    Next

                    If estaDeshabilitado Then       ' Existe, y se deshabilitó
                        comando.CommandText &= "UPDATE enfermedades SET HABILITADO=TRUE, DESCRIPCION=@DESCRIPCION, RECOMENDACIONES=@RECOMENDACIONES, GRAVEDAD=@GRAVEDAD, ID_ESPECIALIDAD=@ID_ESPECIALIDAD WHERE NOMBRE=@NOMBRE"
                        comando.Parameters.AddWithValue("@DESCRIPCION", enfermedad.Descripcion)
                        comando.Parameters.AddWithValue("@RECOMENDACIONES", enfermedad.Recomendaciones)
                        comando.Parameters.AddWithValue("@GRAVEDAD", enfermedad.Gravedad)
                        comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", enfermedad.Especialidad.ID)
                        comando.Parameters.AddWithValue("@NOMBRE", enfermedad.Nombre)
                        ConexionBD.EjecutarTransaccion(comando)

                        Dim comandoBusquedaID As New MySqlCommand("SELECT ID FROM enfermedades WHERE NOMBRE=@NOMBRE;")
                        comandoBusquedaID.Parameters.AddWithValue("@NOMBRE", enfermedad.Nombre)
                        Dim idEnfermedadBD As Integer = ConexionBD.EjecutarConsulta(comandoBusquedaID).Rows(0)(0)
                        comando.CommandText = ""
                        comando.Parameters.Clear()
                        For i = 0 To enfermedad.Sintomas.Count - 1
                            comando.CommandText &= String.Format("INSERT INTO cuadro_sintomatico VALUES (@ID_SINTOMA{0}, @ID_ENFERMEDAD, @FRECUENCIA{0});", i)
                            comando.Parameters.AddWithValue("@ID_SINTOMA" & i, enfermedad.Sintomas(i).ID)
                            comando.Parameters.AddWithValue("@FRECUENCIA" & i, enfermedad.FrecuenciaSintoma(i).ToString.Replace(",", "."))
                        Next
                        comando.Parameters.AddWithValue("@ID_ENFERMEDAD", idEnfermedadBD)
                    Else        ' Jamás existió
                        comando.CommandText &= "INSERT INTO enfermedades (NOMBRE, DESCRIPCION, RECOMENDACIONES, GRAVEDAD, ID_ESPECIALIDAD) VALUES (@NOMBRE, @DESCRIPCION, @RECOMENDACIONES, @GRAVEDAD, @ID_ESPECIALIDAD);"
                        comando.Parameters.AddWithValue("@NOMBRE", enfermedad.Nombre)
                        comando.Parameters.AddWithValue("@DESCRIPCION", enfermedad.Descripcion)
                        comando.Parameters.AddWithValue("@RECOMENDACIONES", enfermedad.Recomendaciones)
                        comando.Parameters.AddWithValue("@GRAVEDAD", enfermedad.Gravedad)
                        comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", enfermedad.Especialidad.ID)
                        ConexionBD.EjecutarTransaccion(comando)

                        Dim idEnfermedadBD As Integer = ConexionBD.ObtenerUltimoIdInsertado
                        comando.CommandText = ""
                        comando.Parameters.Clear()
                        For i = 0 To enfermedad.Sintomas.Count - 1
                            comando.CommandText &= String.Format("INSERT INTO cuadro_sintomatico VALUES (@ID_SINTOMA{0}, @ID_ENFERMEDAD, @FRECUENCIA{0});", i)
                            comando.Parameters.AddWithValue("@ID_SINTOMA" & i, enfermedad.Sintomas(i).ID)
                            comando.Parameters.AddWithValue("@FRECUENCIA" & i, enfermedad.FrecuenciaSintoma(i).ToString.Replace(",", "."))
                        Next
                        comando.Parameters.AddWithValue("@ID_ENFERMEDAD", idEnfermedadBD)
                    End If


                Case TiposObjeto.Especialidad
                    Dim especialidad As Especialidad = objetoAInsertar

                    Dim estaDeshabilitado As Boolean = False
                    For Each r As DataRow In ConexionBD.EjecutarConsulta(New MySqlCommand("SELECT * FROM especialidades WHERE HABILITADO=FALSE;")).Rows
                        If r("NOMBRE") = especialidad.Nombre Then
                            estaDeshabilitado = True
                            Exit For
                        End If
                    Next

                    If estaDeshabilitado Then
                        comando.CommandText &= ("UPDATE especialidades SET HABILITADO=TRUE WHERE NOMBRE=@NOMBRE;")
                        comando.Parameters.AddWithValue("@NOMBRE", especialidad.Nombre)
                    Else
                        comando.CommandText &= ("INSERT INTO especialidades (NOMBRE) VALUES (@NOMBRE);")
                        comando.Parameters.AddWithValue("@NOMBRE", especialidad.Nombre)
                    End If


                Case TiposObjeto.Departamento
                    Dim departamento As Departamento = objetoAInsertar
                    comando.CommandText &= "INSERT INTO departamentos (NOMBRE) VALUES (@NOMBRE);"
                    comando.Parameters.AddWithValue("@NOMBRE", departamento.Nombre)


                Case TiposObjeto.Localidad
                    Dim localidad As Localidad = objetoAInsertar
                    comando.CommandText &= "INSERT INTO localidades (NOMBRE, ID_DEPARTAMENTO) VALUES (@NOMBRE, @ID_DEPARTAMENTO)"
                    comando.Parameters.AddWithValue("@NOMBRE", localidad.Nombre)
                    comando.Parameters.AddWithValue("@NOMBRE", localidad.Departamento.ID)



                Case TiposObjeto.Sintoma
                    Dim sintoma As Sintoma = objetoAInsertar

                    Dim estaDeshabilitado As Boolean = False
                    For Each r As DataRow In ConexionBD.EjecutarConsulta(New MySqlCommand("SELECT * FROM sintomas WHERE HABILITADO=FALSE;")).Rows
                        If r("NOMBRE") = sintoma.Nombre Then
                            estaDeshabilitado = True
                            Exit For
                        End If
                    Next

                    If estaDeshabilitado Then
                        comando.CommandText &= "UPDATE sintomas SET HABILITADO=TRUE, DESCRIPCION=@DESCRIPCION, RECOMENDACIONES=@RECOMENDACIONES, URGENCIA=@URGENCIA WHERE NOMBRE=@NOMBRE;"
                        comando.Parameters.AddWithValue("@DESCRIPCION", sintoma.Descripcion)
                        comando.Parameters.AddWithValue("@RECOMENDACIONES", sintoma.Recomendaciones)
                        comando.Parameters.AddWithValue("@URGENCIA", sintoma.Urgencia)
                        comando.Parameters.AddWithValue("@NOMBRE", sintoma.Nombre)
                        ConexionBD.EjecutarTransaccion(comando)

                        Dim comandoBusquedaID As New MySqlCommand("SELECT ID FROM sintomas WHERE NOMBRE=@NOMBRE;")
                        comandoBusquedaID.Parameters.AddWithValue("@NOMBRE", sintoma.Nombre)
                        Dim idSintomaBD As Integer = ConexionBD.EjecutarConsulta(comandoBusquedaID).Rows(0)(0)
                        comando.CommandText = ""
                        comando.Parameters.Clear()
                        For i = 0 To sintoma.Enfermedades.Count - 1
                            comando.CommandText &= String.Format("INSERT INTO cuadro_sintomatico VALUES (@ID_SINTOMA, @ID_ENFERMEDAD{0}, @FRECUENCIA{0});", i)
                            comando.Parameters.AddWithValue("@ID_ENFERMEDAD" & i, sintoma.Enfermedades(i).Id)
                            comando.Parameters.AddWithValue("@FRECUENCIA" & i, sintoma.FrecuenciaEnfermedad(i).ToString.Replace(",", "."))
                        Next
                        comando.Parameters.AddWithValue("@ID_SINTOMA", idSintomaBD)

                    Else
                        comando.CommandText &= "INSERT INTO sintomas (NOMBRE, DESCRIPCION, RECOMENDACIONES, URGENCIA) VALUES (@NOMBRE, @DESCRIPCION, @RECOMENDACIONES, @URGENCIA);"
                        comando.Parameters.AddWithValue("@NOMBRE", sintoma.Nombre)
                        comando.Parameters.AddWithValue("@DESCRIPCION", sintoma.Descripcion)
                        comando.Parameters.AddWithValue("@RECOMENDACIONES", sintoma.Recomendaciones)
                        comando.Parameters.AddWithValue("@URGENCIA", sintoma.Urgencia)
                        ConexionBD.EjecutarTransaccion(comando)

                        Dim idSintomaBD As Integer = ConexionBD.ObtenerUltimoIdInsertado
                        comando.CommandText = ""
                        comando.Parameters.Clear()
                        For i = 0 To sintoma.Enfermedades.Count - 1
                            comando.CommandText &= String.Format("INSERT INTO cuadro_sintomatico VALUES (@ID_SINTOMA, @ID_ENFERMEDAD{0}, @FRECUENCIA{0});", i)
                            comando.Parameters.AddWithValue("@ID_ENFERMEDAD" & i, sintoma.Enfermedades(i).Id)
                            comando.Parameters.AddWithValue("@FRECUENCIA" & i, sintoma.FrecuenciaEnfermedad(i).ToString.Replace(",", "."))
                        Next
                        comando.Parameters.AddWithValue("@ID_SINTOMA", idSintomaBD)
                    End If


                Case TiposObjeto.Usuario
                    Dim usuario As Usuario = objetoAInsertar
                    comando.CommandText &= "INSERT INTO usuarios (CONTRASENIA, TIPO, ID_PERSONA) VALUES (@CONTRASENIA, @TIPO, @ID_PERSONA);"
                    comando.Parameters.AddWithValue("@CONTRASENIA", usuario.Contrasena)
                    comando.Parameters.AddWithValue("@TIPO", usuario.Tipo)
                    comando.Parameters.AddWithValue("@ID_PERSONA", usuario.Persona.ID)


                Case TiposObjeto.Mensaje
                    Dim mensaje As Mensaje = objetoAInsertar
                    If mensaje.Formato = FormatosMensajeAdmitidos.TXT Then
                        comando.CommandText &= "INSERT INTO mensajes (FECHAHORA, FORMATO, CONTENIDO, REMITENTE, ID_DIAGNOSTICO_PRIMARIO_CON_CONSULTA) VALUES (@FECHAHORA, @FORMATO, @CONTENIDO, @REMITENTE, @ID_DIAGNOSTICO_PRIMARIO_CON_CONSULTA);"
                        comando.Parameters.AddWithValue("@FECHAHORA", mensaje.FechaHora.ToString("yyyy-MM-dd HH:mm:ss"))
                        comando.Parameters.AddWithValue("@FORMATO", FormatosMensajeAdmitidos.TXT)
                        comando.Parameters.AddWithValue("@CONTENIDO", Encoding.UTF8.GetString(mensaje.Contenido))
                        comando.Parameters.AddWithValue("@REMITENTE", mensaje.Remitente)
                        comando.Parameters.AddWithValue("@ID_DIAGNOSTICO_PRIMARIO_CON_CONSULTA", mensaje.DiagnosticoPrimarioConConsulta.ID)
                    Else
                        comando.CommandText &= "INSERT INTO mensajes (FECHAHORA, FORMATO, CONTENIDO, NOMBRE_ARCHIVO, REMITENTE, ID_DIAGNOSTICO_PRIMARIO_CON_CONSULTA) VALUES (@FECHAHORA, @FORMATO, @CONTENIDO, @NOMBRE_ARCHIVO, @REMITENTE, @ID_DIAGNOSTICO_PRIMARIO_CON_CONSULTA);"
                        comando.Parameters.AddWithValue("@FECHAHORA", mensaje.FechaHora.ToString("yyyy-MM-dd HH:mm:ss"))
                        comando.Parameters.AddWithValue("@FORMATO", mensaje.Formato)
                        comando.Parameters.AddWithValue("@CONTENIDO", mensaje.Contenido)
                        comando.Parameters.AddWithValue("@NOMBRE_ARCHIVO", mensaje.NombreArchivo)
                        comando.Parameters.AddWithValue("@REMITENTE", mensaje.Remitente)
                        comando.Parameters.AddWithValue("@ID_DIAGNOSTICO_PRIMARIO_CON_CONSULTA", mensaje.DiagnosticoPrimarioConConsulta.ID)
                    End If


                Case TiposObjeto.Administrativo
                    Dim administrativo As Administrativo = objetoAInsertar

                    Dim estaDeshabilitado As Boolean = False
                    Dim idAdministrativoBD As Integer = -1
                    Dim tablaAdministrativos As DataTable = ConexionBD.EjecutarConsulta(New MySqlCommand("SELECT * FROM ObtenerListadoAdministrativos WHERE `Habilitado administrativo`=FALSE"))
                    For Each filaAdministrativo As DataRow In tablaAdministrativos.Rows
                        If filaAdministrativo("CI administrativo") = administrativo.CI Then
                            estaDeshabilitado = True
                            idAdministrativoBD = filaAdministrativo("CI administrativo")
                        End If
                    Next

                    If estaDeshabilitado Then
                        comando.CommandText &= "UPDATE personas SET CI=@CI, NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, CORREO=@CORREO, ID_LOCALIDAD=@ID_LOCALIDAD, TIPO=@TIPO WHERE ID=@ID;"
                        comando.CommandText &= "UPDATE funcionarios SET HABILITADO=TRUE WHERE ID_PERSONA=@ID;"
                        comando.CommandText &= "UPDATE administrativos SET ES_ENCARGADO=@ES_ENCARGADO WHERE ID_FUNCIONARIO=@ID;"
                        comando.Parameters.AddWithValue("@CI", administrativo.CI)
                        comando.Parameters.AddWithValue("@NOMBRE", administrativo.Nombre)
                        comando.Parameters.AddWithValue("@APELLIDO", administrativo.Apellido)
                        comando.Parameters.AddWithValue("@CORREO", administrativo.Correo)
                        comando.Parameters.AddWithValue("@ID_LOCALIDAD", administrativo.Localidad.ID)
                        comando.Parameters.AddWithValue("@TIPO", administrativo.Tipo)
                        comando.Parameters.AddWithValue("@ES_ENCARGADO", administrativo.EsEncargado)
                        comando.Parameters.AddWithValue("@ID", administrativo.ID)

                    Else
                        comando.CommandText &= "INSERT INTO personas (CI, NOMBRE, APELLIDO, CORREO, ID_LOCALIDAD, TIPO) VALUES (@CI, @NOMBRE, @APELLIDO, @CORREO, @ID_LOCALIDAD, @TIPO);"
                        comando.Parameters.AddWithValue("@CI", administrativo.CI)
                        comando.Parameters.AddWithValue("@NOMBRE", administrativo.Nombre)
                        comando.Parameters.AddWithValue("@APELLIDO", administrativo.Apellido)
                        comando.Parameters.AddWithValue("@CORREO", administrativo.Correo)
                        comando.Parameters.AddWithValue("@ID_LOCALIDAD", administrativo.Localidad.ID)
                        comando.Parameters.AddWithValue("@TIPO", TiposPersona.Funcionario.ToString)
                        ConexionBD.EjecutarTransaccion(comando)

                        idAdministrativoBD = ConexionBD.ObtenerUltimoIdInsertado
                        comando.CommandText = ""
                        comando.Parameters.Clear()
                        comando.CommandText &= "INSERT INTO funcionarios (ID_PERSONA, TIPO) VALUES (@ID, @TIPO);"
                        comando.CommandText &= "INSERT INTO administrativos VALUES (@ID, @ES_ENCARGADO);"
                        comando.Parameters.AddWithValue("@ID", idAdministrativoBD)
                        comando.Parameters.AddWithValue("@TIPO", TiposFuncionario.Administrativo.ToString)
                        comando.Parameters.AddWithValue("@ES_ENCARGADO", administrativo.EsEncargado)
                    End If


                Case TiposObjeto.Paciente
                    Dim paciente As Paciente = objetoAInsertar
                    comando.CommandText &= "INSERT INTO personas (CI, NOMBRE, APELLIDO, CORREO, ID_LOCALIDAD, TIPO) VALUES (@CI, @NOMBRE, @APELLIDO, @CORREO, @ID_LOCALIDAD, @TIPO);"
                    comando.Parameters.AddWithValue("@CI", paciente.CI)
                    comando.Parameters.AddWithValue("@NOMBRE", paciente.Nombre)
                    comando.Parameters.AddWithValue("@APELLIDO", paciente.Apellido)
                    comando.Parameters.AddWithValue("@CORREO", paciente.Correo)
                    comando.Parameters.AddWithValue("@ID_LOCALIDAD", paciente.Localidad.ID)
                    comando.Parameters.AddWithValue("@TIPO", paciente.Tipo.ToString)
                    ConexionBD.EjecutarTransaccion(comando)

                    Dim idPacienteBD As Integer = ConexionBD.ObtenerUltimoIdInsertado
                    comando.Parameters.Clear()
                    comando.CommandText = "INSERT INTO pacientes VALUES (@ID, @TELEFONO_MOVIL, @TELEFONO_FIJO, @SEXO, @FECHA_NACIMIENTO, @FECHA_DEFUNCION, @CALLE, @NUMERO_PUERTA, @APARTAMENTO);"
                    comando.Parameters.AddWithValue("@ID", idPacienteBD)
                    comando.Parameters.AddWithValue("@TELEFONO_MOVIL", paciente.TelefonoMovil)
                    comando.Parameters.AddWithValue("@TELEFONO_FIJO", paciente.TelefonoFijo)
                    comando.Parameters.AddWithValue("@SEXO", paciente.Sexo.ToString)
                    comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", paciente.FechaNacimiento.ToString("yyyy-MM-dd HH:mm:ss"))
                    comando.Parameters.AddWithValue("@FECHA_DEFUNCION", paciente.FechaDefuncion.ToString("yyyy-MM-dd HH:mm:ss"))
                    comando.Parameters.AddWithValue("@CALLE", paciente.Calle)
                    comando.Parameters.AddWithValue("@NUMERO_PUERTA", paciente.NumeroPuerta)
                    comando.Parameters.AddWithValue("@APARTAMENTO", paciente.Apartamento)


                Case TiposObjeto.Medico
                    Dim medico As Medico = objetoAInsertar

                    Dim estaDeshabilitado As Boolean = False
                    Dim idMedicoBD As Integer = -1
                    Dim tablaMedicos As DataTable = ConexionBD.EjecutarConsulta(New MySqlCommand("SELECT * FROM ObtenerListadoMedicos WHERE `Habilitado medico`=FALSE"))
                    For Each filaMedico As DataRow In tablaMedicos.Rows
                        If filaMedico("CI medico") = medico.CI Then
                            estaDeshabilitado = True
                            idMedicoBD = filaMedico("ID medico")
                        End If
                    Next

                    If estaDeshabilitado Then
                        comando.CommandText &= "UPDATE personas SET CI=@CI, NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, CORREO=@CORREO, ID_LOCALIDAD=@ID_LOCALIDAD, TIPO=@TIPO WHERE ID=@ID_MEDICO;"
                        comando.CommandText &= "UPDATE funcionarios SET HABILITADO=TRUE WHERE ID_PERSONA=@ID_MEDICO;"
                        For i = 0 To medico.Especialidades.Count - 1
                            comando.CommandText &= String.Format("INSERT INTO especialidades_medicos VALUES (@ID_ESPECIALIDAD{0}, @ID_MEDICO);", i)
                            comando.Parameters.AddWithValue("@ID_ESPECIALIDAD" & i, medico.Especialidades(i).ID)
                        Next
                        comando.Parameters.AddWithValue("@CI", medico.CI)
                        comando.Parameters.AddWithValue("@NOMBRE", medico.Nombre)
                        comando.Parameters.AddWithValue("@APELLIDO", medico.Apellido)
                        comando.Parameters.AddWithValue("@CORREO", medico.Correo)
                        comando.Parameters.AddWithValue("@ID_LOCALIDAD", medico.Localidad.ID)
                        comando.Parameters.AddWithValue("@TIPO", medico.Tipo.ToString)
                        comando.Parameters.AddWithValue("@ID", idMedicoBD)

                    Else
                        comando.CommandText &= "INSERT INTO personas (CI, NOMBRE, APELLIDO, CORREO, ID_LOCALIDAD, TIPO) VALUES (@CI, @NOMBRE, @APELLIDO, @CORREO, @ID_LOCALIDAD, @TIPO);"
                        comando.Parameters.AddWithValue("@CI", medico.CI)
                        comando.Parameters.AddWithValue("@NOMBRE", medico.Nombre)
                        comando.Parameters.AddWithValue("@APELLIDO", medico.Apellido)
                        comando.Parameters.AddWithValue("@CORREO", medico.Correo)
                        comando.Parameters.AddWithValue("@ID_LOCALIDAD", medico.Localidad.ID)
                        comando.Parameters.AddWithValue("@TIPO", medico.Tipo.ToString)
                        ConexionBD.EjecutarTransaccion(comando)

                        idMedicoBD = ConexionBD.ObtenerUltimoIdInsertado
                        comando.Parameters.Clear()
                        comando.CommandText = "INSERT INTO funcionarios (ID_PERSONA, TIPO) VALUES (@ID_MEDICO, @TIPO);"
                        comando.CommandText &= "INSERT INTO medicos VALUES (@ID_MEDICO);"
                        For i = 0 To medico.Especialidades.Count - 1
                            comando.CommandText &= String.Format("INSERT INTO especialidades_medicos VALUES (@ID_ESPECIALIDAD{0}, @ID_MEDICO);", i)
                            comando.Parameters.AddWithValue("@ID_ESPECIALIDAD" & i, medico.Especialidades(i).ID)
                        Next
                        comando.Parameters.AddWithValue("@ID_MEDICO", idMedicoBD)
                        comando.Parameters.AddWithValue("@TIPO", TiposFuncionario.Medico.ToString)
                    End If


                Case TiposObjeto.DiagnosticoPrimarioConConsulta
                    Dim diagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta = objetoAInsertar
                    comando.CommandText &= "INSERT INTO diagnosticos_primarios_con_consulta VALUES (@ID_DIAGNOSTICO, @ID_MEDICO, @COMENTARIOS_ADICIONALES);"
                    comando.CommandText &= "UPDATE diagnosticos_primarios SET TIPO='Con_Consulta' WHERE ID=@ID_DIAGNOSTICO;"
                    comando.Parameters.AddWithValue("@ID_DIAGNOSTICO", diagnosticoPrimarioConConsulta.ID)
                    comando.Parameters.AddWithValue("@ID_MEDICO", DBNull.Value)
                    comando.Parameters.AddWithValue("@COMENTARIOS_ADICIONALES", diagnosticoPrimarioConConsulta.ComentariosAdicionales)
            End Select
        Catch ex As Exception
            ConexionBD.Conexion.Close()
            Throw ex
        End Try



        Try
            comando.CommandText &= "COMMIT;"
            ConexionBD.EjecutarTransaccion(comando)         ' Ejecuta el último comando de la transacción, agregando el commit correspondiente
        Catch ex As MySqlException
            ConexionBD.EjecutarTransaccion(New MySqlCommand("ROLLBACK;"))       ' Si hubo un error de MySQL, anula la transacción
            ConexionBD.Conexion.Close()
            Throw ex
        Finally
            If ConexionBD.Conexion.State = ConnectionState.Open Then            ' Cierra la conexión con la BD
                ConexionBD.Conexion.Close()
            End If
        End Try
    End Sub

    ' Elimina un objeto en las tablas correspondientes de acuerdo al parámetro "entidad" mediante sentencias SQL.
    ' Únicamente los pacientes son eliminados físicamente de la BD. El resto de objetos son conservados mediante un borrado
    ' lógico para preservar la integridad referencial de las tablas. Cuando se "elimina" uno de estos objetos, se realiza un UPDATE
    ' en la tabla correspondiente para distinguir el registro de aquellos que no han sido dados de baja.
    ' Cuando la operación requiere más de un comando, dichos comandos se encuentran encapsulados por BEGIN, COMMIT y ROLLBACK en un bloque Try/Catch.
    Public Sub EliminarObjeto(objetoAEliminar As Object, entidad As TiposObjeto)
        Dim comando As New MySqlCommand("BEGIN;")
        Try
            ConexionBD.Conexion.Open()
        Catch ex As MySqlException
            Throw New Exception("No se puede establecer la conexión con la base de datos.")
        End Try

        Select Case entidad
            Case TiposObjeto.Enfermedad
                Dim enfermedad As Enfermedad = objetoAEliminar
                comando.CommandText &= "UPDATE enfermedades SET HABILITADO=FALSE WHERE ID=@ID;"
                comando.CommandText &= "DELETE FROM cuadro_sintomatico WHERE ID_ENFERMEDAD=@ID;"
                comando.Parameters.AddWithValue("@ID", enfermedad.Id)

            Case TiposObjeto.Especialidad
                Dim especialidad As Especialidad = objetoAEliminar
                comando.CommandText &= "UPDATE especialidades SET HABILITADO=FALSE WHERE ID=@ID;"
                comando.Parameters.AddWithValue("@ID", especialidad.ID)

            Case TiposObjeto.Departamento
                Dim departamento As Departamento = objetoAEliminar
                comando.CommandText &= "DELETE FROM departamentos WHERE ID=@ID;"
                comando.Parameters.AddWithValue("@ID", departamento.ID)

            Case TiposObjeto.Localidad
                Dim localidad As Localidad = objetoAEliminar
                comando.CommandText &= "DELETE FROM localidades WHERE ID=@ID;"
                comando.Parameters.AddWithValue("@ID", localidad.ID)

            Case TiposObjeto.Sintoma
                Dim sintoma As Sintoma = objetoAEliminar
                comando.CommandText &= "UPDATE sintomas SET HABILITADO=FALSE WHERE ID=@ID;"
                comando.CommandText &= "DELETE FROM cuadro_sintomatico WHERE ID_SINTOMA=@ID;"
                comando.Parameters.AddWithValue("@ID", sintoma.ID)

            Case TiposObjeto.Usuario
                Dim usuario As Usuario = objetoAEliminar
                comando.CommandText &= "UPDATE usuarios SET HABILITADO=FALSE WHERE ID=@ID;"
                comando.Parameters.AddWithValue("@ID", usuario.ID)

            Case TiposObjeto.Administrativo
                Dim administrativo As Administrativo = objetoAEliminar
                comando.CommandText &= "UPDATE funcionarios SET HABILITADO=FALSE WHERE ID_PERSONA=@ID;"
                comando.Parameters.AddWithValue("@ID", administrativo.ID)

            Case TiposObjeto.Paciente
                Dim paciente As Paciente = objetoAEliminar
                comando.CommandText &= "DELETE FROM personas WHERE ID=@ID;"
                comando.Parameters.AddWithValue("@ID", paciente.ID)

            Case TiposObjeto.Medico
                Dim medico As Medico = objetoAEliminar
                comando.CommandText &= "UPDATE funcionarios SET HABILITADO=FALSE WHERE ID_PERSONA=@ID;"
                comando.Parameters.AddWithValue("@ID", medico.ID)
        End Select

        Try
            comando.CommandText &= "COMMIT;"
            ConexionBD.EjecutarTransaccion(comando)
        Catch ex As MySqlException
            ConexionBD.EjecutarTransaccion(New MySqlCommand("ROLLBACK;"))
            ConexionBD.Conexion.Close()

            Select Case ex.Number
                Case 1062
                    Select Case entidad
                        Case TiposObjeto.Departamento
                            Throw New Exception("No se puede eliminar un departamento en el que haya localidades registradas.")
                        Case TiposObjeto.Localidad
                            Throw New Exception("No se puede eliminar una localidad en la que haya personas registradas.")
                    End Select

                Case Else
                    Throw ex
            End Select
        Finally
            If ConexionBD.Conexion.State = ConnectionState.Open Then
                ConexionBD.Conexion.Close()
            End If
        End Try
    End Sub

    ' Modifica un objeto en las tablas correspondientes de acuerdo al parámetro "entidad" mediante sentencias SQL.
    ' Cuando la operación requiere más de un comando, dichos comandos se encuentran encapsulados por BEGIN, COMMIT y ROLLBACK en un bloque Try/Catch.
    Public Sub ModificarObjeto(objetoAModificar As Object, entidad As TiposObjeto)
        Dim comando As New MySqlCommand("BEGIN;")
        Try
            ConexionBD.Conexion.Open()
        Catch ex As MySqlException
            Throw New Exception("No se puede establecer la conexión con la base de datos.")
        End Try

        Select Case entidad
            Case TiposObjeto.Enfermedad
                Dim enfermedad As Enfermedad = objetoAModificar
                comando.CommandText &= "UPDATE enfermedades SET NOMBRE=@NOMBRE, DESCRIPCION=@DESCRIPCION, RECOMENDACIONES=@RECOMENDACIONES, GRAVEDAD=@GRAVEDAD, ID_ESPECIALIDAD=@ID_ESPECIALIDAD WHERE ID=@ID_ENFERMEDAD;"
                comando.CommandText &= "DELETE FROM cuadro_sintomatico WHERE ID_ENFERMEDAD=@ID_ENFERMEDAD;"
                For i = 0 To enfermedad.Sintomas.Count - 1
                    comando.CommandText &= String.Format("INSERT INTO cuadro_sintomatico VALUES (@ID_SINTOMA{0}, @ID_ENFERMEDAD, @FRECUENCIA{0});", i)
                    comando.Parameters.AddWithValue("@ID_SINTOMA" & i, enfermedad.Sintomas(i).ID)
                    comando.Parameters.AddWithValue("@FRECUENCIA" & i, enfermedad.FrecuenciaSintoma(i).ToString.Replace(",", "."))
                Next
                comando.Parameters.AddWithValue("@NOMBRE", enfermedad.Nombre)
                comando.Parameters.AddWithValue("@DESCRIPCION", enfermedad.Descripcion)
                comando.Parameters.AddWithValue("@RECOMENDACIONES", enfermedad.Recomendaciones)
                comando.Parameters.AddWithValue("@GRAVEDAD", enfermedad.Gravedad)
                comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", enfermedad.Especialidad.ID)
                comando.Parameters.AddWithValue("@ID_ENFERMEDAD", enfermedad.Id)

            Case TiposObjeto.Especialidad
                Dim especialidad As Especialidad = objetoAModificar
                comando.CommandText &= "UPDATE especialidades SET NOMBRE=@NOMBRE WHERE ID=@ID;"
                comando.Parameters.AddWithValue("@NOMBRE", especialidad.Nombre)
                comando.Parameters.AddWithValue("@ID", especialidad.ID)

            Case TiposObjeto.Departamento
                Dim departamento As Departamento = objetoAModificar
                comando.CommandText &= "UPDATE departamentos SET NOMBRE=@NOMBRE WHERE ID=@ID;"
                comando.Parameters.AddWithValue("@NOMBRE", departamento.Nombre)
                comando.Parameters.AddWithValue("@ID", departamento.ID)

            Case TiposObjeto.Localidad
                Dim localidad As Localidad = objetoAModificar
                comando.CommandText &= "UPDATE localidades SET NOMBRE=@NOMBRE, ID_DEPARTAMENTO=@ID_DEPARTAMENTO WHERE ID=@ID;"
                comando.Parameters.AddWithValue("@NOMBRE", localidad.Nombre)
                comando.Parameters.AddWithValue("@ID_DEPARTAMENTO", localidad.Departamento.ID)
                comando.Parameters.AddWithValue("@ID", localidad.ID)

            Case TiposObjeto.Sintoma
                Dim sintoma As Sintoma = objetoAModificar
                comando.CommandText &= "UPDATE sintomas SET NOMBRE=@NOMBRE, DESCRIPCION=@DESCRIPCION, RECOMENDACIONES=@RECOMENDACIONES, URGENCIA=@URGENCIA WHERE ID=@ID_SINTOMA;"
                comando.CommandText &= "DELETE FROM cuadro_sintomatico WHERE ID_SINTOMA=@ID_SINTOMA;"
                For i = 0 To sintoma.Enfermedades.Count - 1
                    comando.CommandText &= String.Format("INSERT INTO cuadro_sintomatico VALUES (@ID_SINTOMA, @ID_ENFERMEDAD{0}, @FRECUENCIA{0});", i)
                    comando.Parameters.AddWithValue("@ID_ENFERMEDAD" & i, sintoma.Enfermedades(i).Id)
                    comando.Parameters.AddWithValue("@FRECUENCIA" & i, sintoma.FrecuenciaEnfermedad(i).ToString.Replace(",", "."))
                Next
                comando.Parameters.AddWithValue("@NOMBRE", sintoma.Nombre)
                comando.Parameters.AddWithValue("@DESCRIPCION", sintoma.Descripcion)
                comando.Parameters.AddWithValue("@RECOMENDACIONES", sintoma.Recomendaciones)
                comando.Parameters.AddWithValue("@URGENCIA", sintoma.Urgencia)
                comando.Parameters.AddWithValue("@ID_SINTOMA", sintoma.ID)

            Case TiposObjeto.Administrativo
                Dim administrativo As Administrativo = objetoAModificar
                comando.CommandText &= "UPDATE personas SET CI=@CI, NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, CORREO=@CORREO, ID_LOCALIDAD=@ID_LOCALIDAD, TIPO=@TIPO WHERE ID=@ID;"
                comando.CommandText &= "UPDATE administrativos SET ES_ENCARGADO=@ES_ENCARGADO WHERE ID_FUNCIONARIO=@ID;"
                comando.Parameters.AddWithValue("@CI", administrativo.CI)
                comando.Parameters.AddWithValue("@NOMBRE", administrativo.Nombre)
                comando.Parameters.AddWithValue("@APELLIDO", administrativo.Apellido)
                comando.Parameters.AddWithValue("@CORREO", administrativo.Correo)
                comando.Parameters.AddWithValue("@ID_LOCALIDAD", administrativo.Localidad.ID)
                comando.Parameters.AddWithValue("@TIPO", administrativo.Tipo.ToString)
                comando.Parameters.AddWithValue("@ID", administrativo.ID)
                comando.Parameters.AddWithValue("@ES_ENCARGADO", administrativo.EsEncargado)

            Case TiposObjeto.Paciente
                Dim paciente As Paciente = objetoAModificar
                comando.CommandText &= "UPDATE personas SET CI=@CI, NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, CORREO=@CORREO, ID_LOCALIDAD=@ID_LOCALIDAD WHERE ID=@ID;"
                comando.CommandText &= "UPDATE pacientes SET TELEFONOMOVIL=@TELEFONOMOVIL, TELEFONOFIJO=@TELEFONOFIJO, SEXO=@SEXO, FECHANACIMIENTO=@FECHANACIMIENTO, FECHADEFUNCION=@FECHADEFUNCION, CALLE=@CALLE, NUMEROPUERTA=@NUMEROPUERTA, APARTAMENTO=@APARTAMENTO WHERE ID_PERSONA=@ID;"
                comando.Parameters.AddWithValue("@CI", paciente.CI)
                comando.Parameters.AddWithValue("@NOMBRE", paciente.Nombre)
                comando.Parameters.AddWithValue("@APELLIDO", paciente.Apellido)
                comando.Parameters.AddWithValue("@CORREO", paciente.Correo)
                comando.Parameters.AddWithValue("@ID_LOCALIDAD", paciente.Localidad.ID)
                comando.Parameters.AddWithValue("@ID", paciente.ID)
                comando.Parameters.AddWithValue("@TELEFONOMOVIL", paciente.TelefonoMovil)
                comando.Parameters.AddWithValue("@TELEFONOFIJO", paciente.TelefonoFijo)
                comando.Parameters.AddWithValue("@SEXO", paciente.Sexo.ToString)
                comando.Parameters.AddWithValue("@FECHANACIMIENTO", paciente.FechaNacimiento.ToString("yyyy-MM-dd HH:mm:ss"))
                If paciente.FechaDefuncion <> Date.MinValue Then
                    comando.Parameters.AddWithValue("@FECHADEFUNCION", paciente.FechaDefuncion.ToString("yyyy-MM-dd HH:mm:ss"))
                Else
                    comando.Parameters.AddWithValue("@FECHADEFUNCION", DBNull.Value)
                End If
                comando.Parameters.AddWithValue("@CALLE", paciente.Calle)
                comando.Parameters.AddWithValue("@NUMEROPUERTA", paciente.NumeroPuerta)
                comando.Parameters.AddWithValue("@APARTAMENTO", paciente.Apartamento)

            Case TiposObjeto.Medico
                Dim medico As Medico = objetoAModificar
                comando.CommandText &= "UPDATE personas SET CI=@CI, NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, CORREO=@CORREO, ID_LOCALIDAD=@ID_LOCALIDAD, TIPO=@TIPO WHERE ID=@ID_MEDICO;"
                comando.CommandText &= "DELETE FROM especialidades_medicos WHERE ID_MEDICO=@ID_MEDICO;"
                For i = 0 To medico.Especialidades.Count - 1
                    comando.CommandText &= String.Format("INSERT INTO especialidades_medicos VALUES (@ID_ESPECIALIDAD{0}, @ID_MEDICO);", i)
                    comando.Parameters.AddWithValue("@ID_ESPECIALIDAD" & i, medico.Especialidades(i).ID)
                Next
                comando.Parameters.AddWithValue("@CI", medico.CI)
                comando.Parameters.AddWithValue("@NOMBRE", medico.Nombre)
                comando.Parameters.AddWithValue("@APELLIDO", medico.Apellido)
                comando.Parameters.AddWithValue("@CORREO", medico.Correo)
                comando.Parameters.AddWithValue("@ID_LOCALIDAD", medico.Localidad.ID)
                comando.Parameters.AddWithValue("@TIPO", medico.Tipo.ToString)
                comando.Parameters.AddWithValue("@ID_MEDICO", medico.ID)
        End Select

        Try
            comando.CommandText &= "COMMIT;"
            ConexionBD.EjecutarTransaccion(comando)
        Catch ex As MySqlException
            ConexionBD.EjecutarTransaccion(New MySqlCommand("ROLLBACK;"))
            ConexionBD.Conexion.Close()
            Throw ex
        Finally
            If ConexionBD.Conexion.State = ConnectionState.Open Then
                ConexionBD.Conexion.Close()
            End If
        End Try
    End Sub

    Public Function TienePersonaRegistrada(ci As String, tipo As TiposUsuario) As Boolean
        Dim comando As MySqlCommand
        Select Case tipo
            Case TiposUsuario.Administrativo
                comando = New MySqlCommand("SELECT COUNT(*) FROM ObtenerAdministrativos WHERE `CI Persona`=@CI")
            Case TiposUsuario.Medico
                comando = New MySqlCommand("SELECT COUNT(*) FROM ObtenerMedicos WHERE `CI Persona`=@CI")
            Case TiposUsuario.Paciente
                comando = New MySqlCommand("SELECT COUNT(*) FROM ObtenerPacientes WHERE `CI Persona`=@CI")
            Case Else
                Throw New Exception("No se especificó un tipo de usuario válido.")
        End Select

        comando.Parameters.AddWithValue("@CI", ci)
        Dim datos As DataTable = ConexionBD.EjecutarConsulta(comando)
        Dim cantidadPersonas As Integer = datos.Rows(0)(0)
        Return cantidadPersonas = 1
    End Function

    Public Function ObtenerMedicoPorCI(ci As String) As Medico
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerMedicos WHERE `CI Persona`=@CI;")
        comando.Parameters.AddWithValue("@CI", ci)
        Dim tablaMedico As DataTable = ConexionBD.EjecutarConsulta(comando)
        Dim filaMedico As DataRow = tablaMedico.Rows(0)

        Dim idMedico As Integer = filaMedico("ID Persona")
        Dim ciMedico As String = filaMedico("CI Persona")
        Dim nombreMedico As String = filaMedico("Nombre persona")
        Dim apellidoMedico As String = filaMedico("Apellido persona")
        Dim correoMedico As String = filaMedico("Correo persona")
        Dim idLocalidad As String = filaMedico("ID localidad")
        Dim nombreLocalidad As String = filaMedico("Nombre localidad")
        Dim idDepartamento As String = filaMedico("ID departamento")
        Dim nombreDepartamento As String = filaMedico("Nombre departamento")

        Dim departamentoLocalidad As New Departamento(idDepartamento, nombreDepartamento)
        Dim localidadMedico As New Localidad(idLocalidad, nombreLocalidad, departamentoLocalidad)

        comando = New MySqlCommand("SELECT * FROM ObtenerEspecialidadesPorMedico WHERE `ID medico`=@ID_MEDICO")
        comando.Parameters.AddWithValue("@ID_MEDICO", idMedico)
        Dim tablaEspecialidadesAsociadas As DataTable = ConexionBD.EjecutarConsulta(comando)
        Dim filasEspecialidades As DataRowCollection = tablaEspecialidadesAsociadas.Rows

        Dim especialidadesMedico As New List(Of Especialidad)
        For i = 0 To filasEspecialidades.Count - 1
            Dim idEspecialidad As String = filasEspecialidades(i)("ID especialidad")
            Dim nombreEspecialidad As String = filasEspecialidades(i)("Nombre especialidad")
            especialidadesMedico.Add(New Especialidad(idEspecialidad, nombreEspecialidad, Nothing, True))
        Next

        Return New Medico(idMedico, ciMedico, nombreMedico, apellidoMedico, correoMedico, localidadMedico, especialidadesMedico, True)
    End Function

    Public Function ObtenerPacientePorCI(ci As String) As Paciente
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerPacientes WHERE `CI Persona`=@CI;")
        comando.Parameters.AddWithValue("@CI", ci)
        Dim datos As DataTable = ConexionBD.EjecutarConsulta(comando)
        Dim filas As DataRowCollection = datos.Rows

        Dim idPaciente As Integer = filas(0)("ID Persona")
        Dim ciPaciente As String = filas(0)("CI Persona")
        Dim nombrePaciente As String = filas(0)("Nombre persona")
        Dim apellidoPaciente As String = filas(0)("Apellido persona")
        Dim correoPaciente As String = filas(0)("Correo persona")
        Dim telefonoMovilPaciente As String = filas(0)("Telefonomovil paciente")
        Dim telefonoFijoPaciente As String = filas(0)("Telefonofijo paciente")
        Dim sexoPaciente As TiposSexo = [Enum].Parse(GetType(TiposSexo), filas(0)("Sexo paciente"))
        Dim fechaNacimientoPaciente As Date = CType(filas(0)("Fecha nacimiento paciente"), MySqlDateTime).Value
        Dim fechaDefuncionPaciente As Date = If(TypeOf filas(0)("Fecha defuncion paciente") IsNot DBNull, CType(filas(0)("Fecha defuncion paciente"), MySqlDateTime).Value, Nothing)
        Dim callePaciente As String = filas(0)("Calle paciente")
        Dim numeroPuertaPaciente As String = filas(0)("Numero puerta paciente")
        Dim apartamentoPaciente As String = If(TypeOf filas(0)("Apartamento paciente") IsNot DBNull, filas(0)("Apartamento paciente"), Nothing)
        Dim idLocalidad As Integer = filas(0)("ID localidad")
        Dim nombreLocalidad As String = filas(0)("Nombre localidad")
        Dim idDepartamento As Integer = filas(0)("ID departamento")
        Dim nombreDepartamento As String = filas(0)("Nombre departamento")

        Dim departamentoLocalidad As New Departamento(idDepartamento, nombreDepartamento)
        Dim localidadPaciente As New Localidad(idLocalidad, nombreLocalidad, departamentoLocalidad)
        Return New Paciente(idPaciente, ciPaciente, nombrePaciente, apellidoPaciente, correoPaciente, localidadPaciente, telefonoMovilPaciente,
                            telefonoFijoPaciente, sexoPaciente, fechaNacimientoPaciente, fechaDefuncionPaciente, callePaciente, numeroPuertaPaciente, apartamentoPaciente)
    End Function

    Public Function ObtenerAdministrativoPorCI(ci As String) As Administrativo
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerAdministrativos WHERE `CI Persona`=@CI;")
        comando.Parameters.AddWithValue("@CI", ci)
        Dim datos As DataTable = ConexionBD.EjecutarConsulta(comando)
        Dim filas As DataRowCollection = datos.Rows

        Dim idAdministrativo As Integer = filas(0)("ID Persona")
        Dim ciAdministrativo As String = filas(0)("CI Persona")
        Dim nombreAdministrativo As String = filas(0)("Nombre persona")
        Dim apellidoAdministrativo As String = filas(0)("Apellido persona")
        Dim correoAdministrativo As String = filas(0)("Correo persona")
        Dim esEncargadoAdministrativo As Boolean = filas(0)("Encargado administrativo")
        Dim idLocalidad As Integer = filas(0)("ID localidad")
        Dim nombreLocalidad As String = filas(0)("Nombre localidad")
        Dim idDepartamento As Integer = filas(0)("ID departamento")
        Dim nombreDepartamento As String = filas(0)("Nombre departamento")

        Dim departamentoLocalidad As New Departamento(idDepartamento, nombreDepartamento)
        Dim localidadAdministrativo As New Localidad(idLocalidad, nombreLocalidad, departamentoLocalidad)
        Return New Administrativo(idAdministrativo, ciAdministrativo, nombreAdministrativo, apellidoAdministrativo, correoAdministrativo,
                                  localidadAdministrativo, esEncargadoAdministrativo, True)
    End Function

    Public Function TieneUsuarioRegistrado(persona As Persona) As Boolean
        Dim comando As New MySqlCommand("SELECT COUNT(*) FROM ObtenerUsuario WHERE `ID persona`=@ID;")
        comando.Parameters.AddWithValue("@ID", persona.ID)
        Dim datos As DataTable = ConexionBD.EjecutarConsulta(comando)
        Dim cantidadUsuarios As Integer = datos.Rows(0)(0)
        Return cantidadUsuarios = 1
    End Function

    Public Function ObtenerUsuarioPorPersona(persona As Persona) As Usuario
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerUsuario WHERE `ID persona`=@ID_PERSONA;")
        comando.Parameters.AddWithValue("@ID_PERSONA", persona.ID)
        Dim datos As DataTable = ConexionBD.EjecutarConsulta(comando)
        Dim fila As DataRow = datos.Rows(0)
        Dim idUsuario As Integer = fila("ID usuario")
        Dim contrasenaUsuario As String = fila("Contrasena usuario")
        Return New Usuario(idUsuario, contrasenaUsuario, persona, True)
    End Function

    Public Function ObtenerDiagnosticosPrimariosPorPaciente(paciente As Paciente) As List(Of DiagnosticoPrimario)
        Dim ds As New DataSet
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerDatosDiagnosticos WHERE `ID paciente`=@ID_PACIENTE ORDER BY `Fecha hora diagnostico primario` DESC;")
        comando.Parameters.AddWithValue("@ID_PACIENTE", paciente.ID)
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Diagnosticos"))
        comando.CommandText = "SELECT * FROM ObtenerSintomasDeDiagnosticosPrimarios;"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "SintomasEvaluados"))
        comando.CommandText = "SELECT * FROM ObtenerEnfermedadesDeDiagnosticosPrimarios;"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "EnfermedadesDiagnosticadas"))

        Dim tablaDiagnosticos As DataTable = ds.Tables("Diagnosticos")
        Dim tablaSintomasEvaluados As DataTable = ds.Tables("SintomasEvaluados")
        Dim tablaEnfermedadesDiagnosticadas As DataTable = ds.Tables("EnfermedadesDiagnosticadas")

        Dim listaDiagnosticosPrimarios As New List(Of DiagnosticoPrimario)
        For i = 0 To tablaDiagnosticos.Rows.Count - 1
            Dim filaDiagnostico As DataRow = tablaDiagnosticos.Rows(i)
            Dim idDiagnostico As Integer = filaDiagnostico("ID diagnostico primario")
            Dim fechaHoraDiagnostico As Date = CType(filaDiagnostico("Fecha hora diagnostico primario"), MySqlDateTime).Value
            Dim tipoDiagnostico As TiposDiagnosticosPrimarios = [Enum].Parse(GetType(TiposDiagnosticosPrimarios), filaDiagnostico("Tipo diagnostico primario"))

            Dim sintomas As New List(Of Sintoma)
            For j = 0 To tablaSintomasEvaluados.Rows.Count - 1
                Dim filaSintoma As DataRow = tablaSintomasEvaluados.Rows(j)
                If filaSintoma("ID diagnostico primario") = idDiagnostico Then
                    Dim idSintoma As Integer = filaSintoma("ID Sintoma")
                    Dim nombreSintoma As String = filaSintoma("Nombre Sintoma")
                    Dim descripcionSintoma As String = filaSintoma("Descripcion Sintoma")
                    Dim recomendacionesSintoma As String = filaSintoma("Recomendaciones Sintoma")
                    Dim urgenciaSintoma As String = filaSintoma("Urgencia Sintoma")
                    Dim habilitadoSintoma As Boolean = filaSintoma("Habilitado Sintoma")
                    sintomas.Add(New Sintoma(idSintoma, nombreSintoma, descripcionSintoma, recomendacionesSintoma, urgenciaSintoma, Nothing, habilitadoSintoma))
                End If
            Next

            Dim enfermedades As New List(Of Enfermedad)
            Dim probabilidades As New List(Of Decimal)
            For j = 0 To tablaEnfermedadesDiagnosticadas.Rows.Count - 1
                Dim filaEnfermedad As DataRow = tablaEnfermedadesDiagnosticadas.Rows(j)
                If filaEnfermedad("ID diagnostico primario") = idDiagnostico Then
                    Dim idEnfermedad As Integer = filaEnfermedad("ID enfermedad")
                    Dim nombreEnfermedad As String = filaEnfermedad("Nombre enfermedad")
                    Dim descripcionEnfermedad As String = filaEnfermedad("Descripcion enfermedad")
                    Dim recomendacionesEnfermedad As String = filaEnfermedad("Recomendaciones enfermedad")
                    Dim gravedadEnfermedad As Integer = filaEnfermedad("Gravedad enfermedad")
                    Dim habilitadoEnfermedad As Boolean = filaEnfermedad("Habilitado enfermedad")
                    Dim probabilidadEnfermedad As Double = filaEnfermedad("Probabilidad enfermedad")

                    Dim idEspecialidad As Integer = filaEnfermedad("ID especialidad")
                    Dim nombreEspecialidad As String = filaEnfermedad("Nombre especialidad")
                    Dim habilitadoEspecialidad As Boolean = filaEnfermedad("Habilitado especialidad")
                    Dim especialidadEnfermedad As New Especialidad(idEspecialidad, nombreEspecialidad, Nothing, habilitadoEspecialidad)

                    enfermedades.Add(New Enfermedad(idEnfermedad, nombreEnfermedad, recomendacionesEnfermedad, gravedadEnfermedad, descripcionEnfermedad,
                                                         Nothing, especialidadEnfermedad, habilitadoEnfermedad))
                    probabilidades.Add(probabilidadEnfermedad)
                End If
            Next
            Dim enfermedadesDiagnosticadas As New EnfermedadesDiagnosticadas(enfermedades, probabilidades)

            If tipoDiagnostico = TiposDiagnosticosPrimarios.Sin_Consulta Then
                listaDiagnosticosPrimarios.Add(New DiagnosticoPrimario(idDiagnostico, paciente, sintomas, enfermedadesDiagnosticadas, fechaHoraDiagnostico,
                                                                       tipoDiagnostico))
            Else
                Dim comentariosDiagnostico As String = If(TypeOf filaDiagnostico("Comentarios consulta") IsNot DBNull, filaDiagnostico("Comentarios consulta"), Nothing)
                Dim medico As Medico
                If TypeOf filaDiagnostico("ID medico") IsNot DBNull Then
                    Dim idMedico As Integer = filaDiagnostico("ID medico")
                    Dim ciMedico As String = filaDiagnostico("CI medico")
                    Dim nombreMedico As String = filaDiagnostico("Nombre medico")
                    Dim apellidoMedico As String = filaDiagnostico("Apellido medico")
                    Dim correoMedico As String = filaDiagnostico("Correo medico")
                    Dim habilitadoMedico As Boolean = filaDiagnostico("Habilitado medico")
                    Dim idLocalidad As String = filaDiagnostico("ID localidad medico")
                    Dim nombreLocalidad As String = filaDiagnostico("Nombre localidad medico")
                    Dim idDepartamento As String = filaDiagnostico("ID departamento medico")
                    Dim nombreDepartamento As String = filaDiagnostico("Nombre departamento medico")

                    Dim departamentoLocalidad As New Departamento(idDepartamento, nombreDepartamento)
                    Dim localidadMedico As New Localidad(idLocalidad, nombreLocalidad, departamentoLocalidad)
                    medico = New Medico(idMedico, ciMedico, nombreMedico, apellidoMedico, correoMedico, localidadMedico, Nothing, habilitadoMedico)
                Else
                    medico = Nothing
                End If

                listaDiagnosticosPrimarios.Add(New DiagnosticoPrimarioConConsulta(idDiagnostico, paciente, sintomas, enfermedadesDiagnosticadas,
                                                                                  fechaHoraDiagnostico, medico, comentariosDiagnostico))
            End If
        Next

        Return listaDiagnosticosPrimarios
    End Function

    Public Function ObtenerUltimosDiagnosticosPrimariosConConsultaPorMedico(medico As Medico) As List(Of DiagnosticoPrimarioConConsulta)
        Dim ds As New DataSet
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerDatosConsultas WHERE `ID medico`=@ID_MEDICO ORDER BY `Fecha hora diagnostico primario` DESC;")
        comando.Parameters.AddWithValue("@ID_MEDICO", medico.ID)
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Diagnosticos"))
        comando.CommandText = "SELECT * FROM ObtenerSintomasDeDiagnosticosPrimarios;"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "SintomasEvaluados"))
        comando.CommandText = "SELECT * FROM ObtenerEnfermedadesDeDiagnosticosPrimarios;"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "EnfermedadesDiagnosticadas"))

        Dim tablaDiagnosticos As DataTable = ds.Tables("Diagnosticos")
        Dim tablaSintomasEvaluados As DataTable = ds.Tables("SintomasEvaluados")
        Dim tablaEnfermedadesDiagnosticadas As DataTable = ds.Tables("EnfermedadesDiagnosticadas")

        Dim listaConsultas As New List(Of DiagnosticoPrimarioConConsulta)

        For i = 0 To ds.Tables("Diagnosticos").Rows.Count - 1
            Dim fila As DataRow = ds.Tables("Diagnosticos").Rows(i)

            Dim idDiagnostico As Integer = fila("ID diagnostico primario")
            Dim fechaHoraDiagnostico As Date = CType(fila("Fecha hora diagnostico primario"), MySqlDateTime).Value
            Dim tipoDiagnostico As TiposDiagnosticosPrimarios = TiposDiagnosticosPrimarios.Con_Consulta
            Dim comentariosDiagnostico As String = If(TypeOf fila("Comentarios adicionales diagnostico primario con consulta") IsNot DBNull, fila("Comentarios adicionales diagnostico primario con consulta"), Nothing)

            Dim idPaciente As Integer = fila("ID paciente")
            Dim ciPaciente As String = fila("CI paciente")
            Dim nombrePaciente As String = fila("Nombre paciente")
            Dim apellidoPaciente As String = fila("Apellido paciente")
            Dim correoPaciente As String = fila("Correo paciente")
            Dim telefonoMovilPaciente As String = fila("Telefonomovil paciente")
            Dim telefonoFijoPaciente As String = fila("Telefonofijo paciente")
            Dim sexoPaciente As TiposSexo = [Enum].Parse(GetType(TiposSexo), fila("Sexo paciente"))
            Dim fechaNacimientoPaciente As Date = CType(fila("Fecha nacimiento paciente"), MySqlDateTime).Value
            Dim fechaDefuncionPaciente As Date = If(TypeOf fila("Fecha defuncion paciente") IsNot DBNull,
                                                    CType(fila("Fecha defuncion paciente"), MySqlDateTime).Value, Nothing)
            Dim callePaciente As String = fila("Calle paciente")
            Dim numeroPuertaPaciente As String = fila("Numero puerta paciente")
            Dim apartamentoPaciente As String = If(TypeOf fila("Apartamento paciente") IsNot DBNull, fila("Apartamento paciente"), Nothing)
            Dim idLocalidadPaciente As Integer = fila("ID localidad paciente")
            Dim nombreLocalidadPaciente As String = fila("Nombre localidad paciente")
            Dim idDepartamentoPaciente As Integer = fila("ID departamento paciente")
            Dim nombreDepartamentoPaciente As String = fila("Nombre departamento paciente")

            Dim departamentoPaciente As New Departamento(idDepartamentoPaciente, nombreDepartamentoPaciente)
            Dim localidadPaciente As New Localidad(idLocalidadPaciente, nombreLocalidadPaciente, departamentoPaciente)
            Dim paciente As New Paciente(idPaciente, ciPaciente, nombrePaciente, apellidoPaciente, correoPaciente, localidadPaciente, telefonoMovilPaciente,
                                         telefonoFijoPaciente, sexoPaciente, fechaNacimientoPaciente, fechaDefuncionPaciente, callePaciente,
                                         numeroPuertaPaciente, apartamentoPaciente)

            Dim sintomas As New List(Of Sintoma)
            For j = 0 To tablaSintomasEvaluados.Rows.Count - 1
                Dim filaSintoma As DataRow = tablaSintomasEvaluados.Rows(j)
                If filaSintoma("ID diagnostico primario") = idDiagnostico Then
                    Dim idSintoma As Integer = filaSintoma("ID Sintoma")
                    Dim nombreSintoma As String = filaSintoma("Nombre Sintoma")
                    Dim descripcionSintoma As String = filaSintoma("Descripcion Sintoma")
                    Dim recomendacionesSintoma As String = filaSintoma("Recomendaciones Sintoma")
                    Dim urgenciaSintoma As String = filaSintoma("Urgencia Sintoma")
                    Dim habilitadoSintoma As Boolean = filaSintoma("Habilitado Sintoma")
                    sintomas.Add(New Sintoma(idSintoma, nombreSintoma, descripcionSintoma, recomendacionesSintoma, urgenciaSintoma, Nothing, habilitadoSintoma))
                End If
            Next

            Dim enfermedades As New List(Of Enfermedad)
            Dim probabilidades As New List(Of Decimal)
            For j = 0 To tablaEnfermedadesDiagnosticadas.Rows.Count - 1
                Dim filaEnfermedad As DataRow = tablaEnfermedadesDiagnosticadas.Rows(j)
                If filaEnfermedad("ID diagnostico primario") = idDiagnostico Then
                    Dim idEnfermedad As Integer = filaEnfermedad("ID enfermedad")
                    Dim nombreEnfermedad As String = filaEnfermedad("Nombre enfermedad")
                    Dim descripcionEnfermedad As String = filaEnfermedad("Descripcion enfermedad")
                    Dim recomendacionesEnfermedad As String = filaEnfermedad("Recomendaciones enfermedad")
                    Dim gravedadEnfermedad As Integer = filaEnfermedad("Gravedad enfermedad")
                    Dim habilitadoEnfermedad As Boolean = filaEnfermedad("Habilitado enfermedad")
                    Dim probabilidadEnfermedad As Double = filaEnfermedad("Probabilidad enfermedad")

                    Dim idEspecialidad As Integer = filaEnfermedad("ID especialidad")
                    Dim nombreEspecialidad As String = filaEnfermedad("Nombre especialidad")
                    Dim habilitadoEspecialidad As Boolean = filaEnfermedad("Habilitado especialidad")
                    Dim especialidadEnfermedad As New Especialidad(idEspecialidad, nombreEspecialidad, Nothing, habilitadoEspecialidad)

                    enfermedades.Add(New Enfermedad(idEnfermedad, nombreEnfermedad, recomendacionesEnfermedad, gravedadEnfermedad, descripcionEnfermedad,
                                                         Nothing, especialidadEnfermedad, habilitadoEnfermedad))
                    probabilidades.Add(probabilidadEnfermedad)
                End If
            Next
            Dim enfermedadesDiagnosticadas As New EnfermedadesDiagnosticadas(enfermedades, probabilidades)

            listaConsultas.Add(New DiagnosticoPrimarioConConsulta(idDiagnostico, paciente, sintomas, enfermedadesDiagnosticadas, fechaHoraDiagnostico,
                                                                  medico, comentariosDiagnostico))
        Next

        Return listaConsultas
    End Function

    Public Function ObtenerUltimosMensajesPorDiagnosticoPrimarioConConsulta(diagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta, cantidadARetornar As Integer) As List(Of Mensaje)
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerUltimosMensajesConsulta WHERE `ID diagnostico`=@ID_DIAGNOSTICO AND `Formato mensaje`='TXT' LIMIT @CANTIDAD_MENSAJES;")
        comando.Parameters.AddWithValue("@ID_DIAGNOSTICO", diagnosticoPrimarioConConsulta.ID)
        comando.Parameters.AddWithValue("@CANTIDAD_MENSAJES", cantidadARetornar)
        Dim datos As DataTable = ConexionBD.EjecutarConsulta(comando)

        Dim listaMensajes As New List(Of Mensaje)

        For i = 0 To datos.Rows.Count - 1
            Dim fila As DataRow = datos.Rows(i)
            Dim idMensaje As Integer = fila("ID mensaje")
            Dim fechaHoraMensaje As Date = CType(fila("Fecha hora mensaje"), MySqlDateTime).Value
            Dim formatoMensaje As FormatosMensajeAdmitidos = [Enum].Parse(GetType(FormatosMensajeAdmitidos), fila("Formato mensaje"))
            Dim nombreArchivoMensaje As String = If(TypeOf fila("Nombre archivo") IsNot DBNull, fila("Nombre archivo"), Nothing)
            Dim contenidoMensaje() As Byte = fila("Contenido mensaje")
            Dim remitenteMensaje As TiposRemitente = [Enum].Parse(GetType(TiposRemitente), fila("Remitente mensaje"))
            listaMensajes.Add(New Mensaje(idMensaje, fechaHoraMensaje, formatoMensaje, contenidoMensaje, remitenteMensaje, nombreArchivoMensaje, diagnosticoPrimarioConConsulta))
        Next

        Return listaMensajes
    End Function

    Public Function ObtenerUltimosMetadatosArchivosPorDiagnosticoPrimarioConConsulta(diagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta, cantidadARetornar As Integer) As List(Of Mensaje)
        Dim comando As New MySqlCommand("SELECT `ID mensaje`, `Fecha hora mensaje`, `Formato mensaje`, `Nombre archivo`, `Remitente mensaje`, `ID diagnostico` FROM ObtenerUltimosMensajesConsulta WHERE `ID diagnostico`=@ID_DIAGNOSTICO AND `Formato mensaje`!='TXT' LIMIT @CANTIDAD_MENSAJES;")
        comando.Parameters.AddWithValue("@ID_DIAGNOSTICO", diagnosticoPrimarioConConsulta.ID)
        comando.Parameters.AddWithValue("@CANTIDAD_MENSAJES", cantidadARetornar)
        Dim datos As DataTable = ConexionBD.EjecutarConsulta(comando)

        Dim listaMensajes As New List(Of Mensaje)

        For i = 0 To datos.Rows.Count - 1
            Dim fila As DataRow = datos.Rows(i)
            Dim idMensaje As Integer = fila("ID mensaje")
            Dim fechaHoraMensaje As Date = CType(fila("Fecha hora mensaje"), MySqlDateTime).Value
            Dim formatoMensaje As FormatosMensajeAdmitidos = [Enum].Parse(GetType(FormatosMensajeAdmitidos), fila("Formato mensaje"))
            Dim nombreArchivoMensaje As String = If(TypeOf fila("Nombre archivo") IsNot DBNull, fila("Nombre archivo"), Nothing)
            Dim remitenteMensaje As TiposRemitente = [Enum].Parse(GetType(TiposRemitente), fila("Remitente mensaje"))
            listaMensajes.Add(New Mensaje(idMensaje, fechaHoraMensaje, formatoMensaje, Nothing, remitenteMensaje, nombreArchivoMensaje, diagnosticoPrimarioConConsulta))
        Next

        Return listaMensajes
    End Function

    Public Function ObtenerCantidadMensajesPorDiagnosticoPrimarioConConsulta(diagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta) As Integer
        Dim comando As New MySqlCommand("SELECT COUNT(*) FROM ObtenerUltimosMensajesConsulta WHERE `ID diagnostico`=@ID_DIAGNOSTICO AND `Formato mensaje`='TXT';")
        comando.Parameters.AddWithValue("@ID_DIAGNOSTICO", diagnosticoPrimarioConConsulta.ID)
        Dim cantidad As Integer = ConexionBD.EjecutarConsulta(comando).Rows(0)(0)
        Return cantidad
    End Function

    Public Function ObtenerCantidadArchivosPorDiagnosticoPrimarioConConsulta(diagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta) As Integer
        Dim comando As New MySqlCommand("SELECT COUNT(*) FROM ObtenerUltimosMensajesConsulta WHERE `ID diagnostico`=@ID_DIAGNOSTICO AND `Formato mensaje`!='TXT';")
        comando.Parameters.AddWithValue("@ID_DIAGNOSTICO", diagnosticoPrimarioConConsulta.ID)
        Dim cantidad As Integer = ConexionBD.EjecutarConsulta(comando).Rows(0)(0)
        Return cantidad
    End Function

    Public Function ObtenerCantidadDiagnosticosDiferencialesPorDiagnosticoPrimarioConConsulta(diagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta) As Integer
        Dim comando As New MySqlCommand("SELECT COUNT(*) FROM diagnosticos_diferenciales WHERE ID_DIAGNOSTICO_PRIMARIO_CON_CONSULTA=@ID_DIAGNOSTICO")
        comando.Parameters.AddWithValue("@ID_DIAGNOSTICO", diagnosticoPrimarioConConsulta.ID)
        Dim cantidad As Integer = ConexionBD.EjecutarConsulta(comando).Rows(0)(0)
        Return cantidad
    End Function

    Public Function ObtenerArchivoPorID(idArchivo As Integer) As Mensaje
        Dim comando As New MySqlCommand("SELECT * FROM mensajes WHERE ID=@ID;")
        comando.Parameters.AddWithValue("@ID", idArchivo)
        Dim fila As DataRow = ConexionBD.EjecutarConsulta(comando).Rows(0)

        Dim idMensaje As Integer = fila("ID")
        Dim fechaHoraMensaje As Date = CType(fila("FECHAHORA"), MySqlDateTime).Value
        Dim formatoMensaje As FormatosMensajeAdmitidos = [Enum].Parse(GetType(FormatosMensajeAdmitidos), fila("FORMATO"))
        Dim nombreArchivoMensaje As String = If(TypeOf fila("NOMBRE_ARCHIVO") IsNot DBNull, fila("NOMBRE_ARCHIVO"), Nothing)
        Dim contenidoMensaje() As Byte = fila("CONTENIDO")
        Dim remitenteMensaje As TiposRemitente = [Enum].Parse(GetType(TiposRemitente), fila("REMITENTE"))

        Return New Mensaje(idMensaje, fechaHoraMensaje, formatoMensaje, contenidoMensaje, remitenteMensaje, nombreArchivoMensaje, Nothing)
    End Function

    Public Function ObtenerDiagnosticosDiferencialesPorDiagnosticoPrimarioConConsulta(diagnosticoPrimarioConConsulta As DiagnosticoPrimarioConConsulta) As List(Of DiagnosticoDiferencial)
        Dim ds As New DataSet
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerDiagnosticosDiferencialesPorConsulta WHERE `ID diagnostico primario`=@ID_DIAGNOSTICO_PRIMARIO;")
        comando.Parameters.AddWithValue("@ID_DIAGNOSTICO_PRIMARIO", diagnosticoPrimarioConConsulta.ID)
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Diferenciales"))
        comando.CommandText = "SELECT * FROM ObtenerSintomasAsociados;"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "SintomasAsociados"))

        Dim diferenciales As DataTable = ds.Tables("Diferenciales")
        Dim sintomasAsociados As DataTable = ds.Tables("SintomasAsociados")

        Dim listaDiagnosticosDiferenciales As New List(Of DiagnosticoDiferencial)
        For i = 0 To diferenciales.Rows.Count - 1
            Dim filaDiferencial As DataRow = diferenciales.Rows(i)
            Dim idDiferencial As Integer = filaDiferencial("ID diagnostico diferencial")
            Dim conductaASeguirDiferencial As String = filaDiferencial("Conducta a seguir diagnostico diferencial")
            Dim fechaHoraDiferencial As Date = CType(filaDiferencial("Fecha hora diagnostico diferencial"), MySqlDateTime).Value
            Dim idEnfermedad As Integer = filaDiferencial("ID enfermedad")
            Dim nombreEnfermedad As String = filaDiferencial("Nombre enfermedad")
            Dim descripcionEnfermedad As String = filaDiferencial("Descripcion enfermedad")
            Dim recomendacionesEnfermedad As String = filaDiferencial("Recomendaciones enfermedad")
            Dim gravedadEnfermedad As Integer = filaDiferencial("Gravedad enfermedad")
            Dim habilitadoEnfermedad As Boolean = filaDiferencial("Habilitado enfermedad")
            Dim idEspecialidad As Integer = filaDiferencial("ID especialidad")
            Dim nombreEspecialidad As String = filaDiferencial("Nombre especialidad")
            Dim habilitadoEspecialidad As Boolean = filaDiferencial("Habilitado especialidad")
            Dim especialidadEnfermedad As New Especialidad(idEspecialidad, nombreEspecialidad, Nothing, habilitadoEspecialidad)

            Dim listaSintomas As New List(Of Sintoma)
            Dim listaFrecuencias As New List(Of Decimal)
            For j = 0 To sintomasAsociados.Rows.Count - 1
                Dim filaSintoma As DataRow = sintomasAsociados.Rows(j)
                If filaSintoma("ID enfermedad") = filaDiferencial("ID enfermedad") Then
                    Dim idSintoma As Integer = filaSintoma("ID Sintoma")
                    Dim nombreSintoma As String = filaSintoma("Nombre Sintoma")
                    Dim descripcionSintoma As String = filaSintoma("Descripcion Sintoma")
                    Dim recomendacionesSintoma As String = filaSintoma("Recomendaciones Sintoma")
                    Dim urgenciaSintoma As Integer = filaSintoma("Urgencia Sintoma")
                    Dim habilitadoSintoma As Boolean = filaSintoma("Habilitado Sintoma")
                    Dim frecuenciaSintoma As Decimal = filaSintoma("Frecuencia cuadro sintomatico")
                    listaSintomas.Add(New Sintoma(idSintoma, nombreSintoma, descripcionSintoma, recomendacionesSintoma, urgenciaSintoma, Nothing, habilitadoSintoma))
                    listaFrecuencias.Add(frecuenciaSintoma)
                End If
            Next
            Dim sintomasEnfermedad As New SintomasAsociados(listaSintomas, listaFrecuencias)
            Dim enfermedadDiferencial As New Enfermedad(idEnfermedad, nombreEnfermedad, recomendacionesEnfermedad, gravedadEnfermedad,
                                                        descripcionEnfermedad, sintomasEnfermedad, especialidadEnfermedad, habilitadoEnfermedad)

            listaDiagnosticosDiferenciales.Add(New DiagnosticoDiferencial(idDiferencial, Nothing, enfermedadDiferencial, conductaASeguirDiferencial,
                                                                          fechaHoraDiferencial))
        Next

        Return listaDiagnosticosDiferenciales
    End Function

    Public Function ObtenerConsultasSinAtender() As List(Of DiagnosticoPrimarioConConsulta)
        Dim ds As New DataSet
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerDatosConsultas WHERE `ID medico` IS NULL ORDER BY `Fecha hora diagnostico primario` DESC;")
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Diagnosticos"))
        comando.CommandText = "SELECT * FROM ObtenerSintomasDeDiagnosticosPrimarios;"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "SintomasEvaluados"))
        comando.CommandText = "SELECT * FROM ObtenerEnfermedadesDeDiagnosticosPrimarios;"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "EnfermedadesDiagnosticadas"))

        Dim tablaDiagnosticos As DataTable = ds.Tables("Diagnosticos")
        Dim tablaSintomasEvaluados As DataTable = ds.Tables("SintomasEvaluados")
        Dim tablaEnfermedadesDiagnosticadas As DataTable = ds.Tables("EnfermedadesDiagnosticadas")

        Dim listaConsultas As New List(Of DiagnosticoPrimarioConConsulta)

        For i = 0 To ds.Tables("Diagnosticos").Rows.Count - 1
            Dim fila As DataRow = ds.Tables("Diagnosticos").Rows(i)

            Dim idDiagnostico As Integer = fila("ID diagnostico primario")
            Dim fechaHoraDiagnostico As Date = CType(fila("Fecha hora diagnostico primario"), MySqlDateTime).Value
            Dim tipoDiagnostico As TiposDiagnosticosPrimarios = TiposDiagnosticosPrimarios.Con_Consulta
            Dim comentariosDiagnostico As String = If(TypeOf fila("Comentarios adicionales diagnostico primario con consulta") IsNot DBNull, fila("Comentarios adicionales diagnostico primario con consulta"), Nothing)

            Dim idPaciente As Integer = fila("ID paciente")
            Dim ciPaciente As String = fila("CI paciente")
            Dim nombrePaciente As String = fila("Nombre paciente")
            Dim apellidoPaciente As String = fila("Apellido paciente")
            Dim correoPaciente As String = fila("Correo paciente")
            Dim telefonoMovilPaciente As String = fila("Telefonomovil paciente")
            Dim telefonoFijoPaciente As String = fila("Telefonofijo paciente")
            Dim sexoPaciente As TiposSexo = [Enum].Parse(GetType(TiposSexo), fila("Sexo paciente"))
            Dim fechaNacimientoPaciente As Date = CType(fila("Fecha nacimiento paciente"), MySqlDateTime).Value
            Dim fechaDefuncionPaciente As Date = If(TypeOf fila("Fecha defuncion paciente") IsNot DBNull,
                                                    CType(fila("Fecha defuncion paciente"), MySqlDateTime).Value, Nothing)
            Dim callePaciente As String = fila("Calle paciente")
            Dim numeroPuertaPaciente As String = fila("Numero puerta paciente")
            Dim apartamentoPaciente As String = If(TypeOf fila("Apartamento paciente") IsNot DBNull, fila("Apartamento paciente"), Nothing)
            Dim idLocalidadPaciente As Integer = fila("ID localidad paciente")
            Dim nombreLocalidadPaciente As String = fila("Nombre localidad paciente")
            Dim idDepartamentoPaciente As Integer = fila("ID departamento paciente")
            Dim nombreDepartamentoPaciente As String = fila("Nombre departamento paciente")

            Dim departamentoPaciente As New Departamento(idDepartamentoPaciente, nombreDepartamentoPaciente)
            Dim localidadPaciente As New Localidad(idLocalidadPaciente, nombreLocalidadPaciente, departamentoPaciente)
            Dim paciente As New Paciente(idPaciente, ciPaciente, nombrePaciente, apellidoPaciente, correoPaciente, localidadPaciente, telefonoMovilPaciente,
                                         telefonoFijoPaciente, sexoPaciente, fechaNacimientoPaciente, fechaDefuncionPaciente, callePaciente,
                                         numeroPuertaPaciente, apartamentoPaciente)

            Dim sintomas As New List(Of Sintoma)
            For j = 0 To tablaSintomasEvaluados.Rows.Count - 1
                Dim filaSintoma As DataRow = tablaSintomasEvaluados.Rows(j)
                If filaSintoma("ID diagnostico primario") = idDiagnostico Then
                    Dim idSintoma As Integer = filaSintoma("ID Sintoma")
                    Dim nombreSintoma As String = filaSintoma("Nombre Sintoma")
                    Dim descripcionSintoma As String = filaSintoma("Descripcion Sintoma")
                    Dim recomendacionesSintoma As String = filaSintoma("Recomendaciones Sintoma")
                    Dim urgenciaSintoma As String = filaSintoma("Urgencia Sintoma")
                    Dim habilitadoSintoma As Boolean = filaSintoma("Habilitado Sintoma")
                    sintomas.Add(New Sintoma(idSintoma, nombreSintoma, descripcionSintoma, recomendacionesSintoma, urgenciaSintoma, Nothing, habilitadoSintoma))
                End If
            Next

            Dim enfermedades As New List(Of Enfermedad)
            Dim probabilidades As New List(Of Decimal)
            For j = 0 To tablaEnfermedadesDiagnosticadas.Rows.Count - 1
                Dim filaEnfermedad As DataRow = tablaEnfermedadesDiagnosticadas.Rows(j)
                If filaEnfermedad("ID diagnostico primario") = idDiagnostico Then
                    Dim idEnfermedad As Integer = filaEnfermedad("ID enfermedad")
                    Dim nombreEnfermedad As String = filaEnfermedad("Nombre enfermedad")
                    Dim descripcionEnfermedad As String = filaEnfermedad("Descripcion enfermedad")
                    Dim recomendacionesEnfermedad As String = filaEnfermedad("Recomendaciones enfermedad")
                    Dim gravedadEnfermedad As Integer = filaEnfermedad("Gravedad enfermedad")
                    Dim habilitadoEnfermedad As Boolean = filaEnfermedad("Habilitado enfermedad")
                    Dim probabilidadEnfermedad As Double = filaEnfermedad("Probabilidad enfermedad")

                    Dim idEspecialidad As Integer = filaEnfermedad("ID especialidad")
                    Dim nombreEspecialidad As String = filaEnfermedad("Nombre especialidad")
                    Dim habilitadoEspecialidad As Boolean = filaEnfermedad("Habilitado especialidad")
                    Dim especialidadEnfermedad As New Especialidad(idEspecialidad, nombreEspecialidad, Nothing, habilitadoEspecialidad)

                    enfermedades.Add(New Enfermedad(idEnfermedad, nombreEnfermedad, recomendacionesEnfermedad, gravedadEnfermedad, descripcionEnfermedad,
                                                         Nothing, especialidadEnfermedad, habilitadoEnfermedad))
                    probabilidades.Add(probabilidadEnfermedad)
                End If
            Next
            Dim enfermedadesDiagnosticadas As New EnfermedadesDiagnosticadas(enfermedades, probabilidades)

            listaConsultas.Add(New DiagnosticoPrimarioConConsulta(idDiagnostico, paciente, sintomas, enfermedadesDiagnosticadas, fechaHoraDiagnostico,
                                                                  Nothing, comentariosDiagnostico))
        Next

        Return listaConsultas
    End Function

    Public Sub AsignarIDMedicoAConsulta(medico As Medico, consulta As DiagnosticoPrimarioConConsulta)
        ConexionBD.Conexion.Open()
        Dim comando As New MySqlCommand("UPDATE diagnosticos_primarios_con_consulta SET ID_MEDICO=@ID_MEDICO WHERE ID_DIAGNOSTICO_PRIMARIO=@ID_DIAGNOSTICO;")
        comando.Parameters.AddWithValue("@ID_MEDICO", medico.ID)
        comando.Parameters.AddWithValue("@ID_DIAGNOSTICO", consulta.ID)
        ConexionBD.EjecutarTransaccion(comando)
        ConexionBD.Conexion.Close()
    End Sub

    Public Function ObtenerListadoSintomas() As List(Of Sintoma)
        Dim ds As New DataSet
        Dim comando As New MySqlCommand("SELECT * FROM sintomas WHERE HABILITADO=TRUE;")
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Sintomas"))
        comando.CommandText = "SELECT * FROM ObtenerEnfermedadesAsociadas"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "EnfermedadesAsociadas"))

        Dim tablaSintomas As DataTable = ds.Tables("Sintomas")
        Dim tablaEnfermedadesAsociadas As DataTable = ds.Tables("EnfermedadesAsociadas")

        Dim listadoSintomas As New List(Of Sintoma)

        For i = 0 To tablaSintomas.Rows.Count - 1
            Dim filaSintoma As DataRow = tablaSintomas.Rows(i)
            Dim idSintoma As Integer = filaSintoma("ID")
            Dim nombreSintoma As String = filaSintoma("NOMBRE")
            Dim descripcionSintoma As String = filaSintoma("DESCRIPCION")
            Dim recomendacionesSintoma As String = filaSintoma("RECOMENDACIONES")
            Dim urgenciaSintoma As Integer = filaSintoma("URGENCIA")

            Dim listaEnfermedades As New List(Of Enfermedad)
            Dim listaFrecuencias As New List(Of Decimal)
            For j = 0 To tablaEnfermedadesAsociadas.Rows.Count - 1
                Dim filaEnfermedad As DataRow = tablaEnfermedadesAsociadas.Rows(j)
                If filaEnfermedad("ID sintoma asociado") = filaSintoma("ID") Then
                    Dim idEnfermedad As Integer = filaEnfermedad("ID enfermedad")
                    Dim nombreEnfermedad As String = filaEnfermedad("Nombre enfermedad")
                    Dim descripcionEnfermedad As String = filaEnfermedad("Descripcion enfermedad")
                    Dim recomendacionesEnfermedad As String = filaEnfermedad("Recomendaciones enfermedad")
                    Dim gravedadEnfermedad As Integer = filaEnfermedad("Gravedad enfermedad")
                    Dim habilitadoEnfermedad As Boolean = filaEnfermedad("Habilitado enfermedad")
                    Dim frecuenciaEnfermedad As Decimal = filaEnfermedad("Frecuencia sintoma asociado")

                    Dim idEspecialidad As Integer = filaEnfermedad("ID especialidad")
                    Dim nombreEspecialidad As String = filaEnfermedad("Nombre especialidad")
                    Dim habilitadoEspecialidad As Boolean = filaEnfermedad("Habilitado especialidad")

                    Dim especialidadEnfermedad As New Especialidad(idEspecialidad, nombreEspecialidad, Nothing, habilitadoEspecialidad)

                    listaEnfermedades.Add(New Enfermedad(idEnfermedad, nombreEnfermedad, recomendacionesEnfermedad, gravedadEnfermedad, descripcionEnfermedad, Nothing, especialidadEnfermedad, habilitadoEnfermedad))
                    listaFrecuencias.Add(frecuenciaEnfermedad)
                End If
            Next

            Dim enfermedadesAsociadas As New EnfermedadesAsociadas(listaEnfermedades, listaFrecuencias)
            listadoSintomas.Add(New Sintoma(idSintoma, nombreSintoma, descripcionSintoma, recomendacionesSintoma, urgenciaSintoma, enfermedadesAsociadas, True))
        Next

        Return listadoSintomas
    End Function

    Public Function ObtenerListadoEnfermedades() As List(Of Enfermedad)
        Dim ds As New DataSet
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerListadoEnfermedades WHERE `Habilitado enfermedad`=TRUE;")
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Enfermedades"))
        comando.CommandText = "SELECT * FROM ObtenerSintomasAsociados"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "SintomasAsociados"))

        Dim tablaEnfermedades As DataTable = ds.Tables("Enfermedades")
        Dim tablaSintomasAsociados As DataTable = ds.Tables("SintomasAsociados")

        Dim listadoEnfermedades As New List(Of Enfermedad)

        For i = 0 To tablaEnfermedades.Rows.Count - 1
            Dim filaEnfermedad As DataRow = tablaEnfermedades.Rows(i)
            Dim idEnfermedad As Integer = filaEnfermedad("ID enfermedad")
            Dim nombreEnfermedad As String = filaEnfermedad("Nombre enfermedad")
            Dim descripcionEnfermedad As String = filaEnfermedad("Descripcion enfermedad")
            Dim recomendacionesEnfermedad As String = filaEnfermedad("Recomendaciones enfermedad")
            Dim gravedadEnfermedad As Integer = filaEnfermedad("Gravedad enfermedad")
            Dim habilitadoEnfermedad As Boolean = filaEnfermedad("Habilitado enfermedad")
            Dim idEspecialidad As Integer = filaEnfermedad("ID especialidad")
            Dim nombreEspecialidad As String = filaEnfermedad("Nombre especialidad")
            Dim habilitadoEspecialidad As Boolean = filaEnfermedad("Habilitado especialidad")
            Dim especialidadEnfermedad As New Especialidad(idEspecialidad, nombreEspecialidad, Nothing, habilitadoEspecialidad)

            Dim listaSintomas As New List(Of Sintoma)
            Dim listaFrecuencias As New List(Of Decimal)
            For j = 0 To tablaSintomasAsociados.Rows.Count - 1
                Dim filaSintoma As DataRow = tablaSintomasAsociados.Rows(j)
                If filaSintoma("ID enfermedad") = filaEnfermedad("ID enfermedad") Then
                    Dim idSintoma As Integer = filaSintoma("ID Sintoma")
                    Dim nombreSintoma As String = filaSintoma("Nombre Sintoma")
                    Dim descripcionSintoma As String = filaSintoma("Descripcion Sintoma")
                    Dim recomendacionesSintoma As String = filaSintoma("Recomendaciones Sintoma")
                    Dim urgenciaSintoma As Integer = filaSintoma("Urgencia Sintoma")
                    Dim habilitadoSintoma As Boolean = filaSintoma("Habilitado Sintoma")
                    Dim frecuenciaSintoma As Decimal = filaSintoma("Frecuencia cuadro sintomatico")
                    listaSintomas.Add(New Sintoma(idSintoma, nombreSintoma, descripcionSintoma, recomendacionesSintoma, urgenciaSintoma, Nothing, habilitadoSintoma))
                    listaFrecuencias.Add(frecuenciaSintoma)
                End If
            Next

            Dim sintomasEnfermedad As New SintomasAsociados(listaSintomas, listaFrecuencias)
            listadoEnfermedades.Add(New Enfermedad(idEnfermedad, nombreEnfermedad, recomendacionesEnfermedad, gravedadEnfermedad,
                                                   descripcionEnfermedad, sintomasEnfermedad, especialidadEnfermedad, habilitadoEnfermedad))
        Next

        Return listadoEnfermedades
    End Function

    Public Function ObtenerListadoEspecialidades() As List(Of Especialidad)
        Dim ds As New DataSet
        Dim comando As New MySqlCommand("SELECT * FROM especialidades WHERE HABILITADO=TRUE;")
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Especialidades"))
        comando.CommandText = "SELECT * FROM ObtenerMedicosPorEspecialidad WHERE `Habilitado funcionario medico`=TRUE;"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Medicos"))

        Dim tablaEspecialidades As DataTable = ds.Tables("Especialidades")
        Dim tablaMedicos As DataTable = ds.Tables("Medicos")

        ds.Relations.Add("MedicosEspecialidad", tablaEspecialidades.Columns("ID"), tablaMedicos.Columns("ID especialidad"))

        Dim listadoEspecialidades As New List(Of Especialidad)
        For i = 0 To tablaEspecialidades.Rows.Count - 1
            Dim filaEspecialidad As DataRow = tablaEspecialidades.Rows(i)
            Dim idEspecialidad As Integer = filaEspecialidad("ID")
            Dim nombreEspecialidad As String = filaEspecialidad("NOMBRE")

            Dim listaMedicos As New List(Of Medico)
            For Each filaMedico As DataRow In filaEspecialidad.GetChildRows("MedicosEspecialidad")
                Dim idMedico As Integer = filaMedico("ID medico")
                Dim ciMedico As String = filaMedico("CI medico")
                Dim nombreMedico As String = filaMedico("Nombre medico")
                Dim apellidoMedico As String = filaMedico("Apellido medico")
                Dim correoMedico As String = filaMedico("Correo medico")
                Dim idLocalidad As String = filaMedico("ID localidad medico")
                Dim nombreLocalidad As String = filaMedico("Nombre localidad medico")
                Dim idDepartamento As String = filaMedico("ID departamento medico")
                Dim nombreDepartamento As String = filaMedico("Nombre departamento medico")

                Dim departamentoLocalidad As New Departamento(idDepartamento, nombreDepartamento)
                Dim localidadMedico As New Localidad(idLocalidad, nombreLocalidad, departamentoLocalidad)
                listaMedicos.Add(New Medico(idMedico, ciMedico, nombreMedico, apellidoMedico, correoMedico, localidadMedico, Nothing, True))
            Next

            listadoEspecialidades.Add(New Especialidad(idEspecialidad, nombreEspecialidad, listaMedicos, True))
        Next

        Return listadoEspecialidades
    End Function

    Public Function ObtenerListadoDepartamentos() As List(Of Departamento)
        Dim ds As New DataSet
        Dim comando As New MySqlCommand("SELECT * FROM departamentos;")
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando))

        Dim tablaDepartamentos As DataTable = ds.Tables(0)

        Dim listadoDepartamentos As New List(Of Departamento)
        For i = 0 To tablaDepartamentos.Rows.Count - 1
            Dim filaDepartamento As DataRow = tablaDepartamentos.Rows(i)
            Dim idDepartamento As Integer = filaDepartamento("ID")
            Dim nombreDepartamento As String = filaDepartamento("NOMBRE")
            listadoDepartamentos.Add(New Departamento(idDepartamento, nombreDepartamento))
        Next

        Return listadoDepartamentos
    End Function

    Public Function ObtenerListadoLocalidades() As List(Of Localidad)
        Dim ds As New DataSet
        Dim comando As New MySqlCommand("SELECT * FROM localidades;")
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Localidades"))
        comando.CommandText = "SELECT * FROM departamentos;"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Departamentos"))

        Dim tablaLocalidades As DataTable = ds.Tables("Localidades")
        Dim tablaDepartamentos As DataTable = ds.Tables("Departamentos")

        ds.Relations.Add("DepartamentoLocalidades", tablaDepartamentos.Columns("ID"), tablaLocalidades.Columns("ID_DEPARTAMENTO"))

        Dim listadoLocalidades As New List(Of Localidad)

        For i = 0 To tablaLocalidades.Rows.Count - 1
            Dim filaLocalidad As DataRow = tablaLocalidades.Rows(i)
            Dim idLocalidad As Integer = filaLocalidad("ID")
            Dim nombreLocalidad As String = filaLocalidad("NOMBRE")

            Dim filaDepartamento As DataRow = filaLocalidad.GetParentRow("DepartamentoLocalidades")
            Dim idDepartamento As Integer = filaDepartamento("ID")
            Dim nombreDepartamento As String = filaDepartamento("NOMBRE")
            Dim departamentoLocalidad As New Departamento(idDepartamento, nombreDepartamento)

            listadoLocalidades.Add(New Localidad(idLocalidad, nombreLocalidad, departamentoLocalidad))
        Next

        Return listadoLocalidades
    End Function

    Public Function ObtenerListadoPacientes() As List(Of Paciente)
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerPacientes;")
        Dim datos As DataTable = ConexionBD.EjecutarConsulta(comando)

        Dim listaPacientes As New List(Of Paciente)
        For i = 0 To datos.Rows.Count - 1
            Dim fila As DataRow = datos.Rows(i)

            Dim idPaciente As Integer = fila("ID Persona")
            Dim ciPaciente As String = fila("CI Persona")
            Dim nombrePaciente As String = fila("Nombre persona")
            Dim apellidoPaciente As String = fila("Apellido persona")
            Dim correoPaciente As String = fila("Correo persona")
            Dim telefonoMovilPaciente As String = fila("Telefonomovil paciente")
            Dim telefonoFijoPaciente As String = fila("Telefonofijo paciente")
            Dim sexoPaciente As TiposSexo = [Enum].Parse(GetType(TiposSexo), fila("Sexo paciente"))
            Dim fechaNacimientoPaciente As Date = CType(fila("Fecha nacimiento paciente"), MySqlDateTime).Value
            Dim fechaDefuncionPaciente As Date = If(TypeOf fila("Fecha defuncion paciente") IsNot DBNull,
                                                    CType(fila("Fecha defuncion paciente"), MySqlDateTime).Value, Nothing)
            Dim callePaciente As String = fila("Calle paciente")
            Dim numeroPuertaPaciente As String = fila("Numero puerta paciente")
            Dim apartamentoPaciente As String = If(TypeOf fila("Apartamento paciente") IsNot DBNull, fila("Apartamento paciente"), Nothing)
            Dim idLocalidad As Integer = fila("ID localidad")
            Dim nombreLocalidad As String = fila("Nombre localidad")
            Dim idDepartamento As Integer = fila("ID departamento")
            Dim nombreDepartamento As String = fila("Nombre departamento")

            Dim departamentoLocalidad As New Departamento(idDepartamento, nombreDepartamento)
            Dim localidadPaciente As New Localidad(idLocalidad, nombreLocalidad, departamentoLocalidad)

            listaPacientes.Add(New Paciente(idPaciente, ciPaciente, nombrePaciente, apellidoPaciente, correoPaciente, localidadPaciente, telefonoMovilPaciente,
                                telefonoFijoPaciente, sexoPaciente, fechaNacimientoPaciente, fechaDefuncionPaciente, callePaciente, numeroPuertaPaciente,
                                apartamentoPaciente))
        Next
        Return listaPacientes
    End Function

    Public Function ObtenerListadoMedicos() As List(Of Medico)
        Dim ds As New DataSet
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerMedicos;")
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Medicos"))
        comando.CommandText = "SELECT * FROM ObtenerEspecialidadesPorMedico"
        ds.Tables.Add(ConexionBD.EjecutarConsulta(comando, "Especialidades"))

        Dim tablaMedicos As DataTable = ds.Tables("Medicos")
        Dim tablaEspecialidades As DataTable = ds.Tables("Especialidades")

        Dim listaMedicos As New List(Of Medico)
        For i = 0 To tablaMedicos.Rows.Count - 1
            Dim filaMedico As DataRow = tablaMedicos.Rows(i)

            Dim idMedico As Integer = filaMedico("ID Persona")
            Dim ciMedico As String = filaMedico("CI Persona")
            Dim nombreMedico As String = filaMedico("Nombre persona")
            Dim apellidoMedico As String = filaMedico("Apellido persona")
            Dim correoMedico As String = filaMedico("Correo persona")
            Dim idLocalidad As String = filaMedico("ID localidad")
            Dim nombreLocalidad As String = filaMedico("Nombre localidad")
            Dim idDepartamento As String = filaMedico("ID departamento")
            Dim nombreDepartamento As String = filaMedico("Nombre departamento")

            Dim departamentoLocalidad As New Departamento(idDepartamento, nombreDepartamento)
            Dim localidadMedico As New Localidad(idLocalidad, nombreLocalidad, departamentoLocalidad)

            Dim especialidadesMedico As New List(Of Especialidad)
            For j = 0 To tablaEspecialidades.Rows.Count - 1
                Dim filaEspecialidad As DataRow = tablaEspecialidades.Rows(j)
                If filaMedico("ID Persona") = filaEspecialidad("ID medico") Then
                    Dim idEspecialidad As String = filaEspecialidad("ID especialidad")
                    Dim nombreEspecialidad As String = filaEspecialidad("Nombre especialidad")
                    especialidadesMedico.Add(New Especialidad(idEspecialidad, nombreEspecialidad, Nothing, True))
                End If
            Next

            listaMedicos.Add(New Medico(idMedico, ciMedico, nombreMedico, apellidoMedico, correoMedico, localidadMedico, especialidadesMedico, True))
        Next
        Return listaMedicos
    End Function

    Public Function ObtenerListadoAdministrativos() As List(Of Administrativo)
        Dim comando As New MySqlCommand("SELECT * FROM ObtenerAdministrativos;")
        Dim datos As DataTable = ConexionBD.EjecutarConsulta(comando)
        Dim filas As DataRowCollection = datos.Rows

        Dim listaAdministrativos As New List(Of Administrativo)
        For i = 0 To datos.Rows.Count - 1
            Dim fila As DataRow = datos.Rows(i)

            Dim idAdministrativo As Integer = fila("ID Persona")
            Dim ciAdministrativo As String = fila("CI Persona")
            Dim nombreAdministrativo As String = fila("Nombre persona")
            Dim apellidoAdministrativo As String = fila("Apellido persona")
            Dim correoAdministrativo As String = fila("Correo persona")
            Dim esEncargadoAdministrativo As Boolean = fila("Encargado administrativo")
            Dim idLocalidad As Integer = fila("ID localidad")
            Dim nombreLocalidad As String = fila("Nombre localidad")
            Dim idDepartamento As Integer = fila("ID departamento")
            Dim nombreDepartamento As String = fila("Nombre departamento")

            Dim departamentoLocalidad As New Departamento(idDepartamento, nombreDepartamento)
            Dim localidadAdministrativo As New Localidad(idLocalidad, nombreLocalidad, departamentoLocalidad)



            listaAdministrativos.Add(New Administrativo(idAdministrativo, ciAdministrativo, nombreAdministrativo, apellidoAdministrativo, correoAdministrativo,
                                                        localidadAdministrativo, esEncargadoAdministrativo, True))
        Next
        Return listaAdministrativos
    End Function

    Public Sub InsertarEnfermedadesImportadas(lista As List(Of Enfermedad))
        Try
            ConexionBD.Conexion.Open()
            ConexionBD.EjecutarTransaccion(New MySqlCommand("BEGIN;"))

            For Each enfermedad As Enfermedad In lista
                Dim comando As New MySqlCommand("")

                Dim estaDeshabilitado As Boolean = False
                For Each r As DataRow In ConexionBD.EjecutarConsulta(New MySqlCommand("SELECT * FROM enfermedades WHERE HABILITADO=FALSE;")).Rows
                    If r("NOMBRE") = enfermedad.Nombre Then
                        estaDeshabilitado = True
                        Exit For
                    End If
                Next

                If estaDeshabilitado Then       ' Existe, y se deshabilitó
                    comando.CommandText &= "UPDATE enfermedades SET HABILITADO=TRUE, DESCRIPCION=@DESCRIPCION, RECOMENDACIONES=@RECOMENDACIONES, GRAVEDAD=@GRAVEDAD, ID_ESPECIALIDAD=@ID_ESPECIALIDAD WHERE NOMBRE=@NOMBRE"
                    comando.Parameters.AddWithValue("@DESCRIPCION", enfermedad.Descripcion)
                    comando.Parameters.AddWithValue("@RECOMENDACIONES", enfermedad.Recomendaciones)
                    comando.Parameters.AddWithValue("@GRAVEDAD", enfermedad.Gravedad)
                    comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", enfermedad.Especialidad.ID)
                    comando.Parameters.AddWithValue("@NOMBRE", enfermedad.Nombre)
                    ConexionBD.EjecutarTransaccion(comando)

                    Dim comandoBusquedaID As New MySqlCommand("SELECT ID FROM enfermedades WHERE NOMBRE=@NOMBRE;")
                    comandoBusquedaID.Parameters.AddWithValue("@NOMBRE", enfermedad.Nombre)
                    Dim idEnfermedadBD As Integer = ConexionBD.EjecutarConsulta(comandoBusquedaID).Rows(0)(0)
                    comando.CommandText = ""
                    comando.Parameters.Clear()
                    For i = 0 To enfermedad.Sintomas.Count - 1
                        comando.CommandText &= String.Format("INSERT INTO cuadro_sintomatico VALUES (@ID_SINTOMA{0}, @ID_ENFERMEDAD, @FRECUENCIA{0});", i)
                        comando.Parameters.AddWithValue("@ID_SINTOMA" & i, enfermedad.Sintomas(i).ID)
                        comando.Parameters.AddWithValue("@FRECUENCIA" & i, enfermedad.FrecuenciaSintoma(i).ToString.Replace(",", "."))
                    Next
                    comando.Parameters.AddWithValue("@ID_ENFERMEDAD", idEnfermedadBD)
                Else        ' Jamás existió
                    comando.CommandText &= "INSERT INTO enfermedades (NOMBRE, DESCRIPCION, RECOMENDACIONES, GRAVEDAD, ID_ESPECIALIDAD) VALUES (@NOMBRE, @DESCRIPCION, @RECOMENDACIONES, @GRAVEDAD, @ID_ESPECIALIDAD);"
                    comando.Parameters.AddWithValue("@NOMBRE", enfermedad.Nombre)
                    comando.Parameters.AddWithValue("@DESCRIPCION", enfermedad.Descripcion)
                    comando.Parameters.AddWithValue("@RECOMENDACIONES", enfermedad.Recomendaciones)
                    comando.Parameters.AddWithValue("@GRAVEDAD", enfermedad.Gravedad)
                    comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", enfermedad.Especialidad.ID)
                    ConexionBD.EjecutarTransaccion(comando)

                    Dim idEnfermedadBD As Integer = ConexionBD.ObtenerUltimoIdInsertado
                    comando.CommandText = ""
                    comando.Parameters.Clear()
                    For i = 0 To enfermedad.Sintomas.Count - 1
                        comando.CommandText &= String.Format("INSERT INTO cuadro_sintomatico VALUES (@ID_SINTOMA{0}, @ID_ENFERMEDAD, @FRECUENCIA{0});", i)
                        comando.Parameters.AddWithValue("@ID_SINTOMA" & i, enfermedad.Sintomas(i).ID)
                        comando.Parameters.AddWithValue("@FRECUENCIA" & i, enfermedad.FrecuenciaSintoma(i).ToString.Replace(",", "."))
                    Next
                    comando.Parameters.AddWithValue("@ID_ENFERMEDAD", idEnfermedadBD)
                End If

                ConexionBD.EjecutarTransaccion(comando)
            Next

            ConexionBD.EjecutarTransaccion(New MySqlCommand("COMMIT;"))
        Catch ex As Exception
            ConexionBD.EjecutarTransaccion(New MySqlCommand("ROLLBACK;"))
            Throw ex
        Finally
            If ConexionBD.Conexion.State = ConnectionState.Open Then
                ConexionBD.Conexion.Close()
            End If
        End Try
    End Sub

    Public Sub InsertarSintomasImportados(lista As List(Of Sintoma))
        Try
            ConexionBD.Conexion.Open()
            ConexionBD.EjecutarTransaccion(New MySqlCommand("BEGIN;"))

            For Each sintoma As Sintoma In lista
                Dim comando As New MySqlCommand("")

                Dim estaDeshabilitado As Boolean = False
                For Each r As DataRow In ConexionBD.EjecutarConsulta(New MySqlCommand("SELECT * FROM sintomas WHERE HABILITADO=FALSE;")).Rows
                    If r("NOMBRE") = sintoma.Nombre Then
                        estaDeshabilitado = True
                        Exit For
                    End If
                Next

                If estaDeshabilitado Then
                    comando.CommandText &= "UPDATE sintomas SET HABILITADO=TRUE, DESCRIPCION=@DESCRIPCION, RECOMENDACIONES=@RECOMENDACIONES, URGENCIA=@URGENCIA WHERE NOMBRE=@NOMBRE;"
                    comando.Parameters.AddWithValue("@DESCRIPCION", sintoma.Descripcion)
                    comando.Parameters.AddWithValue("@RECOMENDACIONES", sintoma.Recomendaciones)
                    comando.Parameters.AddWithValue("@URGENCIA", sintoma.Urgencia)
                    comando.Parameters.AddWithValue("@NOMBRE", sintoma.Nombre)
                    ConexionBD.EjecutarTransaccion(comando)

                    Dim comandoBusquedaID As New MySqlCommand("SELECT ID FROM sintomas WHERE NOMBRE=@NOMBRE;")
                    comandoBusquedaID.Parameters.AddWithValue("@NOMBRE", sintoma.Nombre)
                    Dim idSintomaBD As Integer = ConexionBD.EjecutarConsulta(comandoBusquedaID).Rows(0)(0)
                    comando.CommandText = ""
                    comando.Parameters.Clear()
                    For i = 0 To sintoma.Enfermedades.Count - 1
                        comando.CommandText &= String.Format("INSERT INTO cuadro_sintomatico VALUES (@ID_SINTOMA, @ID_ENFERMEDAD{0}, @FRECUENCIA{0});", i)
                        comando.Parameters.AddWithValue("@ID_ENFERMEDAD" & i, sintoma.Enfermedades(i).Id)
                        comando.Parameters.AddWithValue("@FRECUENCIA" & i, sintoma.FrecuenciaEnfermedad(i).ToString.Replace(",", "."))
                    Next
                    comando.Parameters.AddWithValue("@ID_SINTOMA", idSintomaBD)

                Else
                    comando.CommandText &= "INSERT INTO sintomas (NOMBRE, DESCRIPCION, RECOMENDACIONES, URGENCIA) VALUES (@NOMBRE, @DESCRIPCION, @RECOMENDACIONES, @URGENCIA);"
                    comando.Parameters.AddWithValue("@NOMBRE", sintoma.Nombre)
                    comando.Parameters.AddWithValue("@DESCRIPCION", sintoma.Descripcion)
                    comando.Parameters.AddWithValue("@RECOMENDACIONES", sintoma.Recomendaciones)
                    comando.Parameters.AddWithValue("@URGENCIA", sintoma.Urgencia)
                    ConexionBD.EjecutarTransaccion(comando)

                    Dim idSintomaBD As Integer = ConexionBD.ObtenerUltimoIdInsertado
                    comando.CommandText = ""
                    comando.Parameters.Clear()
                    For i = 0 To sintoma.Enfermedades.Count - 1
                        comando.CommandText &= String.Format("INSERT INTO cuadro_sintomatico VALUES (@ID_SINTOMA, @ID_ENFERMEDAD{0}, @FRECUENCIA{0});", i)
                        comando.Parameters.AddWithValue("@ID_ENFERMEDAD" & i, sintoma.Enfermedades(i).Id)
                        comando.Parameters.AddWithValue("@FRECUENCIA" & i, sintoma.FrecuenciaEnfermedad(i).ToString.Replace(",", "."))
                    Next
                    comando.Parameters.AddWithValue("@ID_SINTOMA", idSintomaBD)
                End If

                ConexionBD.EjecutarTransaccion(comando)
            Next

            ConexionBD.EjecutarTransaccion(New MySqlCommand("COMMIT;"))
        Catch ex As Exception
            ConexionBD.EjecutarTransaccion(New MySqlCommand("ROLLBACK;"))
            Throw ex
        Finally
            If ConexionBD.Conexion.State = ConnectionState.Open Then
                ConexionBD.Conexion.Close()
            End If
        End Try
    End Sub

    Public Function ObtenerCantidadPersonasEnLocalidad(l As Localidad) As Integer
        Dim comando As New MySqlCommand("SELECT COUNT(*) FROM personas WHERE ID_LOCALIDAD=@LOCALIDAD;")
        comando.Parameters.AddWithValue("@LOCALIDAD", l.ID)
        Dim cantidad As Integer = ConexionBD.EjecutarConsulta(comando).Rows(0)(0)
        Return cantidad
    End Function
End Module
