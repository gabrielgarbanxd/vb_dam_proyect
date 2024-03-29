﻿Imports ProyectoVB.Entities
Imports ProyectoVB.Repositories

Namespace Services
    Public Class UserService
        Private ReadOnly _userRepository As MySqlUserRepository
        Private ReadOnly _roleRepository As MySqlRoleRepository
        Private ReadOnly _permissionRepository As MySqlPermissionRepository


        Public Sub New(userRepository As MySqlUserRepository, roleRepository As MySqlRoleRepository, permissionRepository As MySqlPermissionRepository)
            _userRepository = userRepository
            _roleRepository = roleRepository
            _permissionRepository = permissionRepository
        End Sub

        Public Async Function Authenticate(name As String, password As String) As Task(Of User)
            Try

                Dim user = Await _userRepository.SearchByNameAsync(name)

                If user Is Nothing Or user.VerifyPassword(password) = False Then
                    Throw New ServiceException("Usuario o contraseña incorrectos")
                End If

                user.Role = Await _roleRepository.FindByIdAsync(user.RoleId)
                user.Role.Permissions = Await _permissionRepository.SearchByRoleAsync(user.RoleId)

                user.LastConnection = DateTime.Now

                Dim unused = _userRepository.UpdateAsync(user)

                Return user

            Catch ex As Exception

                Logger.LogException(ex)
                Throw New ServiceException("Error al autenticar el usuario")

            End Try
        End Function

        Public Async Function ResetPassword(email As String) As Task
            Try

                Dim user = Await _userRepository.SearchByEmailAsync(email)

                Dim newPassword = DateTime.Now.ToString("yyyyMMddHHmmss")

                user.Password = User.HashPassword(newPassword)
                user.FirstLogin = True

                Await _userRepository.UpdateAsync(user)


                Dim mailService = New MailService
                Await mailService.SendRecoverPasswordEmailAsync(email, newPassword)

            Catch ex As Exception

                Logger.LogException(ex)
                Throw New ServiceException("Error al resetear la contraseña")

            End Try
        End Function



        Public Async Function GetAll() As Task(Of List(Of User))
            Try
                Dim users = Await _userRepository.GetAllAsync

                For Each user In users
                    user.Role = Await _roleRepository.FindByIdAsync(user.RoleId)
                    user.Role.Permissions = Await _permissionRepository.SearchByRoleAsync(user.RoleId)
                Next

                Return users
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New ServiceException("Error al obtener los usuarios")
            End Try
        End Function

        Public Async Function GetById(id As Integer) As Task(Of User)
            Try

                Dim user = Await _userRepository.FindByIdAsync(id)
                user.Role = Await _roleRepository.FindByIdAsync(user.RoleId)
                user.Role.Permissions = Await _permissionRepository.SearchByRoleAsync(user.RoleId)
                Return user

            Catch ex As Exception

                Logger.LogException(ex)
                Throw New ServiceException("Error al obtener el usuario")

            End Try
        End Function

        Public Async Function GetByName(name As String) As Task(Of User)
            Try

                Dim user = Await _userRepository.SearchByNameAsync(name)
                user.Role = Await _roleRepository.FindByIdAsync(user.RoleId)
                user.Role.Permissions = Await _permissionRepository.SearchByRoleAsync(user.RoleId)
                Return user

            Catch ex As Exception

                Logger.LogException(ex)
                Throw New ServiceException("Error al obtener el usuario")

            End Try
        End Function

        Public Async Function SearchByEmailAsync(email As String) As Task(Of User)
            Try

                Dim user = Await _userRepository.SearchByEmailAsync(email)
                Return user

            Catch ex As Exception

                Logger.LogException(ex)
                Throw New ServiceException("Error al obtener el usuario")

            End Try
        End Function


        Public Async Function Create(user As User) As Task(Of Integer)
            Try

                Return Await _userRepository.CreateAsync(user)

            Catch ex As Exception

                Logger.LogException(ex)
                Throw New ServiceException("Error al crear el usuario")

            End Try
        End Function

        Public Async Function Update(user As User) As Task(Of Integer)
            Try

                Return Await _userRepository.UpdateAsync(user)

            Catch ex As Exception

                Logger.LogException(ex)
                Throw New ServiceException("Error al actualizar el usuario")

            End Try
        End Function

        Public Async Function Delete(user As User) As Task(Of Integer)
            Try

                If user.LastConnection Is Nothing Then
                    Throw New ServiceException("No se puede eliminar un usuario que no haya iniciado sesión")
                End If

                ' solo podemos eliminar un usuario que lleve 3 dias sin conectarse
                If user.LastConnection?.AddDays(3) > DateTime.Now Then
                    Throw New ServiceException("No se puede eliminar un usuario que haya iniciado sesión en los últimos 3 días")
                End If


                Dim deletedUserRepo = New MySqlDeletedUserRepository()

                Dim deletedUser = New DeletedUser(user.Id, user.Name, user.Email, user.RoleId, user.CreatedAt, DateTime.Now)

                Await deletedUserRepo.CreateAsync(deletedUser)

                Return Await _userRepository.DeleteAsync(user.Id)

            Catch ex As Exception

                Logger.LogException(ex)
                Throw New ServiceException("Error al eliminar el usuario")

            End Try
        End Function

    End Class
End Namespace