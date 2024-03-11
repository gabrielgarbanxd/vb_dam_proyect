<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeletedUsersPage
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
        DgvDeletedUsers = New DataGridView()
        BtnRestoreUser = New MaterialSkin.Controls.MaterialButton()
        Label2 = New Label()
        MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        BtnSearchName = New MaterialSkin.Controls.MaterialButton()
        TxtNameToSearch = New MaterialSkin.Controls.MaterialMaskedTextBox()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        BtnDeleteFilters = New MaterialSkin.Controls.MaterialButton()
        CType(DgvDeletedUsers, ComponentModel.ISupportInitialize).BeginInit()
        MaterialCard2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DgvDeletedUsers
        ' 
        DgvDeletedUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvDeletedUsers.Location = New Point(891, 38)
        DgvDeletedUsers.Name = "DgvDeletedUsers"
        DgvDeletedUsers.RowTemplate.Height = 25
        DgvDeletedUsers.Size = New Size(972, 614)
        DgvDeletedUsers.TabIndex = 17
        ' 
        ' BtnRestoreUser
        ' 
        BtnRestoreUser.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnRestoreUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnRestoreUser.Depth = 0
        BtnRestoreUser.HighEmphasis = True
        BtnRestoreUser.Icon = Nothing
        BtnRestoreUser.Location = New Point(891, 661)
        BtnRestoreUser.Margin = New Padding(4, 6, 4, 6)
        BtnRestoreUser.MouseState = MaterialSkin.MouseState.HOVER
        BtnRestoreUser.Name = "BtnRestoreUser"
        BtnRestoreUser.NoAccentTextColor = Color.Empty
        BtnRestoreUser.Size = New Size(169, 36)
        BtnRestoreUser.TabIndex = 18
        BtnRestoreUser.Text = "Recuperar Usuario"
        BtnRestoreUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnRestoreUser.UseAccentColor = False
        BtnRestoreUser.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(203, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(244, 36)
        Label2.TabIndex = 25
        Label2.Text = "Buscar por Nombre"
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Controls.Add(BtnSearchName)
        MaterialCard2.Controls.Add(TxtNameToSearch)
        MaterialCard2.Controls.Add(MaterialLabel1)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(203, 103)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(14)
        MaterialCard2.Size = New Size(338, 170)
        MaterialCard2.TabIndex = 24
        ' 
        ' BtnSearchName
        ' 
        BtnSearchName.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnSearchName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnSearchName.Depth = 0
        BtnSearchName.HighEmphasis = True
        BtnSearchName.Icon = Nothing
        BtnSearchName.Location = New Point(17, 114)
        BtnSearchName.Margin = New Padding(4, 6, 4, 6)
        BtnSearchName.MouseState = MaterialSkin.MouseState.HOVER
        BtnSearchName.Name = "BtnSearchName"
        BtnSearchName.NoAccentTextColor = Color.Empty
        BtnSearchName.Size = New Size(77, 36)
        BtnSearchName.TabIndex = 24
        BtnSearchName.Text = "Buscar"
        BtnSearchName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnSearchName.UseAccentColor = False
        BtnSearchName.UseVisualStyleBackColor = True
        ' 
        ' TxtNameToSearch
        ' 
        TxtNameToSearch.AllowPromptAsInput = True
        TxtNameToSearch.AnimateReadOnly = False
        TxtNameToSearch.AsciiOnly = False
        TxtNameToSearch.BackgroundImageLayout = ImageLayout.None
        TxtNameToSearch.BeepOnError = False
        TxtNameToSearch.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        TxtNameToSearch.Depth = 0
        TxtNameToSearch.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtNameToSearch.HidePromptOnLeave = False
        TxtNameToSearch.HideSelection = True
        TxtNameToSearch.InsertKeyMode = InsertKeyMode.Default
        TxtNameToSearch.LeadingIcon = Nothing
        TxtNameToSearch.Location = New Point(17, 42)
        TxtNameToSearch.Mask = ""
        TxtNameToSearch.MaxLength = 32767
        TxtNameToSearch.MouseState = MaterialSkin.MouseState.OUT
        TxtNameToSearch.Name = "TxtNameToSearch"
        TxtNameToSearch.PasswordChar = ChrW(0)
        TxtNameToSearch.PrefixSuffixText = Nothing
        TxtNameToSearch.PromptChar = "_"c
        TxtNameToSearch.ReadOnly = False
        TxtNameToSearch.RejectInputOnFirstFailure = False
        TxtNameToSearch.ResetOnPrompt = True
        TxtNameToSearch.ResetOnSpace = True
        TxtNameToSearch.RightToLeft = RightToLeft.No
        TxtNameToSearch.SelectedText = ""
        TxtNameToSearch.SelectionLength = 0
        TxtNameToSearch.SelectionStart = 0
        TxtNameToSearch.ShortcutsEnabled = True
        TxtNameToSearch.Size = New Size(250, 48)
        TxtNameToSearch.SkipLiterals = True
        TxtNameToSearch.TabIndex = 12
        TxtNameToSearch.TabStop = False
        TxtNameToSearch.TextAlign = HorizontalAlignment.Left
        TxtNameToSearch.TextMaskFormat = MaskFormat.IncludeLiterals
        TxtNameToSearch.TrailingIcon = Nothing
        TxtNameToSearch.UseSystemPasswordChar = False
        TxtNameToSearch.ValidatingType = Nothing
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(17, 18)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(69, 19)
        MaterialLabel1.TabIndex = 11
        MaterialLabel1.Text = "Nombre : "
        ' 
        ' BtnDeleteFilters
        ' 
        BtnDeleteFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnDeleteFilters.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnDeleteFilters.Depth = 0
        BtnDeleteFilters.HighEmphasis = True
        BtnDeleteFilters.Icon = Nothing
        BtnDeleteFilters.Location = New Point(203, 293)
        BtnDeleteFilters.Margin = New Padding(4, 6, 4, 6)
        BtnDeleteFilters.MouseState = MaterialSkin.MouseState.HOVER
        BtnDeleteFilters.Name = "BtnDeleteFilters"
        BtnDeleteFilters.NoAccentTextColor = Color.Empty
        BtnDeleteFilters.Size = New Size(139, 36)
        BtnDeleteFilters.TabIndex = 28
        BtnDeleteFilters.Text = "Borrar Filtros"
        BtnDeleteFilters.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnDeleteFilters.UseAccentColor = False
        BtnDeleteFilters.UseVisualStyleBackColor = True
        ' 
        ' DeletedUsersPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BtnDeleteFilters)
        Controls.Add(Label2)
        Controls.Add(MaterialCard2)
        Controls.Add(BtnRestoreUser)
        Controls.Add(DgvDeletedUsers)
        Name = "DeletedUsersPage"
        Size = New Size(1906, 985)
        CType(DgvDeletedUsers, ComponentModel.ISupportInitialize).EndInit()
        MaterialCard2.ResumeLayout(False)
        MaterialCard2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvDeletedUsers As DataGridView
    Friend WithEvents BtnRestoreUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents BtnSearchName As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TxtNameToSearch As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BtnDeleteFilters As MaterialSkin.Controls.MaterialButton
End Class
