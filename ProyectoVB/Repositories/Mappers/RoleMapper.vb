Imports ProyectoVB.Entities

Namespace Repositories.Mappers
    Public Class RoleMapper
        Implements IObjectMapper(Of Role)

        Public Function Map(reader As IDataReader) As Role Implements IObjectMapper(Of Role).Map
            Dim id As Integer = reader.GetInt32(reader.GetOrdinal("id"))
            Dim name As String = reader.GetString(reader.GetOrdinal("name"))
            Dim description As String = reader.GetString(reader.GetOrdinal("description"))

            Return New Role(id, name, description)

        End Function
    End Class
End Namespace
