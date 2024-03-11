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

            LoadDataGrid()

        Catch ex As ServiceException

            MessageBox.Show("Error al cargar los usuarios: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub LoadDataGrid()

        'DgvUsers.AutoGenerateColumns = False
        DgvUsers.DataSource = Nothing

        DgvUsers.DataSource = Users

        DgvUsers.Columns("Id").Visible = False
        DgvUsers.Columns("Name").HeaderText = "Nombre"
        DgvUsers.Columns("Name").ReadOnly = True
        DgvUsers.Columns("Email").HeaderText = "Correo"
        DgvUsers.Columns("Password").Visible = False
        DgvUsers.Columns("Payment").HeaderText = "Pago"
        DgvUsers.Columns("Payment").Width = 150
        DgvUsers.Columns("LastConnection").HeaderText = "Última conexión"
        DgvUsers.Columns("LastConnection").Width = 150
        DgvUsers.Columns("FirstLogin").HeaderText = "Primer inicio de sesión"
        DgvUsers.Columns("RoleId").HeaderText = "Rol"
        DgvUsers.Columns("CreatedAt").HeaderText = "Creado en"
        DgvUsers.Columns("CreatedAt").Width = 150
        DgvUsers.Columns("Role").Visible = False
    End Sub


    Private Async Sub BtnNewUser_Click(sender As Object, e As EventArgs) Handles BtnNewUser.Click

        'Pruebas para ver si se cargan los roles
        Dim role As Role = CbxRole.SelectedItem
        MsgBox(role.Name)
        MsgBox(role.Id)

        Dim user As New User(0, TxtName.Text, TxtEmail.Text, User.HashPassword(DateTime.Now), Nothing, Nothing, True, role.Id, DateTime.Now)

        Try
            Dim new_id = Await usersService.Create(user)

            user.Id = new_id

            Users.Add(user)

            LoadDataGrid()
        Catch ex As ServiceException
            MessageBox.Show("Error al crear el usuario: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Async Sub BtnDeleteUser_Click(sender As Object, e As EventArgs) Handles BtnDeleteUser.Click

        If DgvUsers.SelectedRows.Count <= 0 Then
            MessageBox.Show("Debe seleccionar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim user As User = DgvUsers.SelectedRows(0).DataBoundItem

        Try
            Await usersService.Delete(user)

            Users.Remove(user)

            LoadDataGrid()

            MaterialSkin.Controls.MaterialMessageBox.Show("Usuario eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As ServiceException
            MessageBox.Show("Error al eliminar el usuario: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnResetPassword_Click(sender As Object, e As EventArgs) Handles BtnResetPassword.Click

    End Sub
End Class
