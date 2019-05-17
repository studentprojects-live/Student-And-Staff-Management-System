Imports System.Data.SqlClient
Public Class Exam
    Dim seid
    Sub grid()
        connection_open()
        sql = "select * from Exam_tbl "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        dgvexam.Rows.Clear()
        Dim i = 0
        While reader.Read = True
            dgvexam.Rows.Add()
            dgvexam.Item(0, i).Value = reader(0)
            dgvexam.Item(1, i).Value = reader(1)
            i = i + 1
        End While
        connection_close()
    End Sub
    Sub clear()
        txtexam.Text = ""
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If btnsave.Text = "&ADD" Then
            connection_open()
            sql = "insert into Exam_tbl values('" & Val(seid) & "','" & txtexam.Text & "')"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox(txtexam.Text & " examination is added")
        ElseIf btnsave.Text = "&UPDATE" Then
            connection_open()
            sql = "update  Exam_tbl set Exam_type='" & txtexam.Text & "' where Exam_Id='" & dgvexam.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox(txtexam.Text & " examination has been updated ")
        End If
        Call grid()
        clear()
        eid()


    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            connection_open()
            If MsgBoxResult.No = MsgBox("Are u Sure u want to delete " & dgvexam.CurrentRow.Cells(1).Value & ".", MsgBoxStyle.YesNo) Then Exit Sub
            sql = "delete from Exam_tbl where Exam_Id='" & dgvexam.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox(txtexam.Text & " has been deleted")
            Call grid()
            clear()
            eid()
            btnsave.Text = "&UPDATE"
        Catch ex As Exception
            MsgBox("Please delete other records belonging to this Exam in order to proceed")

        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()


    End Sub
    Private Sub dgvexam_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvexam.DoubleClick
        btnsave.Text = "&UPDATE"
        txtexam.Text = dgvexam.CurrentRow.Cells(1).Value
        btndelete.Enabled = True

    End Sub

    Private Sub Exam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        Call grid()
        eid()
        btndelete.Enabled = False
        btnsave.Enabled = False
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

    End Sub
    Sub eid()
        connection_open()
        sql = " select max(Exam_Id)+1 from Exam_tbl"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                seid = "1"
            Else
                seid = reader(0)
            End If
        End If
        connection_close()

    End Sub

  

    Private Sub txtexam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtexam.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "32" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub
    Private Sub txtexam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtexam.TextChanged
        If btnsave.Text = "&ADD" Then
            connection_open()
            sql = "select Exam_Type from exam_tbl where Exam_Type='" & txtexam.Text & "'"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                txtexam.Text = ""
            End If
            connection_close()
        End If

        If txtexam.Text = "" Then
            btnsave.Enabled = False
        Else
            btnsave.Enabled = True
        End If

    End Sub

    
End Class