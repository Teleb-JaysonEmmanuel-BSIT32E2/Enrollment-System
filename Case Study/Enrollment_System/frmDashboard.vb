Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'the monitor dashboard will load in the main dashboard

        frmMonitorDashboard.TopLevel = False
        panelMainDashboard.Controls.Add(frmMonitorDashboard)
        frmMonitorDashboard.BringToFront()
        frmMonitorDashboard.Show()

    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        'get the frmManageUsers in to front
        frmManageUsers.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageUsers)
        frmManageUsers.BringToFront()
        frmManageUsers.Show()
    End Sub

    Private Sub stsDateTime_Click(sender As Object, e As EventArgs) Handles stsDateTime.Click
        stsDateTime.Text = DateAndTime.Now
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmMainLogin.Show()
        frmLogin.Show()
    End Sub

    Private Sub btnSubjects_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click
        'get the frmManageSubjects in to front
        frmManageSubjects.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageSubjects)
        frmManageSubjects.BringToFront()
        frmManageSubjects.Show()
    End Sub

    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click
        frmEnrollment.TopLevel = False
        panelMainDashboard.Controls.Add(frmEnrollment)
        frmEnrollment.BringToFront()
        frmEnrollment.Show()
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        frmClassScheduling.TopLevel = False
        panelMainDashboard.Controls.Add(frmClassScheduling)
        frmClassScheduling.BringToFront()
        frmClassScheduling.Show()
    End Sub

    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        frmManageSections.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageSections)
        frmManageSections.BringToFront()
        frmManageSections.Show()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        'still on progress for managing fmrStudents
        frmManageStudents.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageStudents)
        frmManageStudents.BringToFront()
        frmManageStudents.Show()
    End Sub

    Private Sub panelMainDashboard_Paint(sender As Object, e As PaintEventArgs) Handles panelMainDashboard.Paint

    End Sub
    Private Sub btnDashaboard_Click(sender As Object, e As EventArgs) Handles btnDashaboard.Click
        frmMonitorDashboard.TopLevel = False
        panelMainDashboard.Controls.Add(frmMonitorDashboard)
        frmMonitorDashboard.BringToFront()
        frmMonitorDashboard.Show()
    End Sub

    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        frmManageTeachers.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageTeachers)
        frmManageTeachers.BringToFront()
        frmManageTeachers.Show()
    End Sub
End Class