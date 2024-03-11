Imports ProyectoVB.Entities
Imports ProyectoVB.Repositories

Namespace Services

    Public Class DeletedUserService

        Private ReadOnly _deletedUserRepository As MySqlDeletedUserRepository

        Public Sub New(deletedUserRepository As MySqlDeletedUserRepository)
            _deletedUserRepository = deletedUserRepository
        End Sub

        Public Async Function GetAll() As Task(Of List(Of DeletedUser))
            Try
                Return Await _deletedUserRepository.GetAllAsync()
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al obtener los usuarios eliminados")
            End Try
        End Function

        ' delete a user
        Public Async Function Delete(user As DeletedUser) As Task(Of Integer)
            Try
                Await _deletedUserRepository.DeleteAsync(user.Id)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al eliminar el usuario")
            End Try
        End Function

        ' Restore a deleted user
        Public Async Function Restore(userToRestore As DeletedUser) As Task(Of Integer)

            Try
                Dim restoredUser = New User With {
                    .Id = 0,
                    .Name = userToRestore.Name,
                    .Email = userToRestore.Email,
                    .RoleId = userToRestore.RoleId,
                    .FirstLogin = True,
                    .CreatedAt = userToRestore.CreatedAt,
                    .Password = User.HashPassword(DateTime.Now)
                }

                Await My.Application.UserRepository.CreateAsync(restoredUser)

                Return Await _deletedUserRepository.DeleteAsync(userToRestore.Id)

            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al restaurar el usuario")
            End Try

        End Function


    End Class

End Namespace
