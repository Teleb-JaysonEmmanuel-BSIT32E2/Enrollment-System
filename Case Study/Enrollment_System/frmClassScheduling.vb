Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader
Public Class frmClassScheduling
    Dim classNo As String
    Dim newCourseId As String
    Dim newDeptId As String
    Dim newSYId As String
    Dim newSubId As String
    Dim newTeacherId As String
    Dim classID As String
    Private Sub frmClassScheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call getSectionName()
        Call getCSNo()
        Call getTeacher()
        Call getSubjects()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            cboSection.Text = ListView1.SelectedItems(0).SubItems(1).Text
            classID = ListView1.SelectedItems(0).SubItems(0).Text
            Call getCSNo()
        End If
    End Sub

    Private Sub loadSchedule()
        sql = "Select * from qryClassSchedule WHERE SectionName = '" & cboSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            x = New ListViewItem(dr("SubjCode").ToString)
            x.SubItems.Add(dr("Course").ToString)
            x.SubItems.Add(dr("Units").ToString)
            x.SubItems.Add(dr("FirstName") & " " & dr("LastName").ToString)
            ListView1.Items.Add(x)
        Loop


    End Sub


    Private Sub getSubjects()
        sql = "SELECT DISTINCT SubjCode FROM tblSubjects"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        txtSubjCode.Items.Clear()
        While dr.Read = True
            txtSubjCode.Items.Add(dr("SubjCode").ToString())
        End While
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
        sql = "SELECT ClassSchedNo from tblClassSchedule WHERE SectionName = '" & cboSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblClassNo.Text = dr("ClassSchedNo").ToString
        End If
        dr.Close()
    End Sub

    Private Sub getTeacher()
        sql = "SELECT DISTINCT FirstName & ' ' & MiddleName & ' ' & LastName AS FullName FROM tblTeachers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboTeacher.Items.Clear()

        While dr.Read = True
            cboTeacher.Items.Add(dr("FullName").ToString())
        End While

        dr.Close()
    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cboStatus.Enabled = True
        cboSection.Enabled = True
        txtSubjCode.Enabled = True

        cboTeacher.Enabled = True
        ListView1.Enabled = True

        cboStatus.SelectedText = -1
        cboType.SelectedIndex = -1
        cboGrade.SelectedIndex = -1
        cboSection.SelectedIndex = -1
        cboSem.SelectedIndex = -1
        cboDept.SelectedIndex = -1
        cboSY.SelectedIndex = -1
        cboTeacher.SelectedIndex = -1 'not working
        cboCourse.SelectedIndex = -1
        txtDescription.Clear()
        txtSubjCode.SelectedIndex = -1 'not working
        txtUnits.Clear()


        classNo = GetNextClassNo()
        lblClassNo.Text = classNo
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Do you want to save?", vbYesNo) = vbYes Then
            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
                {"cboType", cboType},
                {"cboStatus", cboStatus},
                {"cboGrade", cboGrade},
                {"cboSection", cboSection},
                {"cboSem", cboSem},
                {"cboStrand", cboDept},
                {"cboSY", cboSY},
                {"cboTeacher", cboTeacher},
                {"cboTrack", cboCourse},
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
                sql = "SELECT SubjCode from tblClassSchedule WHERE SectionName = '" & cboSection.Text & "' and SUbjCode = '" & txtSubjCode.Text & "'"
                cmd = New OleDbCommand(sql, cn)
                dr = cmd.ExecuteReader

                If dr.Read = True Then
                    MsgBox("Subject is already in Section!", MsgBoxStyle.Critical)
                Else
                    sql = "Insert into tblClassSchedule(ClassSchedNo,YearLevel, SectionName, ClassAdviser, TeacherID, SubjCode, SYID, DeptID, CourseID) Values(@ClassSchedNo, @YearLevel, @SectionName, @ClassAdviser, @TeacherID, @SubjCode, @SYID, @DeptID, @CourseID)"
                    cmd = New OleDbCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@ClassSchedNo", lblClassNo.Text)
                        .Parameters.AddWithValue("@YearLevel", cboGrade.Text)
                        .Parameters.AddWithValue("@SectionName", cboSection.Text)
                        .Parameters.AddWithValue("@ClassAdviser", cboTeacher.Text)
                        .Parameters.AddWithValue("@TeacherID", newTeacherId)
                        .Parameters.AddWithValue("@SubjCode", txtSubjCode.Text)
                        .Parameters.AddWithValue("@SYID", newSYId)
                        .Parameters.AddWithValue("@DeptID", newDeptId)
                        .Parameters.AddWithValue("@CourseID", newCourseId)
                        .ExecuteNonQuery()
                    End With

                    MsgBox("Done!")
                    Call loadSchedule()
                End If
            End If
        End If
    End Sub

    Private Function GetNextClassNo() As String
        Dim nextID As String = Nothing
        sql = "SELECT TOP 1 ClassSchedNo FROM tblClassSchedule ORDER BY ClassSchedNo DESC"
        cmd = New OleDbCommand(sql, cn)
        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            Dim lastCSNo As String = result.ToString()
            Dim lastNumber As Integer
            If Integer.TryParse(lastCSNo.Substring(4), lastNumber) Then
                nextID = "CS-" & (lastNumber + 1).ToString("D4")
            End If
        Else
            nextID = "CS-0001"
        End If
        Return nextID
    End Function

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        Call clear()
        btnDelete.Enabled = True
        btnSave.Enabled = True
        sql = "SELECT tblSections.YearLevel, tblSY.SchoolYear, tblSY.Semester, tblCourse.Course, tblDept.Department " &
          "FROM ((tblSections " &
          "INNER JOIN tblSY ON tblSections.SYID = tblSY.SYID) " &
          "INNER JOIN tblDept ON tblSections.DeptID = tblDept.DeptID) " &
          "INNER JOIN tblCourse ON tblSections.CourseID = tblCourse.CourseID " &
          "WHERE SectionName = '" & cboSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            cboSY.Text = dr("SchoolYear").ToString
            cboSem.Text = dr("Semester").ToString
            cboGrade.Text = dr("YearLevel").ToString
            cboCourse.Text = dr("Course").ToString
            cboDept.Text = dr("Department").ToString
        End If

        Call loadSchedule()
        Call getCSNo()
        Call getCrsID()
        Call getDeptId()
        Call getSYID()
    End Sub

    Private Sub txtSubjCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSubjCode.SelectedIndexChanged
        sql = "SELECT Description, Units, SubjType, Status FROM tblSubjects WHERE SubjCode = '" & txtSubjCode.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            txtUnits.Text = dr("Units").ToString
            cboType.Text = dr("SubjType").ToString
            txtDescription.Text = dr("Description").ToString
            cboStatus.Text = dr("Status").ToString
        End If
    End Sub

    Private Sub cboTeacher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeacher.SelectedIndexChanged
        Dim nameParts As String() = cboTeacher.Text.Split(" ")

        Dim firstName As String = ""
        Dim middleName As String = ""

        If UBound(nameParts) = 2 Then 'if name is only three
            firstName = nameParts(0)
            middleName = nameParts(1)
        ElseIf UBound(nameParts) > 2 Then ' if name is more than three
            firstName = nameParts(0) & " " & nameParts(1)
            middleName = nameParts(2)
        End If

        Dim lastName As String = nameParts(UBound(nameParts))


        sql = "SELECT TeacherID FROM tblTeachers WHERE FirstName = '" & firstName & "' and MiddleName = '" & middleName & "' and LastName = '" & lastName & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            newTeacherId = dr("TeacherID")
        End If
    End Sub

    Private Sub getCrsID()
        sql = "SELECT CourseID from tblCourse WHERE Course = '" & cboCourse.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            newCourseId = dr("CourseID")
        End If
    End Sub

    Private Sub getDeptId()
        sql = "SELECT DeptID from tblDept WHERE Department = '" & cboDept.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            newDeptId = dr("DeptID")
        End If
    End Sub

    Private Sub getSYID()
        sql = "SELECT SYID from tblSY WHERE SchoolYear = '" & cboSY.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            newSYId = dr("SYID")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListView1.SelectedItems.Count > 0 Then
            If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                sql = "DELETE FROM tblClassSchedule WHERE SubjCode = @item and SectionName = '" & cboSection.Text & "'"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@item", classID)
                    .ExecuteNonQuery()
                End With
                MsgBox("Deleted!")
                Call loadSchedule()
            End If
        Else
            MsgBox("Please select an item to delete!", vbExclamation)
        End If

    End Sub

    Private Sub clear()
        cboTeacher.SelectedIndex = -1
        txtSubjCode.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        cboType.SelectedIndex = -1

        txtUnits.Clear()
        txtDescription.Clear()
    End Sub
End Class