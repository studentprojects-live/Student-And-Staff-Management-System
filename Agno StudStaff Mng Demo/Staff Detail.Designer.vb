<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Detail))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tpJobInformation = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmbDepartment = New System.Windows.Forms.ComboBox
        Me.dtpDOfJoining = New System.Windows.Forms.DateTimePicker
        Me.lblDesignation = New System.Windows.Forms.Label
        Me.txtBasicSalary = New System.Windows.Forms.TextBox
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.lblBasicSalary = New System.Windows.Forms.Label
        Me.cmbDesignation = New System.Windows.Forms.ComboBox
        Me.lblDateOfJoining = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.grpJobProfile = New System.Windows.Forms.GroupBox
        Me.txtLastExperience = New System.Windows.Forms.TextBox
        Me.grpCheckbox = New System.Windows.Forms.GroupBox
        Me.chkbPostGraduation = New System.Windows.Forms.CheckBox
        Me.chkbIntermediate = New System.Windows.Forms.CheckBox
        Me.chkbGraduation = New System.Windows.Forms.CheckBox
        Me.chkbHighSchool = New System.Windows.Forms.CheckBox
        Me.cmbCertificatesSubmitted = New System.Windows.Forms.ComboBox
        Me.lblCertificatesSubmitted = New System.Windows.Forms.Label
        Me.txtLastWorkingPlace = New System.Windows.Forms.TextBox
        Me.lblLastExperience = New System.Windows.Forms.Label
        Me.lblLastWorkingPlace = New System.Windows.Forms.Label
        Me.tpPersonalInformation = New System.Windows.Forms.TabPage
        Me.grp = New System.Windows.Forms.GroupBox
        Me.txtImagePath = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.PbEmployeePhoto = New System.Windows.Forms.PictureBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblMobile = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.txtLandline = New System.Windows.Forms.TextBox
        Me.lblLandLine = New System.Windows.Forms.Label
        Me.lblEMail = New System.Windows.Forms.Label
        Me.txtEMail = New System.Windows.Forms.TextBox
        Me.btnPhoto = New System.Windows.Forms.Button
        Me.grpAddressDetails = New System.Windows.Forms.GroupBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblPermanentAddress = New System.Windows.Forms.Label
        Me.txtPermanentAddress = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtEmployeeID = New System.Windows.Forms.TextBox
        Me.txtlastqualifi = New System.Windows.Forms.TextBox
        Me.lblEmployeeID = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblFathersName = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.lblLastQualification = New System.Windows.Forms.Label
        Me.lblDateofBirth = New System.Windows.Forms.Label
        Me.cmbSex = New System.Windows.Forms.ComboBox
        Me.lblSex = New System.Windows.Forms.Label
        Me.cmbMaritualStatus = New System.Windows.Forms.ComboBox
        Me.lblMaritulStatus = New System.Windows.Forms.Label
        Me.txtFathersName = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.tbEmployeeInformation = New System.Windows.Forms.TabControl
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        Me.tpJobInformation.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.grpJobProfile.SuspendLayout()
        Me.grpCheckbox.SuspendLayout()
        Me.tpPersonalInformation.SuspendLayout()
        Me.grp.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PbEmployeePhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.grpAddressDetails.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tbEmployeeInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 51)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(220, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EMPLOYEE REGISTRATION"
        '
        'tpJobInformation
        '
        Me.tpJobInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpJobInformation.Controls.Add(Me.GroupBox3)
        Me.tpJobInformation.Controls.Add(Me.GroupBox4)
        Me.tpJobInformation.Controls.Add(Me.GroupBox8)
        Me.tpJobInformation.Location = New System.Drawing.Point(4, 26)
        Me.tpJobInformation.Name = "tpJobInformation"
        Me.tpJobInformation.Size = New System.Drawing.Size(802, 450)
        Me.tpJobInformation.TabIndex = 2
        Me.tpJobInformation.Text = "Job Information"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Location = New System.Drawing.Point(585, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 52)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(87, 17)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(73, 29)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(6, 17)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 31)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmbDepartment)
        Me.GroupBox4.Controls.Add(Me.dtpDOfJoining)
        Me.GroupBox4.Controls.Add(Me.lblDesignation)
        Me.GroupBox4.Controls.Add(Me.txtBasicSalary)
        Me.GroupBox4.Controls.Add(Me.lblDepartment)
        Me.GroupBox4.Controls.Add(Me.lblBasicSalary)
        Me.GroupBox4.Controls.Add(Me.cmbDesignation)
        Me.GroupBox4.Controls.Add(Me.lblDateOfJoining)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(8, 196)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(548, 183)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Current"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(142, 69)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(123, 25)
        Me.cmbDepartment.TabIndex = 5
        '
        'dtpDOfJoining
        '
        Me.dtpDOfJoining.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOfJoining.Location = New System.Drawing.Point(142, 151)
        Me.dtpDOfJoining.Name = "dtpDOfJoining"
        Me.dtpDOfJoining.Size = New System.Drawing.Size(124, 25)
        Me.dtpDOfJoining.TabIndex = 8
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoSize = True
        Me.lblDesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDesignation.ForeColor = System.Drawing.Color.Black
        Me.lblDesignation.Location = New System.Drawing.Point(19, 31)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(90, 15)
        Me.lblDesignation.TabIndex = 23
        Me.lblDesignation.Text = "Designation*"
        '
        'txtBasicSalary
        '
        Me.txtBasicSalary.Location = New System.Drawing.Point(142, 107)
        Me.txtBasicSalary.MaxLength = 35
        Me.txtBasicSalary.Name = "txtBasicSalary"
        Me.txtBasicSalary.Size = New System.Drawing.Size(124, 25)
        Me.txtBasicSalary.TabIndex = 7
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDepartment.ForeColor = System.Drawing.Color.Black
        Me.lblDepartment.Location = New System.Drawing.Point(19, 72)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(88, 15)
        Me.lblDepartment.TabIndex = 24
        Me.lblDepartment.Text = "Department*"
        '
        'lblBasicSalary
        '
        Me.lblBasicSalary.AutoSize = True
        Me.lblBasicSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBasicSalary.ForeColor = System.Drawing.Color.Black
        Me.lblBasicSalary.Location = New System.Drawing.Point(15, 112)
        Me.lblBasicSalary.Name = "lblBasicSalary"
        Me.lblBasicSalary.Size = New System.Drawing.Size(92, 15)
        Me.lblBasicSalary.TabIndex = 25
        Me.lblBasicSalary.Text = "Basic Salary*"
        '
        'cmbDesignation
        '
        Me.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDesignation.FormattingEnabled = True
        Me.cmbDesignation.Location = New System.Drawing.Point(143, 28)
        Me.cmbDesignation.Name = "cmbDesignation"
        Me.cmbDesignation.Size = New System.Drawing.Size(123, 25)
        Me.cmbDesignation.TabIndex = 6
        '
        'lblDateOfJoining
        '
        Me.lblDateOfJoining.AutoSize = True
        Me.lblDateOfJoining.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDateOfJoining.ForeColor = System.Drawing.Color.Black
        Me.lblDateOfJoining.Location = New System.Drawing.Point(14, 153)
        Me.lblDateOfJoining.Name = "lblDateOfJoining"
        Me.lblDateOfJoining.Size = New System.Drawing.Size(110, 15)
        Me.lblDateOfJoining.TabIndex = 18
        Me.lblDateOfJoining.Text = "Date of Joining*"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.grpJobProfile)
        Me.GroupBox8.Location = New System.Drawing.Point(-4, -22)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(570, 449)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        '
        'grpJobProfile
        '
        Me.grpJobProfile.BackColor = System.Drawing.Color.Transparent
        Me.grpJobProfile.Controls.Add(Me.txtLastExperience)
        Me.grpJobProfile.Controls.Add(Me.grpCheckbox)
        Me.grpJobProfile.Controls.Add(Me.cmbCertificatesSubmitted)
        Me.grpJobProfile.Controls.Add(Me.lblCertificatesSubmitted)
        Me.grpJobProfile.Controls.Add(Me.txtLastWorkingPlace)
        Me.grpJobProfile.Controls.Add(Me.lblLastExperience)
        Me.grpJobProfile.Controls.Add(Me.lblLastWorkingPlace)
        Me.grpJobProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpJobProfile.ForeColor = System.Drawing.Color.Black
        Me.grpJobProfile.Location = New System.Drawing.Point(12, 29)
        Me.grpJobProfile.Name = "grpJobProfile"
        Me.grpJobProfile.Size = New System.Drawing.Size(548, 183)
        Me.grpJobProfile.TabIndex = 2
        Me.grpJobProfile.TabStop = False
        Me.grpJobProfile.Text = "Previous"
        '
        'txtLastExperience
        '
        Me.txtLastExperience.Location = New System.Drawing.Point(143, 75)
        Me.txtLastExperience.MaxLength = 10
        Me.txtLastExperience.Name = "txtLastExperience"
        Me.txtLastExperience.Size = New System.Drawing.Size(123, 20)
        Me.txtLastExperience.TabIndex = 2
        '
        'grpCheckbox
        '
        Me.grpCheckbox.Controls.Add(Me.chkbPostGraduation)
        Me.grpCheckbox.Controls.Add(Me.chkbIntermediate)
        Me.grpCheckbox.Controls.Add(Me.chkbGraduation)
        Me.grpCheckbox.Controls.Add(Me.chkbHighSchool)
        Me.grpCheckbox.Enabled = False
        Me.grpCheckbox.ForeColor = System.Drawing.Color.Black
        Me.grpCheckbox.Location = New System.Drawing.Point(300, 103)
        Me.grpCheckbox.Name = "grpCheckbox"
        Me.grpCheckbox.Size = New System.Drawing.Size(230, 74)
        Me.grpCheckbox.TabIndex = 4
        Me.grpCheckbox.TabStop = False
        '
        'chkbPostGraduation
        '
        Me.chkbPostGraduation.AutoSize = True
        Me.chkbPostGraduation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbPostGraduation.ForeColor = System.Drawing.Color.Black
        Me.chkbPostGraduation.Location = New System.Drawing.Point(115, 42)
        Me.chkbPostGraduation.Name = "chkbPostGraduation"
        Me.chkbPostGraduation.Size = New System.Drawing.Size(115, 17)
        Me.chkbPostGraduation.TabIndex = 3
        Me.chkbPostGraduation.Text = "Post graduation"
        Me.chkbPostGraduation.UseVisualStyleBackColor = True
        '
        'chkbIntermediate
        '
        Me.chkbIntermediate.AutoSize = True
        Me.chkbIntermediate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbIntermediate.ForeColor = System.Drawing.Color.Black
        Me.chkbIntermediate.Location = New System.Drawing.Point(6, 44)
        Me.chkbIntermediate.Name = "chkbIntermediate"
        Me.chkbIntermediate.Size = New System.Drawing.Size(96, 17)
        Me.chkbIntermediate.TabIndex = 2
        Me.chkbIntermediate.Text = "Intermediate"
        Me.chkbIntermediate.UseVisualStyleBackColor = True
        '
        'chkbGraduation
        '
        Me.chkbGraduation.AutoSize = True
        Me.chkbGraduation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbGraduation.ForeColor = System.Drawing.Color.Black
        Me.chkbGraduation.Location = New System.Drawing.Point(111, 19)
        Me.chkbGraduation.Name = "chkbGraduation"
        Me.chkbGraduation.Size = New System.Drawing.Size(88, 17)
        Me.chkbGraduation.TabIndex = 1
        Me.chkbGraduation.Text = "Graduation"
        Me.chkbGraduation.UseVisualStyleBackColor = True
        '
        'chkbHighSchool
        '
        Me.chkbHighSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbHighSchool.ForeColor = System.Drawing.Color.Black
        Me.chkbHighSchool.Location = New System.Drawing.Point(7, 21)
        Me.chkbHighSchool.Name = "chkbHighSchool"
        Me.chkbHighSchool.Size = New System.Drawing.Size(95, 17)
        Me.chkbHighSchool.TabIndex = 0
        Me.chkbHighSchool.Text = "High School"
        Me.chkbHighSchool.UseVisualStyleBackColor = False
        '
        'cmbCertificatesSubmitted
        '
        Me.cmbCertificatesSubmitted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCertificatesSubmitted.FormattingEnabled = True
        Me.cmbCertificatesSubmitted.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbCertificatesSubmitted.Location = New System.Drawing.Point(457, 74)
        Me.cmbCertificatesSubmitted.Name = "cmbCertificatesSubmitted"
        Me.cmbCertificatesSubmitted.Size = New System.Drawing.Size(62, 21)
        Me.cmbCertificatesSubmitted.TabIndex = 3
        '
        'lblCertificatesSubmitted
        '
        Me.lblCertificatesSubmitted.AutoSize = True
        Me.lblCertificatesSubmitted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCertificatesSubmitted.ForeColor = System.Drawing.Color.Black
        Me.lblCertificatesSubmitted.Location = New System.Drawing.Point(285, 75)
        Me.lblCertificatesSubmitted.Name = "lblCertificatesSubmitted"
        Me.lblCertificatesSubmitted.Size = New System.Drawing.Size(154, 15)
        Me.lblCertificatesSubmitted.TabIndex = 18
        Me.lblCertificatesSubmitted.Text = "Certificates Submitted*"
        '
        'txtLastWorkingPlace
        '
        Me.txtLastWorkingPlace.Location = New System.Drawing.Point(142, 39)
        Me.txtLastWorkingPlace.MaxLength = 100
        Me.txtLastWorkingPlace.Multiline = True
        Me.txtLastWorkingPlace.Name = "txtLastWorkingPlace"
        Me.txtLastWorkingPlace.Size = New System.Drawing.Size(319, 22)
        Me.txtLastWorkingPlace.TabIndex = 0
        '
        'lblLastExperience
        '
        Me.lblLastExperience.AutoSize = True
        Me.lblLastExperience.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastExperience.ForeColor = System.Drawing.Color.Black
        Me.lblLastExperience.Location = New System.Drawing.Point(11, 76)
        Me.lblLastExperience.Name = "lblLastExperience"
        Me.lblLastExperience.Size = New System.Drawing.Size(110, 15)
        Me.lblLastExperience.TabIndex = 2
        Me.lblLastExperience.Text = "Last Experience"
        '
        'lblLastWorkingPlace
        '
        Me.lblLastWorkingPlace.AutoSize = True
        Me.lblLastWorkingPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastWorkingPlace.ForeColor = System.Drawing.Color.Black
        Me.lblLastWorkingPlace.Location = New System.Drawing.Point(6, 39)
        Me.lblLastWorkingPlace.Name = "lblLastWorkingPlace"
        Me.lblLastWorkingPlace.Size = New System.Drawing.Size(130, 15)
        Me.lblLastWorkingPlace.TabIndex = 0
        Me.lblLastWorkingPlace.Text = "Last Working Place"
        '
        'tpPersonalInformation
        '
        Me.tpPersonalInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpPersonalInformation.Controls.Add(Me.grp)
        Me.tpPersonalInformation.Location = New System.Drawing.Point(4, 26)
        Me.tpPersonalInformation.Name = "tpPersonalInformation"
        Me.tpPersonalInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPersonalInformation.Size = New System.Drawing.Size(802, 450)
        Me.tpPersonalInformation.TabIndex = 0
        Me.tpPersonalInformation.Text = "Personal Information"
        '
        'grp
        '
        Me.grp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grp.Controls.Add(Me.txtImagePath)
        Me.grp.Controls.Add(Me.GroupBox6)
        Me.grp.Controls.Add(Me.GroupBox5)
        Me.grp.Controls.Add(Me.btnPhoto)
        Me.grp.Controls.Add(Me.grpAddressDetails)
        Me.grp.Controls.Add(Me.GroupBox2)
        Me.grp.Location = New System.Drawing.Point(-4, -9)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(788, 460)
        Me.grp.TabIndex = 1
        Me.grp.TabStop = False
        '
        'txtImagePath
        '
        Me.txtImagePath.Location = New System.Drawing.Point(589, 191)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.ReadOnly = True
        Me.txtImagePath.Size = New System.Drawing.Size(129, 25)
        Me.txtImagePath.TabIndex = 31
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PbEmployeePhoto)
        Me.GroupBox6.Location = New System.Drawing.Point(584, 24)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(150, 161)
        Me.GroupBox6.TabIndex = 30
        Me.GroupBox6.TabStop = False
        '
        'PbEmployeePhoto
        '
        Me.PbEmployeePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbEmployeePhoto.ErrorImage = Nothing
        Me.PbEmployeePhoto.Image = CType(resources.GetObject("PbEmployeePhoto.Image"), System.Drawing.Image)
        Me.PbEmployeePhoto.InitialImage = Nothing
        Me.PbEmployeePhoto.Location = New System.Drawing.Point(13, 17)
        Me.PbEmployeePhoto.Name = "PbEmployeePhoto"
        Me.PbEmployeePhoto.Size = New System.Drawing.Size(121, 138)
        Me.PbEmployeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEmployeePhoto.TabIndex = 29
        Me.PbEmployeePhoto.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblMobile)
        Me.GroupBox5.Controls.Add(Me.txtMobile)
        Me.GroupBox5.Controls.Add(Me.txtLandline)
        Me.GroupBox5.Controls.Add(Me.lblLandLine)
        Me.GroupBox5.Controls.Add(Me.lblEMail)
        Me.GroupBox5.Controls.Add(Me.txtEMail)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(10, 334)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(541, 112)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Contact Details"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.ForeColor = System.Drawing.Color.Black
        Me.lblMobile.Location = New System.Drawing.Point(10, 17)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(43, 15)
        Me.lblMobile.TabIndex = 10
        Me.lblMobile.Text = "Mobile"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(111, 16)
        Me.txtMobile.MaxLength = 15
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(153, 21)
        Me.txtMobile.TabIndex = 0
        '
        'txtLandline
        '
        Me.txtLandline.Location = New System.Drawing.Point(111, 48)
        Me.txtLandline.MaxLength = 11
        Me.txtLandline.Name = "txtLandline"
        Me.txtLandline.Size = New System.Drawing.Size(153, 21)
        Me.txtLandline.TabIndex = 1
        '
        'lblLandLine
        '
        Me.lblLandLine.AutoSize = True
        Me.lblLandLine.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLandLine.ForeColor = System.Drawing.Color.Black
        Me.lblLandLine.Location = New System.Drawing.Point(10, 50)
        Me.lblLandLine.Name = "lblLandLine"
        Me.lblLandLine.Size = New System.Drawing.Size(55, 15)
        Me.lblLandLine.TabIndex = 11
        Me.lblLandLine.Text = "Landline"
        '
        'lblEMail
        '
        Me.lblEMail.AutoSize = True
        Me.lblEMail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEMail.ForeColor = System.Drawing.Color.Black
        Me.lblEMail.Location = New System.Drawing.Point(10, 85)
        Me.lblEMail.Name = "lblEMail"
        Me.lblEMail.Size = New System.Drawing.Size(41, 15)
        Me.lblEMail.TabIndex = 28
        Me.lblEMail.Text = "E-Mail"
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(111, 80)
        Me.txtEMail.MaxLength = 11
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(153, 21)
        Me.txtEMail.TabIndex = 2
        '
        'btnPhoto
        '
        Me.btnPhoto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnPhoto.Location = New System.Drawing.Point(609, 217)
        Me.btnPhoto.Name = "btnPhoto"
        Me.btnPhoto.Size = New System.Drawing.Size(97, 24)
        Me.btnPhoto.TabIndex = 0
        Me.btnPhoto.Text = "&Photo"
        Me.btnPhoto.UseVisualStyleBackColor = True
        '
        'grpAddressDetails
        '
        Me.grpAddressDetails.Controls.Add(Me.txtAddress)
        Me.grpAddressDetails.Controls.Add(Me.lblAddress)
        Me.grpAddressDetails.Controls.Add(Me.lblPermanentAddress)
        Me.grpAddressDetails.Controls.Add(Me.txtPermanentAddress)
        Me.grpAddressDetails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddressDetails.ForeColor = System.Drawing.Color.Black
        Me.grpAddressDetails.Location = New System.Drawing.Point(6, 155)
        Me.grpAddressDetails.Name = "grpAddressDetails"
        Me.grpAddressDetails.Size = New System.Drawing.Size(545, 173)
        Me.grpAddressDetails.TabIndex = 1
        Me.grpAddressDetails.TabStop = False
        Me.grpAddressDetails.Text = "Address Details"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(116, 17)
        Me.txtAddress.MaxLength = 200
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(330, 75)
        Me.txtAddress.TabIndex = 0
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(17, 23)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(101, 15)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Present  Address"
        '
        'lblPermanentAddress
        '
        Me.lblPermanentAddress.AutoSize = True
        Me.lblPermanentAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermanentAddress.ForeColor = System.Drawing.Color.Black
        Me.lblPermanentAddress.Location = New System.Drawing.Point(17, 101)
        Me.lblPermanentAddress.Name = "lblPermanentAddress"
        Me.lblPermanentAddress.Size = New System.Drawing.Size(68, 30)
        Me.lblPermanentAddress.TabIndex = 9
        Me.lblPermanentAddress.Text = "Permanent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Address*"
        '
        'txtPermanentAddress
        '
        Me.txtPermanentAddress.Location = New System.Drawing.Point(115, 98)
        Me.txtPermanentAddress.MaximumSize = New System.Drawing.Size(331, 69)
        Me.txtPermanentAddress.MaxLength = 200
        Me.txtPermanentAddress.Multiline = True
        Me.txtPermanentAddress.Name = "txtPermanentAddress"
        Me.txtPermanentAddress.Size = New System.Drawing.Size(331, 69)
        Me.txtPermanentAddress.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtEmployeeID)
        Me.GroupBox2.Controls.Add(Me.txtlastqualifi)
        Me.GroupBox2.Controls.Add(Me.lblEmployeeID)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.lblFathersName)
        Me.GroupBox2.Controls.Add(Me.dtpDOB)
        Me.GroupBox2.Controls.Add(Me.lblLastQualification)
        Me.GroupBox2.Controls.Add(Me.lblDateofBirth)
        Me.GroupBox2.Controls.Add(Me.cmbSex)
        Me.GroupBox2.Controls.Add(Me.lblSex)
        Me.GroupBox2.Controls.Add(Me.cmbMaritualStatus)
        Me.GroupBox2.Controls.Add(Me.lblMaritulStatus)
        Me.GroupBox2.Controls.Add(Me.txtFathersName)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(10, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(541, 134)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personal information"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(131, 20)
        Me.txtEmployeeID.MaxLength = 10
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(139, 21)
        Me.txtEmployeeID.TabIndex = 9
        '
        'txtlastqualifi
        '
        Me.txtlastqualifi.Location = New System.Drawing.Point(131, 102)
        Me.txtlastqualifi.MaxLength = 20
        Me.txtlastqualifi.Name = "txtlastqualifi"
        Me.txtlastqualifi.Size = New System.Drawing.Size(139, 21)
        Me.txtlastqualifi.TabIndex = 8
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeID.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeID.Location = New System.Drawing.Point(13, 23)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(83, 15)
        Me.lblEmployeeID.TabIndex = 0
        Me.lblEmployeeID.Text = "Employee Id *"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(10, 50)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(46, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name*"
        '
        'lblFathersName
        '
        Me.lblFathersName.AutoSize = True
        Me.lblFathersName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFathersName.ForeColor = System.Drawing.Color.Black
        Me.lblFathersName.Location = New System.Drawing.Point(10, 78)
        Me.lblFathersName.Name = "lblFathersName"
        Me.lblFathersName.Size = New System.Drawing.Size(88, 15)
        Me.lblFathersName.TabIndex = 2
        Me.lblFathersName.Text = "Father's Name"
        '
        'dtpDOB
        '
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(367, 45)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(150, 21)
        Me.dtpDOB.TabIndex = 5
        '
        'lblLastQualification
        '
        Me.lblLastQualification.AutoSize = True
        Me.lblLastQualification.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastQualification.ForeColor = System.Drawing.Color.Black
        Me.lblLastQualification.Location = New System.Drawing.Point(10, 106)
        Me.lblLastQualification.Name = "lblLastQualification"
        Me.lblLastQualification.Size = New System.Drawing.Size(83, 15)
        Me.lblLastQualification.TabIndex = 3
        Me.lblLastQualification.Text = " Qualification*"
        '
        'lblDateofBirth
        '
        Me.lblDateofBirth.AutoSize = True
        Me.lblDateofBirth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateofBirth.ForeColor = System.Drawing.Color.Black
        Me.lblDateofBirth.Location = New System.Drawing.Point(280, 50)
        Me.lblDateofBirth.Name = "lblDateofBirth"
        Me.lblDateofBirth.Size = New System.Drawing.Size(79, 15)
        Me.lblDateofBirth.TabIndex = 4
        Me.lblDateofBirth.Text = "Date of Birth*"
        '
        'cmbSex
        '
        Me.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbSex.Location = New System.Drawing.Point(367, 72)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(150, 23)
        Me.cmbSex.TabIndex = 6
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.Black
        Me.lblSex.Location = New System.Drawing.Point(280, 79)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(32, 15)
        Me.lblSex.TabIndex = 5
        Me.lblSex.Text = "Sex*"
        '
        'cmbMaritualStatus
        '
        Me.cmbMaritualStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaritualStatus.FormattingEnabled = True
        Me.cmbMaritualStatus.Items.AddRange(New Object() {"Unmarried", "Married", "Divorcee"})
        Me.cmbMaritualStatus.Location = New System.Drawing.Point(367, 101)
        Me.cmbMaritualStatus.Name = "cmbMaritualStatus"
        Me.cmbMaritualStatus.Size = New System.Drawing.Size(151, 23)
        Me.cmbMaritualStatus.TabIndex = 7
        '
        'lblMaritulStatus
        '
        Me.lblMaritulStatus.AutoSize = True
        Me.lblMaritulStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaritulStatus.ForeColor = System.Drawing.Color.Black
        Me.lblMaritulStatus.Location = New System.Drawing.Point(276, 106)
        Me.lblMaritulStatus.Name = "lblMaritulStatus"
        Me.lblMaritulStatus.Size = New System.Drawing.Size(89, 15)
        Me.lblMaritulStatus.TabIndex = 6
        Me.lblMaritulStatus.Text = "Maritul Status *"
        '
        'txtFathersName
        '
        Me.txtFathersName.Location = New System.Drawing.Point(131, 75)
        Me.txtFathersName.MaxLength = 75
        Me.txtFathersName.Name = "txtFathersName"
        Me.txtFathersName.Size = New System.Drawing.Size(139, 21)
        Me.txtFathersName.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(131, 47)
        Me.txtName.MaxLength = 75
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(139, 21)
        Me.txtName.TabIndex = 2
        '
        'tbEmployeeInformation
        '
        Me.tbEmployeeInformation.AllowDrop = True
        Me.tbEmployeeInformation.Controls.Add(Me.tpPersonalInformation)
        Me.tbEmployeeInformation.Controls.Add(Me.tpJobInformation)
        Me.tbEmployeeInformation.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmployeeInformation.Location = New System.Drawing.Point(12, 82)
        Me.tbEmployeeInformation.Name = "tbEmployeeInformation"
        Me.tbEmployeeInformation.SelectedIndex = 0
        Me.tbEmployeeInformation.Size = New System.Drawing.Size(810, 480)
        Me.tbEmployeeInformation.TabIndex = 25
        Me.tbEmployeeInformation.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Staff_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(883, 650)
        Me.Controls.Add(Me.tbEmployeeInformation)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Staff_Detail"
        Me.Text = "Staff_Detail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpJobInformation.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.grpJobProfile.ResumeLayout(False)
        Me.grpJobProfile.PerformLayout()
        Me.grpCheckbox.ResumeLayout(False)
        Me.grpCheckbox.PerformLayout()
        Me.tpPersonalInformation.ResumeLayout(False)
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.PbEmployeePhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.grpAddressDetails.ResumeLayout(False)
        Me.grpAddressDetails.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tbEmployeeInformation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tpJobInformation As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDOfJoining As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDesignation As System.Windows.Forms.Label
    Friend WithEvents txtBasicSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblBasicSalary As System.Windows.Forms.Label
    Friend WithEvents cmbDesignation As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateOfJoining As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents grpJobProfile As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastExperience As System.Windows.Forms.TextBox
    Friend WithEvents grpCheckbox As System.Windows.Forms.GroupBox
    Friend WithEvents chkbPostGraduation As System.Windows.Forms.CheckBox
    Friend WithEvents chkbIntermediate As System.Windows.Forms.CheckBox
    Friend WithEvents chkbGraduation As System.Windows.Forms.CheckBox
    Friend WithEvents chkbHighSchool As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCertificatesSubmitted As System.Windows.Forms.ComboBox
    Friend WithEvents lblCertificatesSubmitted As System.Windows.Forms.Label
    Friend WithEvents txtLastWorkingPlace As System.Windows.Forms.TextBox
    Friend WithEvents lblLastExperience As System.Windows.Forms.Label
    Friend WithEvents lblLastWorkingPlace As System.Windows.Forms.Label
    Friend WithEvents tpPersonalInformation As System.Windows.Forms.TabPage
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents txtImagePath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PbEmployeePhoto As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtLandline As System.Windows.Forms.TextBox
    Friend WithEvents lblLandLine As System.Windows.Forms.Label
    Friend WithEvents lblEMail As System.Windows.Forms.Label
    Friend WithEvents txtEMail As System.Windows.Forms.TextBox
    Friend WithEvents btnPhoto As System.Windows.Forms.Button
    Friend WithEvents grpAddressDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblPermanentAddress As System.Windows.Forms.Label
    Friend WithEvents txtPermanentAddress As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEmployeeID As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblFathersName As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblLastQualification As System.Windows.Forms.Label
    Friend WithEvents lblDateofBirth As System.Windows.Forms.Label
    Friend WithEvents cmbSex As System.Windows.Forms.ComboBox
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents cmbMaritualStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblMaritulStatus As System.Windows.Forms.Label
    Friend WithEvents txtFathersName As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents tbEmployeeInformation As System.Windows.Forms.TabControl
    Friend WithEvents txtlastqualifi As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
