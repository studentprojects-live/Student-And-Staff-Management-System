Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class School_Information
    Dim sid = 1
    Sub check()
        connection_open()
        sql = " select School_id from School_info"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = False Then
            sid = 1
            btnUpdate.Text = "&Add"
        ElseIf reader.Read = True Then
            sid = reader(0)
        End If
        connection_close()

    End Sub
    Sub txtload()
        If (sid = 1) Then
            Try
                connection_open()
                sql = "select * from School_Info where School_id='" & Val(sid) & "'"
                cmd = New SqlCommand(sql, cnn)
                reader = cmd.ExecuteReader
                If reader.Read = True Then
                    txtSchoolName.Text = reader(1)
                    txtAddress.Text = reader(2)
                    txtcity.Text = reader(3)
                    txtstate.Text = reader(4)
                    txtContact1.Text = reader(5)
                    txtContact2.Text = reader(6)
                    txtEmail.Text = reader(7)
                    txtWebsite.Text = reader(8)
                    lbschool.Text = reader(1)
                    lbadd.Text = reader(2)
                    lbcity.Text = reader(3)
                    lbstate.Text = reader(4)
                    lbcontct1.Text = reader(5)
                    lbcontct2.Text = reader(6)
                    lbemail.Text = reader(7)
                    lbweb.Text = reader(8)
                End If
                connection_close()
            Catch ex As Exception

            End Try
        End If
    End Sub
   

    Private Sub School_Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        alldisable()
        check()
        txtload()
        lbschool.Visible = True
        lbadd.Visible = True
        lbcity.Visible = True
        lbstate.Visible = True
        lbcontct1.Visible = True
        lbcontct2.Visible = True
        lbemail.Visible = True
        lbweb.Visible = True
        txtSchoolName.Visible = False
        txtAddress.Visible = False
        txtcity.Visible = False
        txtstate.Visible = False
        txtContact1.Visible = False
        txtContact2.Visible = False
        txtEmail.Visible = False
        txtWebsite.Visible = False
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

    End Sub

    
   
    Sub allenable()
        txtAddress.Enabled = True
        txtSchoolName.Enabled = True
        txtcity.Enabled = True
        txtstate.Enabled = True
        txtContact1.Enabled = True
        txtContact2.Enabled = True
        txtEmail.Enabled = True
        txtWebsite.Enabled = True
    End Sub
   

   
    Sub alldisable()
        txtAddress.Enabled = False
        txtSchoolName.Enabled = False
        txtcity.Enabled = False
        txtstate.Enabled = False
        txtContact1.Enabled = False
        txtContact2.Enabled = False
        txtEmail.Enabled = False
        txtWebsite.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim pattern As String
        pattern = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If btnUpdate.Text = "&Add" Then
            connection_open()
            sql = "insert into School_info values('" & sid & "','" & txtSchoolName.Text & "','" & txtAddress.Text & "','" & txtcity.Text & "','" & txtstate.Text & "','" & txtContact1.Text & "','" & txtContact2.Text & "','" & txtEmail.Text & "','" & txtWebsite.Text & "')"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("School details have been Created")
            Agno_Student_And_Staff_Management_System.Show()
            Me.Close()
        End If
        If btnUpdate.Text = "&Update" Then
            If MsgBoxResult.No = MsgBox("Are u sure u want to update the details  ", MsgBoxStyle.YesNo) Then
                btnUpdate.Text = "&Update"
                alldisable()
                lbschool.Visible = True
                lbadd.Visible = True
                lbcity.Visible = True
                lbstate.Visible = True
                lbcontct1.Visible = True
                lbcontct2.Visible = True
                lbemail.Visible = True
                lbweb.Visible = True
                txtSchoolName.Visible = False
                txtAddress.Visible = False
                txtcity.Visible = False
                txtstate.Visible = False
                txtContact1.Visible = False
                txtContact2.Visible = False
                txtEmail.Visible = False
                txtWebsite.Visible = False

            Else
                btnUpdate.Text = "&Save"
                allenable()
                txtSchoolName.Visible = True
                txtAddress.Visible = True
                txtcity.Visible = True
                txtstate.Visible = True
                txtContact1.Visible = True
                txtContact2.Visible = True
                txtEmail.Visible = True
                txtWebsite.Visible = True
                lbschool.Visible = False
                lbadd.Visible = False
                lbcity.Visible = False
                lbstate.Visible = False
                lbcontct1.Visible = False
                lbcontct2.Visible = False
                lbemail.Visible = False
                lbweb.Visible = False
                Exit Sub
            End If
        ElseIf btnUpdate.Text = "&Save" Then
            If Regex.IsMatch(txtEmail.Text, pattern) Then
            Else
                MsgBox("Not a valid Email address ")
                txtEmail.Text = ""
                txtEmail.Focus()
                Exit Sub
            End If
            connection_open()
            sql = "  update School_info set School_Name='" & txtSchoolName.Text & "', Address='" & txtAddress.Text & "',City='" & txtcity.Text & "',State='" & txtstate.Text & "',contact1='" & txtContact1.Text & "',contact2='" & txtContact2.Text & "',email='" & txtEmail.Text & "',website='" & txtWebsite.Text & "' "
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("School details have been Saved")
            txtload()
            lbschool.Visible = True
            lbadd.Visible = True
            lbcity.Visible = True
            lbstate.Visible = True
            lbcontct1.Visible = True
            lbcontct2.Visible = True
            lbemail.Visible = True
            lbweb.Visible = True
            txtSchoolName.Visible = False
            txtAddress.Visible = False
            txtcity.Visible = False
            txtstate.Visible = False
            txtContact1.Visible = False
            txtContact2.Visible = False
            txtEmail.Visible = False
            txtWebsite.Visible = False
            btnUpdate.Text = "&Update"
            check()

        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True

        Me.Close()
    End Sub

    Private Sub txtSchoolName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSchoolName.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "32" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub


    Private Sub txtcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "32" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstate.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "32" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtContact1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact1.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "43" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtContact2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact2.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "43" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub lbemail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbemail.Click

    End Sub

    Private Sub lbemail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbemail.Leave

    End Sub

    
End Class