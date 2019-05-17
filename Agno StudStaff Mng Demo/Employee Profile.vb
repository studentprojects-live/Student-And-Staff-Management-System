Imports System.Data.SqlClient
Public Class Employee_Profile
    Dim des
    Dim dept
   
    
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "&Update" Then
            If MsgBoxResult.No = MsgBox("Are u sure u want to update the details of " & txtEmployeeID.Text, MsgBoxStyle.YesNo) Then
                btnUpdate.Text = "&Update"
                
                alldisable()
            Else
                designation()
                des = txtdes.Text
                dept = txtdept.Text
                txtdept.Visible = False
                txtdes.Visible = False

                cmbDesignation.Text = des
                cmbDepartment.Text = dept
                btnUpdate.Text = "&Save"
                btndelete.Visible = False
                allenable()
                Exit Sub
            End If
        ElseIf btnUpdate.Text = "&Save" Then
            If txtEmployeeID.Text = "" Or txtName.Text = "" Or cmbSex.Text = "" Or dtpDOB.Text = Date.Today Or txtlastqualifi.Text = "" Or txtPermanentAddress.Text = "" Or txtBasicSalary.Text = "" Or cmbDepartment.Text = "" Or cmbDesignation.Text = "" Or dtpDOfJoining.Text = Date.Today Or cmbCertificatesSubmitted.Text = "" Then
                MsgBox("Please enter all required field marked as * ")
            Else
                connection_open()
                sql = " update employee_tbl set Date_of_Birth=convert(date,'" & dtpDOB.Value & "',105), Name='" & txtName.Text & "',"
                sql = sql & "Sex='" & cmbSex.Text & "',Fathers_Name='" & txtFathersName.Text & "',Present_Address='" & txtAddress.Text & "',Permanent_address='" & txtPermanentAddress.Text & "',"
                sql = sql & "Mobile_No= '" & txtMobile.Text & "',Landline='" & txtLandline.Text & "',Email_Id='" & txtEMail.Text & "',Qualification='" & txtlastqualifi.Text & "',Date_of_join=convert(date,'" & dtpDOfJoining.Value & "',105),"
                sql = sql & " Maritial_Status='" & cmbMaritualStatus.Text & "',Photo='" & txtImagePath.Text & "',Department_Id="
                sql = sql & "'" & cmbDepartment.SelectedValue & "',Designation_Id='" & cmbDesignation.SelectedValue & "',Basic_Salary='" & txtBasicSalary.Text & "',Certificate='" & cmbCertificatesSubmitted.Text & "',"
                sql = sql & "HighSchool='" & chkbHighSchool.CheckState & "',Intermediate='" & chkbIntermediate.CheckState & "',Graduation='" & chkbGraduation.CheckState & "',Post_Graduation='" & chkbPostGraduation.CheckState & "',last_experience='" & txtLastExperience.Text & "',last_working_place='" & txtLastWorkingPlace.Text & "' "
                sql = sql & " where Employee_Id='" & txtEmployeeID.Text & "'"
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                connection_close()

                MsgBox("Employee " & txtEmployeeID.Text & " data has been Updated")
                Employee_list.Show()
                Me.Close()

            End If
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try

            If MsgBoxResult.No = MsgBox("Are You sure you want to deleted all the details of " & txtName.Text & " ", MsgBoxStyle.YesNo) Then Exit Sub
            connection_open()
            sql = " delete from Employee_tbl where Employee_Id='" & txtEmployeeID.Text & "'"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Record is deleted")
        Catch ex As Exception
            MsgBox(txtName.Text & " Employee has many records stored u may have to delete those record inorder to proceed")
        End Try
        clear()
    End Sub
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

    Private Sub cmbDesignation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDesignation.SelectedIndexChanged

        Try
            connection_open()
            sql = "select * from Department_tbl where Designation_Id='" & cmbDesignation.SelectedValue & "'"
            cmd = New SqlCommand(sql, cnn)
            adapter.SelectCommand = cmd
            ds1.Clear()

            adapter.Fill(ds1)
            cmbDepartment.DataSource = ds1.Tables(0)
            cmbDepartment.ValueMember = "Department_Id"
            cmbDepartment.DisplayMember = "Department_Name"
            cmbDepartment.SelectedIndex = -1
            connection_close()
        Catch ex As Exception

        End Try

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
        txtBasicSalary.Text = ""
        PbEmployeePhoto.ImageLocation = "E:\project\Pictre\NotAvailable"
        txtImagePath.Text = ""
        txtLandline.Text = ""
        txtMobile.Text = ""
        txtdept.Visible = False
        txtdes.Visible = False
    End Sub
    Sub alldisable()
        txtEmployeeID.Enabled = False
        txtName.Enabled = False
        cmbSex.Enabled = False
        txtFathersName.Enabled = False
        txtlastqualifi.Enabled = False
        cmbMaritualStatus.Enabled = False
        txtAddress.Enabled = False
        txtPermanentAddress.Enabled = False
        txtEMail.Enabled = False
        txtLastWorkingPlace.Enabled = False
        txtLastExperience.Enabled = False
        cmbCertificatesSubmitted.Enabled = False
        txtBasicSalary.Enabled = False
        PbEmployeePhoto.Enabled = False
        txtImagePath.Enabled = False
        txtLandline.Enabled = False
        txtMobile.Enabled = False
        dtpDOB.Enabled = False
        dtpDOfJoining.Enabled = False
        grpCheckbox.Enabled = False
        txtdept.Enabled = False
        txtdes.Enabled = False

    End Sub

    Sub allenable()

        txtName.Enabled = True
        cmbSex.Enabled = True
        txtFathersName.Enabled = True
        txtlastqualifi.Enabled = True
        cmbMaritualStatus.Enabled = True
        txtAddress.Enabled = True
        txtPermanentAddress.Enabled = True
        txtEMail.Enabled = True
        txtLastWorkingPlace.Enabled = True
        txtLastExperience.Enabled = True
        cmbCertificatesSubmitted.Enabled = True
        txtBasicSalary.Enabled = True
        PbEmployeePhoto.Enabled = True
        txtImagePath.Enabled = True
        txtLandline.Enabled = True
        txtMobile.Enabled = True
        dtpDOB.Enabled = True
        dtpDOfJoining.Enabled = True
        grpCheckbox.Enabled = True
        txtdept.Enabled = True
        txtdes.Enabled = True
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

    Private Sub Employee_Profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        txtEmployeeID.Enabled = False
        des = cmbDesignation.Text
        dept = cmbDepartment.Text
        alldisable()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True

        Me.Close()


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
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
        End If
    End Sub
    Private Sub txtLastWorkingPlace_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastWorkingPlace.KeyPress
        If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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
      
    
    Private Sub btnPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoto.Click
        OpenFileDialog1.ShowDialog()
        PbEmployeePhoto.ImageLocation = OpenFileDialog1.FileName
        txtImagePath.Text = OpenFileDialog1.FileName
    End Sub
End Class