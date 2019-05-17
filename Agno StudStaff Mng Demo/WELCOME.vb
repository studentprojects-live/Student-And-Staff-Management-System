Imports System.Windows.Forms
Imports System.Data.SqlClient



Public Class WELCOME
    Public Shared objOpenedForm As New Form()
    Public Sub LoadForm(ByRef obj As Form)
        obj.MdiParent = Me
        If obj.Name <> objOpenedForm.Name Then
            obj.Location = New Point(0, 0)
            objOpenedForm.Close()
            objOpenedForm = obj
            obj.Show()
        End If
    End Sub
    Sub GRIDLOAD()
        connection_open()
        sql = "SELECT * from login_tbl "
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                Registration.ShowDialog()
            Else
                Log_In.ShowDialog()
            End If
        End If
        connection_close()
    End Sub

    Private Sub WELCOME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        GRIDLOAD()
    End Sub
End Class