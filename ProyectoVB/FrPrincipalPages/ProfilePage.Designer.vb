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
        lblConexion = New MaterialSkin.Controls.MaterialLabel()
        lblMostrarEmail = New MaterialSkin.Controls.MaterialLabel()
        lblMostrarFechaPago = New MaterialSkin.Controls.MaterialLabel()
        lblMostrarConexion = New MaterialSkin.Controls.MaterialLabel()
        btnPagar = New MaterialSkin.Controls.MaterialButton()
        lblEditarEmail = New MaterialSkin.Controls.MaterialLabel()
        txtActualizarEmail = New MaterialSkin.Controls.MaterialMaskedTextBox()
        btnActualizar = New MaterialSkin.Controls.MaterialButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Depth = 0
        lblNombre.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
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
        lblMostrarNombre.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
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
        lblEmail.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
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
        lblFechaPago.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblFechaPago.Location = New Point(100, 421)
        lblFechaPago.MouseState = MaterialSkin.MouseState.HOVER
        lblFechaPago.Name = "lblFechaPago"
        lblFechaPago.Size = New Size(92, 19)
        lblFechaPago.TabIndex = 4
        lblFechaPago.Text = "Fecha pago: "
        ' 
        ' lblConexion
        ' 
        lblConexion.AutoSize = True
        lblConexion.Depth = 0
        lblConexion.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblConexion.Location = New Point(100, 480)
        lblConexion.MouseState = MaterialSkin.MouseState.HOVER
        lblConexion.Name = "lblConexion"
        lblConexion.Size = New Size(123, 19)
        lblConexion.TabIndex = 5
        lblConexion.Text = "Ultima conexion: "
        ' 
        ' lblMostrarEmail
        ' 
        lblMostrarEmail.AutoSize = True
        lblMostrarEmail.Depth = 0
        lblMostrarEmail.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
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
        lblMostrarFechaPago.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
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
        lblMostrarConexion.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
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
        btnPagar.Location = New Point(281, 665)
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
        lblEditarEmail.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblEditarEmail.Location = New Point(100, 554)
        lblEditarEmail.MouseState = MaterialSkin.MouseState.HOVER
        lblEditarEmail.Name = "lblEditarEmail"
        lblEditarEmail.Size = New Size(94, 19)
        lblEditarEmail.TabIndex = 10
        lblEditarEmail.Text = "Editar Email: "
        ' 
        ' txtActualizarEmail
        ' 
        txtActualizarEmail.AllowPromptAsInput = True
        txtActualizarEmail.AnimateReadOnly = False
        txtActualizarEmail.AsciiOnly = False
        txtActualizarEmail.BackgroundImageLayout = ImageLayout.None
        txtActualizarEmail.BeepOnError = False
        txtActualizarEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txtActualizarEmail.Depth = 0
        txtActualizarEmail.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtActualizarEmail.HidePromptOnLeave = False
        txtActualizarEmail.HideSelection = True
        txtActualizarEmail.InsertKeyMode = InsertKeyMode.Default
        txtActualizarEmail.LeadingIcon = Nothing
        txtActualizarEmail.Location = New Point(100, 576)
        txtActualizarEmail.Mask = ""
        txtActualizarEmail.MaxLength = 32767
        txtActualizarEmail.MouseState = MaterialSkin.MouseState.OUT
        txtActualizarEmail.Name = "txtActualizarEmail"
        txtActualizarEmail.PasswordChar = ChrW(0)
        txtActualizarEmail.PrefixSuffixText = Nothing
        txtActualizarEmail.PromptChar = "_"c
        txtActualizarEmail.ReadOnly = False
        txtActualizarEmail.RejectInputOnFirstFailure = False
        txtActualizarEmail.ResetOnPrompt = True
        txtActualizarEmail.ResetOnSpace = True
        txtActualizarEmail.RightToLeft = RightToLeft.No
        txtActualizarEmail.SelectedText = ""
        txtActualizarEmail.SelectionLength = 0
        txtActualizarEmail.SelectionStart = 0
        txtActualizarEmail.ShortcutsEnabled = True
        txtActualizarEmail.Size = New Size(250, 48)
        txtActualizarEmail.SkipLiterals = True
        txtActualizarEmail.TabIndex = 11
        txtActualizarEmail.TabStop = False
        txtActualizarEmail.TextAlign = HorizontalAlignment.Left
        txtActualizarEmail.TextMaskFormat = MaskFormat.IncludeLiterals
        txtActualizarEmail.TrailingIcon = Nothing
        txtActualizarEmail.UseSystemPasswordChar = False
        txtActualizarEmail.ValidatingType = Nothing
        ' 
        ' btnActualizar
        ' 
        btnActualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnActualizar.Depth = 0
        btnActualizar.HighEmphasis = True
        btnActualizar.Icon = Nothing
        btnActualizar.Location = New Point(100, 665)
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
        ' ProfilePage
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnActualizar)
        Controls.Add(txtActualizarEmail)
        Controls.Add(lblEditarEmail)
        Controls.Add(btnPagar)
        Controls.Add(lblMostrarConexion)
        Controls.Add(lblMostrarFechaPago)
        Controls.Add(lblMostrarEmail)
        Controls.Add(lblConexion)
        Controls.Add(lblFechaPago)
        Controls.Add(lblEmail)
        Controls.Add(lblMostrarNombre)
        Controls.Add(PictureBox1)
        Controls.Add(lblNombre)
        Name = "ProfilePage"
        Size = New Size(1906, 985)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMostrarNombre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblEmail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblFechaPago As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblConexion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMostrarEmail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMostrarFechaPago As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMostrarConexion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnPagar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblEditarEmail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtActualizarEmail As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents btnActualizar As MaterialSkin.Controls.MaterialButton

End Class
