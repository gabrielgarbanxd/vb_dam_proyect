Imports ProyectoVB.Entities
Imports ProyectoVB.Repositories.Mappers

Namespace Repositories

    Public Class MySqlDeletedUserRepository
        Inherits MySqlRepositoryBase(Of DeletedUser)

        Public Sub New(mapper As DeletedUserMapper)
            MyBase.New(mapper)
        End Sub

        Public Sub New()
            MyBase.New()
        End Sub


        Public Async Function GetAllAsync() As Task(Of IEnumerable(Of DeletedUser))

            Return Await ExecuteQueryAsync("GetAllDeletedUsersProcedure")

        End Function

        Public Async Function FindByIdAsync(id As Integer) As Task(Of DeletedUser)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_id", id}}

            Dim users = Await ExecuteQueryAsync("GetDeletedUserByIdProcedure", parameters)

            If users.Any() Then

                Return users.First()

            End If

            Throw New Exception("Error al buscar el usuario")

        End Function

        Public Async Function SearchByNameAsync(name As String) As Task(Of DeletedUser)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_name", name}}

            Dim users = Await ExecuteQueryAsync("SearchDeletedUsersByNameProcedure", parameters)


            If users.Any() Then

                Return users.First()

            End If

            Throw New Exception("Error al buscar el usuario")

        End Function

        Public Async Function CreateAsync(user As DeletedUser) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_name", user.Name},
                {"p_email", user.Email},
                {"p_role_id", user.RoleId},
                {"p_created_at", user.CreatedAt},
                {"p_deleted_at", user.DeletedAt}
            }

            Dim result = Await ExecuteNonQueryAsync("CreateDeletedUserProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al crear el usuario")
            End If

            Return result

        End Function

        Public Async Function DeleteAsync(id As Integer) As Task(Of Integer)

            Dim parameters As New Dictionary(Of String, Object) From {{"p_id", id}}

            Dim result = Await ExecuteNonQueryAsync("DeleteDeletedUserProcedure", parameters)

            If result <= 0 Then
                Throw New Exception("Error al eliminar el usuario")
            End If

            Return result

        End Function

    End Class

End Namespace