Imports System.Data.SqlClient
Public Class Student_list

    Private Sub Student_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        loadgrid()
        txtSearchInfo.Enabled = False
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False
    End Sub
    Sub loadgrid()
        Try
            connection_open()
            sql = "SELECT     dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name, dbo.Student1_tbl.Gender, "
            sql = sql & " dbo.Student1_tbl.DateOfBirth, dbo.Student1_tbl.FathersName, dbo.Student1_tbl.MothersName, dbo.Student1_tbl.PermanantAddress, dbo.Student1_tbl.Mobile"
            sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
            sql = sql & "                    dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id INNER JOIN"
            sql = sql & "                  dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id AND dbo.Section_tbl.Section_Id = dbo.Student1_tbl.Section_Id"

            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim f = 0
            dgvSearchList.Rows.Clear()
            While reader.Read = True
                dgvSearchList.Rows.Add()
                dgvSearchList.Item(0, f).Value = reader(0)
                dgvSearchList.Item(1, f).Value = reader(1)
                dgvSearchList.Item(2, f).Value = reader(2)
                dgvSearchList.Item(3, f).Value = reader(3)
                dgvSearchList.Item(4, f).Value = reader(4)
                dgvSearchList.Item(5, f).Value = Format("DD-MM-YYYY", reader(5))
                dgvSearchList.Item(6, f).Value = reader(6)
                dgvSearchList.Item(7, f).Value = reader(7)
                dgvSearchList.Item(8, f).Value = reader(8)
                dgvSearchList.Item(9, f).Value = reader(9)
                f = f + 1
            End While
            connection_close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub txtSearchInfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchInfo.KeyPress
        If cmbSearch.SelectedIndex = 0 Then
            If Char.IsLetterOrDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Or Asc(e.KeyChar) = "47" Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        ElseIf cmbSearch.SelectedIndex = 1 Then
            If Char.IsDigit(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf cmbSearch.SelectedIndex = 2 Then
            If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf cmbSearch.SelectedIndex = 3 Then
            If Char.IsLetter(e.KeyChar) = True Or Asc(e.KeyChar) = "8" Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub
    Private Sub txtSearchInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchInfo.TextChanged
        If cmbSearch.Text = "Admission No" Then
            connection_open()
            sql = "SELECT     dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name, dbo.Student1_tbl.Gender, "
            sql = sql & " dbo.Student1_tbl.DateOfBirth, dbo.Student1_tbl.FathersName, dbo.Student1_tbl.MothersName, dbo.Student1_tbl.PermanantAddress, dbo.Student1_tbl.Mobile"
            sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
            sql = sql & "                    dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id INNER JOIN"
            sql = sql & "                  dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id AND dbo.Section_tbl.Section_Id = dbo.Student1_tbl.Section_Id"
            sql = sql & " WHERE     (dbo.Student1_tbl.Admission_Numb like '" & txtSearchInfo.Text & "%')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim f = 0
            dgvSearchList.Rows.Clear()
            While reader.Read = True
                dgvSearchList.Rows.Add()
                dgvSearchList.Item(0, f).Value = reader(0)
                dgvSearchList.Item(1, f).Value = reader(1)
                dgvSearchList.Item(2, f).Value = reader(2)
                dgvSearchList.Item(3, f).Value = reader(3)
                dgvSearchList.Item(4, f).Value = reader(4)
                dgvSearchList.Item(5, f).Value = Format("DD-MM-YYYY", reader(5))
                dgvSearchList.Item(6, f).Value = reader(6)
                dgvSearchList.Item(7, f).Value = reader(7)
                dgvSearchList.Item(8, f).Value = reader(8)
                dgvSearchList.Item(9, f).Value = reader(9)
                f = f + 1
            End While
            connection_close()
        ElseIf cmbSearch.Text = "Admission Year" Then
            connection_open()
            sql = "SELECT     dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name, dbo.Student1_tbl.Gender, "
            sql = sql & " dbo.Student1_tbl.DateOfBirth, dbo.Student1_tbl.FathersName, dbo.Student1_tbl.MothersName, dbo.Student1_tbl.PermanantAddress, dbo.Student1_tbl.Mobile"
            sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
            sql = sql & "                    dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id INNER JOIN"
            sql = sql & "                  dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id AND dbo.Section_tbl.Section_Id = dbo.Student1_tbl.Section_Id"
            sql = sql & " WHERE     (year(dbo.Student1_tbl.Admission_date) like '" & txtSearchInfo.Text & "%')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim f = 0
            dgvSearchList.Rows.Clear()
            While reader.Read = True
                dgvSearchList.Rows.Add()
                dgvSearchList.Item(0, f).Value = reader(0)
                dgvSearchList.Item(1, f).Value = reader(1)
                dgvSearchList.Item(2, f).Value = reader(2)
                dgvSearchList.Item(3, f).Value = reader(3)
                dgvSearchList.Item(4, f).Value = reader(4)
                dgvSearchList.Item(5, f).Value = Format("DD-MM-YYYY", reader(5))
                dgvSearchList.Item(6, f).Value = reader(6)
                dgvSearchList.Item(7, f).Value = reader(7)
                dgvSearchList.Item(8, f).Value = reader(8)
                dgvSearchList.Item(9, f).Value = reader(9)
                f = f + 1
            End While
            connection_close()
        ElseIf cmbSearch.Text = "Student Name" Then
            connection_open()
            sql = "SELECT     dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name, dbo.Student1_tbl.Gender, "
            sql = sql & " dbo.Student1_tbl.DateOfBirth, dbo.Student1_tbl.FathersName, dbo.Student1_tbl.MothersName, dbo.Student1_tbl.PermanantAddress, dbo.Student1_tbl.Mobile"
            sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
            sql = sql & "                    dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id INNER JOIN"
            sql = sql & "                  dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id AND dbo.Section_tbl.Section_Id = dbo.Student1_tbl.Section_Id"
            sql = sql & " WHERE     (dbo.Student1_tbl.Student_Name like '" & txtSearchInfo.Text & "%')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim f = 0
            dgvSearchList.Rows.Clear()
            While reader.Read = True
                dgvSearchList.Rows.Add()
                dgvSearchList.Item(0, f).Value = reader(0)
                dgvSearchList.Item(1, f).Value = reader(1)
                dgvSearchList.Item(2, f).Value = reader(2)
                dgvSearchList.Item(3, f).Value = reader(3)
                dgvSearchList.Item(4, f).Value = reader(4)
                dgvSearchList.Item(5, f).Value = Format("DD-MM-YYYY", reader(5))
                dgvSearchList.Item(6, f).Value = reader(6)
                dgvSearchList.Item(7, f).Value = reader(7)
                dgvSearchList.Item(8, f).Value = reader(8)
                dgvSearchList.Item(9, f).Value = reader(9)
                f = f + 1
            End While
            connection_close()
        ElseIf cmbSearch.Text = "Standard" Then
            connection_open()
            sql = "SELECT     dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Class_tbl.Class_Name, dbo.Section_tbl.Section_Name, dbo.Student1_tbl.Gender, "
            sql = sql & " dbo.Student1_tbl.DateOfBirth, dbo.Student1_tbl.FathersName, dbo.Student1_tbl.MothersName, dbo.Student1_tbl.PermanantAddress, dbo.Student1_tbl.Mobile"
            sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
            sql = sql & "                    dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id INNER JOIN"
            sql = sql & "                  dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id AND dbo.Section_tbl.Section_Id = dbo.Student1_tbl.Section_Id"
            sql = sql & " WHERE     (dbo.Class_tbl.Class_Name = '" & txtSearchInfo.Text & "%')"
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            Dim f = 0
            dgvSearchList.Rows.Clear()
            While reader.Read = True
                dgvSearchList.Rows.Add()
                dgvSearchList.Item(0, f).Value = reader(0)
                dgvSearchList.Item(1, f).Value = reader(1)
                dgvSearchList.Item(2, f).Value = reader(2)
                dgvSearchList.Item(3, f).Value = reader(3)
                dgvSearchList.Item(4, f).Value = reader(4)
                dgvSearchList.Item(5, f).Value = Format("DD-MM-YYYY", reader(5))
                dgvSearchList.Item(6, f).Value = reader(6)
                dgvSearchList.Item(7, f).Value = reader(7)
                dgvSearchList.Item(8, f).Value = reader(8)
                dgvSearchList.Item(9, f).Value = reader(9)
                f = f + 1
            End While
            connection_close()

        End If
    End Sub
    Private Sub dgvSearchList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearchList.CellDoubleClick
        connection_open()
        sql = " SELECT     dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Admission_date, dbo.Student1_tbl.Student_Name, dbo.Student1_tbl.Gender, dbo.Student1_tbl.DateOfBirth, "
        sql = sql & "                dbo.Student1_tbl.Age, dbo.Student1_tbl.PBVillage, dbo.Student1_tbl.PBTown, dbo.Student1_tbl.PBTaluk, dbo.Student1_tbl.PBDistrict, dbo.Student1_tbl.PBState, "
        sql = sql & "       dbo.Student1_tbl.Nationality, dbo.Student1_tbl.Religion, dbo.Student1_tbl.Caste, dbo.Student1_tbl.PermanantAddress, dbo.Student1_tbl.Photo, "
        sql = sql & "            dbo.Student1_tbl.FathersName, dbo.Student1_tbl.FathersQualification, dbo.Student1_tbl.FathersOccupation, dbo.Student1_tbl.MothersName, "
        sql = sql & "        dbo.Student1_tbl.MothersQualification, dbo.Student1_tbl.Mother_Tongue, dbo.Student1_tbl.MothersOccupation, dbo.Student1_tbl.Annual_Income, "
        sql = sql & "             dbo.Student1_tbl.Numb_of_Dependancy, dbo.Student1_tbl.Present_Address, dbo.Student1_tbl.LandLine, dbo.Student1_tbl.Mobile, dbo.Student1_tbl.Gardians_Name, "
        sql = sql & "              dbo.Student1_tbl.Gardian_Address, dbo.Student1_tbl.Gardians_PhnNumb, dbo.Student1_tbl.Prv_SchoolName, dbo.Student1_tbl.Prv_Standard, "
        sql = sql & "  dbo.Student1_tbl.Prv_transferNo, dbo.Student1_tbl.Prv_transferDate, dbo.Section_tbl.Section_Name, dbo.Class_tbl.Class_Name"
        sql = sql & " FROM           dbo.Class_tbl INNER JOIN"
        sql = sql & "               dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id INNER JOIN"
        sql = sql & "               dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id AND dbo.Section_tbl.Section_Id = dbo.Student1_tbl.Section_Id"
        sql = sql & "   WHERE (dbo.Student1_tbl.Admission_Numb = '" & dgvSearchList.CurrentRow.Cells(0).Value & "')"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            Profile.txtAdmissionNo.Text = reader(0)
            Profile.dtpAdmissionDate.Value = reader(1)
            Profile.txtpupilName.Text = reader(2)
            Profile.cmbSex.Text = reader(3)
            Profile.dtpDateOfBirth.Value = reader(4)
            Profile.txtage.Text = reader(5)
            Profile.txtvillage.Text = reader(6)
            Profile.txttown.Text = reader(7)
            Profile.txttaluk.Text = reader(8)
            Profile.txtdistrict.Text = reader(9)
            Profile.txtstate.Text = reader(10)
            Profile.txtnationality.Text = reader(11)
            Profile.txtreligion.Text = reader(12)
            Profile.txtcaste.Text = reader(13)
            Profile.txtPermanentAddress.Text = reader(14)
            Profile.pbStudentPhoto.ImageLocation = reader(15)
            Profile.txtImagePath.Text = reader(15)
            Profile.txtF_Name.Text = reader(16)
            Profile.txtF_EducQualification.Text = reader(17)
            Profile.txtF_Occupation.Text = reader(18)
            Profile.txtM_Name.Text = reader(19)
            Profile.txtM_EducQualification.Text = reader(20)
            Profile.txtM_tongue.Text = reader(21)
            Profile.txtM_Occupation.Text = reader(22)
            Profile.txtannualincm.Text = reader(23)
            Profile.txtdepend.Text = reader(24)
            Profile.txtPresent_Address.Text = reader(25)
            Profile.txtLandline.Text = reader(26)
            Profile.txtMobile.Text = reader(27)
            Profile.txtguardianname.Text = reader(28)
            Profile.txtguardianaddress.Text = reader(29)
            Profile.txtgurdian_number.Text = reader(30)
            Profile.txtA_SchoolName.Text = reader(31)
            Profile.txtpstand.Text = reader(32)
            Profile.txttcnumb.Text = reader(33)
            Profile.dtptc.Value = reader(34)
            Profile.txtstand.Text = reader(36)
            Profile.txtsecn.Text = reader(35)
        End If
        Profile.Show()

    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
        If cmbSearch.Text = "Admission No" Or cmbSearch.Text = "Student Name" Or cmbSearch.Text = "Admission Year" Or cmbSearch.Text = "Standard" Then
            txtSearchInfo.Enabled = True
        Else
            txtSearchInfo.Enabled = False

        End If
    End Sub

   
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Hide()
        Agno_Student_And_Staff_Management_System.Show()
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True



    End Sub

    Private Sub dgvSearchList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearchList.CellContentClick

    End Sub
End Class