Imports ProyectoVB.Entities

Namespace Repositories.Mappers

    Public Class PermissionMapper
        Implements IObjectMapper(Of Permission)

        Public Function Map(reader As IDataReader) As Permission Implements IObjectMapper(Of Permission).Map
            Dim id As Integer = reader.GetInt32(reader.GetOrdinal("id"))
            Dim action As PermissionAction = [Enum].Parse(GetType(PermissionAction), reader("action").ToString())
            Dim resource As PermissionResource = [Enum].Parse(GetType(PermissionResource), reader("resource").ToString())

            Return New Permission(id, action, resource)
        End Function
    End Class

End Namespace