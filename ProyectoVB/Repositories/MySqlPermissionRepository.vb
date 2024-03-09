Imports ProyectoVB.Repositories.Mappers
Imports ProyectoVB.Entities

Namespace Repositories
    Public Class MySqlPermissionRepository
        Inherits MySqlRepositoryBase(Of Permission)

        Public Sub New(mapper As PermissionMapper)
            MyBase.New(mapper)
        End Sub

        Public Async Function GetAllAsync() As Task(Of IEnumerable(Of Permission))

            Return Await ExecuteQueryAsync("GetAllPermissionsProcedure")

        End Function

        Public Async Function FindByIdAsync(id As Integer) As Task(Of Permission)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_id", id}}

            Dim permissions = Await ExecuteQueryAsync("GetPermissionByIdProcedure", parameters)

            Return permissions.FirstOrDefault()

        End Function

        Public Async Function SearchByNameAsync(action As PermissionAction, resource As PermissionResource) As Task(Of IEnumerable(Of Permission))

            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_action", action.ToString()},
                {"p_resource", resource.ToString()}
            }

            Return Await ExecuteQueryAsync("SearchPermissionsByNameProcedure", parameters)

        End Function

        Public Async Function SearchByRoleAsync(roleId As Integer) As Task(Of IEnumerable(Of Permission))

            Dim parameters As New Dictionary(Of String, Object) From {{"p_role_id", roleId}}

            Return Await ExecuteQueryAsync("SearchPermissionsByRoleProcedure", parameters)

        End Function

        Public Async Function CreateAsync(permission As Permission) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_action", permission.Action.ToString()},
                {"p_resource", permission.Resource.ToString()}
            }

            Dim result = Await ExecuteNonQueryAsync("CreatePermissionProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al crear el permiso")
            End If

            Return result

        End Function

        Public Async Function UpdateAsync(permission As Permission) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_id", permission.Id},
                {"p_action", permission.Action.ToString()},
                {"p_resource", permission.Resource.ToString()}
            }

            Dim result = Await ExecuteNonQueryAsync("UpdatePermissionProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al actualizar el permiso")
            End If

            Return result

        End Function

        Public Async Function DeleteAsync(id As Integer) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_id", id}}

            Dim result = Await ExecuteNonQueryAsync("DeletePermissionProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al eliminar el permiso")
            End If

            Return result

        End Function
    End Class

End Namespace