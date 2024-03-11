Imports MaterialSkin.Controls
Imports ProyectoVB.Entities
Imports ProyectoVB.Services

Public Class DeletedUsersPage

    Private ReadOnly deletedUsersService As DeletedUserService

    Private DeletedUsers As List(Of DeletedUser)

    Public Sub New()
        InitializeComponent()

        deletedUsersService = New DeletedUserService(My.Application.DeletedUserRepository)

        LoadDeletedUsers()
    End Sub

    Private Async Sub LoadDeletedUsers()

        Try
            DeletedUsers = Await deletedUsersService.GetAll()

            LoadDataGrid()

        Catch ex As ServiceException

            MessageBox.Show("Error al cargar los usuarios eliminados: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub LoadDataGrid()

        DgvDeletedUsers.DataSource = Nothing

        DgvDeletedUsers.DataSource = DeletedUsers

    End Sub

    Private Async Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles BtnRestoreUser.Click

        If DgvDeletedUsers.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un usuario para restaurar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim deletedUser As DeletedUser = DgvDeletedUsers.SelectedRows(0).DataBoundItem

        Try
            Await deletedUsersService.Restore(deletedUser)

            MaterialMessageBox.Show("Usuario restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadDeletedUsers()

        Catch ex As ServiceException

            MessageBox.Show("Error al restaurar el usuario: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BtnSearchName_Click(sender As Object, e As EventArgs) Handles BtnSearchName.Click

        Dim search As String = TxtNameToSearch.Text

        If search = "" Then
            MaterialMessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        DeletedUsers = DeletedUsers.Where(Function(u) u.Name.ToLower().Contains(search.ToLower())).ToList()

        LoadDataGrid()


    End Sub

    Private Sub BtnDeleteFilters_Click(sender As Object, e As EventArgs) Handles BtnDeleteFilters.Click

        TxtNameToSearch.Text = ""

        LoadDeletedUsers()

    End Sub
End Class
