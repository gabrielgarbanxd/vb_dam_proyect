Namespace Entities

    Public Class DeletedUser
        Public Property Id As Integer
        Public Property Name As String
        Public Property Email As String
        Public Property RoleId As Integer
        Public Property CreatedAt As DateTime
        Public Property DeletedAt As DateTime

        Public Sub New()
        End Sub

        Public Sub New(id As Integer, name As String, email As String, roleId As Integer, createdAt As DateTime, deletedAt As DateTime)
            Me.Id = id
            Me.Name = name
            Me.Email = email
            Me.RoleId = roleId
            Me.CreatedAt = createdAt
            Me.DeletedAt = deletedAt
        End Sub

    End Class

End Namespace
