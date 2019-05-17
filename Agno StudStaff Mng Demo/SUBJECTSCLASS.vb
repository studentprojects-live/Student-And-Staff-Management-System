Imports System.Data.SqlClient
Public Class SUBJECTSCLASS
    Sub standard()
        connection_open()
        sql = "select * from Class_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        cmbstand.DataSource = ds.Tables(0)
        cmbstand.ValueMember = "Class_Id"
        cmbstand.DisplayMember = "Class_Name"
        cmbstand.SelectedIndex = -1
        connection_close()

    End Sub
    Private Sub SUBJECTSCLASS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        standard()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

    End Sub

    Private Sub cmbstand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstand.SelectedIndexChanged
        Try

            connection_open()
            sql = "SELECT     dbo.Subject_tbl.Subject_Id, dbo.Class_tbl.Class_Id, dbo.Subject_tbl.Subject_Name"
            sql = sql & " FROM         dbo.Subject_tbl INNER JOIN"
            sql = sql & "              dbo.Class_tbl ON dbo.Subject_tbl.Class_Id = dbo.Class_tbl.Class_Id"
            sql = sql & " WHERE(dbo.Class_tbl.Class_Id ='" & cmbstand.SelectedValue & "' )"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim i = 0
            Dgvsubject.Rows.Clear()
            While reader.Read = True
                Dgvsubject.Rows.Add()
                Dgvsubject.Item(0, i).Value = reader(0)
                Dgvsubject.Item(1, i).Value = reader(1)
                Dgvsubject.Item(2, i).Value = reader(2)
                i = i + 1

            End While

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

    End Sub
End Class