Imports System.Data.SqlClient
Public Class Profile

    Dim cl
    Dim sc
    Private Sub btnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupload.Click
        OpenFileDialog1.ShowDialog()
        pbStudentPhoto.ImageLocation = OpenFileDialog1.FileName
        txtImagePath.Text = OpenFileDialog1.FileName
    End Sub
    Sub standard()
        connection_open()
        sql = "select * from Class_tbl"
        cmd = New SqlCommand(sql, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        cmbstnd.DataSource = ds.Tables(0)
        cmbstnd.ValueMember = "Class_Id"
        cmbstnd.DisplayMember = "Class_Name"
        cmbstnd.SelectedIndex = -1
        connection_close()

    End Sub
    Private Sub Profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        txtAdmissionNo.Enabled = False
        cmbsectn.Visible = False
        cmbstnd.Visible = False
        alldisable()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
        dtpDateOfBirth.MaxDate = Today.Date
        dtpAdmissionDate.MaxDate = Today.Date
        dtptc.MaxDate = Today.Date
      
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "&Update" Then
            If MsgBoxResult.No = MsgBox("Are u sure u want to update the details of " & txtAdmissionNo.Text, MsgBoxStyle.YesNo) Then
                btnUpdate.Text = "&Update"
                cmbsectn.Visible = False
                cmbstnd.Visible = False
                alldisable()
            Else
                standard()
                sc = txtsecn.Text
                cl = txtstand.Text


                cmbsectn.Visible = True
                cmbstnd.Visible = True

                cmbstnd.Text = cl
                cmbsectn.Text = sc
                txtstand.Visible = False
                txtsecn.Visible = False
                btnDelete.Visible = False
                btnUpdate.Text = "&Save"
                allenable()
                Exit Sub
            End If
        ElseIf btnUpdate.Text = "&Save" Then
            If txtAdmissionNo.Text = "" Or dtpAdmissionDate.Text = "" Or txtpupilName.Text = "" Or dtpDateOfBirth.Text = "" Or cmbSex.Text = "" Or txtreligion.Text = "" Or txtnationality.Text = "" Or txtcaste.Text = "" Or txtvillage.Text = "" Or txttaluk.Text = "" Or txttown.Text = "" Or txtdistrict.Text = "" Or txtstate.Text = "" Or txtPermanentAddress.Text = "" Or txtF_Name.Text = "" Or txtM_Name.Text = "" Or txtannualincm.Text = "" Or txtM_tongue.Text = "" Or txtPresent_Address.Text = "" Or txtMobile.Text = "" Or txttcnumb.Text = "" Or dtptc.Text = "" Or cmbstnd.Text = "" Or cmbsectn.Text = "" Then
                MsgBox("You have not entered  all The Reqiured Field")
            Else
                connection_open()
                sql = " update Student1_tbl set Admission_date=convert(date,'" & dtpAdmissionDate.Value & "',105),Student_Name='" & txtpupilName.Text & "',"
                sql = sql & "Gender='" & cmbSex.Text & "',DateOfBirth=convert(date,'" & dtpDateOfBirth.Value & "',105),Age='" & txtage.Text & "',PBVillage='" & txtvillage.Text & "',PBTown='" & txttown.Text & "',"
                sql = sql & "PBTaluk= '" & txttaluk.Text & "',PBDistrict='" & txtdistrict.Text & "',PBState='" & txtstate.Text & "',Nationality='" & txtnationality.Text & "',Religion='" & txtreligion.Text & "',"
                sql = sql & " Caste='" & txtcaste.Text & "',PermanantAddress='" & txtPermanentAddress.Text & "',Photo='" & txtImagePath.Text & "',FathersName="
                sql = sql & "'" & txtF_Name.Text & "',FathersQualification='" & txtF_EducQualification.Text & "',FathersOccupation='" & txtF_Occupation.Text & "',MothersName='" & txtM_Name.Text & "',"
                sql = sql & "MothersQualification='" & txtM_EducQualification.Text & "',MothersOccupation='" & txtM_Occupation.Text & "',Annual_Income='" & txtannualincm.Text & "',Numb_of_Dependancy='" & txtdepend.Text & "',Present_Address='" & txtPresent_Address.Text & "',LandLine='" & txtLandline.Text & "',"
                sql = sql & "Mobile='" & txtMobile.Text & "',Gardians_Name='" & txtguardianname.Text & "',Gardian_Address='" & txtguardianaddress.Text & "',Gardians_PhnNumb='" & txtgurdian_number.Text & "',"
                sql = sql & "Prv_SchoolName='" & txtA_SchoolName.Text & "',Prv_Standard='" & txtpstand.Text & "',Prv_transferNo='" & txttcnumb.Text & "',Prv_transferDate='" & dtptc.Value & "',Class_Id='" & cmbstnd.Text & "',"
                sql = sql & "Section_Id='" & cmbsectn.Text & "' where Admission_Numb='" & txtAdmissionNo.Text & "'"
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                connection_close()
                MsgBox("Student " & txtAdmissionNo.Text & " data has been Updated")
                Student_list.Show()
            End If
        End If


    End Sub
    Sub clear()
        txtAdmissionNo.Text = ""
        txtpupilName.Text = ""
        cmbSex.SelectedIndex = -1
        txtage.Text = ""
        txtvillage.Text = ""
        txttown.Text = ""
        txttaluk.Text = ""
        txtdistrict.Text = ""
        txtstate.Text = ""
        txtnationality.Text = ""
        txtreligion.Text = ""
        txtcaste.Text = ""
        txtPermanentAddress.Text = ""
        pbStudentPhoto.ImageLocation = ""
        txtImagePath.Text = ""
        txtF_Name.Text = ""
        txtF_EducQualification.Text = ""
        txtF_Occupation.Text = ""
        txtM_Name.Text = ""
        txtM_EducQualification.Text = ""
        txtM_Occupation.Text = ""
        txtannualincm.Text = ""
        txtdepend.Text = ""
        txtPresent_Address.Text = ""
        txtLandline.Text = ""
        txtMobile.Text = ""
        txtguardianname.Text = ""
        txtguardianaddress.Text = ""
        txtgurdian_number.Text = ""
        txtA_SchoolName.Text = ""
        txtpstand.Text = ""
        txttcnumb.Text = ""
        cmbsectn.SelectedIndex = -1
        cmbstnd.SelectedIndex = -1
        dtpDateOfBirth.Text = Today.Date
        dtpAdmissionDate.Text = Today.Date
        dtptc.Text = Today.Date
    End Sub


   
    Sub allenable()

        txtpupilName.Enabled = True
        cmbSex.Enabled = True
        txtage.Enabled = True
        txtvillage.Enabled = True
        txttown.Enabled = True
        txttaluk.Enabled = True
        txtdistrict.Enabled = True
        txtstate.Enabled = True
        txtnationality.Enabled = True
        txtreligion.Enabled = True
        txtcaste.Enabled = True
        txtPermanentAddress.Enabled = True
        btnupload.Enabled = True
        txtImagePath.Enabled = True
        txtF_Name.Enabled = True
        txtF_EducQualification.Enabled = True
        txtF_Occupation.Enabled = True
        txtM_Name.Enabled = True
        txtM_EducQualification.Enabled = True
        txtM_Occupation.Enabled = True
        txtannualincm.Enabled = True
        txtdepend.Enabled = True
        txtPresent_Address.Enabled = True
        txtLandline.Enabled = True
        txtMobile.Enabled = True
        txtguardianname.Enabled = True
        txtguardianaddress.Enabled = True
        txtgurdian_number.Enabled = True
        txtA_SchoolName.Enabled = True
        txtpstand.Enabled = True
        txttcnumb.Enabled = True
        txtstand.Enabled = True
        txtsecn.Enabled = True
        txtM_tongue.Enabled = True
        dtpAdmissionDate.Enabled = True
        dtpDateOfBirth.Enabled = True
        dtptc.Enabled = True


    End Sub
    Sub alldisable()

        txtpupilName.Enabled = False
        cmbSex.Enabled = False
        txtage.Enabled = False
        txtvillage.Enabled = False
        txttown.Enabled = False
        txttaluk.Enabled = False
        txtdistrict.Enabled = False
        txtstate.Enabled = False
        txtnationality.Enabled = False
        txtreligion.Enabled = False
        txtcaste.Enabled = False
        txtPermanentAddress.Enabled = False
        btnupload.Enabled = False
        txtImagePath.Enabled = False
        txtF_Name.Enabled = False
        txtF_EducQualification.Enabled = False
        txtF_Occupation.Enabled = False
        txtM_Name.Enabled = False
        txtM_EducQualification.Enabled = False
        txtM_Occupation.Enabled = False
        txtannualincm.Enabled = False
        txtdepend.Enabled = False
        txtPresent_Address.Enabled = False
        txtLandline.Enabled = False
        txtMobile.Enabled = False
        txtguardianname.Enabled = False
        txtguardianaddress.Enabled = False
        txtgurdian_number.Enabled = False
        txtA_SchoolName.Enabled = False
        txtpstand.Enabled = False
        txttcnumb.Enabled = False
        txtstand.Enabled = False
        txtsecn.Enabled = False
        txtM_tongue.Enabled = False
        dtpAdmissionDate.Enabled = False
        dtpDateOfBirth.Enabled = False
        dtptc.Enabled = False

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        connection_open()
        If MsgBoxResult.No = MsgBox("Are U Sure u want to Delete The details of " & txtAdmissionNo.Text, MsgBoxStyle.YesNo) Then Exit Sub
        sql = " delete from Student1_tbl where Admission_Numb='" & txtAdmissionNo.Text & "'"
        cmd = New SqlCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        connection_close()
        MsgBox(txtAdmissionNo.Text & "Record has been deleted")
        clear()
        Student_list.Show()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True

        Me.Close()
        Student_list.Show()

    End Sub
    Private Sub txtA_SchoolName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtA_SchoolName.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpstand_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpstand.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txttcnumb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttcnumb.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpupilName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpupilName.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtreligion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreligion.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtnationality_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnationality.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtvillage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvillage.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttaluk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttaluk.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttown_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttown.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtdistrict_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdistrict.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub




    Private Sub txtstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstate.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtF_Name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtF_Name.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtF_EducQualification_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtF_EducQualification.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtF_Occupation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtF_Occupation.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtM_Occupation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtM_Occupation.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtM_EducQualification_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtM_EducQualification.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtM_Name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtM_Name.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub




    Private Sub txtM_tongue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtM_tongue.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtdepend_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdepend.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtannualincm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtannualincm.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtMobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtLandline_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLandline.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtguardianname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtguardianname.KeyPress
        If Char.IsDigit(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtgurdian_number_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgurdian_number.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    
    
    Private Sub cmbstnd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstnd.SelectedIndexChanged
        Try
            connection_open()
            sql = "select * from Section_tbl where Class_Id='" & cmbstnd.SelectedValue & "'"
            cmd = New SqlCommand(sql, cnn)
            adapter.SelectCommand = cmd
            ds1.Clear()
            adapter.Fill(ds1)
            cmbsectn.DataSource = ds1.Tables(0)
            cmbsectn.ValueMember = "Section_Id"
            cmbsectn.DisplayMember = "Section_Name"
            cmbsectn.SelectedIndex = -1
            connection_close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpDateOfBirth_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDateOfBirth.Leave
        If txtage.Text = "" Then
            MsgBox(" invalid Date of Birth")
            dtpDateOfBirth.Text = Today.Date
        End If
    End Sub

    Private Sub dtpDateOfBirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOfBirth.ValueChanged
        Dim i As Integer
        i = DateDiff("yyyy", dtpDateOfBirth.Value.Date, Today.Date)
        txtage.Text = i
        If i >= 5 Then
            txtage.Text = i
        Else
            txtage.Text = ""
        End If
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub grpStudentInfo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpStudentInfo.Enter

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub grpAddmissionInfo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpAddmissionInfo.Enter

    End Sub
End Class