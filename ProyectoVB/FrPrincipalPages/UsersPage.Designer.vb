<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersPage
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
        TxtEmail = New MaterialSkin.Controls.MaterialMaskedTextBox()
        lblEmailFrmUser = New MaterialSkin.Controls.MaterialLabel()
        TxtName = New MaterialSkin.Controls.MaterialMaskedTextBox()
        lblNameFrmUser = New MaterialSkin.Controls.MaterialLabel()
        CbxRole = New MaterialSkin.Controls.MaterialComboBox()
        lblRole = New MaterialSkin.Controls.MaterialLabel()
        BtnNewUser = New MaterialSkin.Controls.MaterialButton()
        DgvUsers = New DataGridView()
        CType(DgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtEmail
        ' 
        TxtEmail.AllowPromptAsInput = True
        TxtEmail.AnimateReadOnly = False
        TxtEmail.AsciiOnly = False
        TxtEmail.BackgroundImageLayout = ImageLayout.None
        TxtEmail.BeepOnError = False
        TxtEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        TxtEmail.Depth = 0
        TxtEmail.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtEmail.HidePromptOnLeave = False
        TxtEmail.HideSelection = True
        TxtEmail.InsertKeyMode = InsertKeyMode.Default
        TxtEmail.LeadingIcon = Nothing
        TxtEmail.Location = New Point(16, 669)
        TxtEmail.Mask = ""
        TxtEmail.MaxLength = 32767
        TxtEmail.MouseState = MaterialSkin.MouseState.OUT
        TxtEmail.Name = "TxtEmail"
        TxtEmail.PasswordChar = ChrW(0)
        TxtEmail.PrefixSuffixText = Nothing
        TxtEmail.PromptChar = "_"c
        TxtEmail.ReadOnly = False
        TxtEmail.RejectInputOnFirstFailure = False
        TxtEmail.ResetOnPrompt = True
        TxtEmail.ResetOnSpace = True
        TxtEmail.RightToLeft = RightToLeft.No
        TxtEmail.SelectedText = ""
        TxtEmail.SelectionLength = 0
        TxtEmail.SelectionStart = 0
        TxtEmail.ShortcutsEnabled = True
        TxtEmail.Size = New Size(250, 48)
        TxtEmail.SkipLiterals = True
        TxtEmail.TabIndex = 12
        TxtEmail.TabStop = False
        TxtEmail.TextAlign = HorizontalAlignment.Left
        TxtEmail.TextMaskFormat = MaskFormat.IncludeLiterals
        TxtEmail.TrailingIcon = Nothing
        TxtEmail.UseSystemPasswordChar = False
        TxtEmail.ValidatingType = Nothing
        ' 
        ' lblEmailFrmUser
        ' 
        lblEmailFrmUser.AutoSize = True
        lblEmailFrmUser.Depth = 0
        lblEmailFrmUser.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblEmailFrmUser.Location = New Point(16, 647)
        lblEmailFrmUser.MouseState = MaterialSkin.MouseState.HOVER
        lblEmailFrmUser.Name = "lblEmailFrmUser"
        lblEmailFrmUser.Size = New Size(53, 19)
        lblEmailFrmUser.TabIndex = 11
        lblEmailFrmUser.Text = "Email : "
        ' 
        ' TxtName
        ' 
        TxtName.AllowPromptAsInput = True
        TxtName.AnimateReadOnly = False
        TxtName.AsciiOnly = False
        TxtName.BackgroundImageLayout = ImageLayout.None
        TxtName.BeepOnError = False
        TxtName.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        TxtName.Depth = 0
        TxtName.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtName.HidePromptOnLeave = False
        TxtName.HideSelection = True
        TxtName.InsertKeyMode = InsertKeyMode.Default
        TxtName.LeadingIcon = Nothing
        TxtName.Location = New Point(16, 583)
        TxtName.Mask = ""
        TxtName.MaxLength = 32767
        TxtName.MouseState = MaterialSkin.MouseState.OUT
        TxtName.Name = "TxtName"
        TxtName.PasswordChar = ChrW(0)
        TxtName.PrefixSuffixText = Nothing
        TxtName.PromptChar = "_"c
        TxtName.ReadOnly = False
        TxtName.RejectInputOnFirstFailure = False
        TxtName.ResetOnPrompt = True
        TxtName.ResetOnSpace = True
        TxtName.RightToLeft = RightToLeft.No
        TxtName.SelectedText = ""
        TxtName.SelectionLength = 0
        TxtName.SelectionStart = 0
        TxtName.ShortcutsEnabled = True
        TxtName.Size = New Size(250, 48)
        TxtName.SkipLiterals = True
        TxtName.TabIndex = 10
        TxtName.TabStop = False
        TxtName.TextAlign = HorizontalAlignment.Left
        TxtName.TextMaskFormat = MaskFormat.IncludeLiterals
        TxtName.TrailingIcon = Nothing
        TxtName.UseSystemPasswordChar = False
        TxtName.ValidatingType = Nothing
        ' 
        ' lblNameFrmUser
        ' 
        lblNameFrmUser.AutoSize = True
        lblNameFrmUser.Depth = 0
        lblNameFrmUser.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNameFrmUser.Location = New Point(16, 561)
        lblNameFrmUser.MouseState = MaterialSkin.MouseState.HOVER
        lblNameFrmUser.Name = "lblNameFrmUser"
        lblNameFrmUser.Size = New Size(69, 19)
        lblNameFrmUser.TabIndex = 9
        lblNameFrmUser.Text = "Nombre : "
        ' 
        ' CbxRole
        ' 
        CbxRole.AutoResize = False
        CbxRole.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        CbxRole.Depth = 0
        CbxRole.DrawMode = DrawMode.OwnerDrawVariable
        CbxRole.DropDownHeight = 174
        CbxRole.DropDownStyle = ComboBoxStyle.DropDownList
        CbxRole.DropDownWidth = 121
        CbxRole.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        CbxRole.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        CbxRole.FormattingEnabled = True
        CbxRole.IntegralHeight = False
        CbxRole.ItemHeight = 43
        CbxRole.Location = New Point(16, 761)
        CbxRole.MaxDropDownItems = 4
        CbxRole.MouseState = MaterialSkin.MouseState.OUT
        CbxRole.Name = "CbxRole"
        CbxRole.Size = New Size(248, 49)
        CbxRole.StartIndex = 0
        CbxRole.TabIndex = 13
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Depth = 0
        lblRole.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblRole.Location = New Point(16, 739)
        lblRole.MouseState = MaterialSkin.MouseState.HOVER
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(32, 19)
        lblRole.TabIndex = 14
        lblRole.Text = "Rol :"
        ' 
        ' BtnNewUser
        ' 
        BtnNewUser.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnNewUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnNewUser.Depth = 0
        BtnNewUser.HighEmphasis = True
        BtnNewUser.Icon = Nothing
        BtnNewUser.Location = New Point(16, 819)
        BtnNewUser.Margin = New Padding(4, 6, 4, 6)
        BtnNewUser.MouseState = MaterialSkin.MouseState.HOVER
        BtnNewUser.Name = "BtnNewUser"
        BtnNewUser.NoAccentTextColor = Color.Empty
        BtnNewUser.Size = New Size(184, 36)
        BtnNewUser.TabIndex = 15
        BtnNewUser.Text = "Crear Nuevo Usuario"
        BtnNewUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnNewUser.UseAccentColor = False
        BtnNewUser.UseVisualStyleBackColor = True
        ' 
        ' DgvUsers
        ' 
        DgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvUsers.Location = New Point(485, 218)
        DgvUsers.Name = "DgvUsers"
        DgvUsers.RowTemplate.Height = 25
        DgvUsers.Size = New Size(1196, 649)
        DgvUsers.TabIndex = 16
        ' 
        ' UsersPage
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DgvUsers)
        Controls.Add(BtnNewUser)
        Controls.Add(lblRole)
        Controls.Add(CbxRole)
        Controls.Add(TxtEmail)
        Controls.Add(lblEmailFrmUser)
        Controls.Add(TxtName)
        Controls.Add(lblNameFrmUser)
        Name = "UsersPage"
        Size = New Size(1684, 870)
        CType(DgvUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPasswordFrmUser As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxtEmail As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents lblEmailFrmUser As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxtName As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents lblNameFrmUser As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CbxRole As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents lblRole As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BtnNewUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents DgvUsers As DataGridView
End Class
