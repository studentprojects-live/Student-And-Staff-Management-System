Imports System.Data.SqlClient
Public Class reciept
    Sub load_grid()
        connection_open()
        sql = " SELECT     dbo.Fee_tbl.Receipt_No, dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name, "
        sql = sql & " dbo.Fee_tbl.bal_amt, dbo.Fee_tbl.amount_paid"
        sql = sql & " FROM         dbo.Fee_tbl INNER JOIN"
        sql = sql & "                     dbo.Student1_tbl ON dbo.Fee_tbl.Admission_Numb = dbo.Student1_tbl.Admission_Numb INNER JOIN"
        sql = sql & "                   dbo.Section_tbl ON dbo.Student1_tbl.Section_Id = dbo.Section_tbl.Section_Id INNER JOIN"
        sql = sql & "                  dbo.Class_tbl ON dbo.Student1_tbl.Class_Id = dbo.Class_tbl.Class_Id AND dbo.Section_tbl.Class_Id = dbo.Class_tbl.Class_Id"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        Dim i = 0
        dgvrecieptList.Rows.Clear()
        While reader.Read = True
            dgvrecieptList.Rows.Add()
            dgvrecieptList.Item(0, i).Value = reader(0)
            dgvrecieptList.Item(1, i).Value = reader(1)
            dgvrecieptList.Item(2, i).Value = reader(2)
            dgvrecieptList.Item(3, i).Value = reader(3)
            dgvrecieptList.Item(4, i).Value = reader(4)
            dgvrecieptList.Item(5, i).Value = reader(5)
            dgvrecieptList.Item(6, i).Value = reader(6)

            i = i + 1
        End While
        connection_close()

    End Sub

    Private Sub reciept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        load_grid()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
    End Sub

    Private Sub txtSearchrecieptInfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchrecieptInfo.KeyPress
        If cmbSearchreciept.SelectedIndex = 0 Then
            If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf cmbSearchreciept.SelectedIndex = 2 Then
            If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf cmbSearchreciept.SelectedIndex = 3 Then
            If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSearchrecieptInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchrecieptInfo.TextChanged
        If cmbSearchreciept.Text = "Student Name" Then
            connection_open()
            sql = " SELECT     dbo.Fee_tbl.Receipt_No, dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name, "
            sql = sql & " dbo.Fee_tbl.bal_amt, dbo.Fee_tbl.amount_paid"
            sql = sql & " FROM         dbo.Fee_tbl INNER JOIN"
            sql = sql & "                     dbo.Student1_tbl ON dbo.Fee_tbl.Admission_Numb = dbo.Student1_tbl.Admission_Numb INNER JOIN"
            sql = sql & "                   dbo.Section_tbl ON dbo.Student1_tbl.Section_Id = dbo.Section_tbl.Section_Id INNER JOIN"
            sql = sql & "                  dbo.Class_tbl ON dbo.Student1_tbl.Class_Id = dbo.Class_tbl.Class_Id AND dbo.Section_tbl.Class_Id = dbo.Class_tbl.Class_Id"
            sql = sql & " WHERE     (dbo.Student1_tbl.Student_Name like '" & txtSearchrecieptInfo.Text & "%')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim i = 0
            dgvrecieptList.Rows.Clear()
            While reader.Read = True
                dgvrecieptList.Rows.Add()
                dgvrecieptList.Item(0, i).Value = reader(0)
                dgvrecieptList.Item(1, i).Value = reader(1)
                dgvrecieptList.Item(2, i).Value = reader(2)
                dgvrecieptList.Item(3, i).Value = reader(3)
                dgvrecieptList.Item(4, i).Value = reader(4)
                dgvrecieptList.Item(5, i).Value = reader(5)
                dgvrecieptList.Item(6, i).Value = reader(6)

                i = i + 1
            End While
            connection_close()

        ElseIf cmbSearchreciept.Text = "Present Class" Then
            connection_open()
            sql = " SELECT     dbo.Fee_tbl.Receipt_No, dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name, "
            sql = sql & " dbo.Fee_tbl.bal_amt, dbo.Fee_tbl.amount_paid"
            sql = sql & " FROM         dbo.Fee_tbl INNER JOIN"
            sql = sql & "                     dbo.Student1_tbl ON dbo.Fee_tbl.Admission_Numb = dbo.Student1_tbl.Admission_Numb INNER JOIN"
            sql = sql & "                   dbo.Section_tbl ON dbo.Student1_tbl.Section_Id = dbo.Section_tbl.Section_Id INNER JOIN"
            sql = sql & "                  dbo.Class_tbl ON dbo.Student1_tbl.Class_Id = dbo.Class_tbl.Class_Id AND dbo.Section_tbl.Class_Id = dbo.Class_tbl.Class_Id"
            sql = sql & " WHERE     (dbo.Class_tbl.Class_Name like '" & txtSearchrecieptInfo.Text & "')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim i = 0
            dgvrecieptList.Rows.Clear()
            While reader.Read = True
                dgvrecieptList.Rows.Add()
                dgvrecieptList.Item(0, i).Value = reader(0)
                dgvrecieptList.Item(1, i).Value = reader(1)
                dgvrecieptList.Item(2, i).Value = reader(2)
                dgvrecieptList.Item(3, i).Value = reader(3)
                dgvrecieptList.Item(4, i).Value = reader(4)
                dgvrecieptList.Item(5, i).Value = reader(5)
                dgvrecieptList.Item(6, i).Value = reader(6)
                i = i + 1
            End While
            connection_close()

        ElseIf cmbSearchreciept.Text = "Year" Then
            connection_open()
            sql = " SELECT     dbo.Fee_tbl.Receipt_No, dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name, "
            sql = sql & " dbo.Fee_tbl.bal_amt, dbo.Fee_tbl.amount_paid"
            sql = sql & " FROM         dbo.Fee_tbl INNER JOIN"
            sql = sql & "                     dbo.Student1_tbl ON dbo.Fee_tbl.Admission_Numb = dbo.Student1_tbl.Admission_Numb INNER JOIN"
            sql = sql & "                   dbo.Section_tbl ON dbo.Student1_tbl.Section_Id = dbo.Section_tbl.Section_Id INNER JOIN"
            sql = sql & "                  dbo.Class_tbl ON dbo.Student1_tbl.Class_Id = dbo.Class_tbl.Class_Id AND dbo.Section_tbl.Class_Id = dbo.Class_tbl.Class_Id"
            sql = sql & " WHERE     (year(dbo.Fee_tbl.Date) like '" & txtSearchrecieptInfo.Text & "%')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim i = 0
            dgvrecieptList.Rows.Clear()
            While reader.Read = True
                dgvrecieptList.Rows.Add()
                dgvrecieptList.Item(0, i).Value = reader(0)
                dgvrecieptList.Item(1, i).Value = reader(1)
                dgvrecieptList.Item(2, i).Value = reader(2)
                dgvrecieptList.Item(3, i).Value = reader(3)
                dgvrecieptList.Item(4, i).Value = reader(4)
                dgvrecieptList.Item(5, i).Value = reader(5)
                dgvrecieptList.Item(6, i).Value = reader(6)
                i = i + 1
            End While
            connection_close()
        End If
        If txtSearchrecieptInfo.Text = "" Then

            load_grid()

        End If

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

    End Sub
End Class