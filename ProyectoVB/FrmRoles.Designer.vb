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
        lblIdFrmRoles = New MaterialSkin.Controls.MaterialLabel()
        btnAceptarFrmRoles = New MaterialSkin.Controls.MaterialButton()
        txtIdFrmRoles = New MaterialSkin.Controls.MaterialMaskedTextBox()
        lblNameFrmRole = New MaterialSkin.Controls.MaterialLabel()
        txtNameFrmRoles = New MaterialSkin.Controls.MaterialMaskedTextBox()
        lblDescriptionFrmRole = New MaterialSkin.Controls.MaterialLabel()
        txtDescriptionFrmRoles = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        SuspendLayout()
        ' 
        ' lblIdFrmRoles
        ' 
        lblIdFrmRoles.AutoSize = True
        lblIdFrmRoles.Depth = 0
        lblIdFrmRoles.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblIdFrmRoles.Location = New Point(40, 96)
        lblIdFrmRoles.MouseState = MaterialSkin.MouseState.HOVER
        lblIdFrmRoles.Name = "lblIdFrmRoles"
        lblIdFrmRoles.Size = New Size(22, 19)
        lblIdFrmRoles.TabIndex = 0
        lblIdFrmRoles.Text = "Id: "
        ' 
        ' btnAceptarFrmRoles
        ' 
        btnAceptarFrmRoles.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAceptarFrmRoles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAceptarFrmRoles.Depth = 0
        btnAceptarFrmRoles.HighEmphasis = True
        btnAceptarFrmRoles.Icon = Nothing
        btnAceptarFrmRoles.Location = New Point(447, 359)
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
        ' txtIdFrmRoles
        ' 
        txtIdFrmRoles.AllowPromptAsInput = True
        txtIdFrmRoles.AnimateReadOnly = False
        txtIdFrmRoles.AsciiOnly = False
        txtIdFrmRoles.BackgroundImageLayout = ImageLayout.None
        txtIdFrmRoles.BeepOnError = False
        txtIdFrmRoles.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtIdFrmRoles.Depth = 0
        txtIdFrmRoles.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtIdFrmRoles.HidePromptOnLeave = False
        txtIdFrmRoles.HideSelection = True
        txtIdFrmRoles.InsertKeyMode = InsertKeyMode.Default
        txtIdFrmRoles.LeadingIcon = Nothing
        txtIdFrmRoles.Location = New Point(40, 118)
        txtIdFrmRoles.Mask = ""
        txtIdFrmRoles.MaxLength = 32767
        txtIdFrmRoles.MouseState = MaterialSkin.MouseState.OUT
        txtIdFrmRoles.Name = "txtIdFrmRoles"
        txtIdFrmRoles.PasswordChar = ChrW(0)
        txtIdFrmRoles.PrefixSuffixText = Nothing
        txtIdFrmRoles.PromptChar = "_"c
        txtIdFrmRoles.ReadOnly = False
        txtIdFrmRoles.RejectInputOnFirstFailure = False
        txtIdFrmRoles.ResetOnPrompt = True
        txtIdFrmRoles.ResetOnSpace = True
        txtIdFrmRoles.RightToLeft = RightToLeft.No
        txtIdFrmRoles.SelectedText = ""
        txtIdFrmRoles.SelectionLength = 0
        txtIdFrmRoles.SelectionStart = 0
        txtIdFrmRoles.ShortcutsEnabled = True
        txtIdFrmRoles.Size = New Size(250, 48)
        txtIdFrmRoles.SkipLiterals = True
        txtIdFrmRoles.TabIndex = 2
        txtIdFrmRoles.TabStop = False
        txtIdFrmRoles.TextAlign = HorizontalAlignment.Left
        txtIdFrmRoles.TextMaskFormat = MaskFormat.IncludeLiterals
        txtIdFrmRoles.TrailingIcon = Nothing
        txtIdFrmRoles.UseSystemPasswordChar = False
        txtIdFrmRoles.ValidatingType = Nothing
        ' 
        ' lblNameFrmRole
        ' 
        lblNameFrmRole.AutoSize = True
        lblNameFrmRole.Depth = 0
        lblNameFrmRole.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNameFrmRole.Location = New Point(40, 188)
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
        txtNameFrmRoles.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNameFrmRoles.HidePromptOnLeave = False
        txtNameFrmRoles.HideSelection = True
        txtNameFrmRoles.InsertKeyMode = InsertKeyMode.Default
        txtNameFrmRoles.LeadingIcon = Nothing
        txtNameFrmRoles.Location = New Point(40, 210)
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
        lblDescriptionFrmRole.Location = New Point(40, 273)
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
        txtDescriptionFrmRoles.Location = New Point(40, 295)
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
        ' FrmRoles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtDescriptionFrmRoles)
        Controls.Add(lblDescriptionFrmRole)
        Controls.Add(txtNameFrmRoles)
        Controls.Add(lblNameFrmRole)
        Controls.Add(txtIdFrmRoles)
        Controls.Add(btnAceptarFrmRoles)
        Controls.Add(lblIdFrmRoles)
        Name = "FrmRoles"
        Text = "FrmRoles"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIdFrmRoles As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnAceptarFrmRoles As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtIdFrmRoles As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents lblNameFrmRole As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNameFrmRoles As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents lblDescriptionFrmRole As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtDescriptionFrmRoles As MaterialSkin.Controls.MaterialMultiLineTextBox2
End Class
