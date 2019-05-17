Imports System.Data.SqlClient

Public Class Staff_Detail
    Sub designation()
        connection_open()
        sql = "select * from Designation_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        cmbDesignation.DataSource = ds.Tables(0)
        cmbDesignation.ValueMember = "Designation_Id"
        cmbDesignation.DisplayMember = "Designation_Name"
        cmbDesignation.SelectedIndex = -1
        connection_close()

    End Sub


    Private Sub btnPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoto.Click
        OpenFileDialog1.ShowDialog()
        PbEmployeePhoto.ImageLocation = OpenFileDialog1.FileName
        txtImagePath.Text = OpenFileDialog1.FileName
    End Sub


    Private Sub cmbCertificatesSubmitted_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCertificatesSubmitted.SelectedIndexChanged
        If cmbCertificatesSubmitted.Text = "Yes" Then
            grpCheckbox.Enabled = True
        Else
            chkbGraduation.Checked = False
            chkbHighSchool.Checked = False
            chkbIntermediate.Checked = False
            chkbPostGraduation.Checked = False
            grpCheckbox.Enabled = False
        End If
    End Sub
    Sub clear()
        txtEmployeeID.Text = ""
        txtName.Text = ""
        cmbSex.SelectedIndex = -1
        txtFathersName.Text = ""
        txtlastqualifi.Text = ""
        cmbMaritualStatus.SelectedIndex = -1
        txtAddress.Text = ""
        txtPermanentAddress.Text = ""
        txtEMail.Text = ""
        txtLastWorkingPlace.Text = ""
        txtLastExperience.Text = ""
        cmbCertificatesSubmitted.SelectedIndex = 1
        txtBasicSalary.Text = "0"
        PbEmployeePhoto.ImageLocation = "E:\project\Pictre\NotAvailable"
        txtImagePath.Text = ""
        cmbDepartment.SelectedIndex = -1
        cmbDesignation.SelectedIndex = -1
      
        txtLandline.Text = ""
        txtMobile.Text = ""
    End Sub
    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub
    Private Sub txtBasicSalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBasicSalary.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtFathersName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFathersName.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtMobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "45" Or Asc(e.KeyChar) = "43" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtLandline_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLandline.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Staff_Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        btnSave.Enabled = False
        designation()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
    End Sub

    Private Sub txtEmployeeID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmployeeID.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtLastExperience_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastExperience.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "32" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtlastqualifi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlastqualifi.KeyPress
        If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "32" Or Asc(e.KeyChar) = "44" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmployeeID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmployeeID.Leave
        connection_open()

        sql = "select Employee_Id from employee_tbl where  Employee_Id='" & txtEmployeeID.Text & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            txtEmployeeID.Text = ""
        End If
        connection_close()

    End Sub


    Private Sub txtEmployeeID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeID.TextChanged
        If txtEmployeeID.Text = "" Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If

    End Sub

    Private Sub txtLastWorkingPlace_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastWorkingPlace.KeyPress
        If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "32" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    


    Private Sub cmbDesignation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDesignation.SelectedIndexChanged
        Try
            connection_open()
            sql = "select * from Department_tbl where Designation_Id='" & cmbDesignation.SelectedValue & "'"
            cmd = New SqlCommand(sql, cnn)
            adapter.SelectCommand = cmd
            ds1.Clear()
            adapter.Fill(ds1)
            cmbDepartment .DataSource = ds1.Tables(0)
            cmbDepartment.ValueMember = "Department_Id"
            cmbDepartment.DisplayMember = "Department_Name"
            cmbDepartment.SelectedIndex = -1
            connection_close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMobile_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobile.Leave
        If txtMobile.TextLength < 10 Then
            txtMobile.Text = "0"

        End If
    End Sub


    Private Sub txtLandline_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLandline.Leave
        If txtLandline.TextLength < 7 Then
            txtLandline.Text = "0"

        End If
    End Sub

  
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtEmployeeID.Text = "" Or txtName.Text = "" Or cmbSex.Text = "" Or dtpDOB.Text = Date.Today Or txtlastqualifi.Text = "" Or txtPermanentAddress.Text = "" Or txtBasicSalary.Text = "" Or cmbDepartment.Text = "" Or cmbDesignation.Text = "" Or dtpDOfJoining.Text = Date.Today Or cmbCertificatesSubmitted.Text = "" Then
            MsgBox("Please enter all required field marked as * ")
        Else
            connection_open()
            sql = " insert into Employee_tbl values ('" & txtEmployeeID.Text & "','" & txtName.Text & "','" & cmbSex.Text & "',convert(date,'" & dtpDOB.Text & "',105),'" & txtFathersName.Text & "',"
            sql = sql & "'" & txtAddress.Text & "','" & txtPermanentAddress.Text & "','" & txtMobile.Text & "','" & txtLandline.Text & "','" & txtEMail.Text & "','" & txtlastqualifi.Text & "',"
            sql = sql & "convert(date,'" & dtpDOfJoining.Text & "',105),'" & cmbMaritualStatus.Text & "','" & cmbDepartment.SelectedValue & "','" & cmbDesignation.SelectedValue & "','" & txtBasicSalary.Text & "',"
            sql = sql & "'" & cmbCertificatesSubmitted.Text & "','" & chkbHighSchool.CheckState & "','" & chkbIntermediate.CheckState & "','" & chkbGraduation.CheckState & "','" & chkbPostGraduation.CheckState & "',"
            sql = sql & " '" & txtLastExperience.Text & "','" & txtLastWorkingPlace.Text & "','" & txtImagePath.Text & "')"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox(txtName.Text & " Employee  has been Added")
            btnSave.Enabled = False
            clear()

        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Agno_Student_And_Staff_Management_System.Show()
        Me.Close()

    End Sub
End Class