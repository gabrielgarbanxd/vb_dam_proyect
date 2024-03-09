<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        LostPassword = New LinkLabel()
        BtnSubmit = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        TxtName = New MaterialSkin.Controls.MaterialTextBox()
        TxtPassword = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        SuspendLayout()
        ' 
        ' LostPassword
        ' 
        LostPassword.AutoSize = True
        LostPassword.Location = New Point(36, 360)
        LostPassword.Name = "LostPassword"
        LostPassword.Size = New Size(138, 15)
        LostPassword.TabIndex = 5
        LostPassword.TabStop = True
        LostPassword.Text = "Recuperar mi contraseña"
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnSubmit.Depth = 0
        BtnSubmit.HighEmphasis = True
        BtnSubmit.Icon = Nothing
        BtnSubmit.Location = New Point(36, 306)
        BtnSubmit.Margin = New Padding(4, 6, 4, 6)
        BtnSubmit.MouseState = MaterialSkin.MouseState.HOVER
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.NoAccentTextColor = Color.Empty
        BtnSubmit.Size = New Size(77, 36)
        BtnSubmit.TabIndex = 6
        BtnSubmit.Text = "Entrar"
        BtnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnSubmit.UseAccentColor = False
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(36, 106)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(57, 19)
        MaterialLabel1.TabIndex = 7
        MaterialLabel1.Text = "Nombre"
        ' 
        ' TxtName
        ' 
        TxtName.AnimateReadOnly = False
        TxtName.BorderStyle = BorderStyle.None
        TxtName.Depth = 0
        TxtName.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtName.LeadingIcon = Nothing
        TxtName.Location = New Point(36, 128)
        TxtName.MaxLength = 50
        TxtName.MouseState = MaterialSkin.MouseState.OUT
        TxtName.Multiline = False
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(287, 50)
        TxtName.TabIndex = 8
        TxtName.Text = ""
        TxtName.TrailingIcon = Nothing
        ' 
        ' TxtPassword
        ' 
        TxtPassword.AnimateReadOnly = False
        TxtPassword.BorderStyle = BorderStyle.None
        TxtPassword.Depth = 0
        TxtPassword.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtPassword.LeadingIcon = Nothing
        TxtPassword.Location = New Point(36, 230)
        TxtPassword.MaxLength = 50
        TxtPassword.MouseState = MaterialSkin.MouseState.OUT
        TxtPassword.Multiline = False
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Password = True
        TxtPassword.Size = New Size(287, 50)
        TxtPassword.TabIndex = 10
        TxtPassword.Text = ""
        TxtPassword.TrailingIcon = Nothing
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(36, 208)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(90, 19)
        MaterialLabel2.TabIndex = 9
        MaterialLabel2.Text = "Contraseña :"
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(468, 462)
        Controls.Add(TxtPassword)
        Controls.Add(MaterialLabel2)
        Controls.Add(TxtName)
        Controls.Add(MaterialLabel1)
        Controls.Add(BtnSubmit)
        Controls.Add(LostPassword)
        Name = "FrmLogin"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LostPassword As LinkLabel
    Friend WithEvents BtnSubmit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxtName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxtPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
End Class
