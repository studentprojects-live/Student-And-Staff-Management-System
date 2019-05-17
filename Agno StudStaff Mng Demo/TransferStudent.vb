Imports System.Data.SqlClient

Public Class TransferStudent
    Sub clear()
        cmbFromClass.SelectedIndex = -1
        cmbnewclass.SelectedIndex = -1
        cmbFromSection.SelectedIndex = -1
        cmbToNewSection.SelectedIndex = -1
        dgvfromclass.Rows.Clear()
        dgvStudentGotUpgraded.Rows.Clear()

    End Sub


    Sub standard()
        connection_open()
        sql = "select * from Class_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        cmbFromClass.DataSource = ds.Tables(0)
        cmbFromClass.ValueMember = "Class_Id"
        cmbFromClass.DisplayMember = "Class_Name"
        cmbFromClass.SelectedIndex = -1
        connection_close()
    End Sub
    Sub standard1()
        connection_open()
        sql = "select * from Class_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds1)
        cmbnewclass.DataSource = ds1.Tables(0)
        cmbnewclass.ValueMember = "Class_Id"
        cmbnewclass.DisplayMember = "Class_Name"
        cmbnewclass.SelectedIndex = -1
        connection_close()
    End Sub


    Private Sub TransferStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)

        standard()
        standard1()
        btnSave.Enabled = False
        cmbFromSection.SelectedIndex = -1
        cmbToNewSection.SelectedIndex = -1
        cmbFromSection.Enabled = False
        cmbnewclass.Enabled = False
        cmbToNewSection.Enabled = False


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()


    End Sub


    Private Sub cmbFromClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFromClass.SelectedIndexChanged
        cmbFromSection.Enabled = True

        dgvfromclass.Rows.Clear()

        Try
            If (cmbFromClass.SelectedIndex = cmbnewclass.SelectedIndex) = False Then

                connection_open()
                sql = "select * from Section_tbl where Class_Id='" & cmbFromClass.SelectedValue & "'"
                cmd = New SqlCommand(sql, cnn)
                adapter.SelectCommand = cmd
                ds2.Clear()
                adapter.Fill(ds2)
                cmbFromSection.DataSource = ds2.Tables(0)
                cmbFromSection.ValueMember = "Section_Id"
                cmbFromSection.DisplayMember = "Section_Name"
                cmbFromSection.SelectedIndex = -1
                connection_close()
                cmbnewclass.Enabled = True
            Else
                cmbFromClass.SelectedIndex = -1
                clear()
            End If
        Catch ex As Exception

        End Try
        cmbnewclass.Enabled = False
    End Sub

    Private Sub cmbToNewClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub cmbFromSection_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFromSection.Leave
        Try
            connection_open()
            sql = "  SELECT     TOP (100) PERCENT dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name"
            sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
            sql = sql & "         dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id INNER JOIN"
            sql = sql & "         dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id AND dbo.Section_tbl.Section_Id = dbo.Student1_tbl.Section_Id"
            sql = sql & " WHERE     (dbo.Class_tbl.Class_Name = 'III') AND (dbo.Section_tbl.Section_Name = 'A')"
            sql = sql & " ORDER BY dbo.Student1_tbl.Student_Name"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim i = 0
            dgvfromclass.Rows.Clear()
            While reader.Read = True
                dgvfromclass.Rows.Add()
                dgvfromclass.Item(0, i).Value = reader(0)
                dgvfromclass.Item(1, i).Value = reader(1)
                i = i + 1
            End While
            connection_close()

        Catch ex As Exception

        End Try
    End Sub




    Private Sub cmbFromSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFromSection.SelectedIndexChanged
        cmbnewclass.Enabled = True
       
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
       
        dgvStudentGotUpgraded.Rows.Clear()
        Dim k = 0
        For i = 0 To dgvfromclass.RowCount - 1

            If dgvfromclass.Item(2, i).Value = True Then

                dgvStudentGotUpgraded.Rows.Add()
                dgvStudentGotUpgraded.Item(0, k).Value = dgvfromclass.Item(0, i).Value
                dgvStudentGotUpgraded.Item(1, k).Value = dgvfromclass.Item(1, i).Value

                k = k + 1

            End If

        Next
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        For k = 0 To dgvStudentGotUpgraded.RowCount - 1
            connection_open()
            sql = "insert into transfer_tbl values('" & Today.Year & "','" & cmbnewclass.SelectedValue & "','" & cmbToNewSection.SelectedValue & "', '" & dgvStudentGotUpgraded.Item(0, k).Value & "')"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            connection_open()
            sql = "update Student1_tbl set Class_Id='" & cmbnewclass.SelectedValue & "', Section_Id='" & cmbToNewSection.SelectedValue & "'  where Admission_Numb='" & dgvStudentGotUpgraded.Item(0, k).Value & "' "
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
        Next
        MsgBox("Student Has been Transfered to " & cmbnewclass.Text & " Standard  and Section " & cmbToNewSection.Text)
        clear()
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.Checked = True Then
            For j = 0 To dgvfromclass.RowCount - 1
                dgvfromclass.Item(2, j).Value = True
            Next
        Else
            For j = 0 To dgvfromclass.RowCount - 1
                dgvfromclass.Item(2, j).Value = False
            Next
        End If
    End Sub

    Private Sub dgvfromclass_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvfromclass.CellValueChanged
        'Dim f = 0
        'For j = 0 To dgvfromclass.RowCount - 1
        '    If dgvfromclass.Item(2, j).Value = False Then
        '        f = 1
        '    End If
        '    If f = 0 Then
        '        chkSelectAll.Checked = True
        '    Else
        '        chkSelectAll.Checked = False
        '    End If
        'Next
    End Sub

    Private Sub cmbnewclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnewclass.SelectedIndexChanged
        cmbToNewSection.Enabled = True
        Try
            If (cmbFromClass.SelectedIndex = cmbnewclass.SelectedIndex) = False Then

                connection_open()
                sql = "select * from Section_tbl where Class_Id='" & cmbnewclass.SelectedValue & "'"
                cmd = New SqlCommand(sql, cnn)
                adapter.SelectCommand = cmd
                ds2.Clear()
                adapter.Fill(ds2)
                cmbToNewSection.DataSource = ds2.Tables(0)
                cmbToNewSection.ValueMember = "Section_Id"
                cmbToNewSection.DisplayMember = "Section_Name"
                cmbToNewSection.SelectedIndex = -1
                connection_close()
            Else
                cmbnewclass.SelectedIndex = -1
                clear()
            End If
            connection_close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbToNewSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbToNewSection.SelectedIndexChanged
        dgvfromclass.Enabled = True
    End Sub

    Private Sub dgvfromclass_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvfromclass.CellContentClick

    End Sub
End Class