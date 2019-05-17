Imports System.Data.SqlClient
Public Class Transfer_certificate
    Dim caste, stard
    Private Sub Transfer_certificate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        loadadmission()
        checkradiobtn()
        tcid()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

    End Sub
    Sub loadadmission()
        connection_open()
        sql = "Select Admission_Numb from Student1_tbl"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        Dim i = 0
        While reader.Read = True
            cmbadmissionNo.Items.Add(reader(0))
            i = i + 1
        End While
        connection_close()
    End Sub
    Sub loadAll()
        connection_open()
        sql = "SELECT     dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Admission_date, dbo.Student1_tbl.Student_Name, dbo.Student1_tbl.Gender, dbo.Student1_tbl.DateOfBirth, "
        sql = sql & "              dbo.Student1_tbl.PBVillage, dbo.Student1_tbl.PBTown, dbo.Student1_tbl.PBTaluk, dbo.Student1_tbl.PBDistrict, dbo.Student1_tbl.PBState, dbo.Student1_tbl.Nationality, "
        sql = sql & "  dbo.Student1_tbl.Religion, dbo.Student1_tbl.FathersName, dbo.Student1_tbl.MothersName, dbo.Student1_tbl.Mother_Tongue, dbo.Class_tbl.Class_Name, dbo.Class_tbl.Class_Id"
        sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
        sql = sql & "                      dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id"
        sql = sql & " WHERE     (dbo.Student1_tbl.Admission_Numb = '" & cmbadmissionNo.Text & "')"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            dtpAdmissiondate.Text = reader(1)
            txtname.Text = reader(2)
            txtsex.Text = reader(3)
            dtpdob.Text = reader(4)
            txtvillage.Text = reader(5)
            txttown.Text = reader(6)
            txttaluk.Text = reader(7)
            txtdistrict.Text = reader(8)
            txtstate.Text = reader(9)
            txtnationality.Text = reader(10)
            txtreligion.Text = reader(11)
            txtFatherName.Text = reader(12)
            txtMotherName.Text = reader(13)
            txtM_tongue.Text = reader(14)
            txtprentStandard.Text = reader(15)
            stard = reader(16)
        End If
        connection_close()

    End Sub

    Private Sub cmbadmissionNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbadmissionNo.SelectedIndexChanged
        connection_open()
        sql = "select Admission_Numb from Tc_tbl where Admission_Numb ='" & cmbadmissionNo.Text & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader

        If reader.Read = True Then
            cmbadmissionNo.SelectedIndex = -1
        Else

        End If
        If cmbadmissionNo.SelectedIndex = -1 Then
            btnsave.Enabled = False
        Else
            btnsave.Enabled = True
        End If
        loadAll()


    End Sub

 
    Sub checkradiobtn()
        If rbshedulCast.Checked = True Then
            caste = rbshedulCast.Text
        ElseIf rbshedultrbe.Checked = True Then
            caste = rbshedultrbe.Text
        Else
            caste = rbnone.Text
        End If
    End Sub
    Sub tcid()
        connection_open()
        sql = " select max(cast(substring(tc_id,3,len(tc_id))+1 as int))from Tc_tbl"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                txttc.Text = "TC101"
            Else
                txttc.Text = "TC" & reader(0)
            End If
        End If
    End Sub

   

    Private Sub txtCharacter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCharacter.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub
    Sub clear()
        dtpAdmissiondate.Text = ""
        txtname.Text = ""
        txtsex.Text = ""
        dtpdob.Text = ""
        txtvillage.Text = ""
        txttown.Text = ""
        txttaluk.Text = ""
        txtdistrict.Text = ""
        txtstate.Text = ""
        txtnationality.Text = ""
        txtreligion.Text = ""
        txtFatherName.Text = ""
        txtMotherName.Text = ""
        txtM_tongue.Text = ""
        txtCharacter.Text = ""
        rbnone.Checked = False
        rbshedulCast.Checked = False
        rbshedultrbe.Checked = False

        txtprentStandard.Text = ""
    End Sub
   
   
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtCharacter.Text = "" Or txtmedium.Text = "" Or cmbqualified.SelectedIndex = -1 Or cmbmedical.SelectedIndex = -1 Or txtnoofschooldays.Text = "" Or txtattended.Text = "" Then
            MsgBox("Enter all the fields marked as *")
        Else
            
            connection_open()
            sql = " insert into Tc_tbl values('" & txttc.Text & "','" & cmbadmissionNo.Text & "','" & Val(stard) & "','" & caste & "','" & txtmedium.Text & "','" & cmbqualified.Text & "','" & cmbmedical.Text & "',"
            sql = sql & "'" & txtlanguage.Text & "','" & txtelective.Text & "','" & txtnoofschooldays.Text & "','" & txtattended.Text & "',convert(date,'" & dtplastSchool.Value & "',105),'" & txtscholarnature.Text & "','" & txtscholarperiod.Text & "',"
            sql = sql & " '" & txtfeenature.Text & "','" & txtfeeperiod.Text & "',convert(date,'" & dtptc.Value & "',105),'" & txtCharacter.Text & "','" & cmbfee.Text & "')"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            If MsgBoxResult.No = MsgBox("Details of" & cmbadmissionNo.Text & " have been saved do u want to take the printout of the Transfer Certificate   ", MsgBoxStyle.YesNo) Then Exit Sub
            dbconf()
            Dim rpt As New CrysTC
            rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
            rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
            rpt.SetParameterValue("tcid", txttc.Text)
            frmPrintTC.crtc.ReportSource = rpt
            frmPrintTC.crtc.Refresh()
            frmPrintTC.ShowDialog()
        End If

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()
    End Sub
End Class