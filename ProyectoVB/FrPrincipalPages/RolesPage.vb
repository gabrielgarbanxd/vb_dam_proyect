Imports ProyectoVB.Entities
Imports ProyectoVB.Services

Public Class RolesPage

    Private ReadOnly _roleService As RoleService
    Private _roles As List(Of Role)

    Public Sub New()
        InitializeComponent()
        _roleService = New RoleService(My.Application.RoleRepository, My.Application.PermissionRepository)
        LoadRoles()
    End Sub

    Private Async Sub SaveRole()
        Dim selectedRowIndex As Integer = DataGridView1.SelectedCells(0).RowIndex
        Dim selectedRole As Role = _roles(selectedRowIndex)

        selectedRole.Permissions = New List(Of Permission)()

        For Each index As Integer In chkPermisos.CheckedIndices
            Dim action As PermissionAction = [Enum].Parse(GetType(PermissionAction), chkPermisos.Items(index).ToString())
            selectedRole.Permissions.Add(New Permission() With {.Action = action, .Resource = PermissionResource.USERS})
        Next

        Await _roleService.Update(selectedRole)

        LoadRoles()

        MessageBox.Show("Rol actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim selectedRole As Role = CType(DataGridView1.SelectedRows(0).DataBoundItem, Role)
            ShowPermissions(selectedRole)
        End If
    End Sub

    Private Sub ShowPermissions(selectedRole As Role)
        If selectedRole IsNot Nothing Then
            DataGridView2.AutoGenerateColumns = False
            DataGridView2.Columns.Clear()

            Dim actionColumn As New DataGridViewTextBoxColumn()
            actionColumn.DataPropertyName = "Action"
            actionColumn.HeaderText = "Acción"
            DataGridView2.Columns.Add(actionColumn)

            Dim resourceColumn As New DataGridViewTextBoxColumn()
            resourceColumn.DataPropertyName = "Resource"
            resourceColumn.HeaderText = "Recurso"
            DataGridView2.Columns.Add(resourceColumn)

            DataGridView2.DataSource = selectedRole.Permissions
        Else
            DataGridView2.DataSource = Nothing
        End If
    End Sub

End Class
