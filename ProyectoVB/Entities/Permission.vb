
Namespace Entities

    Public Class Permission
        Public Property Id As Integer
        Public Property Action As PermissionAction
        Public Property Resource As PermissionResource

        Public Sub New()
        End Sub

        Public Sub New(id As Integer, action As PermissionAction, resource As PermissionResource)
            Me.Id = id
            Me.Action = action
            Me.Resource = resource
        End Sub

    End Class

    Public Enum PermissionAction
        CREATE
        UPDATE
        READ
        DELETE
    End Enum

    Public Enum PermissionResource
        USERS
        ROLES
        PERMISSIONS
        DELETED_USERS
    End Enum


End Namespace


