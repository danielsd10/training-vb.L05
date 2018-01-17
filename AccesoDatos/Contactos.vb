Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class Contactos

    Private CadenaConexion As String

    Sub New()
        CadenaConexion = "Data Source=localhost;Initial Catalog=TrainingNET;Integrated Security=True"
    End Sub

    Public Function RegistrarPersona(objPersona As Persona) As Boolean
        Dim cnx As New SqlConnection
        Dim cmd As New SqlCommand
        Dim params(5) As SqlParameter

        Try
            cnx = New SqlConnection(CadenaConexion)
            cnx.Open()

            cmd = New SqlCommand()
            cmd.Connection = cnx
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "RegistrarPersona"

            params(0) = New SqlParameter("Nombre", SqlDbType.VarChar)
            params(0).Value = objPersona.Nombre
            params(1) = New SqlParameter("Apellido", SqlDbType.VarChar)
            params(1).Value = objPersona.Apellido
            params(2) = New SqlParameter("DNI", SqlDbType.VarChar)
            params(2).Value = objPersona.DNI
            params(3) = New SqlParameter("Direccion", SqlDbType.VarChar)
            params(3).Value = objPersona.Direccion
            params(4) = New SqlParameter("FechaNacimiento", SqlDbType.Date)
            params(4).Value = objPersona.FechaNacimiento.ToString("yyyy-MM-dd")
            params(5) = New SqlParameter("Id", SqlDbType.Int)
            params(5).Direction = ParameterDirection.Output
            cmd.Parameters.AddRange(params)

            cmd.ExecuteNonQuery()

            Return params(5).Value > 0

        Catch ex As SqlException
            Return False
        Catch ex As Exception
            Return False
        Finally
            cmd.Dispose()
            cnx.Dispose()
            cnx.Close()
        End Try
    End Function

    Public Function ListarPersonas(Optional strBuscar As String = "") As List(Of Persona)
        Dim cnx As New SqlConnection
        Dim cmd As New SqlCommand
        Dim param As SqlParameter

        Dim lstPersonas As New List(Of Persona)
        Dim objPersona As Persona

        Try
            cnx = New SqlConnection(CadenaConexion)
            cnx.Open()

            cmd = New SqlCommand()
            cmd.Connection = cnx
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "ListarPersonas"

            If strBuscar <> "" Then
                param = New SqlParameter("Buscar", SqlDbType.VarChar)
                param.Value = strBuscar
                cmd.Parameters.Add(param)
            End If

            Using reader As SqlDataReader = cmd.ExecuteReader
                While reader.Read
                    objPersona = New Persona
                    objPersona.Id = reader("id_contacto")
                    objPersona.Nombre = reader("nombre")
                    objPersona.Apellido = reader("apellido")
                    objPersona.DNI = reader("dni")
                    objPersona.Direccion = reader("direccion")
                    objPersona.FechaNacimiento = reader("fecha_nacimiento")
                    lstPersonas.Add(objPersona)
                End While
            End Using

        Catch ex As SqlException

        Catch ex As Exception

        Finally
            cmd.Dispose()
            cnx.Dispose()
            cnx.Close()
        End Try
        Return lstPersonas
    End Function

    Public Function EliminarContacto(Id As Integer) As Boolean
        Dim cnx As New SqlConnection
        Dim cmd As New SqlCommand
        Dim params(0) As SqlParameter

        Try
            cnx = New SqlConnection(CadenaConexion)
            cnx.Open()

            cmd = New SqlCommand()
            cmd.Connection = cnx
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "EliminarContacto"

            params(0) = New SqlParameter("Id", SqlDbType.VarChar)
            params(0).Value = Id
            cmd.Parameters.AddRange(params)

            cmd.ExecuteNonQuery()

            Return True

        Catch ex As SqlException
            Return False
        Catch ex As Exception
            Return False
        Finally
            cmd.Dispose()
            cnx.Dispose()
            cnx.Close()
        End Try
    End Function

End Class
