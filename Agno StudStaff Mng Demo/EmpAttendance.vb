Imports System.Data.SqlClient
Public Class EmpAttendance
    Dim m As Integer
    Dim ai
    Sub aidd()
        connection_open()
        sql = "Select max(Attendance_Id)+1 from Employee_Attendance "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                ai = "1"
            Else
                ai = reader(0)
            End If
        End If
        connection_close()
    End Sub
    Private Sub EmpAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        If Today.Month = "1" Then
            txtyear.Text = (Today.Year) - 1
        Else
            txtyear.Text = (Today.Year)
        End If

        empname()
        grid()

        btnsave.Enabled = False
        txtpresent.Enabled = False
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

    End Sub
    Sub empname()
        ds2.Clear()
        connection_open()
        sql = "select * from employee_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds2)
        cmbempname.DataSource = ds2.Tables(0)
        cmbempname.ValueMember = "Employee_Id"
        cmbempname.DisplayMember = "Name"
        cmbempname.SelectedIndex = -1
        connection_close()
    End Sub

    Private Sub cmbmonth_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbmonth.Leave
        Try
            connection_open()
            sql = "select Working_days from work_day where year='" & txtyear.Text & "' and month='" & cmbmonth.SelectedIndex & "' "
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                txtworkday.Text = reader(0)
            End If
            connection_close()


            
        Catch ex As Exception

        End Try
    End Sub

    


    Private Sub txtpresent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpresent.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtpresent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpresent.TextChanged
        If Val(txtpresent.Text) < Val(txtworkday.Text) Then
            btnsave.Enabled = True

            txtabsent.Text = Val(txtworkday.Text) - Val(txtpresent.Text)
        Else
            btnsave.Enabled = False
            txtabsent.Text = ""
        End If


    End Sub
    Sub clear()
        txtabsent.Text = ""
        txtpresent.Text = ""
        txtworkday.Text = ""
        txtabsent.Text = ""
        btnsave.Enabled = False
        txtpresent.Enabled = False
        cmbempname.SelectedIndex = -1
        cmbmonth.SelectedIndex = 0

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cmbempname.SelectedIndex = -1 Or cmbmonth.SelectedIndex = -1 Or cmbmonth.SelectedIndex = 0 Or txtpresent.Text = "" Then
            MsgBox("Enter all the fileds")
        Else
            aidd()
            connection_open()

            sql = "insert into Employee_Attendance values('" & Val(ai) & "','" & cmbempname.SelectedValue & "','" & txtyear.Text & "','" & cmbmonth.SelectedIndex & "','" & txtpresent.Text & "')"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Record has been Saved")
            connection_close()
            clear()
            grid()

            TabControl1.SelectedTab = tpAttendancelist
        End If

    End Sub
    Sub grid()
        Try
            connection_open()
            sql = "SELECT     dbo.Employee_Attendance.Attendance_Id, dbo.employee_tbl.Name, dbo.Designation_tbl.Designation_Name, dbo.Department_tbl.Department_Name, "
            sql = sql & "    dbo.Employee_Attendance.Year, dbo.Employee_Attendance.Month, dbo.Employee_Attendance.Days_Present"
            sql = sql & "   FROM         dbo.employee_tbl INNER JOIN"
            sql = sql & "                  dbo.Employee_Attendance ON dbo.employee_tbl.Employee_Id = dbo.Employee_Attendance.Employee_Id INNER JOIN"
            sql = sql & "     dbo.Department_tbl ON dbo.employee_tbl.Department_Id = dbo.Department_tbl.Department_Id INNER JOIN"
            sql = sql & "               dbo.Designation_tbl ON dbo.employee_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id AND "
            sql = sql & "            dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id "
            sql = sql & " ORDER BY dbo.Employee_Attendance.Year DESC"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim i = 0
            While reader.Read = True

                dgvattendanceList.Rows.Add()
                dgvattendanceList.Item(0, i).Value = reader(0)
                dgvattendanceList.Item(1, i).Value = reader(1)
                dgvattendanceList.Item(2, i).Value = reader(2)
                dgvattendanceList.Item(3, i).Value = reader(3)
                dgvattendanceList.Item(4, i).Value = reader(4)
                If reader(5) = 1 Then
                    dgvattendanceList.Item(5, i).Value = "January"
                ElseIf reader(5) = 2 Then
                    dgvattendanceList.Item(5, i).Value = "February"
                ElseIf reader(5) = 3 Then
                    dgvattendanceList.Item(5, i).Value = "March"
                ElseIf reader(5) = 4 Then
                    dgvattendanceList.Item(5, i).Value = "April"
                ElseIf reader(5) = 5 Then
                    dgvattendanceList.Item(5, i).Value = "May"
                ElseIf reader(5) = 6 Then
                    dgvattendanceList.Item(5, i).Value = "June"
                ElseIf reader(5) = 7 Then
                    dgvattendanceList.Item(5, i).Value = "July"
                ElseIf reader(5) = 8 Then
                    dgvattendanceList.Item(5, i).Value = "August"
                ElseIf reader(5) = 9 Then
                    dgvattendanceList.Item(5, i).Value = "September"
                ElseIf reader(5) = 10 Then
                    dgvattendanceList.Item(5, i).Value = "October"
                ElseIf reader(5) = 11 Then
                    dgvattendanceList.Item(5, i).Value = "November"
                ElseIf reader(5) = 12 Then
                    dgvattendanceList.Item(5, i).Value = "December"
                End If

                dgvattendanceList.Item(6, i).Value = reader(6)
                i = i + 1
            End While
            connection_close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("Are you sure u want to delete all the records present in the Table", MsgBoxStyle.YesNo) Then Exit Sub
        connection_open()
        sql = "delete from Employee_Attendance  "
        cmd = New SqlCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        MsgBox("Record has been Deleted from the table ")
        connection_close()
        grid()
        clear()


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Show()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

    End Sub


    Private Sub txtworkday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtworkday.TextChanged
        If txtworkday.Text = "" Then
            cmbempname.Enabled = False

            cmbmonth.SelectedIndex = 0
        Else
            txtpresent.Enabled = True
            cmbempname.Enabled = True

        End If

    End Sub

    Private Sub txtSearchEmpInfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchEmpInfo.KeyPress
        If cmbSearchEmp.SelectedIndex = 0 Then
            If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
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
        ElseIf cmbSearchEmp.SelectedIndex = 2 Then
            If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSearchEmpInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchEmpInfo.TextChanged
        If cmbSearchEmp.Text = "Employee Name" Then
            connection_open()
            sql = "  SELECT     TOP (100) PERCENT dbo.Employee_Attendance.Attendance_Id, dbo.employee_tbl.Name, dbo.Designation_tbl.Designation_Name, "
            sql = sql & " dbo.Department_tbl.Department_Name, dbo.work_day.year, dbo.work_day.month, dbo.Employee_Attendance.Days_Present"
            sql = sql & " FROM         dbo.Department_tbl INNER JOIN"
            sql = sql & "                     dbo.Designation_tbl ON dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id INNER JOIN"
            sql = sql & "                   dbo.employee_tbl ON dbo.Department_tbl.Department_Id = dbo.employee_tbl.Department_Id AND "
            sql = sql & "               dbo.Designation_tbl.Designation_Id = dbo.employee_tbl.Designation_Id INNER JOIN"
            sql = sql & "                  dbo.Employee_Attendance ON dbo.employee_tbl.Employee_Id = dbo.Employee_Attendance.Employee_Id CROSS JOIN"
            sql = sql & "            dbo.work_day"
            sql = sql & " WHERE     (dbo.employee_tbl.Name like '" & txtSearchEmpInfo.Text & "%')"
            sql = sql & " ORDER BY dbo.work_day.year DESC"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim g = 0
            dgvattendanceList.Rows.Clear()
            While reader.Read = True
                dgvattendanceList.Rows.Add()
                dgvattendanceList.Item(0, g).Value = reader(0)
                dgvattendanceList.Item(1, g).Value = reader(1)
                dgvattendanceList.Item(2, g).Value = reader(2)
                dgvattendanceList.Item(3, g).Value = reader(3)
                dgvattendanceList.Item(4, g).Value = reader(4)
                dgvattendanceList.Item(5, g).Value = reader(5)
                dgvattendanceList.Item(6, g).Value = reader(6)

                g = g + 1
            End While
            connection_close()
        ElseIf cmbSearchEmp.Text = "Designation" Then
            connection_open()
            sql = "  SELECT     TOP (100) PERCENT dbo.Employee_Attendance.Attendance_Id, dbo.employee_tbl.Name, dbo.Designation_tbl.Designation_Name, "
            sql = sql & " dbo.Department_tbl.Department_Name, dbo.work_day.year, dbo.work_day.month, dbo.Employee_Attendance.Days_Present"
            sql = sql & " FROM         dbo.Department_tbl INNER JOIN"
            sql = sql & "                     dbo.Designation_tbl ON dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id INNER JOIN"
            sql = sql & "                   dbo.employee_tbl ON dbo.Department_tbl.Department_Id = dbo.employee_tbl.Department_Id AND "
            sql = sql & "               dbo.Designation_tbl.Designation_Id = dbo.employee_tbl.Designation_Id INNER JOIN"
            sql = sql & "                  dbo.Employee_Attendance ON dbo.employee_tbl.Employee_Id = dbo.Employee_Attendance.Employee_Id CROSS JOIN"
            sql = sql & "            dbo.work_day"
            sql = sql & " WHERE     (dbo.Designation_tbl.Designation_Name like '" & txtSearchEmpInfo.Text & "%')"
            sql = sql & " ORDER BY dbo.work_day.year DESC"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim g = 0
            dgvattendanceList.Rows.Clear()
            While reader.Read = True
                dgvattendanceList.Rows.Add()
                dgvattendanceList.Item(0, g).Value = reader(0)
                dgvattendanceList.Item(1, g).Value = reader(1)
                dgvattendanceList.Item(2, g).Value = reader(2)
                dgvattendanceList.Item(3, g).Value = reader(3)
                dgvattendanceList.Item(4, g).Value = reader(4)
                dgvattendanceList.Item(5, g).Value = reader(5)
                dgvattendanceList.Item(6, g).Value = reader(6)

                g = g + 1
            End While
            connection_close()
        ElseIf cmbSearchEmp.Text = "Department" Then
            connection_open()
            sql = "  SELECT     TOP (100) PERCENT dbo.Employee_Attendance.Attendance_Id, dbo.employee_tbl.Name, dbo.Designation_tbl.Designation_Name, "
            sql = sql & " dbo.Department_tbl.Department_Name, dbo.work_day.year, dbo.work_day.month, dbo.Employee_Attendance.Days_Present"
            sql = sql & " FROM         dbo.Department_tbl INNER JOIN"
            sql = sql & "                     dbo.Designation_tbl ON dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id INNER JOIN"
            sql = sql & "                   dbo.employee_tbl ON dbo.Department_tbl.Department_Id = dbo.employee_tbl.Department_Id AND "
            sql = sql & "               dbo.Designation_tbl.Designation_Id = dbo.employee_tbl.Designation_Id INNER JOIN"
            sql = sql & "                  dbo.Employee_Attendance ON dbo.employee_tbl.Employee_Id = dbo.Employee_Attendance.Employee_Id CROSS JOIN"
            sql = sql & "            dbo.work_day"
            sql = sql & " WHERE     (dbo.Department_tbl.Department_Name like '" & txtSearchEmpInfo.Text & "%')"
            sql = sql & " ORDER BY dbo.work_day.year DESC"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim g = 0
            dgvattendanceList.Rows.Clear()
            While reader.Read = True
                dgvattendanceList.Rows.Add()
                dgvattendanceList.Item(0, g).Value = reader(0)
                dgvattendanceList.Item(1, g).Value = reader(1)
                dgvattendanceList.Item(2, g).Value = reader(2)
                dgvattendanceList.Item(3, g).Value = reader(3)
                dgvattendanceList.Item(4, g).Value = reader(4)
                dgvattendanceList.Item(5, g).Value = reader(5)
                dgvattendanceList.Item(6, g).Value = reader(6)

                g = g + 1
            End While
            connection_close()


        ElseIf cmbSearchEmp.Text = "Year" Then
            connection_open()
            sql = "  SELECT     TOP (100) PERCENT dbo.Employee_Attendance.Attendance_Id, dbo.employee_tbl.Name, dbo.Designation_tbl.Designation_Name, "
            sql = sql & " dbo.Department_tbl.Department_Name, dbo.work_day.year, dbo.work_day.month, dbo.Employee_Attendance.Days_Present"
            sql = sql & " FROM         dbo.Department_tbl INNER JOIN"
            sql = sql & "                     dbo.Designation_tbl ON dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id INNER JOIN"
            sql = sql & "                   dbo.employee_tbl ON dbo.Department_tbl.Department_Id = dbo.employee_tbl.Department_Id AND "
            sql = sql & "               dbo.Designation_tbl.Designation_Id = dbo.employee_tbl.Designation_Id INNER JOIN"
            sql = sql & "                  dbo.Employee_Attendance ON dbo.employee_tbl.Employee_Id = dbo.Employee_Attendance.Employee_Id CROSS JOIN"
            sql = sql & "            dbo.work_day"
            sql = sql & " WHERE     (dbo.work_day.year  like '" & txtSearchEmpInfo.Text & "%')"
            sql = sql & " ORDER BY dbo.work_day.year DESC"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim f = 0
            dgvattendanceList.Rows.Clear()
            While reader.Read = True
                dgvattendanceList.Rows.Add()
                dgvattendanceList.Item(0, f).Value = reader(0)
                dgvattendanceList.Item(1, f).Value = reader(1)
                dgvattendanceList.Item(2, f).Value = reader(2)
                dgvattendanceList.Item(3, f).Value = reader(3)
                dgvattendanceList.Item(4, f).Value = reader(4)
                dgvattendanceList.Item(5, f).Value = reader(5)
                dgvattendanceList.Item(6, f).Value = reader(6)

                f = f + 1
            End While
            connection_close()
        End If
    End Sub



    Private Sub cmbempname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempname.SelectedIndexChanged
        Try

      
            connection_open()

            sql = "select Employee_Id from Employee_Attendance where Year='" & txtyear.Text & "' and Month='" & cmbmonth.SelectedIndex & "' and Employee_Id='" & cmbempname.SelectedValue & "'  "
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                cmbmonth.SelectedIndex = 0
            End If
            connection_close()
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub tpempattend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpempattend.Click

    End Sub
End Class