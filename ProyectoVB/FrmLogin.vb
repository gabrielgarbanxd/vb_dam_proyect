Imports ProyectoVB.Entities
Imports ProyectoVB.Services
Imports MaterialSkin

Public Class FrmLogin

    Private ReadOnly UserService As UserService

    Public Sub New()
        InitializeComponent()
        UserService = New UserService(My.Application.UserRepository, My.Application.RoleRepository, My.Application.PermissionRepository)
    End Sub


    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        TxtName.Text = "admin"
        TxtPassword.Text = "admin"
    End Sub

    Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Try
            Dim user = Await UserService.Authenticate(TxtName.Text, TxtPassword.Text)

            If user Is Nothing Then

                HandleLoginError()
                Return

            End If

            If user.FirstLogin Then

                HandleFirstLogin(user)
                Return

            End If

            My.Application.UserContext = user

            OpenMainForm()

        Catch ex As ServiceException
            HandleLoginError()
        End Try
    End Sub

    Private Sub HandleFirstLogin(user As User)

        Dim changePassword = New FrmChangePassword(user, UserService)

        If changePassword.ShowDialog() = DialogResult.OK Then
            OpenMainForm()
        End If


        EmptyFields()

    End Sub


    Private Sub OpenMainForm()
        Me.Hide()
        Dim mainForm = New FrmPrincipal()
        mainForm.Show()
    End Sub

    Private Sub HandleLoginError()
        EmptyFields()
        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LostPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LostPassword.LinkClicked

        Dim recoverPassword = New FrmRecoverPassword(UserService)
        If recoverPassword.ShowDialog() = DialogResult.OK Then
            OpenMainForm()
        End If
        EmptyFields()

    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub EmptyFields()

        TxtName.Text = ""
        TxtPassword.Text = ""

    End Sub

End Class