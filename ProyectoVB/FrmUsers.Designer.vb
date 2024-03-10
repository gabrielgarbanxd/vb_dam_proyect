<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsers
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
        btnAceptarFrmUser = New MaterialSkin.Controls.MaterialButton()
        lblNameFrmUser = New MaterialSkin.Controls.MaterialLabel()
        txtNameFrmUser = New MaterialSkin.Controls.MaterialMaskedTextBox()
        lblEmailFrmUser = New MaterialSkin.Controls.MaterialLabel()
        txtEmailFrmUser = New MaterialSkin.Controls.MaterialMaskedTextBox()
        lblPasswordFrmUser = New MaterialSkin.Controls.MaterialLabel()
        txtPasswordFrmUser = New MaterialSkin.Controls.MaterialMaskedTextBox()
        SuspendLayout()
        ' 
        ' btnAceptarFrmUser
        ' 
        btnAceptarFrmUser.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAceptarFrmUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAceptarFrmUser.Depth = 0
        btnAceptarFrmUser.HighEmphasis = True
        btnAceptarFrmUser.Icon = Nothing
        btnAceptarFrmUser.Location = New Point(366, 371)
        btnAceptarFrmUser.Margin = New Padding(4, 6, 4, 6)
        btnAceptarFrmUser.MouseState = MaterialSkin.MouseState.HOVER
        btnAceptarFrmUser.Name = "btnAceptarFrmUser"
        btnAceptarFrmUser.NoAccentTextColor = Color.Empty
        btnAceptarFrmUser.Size = New Size(86, 36)
        btnAceptarFrmUser.TabIndex = 3
        btnAceptarFrmUser.Text = "Aceptar"
        btnAceptarFrmUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnAceptarFrmUser.UseAccentColor = False
        btnAceptarFrmUser.UseVisualStyleBackColor = True
        ' 
        ' lblNameFrmUser
        ' 
        lblNameFrmUser.AutoSize = True
        lblNameFrmUser.Depth = 0
        lblNameFrmUser.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNameFrmUser.Location = New Point(52, 112)
        lblNameFrmUser.MouseState = MaterialSkin.MouseState.HOVER
        lblNameFrmUser.Name = "lblNameFrmUser"
        lblNameFrmUser.Size = New Size(65, 19)
        lblNameFrmUser.TabIndex = 4
        lblNameFrmUser.Text = "Nombre: "
        ' 
        ' txtNameFrmUser
        ' 
        txtNameFrmUser.AllowPromptAsInput = True
        txtNameFrmUser.AnimateReadOnly = False
        txtNameFrmUser.AsciiOnly = False
        txtNameFrmUser.BackgroundImageLayout = ImageLayout.None
        txtNameFrmUser.BeepOnError = False
        txtNameFrmUser.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtNameFrmUser.Depth = 0
        txtNameFrmUser.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNameFrmUser.HidePromptOnLeave = False
        txtNameFrmUser.HideSelection = True
        txtNameFrmUser.InsertKeyMode = InsertKeyMode.Default
        txtNameFrmUser.LeadingIcon = Nothing
        txtNameFrmUser.Location = New Point(52, 134)
        txtNameFrmUser.Mask = ""
        txtNameFrmUser.MaxLength = 32767
        txtNameFrmUser.MouseState = MaterialSkin.MouseState.OUT
        txtNameFrmUser.Name = "txtNameFrmUser"
        txtNameFrmUser.PasswordChar = ChrW(0)
        txtNameFrmUser.PrefixSuffixText = Nothing
        txtNameFrmUser.PromptChar = "_"c
        txtNameFrmUser.ReadOnly = False
        txtNameFrmUser.RejectInputOnFirstFailure = False
        txtNameFrmUser.ResetOnPrompt = True
        txtNameFrmUser.ResetOnSpace = True
        txtNameFrmUser.RightToLeft = RightToLeft.No
        txtNameFrmUser.SelectedText = ""
        txtNameFrmUser.SelectionLength = 0
        txtNameFrmUser.SelectionStart = 0
        txtNameFrmUser.ShortcutsEnabled = True
        txtNameFrmUser.Size = New Size(250, 48)
        txtNameFrmUser.SkipLiterals = True
        txtNameFrmUser.TabIndex = 5
        txtNameFrmUser.TabStop = False
        txtNameFrmUser.TextAlign = HorizontalAlignment.Left
        txtNameFrmUser.TextMaskFormat = MaskFormat.IncludeLiterals
        txtNameFrmUser.TrailingIcon = Nothing
        txtNameFrmUser.UseSystemPasswordChar = False
        txtNameFrmUser.ValidatingType = Nothing
        ' 
        ' lblEmailFrmUser
        ' 
        lblEmailFrmUser.AutoSize = True
        lblEmailFrmUser.Depth = 0
        lblEmailFrmUser.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblEmailFrmUser.Location = New Point(52, 198)
        lblEmailFrmUser.MouseState = MaterialSkin.MouseState.HOVER
        lblEmailFrmUser.Name = "lblEmailFrmUser"
        lblEmailFrmUser.Size = New Size(49, 19)
        lblEmailFrmUser.TabIndex = 6
        lblEmailFrmUser.Text = "Email: "
        ' 
        ' txtEmailFrmUser
        ' 
        txtEmailFrmUser.AllowPromptAsInput = True
        txtEmailFrmUser.AnimateReadOnly = False
        txtEmailFrmUser.AsciiOnly = False
        txtEmailFrmUser.BackgroundImageLayout = ImageLayout.None
        txtEmailFrmUser.BeepOnError = False
        txtEmailFrmUser.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtEmailFrmUser.Depth = 0
        txtEmailFrmUser.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtEmailFrmUser.HidePromptOnLeave = False
        txtEmailFrmUser.HideSelection = True
        txtEmailFrmUser.InsertKeyMode = InsertKeyMode.Default
        txtEmailFrmUser.LeadingIcon = Nothing
        txtEmailFrmUser.Location = New Point(52, 220)
        txtEmailFrmUser.Mask = ""
        txtEmailFrmUser.MaxLength = 32767
        txtEmailFrmUser.MouseState = MaterialSkin.MouseState.OUT
        txtEmailFrmUser.Name = "txtEmailFrmUser"
        txtEmailFrmUser.PasswordChar = ChrW(0)
        txtEmailFrmUser.PrefixSuffixText = Nothing
        txtEmailFrmUser.PromptChar = "_"c
        txtEmailFrmUser.ReadOnly = False
        txtEmailFrmUser.RejectInputOnFirstFailure = False
        txtEmailFrmUser.ResetOnPrompt = True
        txtEmailFrmUser.ResetOnSpace = True
        txtEmailFrmUser.RightToLeft = RightToLeft.No
        txtEmailFrmUser.SelectedText = ""
        txtEmailFrmUser.SelectionLength = 0
        txtEmailFrmUser.SelectionStart = 0
        txtEmailFrmUser.ShortcutsEnabled = True
        txtEmailFrmUser.Size = New Size(250, 48)
        txtEmailFrmUser.SkipLiterals = True
        txtEmailFrmUser.TabIndex = 7
        txtEmailFrmUser.TabStop = False
        txtEmailFrmUser.TextAlign = HorizontalAlignment.Left
        txtEmailFrmUser.TextMaskFormat = MaskFormat.IncludeLiterals
        txtEmailFrmUser.TrailingIcon = Nothing
        txtEmailFrmUser.UseSystemPasswordChar = False
        txtEmailFrmUser.ValidatingType = Nothing
        ' 
        ' lblPasswordFrmUser
        ' 
        lblPasswordFrmUser.AutoSize = True
        lblPasswordFrmUser.Depth = 0
        lblPasswordFrmUser.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblPasswordFrmUser.Location = New Point(52, 285)
        lblPasswordFrmUser.MouseState = MaterialSkin.MouseState.HOVER
        lblPasswordFrmUser.Name = "lblPasswordFrmUser"
        lblPasswordFrmUser.Size = New Size(82, 19)
        lblPasswordFrmUser.TabIndex = 8
        lblPasswordFrmUser.Text = "Contraeña: "
        ' 
        ' txtPasswordFrmUser
        ' 
        txtPasswordFrmUser.AllowPromptAsInput = True
        txtPasswordFrmUser.AnimateReadOnly = False
        txtPasswordFrmUser.AsciiOnly = False
        txtPasswordFrmUser.BackgroundImageLayout = ImageLayout.None
        txtPasswordFrmUser.BeepOnError = False
        txtPasswordFrmUser.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtPasswordFrmUser.Depth = 0
        txtPasswordFrmUser.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtPasswordFrmUser.HidePromptOnLeave = False
        txtPasswordFrmUser.HideSelection = True
        txtPasswordFrmUser.InsertKeyMode = InsertKeyMode.Default
        txtPasswordFrmUser.LeadingIcon = Nothing
        txtPasswordFrmUser.Location = New Point(52, 307)
        txtPasswordFrmUser.Mask = ""
        txtPasswordFrmUser.MaxLength = 32767
        txtPasswordFrmUser.MouseState = MaterialSkin.MouseState.OUT
        txtPasswordFrmUser.Name = "txtPasswordFrmUser"
        txtPasswordFrmUser.PasswordChar = ChrW(0)
        txtPasswordFrmUser.PrefixSuffixText = Nothing
        txtPasswordFrmUser.PromptChar = "_"c
        txtPasswordFrmUser.ReadOnly = False
        txtPasswordFrmUser.RejectInputOnFirstFailure = False
        txtPasswordFrmUser.ResetOnPrompt = True
        txtPasswordFrmUser.ResetOnSpace = True
        txtPasswordFrmUser.RightToLeft = RightToLeft.No
        txtPasswordFrmUser.SelectedText = ""
        txtPasswordFrmUser.SelectionLength = 0
        txtPasswordFrmUser.SelectionStart = 0
        txtPasswordFrmUser.ShortcutsEnabled = True
        txtPasswordFrmUser.Size = New Size(250, 48)
        txtPasswordFrmUser.SkipLiterals = True
        txtPasswordFrmUser.TabIndex = 9
        txtPasswordFrmUser.TabStop = False
        txtPasswordFrmUser.TextAlign = HorizontalAlignment.Left
        txtPasswordFrmUser.TextMaskFormat = MaskFormat.IncludeLiterals
        txtPasswordFrmUser.TrailingIcon = Nothing
        txtPasswordFrmUser.UseSystemPasswordChar = False
        txtPasswordFrmUser.ValidatingType = Nothing
        ' 
        ' FrmUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtPasswordFrmUser)
        Controls.Add(lblPasswordFrmUser)
        Controls.Add(txtEmailFrmUser)
        Controls.Add(lblEmailFrmUser)
        Controls.Add(txtNameFrmUser)
        Controls.Add(lblNameFrmUser)
        Controls.Add(btnAceptarFrmUser)
        Name = "FrmUsers"
        Text = "FrmUsers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAceptarFrmUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblNameFrmUser As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNameFrmUser As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents lblEmailFrmUser As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtEmailFrmUser As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents lblPasswordFrmUser As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtPasswordFrmUser As MaterialSkin.Controls.MaterialMaskedTextBox
End Class
