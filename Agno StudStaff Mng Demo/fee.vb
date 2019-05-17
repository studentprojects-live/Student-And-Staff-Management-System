Imports System.Data.SqlClient
Public Class fee
    Sub receipt()
        connection_open()
        sql = " select max(Receipt_No)+1 from Fee_tbl"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                txtreceipt.Text = "101"
            Else
                txtreceipt.Text = reader(0)
            End If
        End If
    End Sub

    Sub fee()
        connection_open()
        sql = "select Total_Amount from Fee_Plan_tbl  where Class_Id='" & cmbclass.SelectedValue & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            txtfee.Text = reader(0)
        End If
        connection_close()
    End Sub
    Sub standard()
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

    Private Sub fee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        standard()
        receipt()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

    End Sub

    Private Sub cmbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclass.SelectedIndexChanged
        Try
            connection_open()
            sql = "select * from Section_tbl where Class_Id='" & cmbclass.SelectedValue & "'"
            cmd = New SqlCommand(sql, cnn)
            adapter.SelectCommand = cmd
            ds1.Clear()
            adapter.Fill(ds1)
            cmbsection.DataSource = ds1.Tables(0)
            cmbsection.ValueMember = "Section_Id"
            cmbsection.DisplayMember = "Section_Name"
            cmbsection.SelectedIndex = -1
            connection_close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbregno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbregno.SelectedIndexChanged
        connection_open()
        sql = "select Student_Name from Student1_tbl where Admission_Numb='" & cmbregno.Text & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            txtfname.Text = reader(0)

        End If
        connection_close()
        fee()
        connection_open()
        sql = "select bal_amt from Fee_tbl where Admission_Numb='" & cmbregno.Text & "' order by Receipt_No desc "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            txtbal.Text = reader(0)
        End If
        connection_close()
        load_bal()

    End Sub


    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If cmbclass.SelectedIndex = -1 Or cmbsection.SelectedIndex = -1 Or cmbregno.SelectedIndex = -1 Then
            MsgBox("Please enter all the fields in order to proceed")
        Else
            load_balance()
            connection_open()
            sql = "insert into fee_tbl values('" & txtreceipt.Text & "','" & cmbregno.Text & "',convert(date,'" & Today.Date & "',105),'" & txtpaid.Text & "','" & txtbal.Text & "')"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox(cmbregno.Text & " details have been loaded to take the fee reciept")
            If MsgBoxResult.No = MsgBox("Are u Sure u want to take the fee reciept", MsgBoxStyle.YesNo) Then Exit Sub

            dbconf()
            Dim rpt As New Feereciprcrys
            rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
            rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
            rpt.SetParameterValue("rno", txtreceipt.Text)
            feereceiptprint.CrystalReportViewer1.ReportSource = rpt
            feereceiptprint.CrystalReportViewer1.Refresh()
            feereceiptprint.ShowDialog()
            clear()
        End If

    End Sub

    Private Sub cmbsection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsection.SelectedIndexChanged
        Try
            cmbregno.Items.Clear()
            connection_open()
            sql = "SELECT Admission_Numb from Student1_tbl where Class_Id='" & cmbclass.SelectedValue & "' and Section_Id='" & cmbsection.SelectedValue & "'  "
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim i = 0
            While reader.Read = True
                cmbregno.Items.Add(reader(0))
                i = i + 1
            End While
        Catch ex As Exception

        End Try
    End Sub
    Sub load_balance()
        If Val(txtfee.Text) - Val(txtpaid.Text) = 0 Then
            txtbal.Text = "0"
        Else
            txtbal.Text = Val(txtfee.Text) - Val(txtpaid.Text)
        End If
    End Sub
    Sub clear()
        txtbal.Text = ""
        txtfee.Text = ""
        txtfname.Text = ""
        txtpaid.Text = ""
        receipt()

    End Sub
    Sub load_bal()
        If Val(txtbal.Text) > 0 Then
            txtfee.Text = Val(txtbal.Text)

        End If
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

    End Sub

    
End Class