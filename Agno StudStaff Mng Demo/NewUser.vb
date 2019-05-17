Imports System.Data.SqlClient
Public Class NewUser
    Dim password, userid, oldpass, usrtpe

    Sub loadcmb()
        usrtpe = "Administrator"
        connection_open()
        sql = " select * from login_tbl where User_type='" & usrtpe & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        cmbusertype.Items.Clear()
        If reader.Read = True Then
            cmbusertype.Items.Add("SubUser")
        Else
            cmbusertype.Items.Add("Administrator")
            cmbusertype.Items.Add("SubUser")

        End If
    End Sub
    Sub loadid()
        connection_open()
        sql = " select max(User_Id)+1 from login_tbl"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                userid = "1"
            Else
                userid = reader(0)
            End If
        End If
    End Sub
    Sub clear()
        txtnewpassword.Text = ""
        txtrepassword.Text = ""
        txtusername.Text = ""
        cmbusertype.SelectedIndex = -1
    End Sub
    Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregister.Click
        If btnregister.Text = "&Save" Then
            loadid()

            If txtusername.Text = "" Or cmbusertype.Text = "" Or txtnewpassword.Text = "" Or txtrepassword.Text = "" Then
                MsgBox("Enter all the fields")
            Else
                If (txtnewpassword.Text = txtrepassword.Text) = True Then
                    password = txtnewpassword.Text
                    connection_open()
                    sql = "insert into login_tbl(User_Id,User_type,UserName,Password)values('" & userid & "','" & cmbusertype.SelectedText & "','" & txtusername.Text & "','" & password & "')"
                    cmd = New SqlCommand(sql, cnn)
                    cmd.ExecuteNonQuery()
                    MsgBox(txtusername.Text & " User Has been Created")
                    connection_close()
                    password = ""

                    Call clear()
                Else
                    MsgBox("Password Miss Match")
                    txtnewpassword.Text = ""
                    txtrepassword.Text = ""

                End If
            End If
        End If
    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged
        If txtusername.Text = "" Then

            btnregister.Enabled = False
        Else
            btnregister.Enabled = True

        End If
    End Sub

    Private Sub cmbusertype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusertype.SelectedIndexChanged
        If cmbusertype.SelectedIndex = -1 Then
            btnregister.Enabled = False
        Else
            btnregister.Enabled = True
        End If
    End Sub

    Private Sub txtold_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtold.TextChanged
        If txtold.Text = "" Then
            btnregister.Enabled = False
        Else
            btnregister.Enabled = True
        End If
    End Sub

    Private Sub txtnewpassword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnewpassword.Leave
        If txtnewpassword.TextLength < 8 Then
            MsgBox("Enter mininmum 8 digit Characters")
            txtnewpassword.Text = ""
        End If

    End Sub

    Private Sub txtnewpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnewpassword.TextChanged
        If txtnewpassword.Text = "" Then
            btnregister.Enabled = False
        Else
            btnregister.Enabled = True
        End If
    End Sub

    Private Sub txtrepassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrepassword.TextChanged
        If txtrepassword.Text = "" Then
            btnregister.Enabled = False
        Else
            btnregister.Enabled = True
        End If
    End Sub

    Private Sub NewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadcmb()

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click

    End Sub
End Class