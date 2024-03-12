<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfilePage
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
        lblNombre = New MaterialSkin.Controls.MaterialLabel()
        PictureBox1 = New PictureBox()
        lblMostrarNombre = New MaterialSkin.Controls.MaterialLabel()
        lblEmail = New MaterialSkin.Controls.MaterialLabel()
        SaveFileDialog1 = New SaveFileDialog()
        lblFechaPago = New MaterialSkin.Controls.MaterialLabel()
        LblRole = New MaterialSkin.Controls.MaterialLabel()
        lblMostrarEmail = New MaterialSkin.Controls.MaterialLabel()
        lblMostrarFechaPago = New MaterialSkin.Controls.MaterialLabel()
        lblMostrarConexion = New MaterialSkin.Controls.MaterialLabel()
        btnPagar = New MaterialSkin.Controls.MaterialButton()
        lblEditarEmail = New MaterialSkin.Controls.MaterialLabel()
        TxtEmail = New MaterialSkin.Controls.MaterialMaskedTextBox()
        btnActualizar = New MaterialSkin.Controls.MaterialButton()
        LblNameData = New MaterialSkin.Controls.MaterialLabel()
        LblEmailData = New MaterialSkin.Controls.MaterialLabel()
        LblPaymentDateData = New MaterialSkin.Controls.MaterialLabel()
        DgvMyPermissions = New DataGridView()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        LblRoleData = New MaterialSkin.Controls.MaterialLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvMyPermissions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Depth = 0
        lblNombre.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNombre.Location = New Point(100, 313)
        lblNombre.MouseState = MaterialSkin.MouseState.HOVER
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(65, 19)
        lblNombre.TabIndex = 0
        lblNombre.Text = "Nombre: "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.profile
        PictureBox1.Location = New Point(100, 91)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(187, 184)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblMostrarNombre
        ' 
        lblMostrarNombre.AutoSize = True
        lblMostrarNombre.Depth = 0
        lblMostrarNombre.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblMostrarNombre.Location = New Point(171, 313)
        lblMostrarNombre.MouseState = MaterialSkin.MouseState.HOVER
        lblMostrarNombre.Name = "lblMostrarNombre"
        lblMostrarNombre.Size = New Size(1, 0)
        lblMostrarNombre.TabIndex = 2
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Depth = 0
        lblEmail.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblEmail.Location = New Point(100, 365)
        lblEmail.MouseState = MaterialSkin.MouseState.HOVER
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(49, 19)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email: "
        ' 
        ' lblFechaPago
        ' 
        lblFechaPago.AutoSize = True
        lblFechaPago.Depth = 0
        lblFechaPago.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblFechaPago.Location = New Point(100, 421)
        lblFechaPago.MouseState = MaterialSkin.MouseState.HOVER
        lblFechaPago.Name = "lblFechaPago"
        lblFechaPago.Size = New Size(92, 19)
        lblFechaPago.TabIndex = 4
        lblFechaPago.Text = "Fecha pago: "
        ' 
        ' LblRole
        ' 
        LblRole.AutoSize = True
        LblRole.Depth = 0
        LblRole.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        LblRole.Location = New Point(100, 480)
        LblRole.MouseState = MaterialSkin.MouseState.HOVER
        LblRole.Name = "LblRole"
        LblRole.Size = New Size(32, 19)
        LblRole.TabIndex = 5
        LblRole.Text = "Rol: "
        ' 
        ' lblMostrarEmail
        ' 
        lblMostrarEmail.AutoSize = True
        lblMostrarEmail.Depth = 0
        lblMostrarEmail.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblMostrarEmail.Location = New Point(171, 365)
        lblMostrarEmail.MouseState = MaterialSkin.MouseState.HOVER
        lblMostrarEmail.Name = "lblMostrarEmail"
        lblMostrarEmail.Size = New Size(1, 0)
        lblMostrarEmail.TabIndex = 6
        ' 
        ' lblMostrarFechaPago
        ' 
        lblMostrarFechaPago.AutoSize = True
        lblMostrarFechaPago.Depth = 0
        lblMostrarFechaPago.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblMostrarFechaPago.Location = New Point(211, 421)
        lblMostrarFechaPago.MouseState = MaterialSkin.MouseState.HOVER
        lblMostrarFechaPago.Name = "lblMostrarFechaPago"
        lblMostrarFechaPago.Size = New Size(1, 0)
        lblMostrarFechaPago.TabIndex = 7
        ' 
        ' lblMostrarConexion
        ' 
        lblMostrarConexion.AutoSize = True
        lblMostrarConexion.Depth = 0
        lblMostrarConexion.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblMostrarConexion.Location = New Point(229, 480)
        lblMostrarConexion.MouseState = MaterialSkin.MouseState.HOVER
        lblMostrarConexion.Name = "lblMostrarConexion"
        lblMostrarConexion.Size = New Size(1, 0)
        lblMostrarConexion.TabIndex = 8
        ' 
        ' btnPagar
        ' 
        btnPagar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPagar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPagar.Depth = 0
        btnPagar.HighEmphasis = True
        btnPagar.Icon = Nothing
        btnPagar.Location = New Point(281, 682)
        btnPagar.Margin = New Padding(4, 6, 4, 6)
        btnPagar.MouseState = MaterialSkin.MouseState.HOVER
        btnPagar.Name = "btnPagar"
        btnPagar.NoAccentTextColor = Color.Empty
        btnPagar.Size = New Size(69, 36)
        btnPagar.TabIndex = 9
        btnPagar.Text = "Pagar"
        btnPagar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnPagar.UseAccentColor = False
        btnPagar.UseVisualStyleBackColor = True
        ' 
        ' lblEditarEmail
        ' 
        lblEditarEmail.AutoSize = True
        lblEditarEmail.Depth = 0
        lblEditarEmail.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblEditarEmail.Location = New Point(100, 571)
        lblEditarEmail.MouseState = MaterialSkin.MouseState.HOVER
        lblEditarEmail.Name = "lblEditarEmail"
        lblEditarEmail.Size = New Size(94, 19)
        lblEditarEmail.TabIndex = 10
        lblEditarEmail.Text = "Editar Email: "
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
        TxtEmail.Location = New Point(100, 593)
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
        TxtEmail.TabIndex = 11
        TxtEmail.TabStop = False
        TxtEmail.TextAlign = HorizontalAlignment.Left
        TxtEmail.TextMaskFormat = MaskFormat.IncludeLiterals
        TxtEmail.TrailingIcon = Nothing
        TxtEmail.UseSystemPasswordChar = False
        TxtEmail.ValidatingType = Nothing
        ' 
        ' btnActualizar
        ' 
        btnActualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnActualizar.Depth = 0
        btnActualizar.HighEmphasis = True
        btnActualizar.Icon = Nothing
        btnActualizar.Location = New Point(100, 682)
        btnActualizar.Margin = New Padding(4, 6, 4, 6)
        btnActualizar.MouseState = MaterialSkin.MouseState.HOVER
        btnActualizar.Name = "btnActualizar"
        btnActualizar.NoAccentTextColor = Color.Empty
        btnActualizar.Size = New Size(109, 36)
        btnActualizar.TabIndex = 12
        btnActualizar.Text = "Actualizar"
        btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnActualizar.UseAccentColor = False
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' LblNameData
        ' 
        LblNameData.AutoSize = True
        LblNameData.Depth = 0
        LblNameData.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        LblNameData.Location = New Point(178, 313)
        LblNameData.MouseState = MaterialSkin.MouseState.HOVER
        LblNameData.Name = "LblNameData"
        LblNameData.Size = New Size(1, 0)
        LblNameData.TabIndex = 13
        ' 
        ' LblEmailData
        ' 
        LblEmailData.AutoSize = True
        LblEmailData.Depth = 0
        LblEmailData.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        LblEmailData.Location = New Point(171, 365)
        LblEmailData.MouseState = MaterialSkin.MouseState.HOVER
        LblEmailData.Name = "LblEmailData"
        LblEmailData.Size = New Size(1, 0)
        LblEmailData.TabIndex = 14
        ' 
        ' LblPaymentDateData
        ' 
        LblPaymentDateData.AutoSize = True
        LblPaymentDateData.Depth = 0
        LblPaymentDateData.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        LblPaymentDateData.Location = New Point(198, 421)
        LblPaymentDateData.MouseState = MaterialSkin.MouseState.HOVER
        LblPaymentDateData.Name = "LblPaymentDateData"
        LblPaymentDateData.Size = New Size(1, 0)
        LblPaymentDateData.TabIndex = 15
        ' 
        ' DgvMyPermissions
        ' 
        DgvMyPermissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvMyPermissions.Location = New Point(656, 188)
        DgvMyPermissions.Name = "DgvMyPermissions"
        DgvMyPermissions.RowTemplate.Height = 25
        DgvMyPermissions.Size = New Size(542, 412)
        DgvMyPermissions.TabIndex = 16
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(661, 165)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(101, 19)
        MaterialLabel1.TabIndex = 17
        MaterialLabel1.Text = "Mis Permisos:"
        ' 
        ' LblRoleData
        ' 
        LblRoleData.AutoSize = True
        LblRoleData.Depth = 0
        LblRoleData.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        LblRoleData.Location = New Point(138, 480)
        LblRoleData.MouseState = MaterialSkin.MouseState.HOVER
        LblRoleData.Name = "LblRoleData"
        LblRoleData.Size = New Size(1, 0)
        LblRoleData.TabIndex = 18
        ' 
        ' ProfilePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(LblRoleData)
        Controls.Add(MaterialLabel1)
        Controls.Add(DgvMyPermissions)
        Controls.Add(LblPaymentDateData)
        Controls.Add(LblEmailData)
        Controls.Add(LblNameData)
        Controls.Add(btnActualizar)
        Controls.Add(TxtEmail)
        Controls.Add(lblEditarEmail)
        Controls.Add(btnPagar)
        Controls.Add(lblMostrarConexion)
        Controls.Add(lblMostrarFechaPago)
        Controls.Add(lblMostrarEmail)
        Controls.Add(LblRole)
        Controls.Add(lblFechaPago)
        Controls.Add(lblEmail)
        Controls.Add(lblMostrarNombre)
        Controls.Add(PictureBox1)
        Controls.Add(lblNombre)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "ProfilePage"
        Size = New Size(1906, 985)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvMyPermissions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMostrarNombre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblEmail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblFechaPago As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LblRole As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMostrarEmail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMostrarFechaPago As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMostrarConexion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnPagar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblEditarEmail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxtEmail As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents btnActualizar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents LblNameData As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LblEmailData As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LblPaymentDateData As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DgvMyPermissions As DataGridView
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LblRoleData As MaterialSkin.Controls.MaterialLabel
End Class
