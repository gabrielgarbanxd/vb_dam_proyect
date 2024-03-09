Imports ProyectoVB.Entities

Namespace Repositories.Mappers
    Public Class UserMapper
        Implements IObjectMapper(Of User)

        Public Function Map(reader As IDataReader) As User Implements IObjectMapper(Of User).Map
            Dim id As Integer = reader.GetInt32(reader.GetOrdinal("id"))
            Dim name As String = reader.GetString(reader.GetOrdinal("name"))
            Dim password As String = reader.GetString(reader.GetOrdinal("password"))
            Dim email As String = reader.GetString(reader.GetOrdinal("email"))
            Dim payment As DateTime? = If(reader.IsDBNull(reader.GetOrdinal("payment")), Nothing, reader.GetDateTime(reader.GetOrdinal("payment")))
            Dim lastConnection As DateTime? = If(reader.IsDBNull(reader.GetOrdinal("lastConnection")), Nothing, reader.GetDateTime(reader.GetOrdinal("lastConnection")))
            Dim firstLogin As Boolean = reader.GetBoolean(reader.GetOrdinal("firstLogin"))
            Dim roleId As Integer = reader.GetInt32(reader.GetOrdinal("roleId"))
            Dim createdAt As DateTime = reader.GetDateTime(reader.GetOrdinal("createdAt"))

            Return New User(id, name, email, password, payment, lastConnection, firstLogin, roleId, createdAt)
        End Function
    End Class

End Namespace
