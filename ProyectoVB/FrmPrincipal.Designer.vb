<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits MaterialSkin.Controls.MaterialForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TabControlMain = New MaterialSkin.Controls.MaterialTabControl()
        TabPageUsers = New TabPage()
        TabPageRoles = New TabPage()
        TabPageDeletedUsers = New TabPage()
        TabPageProfile = New TabPage()
        TabControlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControlMain
        ' 
        TabControlMain.Controls.Add(TabPageUsers)
        TabControlMain.Controls.Add(TabPageRoles)
        TabControlMain.Controls.Add(TabPageDeletedUsers)
        TabControlMain.Controls.Add(TabPageProfile)
        TabControlMain.Depth = 0
        TabControlMain.Dock = DockStyle.Fill
        TabControlMain.Location = New Point(3, 64)
        TabControlMain.MouseState = MaterialSkin.MouseState.HOVER
        TabControlMain.Multiline = True
        TabControlMain.Name = "TabControlMain"
        TabControlMain.SelectedIndex = 0
        TabControlMain.Size = New Size(1914, 1013)
        TabControlMain.TabIndex = 0
        ' 
        ' TabPageUsers
        ' 
        TabPageUsers.Location = New Point(4, 24)
        TabPageUsers.Name = "TabPageUsers"
        TabPageUsers.Padding = New Padding(3)
        TabPageUsers.Size = New Size(1906, 985)
        TabPageUsers.TabIndex = 0
        TabPageUsers.Text = "Usuarios"
        TabPageUsers.UseVisualStyleBackColor = True
        ' 
        ' TabPageRoles
        ' 
        TabPageRoles.Location = New Point(4, 24)
        TabPageRoles.Name = "TabPageRoles"
        TabPageRoles.Padding = New Padding(3)
        TabPageRoles.Size = New Size(1906, 985)
        TabPageRoles.TabIndex = 1
        TabPageRoles.Text = "Roles"
        TabPageRoles.UseVisualStyleBackColor = True
        ' 
        ' TabPageDeletedUsers
        ' 
        TabPageDeletedUsers.Location = New Point(4, 24)
        TabPageDeletedUsers.Name = "TabPageDeletedUsers"
        TabPageDeletedUsers.Padding = New Padding(3)
        TabPageDeletedUsers.Size = New Size(1906, 985)
        TabPageDeletedUsers.TabIndex = 2
        TabPageDeletedUsers.Text = "Usuarios Eliminados"
        TabPageDeletedUsers.UseVisualStyleBackColor = True
        ' 
        ' TabPageProfile
        ' 
        TabPageProfile.Location = New Point(4, 24)
        TabPageProfile.Name = "TabPageProfile"
        TabPageProfile.Padding = New Padding(3)
        TabPageProfile.Size = New Size(1906, 985)
        TabPageProfile.TabIndex = 3
        TabPageProfile.Text = "Perfil"
        TabPageProfile.UseVisualStyleBackColor = True
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1920, 1080)
        Controls.Add(TabControlMain)
        DrawerTabControl = TabControlMain
        Name = "FrmPrincipal"
        Text = "FrmPrincipal"
        TabControlMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControlMain As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPageUsers As TabPage
    Friend WithEvents TabPageRoles As TabPage
    Friend WithEvents TabPageDeletedUsers As TabPage
    Friend WithEvents TabPageProfile As TabPage
End Class
