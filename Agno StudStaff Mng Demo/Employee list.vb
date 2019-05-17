Imports System.Data.SqlClient
Public Class Employee_list
    Sub loadgrid()
        Try
            connection_open()
            sql = "SELECT     dbo.employee_tbl.Employee_Id, dbo.employee_tbl.Name, dbo.employee_tbl.Sex, dbo.employee_tbl.Qualification, dbo.employee_tbl.last_experience, "
            sql = sql & " dbo.Department_tbl.Department_Name, dbo.Designation_tbl.Designation_Name, dbo.employee_tbl.Basic_Salary"
            sql = sql & " FROM         dbo.Department_tbl INNER JOIN"
            sql = sql & "                    dbo.Designation_tbl ON dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id INNER JOIN"
            sql = sql & "                 dbo.employee_tbl ON dbo.Department_tbl.Department_Id = dbo.employee_tbl.Department_Id AND "
            sql = sql & "          dbo.Designation_tbl.Designation_Id = dbo.employee_tbl.Designation_Id"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim i = 0
            dgvEmployeeList.Rows.Clear()
            While reader.Read = True
                dgvEmployeeList.Rows.Add()
                dgvEmployeeList.Item(0, i).Value = reader(0)
                dgvEmployeeList.Item(1, i).Value = reader(1)
                dgvEmployeeList.Item(2, i).Value = reader(2)
                dgvEmployeeList.Item(3, i).Value = reader(3)
                dgvEmployeeList.Item(4, i).Value = reader(4)
                dgvEmployeeList.Item(5, i).Value = reader(5)
                dgvEmployeeList.Item(6, i).Value = reader(6)
                dgvEmployeeList.Item(7, i).Value = reader(7)
                i = i + 1
            End While
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvEmployeeList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmployeeList.CellDoubleClick
        connection_open()
        sql = "select * from Employee_tbl where Employee_Id='" & dgvEmployeeList.CurrentRow.Cells(0).Value & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            Employee_Profile.txtEmployeeID.Text = reader(0)
            Employee_Profile.txtName.Text = reader(1)
            Employee_Profile.cmbSex.Text = reader(2)
            Employee_Profile.dtpDOB.Value = reader(3)
            Employee_Profile.txtFathersName.Text = reader(4)
            Employee_Profile.txtAddress.Text = reader(5)
            Employee_Profile.txtPermanentAddress.Text = reader(6)
            Employee_Profile.txtMobile.Text = reader(7)
            Employee_Profile.txtLandline.Text = reader(8)
            Employee_Profile.txtEMail.Text = reader(9)
            Employee_Profile.txtlastqualifi.Text = reader(10)
            Employee_Profile.dtpDOfJoining.Value = reader(11)
            Employee_Profile.cmbMaritualStatus.Text = reader(12)
            Employee_Profile.txtdept.Text = dgvEmployeeList.CurrentRow.Cells(5).Value
            Employee_Profile.txtdes.Text = dgvEmployeeList.CurrentRow.Cells(6).Value
            
            Employee_Profile.txtBasicSalary.Text = reader(15)
            Employee_Profile.cmbCertificatesSubmitted.Text = reader(16)
            Employee_Profile.chkbHighSchool.Checked = reader(17)
            Employee_Profile.chkbIntermediate.Checked = reader(18)
            Employee_Profile.chkbGraduation.Checked = reader(19)
            Employee_Profile.chkbPostGraduation.Checked = reader(20)
            Employee_Profile.txtLastExperience.Text = reader(21)
            Employee_Profile.txtLastWorkingPlace.Text = reader(22)
            Employee_Profile.txtImagePath.Text = reader(23)
            Employee_Profile.PbEmployeePhoto.ImageLocation = reader(23)
        End If
        connection_close()
        Employee_Profile.Show()
        Me.Hide()

    End Sub

    Private Sub Employee_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        loadgrid()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
        txtSearchEmpInfo.Enabled = False
    End Sub

    Private Sub txtSearchEmpInfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchEmpInfo.KeyPress
        If cmbSearchEmp.SelectedIndex = 0 Then
            If Char.IsLetterOrDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        ElseIf cmbSearchEmp.SelectedIndex = 1 Then
            If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf cmbSearchEmp.SelectedIndex = 2 Then
            If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf cmbSearchEmp.SelectedIndex = 3 Then
            If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtSearchEmpInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchEmpInfo.TextChanged
        If cmbSearchEmp.Text = "Employee ID" Then
            connection_open()
            sql = "SELECT     dbo.employee_tbl.Employee_Id, dbo.employee_tbl.Name, dbo.employee_tbl.Sex, dbo.employee_tbl.Qualification, dbo.employee_tbl.last_experience, "
            sql = sql & " dbo.Department_tbl.Department_Name, dbo.Designation_tbl.Designation_Name, dbo.employee_tbl.Basic_Salary"
            sql = sql & " FROM         dbo.Department_tbl INNER JOIN"
            sql = sql & "                    dbo.Designation_tbl ON dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id INNER JOIN"
            sql = sql & "                 dbo.employee_tbl ON dbo.Department_tbl.Department_Id = dbo.employee_tbl.Department_Id AND "
            sql = sql & "          dbo.Designation_tbl.Designation_Id = dbo.employee_tbl.Designation_Id"
            sql = sql & "  WHERE    (dbo.employee_tbl.Employee_Id like  '" & txtSearchEmpInfo.Text & "%')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim f = 0
            dgvEmployeeList.Rows.Clear()
            While reader.Read = True
                dgvEmployeeList.Rows.Add()
                dgvEmployeeList.Item(0, f).Value = reader(0)
                dgvEmployeeList.Item(1, f).Value = reader(1)
                dgvEmployeeList.Item(2, f).Value = reader(2)
                dgvEmployeeList.Item(3, f).Value = reader(3)
                dgvEmployeeList.Item(4, f).Value = reader(4)
                dgvEmployeeList.Item(5, f).Value = reader(5)
                dgvEmployeeList.Item(6, f).Value = reader(6)
                dgvEmployeeList.Item(7, f).Value = reader(7)
                f = f + 1
            End While
            connection_close()
        ElseIf cmbSearchEmp.Text = "Employee Name" Then
            connection_open()
            sql = "SELECT     dbo.employee_tbl.Employee_Id, dbo.employee_tbl.Name, dbo.employee_tbl.Sex, dbo.employee_tbl.Qualification, dbo.employee_tbl.last_experience, "
            sql = sql & " dbo.Department_tbl.Department_Name, dbo.Designation_tbl.Designation_Name, dbo.employee_tbl.Basic_Salary"
            sql = sql & " FROM         dbo.Department_tbl INNER JOIN"
            sql = sql & "                    dbo.Designation_tbl ON dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id INNER JOIN"
            sql = sql & "                 dbo.employee_tbl ON dbo.Department_tbl.Department_Id = dbo.employee_tbl.Department_Id AND "
            sql = sql & "          dbo.Designation_tbl.Designation_Id = dbo.employee_tbl.Designation_Id"
            sql = sql & " WHERE     (dbo.employee_tbl.Name like '" & txtSearchEmpInfo.Text & "%')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim f = 0
            dgvEmployeeList.Rows.Clear()
            While reader.Read = True
                dgvEmployeeList.Rows.Add()
                dgvEmployeeList.Item(0, f).Value = reader(0)
                dgvEmployeeList.Item(1, f).Value = reader(1)
                dgvEmployeeList.Item(2, f).Value = reader(2)
                dgvEmployeeList.Item(3, f).Value = reader(3)
                dgvEmployeeList.Item(4, f).Value = reader(4)
                dgvEmployeeList.Item(5, f).Value = reader(5)
                dgvEmployeeList.Item(6, f).Value = reader(6)
                dgvEmployeeList.Item(7, f).Value = reader(7)
                f = f + 1
            End While
            connection_close()
        ElseIf cmbSearchEmp.Text = "Department" Then
            connection_open()
            sql = "SELECT     dbo.employee_tbl.Employee_Id, dbo.employee_tbl.Name, dbo.employee_tbl.Sex, dbo.employee_tbl.Qualification, dbo.employee_tbl.last_experience, "
            sql = sql & " dbo.Department_tbl.Department_Name, dbo.Designation_tbl.Designation_Name, dbo.employee_tbl.Basic_Salary"
            sql = sql & " FROM         dbo.Department_tbl INNER JOIN"
            sql = sql & "                    dbo.Designation_tbl ON dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id INNER JOIN"
            sql = sql & "                 dbo.employee_tbl ON dbo.Department_tbl.Department_Id = dbo.employee_tbl.Department_Id AND "
            sql = sql & "          dbo.Designation_tbl.Designation_Id = dbo.employee_tbl.Designation_Id"
            sql = sql & " WHERE     (dbo.Department_tbl.Department_Name like '" & txtSearchEmpInfo.Text & "%')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim f = 0
            dgvEmployeeList.Rows.Clear()
            While reader.Read = True
                dgvEmployeeList.Rows.Add()
                dgvEmployeeList.Item(0, f).Value = reader(0)
                dgvEmployeeList.Item(1, f).Value = reader(1)
                dgvEmployeeList.Item(2, f).Value = reader(2)
                dgvEmployeeList.Item(3, f).Value = reader(3)
                dgvEmployeeList.Item(4, f).Value = reader(4)
                dgvEmployeeList.Item(5, f).Value = reader(5)
                dgvEmployeeList.Item(6, f).Value = reader(6)
                dgvEmployeeList.Item(7, f).Value = reader(7)
                f = f + 1
            End While
            connection_close()
        ElseIf cmbSearchEmp.Text = "Designation" Then
            connection_open()
            sql = "SELECT     dbo.employee_tbl.Employee_Id, dbo.employee_tbl.Name, dbo.employee_tbl.Sex, dbo.employee_tbl.Qualification, dbo.employee_tbl.last_experience, "
            sql = sql & " dbo.Department_tbl.Department_Name, dbo.Designation_tbl.Designation_Name, dbo.employee_tbl.Basic_Salary"
            sql = sql & " FROM         dbo.Department_tbl INNER JOIN"
            sql = sql & "                    dbo.Designation_tbl ON dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id INNER JOIN"
            sql = sql & "                 dbo.employee_tbl ON dbo.Department_tbl.Department_Id = dbo.employee_tbl.Department_Id AND "
            sql = sql & "          dbo.Designation_tbl.Designation_Id = dbo.employee_tbl.Designation_Id  WHERE     (dbo.Designation_tbl.Designation_Name like '" & txtSearchEmpInfo.Text & "%')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim f = 0
            dgvEmployeeList.Rows.Clear()
            While reader.Read = True
                dgvEmployeeList.Rows.Add()
                dgvEmployeeList.Item(0, f).Value = reader(0)
                dgvEmployeeList.Item(1, f).Value = reader(1)
                dgvEmployeeList.Item(2, f).Value = reader(2)
                dgvEmployeeList.Item(3, f).Value = reader(3)
                dgvEmployeeList.Item(4, f).Value = reader(4)
                dgvEmployeeList.Item(5, f).Value = reader(5)
                dgvEmployeeList.Item(6, f).Value = reader(6)
                dgvEmployeeList.Item(7, f).Value = reader(7)
                f = f + 1
            End While
            connection_close()
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Agno_Student_And_Staff_Management_System.Show()
        Me.Close()

    End Sub

    Private Sub cmbSearchEmp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearchEmp.SelectedIndexChanged
        txtSearchEmpInfo.Enabled = True

        txtSearchEmpInfo.Text = ""

    End Sub
End Class