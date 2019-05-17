<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Section
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Section))
        Me.ScnSave = New System.Windows.Forms.Button
        Me.ScnDelete = New System.Windows.Forms.Button
        Me.ScnClose = New System.Windows.Forms.Button
        Me.dgvsecn = New System.Windows.Forms.DataGridView
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbstandrd = New System.Windows.Forms.ComboBox
        Me.txtsecn = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpButtons = New System.Windows.Forms.GroupBox
        Me.ScnUpdate = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.dgvsecn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpButtons.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScnSave
        '
        Me.ScnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ScnSave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScnSave.ForeColor = System.Drawing.Color.Black
        Me.ScnSave.Location = New System.Drawing.Point(6, 19)
        Me.ScnSave.Name = "ScnSave"
        Me.ScnSave.Size = New System.Drawing.Size(71, 34)
        Me.ScnSave.TabIndex = 4
        Me.ScnSave.Text = "&ADD"
        Me.ScnSave.UseVisualStyleBackColor = False
        '
        'ScnDelete
        '
        Me.ScnDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ScnDelete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScnDelete.ForeColor = System.Drawing.Color.Black
        Me.ScnDelete.Location = New System.Drawing.Point(6, 67)
        Me.ScnDelete.Name = "ScnDelete"
        Me.ScnDelete.Size = New System.Drawing.Size(73, 34)
        Me.ScnDelete.TabIndex = 5
        Me.ScnDelete.Text = "&DELETE"
        Me.ScnDelete.UseVisualStyleBackColor = False
        '
        'ScnClose
        '
        Me.ScnClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ScnClose.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScnClose.ForeColor = System.Drawing.Color.Black
        Me.ScnClose.Location = New System.Drawing.Point(85, 67)
        Me.ScnClose.Name = "ScnClose"
        Me.ScnClose.Size = New System.Drawing.Size(75, 34)
        Me.ScnClose.TabIndex = 6
        Me.ScnClose.Text = "&CLOSE"
        Me.ScnClose.UseVisualStyleBackColor = False
        '
        'dgvsecn
        '
        Me.dgvsecn.AllowUserToAddRows = False
        Me.dgvsecn.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsecn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvsecn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsecn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column2, Me.Column1})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsecn.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvsecn.Location = New System.Drawing.Point(3, 145)
        Me.dgvsecn.Name = "dgvsecn"
        Me.dgvsecn.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsecn.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvsecn.Size = New System.Drawing.Size(393, 229)
        Me.dgvsecn.TabIndex = 7
        '
        'Column3
        '
        Me.Column3.HeaderText = "Id"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Standard Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column1
        '
        Me.Column1.HeaderText = "Section"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(47, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(770, 50)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(281, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "MANAGE SECTION "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbstandrd)
        Me.GroupBox1.Controls.Add(Me.txtsecn)
        Me.GroupBox1.Controls.Add(Me.dgvsecn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.grpButtons)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 380)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'cmbstandrd
        '
        Me.cmbstandrd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstandrd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbstandrd.FormattingEnabled = True
        Me.cmbstandrd.Location = New System.Drawing.Point(88, 34)
        Me.cmbstandrd.Name = "cmbstandrd"
        Me.cmbstandrd.Size = New System.Drawing.Size(121, 21)
        Me.cmbstandrd.TabIndex = 7
        '
        'txtsecn
        '
        Me.txtsecn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtsecn.Location = New System.Drawing.Point(88, 69)
        Me.txtsecn.Name = "txtsecn"
        Me.txtsecn.Size = New System.Drawing.Size(121, 20)
        Me.txtsecn.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Section"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Standard"
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.ScnUpdate)
        Me.grpButtons.Controls.Add(Me.ScnSave)
        Me.grpButtons.Controls.Add(Me.ScnDelete)
        Me.grpButtons.Controls.Add(Me.ScnClose)
        Me.grpButtons.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpButtons.Location = New System.Drawing.Point(225, 22)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(166, 107)
        Me.grpButtons.TabIndex = 2
        Me.grpButtons.TabStop = False
        '
        'ScnUpdate
        '
        Me.ScnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ScnUpdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScnUpdate.ForeColor = System.Drawing.Color.Black
        Me.ScnUpdate.Location = New System.Drawing.Point(83, 15)
        Me.ScnUpdate.Name = "ScnUpdate"
        Me.ScnUpdate.Size = New System.Drawing.Size(77, 34)
        Me.ScnUpdate.TabIndex = 2
        Me.ScnUpdate.Text = "&UPDATE"
        Me.ScnUpdate.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(487, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(330, 383)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'New_Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(883, 692)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "New_Section"
        Me.Text = "New Section"
        CType(Me.dgvsecn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpButtons.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ScnSave As System.Windows.Forms.Button
    Friend WithEvents ScnDelete As System.Windows.Forms.Button
    Friend WithEvents ScnClose As System.Windows.Forms.Button
    Friend WithEvents dgvsecn As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbstandrd As System.Windows.Forms.ComboBox
    Friend WithEvents txtsecn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents ScnUpdate As System.Windows.Forms.Button
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
