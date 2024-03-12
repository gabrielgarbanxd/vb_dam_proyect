Imports MaterialSkin.Controls
Imports ProyectoVB.Services

Public Class ProfilePage

    Private ReadOnly UserService As UserService

    Public Sub New()
        InitializeComponent()
        UserService = New UserService(My.Application.UserRepository, My.Application.RoleRepository, My.Application.PermissionRepository)
    End Sub

    Private Sub ProfilePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user = My.Application.UserContext
        LblNameData.Text = user.Name
        LblEmailData.Text = user.Email
        LblPaymentDateData.Text = If(user.Payment.HasValue, user.Payment?.ToString("dd/MM/yyyy"), "No ha pagado")
        LblRoleData.Text = user.Role.Name
        DgvMyPermissions.DataSource = user.Role.Permissions
    End Sub


    Private Async Sub BtnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim user = My.Application.UserContext

        Try
            user.Email = TxtEmail.Text
        Catch ex As Exception
            MaterialMessageBox.Show("Email no Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            Await UserService.Update(user)
        Catch ex As Exception

            MaterialMessageBox.Show("Error al actualizar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Async Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

        Dim user = My.Application.UserContext


        user.Payment = DateTime.Now


        Try
            Await UserService.Update(user)
            LblPaymentDateData.Text = user.Payment?.ToString("dd/MM/yyyy")
        Catch ex As Exception
            MaterialMessageBox.Show("Error al actualizar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class
