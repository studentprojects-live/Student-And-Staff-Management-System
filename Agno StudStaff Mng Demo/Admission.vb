Imports System.Data.SqlClient
Public Class Admission

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        If txtAdmissionNo.Text = "" Or dtpAdmissionDate.Text = "" Or txtpupilName.Text = "" Or dtpDateOfBirth.Text = "" Or cmbSex.Text = "" Or txtreligion.Text = "" Or txtnationality.Text = "" Or txtcaste.Text = "" Or txtvillage.Text = "" Or txttaluk.Text = "" Or txttown.Text = "" Or txtdistrict.Text = "" Or txtstate.Text = "" Or txtPermanentAddress.Text = "" Or txtF_Name.Text = "" Or txtM_Name.Text = "" Or txtannualincm.Text = "" Or txtM_tongue.Text = "" Or txtPresent_Address.Text = "" Or txtMobile.Text = "" Or txttcnumb.Text = "" Or dtptc.Text = "" Or cmbstnd.Text = "" Or cmbsectn.Text = "" Then
            MsgBox("You have not entered  all The Reqiured Field")
        ElseIf txtage.Text = "" Or txtage.Text = "0" Then
            MsgBox(" Students Date of birth is not valid")

        Else
            connection_open()
            sql = "insert into Student1_tbl values ('" & txtAdmissionNo.Text & "',convert(date,'" & dtpAdmissionDate.Value & "',105),'" & txtpupilName.Text & "',"
            sql = sql & "'" & cmbSex.Text & "',convert(date,'" & dtpDateOfBirth.Value & "',105),'" & txtage.Text & "','" & txtvillage.Text & "','" & txttown.Text & "',"
            sql = sql & " '" & txttaluk.Text & "','" & txtdistrict.Text & "','" & txtstate.Text & "','" & txtnationality.Text & "','" & txtreligion.Text & "',"
            sql = sql & " '" & txtcaste.Text & "','" & txtPermanentAddress.Text & "','" & txtImagePath.Text & "', "
            sql = sql & "'" & txtF_Name.Text & "','" & txtF_EducQualification.Text & "','" & txtF_Occupation.Text & "','" & txtM_Name.Text & "',"
            sql = sql & "'" & txtM_EducQualification.Text & "','" & txtM_tongue.Text & "','" & txtM_Occupation.Text & "','" & txtannualincm.Text & "','" & txtdepend.Text & "','" & txtPresent_Address.Text & "','" & txtLandline.Text & "',"
            sql = sql & "'" & txtMobile.Text & "','" & txtguardianname.Text & "','" & txtguardianaddress.Text & "','" & txtgurdian_number.Text & "',"
            sql = sql & "'" & txtA_SchoolName.Text & "','" & txtpstand.Text & "','" & txttcnumb.Text & "',convert(date,'" & dtptc.Value & "',105),'" & cmbstnd.SelectedValue & "',"
            sql = sql & "'" & cmbsectn.SelectedValue & "')"
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Student " & txtAdmissionNo.Text & " has been Added")

            clear()
            loadAdmissionid()

        End If

    End Sub

    Sub loadAdmissionid()
        connection_open()
        sql = " select max(substring(Admission_Numb,1,len(Admission_Numb)-5))+1 from Student1_tbl"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            If IsDBNull(reader(0)) Then
                txtAdmissionNo.Text = "1/" & Today.Year
            Else
                txtAdmissionNo.Text = reader(0) & "/" & Today.Year
            End If
        End If
        connection_close()

    End Sub

    Private Sub btnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupload.Click
        OpenFileDialog1.ShowDialog()
        pbStudentPhoto.ImageLocation = OpenFileDialog1.FileName
        txtImagePath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Admission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        loadAdmissionid()
        standard()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
        dtpDateOfBirth.MaxDate = Today.Date
        dtpAdmissionDate.MaxDate = Today.Date
        dtptc.MaxDate = Today.Date

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
    Private Sub cmbstnd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbstnd.SelectedValueChanged
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
    Sub clear()
        txtAdmissionNo.Text = ""
        txtM_tongue.Text = ""

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
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

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

    Private Sub dtpDateOfBirth_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDateOfBirth.Leave
        If txtage.Text = "" Then
            MsgBox(" invalid Date of Birth")
            dtpDateOfBirth.Text = Today.Date
        End If
    End Sub
    Private Sub dtpDateOfBirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOfBirth.ValueChanged

        Dim i As Integer
        i = DateDiff("yyyy", dtpDateOfBirth.Value.Date, Today.Date)
        If i >= 5 Then
            txtage.Text = i
        Else
            txtage.Text = ""
        End If
    End Sub

    Private Sub txtage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtage.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = "8" Then
            e.Handled = True
        Else
            e.Handled = False

        End If
    End Sub
    Private Sub txtMobile_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobile.Leave
        If txtMobile.TextLength < 10 Then
            txtMobile.Text = ""

        End If
    End Sub


    Private Sub txtLandline_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLandline.Leave
        If txtLandline.TextLength < 7 Then
            txtLandline.Text = ""

        End If
    End Sub

    Private Sub txtage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtage.TextChanged
       
    End Sub
End Class