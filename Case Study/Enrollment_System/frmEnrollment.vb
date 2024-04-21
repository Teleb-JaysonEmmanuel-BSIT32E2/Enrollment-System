Imports System.Data.OleDb

Public Class frmEnrollment
    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadAccount()
        Call callThings()
        Call studentNumber()
    End Sub

    Private Sub studentNumber()
        sql = "SELECT StudentNo FROM tblEnrolledStudent ORDER BY StudentNo DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblStudNumber.Text = Val(dr(0)) + 1 & " - " & DateTime.Now.Year Mod 100
        Else
            lblStudNumber.Text = 1000 & " - " & DateTime.Now.Year Mod 100
        End If
    End Sub

    Private Sub loadAccount()
        sql = "Select * from qryEnrollment"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("StudentNo").ToString)
            x.SubItems.Add(dr("LastName").ToString)
            x.SubItems.Add(dr("FirstName").ToString)
            x.SubItems.Add(dr("MiddleName").ToString)
            x.SubItems.Add(dr("StudentType").ToString)
            x.SubItems.Add(dr("Department").ToString)
            x.SubItems.Add(dr("Course").ToString)
            x.SubItems.Add(dr("YearLevel").ToString)
            x.SubItems.Add(dr("Semester").ToString)
            x.SubItems.Add(dr("SectionName").ToString)
            x.SubItems.Add(dr("SchoolYear").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtStudentID.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        Call searchThings()
        sql = "Select LastName,FirstName,MiddleName,StudentType,Department,Course,YearLevel,Semester,SectionName,SchoolYear from qryEnrollment where StudentNo ='" & txtStudentID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtLastName.Text = dr("LastName").ToString
            txtFirstName.Text = dr("FirstName").ToString
            txtMiddleName.Text = dr("MiddleName").ToString
            cboStudentType.Text = dr("StudentType").ToString
            cboDepartment.Text = dr("Department").ToString
            cboCourse.Text = dr("Course").ToString
            cboYearLevel.Text = dr("YearLevel").ToString
            cboSemester.Text = dr("Semester").ToString
            cboSection.Text = dr("SectionName").ToString
            cboSchooYear.Text = dr("SchoolYear").ToString
        End If
    End Sub

    Private Sub searchThings()
        Dim dt As DataTable = SearchDatabase(txtStudentID.Text)
        PopulateListView(dt)
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select * from qryEnrollment where StudentNo LIKE ?"
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

    Private Sub updateData()
        sql = "Update qryEnrollment set StudentNo=@StudentNo,LastName=@LastName,FirstName=@FirstName,MiddleName=@MiddleName,Status=@Status,SectionName=@SectionName,YearLevel=@YearLevel,Semester=@Semester,Department=@Department,Course=@Course where StudentNo=@StudentNo"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("StudentNo", txtStudentID.Text)
            .Parameters.AddWithValue("LastName", txtLastName.Text)
            .Parameters.AddWithValue("FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("MiddleName", txtMiddleName.Text)
            .Parameters.AddWithValue("Status", cboStudentType.Text)
            .Parameters.AddWithValue("@SectionName", cboSection.Text)
            .Parameters.AddWithValue("@YearLevel", cboYearLevel.Text)
            .Parameters.AddWithValue("@Semester", cboSemester.Text)
            .Parameters.AddWithValue("@Course", cboDepartment.Text)
            .Parameters.AddWithValue("@Department", cboCourse.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Enrollment Record Updated", MsgBoxStyle.Information)
        Call loadAccount()
    End Sub
    Private Sub clear()
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtFirstName.Text = ""
        cboStudentType.Text = ""
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
        cboStudentType.Enabled = True
        cboSection.Enabled = True
        cboYearLevel.Enabled = True
        cboSemester.Enabled = True
        cboDepartment.Enabled = True
        cboCourse.Enabled = True
        btnSave.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call updateData()
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
            lastId = "STUD-1000"
        End If

        Dim idNumber As Integer = Integer.Parse(lastId.Substring(5))
        idNumber += 1

        studId = "STUD-" & idNumber.ToString("D4")

        sql = "INSERT INTO tblEnrolledStudent (EStudentID, StudentNo, LastName, FirstName, MiddleName, StudentType, Department, Course, YearLevel, Semester, SectionName, SchoolYear) VALUES (@EStudentID, @StudentNo, @LastName, @FirstName, @MiddleName, @StudentType, @Department, @Course, @YearLevel, @Semester, @SectionName, @SchoolYear)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@EStudentID", studId)
            .Parameters.AddWithValue("@StudentNo", lblStudNumber.Text)
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
            .Parameters.AddWithValue("@StudentType", cboStudentType.Text)
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
        If txtMiddleName.Text = "" Or txtLastName.Text = "" Or txtFirstName.Text = "" Or cboStudentType.Text = "" Or cboSection.Text = "" Or cboYearLevel.Text = "" Or cboSemester.Text = "" Or cboDepartment.Text = "" Or cboCourse.Text = "" Or cboSchooYear.Text = "" Then
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

    Private Sub deleteSection()
        If txtStudentID.Text IsNot Nothing Then
            sql = "DELETE FROM tblEnrolledStudent WHERE StudentNo = @item"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@item", txtStudentID.Text)
                .ExecuteNonQuery()
            End With
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call deleteSection()
        Call loadAccount()
        Call clear()
        MsgBox("Record Deleted", MsgBoxStyle.Information)
        Call studentNumber()
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

End Class