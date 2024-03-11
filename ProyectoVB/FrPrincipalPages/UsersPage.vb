Imports MaterialSkin.Controls
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
        DgvUsers.Columns("Name").Width = 200
        DgvUsers.Columns("Name").ReadOnly = True
        DgvUsers.Columns("Email").HeaderText = "Correo"
        DgvUsers.Columns("Email").Width = 230
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

    Private Function GetSelectedUser() As User

        If DgvUsers.SelectedRows.Count <= 0 Then

            MaterialMessageBox.Show("Debe seleccionar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return Nothing
        End If

        Return DgvUsers.SelectedRows(0).DataBoundItem

    End Function


    Private Async Sub BtnNewUser_Click(sender As Object, e As EventArgs) Handles BtnNewUser.Click

        'Pruebas para ver si se cargan los roles
        Dim role As Role = CbxRole.SelectedItem

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

        Dim user As User = GetSelectedUser()

        If user Is Nothing Then
            Return
        End If


        Try
            Await usersService.Delete(user)

            Users.Remove(user)

            LoadDataGrid()

            MaterialMessageBox.Show("Usuario eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As ServiceException
            MessageBox.Show("Error al eliminar el usuario: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Async Sub BtnResetPassword_Click(sender As Object, e As EventArgs) Handles BtnResetPassword.Click

        Dim user As User = GetSelectedUser()

        If user Is Nothing Then
            Return
        End If

        user.Password = User.HashPassword(DateTime.Now)
        user.FirstLogin = True

        Try
            Await usersService.Update(user)

            LoadDataGrid()

            MaterialMessageBox.Show("Contraseña reiniciada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As ServiceException
            MessageBox.Show("Error al reiniciar la contraseña: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Async Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        For Each row As DataGridViewRow In DgvUsers.Rows

            Dim user As User = row.DataBoundItem

            Try
                Await usersService.Update(user)

            Catch ex As ServiceException
                MessageBox.Show("Error al actualizar el usuario: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Next

        MaterialMessageBox.Show("Usuarios actualizados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BtnSearchConected_Click(sender As Object, e As EventArgs) Handles BtnSearchConected.Click

        ' filtrar por usuarios que se hayan conectado este mes
        Users = Users.Where(Function(u)
                                If u.LastConnection IsNot Nothing Then
                                    Return u.LastConnection.Value.Month = DateTime.Now.Month
                                End If
                                Return False
                            End Function).ToList()
        LoadDataGrid()

    End Sub

    Private Sub BtnDeleteFilters_Click(sender As Object, e As EventArgs) Handles BtnDeleteFilters.Click

        ' limpiar los filtros
        TxtNameToSearch.Text = ""
        DtpFrom.Value = DateTime.Now
        DtpTo.Value = DateTime.Now

        LoadUsers()
    End Sub

    Private Sub BtnSearchName_Click(sender As Object, e As EventArgs) Handles BtnSearchName.Click

        Dim name As String = TxtNameToSearch.Text

        If name = "" Then
            MaterialMessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Users = Users.Where(Function(u) u.Name.ToLower().Contains(name.ToLower())).ToList()

        LoadDataGrid()

    End Sub

    Private Sub BtnSearchDates_Click(sender As Object, e As EventArgs) Handles BtnSearchDates.Click

        Dim dateFrom As DateTime = DtpFrom.Value
        Dim dateTo As DateTime = DtpTo.Value


        If dateTo < dateFrom Then
            MaterialMessageBox.Show("La fecha de inicio debe ser menor a la fecha de fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Users = Users.Where(Function(u) u.CreatedAt >= dateFrom And u.CreatedAt <= dateTo).ToList()

        LoadDataGrid()


    End Sub
End Class
