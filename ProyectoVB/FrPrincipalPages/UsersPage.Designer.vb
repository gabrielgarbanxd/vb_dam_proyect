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
        BtnDeleteUser = New MaterialSkin.Controls.MaterialButton()
        BtnResetPassword = New MaterialSkin.Controls.MaterialButton()
        BtnUpdate = New MaterialSkin.Controls.MaterialButton()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        BtnSearchName = New MaterialSkin.Controls.MaterialButton()
        TxtNameToSearch = New MaterialSkin.Controls.MaterialMaskedTextBox()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        BtnSearchConected = New MaterialSkin.Controls.MaterialButton()
        MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        BtnSearchDates = New MaterialSkin.Controls.MaterialButton()
        lblto = New MaterialSkin.Controls.MaterialLabel()
        DtpTo = New DateTimePicker()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        DtpFrom = New DateTimePicker()
        Label3 = New Label()
        BtnDeleteFilters = New MaterialSkin.Controls.MaterialButton()
        Label2 = New Label()
        Label1 = New Label()
        CType(DgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        MaterialCard1.SuspendLayout()
        MaterialCard2.SuspendLayout()
        MaterialCard3.SuspendLayout()
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
        TxtEmail.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtEmail.HidePromptOnLeave = False
        TxtEmail.HideSelection = True
        TxtEmail.InsertKeyMode = InsertKeyMode.Default
        TxtEmail.LeadingIcon = Nothing
        TxtEmail.Location = New Point(57, 149)
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
        lblEmailFrmUser.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblEmailFrmUser.Location = New Point(57, 126)
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
        TxtName.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtName.HidePromptOnLeave = False
        TxtName.HideSelection = True
        TxtName.InsertKeyMode = InsertKeyMode.Default
        TxtName.LeadingIcon = Nothing
        TxtName.Location = New Point(57, 58)
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
        lblNameFrmUser.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNameFrmUser.Location = New Point(57, 34)
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
        CbxRole.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        CbxRole.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        CbxRole.FormattingEnabled = True
        CbxRole.IntegralHeight = False
        CbxRole.ItemHeight = 43
        CbxRole.Location = New Point(57, 247)
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
        lblRole.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblRole.Location = New Point(57, 224)
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
        BtnNewUser.Location = New Point(57, 309)
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
        DgvUsers.Location = New Point(682, 233)
        DgvUsers.Name = "DgvUsers"
        DgvUsers.RowTemplate.Height = 25
        DgvUsers.Size = New Size(972, 614)
        DgvUsers.TabIndex = 16
        ' 
        ' BtnDeleteUser
        ' 
        BtnDeleteUser.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnDeleteUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnDeleteUser.Depth = 0
        BtnDeleteUser.HighEmphasis = True
        BtnDeleteUser.Icon = Nothing
        BtnDeleteUser.Location = New Point(682, 865)
        BtnDeleteUser.Margin = New Padding(4, 6, 4, 6)
        BtnDeleteUser.MouseState = MaterialSkin.MouseState.HOVER
        BtnDeleteUser.Name = "BtnDeleteUser"
        BtnDeleteUser.NoAccentTextColor = Color.Empty
        BtnDeleteUser.Size = New Size(153, 36)
        BtnDeleteUser.TabIndex = 17
        BtnDeleteUser.Text = "Eliminar Usuario"
        BtnDeleteUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnDeleteUser.UseAccentColor = False
        BtnDeleteUser.UseVisualStyleBackColor = True
        ' 
        ' BtnResetPassword
        ' 
        BtnResetPassword.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnResetPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnResetPassword.Depth = 0
        BtnResetPassword.HighEmphasis = True
        BtnResetPassword.Icon = Nothing
        BtnResetPassword.Location = New Point(1105, 865)
        BtnResetPassword.Margin = New Padding(4, 6, 4, 6)
        BtnResetPassword.MouseState = MaterialSkin.MouseState.HOVER
        BtnResetPassword.Name = "BtnResetPassword"
        BtnResetPassword.NoAccentTextColor = Color.Empty
        BtnResetPassword.Size = New Size(190, 36)
        BtnResetPassword.TabIndex = 18
        BtnResetPassword.Text = "Reiniciar Contraseña"
        BtnResetPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnResetPassword.UseAccentColor = False
        BtnResetPassword.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnUpdate.Depth = 0
        BtnUpdate.HighEmphasis = True
        BtnUpdate.Icon = Nothing
        BtnUpdate.Location = New Point(1510, 865)
        BtnUpdate.Margin = New Padding(4, 6, 4, 6)
        BtnUpdate.MouseState = MaterialSkin.MouseState.HOVER
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.NoAccentTextColor = Color.Empty
        BtnUpdate.Size = New Size(144, 36)
        BtnUpdate.TabIndex = 19
        BtnUpdate.Text = "          Actualizar         "
        BtnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnUpdate.UseAccentColor = False
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(TxtName)
        MaterialCard1.Controls.Add(lblNameFrmUser)
        MaterialCard1.Controls.Add(lblEmailFrmUser)
        MaterialCard1.Controls.Add(TxtEmail)
        MaterialCard1.Controls.Add(CbxRole)
        MaterialCard1.Controls.Add(BtnNewUser)
        MaterialCard1.Controls.Add(lblRole)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(48, 443)
        MaterialCard1.Margin = New Padding(14, 15, 14, 15)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14, 15, 14, 15)
        MaterialCard1.Size = New Size(362, 404)
        MaterialCard1.TabIndex = 20
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Controls.Add(BtnSearchName)
        MaterialCard2.Controls.Add(TxtNameToSearch)
        MaterialCard2.Controls.Add(MaterialLabel1)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(48, 68)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(14)
        MaterialCard2.Size = New Size(338, 170)
        MaterialCard2.TabIndex = 22
        ' 
        ' BtnSearchName
        ' 
        BtnSearchName.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnSearchName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnSearchName.Depth = 0
        BtnSearchName.HighEmphasis = True
        BtnSearchName.Icon = Nothing
        BtnSearchName.Location = New Point(17, 114)
        BtnSearchName.Margin = New Padding(4, 6, 4, 6)
        BtnSearchName.MouseState = MaterialSkin.MouseState.HOVER
        BtnSearchName.Name = "BtnSearchName"
        BtnSearchName.NoAccentTextColor = Color.Empty
        BtnSearchName.Size = New Size(77, 36)
        BtnSearchName.TabIndex = 24
        BtnSearchName.Text = "Buscar"
        BtnSearchName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnSearchName.UseAccentColor = False
        BtnSearchName.UseVisualStyleBackColor = True
        ' 
        ' TxtNameToSearch
        ' 
        TxtNameToSearch.AllowPromptAsInput = True
        TxtNameToSearch.AnimateReadOnly = False
        TxtNameToSearch.AsciiOnly = False
        TxtNameToSearch.BackgroundImageLayout = ImageLayout.None
        TxtNameToSearch.BeepOnError = False
        TxtNameToSearch.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        TxtNameToSearch.Depth = 0
        TxtNameToSearch.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtNameToSearch.HidePromptOnLeave = False
        TxtNameToSearch.HideSelection = True
        TxtNameToSearch.InsertKeyMode = InsertKeyMode.Default
        TxtNameToSearch.LeadingIcon = Nothing
        TxtNameToSearch.Location = New Point(17, 42)
        TxtNameToSearch.Mask = ""
        TxtNameToSearch.MaxLength = 32767
        TxtNameToSearch.MouseState = MaterialSkin.MouseState.OUT
        TxtNameToSearch.Name = "TxtNameToSearch"
        TxtNameToSearch.PasswordChar = ChrW(0)
        TxtNameToSearch.PrefixSuffixText = Nothing
        TxtNameToSearch.PromptChar = "_"c
        TxtNameToSearch.ReadOnly = False
        TxtNameToSearch.RejectInputOnFirstFailure = False
        TxtNameToSearch.ResetOnPrompt = True
        TxtNameToSearch.ResetOnSpace = True
        TxtNameToSearch.RightToLeft = RightToLeft.No
        TxtNameToSearch.SelectedText = ""
        TxtNameToSearch.SelectionLength = 0
        TxtNameToSearch.SelectionStart = 0
        TxtNameToSearch.ShortcutsEnabled = True
        TxtNameToSearch.Size = New Size(250, 48)
        TxtNameToSearch.SkipLiterals = True
        TxtNameToSearch.TabIndex = 12
        TxtNameToSearch.TabStop = False
        TxtNameToSearch.TextAlign = HorizontalAlignment.Left
        TxtNameToSearch.TextMaskFormat = MaskFormat.IncludeLiterals
        TxtNameToSearch.TrailingIcon = Nothing
        TxtNameToSearch.UseSystemPasswordChar = False
        TxtNameToSearch.ValidatingType = Nothing
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(17, 18)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(69, 19)
        MaterialLabel1.TabIndex = 11
        MaterialLabel1.Text = "Nombre : "
        ' 
        ' BtnSearchConected
        ' 
        BtnSearchConected.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnSearchConected.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnSearchConected.Depth = 0
        BtnSearchConected.HighEmphasis = True
        BtnSearchConected.Icon = Nothing
        BtnSearchConected.Location = New Point(48, 311)
        BtnSearchConected.Margin = New Padding(4, 6, 4, 6)
        BtnSearchConected.MouseState = MaterialSkin.MouseState.HOVER
        BtnSearchConected.Name = "BtnSearchConected"
        BtnSearchConected.NoAccentTextColor = Color.Empty
        BtnSearchConected.Size = New Size(189, 36)
        BtnSearchConected.TabIndex = 24
        BtnSearchConected.Text = "Conectados este Mes"
        BtnSearchConected.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnSearchConected.UseAccentColor = False
        BtnSearchConected.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard3
        ' 
        MaterialCard3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard3.Controls.Add(BtnSearchDates)
        MaterialCard3.Controls.Add(lblto)
        MaterialCard3.Controls.Add(DtpTo)
        MaterialCard3.Controls.Add(MaterialLabel2)
        MaterialCard3.Controls.Add(DtpFrom)
        MaterialCard3.Depth = 0
        MaterialCard3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard3.Location = New Point(682, 68)
        MaterialCard3.Margin = New Padding(14)
        MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard3.Name = "MaterialCard3"
        MaterialCard3.Padding = New Padding(14)
        MaterialCard3.Size = New Size(772, 132)
        MaterialCard3.TabIndex = 25
        ' 
        ' BtnSearchDates
        ' 
        BtnSearchDates.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnSearchDates.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnSearchDates.Depth = 0
        BtnSearchDates.HighEmphasis = True
        BtnSearchDates.Icon = Nothing
        BtnSearchDates.Location = New Point(655, 48)
        BtnSearchDates.Margin = New Padding(4, 6, 4, 6)
        BtnSearchDates.MouseState = MaterialSkin.MouseState.HOVER
        BtnSearchDates.Name = "BtnSearchDates"
        BtnSearchDates.NoAccentTextColor = Color.Empty
        BtnSearchDates.Size = New Size(77, 36)
        BtnSearchDates.TabIndex = 25
        BtnSearchDates.Text = "Buscar"
        BtnSearchDates.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnSearchDates.UseAccentColor = False
        BtnSearchDates.UseVisualStyleBackColor = True
        ' 
        ' lblto
        ' 
        lblto.AutoSize = True
        lblto.Depth = 0
        lblto.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblto.Location = New Point(352, 31)
        lblto.MouseState = MaterialSkin.MouseState.HOVER
        lblto.Name = "lblto"
        lblto.Size = New Size(57, 19)
        lblto.TabIndex = 3
        lblto.Text = "Fecha 2"
        ' 
        ' DtpTo
        ' 
        DtpTo.Location = New Point(352, 53)
        DtpTo.Name = "DtpTo"
        DtpTo.Size = New Size(246, 23)
        DtpTo.TabIndex = 2
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(17, 31)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(57, 19)
        MaterialLabel2.TabIndex = 1
        MaterialLabel2.Text = "Fecha 1"
        ' 
        ' DtpFrom
        ' 
        DtpFrom.Location = New Point(17, 53)
        DtpFrom.Name = "DtpFrom"
        DtpFrom.Size = New Size(246, 23)
        DtpFrom.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(682, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(288, 36)
        Label3.TabIndex = 26
        Label3.Text = "Creados entre 2 Fechas"
        ' 
        ' BtnDeleteFilters
        ' 
        BtnDeleteFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnDeleteFilters.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnDeleteFilters.Depth = 0
        BtnDeleteFilters.HighEmphasis = True
        BtnDeleteFilters.Icon = Nothing
        BtnDeleteFilters.Location = New Point(1517, 188)
        BtnDeleteFilters.Margin = New Padding(4, 6, 4, 6)
        BtnDeleteFilters.MouseState = MaterialSkin.MouseState.HOVER
        BtnDeleteFilters.Name = "BtnDeleteFilters"
        BtnDeleteFilters.NoAccentTextColor = Color.Empty
        BtnDeleteFilters.Size = New Size(139, 36)
        BtnDeleteFilters.TabIndex = 27
        BtnDeleteFilters.Text = "Borrar Filtros"
        BtnDeleteFilters.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnDeleteFilters.UseAccentColor = False
        BtnDeleteFilters.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(48, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(244, 36)
        Label2.TabIndex = 23
        Label2.Text = "Buscar por Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(48, 402)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 36)
        Label1.TabIndex = 21
        Label1.Text = "Crear Usuario"
        ' 
        ' UsersPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BtnDeleteFilters)
        Controls.Add(Label3)
        Controls.Add(MaterialCard3)
        Controls.Add(BtnSearchConected)
        Controls.Add(Label2)
        Controls.Add(MaterialCard2)
        Controls.Add(Label1)
        Controls.Add(MaterialCard1)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnResetPassword)
        Controls.Add(BtnDeleteUser)
        Controls.Add(DgvUsers)
        Font = New Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "UsersPage"
        Size = New Size(1684, 928)
        CType(DgvUsers, ComponentModel.ISupportInitialize).EndInit()
        MaterialCard1.ResumeLayout(False)
        MaterialCard1.PerformLayout()
        MaterialCard2.ResumeLayout(False)
        MaterialCard2.PerformLayout()
        MaterialCard3.ResumeLayout(False)
        MaterialCard3.PerformLayout()
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
    Friend WithEvents BtnDeleteUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnResetPassword As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents BtnSearchName As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TxtNameToSearch As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BtnSearchConected As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents BtnSearchDates As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblto As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DtpTo As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DtpFrom As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDeleteFilters As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
