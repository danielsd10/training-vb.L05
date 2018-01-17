Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class Contactos

    Private CadenaConexion As String

    Sub New()
        CadenaConexion = "Data Source=localhost;Initial Catalog=TrainingNET;Integrated Security=True"
    End Sub

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
                    lstPersonas.Add(objPersona)
                    reader.NextResult()
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

End Class
