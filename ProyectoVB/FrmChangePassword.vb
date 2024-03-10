Imports ProyectoVB.Services
Imports ProyectoVB.Entities
Imports System.Windows.Forms

Public Class FrmChangePassword

    Private ReadOnly _user As User
    Private ReadOnly _userService As UserService


    Public Sub New(user As User, userService As UserService)

        InitializeComponent()

        _user = user
        _userService = userService

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If TxtNewPassword.Text = TxtConfirmPassword.Text Then
            UpdatePassword()
        Else
            MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Async Sub UpdatePassword()
        _user.Password = User.HashPassword(TxtNewPassword.Text)
        _user.FirstLogin = False

        Try
            Await _userService.Update(_user)
            MessageBox.Show("Contraseña actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As ServiceException
            MessageBox.Show("Error al actualizar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EmptyFields()
        TxtNewPassword.Text = ""
        TxtConfirmPassword.Text = ""
    End Sub


    Private Sub FrmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"Cambiar contraseña de { _user.Name }"
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub
End Class