Imports System.Data.SqlClient
Public Class Designation
    Dim dess
    Sub desload()
        connection_open()
        sql = "Select max(Designation_Id)+1 from Designation_tbl "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                dess = "1"
            Else
                dess = reader(0)
            End If
        End If
        connection_close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        desload()
        If btnsave.Text = "&Save" Then


            connection_open()
            sql = "Insert into Designation_tbl values('" & Val(dess) & "','" & txtdesignation.Text & "') "
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Designation has been Added")
            loadgrid()
        ElseIf btnsave.Text = "&Update" Then
            connection_open()
            sql = "Update Designation_tbl set Designation_Name='" & txtdesignation.Text & "' where designation_Id='" & dgvdesignation.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Designation has been Updated")
            btnsave.Text = "&Save"
            loadgrid()

        End If
        clear()
    End Sub
    Sub loadgrid()
        connection_open()
        sql = "select * from Designation_tbl "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        Dim i = 0
        dgvdesignation.Rows.Clear()
        While reader.Read = True
            dgvdesignation.Rows.Add()
            dgvdesignation.Item(0, i).Value = reader(0)
            dgvdesignation.Item(1, i).Value = reader(1)
            i = i + 1
        End While
        connection_close()
    End Sub

    Private Sub Designation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
        btnsave.Enabled = False
        btndelete.Enabled = False
        loadgrid()
    End Sub
    Private Sub dgvdesignation_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdesignation.CellDoubleClick
        txtdesignation.Text = dgvdesignation.CurrentRow.Cells(1).Value
        btnsave.Text = "&Update"
        btndelete.Enabled = True
        btnsave.Enabled = True

    End Sub
    Sub clear()
        txtdesignation.Text = ""
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try


            connection_open()
            sql = "Delete from Designation_tbl where Designation_Id='" & dgvdesignation.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Record is Deleted")

            btnsave.Text = "&Save"
        Catch ex As Exception
            MsgBox(txtdesignation.Text & " designation have departments and Employee Details under them please remove all the details belonging to this designation before proceding")

        End Try
        loadgrid()
        clear()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Agno_Student_And_Staff_Management_System.Show()

        Me.Close()

    End Sub

    Private Sub txtdesignation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesignation.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtdesignation_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdesignation.Leave
        If btnsave.Text = "&Save" Then
            connection_open()
            sql = "select Designation_Name from Designation_tbl where Designation_Name ='" & txtdesignation.Text & "'"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                txtdesignation.Text = ""
            End If
            If txtdesignation.Text = "" Then
                btnsave.Enabled = False
            Else
                btnsave.Enabled = True
            End If
        End If

    End Sub

    Private Sub txtdesignation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdesignation.TextChanged
        If txtdesignation.Text = "" Then
            btnsave.Enabled = False

        Else
            btnsave.Enabled = True
        End If

    End Sub
End Class
