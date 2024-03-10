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
        SuspendLayout()
        ' 
        ' TxtNewPassword
        ' 
        TxtNewPassword.Location = New Point(29, 48)
        TxtNewPassword.Name = "TxtNewPassword"
        TxtNewPassword.Size = New Size(187, 23)
        TxtNewPassword.TabIndex = 0
        ' 
        ' TxtConfirmPassword
        ' 
        TxtConfirmPassword.Location = New Point(29, 97)
        TxtConfirmPassword.Name = "TxtConfirmPassword"
        TxtConfirmPassword.Size = New Size(187, 23)
        TxtConfirmPassword.TabIndex = 1
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(29, 147)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(120, 37)
        BtnSubmit.TabIndex = 2
        BtnSubmit.Text = "Button1"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' FrmChangePassword
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(443, 351)
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
End Class
