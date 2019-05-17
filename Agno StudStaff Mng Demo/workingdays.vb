Imports System.Data.SqlClient
Public Class workingdays
    Dim day As Integer
    Dim wkid
    Sub wrkid()
        connection_open()
        sql = " select max(work_Id)+1 from work_day"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                wkid = "1"
            Else
                wkid = reader(0)
            End If
        End If
        connection_close()

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cmbyear.SelectedIndex = -1 Or cmbmonth.SelectedIndex = -1 Or txtworkday.Text = "" Then
            MsgBox("Please Enter all the fileds")
        Else
            day = System.DateTime.DaysInMonth(cmbyear.Text, cmbmonth.SelectedIndex)
            If btnsave.Text = "Save" Then
                connection_open()
                sql = "select * from Work_day where Year='" & cmbyear.Text & "' And Month='" & cmbmonth.SelectedIndex & "'"
                cmd = New SqlCommand(sql, cnn)
                reader = cmd.ExecuteReader

                If reader.Read = True Then
                    MsgBox("Record already exist")
                    connection_close()
                Else
                    If txtworkday.Text < day Then
                        connection_open()
                        sql = " insert into work_day(work_Id,Year,Month,Working_days) values ('" & Val(wkid) & "','" & cmbyear.Text & "','" & cmbmonth.SelectedIndex & "','" & txtworkday.Text & "')"
                        cmd = New SqlCommand(sql, cnn)
                        cmd.ExecuteNonQuery()
                        connection_close()
                        MsgBox("Working days added")
                    Else
                        MsgBox("Invalid working days")
                    End If
                End If
            ElseIf btnsave.Text = "Update" Then
                connection_open()
                sql = " update Work_day set Year='" & cmbyear.Text & "',Month='" & cmbmonth.SelectedIndex & "',Working_days='" & txtworkday.Text & "' where work_Id='" & dgvworkday.CurrentRow.Cells(0).Value & "' "
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                connection_close()
                MsgBox("Record has been Updated")
            End If
            loadgrid()
            clear()
            wrkid()

        End If

    End Sub
    Sub loadgrid()
        connection_open()
        sql = "Select * from work_day"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        Dim i = 0
        dgvworkday.Rows.Clear()
        While reader.Read = True
            dgvworkday.Rows.Add()
            dgvworkday.Item(0, i).Value = reader(0)
            dgvworkday.Item(1, i).Value = reader(1)
            If reader(2) = "1" Then
                dgvworkday.Item(2, i).Value = "January"
            ElseIf reader(2) = "2" Then
                dgvworkday.Item(2, i).Value = "February"
            ElseIf reader(2) = "3" Then
                dgvworkday.Item(2, i).Value = "March"
            ElseIf reader(2) = "4" Then
                dgvworkday.Item(2, i).Value = "April"
            ElseIf reader(2) = "5" Then
                dgvworkday.Item(2, i).Value = "May"
            ElseIf reader(2) = "6" Then
                dgvworkday.Item(2, i).Value = "June"
            ElseIf reader(2) = "7" Then
                dgvworkday.Item(2, i).Value = "July"
            ElseIf reader(2) = "8" Then
                dgvworkday.Item(2, i).Value = "August"
            ElseIf reader(2) = "9" Then
                dgvworkday.Item(2, i).Value = "September"
            ElseIf reader(2) = "10" Then
                dgvworkday.Item(2, i).Value = "October"
            ElseIf reader(2) = "11" Then
                dgvworkday.Item(2, i).Value = "November"
            ElseIf reader(2) = "12" Then
                dgvworkday.Item(2, i).Value = "December"
            End If
            dgvworkday.Item(3, i).Value = reader(3)
            i = i + 1
        End While
    End Sub
    Sub clear()
        cmbyear.SelectedIndex = -1
        cmbmonth.SelectedIndex = -1
        txtworkday.Text = ""
    End Sub

    Private Sub workingdays_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        loadgrid()
        clear()
        wrkid()

        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
    End Sub
    Private Sub dgvworkday_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvworkday.CellDoubleClick
        cmbyear.Text = dgvworkday.CurrentRow.Cells(1).Value
        cmbmonth.Text = dgvworkday.CurrentRow.Cells(2).Value
        txtworkday.Text = dgvworkday.CurrentRow.Cells(3).Value
        btnsave.Text = "Update"
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        connection_open()
        sql = "delete from work_day where work_Id='" & dgvworkday.CurrentRow.Cells(0).Value & "'  "
        cmd = New SqlCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        connection_close()
        loadgrid()
        clear()
        MsgBox("Record has been Deleted")
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class