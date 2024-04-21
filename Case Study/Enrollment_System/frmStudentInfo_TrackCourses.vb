Imports System.Data.OleDb

Public Class frmStudentInfo_TrackCourses
    Private Sub txtStudentNo_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNo.TextChanged
        sql = "Select StudentNo, LastName,FirstName,MiddleName,Address,Brgy,City,ContactNo,Bdate,Age,MotherName,MotherContactNo,FatherName,FatherContactNo,SchoolYear,Semester,Course,CourseDescription,Department,DeptDescription,YearLevel,Status from qryStudCourseDept where StudentNo ='" & txtStudentNo.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtStudentNo.Text = dr("StudentNo").ToString
            txtLastName.Text = dr("LastName").ToString
            txtFirstName.Text = dr("FirstName").ToString
            txtMiddleName.Text = dr("MiddleName").ToString
            txtAddress.Text = dr("Address").ToString
            cboBrgy.Text = dr("Brgy").ToString
            cboCity.Text = dr("City").ToString
            txtContactNo.Text = dr("ContactNo").ToString
            datePicker.Text = dr("Bdate").ToString
            txtAge.Text = dr("Age").ToString
            txtMotherName.Text = dr("MotherName").ToString
            txtMotherContactNo.Text = dr("MotherContactNo").ToString
            txtFatherName.Text = dr("FatherName").ToString
            txtFatherContactNo.Text = dr("FatherContactNo").ToString
            cboSY.Text = dr("SchoolYear").ToString
            cboSem.Text = dr("Semester").ToString
            cboC.Text = dr("Course").ToString
            cboCD.Text = dr("CourseDescription").ToString
            cboD.Text = dr("Department").ToString
            cboDD.Text = dr("DeptDescription").ToString
            cboY.Text = dr("YearLevel").ToString
            cboStatus.Text = dr("Status").ToString

        End If
    End Sub

    Private Sub btnEdit1_Click(sender As Object, e As EventArgs) Handles btnEdit1.Click
        btnEdit1.Enabled = True

        If txtStudentNo.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or
            txtMiddleName.Text = "" Or txtMotherContactNo.Text = "" Or txtMotherName.Text = "" Or
            txtAge.Text = "" Or cboSem.Text = "" Or cboSY.Text = "" Or
            cboStatus.Text = "" Or cboBrgy.Text = "" Or cboCity.Text = "" Or
            cboC.Text = "" Or cboD.Text = "" Or cboSY.Text = "" Or cboC.Text = "" Or
            cboY.Text = "" Or txtAddress.Text = "" Or txtFatherContactNo.Text = "" Or txtFatherName.Text = "" Or cboDD.Text = "" Or cboCD.Text = "" Then
            MsgBox("Please fill up the fields", MsgBoxStyle.Exclamation)
        Else

            Call edit()
        End If
    End Sub
    Private Sub edit()
        Dim convertedDate As DateTime = Convert.ToDateTime(datePicker.Text)
        sql = "UPDATE qryStudCourseDept SET StudentNo =@StudentNo,LastName=@LastName,FirstName=@FirstName,MiddleName=@MiddleName,Address=@Address,Brgy=@Brgy,City=@City,ContactNo=@ContactNo,Bdate=@Bdate,Age=@Age,MotherName=@MotherName,MotherContactNo=@MotherContactNo,FatherName=@FatherName,FatherContactNo=@FatherContactNo,SchoolYear=@SchoolYear,Semester=@Semester,Course=@Course,CourseDescription=@CourseDescription,Department=@Department,DeptDescription=@DeptDescription,YearLevel=@YearLevel,Status=@Status where StudentNo =@StudentNo"
        cmd = New OleDbCommand(sql, cn)
        cmd = New OleDbCommand(sql, cn)

        With cmd
            .Parameters.AddWithValue("@StudentNo", txtStudentNo.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
            .Parameters.AddWithValue("@Address", txtAddress.Text)
            .Parameters.AddWithValue("@Brgy", cboBrgy.Text)
            .Parameters.AddWithValue("@City", cboCity.Text)
            .Parameters.AddWithValue("@ContactNo", txtContactNo.Text)
            .Parameters.AddWithValue("@Bdate", convertedDate)
            .Parameters.AddWithValue("@Age", txtAge.Text)
            .Parameters.AddWithValue("@MotherName", txtMotherName.Text)
            .Parameters.AddWithValue("[@MotherContactNo]", txtMotherContactNo.Text)
            .Parameters.AddWithValue("@FatherName", txtFatherName.Text)
            .Parameters.AddWithValue("[@FatherContactNo]", txtFatherContactNo.Text)
            .Parameters.AddWithValue("@SchoolYear", cboSY.Text)
            .Parameters.AddWithValue("@SchoolYear", cboSem.Text)
            .Parameters.AddWithValue("@CourseDescription", cboCD.Text)
            .Parameters.AddWithValue("@Course", cboC.Text)
            .Parameters.AddWithValue("@YearLevel", cboY.Text)
            .Parameters.AddWithValue("@Status", cboStatus.Text)
            .Parameters.AddWithValue("@Department", cboD.Text)
            .Parameters.AddWithValue("@DeptDescription", cboDD.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Record Successfully Updated", MsgBoxStyle.Information)
        Call frmManageStudents.callLoadAccount()
    End Sub
    Private Sub frmStudentInfo_TrackCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class