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
        TxtNewPassword = New TextBox()
        TxtConfirmPassword = New TextBox()
        BtnSubmit = New Button()
        Label1 = New Label()
        BtnCancel = New Button()
        SuspendLayout()
        ' 
        ' TxtNewPassword
        ' 
        TxtNewPassword.Location = New Point(29, 45)
        TxtNewPassword.Name = "TxtNewPassword"
        TxtNewPassword.PasswordChar = "*"c
        TxtNewPassword.Size = New Size(187, 23)
        TxtNewPassword.TabIndex = 0
        ' 
        ' TxtConfirmPassword
        ' 
        TxtConfirmPassword.Location = New Point(29, 87)
        TxtConfirmPassword.Name = "TxtConfirmPassword"
        TxtConfirmPassword.PasswordChar = "*"c
        TxtConfirmPassword.Size = New Size(187, 23)
        TxtConfirmPassword.TabIndex = 1
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(29, 132)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(104, 30)
        BtnSubmit.TabIndex = 2
        BtnSubmit.Text = "Confirmar"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 15)
        Label1.TabIndex = 3
        Label1.Text = "Nueva Contraseña"
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Location = New Point(139, 132)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(104, 30)
        BtnCancel.TabIndex = 4
        BtnCancel.Text = "Cancelar"
        BtnCancel.UseVisualStyleBackColor = True
        ' 
        ' FrmChangePassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(324, 208)
        Controls.Add(BtnCancel)
        Controls.Add(Label1)
        Controls.Add(BtnSubmit)
        Controls.Add(TxtConfirmPassword)
        Controls.Add(TxtNewPassword)
        Name = "FrmChangePassword"
        Text = "Cambiar Contraseña"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNewPassword As TextBox
    Friend WithEvents TxtConfirmPassword As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancel As Button
End Class
