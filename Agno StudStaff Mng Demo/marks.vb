Imports System.Data.SqlClient
Imports System.String
Public Class marks
    Public tb As TextBox
    Private WithEvents TextBox As New DataGridViewTextBoxEditingControl
    Dim col As Integer
    Sub standrd()
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


        Try

       
            ds2.Clear()
            connection_open()
            sql = "select * from Section_tbl where Class_Id='" & cmbClass.SelectedValue & "'"
            cmd = New SqlCommand(sql, cnn)
            adapter.SelectCommand = cmd
            adapter.Fill(ds2)
            cmbSection.DataSource = ds2.Tables(0)
            cmbSection.ValueMember = "Section_Id"
            cmbSection.DisplayMember = "Section_Name"
            cmbSection.SelectedIndex = -1
            connection_close()
            exam()

        Catch ex As Exception

        End Try
    End Sub
    Sub exam()
        Try

            ds1.Clear()
            connection_open()
            sql = "select * from Exam_tbl "
            cmd = New SqlCommand(sql, cnn)
            adapter.SelectCommand = cmd
            adapter.Fill(ds1)
            cmbexamtype.DataSource = ds1.Tables(0)
            cmbexamtype.ValueMember = "Exam_Id"
            cmbexamtype.DisplayMember = "Exam_Type"
            cmbexamtype.SelectedIndex = -1
            connection_close()
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub marks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        standrd()
        exam()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
        btnsave.Enabled = False
    End Sub

    Private Sub btngo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo.Click
        If cmbClass.SelectedIndex = -1 Or cmbexamtype.SelectedIndex = -1 Or cmbSection.SelectedIndex = -1 Then
            MsgBox("Enter all the fields in order to proceed")
        Else
            dgvmarks.Rows.Clear()
            dgvmarks.Columns.Clear()
            dgvmarks.Columns.Add("Reg_no", "Register No")
            dgvmarks.Columns.Add("Stud_name", "Student Name")
            'connection_open()
            Dim i
            'For i = 0 To dgvmarks.Rows.Count - 1
            '    sql = "select Exam_Id from Marks_tbl where Admission_Numb= '" & dgvmarks.Item(0, i).Value & "' and Exam_Id='" & cmbexamtype.SelectedValue & "' "
            '    cmd = New SqlCommand(sql, cnn)
            '    reader = cmd.ExecuteReader
            '    If reader.Read = True Then
            '        cmbClass.SelectedIndex = -1
            '        cmbClass.SelectedIndex = -1
            '        cmbSection.SelectedIndex = -1
            '        dgvmarks.Rows.Clear()
            '        btnsave.Enabled = False
            '    Else
            '        dgvmarks.Enabled = True
            '        btnsave.Enabled = True
            '    End If

            '    connection_close()
            ' Next
            connection_open()
            sql = "select Admission_Numb,Student_Name from Student1_tbl where Class_Id='" & cmbClass.SelectedValue & "' and Section_Id='" & cmbSection.SelectedValue & "' order by Student_Name "
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            i = 0
            While reader.Read = True
                dgvmarks.Rows.Add()
                dgvmarks.Item(0, i).Value = reader(0)
                dgvmarks.Item(1, i).Value = reader(1)
                i = i + 1
            End While
            connection_close()
            connection_open()
            sql = "Select * from Subject_tbl where Class_id='" & cmbClass.SelectedValue & "'"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            While reader.Read = True
                dgvmarks.Columns.Add(reader(0), reader(1))
            End While
            connection_close()
        End If

    End Sub

    Private Sub dgvmarks_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvmarks.EditingControlShowing
        Try
            If Me.dgvmarks.CurrentCell.ColumnIndex = 2 Or Me.dgvmarks.CurrentCell.ColumnIndex = 3 Or Me.dgvmarks.CurrentCell.ColumnIndex = 4 Or Me.dgvmarks.CurrentCell.ColumnIndex = 5 Or Me.dgvmarks.CurrentCell.ColumnIndex = 6 And Not e.Control Is Nothing Then
                tb = (CType(e.Control, TextBox))
                col = Me.dgvmarks.CurrentCell.ColumnIndex
                AddHandler tb.KeyPress, AddressOf TextBox_keyPress
            Else
                RemoveHandler tb.KeyPress, AddressOf TextBox_keyPress
            End If
        Catch ex As Exception

        End Try
        btnsave.Enabled = True
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox.KeyPress
        
      
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
            


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim i = 0
        Dim j = 2
        For i = 0 To dgvmarks.Rows.Count - 1
            For j = 2 To dgvmarks.Columns.Count - 1
                connection_open()
                sql = "insert into Marks_tbl values('" & cmbexamtype.SelectedValue & "','" & dgvmarks.Item(0, i).Value & "','" & dgvmarks.Columns(j).Name & "','" & dgvmarks.Item(j, i).Value & "')"
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                connection_close()
            Next
        Next
        MsgBox("Submitted")
        dgvmarks.Rows.Clear()
        dgvmarks.Columns.Clear()
        clear()
        btnsave.Enabled = False
    End Sub

    Sub clear()
        cmbClass.SelectedIndex = -1
        cmbSection.SelectedIndex = -1
        cmbexamtype.SelectedIndex = -1
    End Sub

  
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

    End Sub

    Private Sub cmbexamtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbexamtype.SelectedIndexChanged
        
    End Sub

    Private Sub cmbSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSection.SelectedIndexChanged


    End Sub
End Class