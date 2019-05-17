Imports System.Data.SqlClient

Public Class Classreport
    Public tb As TextBox
    Private WithEvents TextBox As New DataGridViewTextBoxEditingControl
    Dim col As Integer
    Dim tot As Double
    Dim pcount = 0
    Dim fcount = 0
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
    Sub exam()
        Try


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

   

    Private Sub Classreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        standrd()
        exam()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
        tot = 0
        lbfailed.Text = ""
        lbpass.Text = ""
        lbstrnght.Text = ""
    End Sub

    
    Private Sub cmbClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClass.SelectedIndexChanged
        dgvmarks.Rows.Clear()
        lbfailed.Text = ""
        lbpass.Text = ""
        lbstrnght.Text = ""

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
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

    End Sub

    Private Sub Btngo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btngo.Click
        If cmbClass.SelectedIndex = -1 Or cmbexamtype.SelectedIndex = -1 Or cmbSection.SelectedIndex = -1 Then
            MsgBox("Enter all the fields in order to proceed")
        Else
            dgvmarks.Rows.Clear()
            dgvmarks.Columns.Clear()
            dgvmarks.Columns.Add("Reg_no", "Admission No")
            dgvmarks.Columns.Add("Stud_name", "Student Name")
            connection_open()
            sql = "select Admission_Numb,Student_Name from Student1_tbl where Class_Id='" & cmbClass.SelectedValue & "' and Section_Id='" & cmbSection.SelectedValue & "' order by Student_Name"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim i = 0
            While reader.Read = True
                dgvmarks.Rows.Add()
                dgvmarks.Item(0, i).Value = reader(0)
                dgvmarks.Item(1, i).Value = reader(1)
                i = i + 1
            End While
            lbstrnght.Text = i
            connection_close()
            connection_open()
            sql = "Select * from Subject_tbl where Class_id='" & cmbClass.SelectedValue & "'"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            While reader.Read = True
                dgvmarks.Columns.Add(reader(0), reader(1))
            End While
            connection_close()
            For j = 0 To dgvmarks.RowCount - 1
                
                For k = 2 To dgvmarks.ColumnCount - 1
                    connection_open()
                    sql = "SELECT     dbo.Marks_tbl.Admission_Numb, dbo.Exam_tbl.Exam_Type, dbo.Marks_tbl.Subject_Id, dbo.Marks_tbl.Marks_Obtain"
                    sql = sql & " FROM         dbo.Section_tbl INNER JOIN"
                    sql = sql & "               dbo.Class_tbl ON dbo.Section_tbl.Class_Id = dbo.Class_tbl.Class_Id INNER JOIN"
                    sql = sql & "             dbo.Subject_tbl ON dbo.Class_tbl.Class_Id = dbo.Subject_tbl.Class_Id INNER JOIN"
                    sql = sql & "           dbo.Marks_tbl INNER JOIN"
                    sql = sql & "          dbo.Exam_tbl ON dbo.Marks_tbl.Exam_Id = dbo.Exam_tbl.Exam_Id ON dbo.Subject_tbl.Subject_Id = dbo.Marks_tbl.Subject_Id"
                    sql = sql & " WHERE     (dbo.Marks_tbl.Admission_Numb = '" & dgvmarks.Item(0, j).Value & "') AND (dbo.Exam_tbl.Exam_Type = '" & cmbexamtype.Text & "') AND (dbo.Marks_tbl.Subject_Id = '" & dgvmarks.Columns(k).Name & "')"
                    cmd = New SqlCommand(sql, cnn)
                    reader = cmd.ExecuteReader
                    If reader.Read = True Then
                        dgvmarks.Item(k, j).Value = reader(3)
                        Dim gk = dgvmarks.Item(k, j).Value
                        If reader(3) < 30 Or reader(3) = "Null" Then
                            fcount = 1
                        End If
                    End If
                    connection_close()
                Next
             
            Next
            If fcount = 1 Then
                fcount = fcount + 1
            Else
                pcount = pcount + 1
            End If
            lbfailed.Text = fcount
            lbpass.Text = pcount
            dgvmarks.Columns.Add("total", "Total")
            dgvmarks.Columns.Add("grade", "Grade")
            Dim h = 0
            For j = 0 To dgvmarks.RowCount - 1
                For h = 2 To dgvmarks.ColumnCount - 3
                    tot = tot + dgvmarks.Item(h, j).Value
                Next
                dgvmarks.Item(h, j).Value = tot
                Dim avg As Double
                avg = tot / (h - 2)
                If avg >= 90 And avg <= 100 Then
                    dgvmarks.Item(h + 1, j).Value = "A+"
                ElseIf avg >= 70 And avg <= 89 Then
                    dgvmarks.Item(h + 1, j).Value = "A"
                ElseIf avg >= 50 And avg <= 69 Then
                    dgvmarks.Item(h + 1, j).Value = "B+"
                ElseIf avg >= 30 And avg <= 49 Then
                    dgvmarks.Item(h + 1, j).Value = "B"
                Else
                    dgvmarks.Item(h + 1, j).Value = "C"
                End If


                tot = 0
            Next
        End If

    End Sub

    Private Sub cmbSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSection.SelectedIndexChanged
        dgvmarks.Rows.Clear()
        lbfailed.Text = ""
        lbpass.Text = ""
        lbstrnght.Text = ""
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

    End Sub

    Private Sub dgvmarks_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmarks.CellContentClick

    End Sub

    Private Sub cmbexamtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbexamtype.SelectedIndexChanged
        lbfailed.Text = ""
        lbpass.Text = ""
        lbstrnght.Text = ""
    End Sub
End Class