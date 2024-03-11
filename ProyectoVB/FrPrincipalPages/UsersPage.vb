Imports ProyectoVB.Entities
Imports ProyectoVB.Services

Public Class UsersPage

    Private rolesService As RoleService
    Private usersService As UserService

    Private Roles As List(Of Role)
    Private Users As List(Of User)


    Public Sub New()
        InitializeComponent()

        rolesService = New RoleService(My.Application.RoleRepository, My.Application.PermissionRepository)
        usersService = New UserService(My.Application.UserRepository, My.Application.RoleRepository, My.Application.PermissionRepository)

        LoadRoles()
        LoadUsers()
    End Sub


    Private Async Sub LoadRoles()

        Try
            Roles = Await rolesService.GetAll()

            CbxRole.DataSource = Roles
            CbxRole.DisplayMember = "Name"
            CbxRole.ValueMember = "Id"

        Catch ex As ServiceException

            MessageBox.Show("Error al cargar los roles: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Async Sub LoadUsers()

        Try
            Users = Await usersService.GetAll()

            DgvUsers.DataSource = Users

        Catch ex As ServiceException

            MessageBox.Show("Error al cargar los usuarios: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BtnNewUser_Click(sender As Object, e As EventArgs) Handles BtnNewUser.Click

        'Pruebas para ver si se cargan los roles
        Dim role As Role = CbxRole.SelectedItem
        MsgBox(role.Name)
        MsgBox(role.Id)

    End Sub
End Class
