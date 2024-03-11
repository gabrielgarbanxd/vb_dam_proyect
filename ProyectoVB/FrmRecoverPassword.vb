Imports MaterialSkin
Imports ProyectoVB.Services

Public Class FrmRecoverPassword

    Private ReadOnly UserService As UserService

    Public Sub New(UserService As UserService)
        InitializeComponent()
        Me.UserService = UserService
    End Sub

    Private Sub FrmRecoverPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub



    Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Try

            Await UserService.ResetPassword(TxtEmail.Text)
            MessageBox.Show("Se ha enviado un correo con la nueva contraseña", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As ServiceException

            MessageBox.Show("Error al resetear la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

End Class