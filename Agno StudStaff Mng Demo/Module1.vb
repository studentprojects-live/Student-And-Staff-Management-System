Imports System.Data.SqlClient
Module Module1
    Public cmd As SqlCommand
    Public cnn As SqlConnection
    Public reader As SqlDataReader
    Public ds, ds1, ds2, ds3 As New DataSet
    Public adapter As New SqlDataAdapter
    Public sqlconn, sqldb, sqluser, sqlpass, sql As String
    Public Sub dbconf()
        sqlconn = "DENZIL-PC"
        sqldb = "Agnostud"
        sqluser = "sa"
        sqlpass = "q1w2e3r4/"
    End Sub
    Public Sub connection_open()
        dbconf()
        Dim constring As String = "Data Source=" & sqlconn & ";Initial Catalog=" & sqldb & ";User ID=" & sqluser & ";Password=" & sqlpass & ""
        cnn = New SqlConnection(constring)
        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
    End Sub

    Public Sub connection_close()
        cnn.Close()
    End Sub
    'Public Function isemail(ByVal email As String) As Boolean
    '    Try
    '        Dim ma As New System.Net.Mail.MailAddress(email)
    '        Return True
    '    Catch
    '        Return False
    '    End Try
    'End Function

End Module