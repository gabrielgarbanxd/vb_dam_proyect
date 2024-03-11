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
        btnAceptarFrmRoles = New MaterialSkin.Controls.MaterialButton()
        chkRol = New CheckedListBox()
        SuspendLayout()
        ' 
        ' btnAceptarFrmRoles
        ' 
        btnAceptarFrmRoles.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAceptarFrmRoles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAceptarFrmRoles.Depth = 0
        btnAceptarFrmRoles.HighEmphasis = True
        btnAceptarFrmRoles.Icon = Nothing
        btnAceptarFrmRoles.Location = New Point(442, 359)
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
        ' chkRol
        ' 
        chkRol.FormattingEnabled = True
        chkRol.Items.AddRange(New Object() {"USER", "ADMIN", "MODERADOR"})
        chkRol.Location = New Point(312, 152)
        chkRol.Name = "chkRol"
        chkRol.Size = New Size(180, 166)
        chkRol.TabIndex = 14
        ' 
        ' FrmRoles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(chkRol)
        Controls.Add(btnAceptarFrmRoles)
        Name = "FrmRoles"
        Text = "FrmRoles"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnAceptarFrmRoles As MaterialSkin.Controls.MaterialButton
    Friend WithEvents chkRol As CheckedListBox
End Class
