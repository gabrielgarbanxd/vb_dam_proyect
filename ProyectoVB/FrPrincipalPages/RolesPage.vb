Imports ProyectoVB.Entities
Imports ProyectoVB.Services

Public Class RolesPage

    Private ReadOnly _roleService As RoleService
    Private _roles As List(Of Role)
    Private _permission As List(Of Permission)

    Public Sub New()
        InitializeComponent()
        _roleService = New RoleService(My.Application.RoleRepository, My.Application.PermissionRepository)





        LoadRoles()
        LoadPermissions()
    End Sub




    Private Async Sub LoadPermissions()
        Try
            _permission = Await My.Application.PermissionRepository.GetAllAsync()

        Catch ex As Exception

        End Try
    End Sub

    Private Async Sub SaveRole()
        Dim roleName As String = txtNameFrmRoles.Text
        Dim roleDescription As String = txtDescriptionFrmRoles.Text

        Dim newRole As New Role(0, roleName, roleDescription)

        ' Obtienen las acciones seleccionadas de cada lista de verificación (chkPermisos, CheckedListBox1, CheckedListBox2)
        ' y las convierten a PermissionAction. Estas acciones seleccionadas se utilizarán para filtrar los permisos que se asignarán al nuevo rol.

        Dim selectedUserActions = chkPermisos.CheckedItems.Cast(Of String)().Select(Function(a) [Enum].Parse(GetType(PermissionAction), a)).ToList()
        Dim selectedRoleActions = CheckedListBox1.CheckedItems.Cast(Of String)().Select(Function(a) [Enum].Parse(GetType(PermissionAction), a)).ToList()
        Dim selectedDeletedUserActions = CheckedListBox2.CheckedItems.Cast(Of String)().Select(Function(a) [Enum].Parse(GetType(PermissionAction), a)).ToList()
        Dim filterPermissions = _permission.Where(Function(p)
                                                      If p.Resource = PermissionResource.USERS AndAlso selectedUserActions.Contains(p.Action) Then
                                                          Return True
                                                      ElseIf p.Resource = PermissionResource.ROLES AndAlso selectedRoleActions.Contains(p.Action) Then
                                                          Return True
                                                      ElseIf p.Resource = PermissionResource.DELETED_USERS AndAlso selectedDeletedUserActions.Contains(p.Action) Then
                                                          Return True
                                                      Else
                                                          Return False
                                                      End If
                                                  End Function)

        Try
            Dim roleId As Integer = Await _roleService.Create(newRole)

            For Each p As Permission In filterPermissions
                Await _roleService.AssignPermissionAsync(roleId, p.Id)
            Next

            LoadRoles()
            MessageBox.Show("Rol creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As ServiceException
            MessageBox.Show("Error al crear el rol: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Async Sub LoadRoles()
        Try
            _roles = Await _roleService.GetAll()
            DataGridView1.DataSource = _roles

            With DataGridView1
                .AutoGenerateColumns = False
                .Columns.Clear()

                Dim idColumn As New DataGridViewTextBoxColumn()
                idColumn.DataPropertyName = "Id"
                idColumn.HeaderText = "ID"
                .Columns.Add(idColumn)

                Dim nameColumn As New DataGridViewTextBoxColumn()
                nameColumn.DataPropertyName = "Name"
                nameColumn.HeaderText = "Nombre"
                .Columns.Add(nameColumn)

                Dim descriptionColumn As New DataGridViewTextBoxColumn()
                descriptionColumn.DataPropertyName = "Description"
                descriptionColumn.HeaderText = "Descripción"
                .Columns.Add(descriptionColumn)
            End With

        Catch ex As Exception
            MessageBox.Show("Error al cargar los roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        SaveRole()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRole As Role = DataGridView1.SelectedRows(0).DataBoundItem
            ShowPermissions(selectedRole)
        End If
    End Sub

    Private Sub ShowPermissions(selectedRole As Role)

        If selectedRole IsNot Nothing Then
            DataGridView2.DataSource = Nothing
            DataGridView2.DataSource = selectedRole.Permissions
        Else
            DataGridView2.DataSource = Nothing
        End If
    End Sub

End Class