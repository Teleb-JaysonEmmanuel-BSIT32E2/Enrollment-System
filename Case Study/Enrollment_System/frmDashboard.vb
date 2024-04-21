Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMonitorDashboard.TopLevel = False
        panelMainDashboard.Controls.Add(frmMonitorDashboard)
        frmMonitorDashboard.BringToFront()
        frmMonitorDashboard.Show()
    End Sub
    Private Sub btnDashaboard_Click(sender As Object, e As EventArgs) Handles btnDashaboard.Click

        frmMonitorDashboard.TopLevel = False
        panelMainDashboard.Controls.Add(frmMonitorDashboard)
        frmMonitorDashboard.BringToFront()
        frmMonitorDashboard.Show()

        frmManageUsers.Close()
        frmManageSections.Close()
        frmManageStudents.Close()
        frmManageSubjects.Close()
        frmManageTeachers.Close()
        frmEnrollment.Close()
        frmClassScheduling.Close()
    End Sub
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        'get the frmManageUsers in to front

        frmManageUsers.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageUsers)
        frmManageUsers.BringToFront()
        frmManageUsers.Show()

        frmMonitorDashboard.Close()
        frmManageSections.Close()
        frmManageStudents.Close()
        frmManageSubjects.Close()
        frmManageTeachers.Close()
        frmEnrollment.Close()
        frmClassScheduling.Close()
    End Sub

    Private Sub btnSubjects_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click
        'get the frmManageSubjects in to front
        frmManageSubjects.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageSubjects)
        frmManageSubjects.BringToFront()
        frmManageSubjects.Show()

        frmMonitorDashboard.Close()
        frmManageSections.Close()
        frmManageStudents.Close()
        frmManageUsers.Close()
        frmManageTeachers.Close()
        frmEnrollment.Close()
        frmClassScheduling.Close()
    End Sub

    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click
        frmEnrollment.TopLevel = False
        panelMainDashboard.Controls.Add(frmEnrollment)
        frmEnrollment.BringToFront()
        frmEnrollment.Show()

        frmMonitorDashboard.Close()
        frmManageSections.Close()
        frmManageStudents.Close()
        frmManageUsers.Close()
        frmManageTeachers.Close()
        frmManageSubjects.Close()
        frmClassScheduling.Close()
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        frmClassScheduling.TopLevel = False
        panelMainDashboard.Controls.Add(frmClassScheduling)
        frmClassScheduling.BringToFront()
        frmClassScheduling.Show()

        frmMonitorDashboard.Close()
        frmManageSections.Close()
        frmManageStudents.Close()
        frmManageUsers.Close()
        frmManageTeachers.Close()
        frmEnrollment.Close()
        frmManageSubjects.Close()
        frmClassScheduling.Close()
    End Sub

    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        frmManageSections.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageSections)
        frmManageSections.BringToFront()
        frmManageSections.Show()

        frmMonitorDashboard.Close()
        frmManageStudents.Close()
        frmManageUsers.Close()
        frmManageTeachers.Close()
        frmEnrollment.Close()
        frmManageSubjects.Close()
        frmClassScheduling.Close()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        frmManageStudents.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageStudents)
        frmManageStudents.BringToFront()
        frmManageStudents.Show()

        frmMonitorDashboard.Close()
        frmManageSections.Close()
        frmManageUsers.Close()
        frmManageTeachers.Close()
        frmEnrollment.Close()
        frmManageSubjects.Close()
        frmClassScheduling.Close()
    End Sub

    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        frmManageTeachers.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageTeachers)
        frmManageTeachers.BringToFront()
        frmManageTeachers.Show()

        frmMonitorDashboard.Close()
        frmManageSections.Close()
        frmManageUsers.Close()
        frmEnrollment.Close()
        frmManageSubjects.Close()
        frmClassScheduling.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stsDateTime.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmMainLogin.Show()
        frmLogin.Show()
    End Sub
End Class
