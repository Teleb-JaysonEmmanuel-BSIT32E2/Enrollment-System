Public Class frmManageStudents
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmStudentInfo_TrackCourses.Show()
        'frmStudentInfo_TrackCourses.TopLevel = False
        'Panel1.Controls.Add(frmStudentInfo_TrackCourses)
        'frmStudentInfo_TrackCourses.BringToFront()
        'frmStudentInfo_TrackCourses.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmStudentInfo_TrackCourses.Close()
    End Sub
End Class