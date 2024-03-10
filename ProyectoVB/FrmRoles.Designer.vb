<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoles
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
        btnAceptarFrmRoles = New MaterialSkin.Controls.MaterialButton()
        lblNameFrmRole = New MaterialSkin.Controls.MaterialLabel()
        txtNameFrmRoles = New MaterialSkin.Controls.MaterialMaskedTextBox()
        lblDescriptionFrmRole = New MaterialSkin.Controls.MaterialLabel()
        txtDescriptionFrmRoles = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        lblSelect = New MaterialSkin.Controls.MaterialLabel()
        chkPermisos = New CheckedListBox()
        lblRolFrmRoles = New MaterialSkin.Controls.MaterialLabel()
        chkRol = New CheckedListBox()
        SuspendLayout()
        ' 
        ' btnAceptarFrmRoles
        ' 
        btnAceptarFrmRoles.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAceptarFrmRoles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAceptarFrmRoles.Depth = 0
        btnAceptarFrmRoles.HighEmphasis = True
        btnAceptarFrmRoles.Icon = Nothing
        btnAceptarFrmRoles.Location = New Point(442, 359)
        btnAceptarFrmRoles.Margin = New Padding(4, 6, 4, 6)
        btnAceptarFrmRoles.MouseState = MaterialSkin.MouseState.HOVER
        btnAceptarFrmRoles.Name = "btnAceptarFrmRoles"
        btnAceptarFrmRoles.NoAccentTextColor = Color.Empty
        btnAceptarFrmRoles.Size = New Size(86, 36)
        btnAceptarFrmRoles.TabIndex = 1
        btnAceptarFrmRoles.Text = "Aceptar"
        btnAceptarFrmRoles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnAceptarFrmRoles.UseAccentColor = False
        btnAceptarFrmRoles.UseVisualStyleBackColor = True
        ' 
        ' lblNameFrmRole
        ' 
        lblNameFrmRole.AutoSize = True
        lblNameFrmRole.Depth = 0
        lblNameFrmRole.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNameFrmRole.Location = New Point(40, 109)
        lblNameFrmRole.MouseState = MaterialSkin.MouseState.HOVER
        lblNameFrmRole.Name = "lblNameFrmRole"
        lblNameFrmRole.Size = New Size(65, 19)
        lblNameFrmRole.TabIndex = 3
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
        txtNameFrmRoles.Location = New Point(40, 132)
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
        txtNameFrmRoles.TabIndex = 4
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
        lblDescriptionFrmRole.Location = New Point(40, 207)
        lblDescriptionFrmRole.MouseState = MaterialSkin.MouseState.HOVER
        lblDescriptionFrmRole.Name = "lblDescriptionFrmRole"
        lblDescriptionFrmRole.Size = New Size(80, 19)
        lblDescriptionFrmRole.TabIndex = 6
        lblDescriptionFrmRole.Text = "Decripcion:"
        ' 
        ' txtDescriptionFrmRoles
        ' 
        txtDescriptionFrmRoles.AnimateReadOnly = False
        txtDescriptionFrmRoles.BackgroundImageLayout = ImageLayout.None
        txtDescriptionFrmRoles.CharacterCasing = CharacterCasing.Normal
        txtDescriptionFrmRoles.Depth = 0
        txtDescriptionFrmRoles.HideSelection = True
        txtDescriptionFrmRoles.Location = New Point(40, 229)
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
        txtDescriptionFrmRoles.TabIndex = 7
        txtDescriptionFrmRoles.TabStop = False
        txtDescriptionFrmRoles.TextAlign = HorizontalAlignment.Left
        txtDescriptionFrmRoles.UseSystemPasswordChar = False
        ' 
        ' lblSelect
        ' 
        lblSelect.AutoSize = True
        lblSelect.Depth = 0
        lblSelect.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblSelect.Location = New Point(524, 121)
        lblSelect.MouseState = MaterialSkin.MouseState.HOVER
        lblSelect.Name = "lblSelect"
        lblSelect.Size = New Size(155, 19)
        lblSelect.TabIndex = 11
        lblSelect.Text = "Selecciona permisos: "
        ' 
        ' chkPermisos
        ' 
        chkPermisos.FormattingEnabled = True
        chkPermisos.Items.AddRange(New Object() {"CREAR USUARIOS", "LEER USUARIOS", "ACTUALIZAR USUARIOS", "ELIMINAR USUARIOS"})
        chkPermisos.Location = New Point(524, 152)
        chkPermisos.Name = "chkPermisos"
        chkPermisos.Size = New Size(180, 166)
        chkPermisos.TabIndex = 12
        ' 
        ' lblRolFrmRoles
        ' 
        lblRolFrmRoles.AutoSize = True
        lblRolFrmRoles.Depth = 0
        lblRolFrmRoles.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblRolFrmRoles.Location = New Point(312, 121)
        lblRolFrmRoles.MouseState = MaterialSkin.MouseState.HOVER
        lblRolFrmRoles.Name = "lblRolFrmRoles"
        lblRolFrmRoles.Size = New Size(120, 19)
        lblRolFrmRoles.TabIndex = 13
        lblRolFrmRoles.Text = "Selecciona el rol:"
        ' 
        ' chkRol
        ' 
        chkRol.FormattingEnabled = True
        chkRol.Items.AddRange(New Object() {"USER", "ADMIN", "MODERADOR"})
        chkRol.Location = New Point(312, 152)
        chkRol.Name = "chkRol"
        chkRol.Size = New Size(180, 166)
        chkRol.TabIndex = 14
        ' 
        ' FrmRoles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(chkRol)
        Controls.Add(lblRolFrmRoles)
        Controls.Add(chkPermisos)
        Controls.Add(lblSelect)
        Controls.Add(txtDescriptionFrmRoles)
        Controls.Add(lblDescriptionFrmRole)
        Controls.Add(txtNameFrmRoles)
        Controls.Add(lblNameFrmRole)
        Controls.Add(btnAceptarFrmRoles)
        Name = "FrmRoles"
        Text = "FrmRoles"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnAceptarFrmRoles As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblNameFrmRole As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNameFrmRoles As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents lblDescriptionFrmRole As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtDescriptionFrmRoles As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents lblSelect As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents chkPermisos As CheckedListBox
    Friend WithEvents lblRolFrmRoles As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents chkRol As CheckedListBox
End Class
