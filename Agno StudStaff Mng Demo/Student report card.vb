Imports System.Data.SqlClient
Public Class Student_report_card
    Sub adload()
        connection_open()
        sql = "select Admission_Numb from student1_tbl "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        Dim i = 0
        While reader.Read = True
            cmbadmin.Items.Add(reader(0))
            i = i + 1
        End While
        cmbadmin.SelectedIndex = -1
        connection_close()
    End Sub

    Private Sub Student_report_card_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        adload()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

    End Sub

    Private Sub cmbadmin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbadmin.SelectedIndexChanged
        dgvstudrpt.Columns.Clear()
        dgvstudrpt.Columns.Add("sub_name", "Subjects")
        connection_open()
        sql = "SELECT     dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name"
        sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
        sql = sql & "           dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id INNER JOIN"
        sql = sql & "          dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id AND dbo.Section_tbl.Section_Id = dbo.Student1_tbl.Section_Id where Admission_Numb='" & cmbadmin.Text & "' "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            lbname.Text = reader(0)
            lbclass.Text = reader(1)
            lbsection.Text = reader(2)
        End If
        connection_close()
        connection_open()
        sql = "SELECT     dbo.Subject_tbl.Subject_Name, dbo.Class_tbl.Class_Name"
        sql = sql & " FROM         dbo.Subject_tbl INNER JOIN"
        sql = sql & "                      dbo.Class_tbl ON dbo.Subject_tbl.Class_Id = dbo.Class_tbl.Class_Id"
        sql = sql & " WHERE     (dbo.Class_tbl.Class_Name = '" & lbclass.Text & "')"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        Dim i = 0

        dgvstudrpt.Rows.Clear()
        While reader.Read = True
            dgvstudrpt.Rows.Add()
            dgvstudrpt.Item(0, i).Value = reader(0)
            i = i + 1
        End While
        connection_close()
        dgvstudrpt.Rows.Add()
        dgvstudrpt.Item(0, i).Value = "Total"
        dgvstudrpt.Rows.Add()
        dgvstudrpt.Item(0, i + 1).Value = "Average"
        dgvstudrpt.Rows.Add()
        dgvstudrpt.Item(0, i + 2).Value = "Grade Point"
        connection_open()
        sql = "Select * from Exam_tbl "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        While reader.Read = True
            dgvstudrpt.Columns.Add(reader(0), reader(1))
        End While
        connection_close()
        If MsgBoxResult.Yes = MsgBox("Do u want to view the Marks in Grade", MsgBoxStyle.YesNo) Then
            For j = 1 To dgvstudrpt.ColumnCount - 1
                Dim tot = 0
                Dim avg = 0
                For k = 0 To dgvstudrpt.RowCount - 1

                    connection_open()
                    sql = "    SELECT     dbo.Marks_tbl.Marks_Obtain, dbo.Subject_tbl.Subject_Name, dbo.Exam_tbl.Exam_Type, dbo.Student1_tbl.Admission_Numb"
                    sql = sql & " FROM         dbo.Exam_tbl INNER JOIN"
                    sql = sql & "      dbo.Marks_tbl ON dbo.Exam_tbl.Exam_Id = dbo.Marks_tbl.Exam_Id INNER JOIN"
                    sql = sql & "       dbo.Subject_tbl ON dbo.Marks_tbl.Subject_Id = dbo.Subject_tbl.Subject_Id INNER JOIN"
                    sql = sql & "        dbo.Student1_tbl ON dbo.Marks_tbl.Admission_Numb = dbo.Student1_tbl.Admission_Numb"
                    sql = sql & " WHERE     (dbo.Student1_tbl.Admission_Numb = '" & cmbadmin.Text & "') AND (dbo.Subject_tbl.Subject_Name = '" & dgvstudrpt.Item(0, k).Value & "' ) AND (dbo.Exam_tbl.Exam_Type = '" & dgvstudrpt.Columns(j).HeaderText & "')"
                    cmd = New SqlCommand(sql, cnn)
                    reader = cmd.ExecuteReader
                    If reader.Read = True Then
                        tot = tot + Val(reader(0))
                        If reader(0) >= 90 And reader(0) <= 100 Then
                            dgvstudrpt.Item(j, k).Value = "A+"
                        ElseIf reader(0) >= 70 And reader(0) <= 89 Then
                            dgvstudrpt.Item(j, k).Value = "A"
                        ElseIf reader(0) >= 50 And reader(0) <= 69 Then
                            dgvstudrpt.Item(j, k).Value = "B+"
                        ElseIf reader(0) >= 30 And reader(0) <= 49 Then
                            dgvstudrpt.Item(j, k).Value = "B"
                        ElseIf reader(0) = "" Then
                            dgvstudrpt.Item(j, k).Value = ""
                            dgvstudrpt.Item(j, k).Value = "C"
                        End If

                    End If
                Next
                dgvstudrpt.Item(j, i).Value = tot
                avg = tot / Val(i)
                If avg >= 90 And avg <= 100 Then
                    dgvstudrpt.Item(j, i + 2).Value = "ExcelLent"
                ElseIf avg >= 70 And avg <= 89 Then
                    dgvstudrpt.Item(j, i + 2).Value = "Very Good"
                ElseIf avg >= 50 And avg <= 69 Then
                    dgvstudrpt.Item(j, i + 2).Value = "Good"
                ElseIf avg >= 30 And avg <= 49 Then
                    dgvstudrpt.Item(j, i + 2).Value = "Satisfactory"
                ElseIf avg = 0 Then
                    dgvstudrpt.Item(j, i + 2).Value = ""
                Else
                    dgvstudrpt.Item(j, i + 2).Value = "Scope for improvement"
                End If
                dgvstudrpt.Item(j, i + 1).Value = avg
                tot = 0
                avg = 0
            Next
        Else
            Dim totl = 0
            Dim avgs = 0
            For j = 1 To dgvstudrpt.ColumnCount - 1
                For k = 0 To dgvstudrpt.RowCount - 1
                    connection_open()
                    sql = "    SELECT     dbo.Marks_tbl.Marks_Obtain, dbo.Subject_tbl.Subject_Name, dbo.Exam_tbl.Exam_Type, dbo.Student1_tbl.Admission_Numb"
                    sql = sql & " FROM         dbo.Exam_tbl INNER JOIN"
                    sql = sql & "      dbo.Marks_tbl ON dbo.Exam_tbl.Exam_Id = dbo.Marks_tbl.Exam_Id INNER JOIN"
                    sql = sql & "       dbo.Subject_tbl ON dbo.Marks_tbl.Subject_Id = dbo.Subject_tbl.Subject_Id INNER JOIN"
                    sql = sql & "        dbo.Student1_tbl ON dbo.Marks_tbl.Admission_Numb = dbo.Student1_tbl.Admission_Numb"
                    sql = sql & " WHERE     (dbo.Student1_tbl.Admission_Numb = '" & cmbadmin.Text & "') AND (dbo.Subject_tbl.Subject_Name = '" & dgvstudrpt.Item(0, k).Value & "' ) AND (dbo.Exam_tbl.Exam_Type = '" & dgvstudrpt.Columns(j).HeaderText & "')"
                    cmd = New SqlCommand(sql, cnn)
                    reader = cmd.ExecuteReader
                    If reader.Read = True Then
                        totl = totl + Val(reader(0))
                        dgvstudrpt.Item(j, k).Value = reader(0)

                    End If
                Next
                dgvstudrpt.Item(j, i).Value = totl
                avgs = totl / Val(i)
                dgvstudrpt.Item(j, i + 1).Value = avgs
                If avgs >= 90 And avgs <= 100 Then
                    dgvstudrpt.Item(j, i + 2).Value = "EXCELLENT"
                ElseIf avgs >= 70 And avgs <= 89 Then
                    dgvstudrpt.Item(j, i + 2).Value = "VERY GOOD"
                ElseIf avgs >= 50 And avgs <= 69 Then
                    dgvstudrpt.Item(j, i + 2).Value = "GOOD"
                ElseIf avgs >= 30 And avgs <= 49 Then
                    dgvstudrpt.Item(j, i + 2).Value = "SATISFACTORY"
                ElseIf avgs = 0 Then
                    dgvstudrpt.Item(j, i + 2).Value = ""
                Else
                    dgvstudrpt.Item(j, i + 2).Value = "SCOPE OF IMPROVEMENT"
                End If
                totl = 0
                avgs = 0
            Next
        End If
        connection_close()
          

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()
    End Sub
End Class