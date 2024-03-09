Imports ProyectoVB.Services
Imports ProyectoVB.Repositories
Imports ProyectoVB.Entities

Public Class FrmLogin

    Private ReadOnly UserService As UserService

    Public Sub New()
        InitializeComponent()
        UserService = New UserService(My.Application.UserRepository, My.Application.RoleRepository, My.Application.PermissionRepository)
    End Sub

    Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        'Try
        Dim user = Await UserService.Authenticate(TxtName.Text, TxtPassword.Text)

            If user IsNot Nothing Then
                My.Application.CambiarForm()
                Me.Close()
            End If

        'Catch ex As ServiceException
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub LostPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LostPassword.LinkClicked

        Dim recoverPassword = New FrmRecoverPassword(UserService)
        recoverPassword.ShowDialog()

    End Sub
End Class