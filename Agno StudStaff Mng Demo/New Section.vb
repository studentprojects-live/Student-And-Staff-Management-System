Imports System.Data.SqlClient
Public Class New_Section
    Dim seid
    Sub secid()
        connection_open()
        sql = " select max(Section_Id)+1 from Section_tbl"
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
    Private Sub New_Section_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        standrd()
        secid()
        grid()
        ScnDelete.Enabled = False
        ScnSave.Enabled = False
        ScnUpdate.Enabled = False

        txtsecn.Enabled = False
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

    End Sub
    Sub standrd()
        connection_open()
        sql = "select * from Class_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        cmbstandrd.DataSource = ds.Tables(0)
        cmbstandrd.ValueMember = "Class_Id"
        cmbstandrd.DisplayMember = "Class_Name"
        cmbstandrd.SelectedIndex = -1
        connection_close()

    End Sub
    Private Sub ScnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScnSave.Click
        connection_open()
        sql = "insert into Section_tbl values('" & Val(seid) & "','" & cmbstandrd.SelectedValue & "','" & txtsecn.Text & "')"
        cmd = New SqlCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        MsgBox("Section has been Added")
        grid()
        connection_close()
        clear()
        secid()


    End Sub
    Sub grid()
        connection_open()
        sql = "SELECT     dbo.Section_tbl.Section_Id, dbo.Section_tbl.Class_Id, dbo.Section_tbl.Section_Name, dbo.Class_tbl.Class_Name"
        sql = sql & " FROM           dbo.Class_tbl INNER JOIN"
        sql = sql & "           dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id  ORDER BY dbo.Class_tbl.Class_Name "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        Dim i = 0
        dgvsecn.Rows.Clear()
        While reader.Read = True
            dgvsecn.Rows.Add()
            dgvsecn.Item(0, i).Value = reader(0)
            dgvsecn.Item(1, i).Value = reader(3)
            dgvsecn.Item(2, i).Value = reader(2)
            i = i + 1
        End While
        connection_close()
    End Sub
    Sub clear()
        cmbstandrd.SelectedIndex = -1
        txtsecn.Text = ""
        txtsecn.Enabled = True

    End Sub

    Private Sub ScnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScnDelete.Click
        Try
            If MsgBoxResult.No = MsgBox("Are You sure to delete items", MsgBoxStyle.YesNo) Then Exit Sub
            connection_open()
            sql = "delete from Section_tbl where Section_Id='" & dgvsecn.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("section has been removed")
            connection_close()
            secid()
            clear()
            grid()

        Catch ex As Exception
            MsgBox("Please delete other records belonging to this Section in order to proceed")

        End Try
    End Sub

    Private Sub dgvsecn_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsecn.CellDoubleClick
        connection_open()
        sql = "SELECT     dbo.Section_tbl.Section_Id, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name"
        sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
        sql = sql & "       dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id"
        sql = sql & "  WHERE(dbo.Section_tbl.Section_Id ='" & dgvsecn.CurrentRow.Cells(0).Value & "')"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            txtsecn.Text = reader(2)
            cmbstandrd.Text = reader(1)
        End If
        connection_close()
        ScnDelete.Enabled = True
        ScnUpdate.Enabled = True
        ScnSave.Enabled = False
    End Sub

    Private Sub ScnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScnUpdate.Click
        connection_open()
        sql = "update Section_tbl set Section_Name='" & txtsecn.Text & "',Class_Id='" & cmbstandrd.SelectedValue & "' where Section_id='" & dgvsecn.CurrentRow.Cells(0).Value & "'"
        cmd = New SqlCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        connection_close()
        MsgBox(" Section name is been updated")
        secid()
        clear()
        grid()

    End Sub


    Private Sub ScnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScnClose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True

        Me.Close()

    End Sub

    Private Sub txtsecn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsecn.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub


    Private Sub cmbstandrd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstandrd.SelectedIndexChanged
        txtsecn.Enabled = True


    End Sub

    Private Sub txtsecn_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsecn.Leave
        connection_open()
        sql = "select Section_Name from Section_tbl where Class_Id = '" & cmbstandrd.SelectedValue & "' and Section_Name='" & txtsecn.Text & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            txtsecn.Text = ""
            cmbstandrd.SelectedIndex = -1

        End If

    End Sub


    Private Sub txtsecn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsecn.TextChanged
        If txtsecn.Text = "" Then
            ScnSave.Enabled = False
        Else
            ScnSave.Enabled = True

        End If
    End Sub
End Class