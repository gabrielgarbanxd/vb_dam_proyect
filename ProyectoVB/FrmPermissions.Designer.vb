<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermissions
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
        lblAccionFrmPermissions = New MaterialSkin.Controls.MaterialLabel()
        lblResourcesFrmPermissions = New MaterialSkin.Controls.MaterialLabel()
        btnAceptarFrmPermissions = New MaterialSkin.Controls.MaterialButton()
        cbAccionFrmPermissions = New ComboBox()
        cbResourcesFrmPermissions = New ComboBox()
        lblNameFrmPermissions = New MaterialSkin.Controls.MaterialLabel()
        txtNameFrmPermissions = New MaterialSkin.Controls.MaterialMaskedTextBox()
        SuspendLayout()
        ' 
        ' lblAccionFrmPermissions
        ' 
        lblAccionFrmPermissions.AutoSize = True
        lblAccionFrmPermissions.Depth = 0
        lblAccionFrmPermissions.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblAccionFrmPermissions.Location = New Point(46, 202)
        lblAccionFrmPermissions.MouseState = MaterialSkin.MouseState.HOVER
        lblAccionFrmPermissions.Name = "lblAccionFrmPermissions"
        lblAccionFrmPermissions.Size = New Size(57, 19)
        lblAccionFrmPermissions.TabIndex = 0
        lblAccionFrmPermissions.Text = "Accion: "
        ' 
        ' lblResourcesFrmPermissions
        ' 
        lblResourcesFrmPermissions.AutoSize = True
        lblResourcesFrmPermissions.Depth = 0
        lblResourcesFrmPermissions.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblResourcesFrmPermissions.Location = New Point(46, 298)
        lblResourcesFrmPermissions.MouseState = MaterialSkin.MouseState.HOVER
        lblResourcesFrmPermissions.Name = "lblResourcesFrmPermissions"
        lblResourcesFrmPermissions.Size = New Size(74, 19)
        lblResourcesFrmPermissions.TabIndex = 2
        lblResourcesFrmPermissions.Text = "Resources"
        ' 
        ' btnAceptarFrmPermissions
        ' 
        btnAceptarFrmPermissions.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAceptarFrmPermissions.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAceptarFrmPermissions.Depth = 0
        btnAceptarFrmPermissions.HighEmphasis = True
        btnAceptarFrmPermissions.Icon = Nothing
        btnAceptarFrmPermissions.Location = New Point(338, 372)
        btnAceptarFrmPermissions.Margin = New Padding(4, 6, 4, 6)
        btnAceptarFrmPermissions.MouseState = MaterialSkin.MouseState.HOVER
        btnAceptarFrmPermissions.Name = "btnAceptarFrmPermissions"
        btnAceptarFrmPermissions.NoAccentTextColor = Color.Empty
        btnAceptarFrmPermissions.Size = New Size(86, 36)
        btnAceptarFrmPermissions.TabIndex = 6
        btnAceptarFrmPermissions.Text = "Aceptar"
        btnAceptarFrmPermissions.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnAceptarFrmPermissions.UseAccentColor = False
        btnAceptarFrmPermissions.UseVisualStyleBackColor = True
        ' 
        ' cbAccionFrmPermissions
        ' 
        cbAccionFrmPermissions.FormattingEnabled = True
        cbAccionFrmPermissions.Items.AddRange(New Object() {"Crear, Actualizar, Leer, Eliminar"})
        cbAccionFrmPermissions.Location = New Point(158, 198)
        cbAccionFrmPermissions.Name = "cbAccionFrmPermissions"
        cbAccionFrmPermissions.Size = New Size(194, 23)
        cbAccionFrmPermissions.TabIndex = 7
        ' 
        ' cbResourcesFrmPermissions
        ' 
        cbResourcesFrmPermissions.FormattingEnabled = True
        cbResourcesFrmPermissions.Items.AddRange(New Object() {"Usuarios, Roles, Permisos, Eliminar usuario"})
        cbResourcesFrmPermissions.Location = New Point(158, 294)
        cbResourcesFrmPermissions.Name = "cbResourcesFrmPermissions"
        cbResourcesFrmPermissions.Size = New Size(194, 23)
        cbResourcesFrmPermissions.TabIndex = 8
        ' 
        ' lblNameFrmPermissions
        ' 
        lblNameFrmPermissions.AutoSize = True
        lblNameFrmPermissions.Depth = 0
        lblNameFrmPermissions.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNameFrmPermissions.Location = New Point(46, 77)
        lblNameFrmPermissions.MouseState = MaterialSkin.MouseState.HOVER
        lblNameFrmPermissions.Name = "lblNameFrmPermissions"
        lblNameFrmPermissions.Size = New Size(65, 19)
        lblNameFrmPermissions.TabIndex = 9
        lblNameFrmPermissions.Text = "Nombre: "
        ' 
        ' txtNameFrmPermissions
        ' 
        txtNameFrmPermissions.AllowPromptAsInput = True
        txtNameFrmPermissions.AnimateReadOnly = False
        txtNameFrmPermissions.AsciiOnly = False
        txtNameFrmPermissions.BackgroundImageLayout = ImageLayout.None
        txtNameFrmPermissions.BeepOnError = False
        txtNameFrmPermissions.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtNameFrmPermissions.Depth = 0
        txtNameFrmPermissions.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNameFrmPermissions.HidePromptOnLeave = False
        txtNameFrmPermissions.HideSelection = True
        txtNameFrmPermissions.InsertKeyMode = InsertKeyMode.Default
        txtNameFrmPermissions.LeadingIcon = Nothing
        txtNameFrmPermissions.Location = New Point(46, 108)
        txtNameFrmPermissions.Mask = ""
        txtNameFrmPermissions.MaxLength = 32767
        txtNameFrmPermissions.MouseState = MaterialSkin.MouseState.OUT
        txtNameFrmPermissions.Name = "txtNameFrmPermissions"
        txtNameFrmPermissions.PasswordChar = ChrW(0)
        txtNameFrmPermissions.PrefixSuffixText = Nothing
        txtNameFrmPermissions.PromptChar = "_"c
        txtNameFrmPermissions.ReadOnly = False
        txtNameFrmPermissions.RejectInputOnFirstFailure = False
        txtNameFrmPermissions.ResetOnPrompt = True
        txtNameFrmPermissions.ResetOnSpace = True
        txtNameFrmPermissions.RightToLeft = RightToLeft.No
        txtNameFrmPermissions.SelectedText = ""
        txtNameFrmPermissions.SelectionLength = 0
        txtNameFrmPermissions.SelectionStart = 0
        txtNameFrmPermissions.ShortcutsEnabled = True
        txtNameFrmPermissions.Size = New Size(250, 48)
        txtNameFrmPermissions.SkipLiterals = True
        txtNameFrmPermissions.TabIndex = 10
        txtNameFrmPermissions.TabStop = False
        txtNameFrmPermissions.TextAlign = HorizontalAlignment.Left
        txtNameFrmPermissions.TextMaskFormat = MaskFormat.IncludeLiterals
        txtNameFrmPermissions.TrailingIcon = Nothing
        txtNameFrmPermissions.UseSystemPasswordChar = False
        txtNameFrmPermissions.ValidatingType = Nothing
        ' 
        ' FrmPermissions
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNameFrmPermissions)
        Controls.Add(lblNameFrmPermissions)
        Controls.Add(cbResourcesFrmPermissions)
        Controls.Add(cbAccionFrmPermissions)
        Controls.Add(btnAceptarFrmPermissions)
        Controls.Add(lblResourcesFrmPermissions)
        Controls.Add(lblAccionFrmPermissions)
        Name = "FrmPermissions"
        Text = "FrmPermissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAccionFrmPermissions As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblResourcesFrmPermissions As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnAceptarFrmPermissions As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cbAccionFrmPermissions As ComboBox
    Friend WithEvents cbResourcesFrmPermissions As ComboBox
    Friend WithEvents lblNameFrmPermissions As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNameFrmPermissions As MaterialSkin.Controls.MaterialMaskedTextBox
End Class
