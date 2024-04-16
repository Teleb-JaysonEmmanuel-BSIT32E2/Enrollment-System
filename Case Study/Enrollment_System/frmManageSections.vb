Imports System.Data.OleDb
Imports System.Drawing.Text
Imports System.Linq.Expressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmManageSections

    Private Sub frmManageSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadAccount()
        Call callThings()

    End Sub

    Private Sub loadAccount()
        sql = "Select * from qrySections"
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
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            cboSection.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub txtSection_TextChanged(sender As Object, e As EventArgs) Handles cboSection.TextChanged
        sql = "Select YearLevel,SchoolYear,Semester,Department,Course from qrySections where SectionName='" & cboSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            cboYearLevel.Text = dr("YearLevel").ToString
            cboSchoolYear.Text = dr("SchoolYear").ToString
            cboSemester.Text = dr("Semester").ToString
            cboDepartment.Text = dr("Department").ToString
            cboCourse.Text = dr("Course").ToString
        End If
    End Sub

    Private Sub updateData()
        sql = "Update qrySections set SectionName=@SectionName,YearLevel=@YearLevel,SchoolYear=@SchoolYear,Semester=@Semester,Department=@Department,Course=@Course where SectionName=@SectionName"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@SectionName", cboSection.Text)
            .Parameters.AddWithValue("@YearLevel", cboYearLevel.Text)
            .Parameters.AddWithValue("@SchoolYear", cboSchoolYear.Text)
            .Parameters.AddWithValue("@Semester", cboSemester.Text)
            .Parameters.AddWithValue("@Course", cboDepartment.Text)
            .Parameters.AddWithValue("@Department", cboCourse.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Section Record Updated", MsgBoxStyle.Information)
        Call loadAccount()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call updateData()
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

    Private Sub getYearLevel()
        sql = "SELECT DISTINCT YearLevel FROM tblSections"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboYearLevel.Items.Clear()
        While dr.Read = True
            cboYearLevel.Items.Add(dr("YearLevel").ToString())
        End While
        dr.Close()
    End Sub

    Private Sub getSchoolYear()
        sql = "SELECT DISTINCT SchoolYear FROM tblSY"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboSchoolYear.Items.Clear()
        While dr.Read = True
            cboSchoolYear.Items.Add(dr("SchoolYear").ToString())
        End While
        dr.Close()
    End Sub

    Private Sub getSemester()
        sql = "SELECT DISTINCT Semester FROM tblSY"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboSemester.Items.Clear()
        While dr.Read = True
            cboSemester.Items.Add(dr("Semester").ToString())
        End While
        dr.Close()
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

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call EnableThings()
    End Sub

    Private Sub EnableThings()
        cboSection.Enabled = True
        cboYearLevel.Enabled = True
        cboSchoolYear.Enabled = True
        cboSemester.Enabled = True
        cboDepartment.Enabled = True
        cboCourse.Enabled = True
        btnSave.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private syId As String
    Private deptId As String
    Private courseId As String

    Private Sub insertSectionYL()
        Dim lastId As String = ""
        sql = "SELECT TOP 1 SectionID FROM tblSections ORDER BY SectionID DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            lastId = dr("SectionID").ToString()
        Else
            lastId = "SEC-1000"
        End If

        Dim idNumber As Integer = Integer.Parse(lastId.Substring(4))
        idNumber += 1

        Dim secId As String = "SEC-" & idNumber.ToString("D4")

        sql = "INSERT INTO tblSections ([SectionID],[SectionName],[YearLevel],[SYID],[DeptID],[CourseID]) VALUES ([@SectionID],[@SectionName],[@YearLevel],[@SYID],[@DeptID],[@CourseID])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("SectionID", secId)
            .Parameters.AddWithValue("SectionName", cboSection.Text)
            .Parameters.AddWithValue("YearLevel", cboYearLevel.Text)
            .Parameters.AddWithValue("SYID", syId)
            .Parameters.AddWithValue("DeptID", deptId)
            .Parameters.AddWithValue("CourseID", courseId)
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub insertSY()
        Dim lastId As String = ""
        sql = "SELECT TOP 1 SYID FROM tblSY ORDER BY SYID DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            lastId = dr("SYID").ToString()
        Else
            lastId = "SY-1000"
        End If

        Dim idNumber As Integer = Integer.Parse(lastId.Substring(3))
        idNumber += 1

        syId = "SY-" & idNumber.ToString("D4")

        sql = "Insert into tblSY ([SYID],[SchoolYear],[Semester])values([@SYID],[@SchoolYear],[@Semester])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("SYID", syId)
            .Parameters.AddWithValue("SchoolYear", cboSchoolYear.Text)
            .Parameters.AddWithValue("Semester", cboSemester.Text)
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub insertDep()
        Dim lastId As String = ""
        sql = "SELECT TOP 1 DeptID FROM tblDept ORDER BY DeptID DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            lastId = dr("DeptID").ToString()
        Else
            lastId = "DEPT-1000"
        End If

        Dim idNumber As Integer = Integer.Parse(lastId.Substring(5))
        idNumber += 1

        deptId = "DEPT-" & idNumber.ToString("D4")

        sql = "Insert into tblDept ([DeptID],[Department])values([@DeptID],[@Department])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("DeptID", deptId)
            .Parameters.AddWithValue("Department", cboDepartment.Text)
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub insertCourse()
        ' Retrieve the last CourseID from the database
        Dim lastId As String = ""
        sql = "SELECT TOP 1 CourseID FROM tblCourse ORDER BY CourseID DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            lastId = dr("CourseID").ToString()
        Else
            lastId = "CRS-1000"
        End If

        ' Extract the numeric part of the CourseID and increment it
        Dim idNumber As Integer = Integer.Parse(lastId.Substring(4))
        idNumber += 1

        ' Create the new CourseID
        courseId = "CRS-" & idNumber.ToString("D4")

        ' Insert the new record
        sql = "INSERT INTO tblCourse (CourseID, Course) VALUES (@CourseID, @Course)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@CourseID", courseId)
            .Parameters.AddWithValue("@Course", cboCourse.Text)
            .ExecuteNonQuery()
        End With
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboSection.Text = "" Or cboYearLevel.Text = "" Or cboSchoolYear.Text = "" Or cboSemester.Text = "" Or cboDepartment.Text = "" Or cboCourse.Text = "" Then
            MsgBox("Please fill all the fields", MsgBoxStyle.Exclamation)
        Else
            Call insertThings()
            Call callThings()
            Call loadAccount()
            MsgBox("Record Inserted", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub callThings()
        Call getSection()
        Call getDepartment()
        Call getYearLevel()
        Call getSchoolYear()
        Call getSemester()
        Call getCourse()
    End Sub

    Private Sub insertThings()
        Call insertSY()
        Call insertDep()
        Call insertCourse()
        Call insertSectionYL()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clear()
    End Sub

    Private Sub clear()
        cboSection.Text = ""
        cboYearLevel.Text = ""
        cboSchoolYear.Text = ""
        cboSemester.Text = ""
        cboDepartment.Text = ""
        cboCourse.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call deleteThings()
        Call callThings()
        Call clear()
        Call loadAccount()
        MsgBox("Record Deleted", MsgBoxStyle.Information)
    End Sub

    Private Sub deleteThings()
        Call deleteSection()
    End Sub

    Private Sub deleteSection()
        If cboSection.Text IsNot Nothing Then
            sql = "DELETE FROM tblSections WHERE SectionName = @item"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@item", cboSection.Text)
                .ExecuteNonQuery()
            End With
        End If
    End Sub

End Class