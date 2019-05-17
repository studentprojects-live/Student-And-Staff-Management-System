Imports System.Data.SqlClient

Public Class School_report

    Private Sub School_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Agno_Student_And_Staff_Management_System
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = False

        connection_open()
        sql = "SELECT     dbo.Student1_tbl.Admission_Numb, dbo.Student1_tbl.Student_Name, dbo.Student1_tbl.Gender, dbo.Student1_tbl.DateOfBirth, dbo.Student1_tbl.Age, "
        sql = sql & "               dbo.Student1_tbl.PBVillage, dbo.Student1_tbl.PBTown, dbo.Student1_tbl.PBTaluk, dbo.Student1_tbl.PBDistrict, dbo.Student1_tbl.PBState, "
        sql = sql & "          dbo.Student1_tbl.FathersName, dbo.Student1_tbl.FathersQualification, dbo.Student1_tbl.FathersOccupation, dbo.Student1_tbl.MothersName, "
        sql = sql & "          dbo.Student1_tbl.MothersQualification, dbo.Student1_tbl.MothersOccupation, dbo.Student1_tbl.Gardians_Name, dbo.Student1_tbl.Gardian_Address, "
        sql = sql & "           dbo.Student1_tbl.Annual_Income, dbo.Student1_tbl.Numb_of_Dependancy, dbo.Student1_tbl.Nationality, dbo.Student1_tbl.Religion, dbo.Student1_tbl.Caste, "
        sql = sql & "           dbo.Student1_tbl.Mother_Tongue, dbo.Student1_tbl.PermanantAddress, dbo.Student1_tbl.Prv_SchoolName, dbo.Student1_tbl.Prv_Standard, "
        sql = sql & "            dbo.Student1_tbl.Prv_transferNo, dbo.Student1_tbl.Prv_transferDate, dbo.Student1_tbl.Admission_date, dbo.Class_tbl.Class_Name, dbo.Tc_tbl.Last_date_of_School, "
        sql = sql & "  dbo.Fee_tbl.Receipt_No, dbo.Fee_tbl.Date, dbo.Tc_tbl.tc_id, dbo.Tc_tbl.Tc_date"
        sql = sql & " FROM         dbo.Class_tbl INNER JOIN"
        sql = sql & "              dbo.Section_tbl ON dbo.Class_tbl.Class_Id = dbo.Section_tbl.Class_Id INNER JOIN"
        sql = sql & "              dbo.Tc_tbl ON dbo.Class_tbl.Class_Id = dbo.Tc_tbl.Class_Id INNER JOIN"
        sql = sql & "             dbo.Student1_tbl ON dbo.Class_tbl.Class_Id = dbo.Student1_tbl.Class_Id AND dbo.Section_tbl.Section_Id = dbo.Student1_tbl.Section_Id AND "
        sql = sql & "              dbo.Tc_tbl.Admission_Numb = dbo.Student1_tbl.Admission_Numb INNER JOIN"
        sql = sql & "             dbo.Fee_tbl ON dbo.Student1_tbl.Admission_Numb = dbo.Fee_tbl.Admission_Numb"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader
        Dim i = 0
        While reader.Read = True
            dgvschool.Rows.Add()
            dgvschool.Item(0, i).Value = reader(0)
            dgvschool.Item(1, i).Value = reader(1)
            dgvschool.Item(2, i).Value = reader(2)
            dgvschool.Item(3, i).Value = Format("DD-MM-YYYY", reader(3)) & " " & reader(4)
            dgvschool.Item(4, i).Value = reader(5) & "\n" & reader(6) & "" & reader(7) & "\n" & reader(8) & "\n" & reader(9)
            dgvschool.Item(5, i).Value = reader(10) & "\n" & reader(11) & "\n" & reader(12)
            dgvschool.Item(6, i).Value = reader(13) & "\n" & reader(14) & "\n" & reader(15)
            dgvschool.Item(7, i).Value = reader(16) & "\n" & reader(17) & "\n" & reader(18)
            dgvschool.Item(8, i).Value = reader(19)
            dgvschool.Item(9, i).Value = reader(20)
            dgvschool.Item(10, i).Value = reader(21) & "\n" & reader(22) & "\n" & reader(23)
            dgvschool.Item(11, i).Value = reader(24)
            dgvschool.Item(12, i).Value = reader(25)
            dgvschool.Item(13, i).Value = reader(26)
            dgvschool.Item(14, i).Value = reader(27)
            dgvschool.Item(15, i).Value = reader(28) & "\n" & reader(29)
            dgvschool.Item(17, i).Value = reader(30)
            dgvschool.Item(26, i).Value = reader(31)
            i = i + 1

        End While


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Agno_Student_And_Staff_Management_System.Agno_Menu.Enabled = True
        Me.Close()

    End Sub
End Class