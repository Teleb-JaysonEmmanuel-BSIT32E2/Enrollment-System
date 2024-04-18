Imports System.Data.OleDb
Public Class frmClassScheduling
    Dim classNo As String
    Dim newSecId As String
    Dim newCourseId As String
    Dim newDeptId As String
    Dim newSYId As String
    Dim newSubId As String
    Dim newTeacherId As String

    Private Sub frmClassScheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSchedule()
        Call getSY()
        Call getCourse()
        Call getSectionName()
        Call getSem()
        Call getYearLevel()
        Call getCSNo()
        Call getTeacher()
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
            cboTeacher.Text = dr("FirstName").ToString & " " & dr("LastName").ToString
            cboGrade.Text = dr("YearLevel").ToString
            cboSem.Text = dr("Semester").ToString
            cboStrand.Text = dr("Department").ToString
            cboTrack.Text = dr("Course").ToString
            cboSY.Text = dr("SchoolYear").ToString
            cboTeacher.Text = dr("FirstName").ToString & " " & dr("LastName").ToString
            txtDescription.Text = dr("Description").ToString
            txtUnits.Text = dr("Units").ToString
        End If

        sql = "Select SubjType, Status from qrySubjects where SubjCode = '" & txtSubjCode.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            cboStatus.Text = dr("Status").ToString
            cboType.Text = dr("SubjType").ToString
        End If

        Call getCSNo()
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

    Private Sub getCSNo()
        sql = "SELECT DISTINCT ClassSchedNo from tblClassSchedule"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblClassNo.Text = dr("ClassSchedNo").ToString
        End If
        dr.Close()
    End Sub

    Private Sub getTeacher()
        sql = "SELECT DISTINCT FirstName, MiddleName, LastName from tblTeachers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboTeacher.Items.Clear()
        If dr.Read = True Then
            cboTeacher.Items.Add(dr("FirstName").ToString & " " & dr("MiddleName").ToString & " " & dr("LastName").ToString())
        End If
        dr.Close()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        cboStatus.Enabled = True
        cboType.Enabled = True
        cboGrade.Enabled = True
        cboSection.Enabled = True
        cboSem.Enabled = True
        cboStrand.Enabled = True
        cboSY.Enabled = True
        cboTeacher.Enabled = True
        cboTrack.Enabled = True
        ListView1.Enabled = True
        txtDescription.Enabled = True
        txtSubjCode.Enabled = True
        txtUnits.Enabled = True

        cboStatus.SelectedText = -1
        cboType.SelectedIndex = -1
        cboGrade.SelectedIndex = -1
        cboSection.SelectedIndex = -1
        cboSem.SelectedIndex = -1
        cboStrand.SelectedIndex = -1
        cboSY.SelectedIndex = -1
        cboTeacher.SelectedIndex = -1 'not working
        cboTrack.SelectedIndex = -1
        txtDescription.Clear()
        txtSubjCode.SelectedIndex = -1 'not working
        txtUnits.Clear()


        classNo = GetNextClassNo()
        lblClassNo.Text = classNo
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim filled As Boolean = True

        Dim requiredFields As New Dictionary(Of String, Control) From {
            {"cboType", cboType},
            {"cboStatus", cboStatus},
            {"cboGrade", cboGrade},
            {"cboSection", cboSection},
            {"cboSem", cboSem},
            {"cboStrand", cboStrand},
            {"cboSY", cboSY},
            {"cboTeacher", cboTeacher},
            {"cboTrack", cboTrack},
            {"txtDescription", txtDescription},
            {"txtSubjCode", txtSubjCode},
            {"txtUnits", txtUnits}
        }

        For Each fieldName_controlPair In requiredFields
            Dim control As Control = fieldName_controlPair.Value

            If control.Text.Trim = "" Then
                ErrorProvider1.SetError(control, "This field is required.")
                filled = False
                Exit For
            Else
                ErrorProvider1.SetError(control, "")
            End If
        Next


        If filled Then
            Call insertThings()

            sql = "Insert into tblClassSchedule(ClassSchedNo,YearLevel, SectionName, ClassAdviser, SYID, DeptID, CourseID) Values(@ClassSchedNo, @YearLevel, @SectionName, @ClassAdviser, @SYID, @DeptID, @CourseID)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@ClassSchedNo", classNo)
                .Parameters.AddWithValue("@YearLevel", cboGrade.Text)
                .Parameters.AddWithValue("@SectionName", cboSection.Text)
                .Parameters.AddWithValue("@ClassAdviser", cboTeacher.Text)
                .Parameters.AddWithValue("@SYID", newSYId)
                .Parameters.AddWithValue("@DeptID", newDeptId)
                .Parameters.AddWithValue("@CourseID", newCourseId)
                .ExecuteNonQuery()
            End With

            'sql = "Insert into tblSections(SYID, DeptID, CourseID, TeacherID) Values(@SYID, @DeptID, @CourseID, @TeacherID)"

            Call loadSchedule()
        End If

    End Sub

    Private Sub insertThings()
        Call insertCourse()
        Call insertDep()
        Call insertSectionYL()
        Call insertSY()
        Call insertSubjects()
    End Sub

    Private Function GetNextClassNo() As String
        Dim nextID As String = Nothing
        sql = "SELECT TOP 1 ClassSchedNo FROM tblClassSchedule ORDER BY ClassSchedNo DESC"
        cmd = New OleDbCommand(sql, cn)
        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            Dim lastEmployeeID As String = result.ToString()
            Dim lastNumber As Integer
            If Integer.TryParse(lastEmployeeID.Substring(4), lastNumber) Then
                nextID = "CS-" & (lastNumber + 1).ToString("D4")
            End If
        Else
            nextID = "CS-0001"
        End If
        Return nextID
    End Function

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

        newSecId = "SEC-" & idNumber.ToString("D4")

        sql = "INSERT INTO tblSections ([SectionID],[SectionName],[YearLevel]) VALUES ([@SectionID],[@SectionName],[@YearLevel])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("SectionID", newSecId)
            .Parameters.AddWithValue("SectionName", cboSection.Text)
            .Parameters.AddWithValue("YearLevel", cboGrade.Text)
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

        newSYId = "SY-" & idNumber.ToString("D4")

        sql = "Insert into tblSY ([SYID],[SchoolYear])values([@SYID],[@SchoolYear])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("SYID", newSYId)
            .Parameters.AddWithValue("SchoolYear", cboSY.Text)
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

        newDeptId = "DEPT-" & idNumber.ToString("D4")

        sql = "Insert into tblDept ([DeptID],[Department])values([@DeptID],[@Department])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("DeptID", newDeptId)
            .Parameters.AddWithValue("Department", cboStrand.Text)
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
        newCourseId = "CRS-" & idNumber.ToString("D4")

        ' Insert the new record
        sql = "INSERT INTO tblCourse (CourseID, Course) VALUES (@CourseID, @Course)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@CourseID", newCourseId)
            .Parameters.AddWithValue("@Course", cboTrack.Text)
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub insertSubjects()
        ' Retrieve the last CourseID from the database
        Dim lastId As String = ""
        sql = "SELECT TOP 1 SubjID FROM tblSubjects ORDER BY SubjID DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            lastId = dr("SubjID").ToString()
        Else
            lastId = "SUB-1000"
        End If

        ' Extract the numeric part of the CourseID and increment it
        Dim idNumber As Integer = Integer.Parse(lastId.Substring(4))
        idNumber += 1

        ' Create the new CourseID
        newSubId = "SUB-" & idNumber.ToString("D4")

        ' Insert the new record
        sql = "Insert into tblSubjects(SubjID, SubjCode, Description, Units, SubjType, Status) Values(@SubjID, @SubjCode, @Description, @Units, @SubjType, @Status)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("SubjID", newSubId)
            .Parameters.AddWithValue("SubjCode", txtSubjCode.Text)
            .Parameters.AddWithValue("Description", txtDescription.Text)
            .Parameters.AddWithValue("Units", txtUnits.Text)
            .Parameters.AddWithValue("SubjType", cboType.Text)
            .Parameters.AddWithValue("Status", cboStatus.Text)
            .ExecuteNonQuery()
        End With
    End Sub

End Class