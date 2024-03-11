﻿Imports ProyectoVB.Entities
Imports ProyectoVB.Repositories
Imports ProyectoVB.Services

Public Class RolesPage

    Private ReadOnly _roleService As RoleService

    Public Sub New(roleService As RoleService)
        InitializeComponent()
        _roleService = roleService
        LoadRoles()
    End Sub

    Private Async Sub LoadRoles()
        Try
            Dim roles As List(Of Role) = Await _roleService.GetAll()
            DataGridView1.DataSource = roles
        Catch ex As Exception
            MessageBox.Show("Error al cargar los roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
