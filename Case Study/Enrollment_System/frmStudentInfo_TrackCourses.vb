Imports System.Data.OleDb

Public Class frmStudentInfo_TrackCourses
    Private Sub txtStudentNo_TextChanged(sender As Object, e As EventArgs) Handles txtAdmissionNumber.TextChanged
        sql = "Select AdmissionNo, LastName,FirstName,MiddleName,Address,Brgy,City,ContactNo,Bdate,Age,MotherName,MotherContactNo,FatherName,FatherContactNo from qryStudents where AdmissionNo ='" & txtAdmissionNumber.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtAdmissionNumber.Text = dr("AdmissionNo").ToString
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

        End If
    End Sub

    Public Sub studentNumber()
        sql = "SELECT AdmissionNo FROM tblStudents ORDER BY AdmissionNo DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtAdmissionNumber.Text = Val(dr(0)) + 1 & "-" & DateTime.Now.Year Mod 100
        Else
            txtAdmissionNumber.Text = 1000 & "-" & DateTime.Now.Year Mod 100
        End If
    End Sub

    Private Sub btnEdit1_Click(sender As Object, e As EventArgs) Handles btnEdit1.Click
        btnEdit1.Enabled = True

        If txtFirstName.Text = "" Or txtLastName.Text = "" Or
            txtMiddleName.Text = "" Or txtMotherContactNo.Text = "" Or txtMotherName.Text = "" Or
            txtAge.Text = "" Or cboBrgy.Text = "" Or cboCity.Text = "" Or
            txtAddress.Text = "" Or txtFatherContactNo.Text = "" Or txtFatherName.Text = "" Then
            MsgBox("Please fill up the fields", MsgBoxStyle.Exclamation)
        Else
            Call updateStudent()
        End If
        Me.Close()
    End Sub
    Private Sub updateStudent()
        Dim convertedDate As DateTime = Convert.ToDateTime(datePicker.Text)
        sql = "UPDATE tblStudents SET AdmissionNo=@AdmissionNo, LastName=@LastName,FirstName=@FirstName,MiddleName=@MiddleName, " &
        "Address=@Address,Brgy=@Brgy,City=@City,ContactNo=@ContactNo,Bdate=@Bdate,Age=@Age,MotherName=@MotherName," &
        "MotherContactNo=@MotherContactNo,FatherName=@FatherName,FatherContactNo=@FatherContactNo where AdmissionNo =@AdmissionNo"

        cmd = New OleDbCommand(sql, cn)

        With cmd
            .Parameters.AddWithValue("@AdmissionNo", txtAdmissionNumber.Text)
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
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Record Successfully Updated", MsgBoxStyle.Information)
        Call frmManageStudents.loadAccount()
    End Sub
    Private Sub frmStudentInfo_TrackCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmManageStudents.ListView1.SelectedItems.Count > 0 Then
            txtAdmissionNumber.Text = frmManageStudents.ListView1.SelectedItems(0).SubItems(0).Text
        Else
            Call studentNumber()
        End If
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class