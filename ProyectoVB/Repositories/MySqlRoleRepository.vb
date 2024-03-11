Imports ProyectoVB.Entities
Imports ProyectoVB.Repositories.Mappers

Namespace Repositories

    Public Class MySqlRoleRepository
        Inherits MySqlRepositoryBase(Of Role)

        Public Sub New(mapper As RoleMapper)
            MyBase.New(mapper)
        End Sub

        Public Async Function GetAllAsync() As Task(Of IEnumerable(Of Role))

            Return Await ExecuteQueryAsync("GetAllRolesProcedure")

        End Function

        Public Async Function FindByIdAsync(id As Integer) As Task(Of Role)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_id", id}}

            Dim roles = Await ExecuteQueryAsync("FindRoleByIdProcedure", parameters)

            Return roles.FirstOrDefault()

        End Function

        Public Async Function SearchByNameAsync(name As String) As Task(Of IEnumerable(Of Role))

            Dim parameters As New Dictionary(Of String, Object) From {{"p_name", name}}

            Return Await ExecuteQueryAsync("SearchRoleByNameProcedure", parameters)

        End Function

        Public Async Function CreateAsync(role As Role) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_name", role.Name},
                {"p_description", role.Description}
            }

            Dim result = Await ExecuteNonQueryAsync("CreateRoleProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al crear el rol")
            End If

            Return result

        End Function

        Public Async Function UpdateAsync(role As Role) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_id", role.Id},
                {"p_name", role.Name},
                {"p_description", role.Description}
            }

            Dim result = Await ExecuteNonQueryAsync("UpdateRoleProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al actualizar el rol")
            End If

            Return result

        End Function

        Public Async Function DeleteAsync(id As Integer) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_id", id}}

            Dim result = Await ExecuteNonQueryAsync("DeleteRoleProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al eliminar el rol")
            End If

            Return result

        End Function

        Public Async Function AssignPermissionAsync(roleId As Integer, permissionId As Integer) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_role_id", roleId},
                {"p_permission_id", permissionId}
            }

            Dim result = Await ExecuteNonQueryAsync("AssignPermissionToRoleProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al asignar el permiso al rol")
            End If

            Return result

        End Function

        Public Async Function UnassignPermissionAsync(roleId As Integer, permissionId As Integer) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_role_id", roleId},
                {"p_permission_id", permissionId}
            }

            Dim result = Await ExecuteNonQueryAsync("UnassignPermissionToRoleProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al desasignar el permiso al rol")
            End If

            Return result

        End Function


    End Class


End Namespace