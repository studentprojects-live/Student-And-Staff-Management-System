Imports System.Data.SqlClient
Public Class feestructure
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

    Private Sub cmbstand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstand.SelectedIndexChanged
        Try
            connection_open()
            sql = "select * from Fee_Plan_tbl where Class_Id ='" & cmbstand.SelectedValue & "'"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                txttution.Text = reader(2)
                txtadmission.Text = reader(3)
                txtspecial.Text = reader(4)
                txtdeveloped.Text = reader(5)
                txtother.Text = reader(6)
                txttotal.Text = reader(7)
            Else
                clear()

            End If
            connection_close()
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub feestructure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        standard()
        clear()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
    End Sub
    Sub clear()
        txtadmission.Text = ""
        txtdeveloped.Text = ""
        txtother.Text = ""
        txttution.Text = ""
        txtspecial.Text = ""
        txttotal.Text = ""

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

    End Sub
End Class