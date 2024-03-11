Imports MaterialSkin

Public Class FrmPrincipal

    Private tabPageLoaders As New Dictionary(Of Integer, Action)()

    ' Pages
    Private usersPage As UsersPage
    Private rolesPage As RolesPage = Nothing
    Private deletedUsersPage As DeletedUsersPage = Nothing
    Private profilePage As ProfilePage = Nothing

    Public Sub New()
        InitializeComponent()

        ' Pages
        usersPage = New UsersPage
        TabPageUsers.Controls.Add(usersPage)

        ' Asignar los métodos Load a los índices de las pestañas
        tabPageLoaders.Add(1, AddressOf LoadTabPageRoles)
        tabPageLoaders.Add(2, AddressOf LoadTabPageDeletedUsers)
        tabPageLoaders.Add(3, AddressOf LoadTabPageProfile)

        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub TabPageChange(sender As Object, e As EventArgs) Handles TabControlMain.SelectedIndexChanged
        Dim selectedTabIndex = TabControlMain.SelectedIndex

        If tabPageLoaders.ContainsKey(selectedTabIndex) Then
            tabPageLoaders(selectedTabIndex).Invoke()
        End If
    End Sub

    Private Sub LoadTabPageRoles()
        If rolesPage Is Nothing Then
            rolesPage = New RolesPage
            TabPageRoles.Controls.Add(rolesPage)
        End If
    End Sub

    Private Sub LoadTabPageDeletedUsers()
        If deletedUsersPage Is Nothing Then
            deletedUsersPage = New DeletedUsersPage
            TabPageDeletedUsers.Controls.Add(deletedUsersPage)
        End If
    End Sub

    Private Sub LoadTabPageProfile()
        If profilePage Is Nothing Then
            profilePage = New ProfilePage
            TabPageProfile.Controls.Add(profilePage)
        End If
    End Sub


    Private Sub FrmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class