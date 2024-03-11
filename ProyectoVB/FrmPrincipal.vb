Imports MaterialSkin

Public Class FrmPrincipal

    ' Pages
    Private usersPage As UsersPage
    Private rolesPage As RolesPage
    Private deletedUsersPage As DeletedUsersPage
    Private profilePage As ProfilePage

    Public Sub New()
        InitializeComponent()

        ' Pages
        usersPage = New UsersPage
        TabPageUsers.Controls.Add(usersPage)

        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub




    Private Sub FrmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub TabPageRoles_Click(sender As Object, e As EventArgs) Handles TabPageRoles.Click

        If rolesPage Is Nothing Then
            rolesPage = New RolesPage
            TabPageRoles.Controls.Add(rolesPage)
        End If

    End Sub

    Private Sub TabPageDeletedUsers_Click(sender As Object, e As EventArgs) Handles TabPageDeletedUsers.Click

        If deletedUsersPage Is Nothing Then
            deletedUsersPage = New DeletedUsersPage
            TabPageDeletedUsers.Controls.Add(deletedUsersPage)
        End If

    End Sub

    Private Sub TabPageProfile_Click(sender As Object, e As EventArgs) Handles TabPageProfile.Click

        If profilePage Is Nothing Then
            profilePage = New ProfilePage
            TabPageProfile.Controls.Add(profilePage)
        End If

    End Sub
End Class