Imports System.Data.SqlClient
Public Class Student_AttendanceFrm
    Dim Class_Id As Integer
    Dim ai
    Sub aidd()
        connection_open()
        sql = "Select max(Attendance_Id)+1 from Student_Attendance "
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
    Private Sub Student_AttendanceFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        standard()

        If Today.Month = "1" Then
            txtyear.Text = Val((Today.Year) - 1)



        Else
            txtyear.Text = (Today.Year)


        End If
        cmbSection.Enabled = False
        cmbMonth.Enabled = False
        txtNo_of_Clases.Enabled = False
        dgvStudentAttendance.Enabled = False
        btnsave.Enabled = False

        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
    End Sub
    Sub standard()
        connection_open()
        sql = "select * from Class_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        cmbClass.DataSource = ds.Tables(0)
        cmbClass.ValueMember = "Class_Id"
        cmbClass.DisplayMember = "Class_Name"
        cmbClass.SelectedIndex = -1
        connection_close()

    End Sub

    Private Sub cmbClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClass.SelectedIndexChanged
        cmbSection.Enabled = True
        Try
            connection_open()
            sql = "select * from Section_tbl where Class_Id='" & cmbClass.SelectedValue & "'"
            cmd = New SqlCommand(sql, cnn)
            adapter.SelectCommand = cmd
            ds1.Clear()
            adapter.Fill(ds1)
            cmbSection.DataSource = ds1.Tables(0)
            cmbSection.ValueMember = "Section_Id"
            cmbSection.DisplayMember = "Section_Name"
            cmbSection.SelectedIndex = -1
            connection_close()
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub cmbSection_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSection.Leave
        
    End Sub

  


    Private Sub dgvStudentAttendance_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudentAttendance.CellEndEdit
        If e.ColumnIndex = 2 Then
            If Val(dgvStudentAttendance.Item(2, e.RowIndex).Value) > Val(txtNo_of_Clases.Text) Then
                dgvStudentAttendance.Item(2, e.RowIndex).Value = ""
                btnsave.Enabled = False
            Else
                dgvStudentAttendance.Item(3, e.RowIndex).Value = (100 * dgvStudentAttendance.Item(2, e.RowIndex).Value) / Val(txtNo_of_Clases.Text)
                btnsave.Enabled = True
            End If
        End If

    End Sub

    'Private Sub dgvStudentAttendance_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudentAttendance.CellValueChanged
    '    If e.ColumnIndex = 2 Then
    '        If dgvStudentAttendance.Item(2, e.RowIndex).Value > Val(txtNo_of_Clases.Text) Then
    '            dgvStudentAttendance.Item(2, e.RowIndex).ReadOnly = True
    '        End If
    '    End If
    'End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim j = 0
        For j = 0 To dgvStudentAttendance.Rows.Count - 1
            aidd()
            connection_open()
            sql = "insert into Student_Attendance values ('" & Val(ai) & "','" & dgvStudentAttendance.Item(0, j).Value & "','" & cmbClass.SelectedValue & "','" & cmbSection.Text & "','" & txtyear.Text & "','" & cmbMonth.Text & "','" & txtNo_of_Clases.Text & "','" & dgvStudentAttendance.Item(2, j).Value & "','" & dgvStudentAttendance.Item(3, j).Value & "')"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
        Next
        MsgBox("Record has been stored")
        clear()

    End Sub

    Private Sub cmbSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSection.SelectedIndexChanged
        cmbMonth.Enabled = True
        Try


            connection_open()
            sql = " SELECT     dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, MONTH(dbo.Student1_tbl.Admission_date) AS Month, dbo.Class_tbl.Class_Name, "
            sql = sql & " dbo.Section_tbl.Section_Name()"
            sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
            sql = sql & "                      dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id INNER JOIN"
            sql = sql & "                      dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id AND dbo.Section_tbl.Section_Id = dbo.Student1_tbl.Section_Id"
            sql = sql & " WHERE     (dbo.Class_tbl.Class_Name = '" & cmbClass.SelectedText & "') AND (dbo.Section_tbl.Section_Name = '" & cmbSection.SelectedText & "') AND (MONTH(dbo.Student1_tbl.Admission_date) = '" & cmbMonth.SelectedIndex & "'))"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim i = 0
            dgvStudentAttendance.Rows.Clear()
            While reader.Read = False
                dgvStudentAttendance.Rows.Add()
                dgvStudentAttendance.Item(0, i).Value = reader(0)
                dgvStudentAttendance.Item(1, i).Value = reader(1)
                i = i + 1
            End While
            connection_close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True


        Me.Close()

    End Sub

    Private Sub txtNo_of_Clases_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNo_of_Clases.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtNo_of_Clases_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNo_of_Clases.TextChanged
        Try
            Dim Day
            If Today.Month = 1 Then
                Day = System.DateTime.DaysInMonth(Today.Year - 1, cmbMonth.SelectedIndex)
                dgvStudentAttendance.Enabled = True

            Else
                Day = System.DateTime.DaysInMonth(Today.Year, cmbMonth.SelectedIndex)
                dgvStudentAttendance.Enabled = True

            End If
           
            If txtNo_of_Clases.Text > Day Then
                txtNo_of_Clases.Text = ""

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        Try

       
            connection_open()
            sql = "select month from Student_Attendance where Class_Id='" & cmbClass.SelectedValue & "' and year='" & txtyear.Text & "' and month='" & cmbMonth.SelectedItem & "' "
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                cmbMonth.SelectedIndex = 0
                cmbClass.SelectedIndex = -1
                cmbSection.SelectedIndex = -1
                dgvStudentAttendance.Rows.Clear()
            Else
                txtNo_of_Clases.Enabled = True
            End If
            connection_close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub dgvStudentAttendance_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudentAttendance.CellEnter

    End Sub

    

    Private Sub txtyear_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtyear.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Sub clear()
        cmbMonth.SelectedIndex = 0
        cmbClass.SelectedIndex = -1
        cmbSection.SelectedIndex = -1
        dgvStudentAttendance.Rows.Clear()
    End Sub
End Class