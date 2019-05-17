Imports System.Windows.Forms

Public Class Agno_Student_And_Staff_Management_System
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
    Private Sub Agno_Student_And_Staff_Management_System_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub SchoolInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolInformationToolStripMenuItem.Click


        School_Information.Show()

    End Sub


    Private Sub TransferStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferStudentToolStripMenuItem.Click
        TransferStudent.Show()

    End Sub

    Private Sub NewStandardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewStandardToolStripMenuItem.Click
        New_Standard.Show()
    End Sub

    Private Sub NewSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSectionToolStripMenuItem.Click
        New_Section.Show()

    End Sub

    Private Sub SubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectToolStripMenuItem.Click
        Subject.Show()

    End Sub

    Private Sub ExaminationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExaminationToolStripMenuItem1.Click
        Exam.Show()

    End Sub

    Private Sub WorkdayAllocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkdayAllocationToolStripMenuItem.Click
        workingdays.Show()

    End Sub

    Private Sub FeePlanAllocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeePlanAllocationToolStripMenuItem.Click
        Fee_Plan.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem1.Click
        Department.Show()

    End Sub

    Private Sub DesignationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesignationToolStripMenuItem1.Click
        Designation.Show()

    End Sub

    Private Sub EmployeeRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeRecordToolStripMenuItem.Click
        Staff_Detail.Show()

    End Sub

    Private Sub AttendenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendenceToolStripMenuItem.Click
        EmpAttendance.Show()

    End Sub



    Private Sub EmployeeListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeListToolStripMenuItem.Click
        Employee_list.Show()

    End Sub






    Private Sub AdmissionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmissionToolStripMenuItem.Click
        Admission.Show()

    End Sub

    Private Sub StudentsRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsRegistrationToolStripMenuItem.Click
        Student_registeration.Show()

    End Sub

    Private Sub StudentsAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsAttendanceToolStripMenuItem.Click
        Student_AttendanceFrm.Show()

    End Sub

    Private Sub MarksEntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksEntryToolStripMenuItem1.Click
        marks.Show()

    End Sub

    Private Sub StudentsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsListToolStripMenuItem.Click
        Student_list.Show()

    End Sub

    Private Sub BalanceFeeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'not done
    End Sub

    Private Sub FeeStructureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeeStructureToolStripMenuItem.Click
        feestructure.Show()

    End Sub

    Private Sub ReceiptBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptBookToolStripMenuItem.Click
        reciept.Show()

    End Sub

    Private Sub ClassReportCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassReportCardToolStripMenuItem.Click
        Classreport.Show()

    End Sub

    Private Sub StudentReportCardToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentReportCardToolStripMenuItem1.Click
        Student_report_card.Show()

    End Sub





    Private Sub StudentProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentProfileToolStripMenuItem.Click
        Profile.Show()

    End Sub

    Private Sub EmployeeprofileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeprofileToolStripMenuItem.Click
        Employee_Profile.Show()

    End Sub

    Private Sub FeeRecieptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeeRecieptToolStripMenuItem.Click
        fee.Show()

    End Sub

    Private Sub TransferCertificateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferCertificateToolStripMenuItem.Click
        Transfer_certificate.Show()

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub ClassWiseSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassWiseSubjectsToolStripMenuItem.Click
        SUBJECTSCLASS.Show()

    End Sub

    

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        WELCOME.Close()

    End Sub

    Private Sub CreationOfUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreationOfUserToolStripMenuItem.Click
        Registration.Show()

    End Sub

    Private Sub SchoolReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolReportToolStripMenuItem.Click
        School_report.Show()

    End Sub
End Class
