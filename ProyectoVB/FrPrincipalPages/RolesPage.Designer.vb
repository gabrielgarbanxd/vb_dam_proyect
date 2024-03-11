<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RolesPage
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        btnGuardar = New MaterialSkin.Controls.MaterialButton()
        DataGridView2 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNameFrmRole
        ' 
        lblNameFrmRole.AutoSize = True
        lblNameFrmRole.Depth = 0
        lblNameFrmRole.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
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
        txtNameFrmRoles.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
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
        lblDescriptionFrmRole.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
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
        lblSelect.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
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
        chkPermisos.Items.AddRange(New Object() {"CREATE", "UPDATE", "READ", "DELETE"})
        chkPermisos.Location = New Point(24, 375)
        chkPermisos.Name = "chkPermisos"
        chkPermisos.Size = New Size(180, 94)
        chkPermisos.TabIndex = 13
        ' 
        ' lblAdminFrmP
        ' 
        lblAdminFrmP.AutoSize = True
        lblAdminFrmP.Depth = 0
        lblAdminFrmP.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblAdminFrmP.Location = New Point(24, 353)
        lblAdminFrmP.MouseState = MaterialSkin.MouseState.HOVER
        lblAdminFrmP.Name = "lblAdminFrmP"
        lblAdminFrmP.Size = New Size(63, 19)
        lblAdminFrmP.TabIndex = 14
        lblAdminFrmP.Text = "Usuarios"
        ' 
        ' lblModeradorFrmP
        ' 
        lblModeradorFrmP.AutoSize = True
        lblModeradorFrmP.Depth = 0
        lblModeradorFrmP.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblModeradorFrmP.Location = New Point(24, 482)
        lblModeradorFrmP.MouseState = MaterialSkin.MouseState.HOVER
        lblModeradorFrmP.Name = "lblModeradorFrmP"
        lblModeradorFrmP.Size = New Size(40, 19)
        lblModeradorFrmP.TabIndex = 15
        lblModeradorFrmP.Text = "Roles"
        ' 
        ' lblUserFrmP
        ' 
        lblUserFrmP.AutoSize = True
        lblUserFrmP.Depth = 0
        lblUserFrmP.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblUserFrmP.Location = New Point(24, 616)
        lblUserFrmP.MouseState = MaterialSkin.MouseState.HOVER
        lblUserFrmP.Name = "lblUserFrmP"
        lblUserFrmP.Size = New Size(146, 19)
        lblUserFrmP.TabIndex = 16
        lblUserFrmP.Text = "Usuarios Eliminados"
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"CREATE", "UPDATE", "READ", "DELETE"})
        CheckedListBox1.Location = New Point(24, 504)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(180, 94)
        CheckedListBox1.TabIndex = 17
        ' 
        ' CheckedListBox2
        ' 
        CheckedListBox2.FormattingEnabled = True
        CheckedListBox2.Items.AddRange(New Object() {"CREATE", "UPDATE", "READ", "DELETE"})
        CheckedListBox2.Location = New Point(24, 638)
        CheckedListBox2.Name = "CheckedListBox2"
        CheckedListBox2.Size = New Size(180, 94)
        CheckedListBox2.TabIndex = 18
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(322, 35)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(535, 800)
        DataGridView1.TabIndex = 19
        ' 
        ' btnGuardar
        ' 
        btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnGuardar.Depth = 0
        btnGuardar.HighEmphasis = True
        btnGuardar.Icon = Nothing
        btnGuardar.Location = New Point(24, 752)
        btnGuardar.Margin = New Padding(4, 6, 4, 6)
        btnGuardar.MouseState = MaterialSkin.MouseState.HOVER
        btnGuardar.Name = "btnGuardar"
        btnGuardar.NoAccentTextColor = Color.Empty
        btnGuardar.Size = New Size(88, 36)
        btnGuardar.TabIndex = 20
        btnGuardar.Text = "Guardar"
        btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnGuardar.UseAccentColor = False
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(894, 35)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(504, 800)
        DataGridView2.TabIndex = 21
        ' 
        ' RolesPage
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DataGridView2)
        Controls.Add(btnGuardar)
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
        Size = New Size(1684, 870)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnGuardar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents DataGridView2 As DataGridView

End Class
