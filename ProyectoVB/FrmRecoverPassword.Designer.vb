<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecoverPassword
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
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        TxtEmail = New MaterialSkin.Controls.MaterialTextBox()
        BtnSubmit = New MaterialSkin.Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(20, 90)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(419, 19)
        MaterialLabel1.TabIndex = 3
        MaterialLabel1.Text = "Introduce Correo Electrónico Para Recuperar Tu Contraseña"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.AnimateReadOnly = False
        TxtEmail.BorderStyle = BorderStyle.None
        TxtEmail.Depth = 0
        TxtEmail.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtEmail.LeadingIcon = Nothing
        TxtEmail.Location = New Point(20, 122)
        TxtEmail.MaxLength = 50
        TxtEmail.MouseState = MaterialSkin.MouseState.OUT
        TxtEmail.Multiline = False
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(301, 50)
        TxtEmail.TabIndex = 4
        TxtEmail.Text = ""
        TxtEmail.TrailingIcon = Nothing
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnSubmit.Depth = 0
        BtnSubmit.HighEmphasis = True
        BtnSubmit.Icon = Nothing
        BtnSubmit.Location = New Point(20, 195)
        BtnSubmit.Margin = New Padding(4, 6, 4, 6)
        BtnSubmit.MouseState = MaterialSkin.MouseState.HOVER
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.NoAccentTextColor = Color.Empty
        BtnSubmit.Size = New Size(276, 36)
        BtnSubmit.TabIndex = 5
        BtnSubmit.Text = "Enviar Corrreo de Recuperacion"
        BtnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnSubmit.UseAccentColor = False
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' FrmRecoverPassword
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(733, 277)
        Controls.Add(BtnSubmit)
        Controls.Add(TxtEmail)
        Controls.Add(MaterialLabel1)
        Name = "FrmRecoverPassword"
        Text = "Recuperar Contraseña"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxtEmail As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents BtnSubmit As MaterialSkin.Controls.MaterialButton
End Class
