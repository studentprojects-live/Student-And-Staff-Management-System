Imports System.Data.SqlClient
Public Class Subject
    Dim seid
    Sub standrd()
        connection_open()
        sql = "select * from Class_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        cmbclass.DataSource = ds.Tables(0)
        cmbclass.ValueMember = "Class_Id"
        cmbclass.DisplayMember = "Class_Name"
        cmbclass.SelectedIndex = -1
        connection_close()
    End Sub
    Sub subject_id()
        connection_open()
        sql = " select max(Subject_Id)+1 from Subject_tbl"
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
    Sub loadgrid()
        connection_open()
        sql = " SELECT     dbo.Subject_tbl.Subject_Id, dbo.Subject_tbl.Subject_Name, dbo.Class_tbl.Class_Name, "
        sql = sql & " dbo.Subject_tbl.MinMarks, dbo.Subject_tbl.MaxMarks"
        sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
        sql = sql & "       dbo.Subject_tbl ON dbo.Class_tbl.Class_Id = dbo.Subject_tbl.Class_Id"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        dgvsubject.Rows.Clear()
        Dim i = 0
        While reader.Read = True
            dgvsubject.Rows.Add()
            dgvsubject.Item(0, i).Value = reader(0)
            dgvsubject.Item(1, i).Value = reader(2)
            dgvsubject.Item(2, i).Value = reader(1)
            dgvsubject.Item(3, i).Value = reader(3)
            dgvsubject.Item(4, i).Value = reader(4)


            i = i + 1
        End While
        connection_close()
    End Sub
    Private Sub Subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        standrd()
        loadgrid()
        subject_id()
        txtsubject.Enabled = False
        txtmin.Enabled = False
        txtmax.Enabled = False
        btnsave.Enabled = False
        btndelete.Enabled = False
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

    End Sub


    Sub clear()
        cmbclass.SelectedIndex = -1
        txtsubject.Text = ""
        txtmax.Text = ""
        txtmin.Text = ""

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cmbclass.SelectedIndex = -1 Or txtmax.Text = "" Or txtmin.Text = "" Or txtsubject.Text = "" Then
            MsgBox("enter all the fields")
        Else
            If btnsave.Text = "&ADD" Then

                connection_open()
                sql = "Insert into subject_tbl values('" & Val(seid) & "','" & txtsubject.Text & "','" & cmbclass.SelectedValue & "','" & txtmin.Text & "','" & txtmax.Text & "')"
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                connection_close()
                MsgBox(txtsubject.Text & " Subject has been added")

            ElseIf btnsave.Text = "&UPDATE" Then
                connection_open()
                sql = "update subject_tbl set Subject_Name='" & txtsubject.Text & "',MinMarks='" & txtmin.Text & "',MaxMarks='" & txtmax.Text & "' where Subject_Id='" & dgvsubject.CurrentRow.Cells(0).Value & "' "
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                connection_close()
                MsgBox(txtsubject.Text & " Subject details  has been Updated ")
                btnsave.Text = "&ADD"
            End If
        End If
        clear()
        loadgrid()
        subject_id()

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try

        
            connection_open()
            If MsgBoxResult.No = MsgBox("Are u Sure u want to delete  " & dgvsubject.CurrentRow.Cells(2).Value & "  Subject from" & dgvsubject.CurrentRow.Cells(1).Value & " Stanadrd.", MsgBoxStyle.YesNo) Then Exit Sub
            sql = "delete from Subject_tbl where Subject_Id='" & dgvsubject.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox(txtsubject.Text & " Subject  has been deleted from" & cmbclass.Text & " Standard")
            Call clear()
            loadgrid()
            subject_id()
            btnsave.Text = "&ADD"
            connection_close()

        Catch ex As Exception
            MsgBox("Please delete other records belonging to this Subject in order to proceed")


        End Try


    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True

        Me.Close()

    End Sub

    Private Sub dgvsubject_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsubject.CellDoubleClick
        connection_open()
        sql = " SELECT     dbo.Subject_tbl.Subject_Id, dbo.Class_tbl.Class_Name, dbo.Subject_tbl.Subject_Name, dbo.Subject_tbl.MinMarks, "
        sql = sql & " dbo.Subject_tbl.MaxMarks "
        sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
        sql = sql & "             dbo.Subject_tbl ON dbo.Class_tbl.Class_Id = dbo.Subject_tbl.Class_Id"
        sql = sql & " WHERE (dbo.Subject_tbl.Subject_Id =  '" & dgvsubject.CurrentRow.Cells(0).Value & "')"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            cmbclass.Text = reader(1)
            txtsubject.Text = reader(2)
            txtmin.Text = reader(3)
            txtmax.Text = reader(4)
        End If
        connection_close()
        btnsave.Text = "&UPDATE"
        btndelete.Enabled = True

    End Sub

    Private Sub txtsubject_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsubject.Enter
       
    End Sub

    Private Sub txtsubject_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsubject.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtmin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmin.Click
        connection_open()
        sql = "select Subject_Name from Subject_tbl where Class_Id = '" & cmbclass.SelectedValue & "' and Subject_Name='" & txtsubject.Text & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            txtsubject.Text = ""
            cmbclass.SelectedIndex = -1

        End If
        connection_close()
    End Sub

    Private Sub txtmin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmin.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtmax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmax.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtsubject_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsubject.Leave
       

    End Sub

  

  
    Private Sub txtsubject_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubject.TextChanged
        If txtsubject.Text = "" Then

            btnsave.Enabled = False
        Else
            btnsave.Enabled = True

        End If

    End Sub

    Private Sub cmbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclass.SelectedIndexChanged
        If cmbclass.Text = "" Then
            txtsubject.Enabled = False
            txtmin.Enabled = False
            txtmax.Enabled = False
        Else
            txtmin.Enabled = True
            txtsubject.Enabled = True
            txtmax.Enabled = True
        End If
    End Sub

    Private Sub txtmin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmin.TextChanged
        If txtmin.Text = "" Then
            btnsave.Enabled = False
        Else
            btnsave.Enabled = True

        End If

    End Sub

    Private Sub txtmax_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmax.Leave
        If Val(txtmax.Text) < Val(txtmin.Text) Then
            txtmax.Text = ""
        End If
       

    End Sub

    Private Sub txtmax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmax.TextChanged
        If txtmax.Text = "" Then
            btnsave.Enabled = False
        Else
            btnsave.Enabled = True
        End If
      
    End Sub
End Class