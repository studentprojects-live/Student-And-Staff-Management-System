Imports System.Data.SqlClient
Public Class Log_In

  

   
    Private Sub Log_In_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadcombo()
    End Sub
    Sub loadcombo()
        connection_open()
        sql = "select distinct(User_Type) from login_tbl"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        cmbusertype.Items.Clear()
        While reader.Read = True
            cmbusertype.Items.Add(reader(0))
        End While
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Or cmbusertype.SelectedIndex = -1 Then
            MsgBox("Enter all the  fields")
        Else
            connection_open()
            sql = "select * from login_tbl where UserName='" & txtusername.Text & "' and Password='" & txtpassword.Text & "' and User_type='" & cmbusertype.Text & "' "
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                MsgBox("Login Successful")

                If reader(2) = "admin" Then
                    Agno_Student_And_Staff_Management_System.Show()

                    Me.Close()
                Else
                    Agno_Student_And_Staff_Management_System.SchoolToolStripMenuItem.Visible = False
                    Agno_Student_And_Staff_Management_System.Show()

                    Me.Close()
                End If
            Else
                MsgBox("Invalid User")
            End If
                connection_close()
            End If
        clear()

    End Sub
    Sub clear()
        cmbusertype.SelectedIndex = -1
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        WELCOME.Close()

        Me.Close()

    End Sub
End Class
