Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class frmEnrollment
    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call callThings()
        Call studentNumber()
    End Sub

    Private Sub studentNumber()
        sql = "SELECT StudentNo FROM tblEnrolledStudent ORDER BY StudentNo DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblStudentNumber.Text = Val(dr(0)) + 1 & "-" & DateTime.Now.Year Mod 100
        Else
            lblStudentNumber.Text = 1000 & "-" & DateTime.Now.Year Mod 100
        End If
    End Sub

    Private Sub loadAccount()
        sql = "Select * from qrySubjectList WHERE SectionName = '" & cboSection.Text & "'"
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

    'Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
    '    If ListView1.SelectedItems.Count > 0 Then
    '        txtStudentID.Text = ListView1.SelectedItems(0).SubItems(0).Text
    '    End If
    'End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        Call searchThings()
        sql = "Select LastName,FirstName,MiddleName from tblStudents where AdmissionNo ='" & frmStudentInfo_TrackCourses.txtAdmissionNumber.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtLastName.Text = dr("LastName").ToString
            txtFirstName.Text = dr("FirstName").ToString
            txtMiddleName.Text = dr("MiddleName").ToString
        End If
    End Sub

    Private Sub searchThings()
        Dim dt As DataTable = SearchDatabase(txtStudentID.Text)
        PopulateListView(dt)
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select * from tblStudents where AdmissionNo LIKE ?"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.Add(New OleDbParameter("searchTerm1", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function

    Private Sub PopulateListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    Private Sub clear()
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtFirstName.Text = ""
        cboSection.Text = ""
        cboYearLevel.Text = ""
        cboSemester.Text = ""
        cboDepartment.Text = ""
        cboCourse.Text = ""
        txtStudentID.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clear()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call EnableThings()
    End Sub

    Private Sub EnableThings()
        txtMiddleName.Enabled = True
        txtLastName.Enabled = True
        txtFirstName.Enabled = True
        cboSection.Enabled = True
        cboYearLevel.Enabled = True
        cboSemester.Enabled = True
        cboDepartment.Enabled = True
        cboCourse.Enabled = True
        btnSave.Enabled = True
    End Sub


    Private studId As String
    Private Sub insertEnrolledStudent()
        Dim lastId As String = ""
        sql = "SELECT TOP 1 EStudentID FROM tblEnrolledStudent ORDER BY EStudentID DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            lastId = dr("EStudentID").ToString()
        Else
            lastId = "ESTUD-1000"
        End If

        Dim idNumber As Integer = Integer.Parse(lastId.Substring(6))
        idNumber += 1

        studId = "ESTUD-" & idNumber.ToString("D4")

        sql = "INSERT INTO tblEnrolledStudent (EStudentID, StudentNo, LastName, FirstName, MiddleName, Department, Course, YearLevel, Semester, SectionName, SchoolYear) VALUES (@EStudentID, @StudentNo, @LastName, @FirstName, @MiddleName, @Department, @Course, @YearLevel, @Semester, @SectionName, @SchoolYear)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@EStudentID", studId)
            .Parameters.AddWithValue("@StudentNo", txtStudentID.Text)
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
            .Parameters.AddWithValue("@Department", cboDepartment.Text)
            .Parameters.AddWithValue("@Course", cboCourse.Text)
            .Parameters.AddWithValue("@YearLevel", cboYearLevel.Text)
            .Parameters.AddWithValue("@Semester", cboSemester.Text)
            .Parameters.AddWithValue("@SectionName", cboSection.Text)
            .Parameters.AddWithValue("@SchoolYear", cboSchooYear.Text)
            .ExecuteNonQuery()
        End With
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtMiddleName.Text = "" Or txtLastName.Text = "" Or txtFirstName.Text = "" Or cboSection.Text = "" Or cboYearLevel.Text = "" Or cboSemester.Text = "" Or cboDepartment.Text = "" Or cboCourse.Text = "" Or cboSchooYear.Text = "" Then
            MsgBox("Please fill all the required fields.", MsgBoxStyle.Exclamation)
        Else
            Call checkStudentID()
        End If
    End Sub

    Private Sub checkStudentID()
        sql = "Select StudentNo from tblEnrolledStudent where StudentNo = '" & txtStudentID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            MsgBox("Student Number Exist", MsgBoxStyle.Exclamation)
        Else
            Call insertEnrolledStudent()
            Call loadAccount()
            MsgBox("Enrolled Student Record Inserted", MsgBoxStyle.Information)
            Call studentNumber()
        End If
    End Sub

    Private Sub callThings()
        Call getCourse()
        Call getDepartment()
        Call getSchoolYear()
        Call getSection()
    End Sub

    Private Sub getDepartment()
        sql = "SELECT DISTINCT Department FROM tblDept"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboDepartment.Items.Clear()
        While dr.Read = True
            cboDepartment.Items.Add(dr("Department").ToString())
        End While
        dr.Close()
    End Sub

    Private Sub getCourse()
        sql = "SELECT DISTINCT Course FROM tblCourse"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboCourse.Items.Clear()
        While dr.Read = True
            cboCourse.Items.Add(dr("Course").ToString())
        End While
        dr.Close()
    End Sub

    Private Sub getSection()
        sql = "SELECT DISTINCT SectionName FROM tblSections"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboSection.Items.Clear()
        While dr.Read = True
            cboSection.Items.Add(dr("SectionName").ToString())
        End While
        dr.Close()
    End Sub

    Private Sub getSchoolYear()
        sql = "SELECT DISTINCT SchoolYear FROM tblSY"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboSchooYear.Items.Clear()
        While dr.Read = True
            cboSchooYear.Items.Add(dr("SchoolYear").ToString())
        End While
        dr.Close()
    End Sub


    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        Call loadAccount()
        sql = "Select Department, Course, YearLevel, Semester, SchoolYear from qrySections WHERE SectionName = '" & cboSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            cboDepartment.Text = dr("Department").ToString
            cboCourse.Text = dr("Course").ToString
            cboYearLevel.Text = dr("YearLevel").ToString
            cboSemester.Text = dr("Semester").ToString
            cboSchooYear.Text = dr("SchoolYear").ToString
        End If
    End Sub

End Class