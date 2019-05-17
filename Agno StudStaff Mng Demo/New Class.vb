Imports System.Data.SqlClient
Public Class New_Standard
    Dim cid
  

    Sub classid()
        connection_open()
        sql = " select max(Class_Id)+1 from Class_tbl"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                cid = "1"
            Else
                cid = reader(0)
            End If
        End If
        connection_close()

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtstand.Text = "" Then
            MsgBox("Please Enter a New Class")
        Else
            connection_open()
            If btnsave.Text = "&Save" Then
                sql = "insert into Class_tbl values('" & Val(cid) & "','" & txtstand.Text & "')"
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                MsgBox(txtstand.Text & " Standard Has been Created")
                connection_close()
                Call classid()


            ElseIf btnsave.Text = "&Update" Then
                sql = "update  Class_tbl set Class_Name='" & txtstand.Text & "' where Class_Id='" & dgvclass.CurrentRow.Cells(0).Value & "' "
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                MsgBox(txtstand.Text & " Standard Has been Updated")
                connection_close()
            End If
        End If
        grid()

        clear()
    End Sub
    Sub grid()
        connection_open()
        sql = "select * from Class_tbl "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        dgvclass.Rows.Clear()
        Dim i = 0
        While reader.Read = True
            dgvclass.Rows.Add()
            dgvclass.Item(0, i).Value = reader(0)
            dgvclass.Item(1, i).Value = reader(1)
            i = i + 1
        End While
        connection_close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            If MsgBoxResult.No = MsgBox("Are You sure to delete items", MsgBoxStyle.YesNo) Then Exit Sub
            connection_open()
            sql = "delete from Class_tbl where Class_Id='" & dgvclass.CurrentRow.Cells(0).Value & "' "
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Deleted")
            connection_close()
            Call grid()
            Call clear()
            btnsave.Text = "&Update"
        Catch ex As Exception
            MsgBox("Please Delete all the records belonging to " & txtstand.Text & " Standard")

        End Try
    End Sub
    Sub clear()
        txtstand.Text = " "
    End Sub

    Private Sub New_Standard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        grid()
        Call classid()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
        btndelete.Enabled = False
        btnsave.Enabled = False
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True

        Me.Close()


    End Sub



    Private Sub txtnewstnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtnewstnd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub





    Private Sub dgvclass_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclass.CellDoubleClick
        connection_open()
        sql = "select Class_Name from Class_tbl where Class_Id='" & dgvclass.CurrentRow.Cells(0).Value & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            txtstand .Text = reader(0)
        End If
        btnsave.Text = "&Update"
        btndelete.Enabled = True
    End Sub

    Private Sub txtstand_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstand.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtstand_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstand.Leave
        connection_open()
        sql = " select Class_Name from Class_tbl where Class_Name='" & txtstand.Text & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            txtstand.Text = ""
        End If

        connection_close()

    End Sub

   
    Private Sub txtstand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstand.TextChanged
        If txtstand.Text = "" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
        Else
            btndelete.Enabled = True
            btnsave.Enabled = True
        End If
       
    End Sub
End Class