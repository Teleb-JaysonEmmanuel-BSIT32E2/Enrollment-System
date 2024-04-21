Imports System.Data.OleDb

Public Class frmManageStudents
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmStudentInfo_TrackCourses.Show()
        Me.TopMost = True
        'frmStudentInfo_TrackCourses.TopLevel = False
        'Panel1.Controls.Add(frmStudentInfo_TrackCourses)
        'frmStudentInfo_TrackCourses.BringToFront()
        'frmStudentInfo_TrackCourses.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmStudentInfo_TrackCourses.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmStudentInfo_TrackCourses.btnEdit1.Enabled = False
        If frmStudentInfo_TrackCourses.txtStudentNo.Text = "" Or frmStudentInfo_TrackCourses.txtFirstName.Text = "" Or frmStudentInfo_TrackCourses.txtLastName.Text = "" Or
            frmStudentInfo_TrackCourses.txtMiddleName.Text = "" Or frmStudentInfo_TrackCourses.txtMotherContactNo.Text = "" Or frmStudentInfo_TrackCourses.txtMotherName.Text = "" Or
            frmStudentInfo_TrackCourses.txtAge.Text = "" Or frmStudentInfo_TrackCourses.cboSem.Text = "" Or frmStudentInfo_TrackCourses.cboSY.Text = "" Or
            frmStudentInfo_TrackCourses.cboStatus.Text = "" Or frmStudentInfo_TrackCourses.cboBrgy.Text = "" Or frmStudentInfo_TrackCourses.cboCity.Text = "" Or
            frmStudentInfo_TrackCourses.cboC.Text = "" Or frmStudentInfo_TrackCourses.cboD.Text = "" Or frmStudentInfo_TrackCourses.cboSY.Text = "" Or frmStudentInfo_TrackCourses.cboC.Text = "" Or
            frmStudentInfo_TrackCourses.cboY.Text = "" Or frmStudentInfo_TrackCourses.txtAddress.Text = "" Or frmStudentInfo_TrackCourses.txtFatherContactNo.Text = "" Or frmStudentInfo_TrackCourses.txtFatherName.Text = "" Or frmStudentInfo_TrackCourses.cboDD.Text = "" Or frmStudentInfo_TrackCourses.cboCD.Text = "" Then
            MsgBox("Please fill up the fields", MsgBoxStyle.Exclamation)
        Else

            Call save()
        End If

    End Sub
    Private Sub save()
        Dim convertedDate As DateTime = Convert.ToDateTime(frmStudentInfo_TrackCourses.datePicker.Text)
        sql = "Insert into tblStudents (StudentNo,LastName,FirstName,MiddleName,Address,Brgy,City,ContactNo,Bdate,Age,MotherName,MotherContactNo,FatherName,FatherContactNo)Values
                (@StudentNo,@LastName,@FirstName,@MiddleName,@Address,@Brgy,@City,@ContactNo,@Bdate,@Age,@MotherName,@MotherContactNo,@FatherName,@FatherContactNo)"
        cmd = New OleDbCommand(sql, cn)

        With cmd
            .Parameters.AddWithValue("@StudentNo", frmStudentInfo_TrackCourses.txtStudentNo.Text)
            .Parameters.AddWithValue("@LastName", frmStudentInfo_TrackCourses.txtLastName.Text)
            .Parameters.AddWithValue("@FirstName", frmStudentInfo_TrackCourses.txtFirstName.Text)
            .Parameters.AddWithValue("@MiddleName", frmStudentInfo_TrackCourses.txtMiddleName.Text)
            .Parameters.AddWithValue("@Address", frmStudentInfo_TrackCourses.txtAddress.Text)
            .Parameters.AddWithValue("@Brgy", frmStudentInfo_TrackCourses.cboBrgy.Text)
            .Parameters.AddWithValue("@City", frmStudentInfo_TrackCourses.cboCity.Text)
            .Parameters.AddWithValue("@ContactNo", frmStudentInfo_TrackCourses.txtContactNo.Text)
            .Parameters.AddWithValue("@Bdate", convertedDate)
            .Parameters.AddWithValue("@Age", frmStudentInfo_TrackCourses.txtAge.Text)
            .Parameters.AddWithValue("@MotherName", frmStudentInfo_TrackCourses.txtMotherName.Text)
            .Parameters.AddWithValue("[@MotherContactNo]", frmStudentInfo_TrackCourses.txtMotherContactNo.Text)
            .Parameters.AddWithValue("@FatherName", frmStudentInfo_TrackCourses.txtFatherName.Text)
            .Parameters.AddWithValue("[@FatherContactNo]", frmStudentInfo_TrackCourses.txtFatherContactNo.Text)

            cmd.ExecuteNonQuery()

        End With

        Call course()


    End Sub
    Private Sub course()
        sql = "Insert into tblCourse (SchoolYear,Semester,CourseDescription,Course,YearLevel,Status)Values(@SchoolYear,@Semester,@CourseDescription,@Course,@YearLevel,@Status)"
        cmd = New OleDbCommand(sql, cn)

        With cmd
            .Parameters.AddWithValue("@SchoolYear", frmStudentInfo_TrackCourses.cboSY.Text)
            .Parameters.AddWithValue("@SchoolYear", frmStudentInfo_TrackCourses.cboSem.Text)
            .Parameters.AddWithValue("@CourseDescription", frmStudentInfo_TrackCourses.cboCD.Text)
            .Parameters.AddWithValue("@Course", frmStudentInfo_TrackCourses.cboC.Text)
            .Parameters.AddWithValue("@YearLevel", frmStudentInfo_TrackCourses.cboY.Text)
            .Parameters.AddWithValue("@Status", frmStudentInfo_TrackCourses.cboStatus.Text)
            cmd.ExecuteNonQuery()
        End With

        Call dept()
    End Sub

    Private Sub dept()
        sql = "Insert into tblDept (Department,DeptDescription)Values(@Department,@DeptDescription)"
        cmd = New OleDbCommand(sql, cn)

        With cmd

            .Parameters.AddWithValue("@Department", frmStudentInfo_TrackCourses.cboD.Text)
            .Parameters.AddWithValue("@DeptDescription", frmStudentInfo_TrackCourses.cboDD.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Successfully Saved", MsgBoxStyle.Information)
        Call loadAccount()
    End Sub
    Private Sub loadAccount()
        sql = "Select * from qryStudCourseDept"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("StudentNo").ToString)
            x.SubItems.Add(dr("LastName").ToString & " " & dr("FirstName").ToString & " " & dr("MiddleName"))
            x.SubItems.Add(dr("Address").ToString)
            x.SubItems.Add(dr("Brgy").ToString)
            x.SubItems.Add(dr("City").ToString)
            x.SubItems.Add(dr("ContactNo").ToString)
            x.SubItems.Add(dr("Bdate").ToString)
            x.SubItems.Add(dr("Age").ToString)
            x.SubItems.Add(dr("MotherName").ToString)
            x.SubItems.Add(dr("MotherContactNo").ToString)
            x.SubItems.Add(dr("FatherName").ToString)
            x.SubItems.Add(dr("FatherContactNo").ToString)
            x.SubItems.Add(dr("SchoolYear").ToString)
            x.SubItems.Add(dr("Semester").ToString)
            x.SubItems.Add(dr("Course").ToString)
            x.SubItems.Add(dr("CourseDescription").ToString)
            x.SubItems.Add(dr("Department").ToString)
            x.SubItems.Add(dr("DeptDescription").ToString)
            x.SubItems.Add(dr("YearLevel").ToString)
            x.SubItems.Add(dr("Status").ToString)
            ListView1.Items.Add(x)
        Loop


    End Sub

    Private Sub frmManageStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadAccount()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            frmStudentInfo_TrackCourses.txtStudentNo.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmStudentInfo_TrackCourses.Show()
        Me.TopMost = True
    End Sub


End Class