Imports System.Data.SqlClient
Public Class Department
    Dim deptid
    Sub loadgrid()
        connection_open()
        sql = "SELECT     dbo.Department_tbl.Department_Id, dbo.Designation_tbl.Designation_Name, dbo.Department_tbl.Department_Name"
        sql = sql & " FROM         dbo.Department_tbl INNER JOIN"
        sql = sql & "         dbo.Designation_tbl ON dbo.Department_tbl.Designation_Id = dbo.Designation_tbl.Designation_Id"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        Dim i = 0
        dgvdepartment.Rows.Clear()
        While reader.Read = True
            dgvdepartment.Rows.Add()
            dgvdepartment.Item(0, i).Value = reader(0)
            dgvdepartment.Item(1, i).Value = reader(1)
            dgvdepartment.Item(2, i).Value = reader(2)
            i = i + 1
        End While
        connection_close()
    End Sub
    Sub loaddesignation()
        connection_open()
        sql = "select * from Designation_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        cmbdesignation.DataSource = ds.Tables(0)
        cmbdesignation.ValueMember = "Designation_Id"
        cmbdesignation.DisplayMember = "Designation_Name"
        cmbdesignation.SelectedIndex = -1
        connection_close()
    End Sub

    Private Sub Department_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        loaddesignation()
        deptload()
        Txtdepartment.Enabled = False
        loadgrid()
        btnsave.Enabled = False
        btndelete.Enabled = False

        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If btnsave.Text = "&Save" Then
            connection_open()
            sql = "Insert into Department_tbl values('" & Val(deptid) & "','" & cmbdesignation.SelectedValue & "','" & Txtdepartment.Text & "' ) "
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Department has been Added")
            loadgrid()
        ElseIf btnsave.Text = "&Update" Then
            connection_open()
            sql = "Update Department_tbl set Department_Name='" & Txtdepartment.Text & "', Designation_Id='" & cmbdesignation.SelectedValue & "' where Department_Id='" & dgvdepartment.CurrentRow.Cells(0).Value & "'  "
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Department has been Updated")
            btnsave.Text = "&Save"
            loadgrid()
        End If
        deptload()
        clear()
        Txtdepartment.Enabled = False
    End Sub
    Sub deptload()
        connection_open()
        sql = "Select max(Department_Id)+1 from Department_tbl "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                deptid = "1"
            Else
                deptid = reader(0)
            End If
        End If
        connection_close()
    End Sub
    Sub clear()
        cmbdesignation.SelectedIndex = -1
        Txtdepartment.Text = ""
    End Sub
    Private Sub dgvdepartment_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdepartment.CellDoubleClick
        cmbdesignation.Text = dgvdepartment.CurrentRow.Cells(1).Value
        Txtdepartment.Text = dgvdepartment.CurrentRow.Cells(2).Value
        btnsave.Text = "&Update"
        btndelete.Enabled = True
        btnsave.Enabled = True

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        try
        connection_open()
        sql = "delete  from Department_tbl where Department_Id='" & dgvdepartment.CurrentRow.Cells(0).Value & "' "
        cmd = New SqlCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        connection_close()
        MsgBox("Record has been deleted")
        clear()
        loadgrid()
            connection_close()
        Catch ex As Exception
            MsgBox("Please delete other records belonging to this Department in order to proceed")

        End Try
    End Sub



    Private Sub cmbdesignation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesignation.SelectedIndexChanged
        Txtdepartment.Enabled = True

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True

        Me.Close()

    End Sub

    Private Sub Txtdepartment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtdepartment.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txtdepartment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtdepartment.TextChanged
        Try


            If btnsave.Text = "&Save" Then


                connection_open()
                sql = "select Department_Name from Department_tbl where Department_Name ='" & Txtdepartment.Text & "' and Designation_Id='" & cmbdesignation.SelectedValue & "'"
                cmd = New SqlCommand(sql, cnn)
                reader = cmd.ExecuteReader
                If reader.Read = True Then
                    Txtdepartment.Text = ""
                End If
                If Txtdepartment.Text = "" Then
                    btnsave.Enabled = False
                Else
                    btnsave.Enabled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class