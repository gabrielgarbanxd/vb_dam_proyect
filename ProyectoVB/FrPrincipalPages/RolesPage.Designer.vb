<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RolesPage
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        lblNameFrmRole = New MaterialSkin.Controls.MaterialLabel()
        txtNameFrmRoles = New MaterialSkin.Controls.MaterialMaskedTextBox()
        lblDescriptionFrmRole = New MaterialSkin.Controls.MaterialLabel()
        txtDescriptionFrmRoles = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        lblSelect = New MaterialSkin.Controls.MaterialLabel()
        chkPermisos = New CheckedListBox()
        lblAdminFrmP = New MaterialSkin.Controls.MaterialLabel()
        lblModeradorFrmP = New MaterialSkin.Controls.MaterialLabel()
        lblUserFrmP = New MaterialSkin.Controls.MaterialLabel()
        CheckedListBox1 = New CheckedListBox()
        CheckedListBox2 = New CheckedListBox()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNameFrmRole
        ' 
        lblNameFrmRole.AutoSize = True
        lblNameFrmRole.Depth = 0
        lblNameFrmRole.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNameFrmRole.Location = New Point(24, 35)
        lblNameFrmRole.MouseState = MaterialSkin.MouseState.HOVER
        lblNameFrmRole.Name = "lblNameFrmRole"
        lblNameFrmRole.Size = New Size(65, 19)
        lblNameFrmRole.TabIndex = 4
        lblNameFrmRole.Text = "Nombre: "
        ' 
        ' txtNameFrmRoles
        ' 
        txtNameFrmRoles.AllowPromptAsInput = True
        txtNameFrmRoles.AnimateReadOnly = False
        txtNameFrmRoles.AsciiOnly = False
        txtNameFrmRoles.BackgroundImageLayout = ImageLayout.None
        txtNameFrmRoles.BeepOnError = False
        txtNameFrmRoles.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtNameFrmRoles.Depth = 0
        txtNameFrmRoles.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNameFrmRoles.HidePromptOnLeave = False
        txtNameFrmRoles.HideSelection = True
        txtNameFrmRoles.InsertKeyMode = InsertKeyMode.Default
        txtNameFrmRoles.LeadingIcon = Nothing
        txtNameFrmRoles.Location = New Point(24, 66)
        txtNameFrmRoles.Mask = ""
        txtNameFrmRoles.MaxLength = 32767
        txtNameFrmRoles.MouseState = MaterialSkin.MouseState.OUT
        txtNameFrmRoles.Name = "txtNameFrmRoles"
        txtNameFrmRoles.PasswordChar = ChrW(0)
        txtNameFrmRoles.PrefixSuffixText = Nothing
        txtNameFrmRoles.PromptChar = "_"c
        txtNameFrmRoles.ReadOnly = False
        txtNameFrmRoles.RejectInputOnFirstFailure = False
        txtNameFrmRoles.ResetOnPrompt = True
        txtNameFrmRoles.ResetOnSpace = True
        txtNameFrmRoles.RightToLeft = RightToLeft.No
        txtNameFrmRoles.SelectedText = ""
        txtNameFrmRoles.SelectionLength = 0
        txtNameFrmRoles.SelectionStart = 0
        txtNameFrmRoles.ShortcutsEnabled = True
        txtNameFrmRoles.Size = New Size(250, 48)
        txtNameFrmRoles.SkipLiterals = True
        txtNameFrmRoles.TabIndex = 5
        txtNameFrmRoles.TabStop = False
        txtNameFrmRoles.TextAlign = HorizontalAlignment.Left
        txtNameFrmRoles.TextMaskFormat = MaskFormat.IncludeLiterals
        txtNameFrmRoles.TrailingIcon = Nothing
        txtNameFrmRoles.UseSystemPasswordChar = False
        txtNameFrmRoles.ValidatingType = Nothing
        ' 
        ' lblDescriptionFrmRole
        ' 
        lblDescriptionFrmRole.AutoSize = True
        lblDescriptionFrmRole.Depth = 0
        lblDescriptionFrmRole.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblDescriptionFrmRole.Location = New Point(24, 133)
        lblDescriptionFrmRole.MouseState = MaterialSkin.MouseState.HOVER
        lblDescriptionFrmRole.Name = "lblDescriptionFrmRole"
        lblDescriptionFrmRole.Size = New Size(80, 19)
        lblDescriptionFrmRole.TabIndex = 7
        lblDescriptionFrmRole.Text = "Decripcion:"
        ' 
        ' txtDescriptionFrmRoles
        ' 
        txtDescriptionFrmRoles.AnimateReadOnly = False
        txtDescriptionFrmRoles.BackgroundImageLayout = ImageLayout.None
        txtDescriptionFrmRoles.CharacterCasing = CharacterCasing.Normal
        txtDescriptionFrmRoles.Depth = 0
        txtDescriptionFrmRoles.HideSelection = True
        txtDescriptionFrmRoles.Location = New Point(24, 183)
        txtDescriptionFrmRoles.MaxLength = 32767
        txtDescriptionFrmRoles.MouseState = MaterialSkin.MouseState.OUT
        txtDescriptionFrmRoles.Name = "txtDescriptionFrmRoles"
        txtDescriptionFrmRoles.PasswordChar = ChrW(0)
        txtDescriptionFrmRoles.ReadOnly = False
        txtDescriptionFrmRoles.ScrollBars = ScrollBars.None
        txtDescriptionFrmRoles.SelectedText = ""
        txtDescriptionFrmRoles.SelectionLength = 0
        txtDescriptionFrmRoles.SelectionStart = 0
        txtDescriptionFrmRoles.ShortcutsEnabled = True
        txtDescriptionFrmRoles.Size = New Size(250, 100)
        txtDescriptionFrmRoles.TabIndex = 8
        txtDescriptionFrmRoles.TabStop = False
        txtDescriptionFrmRoles.TextAlign = HorizontalAlignment.Left
        txtDescriptionFrmRoles.UseSystemPasswordChar = False
        ' 
        ' lblSelect
        ' 
        lblSelect.AutoSize = True
        lblSelect.Depth = 0
        lblSelect.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblSelect.Location = New Point(24, 312)
        lblSelect.MouseState = MaterialSkin.MouseState.HOVER
        lblSelect.Name = "lblSelect"
        lblSelect.Size = New Size(155, 19)
        lblSelect.TabIndex = 12
        lblSelect.Text = "Selecciona permisos: "
        ' 
        ' chkPermisos
        ' 
        chkPermisos.FormattingEnabled = True
        chkPermisos.Items.AddRange(New Object() {"CREAR USUARIOS", "LEER USUARIOS", "ACTUALIZAR USUARIOS", "ELIMINAR USUARIOS"})
        chkPermisos.Location = New Point(24, 375)
        chkPermisos.Name = "chkPermisos"
        chkPermisos.Size = New Size(180, 166)
        chkPermisos.TabIndex = 13
        ' 
        ' lblAdminFrmP
        ' 
        lblAdminFrmP.AutoSize = True
        lblAdminFrmP.Depth = 0
        lblAdminFrmP.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblAdminFrmP.Location = New Point(24, 353)
        lblAdminFrmP.MouseState = MaterialSkin.MouseState.HOVER
        lblAdminFrmP.Name = "lblAdminFrmP"
        lblAdminFrmP.Size = New Size(47, 19)
        lblAdminFrmP.TabIndex = 14
        lblAdminFrmP.Text = "Admin"
        ' 
        ' lblModeradorFrmP
        ' 
        lblModeradorFrmP.AutoSize = True
        lblModeradorFrmP.Depth = 0
        lblModeradorFrmP.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblModeradorFrmP.Location = New Point(24, 555)
        lblModeradorFrmP.MouseState = MaterialSkin.MouseState.HOVER
        lblModeradorFrmP.Name = "lblModeradorFrmP"
        lblModeradorFrmP.Size = New Size(78, 19)
        lblModeradorFrmP.TabIndex = 15
        lblModeradorFrmP.Text = "Moderador"
        ' 
        ' lblUserFrmP
        ' 
        lblUserFrmP.AutoSize = True
        lblUserFrmP.Depth = 0
        lblUserFrmP.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblUserFrmP.Location = New Point(24, 756)
        lblUserFrmP.MouseState = MaterialSkin.MouseState.HOVER
        lblUserFrmP.Name = "lblUserFrmP"
        lblUserFrmP.Size = New Size(32, 19)
        lblUserFrmP.TabIndex = 16
        lblUserFrmP.Text = "User"
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"CREAR USUARIOS", "LEER USUARIOS", "ACTUALIZAR USUARIOS", "ELIMINAR USUARIOS"})
        CheckedListBox1.Location = New Point(24, 577)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(180, 166)
        CheckedListBox1.TabIndex = 17
        ' 
        ' CheckedListBox2
        ' 
        CheckedListBox2.FormattingEnabled = True
        CheckedListBox2.Items.AddRange(New Object() {"CREAR USUARIOS", "LEER USUARIOS", "ACTUALIZAR USUARIOS", "ELIMINAR USUARIOS"})
        CheckedListBox2.Location = New Point(24, 778)
        CheckedListBox2.Name = "CheckedListBox2"
        CheckedListBox2.Size = New Size(180, 166)
        CheckedListBox2.TabIndex = 18
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(322, 35)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1539, 909)
        DataGridView1.TabIndex = 19
        ' 
        ' RolesPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DataGridView1)
        Controls.Add(CheckedListBox2)
        Controls.Add(CheckedListBox1)
        Controls.Add(lblUserFrmP)
        Controls.Add(lblModeradorFrmP)
        Controls.Add(lblAdminFrmP)
        Controls.Add(chkPermisos)
        Controls.Add(lblSelect)
        Controls.Add(txtDescriptionFrmRoles)
        Controls.Add(lblDescriptionFrmRole)
        Controls.Add(txtNameFrmRoles)
        Controls.Add(lblNameFrmRole)
        Name = "RolesPage"
        Size = New Size(1906, 985)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNameFrmRole As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNameFrmRoles As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents lblDescriptionFrmRole As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtDescriptionFrmRoles As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents lblSelect As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents chkPermisos As CheckedListBox
    Friend WithEvents lblAdminFrmP As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblModeradorFrmP As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblUserFrmP As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents DataGridView1 As DataGridView

End Class
