Imports ProyectoVB.Entities

Namespace Repositories.Mappers

    Public Class DeletedUserMapper
        Implements IObjectMapper(Of DeletedUser)

        Public Function Map(reader As IDataReader) As DeletedUser Implements IObjectMapper(Of DeletedUser).Map
            Dim id As Integer = reader.GetInt32(reader.GetOrdinal("id"))
            Dim name As String = reader.GetString(reader.GetOrdinal("name"))
            Dim email As String = reader.GetString(reader.GetOrdinal("email"))
            Dim roleId As Integer = reader.GetInt32(reader.GetOrdinal("role_id"))
            Dim createdAt As DateTime = reader.GetDateTime(reader.GetOrdinal("created_at"))
            Dim deletedAt As DateTime = reader.GetDateTime(reader.GetOrdinal("deleted_at"))

            Return New DeletedUser(id, name, email, roleId, createdAt, deletedAt)
        End Function

    End Class

End Namespace
