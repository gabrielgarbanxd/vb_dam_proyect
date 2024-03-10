<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassword
    Inherits Form

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
        TxtConfirmPassword = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        TxtNewPassword = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        BtnSubmit = New MaterialSkin.Controls.MaterialButton()
        BtnCancel = New MaterialSkin.Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' TxtConfirmPassword
        ' 
        TxtConfirmPassword.AnimateReadOnly = False
        TxtConfirmPassword.BorderStyle = BorderStyle.None
        TxtConfirmPassword.Depth = 0
        TxtConfirmPassword.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtConfirmPassword.LeadingIcon = Nothing
        TxtConfirmPassword.Location = New Point(12, 150)
        TxtConfirmPassword.MaxLength = 50
        TxtConfirmPassword.MouseState = MaterialSkin.MouseState.OUT
        TxtConfirmPassword.Multiline = False
        TxtConfirmPassword.Name = "TxtConfirmPassword"
        TxtConfirmPassword.Password = True
        TxtConfirmPassword.Size = New Size(287, 50)
        TxtConfirmPassword.TabIndex = 15
        TxtConfirmPassword.Text = ""
        TxtConfirmPassword.TrailingIcon = Nothing
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(12, 128)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(214, 19)
        MaterialLabel2.TabIndex = 14
        MaterialLabel2.Text = "Confirmar Nueva Contraseña :"
        ' 
        ' TxtNewPassword
        ' 
        TxtNewPassword.AnimateReadOnly = False
        TxtNewPassword.BorderStyle = BorderStyle.None
        TxtNewPassword.Depth = 0
        TxtNewPassword.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtNewPassword.LeadingIcon = Nothing
        TxtNewPassword.Location = New Point(12, 48)
        TxtNewPassword.MaxLength = 50
        TxtNewPassword.MouseState = MaterialSkin.MouseState.OUT
        TxtNewPassword.Multiline = False
        TxtNewPassword.Name = "TxtNewPassword"
        TxtNewPassword.Password = True
        TxtNewPassword.Size = New Size(287, 50)
        TxtNewPassword.TabIndex = 13
        TxtNewPassword.Text = ""
        TxtNewPassword.TrailingIcon = Nothing
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(12, 26)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(131, 19)
        MaterialLabel1.TabIndex = 12
        MaterialLabel1.Text = "Nueva Contraseña"
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnSubmit.Depth = 0
        BtnSubmit.HighEmphasis = True
        BtnSubmit.Icon = Nothing
        BtnSubmit.Location = New Point(67, 219)
        BtnSubmit.Margin = New Padding(4, 6, 4, 6)
        BtnSubmit.MouseState = MaterialSkin.MouseState.HOVER
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.NoAccentTextColor = Color.Empty
        BtnSubmit.Size = New Size(105, 36)
        BtnSubmit.TabIndex = 11
        BtnSubmit.Text = "Confirmar"
        BtnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnSubmit.UseAccentColor = False
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnCancel
        ' 
        BtnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnCancel.Depth = 0
        BtnCancel.HighEmphasis = True
        BtnCancel.Icon = Nothing
        BtnCancel.Location = New Point(194, 219)
        BtnCancel.Margin = New Padding(4, 6, 4, 6)
        BtnCancel.MouseState = MaterialSkin.MouseState.HOVER
        BtnCancel.Name = "BtnCancel"
        BtnCancel.NoAccentTextColor = Color.Empty
        BtnCancel.Size = New Size(96, 36)
        BtnCancel.TabIndex = 16
        BtnCancel.Text = "Cancelar"
        BtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnCancel.UseAccentColor = False
        BtnCancel.UseVisualStyleBackColor = True
        ' 
        ' FrmChangePassword
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(360, 291)
        Controls.Add(BtnCancel)
        Controls.Add(TxtConfirmPassword)
        Controls.Add(MaterialLabel2)
        Controls.Add(TxtNewPassword)
        Controls.Add(MaterialLabel1)
        Controls.Add(BtnSubmit)
        Name = "FrmChangePassword"
        Text = "Cambiar Contraseña"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtConfirmPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxtNewPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BtnSubmit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnCancel As MaterialSkin.Controls.MaterialButton
End Class
