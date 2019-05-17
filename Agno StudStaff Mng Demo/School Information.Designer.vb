<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class School_Information
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label10 = New System.Windows.Forms.Label
        Me.grpButtons = New System.Windows.Forms.GroupBox
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpSchoolInfo = New System.Windows.Forms.GroupBox
        Me.lbweb = New System.Windows.Forms.Label
        Me.lbemail = New System.Windows.Forms.Label
        Me.lbcontct1 = New System.Windows.Forms.Label
        Me.lbcontct2 = New System.Windows.Forms.Label
        Me.lbstate = New System.Windows.Forms.Label
        Me.lbcity = New System.Windows.Forms.Label
        Me.lbadd = New System.Windows.Forms.Label
        Me.lbschool = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtSchoolName = New System.Windows.Forms.TextBox
        Me.txtcity = New System.Windows.Forms.TextBox
        Me.txtstate = New System.Windows.Forms.TextBox
        Me.txtWebsite = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtContact2 = New System.Windows.Forms.TextBox
        Me.txtContact1 = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.grpButtons.SuspendLayout()
        Me.grpSchoolInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DarkRed
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(227, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(356, 32)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "SCHOOL INFORMATION"
        '
        'grpButtons
        '
        Me.grpButtons.BackColor = System.Drawing.Color.Transparent
        Me.grpButtons.Controls.Add(Me.btnUpdate)
        Me.grpButtons.Controls.Add(Me.btnClose)
        Me.grpButtons.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.grpButtons.Location = New System.Drawing.Point(559, 1)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(135, 106)
        Me.grpButtons.TabIndex = 22
        Me.grpButtons.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnUpdate.Location = New System.Drawing.Point(15, 20)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 34)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(15, 66)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 34)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'grpSchoolInfo
        '
        Me.grpSchoolInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpSchoolInfo.Controls.Add(Me.grpButtons)
        Me.grpSchoolInfo.Controls.Add(Me.lbweb)
        Me.grpSchoolInfo.Controls.Add(Me.lbemail)
        Me.grpSchoolInfo.Controls.Add(Me.lbcontct1)
        Me.grpSchoolInfo.Controls.Add(Me.lbcontct2)
        Me.grpSchoolInfo.Controls.Add(Me.lbstate)
        Me.grpSchoolInfo.Controls.Add(Me.lbcity)
        Me.grpSchoolInfo.Controls.Add(Me.lbadd)
        Me.grpSchoolInfo.Controls.Add(Me.lbschool)
        Me.grpSchoolInfo.Controls.Add(Me.txtAddress)
        Me.grpSchoolInfo.Controls.Add(Me.txtSchoolName)
        Me.grpSchoolInfo.Controls.Add(Me.txtcity)
        Me.grpSchoolInfo.Controls.Add(Me.txtstate)
        Me.grpSchoolInfo.Controls.Add(Me.txtWebsite)
        Me.grpSchoolInfo.Controls.Add(Me.Label59)
        Me.grpSchoolInfo.Controls.Add(Me.txtEmail)
        Me.grpSchoolInfo.Controls.Add(Me.txtContact2)
        Me.grpSchoolInfo.Controls.Add(Me.txtContact1)
        Me.grpSchoolInfo.Controls.Add(Me.Label60)
        Me.grpSchoolInfo.Controls.Add(Me.Label61)
        Me.grpSchoolInfo.Controls.Add(Me.Label62)
        Me.grpSchoolInfo.Controls.Add(Me.Label63)
        Me.grpSchoolInfo.Controls.Add(Me.Label64)
        Me.grpSchoolInfo.Controls.Add(Me.Label65)
        Me.grpSchoolInfo.Controls.Add(Me.Label66)
        Me.grpSchoolInfo.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.grpSchoolInfo.Location = New System.Drawing.Point(36, 44)
        Me.grpSchoolInfo.Name = "grpSchoolInfo"
        Me.grpSchoolInfo.Size = New System.Drawing.Size(694, 422)
        Me.grpSchoolInfo.TabIndex = 21
        Me.grpSchoolInfo.TabStop = False
        '
        'lbweb
        '
        Me.lbweb.ForeColor = System.Drawing.Color.Black
        Me.lbweb.Location = New System.Drawing.Point(122, 374)
        Me.lbweb.Name = "lbweb"
        Me.lbweb.Size = New System.Drawing.Size(386, 32)
        Me.lbweb.TabIndex = 31
        Me.lbweb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbemail
        '
        Me.lbemail.ForeColor = System.Drawing.Color.Black
        Me.lbemail.Location = New System.Drawing.Point(244, 317)
        Me.lbemail.Name = "lbemail"
        Me.lbemail.Size = New System.Drawing.Size(387, 32)
        Me.lbemail.TabIndex = 30
        Me.lbemail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbcontct1
        '
        Me.lbcontct1.ForeColor = System.Drawing.Color.Black
        Me.lbcontct1.Location = New System.Drawing.Point(105, 263)
        Me.lbcontct1.Name = "lbcontct1"
        Me.lbcontct1.Size = New System.Drawing.Size(169, 32)
        Me.lbcontct1.TabIndex = 29
        Me.lbcontct1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbcontct2
        '
        Me.lbcontct2.ForeColor = System.Drawing.Color.Black
        Me.lbcontct2.Location = New System.Drawing.Point(381, 263)
        Me.lbcontct2.Name = "lbcontct2"
        Me.lbcontct2.Size = New System.Drawing.Size(206, 32)
        Me.lbcontct2.TabIndex = 28
        Me.lbcontct2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbstate
        '
        Me.lbstate.ForeColor = System.Drawing.Color.Black
        Me.lbstate.Location = New System.Drawing.Point(403, 197)
        Me.lbstate.Name = "lbstate"
        Me.lbstate.Size = New System.Drawing.Size(146, 32)
        Me.lbstate.TabIndex = 27
        Me.lbstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbcity
        '
        Me.lbcity.ForeColor = System.Drawing.Color.Black
        Me.lbcity.Location = New System.Drawing.Point(111, 194)
        Me.lbcity.Name = "lbcity"
        Me.lbcity.Size = New System.Drawing.Size(150, 32)
        Me.lbcity.TabIndex = 26
        Me.lbcity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbadd
        '
        Me.lbadd.ForeColor = System.Drawing.Color.Black
        Me.lbadd.Location = New System.Drawing.Point(134, 77)
        Me.lbadd.Name = "lbadd"
        Me.lbadd.Size = New System.Drawing.Size(265, 92)
        Me.lbadd.TabIndex = 25
        Me.lbadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbschool
        '
        Me.lbschool.ForeColor = System.Drawing.Color.Black
        Me.lbschool.Location = New System.Drawing.Point(140, 27)
        Me.lbschool.Name = "lbschool"
        Me.lbschool.Size = New System.Drawing.Size(368, 32)
        Me.lbschool.TabIndex = 24
        Me.lbschool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(134, 75)
        Me.txtAddress.MaxLength = 500
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(265, 94)
        Me.txtAddress.TabIndex = 2
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSchoolName
        '
        Me.txtSchoolName.BackColor = System.Drawing.Color.White
        Me.txtSchoolName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSchoolName.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtSchoolName.ForeColor = System.Drawing.Color.Black
        Me.txtSchoolName.Location = New System.Drawing.Point(140, 27)
        Me.txtSchoolName.MaxLength = 200
        Me.txtSchoolName.Name = "txtSchoolName"
        Me.txtSchoolName.Size = New System.Drawing.Size(368, 32)
        Me.txtSchoolName.TabIndex = 1
        Me.txtSchoolName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcity
        '
        Me.txtcity.BackColor = System.Drawing.Color.White
        Me.txtcity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcity.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtcity.ForeColor = System.Drawing.Color.Black
        Me.txtcity.Location = New System.Drawing.Point(115, 194)
        Me.txtcity.MaxLength = 25
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(146, 32)
        Me.txtcity.TabIndex = 23
        Me.txtcity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtstate
        '
        Me.txtstate.BackColor = System.Drawing.Color.White
        Me.txtstate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstate.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtstate.ForeColor = System.Drawing.Color.Black
        Me.txtstate.Location = New System.Drawing.Point(403, 197)
        Me.txtstate.MaxLength = 25
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(146, 32)
        Me.txtstate.TabIndex = 22
        Me.txtstate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWebsite
        '
        Me.txtWebsite.BackColor = System.Drawing.Color.White
        Me.txtWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWebsite.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtWebsite.ForeColor = System.Drawing.Color.Black
        Me.txtWebsite.Location = New System.Drawing.Point(106, 374)
        Me.txtWebsite.MaxLength = 30
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(386, 32)
        Me.txtWebsite.TabIndex = 8
        Me.txtWebsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label59.Location = New System.Drawing.Point(6, 377)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(75, 23)
        Me.Label59.TabIndex = 21
        Me.Label59.Text = "Website"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(106, 320)
        Me.txtEmail.MaxLength = 25
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(387, 32)
        Me.txtEmail.TabIndex = 7
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContact2
        '
        Me.txtContact2.BackColor = System.Drawing.Color.White
        Me.txtContact2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact2.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtContact2.ForeColor = System.Drawing.Color.Black
        Me.txtContact2.Location = New System.Drawing.Point(381, 263)
        Me.txtContact2.MaxLength = 15
        Me.txtContact2.Name = "txtContact2"
        Me.txtContact2.Size = New System.Drawing.Size(206, 32)
        Me.txtContact2.TabIndex = 6
        Me.txtContact2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContact1
        '
        Me.txtContact1.BackColor = System.Drawing.Color.White
        Me.txtContact1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact1.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtContact1.ForeColor = System.Drawing.Color.Black
        Me.txtContact1.Location = New System.Drawing.Point(106, 263)
        Me.txtContact1.MaxLength = 15
        Me.txtContact1.Name = "txtContact1"
        Me.txtContact1.Size = New System.Drawing.Size(168, 32)
        Me.txtContact1.TabIndex = 5
        Me.txtContact1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label60.Location = New System.Drawing.Point(15, 329)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(93, 23)
        Me.Label60.TabIndex = 17
        Me.Label60.Text = "E-mail ID"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label61.Location = New System.Drawing.Point(284, 263)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(91, 23)
        Me.Label61.TabIndex = 16
        Me.Label61.Text = "Contact 2"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label62.Location = New System.Drawing.Point(8, 266)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(91, 23)
        Me.Label62.TabIndex = 15
        Me.Label62.Text = "Contact 1"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label63.Location = New System.Drawing.Point(324, 200)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(51, 23)
        Me.Label63.TabIndex = 6
        Me.Label63.Text = "State"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label64.ForeColor = System.Drawing.Color.Black
        Me.Label64.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label64.Location = New System.Drawing.Point(15, 203)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(45, 23)
        Me.Label64.TabIndex = 4
        Me.Label64.Text = "City"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label65.Location = New System.Drawing.Point(15, 84)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(76, 23)
        Me.Label65.TabIndex = 2
        Me.Label65.Text = "Address"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label66.Location = New System.Drawing.Point(15, 30)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(122, 23)
        Me.Label66.TabIndex = 0
        Me.Label66.Text = "School Name"
        '
        'School_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 520)
        Me.Controls.Add(Me.grpSchoolInfo)
        Me.Controls.Add(Me.Label10)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "School_Information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "School_Information"
        Me.grpButtons.ResumeLayout(False)
        Me.grpSchoolInfo.ResumeLayout(False)
        Me.grpSchoolInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpSchoolInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtstate As System.Windows.Forms.TextBox
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtContact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtContact1 As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtSchoolName As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents lbweb As System.Windows.Forms.Label
    Friend WithEvents lbemail As System.Windows.Forms.Label
    Friend WithEvents lbcontct1 As System.Windows.Forms.Label
    Friend WithEvents lbcontct2 As System.Windows.Forms.Label
    Friend WithEvents lbstate As System.Windows.Forms.Label
    Friend WithEvents lbcity As System.Windows.Forms.Label
    Friend WithEvents lbadd As System.Windows.Forms.Label
    Friend WithEvents lbschool As System.Windows.Forms.Label
End Class
