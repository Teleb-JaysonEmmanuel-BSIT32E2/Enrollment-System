Imports System.Data.OleDb

Public Class frmMonitorDashboard
    Private Sub frmMonitorDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call callUpdate()
    End Sub

    Private Sub updateNumberStudent()
        sql = "SELECT COUNT(*) FROM tblEnrolledStudent"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Dim numItems As Integer = dr.GetInt32(0)
            ' Update the label text.
            lblNumberStudent.Text = numItems.ToString()
        End If
    End Sub

    Private Sub updateNumberUsers()
        sql = "SELECT COUNT(*) FROM tblUsers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Dim numItems As Integer = dr.GetInt32(0)
            ' Update the label text.
            lblNumberUser.Text = numItems.ToString()
        End If
    End Sub

    Private Sub updateNumberSubjects()
        sql = "SELECT COUNT(*) FROM tblSubjects"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Dim numItems As Integer = dr.GetInt32(0)
            ' Update the label text.
            lblNumberSubject.Text = numItems.ToString()
        End If
    End Sub

    Private Sub updateActiveYear()
        sql = "SELECT TOP 1 SchoolYear,Semester FROM tblSY ORDER BY SYID DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblAcademicYear.Text = dr.GetString(0)
            lblSemester.Text = dr.GetString(1)
        End If
    End Sub


    Private Sub callUpdate()
        Call updateNumberStudent()
        Call updateNumberUsers()
        Call updateNumberSubjects()
        Call updateActiveYear()
    End Sub
End Class