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
        MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        TabPage1 = New TabPage()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        txtPassword = New MaterialSkin.Controls.MaterialMaskedTextBox()
        txtEmail = New MaterialSkin.Controls.MaterialMaskedTextBox()
        txtNombre = New MaterialSkin.Controls.MaterialMaskedTextBox()
        btnAceptar = New MaterialSkin.Controls.MaterialButton()
        lblPassword = New MaterialSkin.Controls.MaterialLabel()
        lblEmail = New MaterialSkin.Controls.MaterialLabel()
        lblNombre = New MaterialSkin.Controls.MaterialLabel()
        TabPage2 = New TabPage()
        MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        btnAceptarRoles = New MaterialSkin.Controls.MaterialButton()
        txtDescription = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        MaterialMaskedTextBox1 = New MaterialSkin.Controls.MaterialMaskedTextBox()
        txtIdRole = New MaterialSkin.Controls.MaterialMaskedTextBox()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        lblIdRol = New MaterialSkin.Controls.MaterialLabel()
        TabPage3 = New TabPage()
        MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        btnAceptarPermisos = New MaterialSkin.Controls.MaterialButton()
        txtIdPermisosPermisos = New MaterialSkin.Controls.MaterialMaskedTextBox()
        txtIdRolePermisos = New MaterialSkin.Controls.MaterialMaskedTextBox()
        txtIdPermisos = New MaterialSkin.Controls.MaterialMaskedTextBox()
        MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        lblIdRolePermisos = New MaterialSkin.Controls.MaterialLabel()
        lblIdPermisos = New MaterialSkin.Controls.MaterialLabel()
        TabPage4 = New TabPage()
        MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        MaterialCheckedListBox1 = New MaterialSkin.Controls.MaterialCheckedListBox()
        ListboxUsuariosEliminados = New MaterialSkin.Controls.MaterialLabel()
        MaterialTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        MaterialCard1.SuspendLayout()
        TabPage2.SuspendLayout()
        MaterialCard2.SuspendLayout()
        TabPage3.SuspendLayout()
        MaterialCard3.SuspendLayout()
        TabPage4.SuspendLayout()
        MaterialCard4.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialTabControl1
        ' 
        MaterialTabControl1.Controls.Add(TabPage1)
        MaterialTabControl1.Controls.Add(TabPage2)
        MaterialTabControl1.Controls.Add(TabPage3)
        MaterialTabControl1.Controls.Add(TabPage4)
        MaterialTabControl1.Depth = 0
        MaterialTabControl1.Dock = DockStyle.Fill
        MaterialTabControl1.Location = New Point(3, 64)
        MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabControl1.Multiline = True
        MaterialTabControl1.Name = "MaterialTabControl1"
        MaterialTabControl1.SelectedIndex = 0
        MaterialTabControl1.Size = New Size(986, 574)
        MaterialTabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(MaterialCard1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(978, 546)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Usuarios"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(txtPassword)
        MaterialCard1.Controls.Add(txtEmail)
        MaterialCard1.Controls.Add(txtNombre)
        MaterialCard1.Controls.Add(btnAceptar)
        MaterialCard1.Controls.Add(lblPassword)
        MaterialCard1.Controls.Add(lblEmail)
        MaterialCard1.Controls.Add(lblNombre)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(184, 17)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(660, 450)
        MaterialCard1.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.AllowPromptAsInput = True
        txtPassword.AnimateReadOnly = False
        txtPassword.AsciiOnly = False
        txtPassword.BackgroundImageLayout = ImageLayout.None
        txtPassword.BeepOnError = False
        txtPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtPassword.Depth = 0
        txtPassword.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtPassword.HidePromptOnLeave = False
        txtPassword.HideSelection = True
        txtPassword.InsertKeyMode = InsertKeyMode.Default
        txtPassword.LeadingIcon = Nothing
        txtPassword.Location = New Point(31, 241)
        txtPassword.Mask = ""
        txtPassword.MaxLength = 32767
        txtPassword.MouseState = MaterialSkin.MouseState.OUT
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = ChrW(0)
        txtPassword.PrefixSuffixText = Nothing
        txtPassword.PromptChar = "_"c
        txtPassword.ReadOnly = False
        txtPassword.RejectInputOnFirstFailure = False
        txtPassword.ResetOnPrompt = True
        txtPassword.ResetOnSpace = True
        txtPassword.RightToLeft = RightToLeft.No
        txtPassword.SelectedText = ""
        txtPassword.SelectionLength = 0
        txtPassword.SelectionStart = 0
        txtPassword.ShortcutsEnabled = True
        txtPassword.Size = New Size(250, 48)
        txtPassword.SkipLiterals = True
        txtPassword.TabIndex = 7
        txtPassword.TabStop = False
        txtPassword.TextAlign = HorizontalAlignment.Left
        txtPassword.TextMaskFormat = MaskFormat.IncludeLiterals
        txtPassword.TrailingIcon = Nothing
        txtPassword.UseSystemPasswordChar = False
        txtPassword.ValidatingType = Nothing
        ' 
        ' txtEmail
        ' 
        txtEmail.AllowPromptAsInput = True
        txtEmail.AnimateReadOnly = False
        txtEmail.AsciiOnly = False
        txtEmail.BackgroundImageLayout = ImageLayout.None
        txtEmail.BeepOnError = False
        txtEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtEmail.Depth = 0
        txtEmail.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtEmail.HidePromptOnLeave = False
        txtEmail.HideSelection = True
        txtEmail.InsertKeyMode = InsertKeyMode.Default
        txtEmail.LeadingIcon = Nothing
        txtEmail.Location = New Point(31, 149)
        txtEmail.Mask = ""
        txtEmail.MaxLength = 32767
        txtEmail.MouseState = MaterialSkin.MouseState.OUT
        txtEmail.Name = "txtEmail"
        txtEmail.PasswordChar = ChrW(0)
        txtEmail.PrefixSuffixText = Nothing
        txtEmail.PromptChar = "_"c
        txtEmail.ReadOnly = False
        txtEmail.RejectInputOnFirstFailure = False
        txtEmail.ResetOnPrompt = True
        txtEmail.ResetOnSpace = True
        txtEmail.RightToLeft = RightToLeft.No
        txtEmail.SelectedText = ""
        txtEmail.SelectionLength = 0
        txtEmail.SelectionStart = 0
        txtEmail.ShortcutsEnabled = True
        txtEmail.Size = New Size(250, 48)
        txtEmail.SkipLiterals = True
        txtEmail.TabIndex = 6
        txtEmail.TabStop = False
        txtEmail.TextAlign = HorizontalAlignment.Left
        txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals
        txtEmail.TrailingIcon = Nothing
        txtEmail.UseSystemPasswordChar = False
        txtEmail.ValidatingType = Nothing
        ' 
        ' txtNombre
        ' 
        txtNombre.AllowPromptAsInput = True
        txtNombre.AnimateReadOnly = False
        txtNombre.AsciiOnly = False
        txtNombre.BackgroundImageLayout = ImageLayout.None
        txtNombre.BeepOnError = False
        txtNombre.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtNombre.Depth = 0
        txtNombre.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNombre.HidePromptOnLeave = False
        txtNombre.HideSelection = True
        txtNombre.InsertKeyMode = InsertKeyMode.Default
        txtNombre.LeadingIcon = Nothing
        txtNombre.Location = New Point(31, 52)
        txtNombre.Mask = ""
        txtNombre.MaxLength = 32767
        txtNombre.MouseState = MaterialSkin.MouseState.OUT
        txtNombre.Name = "txtNombre"
        txtNombre.PasswordChar = ChrW(0)
        txtNombre.PrefixSuffixText = Nothing
        txtNombre.PromptChar = "_"c
        txtNombre.ReadOnly = False
        txtNombre.RejectInputOnFirstFailure = False
        txtNombre.ResetOnPrompt = True
        txtNombre.ResetOnSpace = True
        txtNombre.RightToLeft = RightToLeft.No
        txtNombre.SelectedText = ""
        txtNombre.SelectionLength = 0
        txtNombre.SelectionStart = 0
        txtNombre.ShortcutsEnabled = True
        txtNombre.Size = New Size(250, 48)
        txtNombre.SkipLiterals = True
        txtNombre.TabIndex = 5
        txtNombre.TabStop = False
        txtNombre.TextAlign = HorizontalAlignment.Left
        txtNombre.TextMaskFormat = MaskFormat.IncludeLiterals
        txtNombre.TrailingIcon = Nothing
        txtNombre.UseSystemPasswordChar = False
        txtNombre.ValidatingType = Nothing
        ' 
        ' btnAceptar
        ' 
        btnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAceptar.Depth = 0
        btnAceptar.HighEmphasis = True
        btnAceptar.Icon = Nothing
        btnAceptar.Location = New Point(266, 394)
        btnAceptar.Margin = New Padding(4, 6, 4, 6)
        btnAceptar.MouseState = MaterialSkin.MouseState.HOVER
        btnAceptar.Name = "btnAceptar"
        btnAceptar.NoAccentTextColor = Color.Empty
        btnAceptar.Size = New Size(87, 36)
        btnAceptar.TabIndex = 4
        btnAceptar.Text = "Acaptar"
        btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnAceptar.UseAccentColor = False
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Depth = 0
        lblPassword.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblPassword.Location = New Point(31, 219)
        lblPassword.MouseState = MaterialSkin.MouseState.HOVER
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(90, 19)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Contraseña: "
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Depth = 0
        lblEmail.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblEmail.Location = New Point(31, 127)
        lblEmail.MouseState = MaterialSkin.MouseState.HOVER
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(49, 19)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email: "
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Depth = 0
        lblNombre.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNombre.Location = New Point(31, 30)
        lblNombre.MouseState = MaterialSkin.MouseState.HOVER
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(65, 19)
        lblNombre.TabIndex = 0
        lblNombre.Text = "Nombre: "
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(MaterialCard2)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(978, 546)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Roles"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Controls.Add(btnAceptarRoles)
        MaterialCard2.Controls.Add(txtDescription)
        MaterialCard2.Controls.Add(MaterialMaskedTextBox1)
        MaterialCard2.Controls.Add(txtIdRole)
        MaterialCard2.Controls.Add(MaterialLabel3)
        MaterialCard2.Controls.Add(MaterialLabel2)
        MaterialCard2.Controls.Add(lblIdRol)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(168, 17)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(14)
        MaterialCard2.Size = New Size(645, 435)
        MaterialCard2.TabIndex = 0
        ' 
        ' btnAceptarRoles
        ' 
        btnAceptarRoles.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAceptarRoles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAceptarRoles.Depth = 0
        btnAceptarRoles.HighEmphasis = True
        btnAceptarRoles.Icon = Nothing
        btnAceptarRoles.Location = New Point(410, 346)
        btnAceptarRoles.Margin = New Padding(4, 6, 4, 6)
        btnAceptarRoles.MouseState = MaterialSkin.MouseState.HOVER
        btnAceptarRoles.Name = "btnAceptarRoles"
        btnAceptarRoles.NoAccentTextColor = Color.Empty
        btnAceptarRoles.Size = New Size(86, 36)
        btnAceptarRoles.TabIndex = 7
        btnAceptarRoles.Text = "Aceptar"
        btnAceptarRoles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnAceptarRoles.UseAccentColor = False
        btnAceptarRoles.UseVisualStyleBackColor = True
        ' 
        ' txtDescription
        ' 
        txtDescription.AnimateReadOnly = False
        txtDescription.BackgroundImageLayout = ImageLayout.None
        txtDescription.CharacterCasing = CharacterCasing.Normal
        txtDescription.Depth = 0
        txtDescription.HideSelection = True
        txtDescription.Location = New Point(52, 282)
        txtDescription.MaxLength = 32767
        txtDescription.MouseState = MaterialSkin.MouseState.OUT
        txtDescription.Name = "txtDescription"
        txtDescription.PasswordChar = ChrW(0)
        txtDescription.ReadOnly = False
        txtDescription.ScrollBars = ScrollBars.None
        txtDescription.SelectedText = ""
        txtDescription.SelectionLength = 0
        txtDescription.SelectionStart = 0
        txtDescription.ShortcutsEnabled = True
        txtDescription.Size = New Size(250, 100)
        txtDescription.TabIndex = 6
        txtDescription.TabStop = False
        txtDescription.TextAlign = HorizontalAlignment.Left
        txtDescription.UseSystemPasswordChar = False
        ' 
        ' MaterialMaskedTextBox1
        ' 
        MaterialMaskedTextBox1.AllowPromptAsInput = True
        MaterialMaskedTextBox1.AnimateReadOnly = False
        MaterialMaskedTextBox1.AsciiOnly = False
        MaterialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None
        MaterialMaskedTextBox1.BeepOnError = False
        MaterialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        MaterialMaskedTextBox1.Depth = 0
        MaterialMaskedTextBox1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialMaskedTextBox1.HidePromptOnLeave = False
        MaterialMaskedTextBox1.HideSelection = True
        MaterialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default
        MaterialMaskedTextBox1.LeadingIcon = Nothing
        MaterialMaskedTextBox1.Location = New Point(52, 177)
        MaterialMaskedTextBox1.Mask = ""
        MaterialMaskedTextBox1.MaxLength = 32767
        MaterialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialMaskedTextBox1.Name = "MaterialMaskedTextBox1"
        MaterialMaskedTextBox1.PasswordChar = ChrW(0)
        MaterialMaskedTextBox1.PrefixSuffixText = Nothing
        MaterialMaskedTextBox1.PromptChar = "_"c
        MaterialMaskedTextBox1.ReadOnly = False
        MaterialMaskedTextBox1.RejectInputOnFirstFailure = False
        MaterialMaskedTextBox1.ResetOnPrompt = True
        MaterialMaskedTextBox1.ResetOnSpace = True
        MaterialMaskedTextBox1.RightToLeft = RightToLeft.No
        MaterialMaskedTextBox1.SelectedText = ""
        MaterialMaskedTextBox1.SelectionLength = 0
        MaterialMaskedTextBox1.SelectionStart = 0
        MaterialMaskedTextBox1.ShortcutsEnabled = True
        MaterialMaskedTextBox1.Size = New Size(250, 48)
        MaterialMaskedTextBox1.SkipLiterals = True
        MaterialMaskedTextBox1.TabIndex = 5
        MaterialMaskedTextBox1.TabStop = False
        MaterialMaskedTextBox1.TextAlign = HorizontalAlignment.Left
        MaterialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals
        MaterialMaskedTextBox1.TrailingIcon = Nothing
        MaterialMaskedTextBox1.UseSystemPasswordChar = False
        MaterialMaskedTextBox1.ValidatingType = Nothing
        ' 
        ' txtIdRole
        ' 
        txtIdRole.AllowPromptAsInput = True
        txtIdRole.AnimateReadOnly = False
        txtIdRole.AsciiOnly = False
        txtIdRole.BackgroundImageLayout = ImageLayout.None
        txtIdRole.BeepOnError = False
        txtIdRole.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtIdRole.Depth = 0
        txtIdRole.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtIdRole.HidePromptOnLeave = False
        txtIdRole.HideSelection = True
        txtIdRole.InsertKeyMode = InsertKeyMode.Default
        txtIdRole.LeadingIcon = Nothing
        txtIdRole.Location = New Point(52, 74)
        txtIdRole.Mask = ""
        txtIdRole.MaxLength = 32767
        txtIdRole.MouseState = MaterialSkin.MouseState.OUT
        txtIdRole.Name = "txtIdRole"
        txtIdRole.PasswordChar = ChrW(0)
        txtIdRole.PrefixSuffixText = Nothing
        txtIdRole.PromptChar = "_"c
        txtIdRole.ReadOnly = False
        txtIdRole.RejectInputOnFirstFailure = False
        txtIdRole.ResetOnPrompt = True
        txtIdRole.ResetOnSpace = True
        txtIdRole.RightToLeft = RightToLeft.No
        txtIdRole.SelectedText = ""
        txtIdRole.SelectionLength = 0
        txtIdRole.SelectionStart = 0
        txtIdRole.ShortcutsEnabled = True
        txtIdRole.Size = New Size(250, 48)
        txtIdRole.SkipLiterals = True
        txtIdRole.TabIndex = 4
        txtIdRole.TabStop = False
        txtIdRole.TextAlign = HorizontalAlignment.Left
        txtIdRole.TextMaskFormat = MaskFormat.IncludeLiterals
        txtIdRole.TrailingIcon = Nothing
        txtIdRole.UseSystemPasswordChar = False
        txtIdRole.ValidatingType = Nothing
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(52, 250)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(84, 19)
        MaterialLabel3.TabIndex = 3
        MaterialLabel3.Text = "Decripcion: "
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(52, 155)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(65, 19)
        MaterialLabel2.TabIndex = 2
        MaterialLabel2.Text = "Nombre: "
        ' 
        ' lblIdRol
        ' 
        lblIdRol.AutoSize = True
        lblIdRol.Depth = 0
        lblIdRol.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblIdRol.Location = New Point(52, 52)
        lblIdRol.MouseState = MaterialSkin.MouseState.HOVER
        lblIdRol.Name = "lblIdRol"
        lblIdRol.Size = New Size(22, 19)
        lblIdRol.TabIndex = 1
        lblIdRol.Text = "id: "
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(MaterialCard3)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(978, 546)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Permisos"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard3
        ' 
        MaterialCard3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard3.Controls.Add(btnAceptarPermisos)
        MaterialCard3.Controls.Add(txtIdPermisosPermisos)
        MaterialCard3.Controls.Add(txtIdRolePermisos)
        MaterialCard3.Controls.Add(txtIdPermisos)
        MaterialCard3.Controls.Add(MaterialLabel5)
        MaterialCard3.Controls.Add(lblIdRolePermisos)
        MaterialCard3.Controls.Add(lblIdPermisos)
        MaterialCard3.Depth = 0
        MaterialCard3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard3.Location = New Point(161, 17)
        MaterialCard3.Margin = New Padding(14)
        MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard3.Name = "MaterialCard3"
        MaterialCard3.Padding = New Padding(14)
        MaterialCard3.Size = New Size(645, 435)
        MaterialCard3.TabIndex = 1
        ' 
        ' btnAceptarPermisos
        ' 
        btnAceptarPermisos.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAceptarPermisos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAceptarPermisos.Depth = 0
        btnAceptarPermisos.HighEmphasis = True
        btnAceptarPermisos.Icon = Nothing
        btnAceptarPermisos.Location = New Point(254, 353)
        btnAceptarPermisos.Margin = New Padding(4, 6, 4, 6)
        btnAceptarPermisos.MouseState = MaterialSkin.MouseState.HOVER
        btnAceptarPermisos.Name = "btnAceptarPermisos"
        btnAceptarPermisos.NoAccentTextColor = Color.Empty
        btnAceptarPermisos.Size = New Size(86, 36)
        btnAceptarPermisos.TabIndex = 6
        btnAceptarPermisos.Text = "Aceptar"
        btnAceptarPermisos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnAceptarPermisos.UseAccentColor = False
        btnAceptarPermisos.UseVisualStyleBackColor = True
        ' 
        ' txtIdPermisosPermisos
        ' 
        txtIdPermisosPermisos.AllowPromptAsInput = True
        txtIdPermisosPermisos.AnimateReadOnly = False
        txtIdPermisosPermisos.AsciiOnly = False
        txtIdPermisosPermisos.BackgroundImageLayout = ImageLayout.None
        txtIdPermisosPermisos.BeepOnError = False
        txtIdPermisosPermisos.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtIdPermisosPermisos.Depth = 0
        txtIdPermisosPermisos.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtIdPermisosPermisos.HidePromptOnLeave = False
        txtIdPermisosPermisos.HideSelection = True
        txtIdPermisosPermisos.InsertKeyMode = InsertKeyMode.Default
        txtIdPermisosPermisos.LeadingIcon = Nothing
        txtIdPermisosPermisos.Location = New Point(51, 241)
        txtIdPermisosPermisos.Mask = ""
        txtIdPermisosPermisos.MaxLength = 32767
        txtIdPermisosPermisos.MouseState = MaterialSkin.MouseState.OUT
        txtIdPermisosPermisos.Name = "txtIdPermisosPermisos"
        txtIdPermisosPermisos.PasswordChar = ChrW(0)
        txtIdPermisosPermisos.PrefixSuffixText = Nothing
        txtIdPermisosPermisos.PromptChar = "_"c
        txtIdPermisosPermisos.ReadOnly = False
        txtIdPermisosPermisos.RejectInputOnFirstFailure = False
        txtIdPermisosPermisos.ResetOnPrompt = True
        txtIdPermisosPermisos.ResetOnSpace = True
        txtIdPermisosPermisos.RightToLeft = RightToLeft.No
        txtIdPermisosPermisos.SelectedText = ""
        txtIdPermisosPermisos.SelectionLength = 0
        txtIdPermisosPermisos.SelectionStart = 0
        txtIdPermisosPermisos.ShortcutsEnabled = True
        txtIdPermisosPermisos.Size = New Size(250, 48)
        txtIdPermisosPermisos.SkipLiterals = True
        txtIdPermisosPermisos.TabIndex = 5
        txtIdPermisosPermisos.TabStop = False
        txtIdPermisosPermisos.TextAlign = HorizontalAlignment.Left
        txtIdPermisosPermisos.TextMaskFormat = MaskFormat.IncludeLiterals
        txtIdPermisosPermisos.TrailingIcon = Nothing
        txtIdPermisosPermisos.UseSystemPasswordChar = False
        txtIdPermisosPermisos.ValidatingType = Nothing
        ' 
        ' txtIdRolePermisos
        ' 
        txtIdRolePermisos.AllowPromptAsInput = True
        txtIdRolePermisos.AnimateReadOnly = False
        txtIdRolePermisos.AsciiOnly = False
        txtIdRolePermisos.BackgroundImageLayout = ImageLayout.None
        txtIdRolePermisos.BeepOnError = False
        txtIdRolePermisos.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtIdRolePermisos.Depth = 0
        txtIdRolePermisos.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtIdRolePermisos.HidePromptOnLeave = False
        txtIdRolePermisos.HideSelection = True
        txtIdRolePermisos.InsertKeyMode = InsertKeyMode.Default
        txtIdRolePermisos.LeadingIcon = Nothing
        txtIdRolePermisos.Location = New Point(51, 142)
        txtIdRolePermisos.Mask = ""
        txtIdRolePermisos.MaxLength = 32767
        txtIdRolePermisos.MouseState = MaterialSkin.MouseState.OUT
        txtIdRolePermisos.Name = "txtIdRolePermisos"
        txtIdRolePermisos.PasswordChar = ChrW(0)
        txtIdRolePermisos.PrefixSuffixText = Nothing
        txtIdRolePermisos.PromptChar = "_"c
        txtIdRolePermisos.ReadOnly = False
        txtIdRolePermisos.RejectInputOnFirstFailure = False
        txtIdRolePermisos.ResetOnPrompt = True
        txtIdRolePermisos.ResetOnSpace = True
        txtIdRolePermisos.RightToLeft = RightToLeft.No
        txtIdRolePermisos.SelectedText = ""
        txtIdRolePermisos.SelectionLength = 0
        txtIdRolePermisos.SelectionStart = 0
        txtIdRolePermisos.ShortcutsEnabled = True
        txtIdRolePermisos.Size = New Size(250, 48)
        txtIdRolePermisos.SkipLiterals = True
        txtIdRolePermisos.TabIndex = 4
        txtIdRolePermisos.TabStop = False
        txtIdRolePermisos.TextAlign = HorizontalAlignment.Left
        txtIdRolePermisos.TextMaskFormat = MaskFormat.IncludeLiterals
        txtIdRolePermisos.TrailingIcon = Nothing
        txtIdRolePermisos.UseSystemPasswordChar = False
        txtIdRolePermisos.ValidatingType = Nothing
        ' 
        ' txtIdPermisos
        ' 
        txtIdPermisos.AllowPromptAsInput = True
        txtIdPermisos.AnimateReadOnly = False
        txtIdPermisos.AsciiOnly = False
        txtIdPermisos.BackgroundImageLayout = ImageLayout.None
        txtIdPermisos.BeepOnError = False
        txtIdPermisos.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtIdPermisos.Depth = 0
        txtIdPermisos.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtIdPermisos.HidePromptOnLeave = False
        txtIdPermisos.HideSelection = True
        txtIdPermisos.InsertKeyMode = InsertKeyMode.Default
        txtIdPermisos.LeadingIcon = Nothing
        txtIdPermisos.Location = New Point(51, 45)
        txtIdPermisos.Mask = ""
        txtIdPermisos.MaxLength = 32767
        txtIdPermisos.MouseState = MaterialSkin.MouseState.OUT
        txtIdPermisos.Name = "txtIdPermisos"
        txtIdPermisos.PasswordChar = ChrW(0)
        txtIdPermisos.PrefixSuffixText = Nothing
        txtIdPermisos.PromptChar = "_"c
        txtIdPermisos.ReadOnly = False
        txtIdPermisos.RejectInputOnFirstFailure = False
        txtIdPermisos.ResetOnPrompt = True
        txtIdPermisos.ResetOnSpace = True
        txtIdPermisos.RightToLeft = RightToLeft.No
        txtIdPermisos.SelectedText = ""
        txtIdPermisos.SelectionLength = 0
        txtIdPermisos.SelectionStart = 0
        txtIdPermisos.ShortcutsEnabled = True
        txtIdPermisos.Size = New Size(250, 48)
        txtIdPermisos.SkipLiterals = True
        txtIdPermisos.TabIndex = 3
        txtIdPermisos.TabStop = False
        txtIdPermisos.TextAlign = HorizontalAlignment.Left
        txtIdPermisos.TextMaskFormat = MaskFormat.IncludeLiterals
        txtIdPermisos.TrailingIcon = Nothing
        txtIdPermisos.UseSystemPasswordChar = False
        txtIdPermisos.ValidatingType = Nothing
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel5.Location = New Point(51, 206)
        MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel5.Name = "MaterialLabel5"
        MaterialLabel5.Size = New Size(92, 19)
        MaterialLabel5.TabIndex = 2
        MaterialLabel5.Text = "Id Permisos: "
        ' 
        ' lblIdRolePermisos
        ' 
        lblIdRolePermisos.AutoSize = True
        lblIdRolePermisos.Depth = 0
        lblIdRolePermisos.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblIdRolePermisos.Location = New Point(51, 108)
        lblIdRolePermisos.MouseState = MaterialSkin.MouseState.HOVER
        lblIdRolePermisos.Name = "lblIdRolePermisos"
        lblIdRolePermisos.Size = New Size(49, 19)
        lblIdRolePermisos.TabIndex = 1
        lblIdRolePermisos.Text = "Id Rol: "
        ' 
        ' lblIdPermisos
        ' 
        lblIdPermisos.AutoSize = True
        lblIdPermisos.Depth = 0
        lblIdPermisos.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblIdPermisos.Location = New Point(51, 23)
        lblIdPermisos.MouseState = MaterialSkin.MouseState.HOVER
        lblIdPermisos.Name = "lblIdPermisos"
        lblIdPermisos.Size = New Size(22, 19)
        lblIdPermisos.TabIndex = 0
        lblIdPermisos.Text = "Id: "
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(MaterialCard4)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(978, 546)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Usuarios eliminados"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard4
        ' 
        MaterialCard4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard4.Controls.Add(ListboxUsuariosEliminados)
        MaterialCard4.Controls.Add(MaterialCheckedListBox1)
        MaterialCard4.Depth = 0
        MaterialCard4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard4.Location = New Point(168, 17)
        MaterialCard4.Margin = New Padding(14)
        MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard4.Name = "MaterialCard4"
        MaterialCard4.Padding = New Padding(14)
        MaterialCard4.Size = New Size(645, 435)
        MaterialCard4.TabIndex = 1
        ' 
        ' MaterialCheckedListBox1
        ' 
        MaterialCheckedListBox1.AutoScroll = True
        MaterialCheckedListBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCheckedListBox1.Depth = 0
        MaterialCheckedListBox1.Location = New Point(17, 85)
        MaterialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCheckedListBox1.Name = "MaterialCheckedListBox1"
        MaterialCheckedListBox1.Size = New Size(611, 318)
        MaterialCheckedListBox1.Striped = False
        MaterialCheckedListBox1.StripeDarkColor = Color.Empty
        MaterialCheckedListBox1.TabIndex = 0
        ' 
        ' ListboxUsuariosEliminados
        ' 
        ListboxUsuariosEliminados.AutoSize = True
        ListboxUsuariosEliminados.Depth = 0
        ListboxUsuariosEliminados.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        ListboxUsuariosEliminados.Location = New Point(21, 35)
        ListboxUsuariosEliminados.MouseState = MaterialSkin.MouseState.HOVER
        ListboxUsuariosEliminados.Name = "ListboxUsuariosEliminados"
        ListboxUsuariosEliminados.Size = New Size(145, 19)
        ListboxUsuariosEliminados.TabIndex = 1
        ListboxUsuariosEliminados.Text = "Usuarios eliminados"
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(992, 641)
        Controls.Add(MaterialTabControl1)
        DrawerTabControl = MaterialTabControl1
        Name = "FrmPrincipal"
        Text = "FrmPrincipal"
        MaterialTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        MaterialCard1.ResumeLayout(False)
        MaterialCard1.PerformLayout()
        TabPage2.ResumeLayout(False)
        MaterialCard2.ResumeLayout(False)
        MaterialCard2.PerformLayout()
        TabPage3.ResumeLayout(False)
        MaterialCard3.ResumeLayout(False)
        MaterialCard3.PerformLayout()
        TabPage4.ResumeLayout(False)
        MaterialCard4.ResumeLayout(False)
        MaterialCard4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPassword As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblEmail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNombre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNombre As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents btnAceptar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents txtEmail As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblIdRol As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtIdRole As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialMaskedTextBox1 As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents txtDescription As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents btnAceptarRoles As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblIdRolePermisos As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblIdPermisos As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtIdPermisos As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents txtIdRolePermisos As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents btnAceptarPermisos As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtIdPermisosPermisos As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialCheckedListBox1 As MaterialSkin.Controls.MaterialCheckedListBox
    Friend WithEvents ListboxUsuariosEliminados As MaterialSkin.Controls.MaterialLabel
End Class
