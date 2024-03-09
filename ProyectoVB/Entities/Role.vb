Namespace Entities
    Public Class Role
        Public Property Id As Integer
        Public Property Name As String
        Public Property Description As String
        Public Property Permissions As List(Of Permission)

        Public Sub New()
        End Sub

        Public Sub New(id As Integer, name As String, description As String, permissions As List(Of Permission))
            Me.Id = id
            Me.Name = name
            Me.Description = description
            Me.Permissions = permissions
        End Sub

        Public Sub New(id As Integer, name As String, description As String)
            Me.Id = id
            Me.Name = name
            Me.Description = description
        End Sub

        Public Function HasPermission(action As PermissionAction, resource As PermissionResource) As Boolean
            Return Permissions.Any(Function(p) p.Action = action AndAlso p.Resource = resource)
        End Function

    End Class

End Namespace