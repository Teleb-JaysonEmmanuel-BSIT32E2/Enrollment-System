Imports System.Data.OleDb

Public Class frmCashier
    Private Sub frmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged
        sql = "Select LastName,FirstName,MiddleName,SchoolYear, Course, Semester, YearLevel, SectionName from tblEnrolledStudent where StudentNo ='" & txtSearchBar.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtStudentName.Text = dr("FirstName").ToString & " " & dr("MiddleName").ToString & " " & dr("LastName").ToString
            txtSchoolYear.Text = dr("SchoolYear").ToString
            txtCourse.Text = dr("Course").ToString
            txtSemester.Text = dr("Semester").ToString
            txtYearLevel.Text = dr("YearLevel").ToString
            txtSection.Text = dr("SectionName").ToString
        End If
    End Sub

    Private Sub loadAccount()
        sql = "Select * from qrySubjectList WHERE SectionName = '" & txtSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("SubjCode").ToString)
            x.SubItems.Add(dr("Description").ToString)
            x.SubItems.Add(dr("Units").ToString)
            x.SubItems.Add(dr("LastName").ToString & ", " & dr("FirstName").ToString & " " & dr("MiddleName").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub txtSection_TextChanged(sender As Object, e As EventArgs) Handles txtSection.TextChanged
        Call loadAccount()
        sql = "SELECT SUM(TuitionFee) AS TotalTuitionFee FROM qrySubjectList where SectionName='" & txtSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblTuitionFee.Text = dr("TotalTuitionFee").ToString()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtSearchBar.Text = ""
        txtStudentName.Text = ""
        txtSchoolYear.Text = ""
        txtCourse.Text = ""
        txtSemester.Text = ""
        txtYearLevel.Text = ""
        txtSection.Text = ""
    End Sub
End Class