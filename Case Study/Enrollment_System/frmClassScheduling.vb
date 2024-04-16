Imports System.Data.OleDb
Public Class frmClassScheduling

    Private Sub frmClassScheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSchedule()
        Call getSY()
        Call getCourse()
        Call getSectionName()
        Call getSem()
        Call getYearLevel()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtSubjCode.Text = ListView1.SelectedItems(0).SubItems(6).Text
        End If
    End Sub

    Private Sub loadSchedule()
        sql = "Select * from qryClassSchedule"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("SectionName").ToString)
            x.SubItems.Add(dr("YearLevel").ToString)
            x.SubItems.Add(dr("SchoolYear").ToString)
            x.SubItems.Add(dr("Semester").ToString)
            x.SubItems.Add(dr("Department").ToString)
            x.SubItems.Add(dr("Course").ToString)
            x.SubItems.Add(dr("SubjCode").ToString)
            x.SubItems.Add(dr("Description").ToString)
            x.SubItems.Add(dr("Units").ToString)
            x.SubItems.Add(dr("SubjType").ToString)
            x.SubItems.Add(dr("LastName").ToString)
            x.SubItems.Add(dr("FirstName").ToString)

            ListView1.Items.Add(x)

        Loop

    End Sub



    Private Sub txtSubjCode_TextChanged(sender As Object, e As EventArgs) Handles txtSubjCode.TextChanged
        sql = "Select SectionName, YearLevel, SchoolYear, Semester, Department, Course, Description, Units, SubjType, LastName, FirstName from qryClassSchedule where SubjCode = '" & txtSubjCode.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            cboSection.Text = dr("SectionName").ToString
            cboClassAdviser.Text = dr("FirstName").ToString & " " & dr("LastName").ToString
            cboGrade.Text = dr("YearLevel").ToString
            cboSem.Text = dr("Semester").ToString
            cboStrand.Text = dr("Department").ToString
            cboTrack.Text = dr("Course").ToString
            cboSY.Text = dr("SchoolYear").ToString
            cboTeacher.Text = dr("FirstName").ToString & " " & dr("LastName").ToString
            txtDescription.Text = dr("Description").ToString
            txtUnits.Text = dr("Units").ToString
        End If
    End Sub

    Private Sub getSY()
        sql = "SELECT DISTINCT SchoolYear FROM tblSY"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboSY.Items.Clear()
        While dr.Read = True
            cboSY.Items.Add(dr("SchoolYear").ToString())
        End While
        dr.Close()
    End Sub
    Private Sub getCourse()
        sql = "SELECT DISTINCT Course FROM tblCourse"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboTrack.Items.Clear()
        While dr.Read = True
            cboTrack.Items.Add(dr("Course").ToString())
        End While
        dr.Close()

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        sql = "SELECT DISTINCT Department FROM tblDept"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboStrand.Items.Clear()
        While dr.Read = True
            cboStrand.Items.Add(dr("Department").ToString())
        End While
        dr.Close()
    End Sub
    Private Sub getSem()
        sql = "SELECT DISTINCT Semester FROM tblSY"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboSem.Items.Clear()
        While dr.Read = True
            cboSem.Items.Add(dr("Semester").ToString())
        End While
        dr.Close()
    End Sub
    Private Sub getYearLevel()
        sql = "SELECT DISTINCT YearLevel FROM tblSections"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboGrade.Items.Clear()
        While dr.Read = True
            cboGrade.Items.Add(dr("YearLevel").ToString())
        End While
        dr.Close()
    End Sub
    Private Sub getSectionName()
        sql = "SELECT DISTINCT SectionName FROM tblSections"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboSection.Items.Clear()
        While dr.Read = True
            cboSection.Items.Add(dr("SectionName").ToString())
        End While
        dr.Close()
    End Sub

End Class