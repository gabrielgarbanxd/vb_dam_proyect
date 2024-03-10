Imports ProyectoVB.Entities
Imports ProyectoVB.Repositories.Mappers

Namespace Repositories

    Public Class MySqlUserRepository
        Inherits MySqlRepositoryBase(Of User)


        Public Sub New(mapper As UserMapper)
            MyBase.New(mapper)
        End Sub

        Public Async Function GetAllAsync() As Task(Of IEnumerable(Of User))

            Return Await ExecuteQueryAsync("GetAllUsersProcedure")

        End Function

        Public Async Function FindByIdAsync(id As Integer) As Task(Of User)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_id", id}}

            Dim users = Await ExecuteQueryAsync("GetUserByIdProcedure", parameters)

            If users.Any() Then

                Return users.First()

            End If

            Throw New Exception("Error al buscar el usuario")

        End Function

        Public Async Function SearchByNameAsync(name As String) As Task(Of User)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_name", name}}

            Dim users = Await ExecuteQueryAsync("SearchUsersByNameProcedure", parameters)


            If users.Any() Then

                Return users.First()

            End If

            Throw New Exception("Error al buscar el usuario")

        End Function

        Public Async Function SearchByEmailAsync(email As String) As Task(Of User)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_email", email}}

            Dim users = Await ExecuteQueryAsync("SearchUsersByEmailProcedure", parameters)


            If users.Any() Then

                Return users.First()

            End If

            Throw New Exception("Error al buscar el usuario")

        End Function

        Public Async Function CreateAsync(user As User) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_name", user.Name},
                {"p_email", user.Email},
                {"p_password", user.Password},
                {"p_payment", user.Payment},
                {"p_lastConnection", user.LastConnection},
                {"p_firstLogin", user.FirstLogin},
                {"p_roleId", user.RoleId},
                {"p_createdAt", user.CreatedAt}
            }

            Dim result = Await ExecuteNonQueryAsync("CreateUserProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al crear el usuario")
            End If

            Return result

        End Function

        Public Async Function UpdateAsync(user As User) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_id", user.Id},
                {"p_name", user.Name},
                {"p_email", user.Email},
                {"p_password", user.Password},
                {"p_payment", user.Payment},
                {"p_lastConnection", user.LastConnection},
                {"p_firstLogin", user.FirstLogin},
                {"p_roleId", user.RoleId},
                {"p_createdAt", user.CreatedAt}
            }

            Dim result = Await ExecuteNonQueryAsync("UpdateUserProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al actualizar el usuario")
            End If

            Return result

        End Function

        Public Async Function DeleteAsync(id As Integer) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_id", id}}

            Dim result = Await ExecuteNonQueryAsync("DeleteUserProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al eliminar el usuario")
            End If

            Return result

        End Function

    End Class


End Namespace