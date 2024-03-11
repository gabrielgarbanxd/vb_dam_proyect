Imports ProyectoVB.Entities
Imports ProyectoVB.Repositories

Namespace Services
    Public Class RoleService
        Private ReadOnly _roleRepository As MySqlRoleRepository
        Private ReadOnly _permissionRepository As MySqlPermissionRepository

        Public Sub New(roleRepository As MySqlRoleRepository, permissionRepository As MySqlPermissionRepository)
            _roleRepository = roleRepository
            _permissionRepository = permissionRepository
        End Sub

        Public Async Function GetAll() As Task(Of List(Of Role))
            Try
                Return Await _roleRepository.GetAllAsync()
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al obtener todos los roles")
            End Try
        End Function

        Public Async Function GetById(id As Integer) As Task(Of Role)
            Try
                Return Await _roleRepository.FindByIdAsync(id)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al obtener el rol por ID")
            End Try
        End Function

        Public Async Function SearchByName(name As String) As Task(Of IEnumerable(Of Role))
            Try
                Return Await _roleRepository.SearchByNameAsync(name)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al buscar roles por nombre")
            End Try
        End Function

        Public Async Function Create(role As Role) As Task(Of Integer)
            Try
                Return Await _roleRepository.CreateAsync(role)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al crear el rol")
            End Try
        End Function

        Public Async Function Update(role As Role) As Task(Of Integer)
            Try
                Return Await _roleRepository.UpdateAsync(role)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al actualizar el rol")
            End Try
        End Function

        Public Async Function Delete(id As Integer) As Task(Of Integer)
            Try
                Return Await _roleRepository.DeleteAsync(id)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al eliminar el rol")
            End Try
        End Function

        Public Async Function AssignPermissionAsync(roleId As Integer, permissionId As Integer) As Task(Of Integer)
            Try
                Return Await _roleRepository.AssignPermissionAsync(roleId, permissionId)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al asignar permiso al rol")
            End Try
        End Function

        Public Async Function UnassignPermissionAsync(roleId As Integer, permissionId As Integer) As Task(Of Integer)
            Try
                Return Await _roleRepository.UnassignPermissionAsync(roleId, permissionId)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al desasignar permiso del rol")
            End Try
        End Function
    End Class
End Namespace
