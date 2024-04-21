Public Class frmDashboard
    Public Shared Sub CloseActiveFormExcept(targetForm As Form)
        Dim numForms As Integer = Application.OpenForms.Count  ' Get the number of forms
        For i As Integer = numForms - 1 To 0 Step -1  ' Loop backwards

            Dim frm As Form = Application.OpenForms(i)  ' Access form by index
            If frm IsNot targetForm Then
                frm.Close()
            End If
        Next
    End Sub


    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'the monitor dashboard will load in the main dashboard
        CloseActiveFormExcept(Me)
        frmMonitorDashboard.TopLevel = False
        panelMainDashboard.Controls.Add(frmMonitorDashboard)
        frmMonitorDashboard.BringToFront()
        frmMonitorDashboard.Show()

    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        'get the frmManageUsers in to front
        CloseActiveFormExcept(Me)
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
        CloseActiveFormExcept(Me)
        frmManageSubjects.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageSubjects)
        frmManageSubjects.BringToFront()
        frmManageSubjects.Show()
    End Sub

    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click
        CloseActiveFormExcept(Me)
        frmEnrollment.TopLevel = False
        panelMainDashboard.Controls.Add(frmEnrollment)
        frmEnrollment.BringToFront()
        frmEnrollment.Show()
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        CloseActiveFormExcept(Me)
        frmClassScheduling.TopLevel = False
        panelMainDashboard.Controls.Add(frmClassScheduling)
        frmClassScheduling.BringToFront()
        frmClassScheduling.Show()
    End Sub

    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        CloseActiveFormExcept(Me)
        frmManageSections.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageSections)
        frmManageSections.BringToFront()
        frmManageSections.Show()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        'still on progress for managing fmrStudents
        CloseActiveFormExcept(Me)
        frmManageStudents.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageStudents)
        frmManageStudents.BringToFront()
        frmManageStudents.Show()
    End Sub

    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        CloseActiveFormExcept(Me)
        frmManageTeachers.TopLevel = False
        panelMainDashboard.Controls.Add(frmManageTeachers)
        frmManageTeachers.BringToFront()
        frmManageTeachers.Show()
    End Sub
End Class