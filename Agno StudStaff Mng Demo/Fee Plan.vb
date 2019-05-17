Imports System.Data.SqlClient
Public Class Fee_Plan
    Dim fees

    Private Sub Fee_Plan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        standrd()
        loadgrid()
        enble()
        btndelete.Enabled = False
        butnsave.Enabled = False

        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
    End Sub
    Sub standrd()
        connection_open()
        sql = "select * from Class_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds3)

        cmbstandard.DataSource = ds3.Tables(0)
        cmbstandard.ValueMember = "Class_Id"
        cmbstandard.DisplayMember = "Class_Name"
        cmbstandard.SelectedIndex = -1
        connection_close()
    End Sub
    Sub feeplanid()

        connection_open()
        sql = " select max(FeePlan_Id)+1 from Fee_Plan_tbl"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                fees = "1"
            Else
                fees = reader(0)
            End If
        End If
        connection_close()

    End Sub
    Private Sub butnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butnsave.Click
        If cmbstandard.SelectedIndex = -1 Or txttotal.Text = "0" Or txttotal.Text = "0" Then
            MsgBox("Please Enter required data")
        Else
            If butnsave.Text = "&Save" Then
                feeplanid()
                connection_open()
                sql = "insert into Fee_Plan_tbl values('" & Int(fees) & "','" & cmbstandard.SelectedValue & "','" & Val(txttution.Text) & "','" & Val(txtadmis.Text) & "','" & Val(txtspecial.Text) & "','" & Val(txtdevelop.Text) & "','" & Val(txtother.Text) & "','" & Val(txttotal.Text) & "')"
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                connection_close()
                MsgBox("Fee plan hass been Added")
                loadgrid()
                clear()
                connection_close()

            ElseIf butnsave.Text = "&Update" Then
                connection_open()
                sql = "update FeePlan_tbl Set Tuition_Fee='" & txttution.Text & "',Admission_fee='" & txtadmis.Text & "',Special_Fee='" & txtspecial.Text & "',Development_Fee='" & txtdevelop.Text & "',Other='" & txtother.Text & "' ,Class_Id='" & cmbstandard.SelectedValue & "',Total_Amount ='" & txttotal.Text & "' where Fee_Plan_Id='" & dgvfeeplan.CurrentRow.Cells(0).Value & "'"
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                connection_close()
                MsgBox("Fee Plan has been Updated")
                loadgrid()
                butnsave.Text = "&Save"
                loadgrid()
                clear()
                connection_close()

            End If
            feeplanid()
        End If

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            connection_open()
            sql = "Delete from Fee_Plan_tbl where FeePlan_Id='" & dgvfeeplan.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Record is Deleted")
            loadgrid()
            clear()
            butnsave.Text = "Save"
            feeplanid()
            connection_close()
        Catch ex As Exception
            MsgBox("Please delete other records belonging to this Feeplan in order to proceed")

        End Try
    End Sub

    
    Sub loadgrid()
        connection_open()
        sql = "SELECT     dbo.Fee_Plan_tbl.FeePlan_Id, dbo.Class_tbl.Class_Name, dbo.Fee_Plan_tbl.Tuition_Fee, dbo.Fee_Plan_tbl.Admission_fee, dbo.Fee_Plan_tbl.Special_Fee, "
        sql = sql & " dbo.Fee_Plan_tbl.Development_Fee, dbo.Fee_Plan_tbl.Other, dbo.Fee_Plan_tbl.Total_Amount"
        sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
        sql = sql & "    dbo.Fee_Plan_tbl ON dbo.Class_tbl.Class_Id = dbo.Fee_Plan_tbl.FeePlan_Id"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        Dim i = 0
        dgvfeeplan.Rows.Clear()
        While reader.Read = True
            dgvfeeplan.Rows.Add()
            dgvfeeplan.Item(0, i).Value = reader(0)
            dgvfeeplan.Item(1, i).Value = reader(1)
            dgvfeeplan.Item(2, i).Value = reader(2)
            dgvfeeplan.Item(3, i).Value = reader(3)
            dgvfeeplan.Item(4, i).Value = reader(4)
            dgvfeeplan.Item(5, i).Value = reader(5)
            dgvfeeplan.Item(6, i).Value = reader(6)
            dgvfeeplan.Item(7, i).Value = reader(7)


            i = i + 1

        End While
        connection_close()

    End Sub

    Private Sub dgvfeeplan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvfeeplan.DoubleClick
        txttution.Text = dgvfeeplan.CurrentRow.Cells(2).Value
        cmbStandard.Text = dgvfeeplan.CurrentRow.Cells(1).Value
        txtadmis.Text = dgvfeeplan.CurrentRow.Cells(3).Value
        txtspecial.Text = dgvfeeplan.CurrentRow.Cells(4).Value
        txtdevelop.Text = dgvfeeplan.CurrentRow.Cells(5).Value
        txtother.Text = dgvfeeplan.CurrentRow.Cells(6).Value
        txttotal.Text = dgvfeeplan.CurrentRow.Cells(7).Value
        TabControl1.SelectedTab = tpFeePlan
        butnsave.Text = "&Update"
        btndelete.Enabled = True

    End Sub
    Sub clear()
        txtadmis.Text = ""
        txtadmis.Text = ""
        txtother.Text = ""
        txtspecial.Text = ""
        txttution.Text = ""
        txtdevelop.Text = ""
        cmbstandard.SelectedIndex = -1
        txttotal.Text = ""
    End Sub
 

 
    Private Sub btntotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntotal.Click
        txttotal.Text = ""
        txttotal.Text = Val(txttution.Text) + Val(txtadmis.Text) + Val(txtdevelop.Text) + Val(txtspecial.Text) + Val(txtother.Text)
        butnsave.Enabled = True
        btndelete.Enabled = False

    End Sub

 
    Sub enble()
        txtadmis.Enabled = False
        txtdevelop.Enabled = False
        txtother.Enabled = False
        txtspecial.Enabled = False
        txttution.Enabled = False
        btntotal.Enabled = False

    End Sub

    Private Sub cmbstandard_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstandard.SelectedIndexChanged
        If Val(cmbstandard.SelectedIndex) <> -1 Then
            txtadmis.Enabled = True
            txtdevelop.Enabled = True
            txtother.Enabled = True
            txtspecial.Enabled = True
            txttution.Enabled = True
            btntotal.Enabled = True

        Else
            txtadmis.Enabled = False
            txtdevelop.Enabled = False
            txtother.Enabled = False
            txtspecial.Enabled = False
            txttution.Enabled = False
            btntotal.Enabled = False
        End If
        Try

            connection_open()
            sql = "select Class_Id from Fee_Plan_tbl where Class_Id='" & cmbstandard.SelectedValue & "'"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            If reader.Read = True Then

                cmbstandard.SelectedIndex = -1
            Else
                btntotal.Enabled = True
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

    End Sub

    Private Sub txttotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.TextChanged
        If txttotal.Text = "" Then
            btndelete.Enabled = False
            butnsave.Enabled = False
        Else
            btndelete.Enabled = True
            butnsave.Enabled = True

        End If
    End Sub

    Private Sub txttution_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttution.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtadmis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadmis.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtspecial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtspecial.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub txtdevelop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdevelop.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

  

    Private Sub txtother_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtother.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

   
End Class