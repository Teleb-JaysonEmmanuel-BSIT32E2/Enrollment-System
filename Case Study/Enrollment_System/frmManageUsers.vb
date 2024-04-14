﻿Imports Guna.UI2.Native.WinApi
Imports System.Data.OleDb
Imports System.Drawing.Text
Imports System.Reflection

Public Class frmManageUsers
    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        If txtEmpNo.Text = "" Or txtLn.Text = "" Or txtFn.Text = "" Or txtP.Text = "" Or txtCp.Text = "" Or cboAS.Text = "" Or cboPos.Text = "" Or cboUl.Text = "" Then
            MsgBox("Please fill up the fields", MsgBoxStyle.Exclamation)
        Else
            Call save()
        End If
    End Sub

    Private Sub save()

        If txtP.Text <> txtCp.Text Then
            MsgBox("Passwords do not match!", MsgBoxStyle.Critical)
        Else
            sql = "Insert into tblUsers (EmployeeID, Username, [Password], AccessLevel, LastName, FirstName,[Position], AccStatus) Values (@EmployeeID, @Username, [@Password], @AccessLevel, @LastName, @FirstName, [@Position], @AccStatus)"
            cmd = New OleDbCommand(sql, cn)

            With cmd
                .Parameters.AddWithValue("@EmployeeID", txtEmpNo.Text)
                .Parameters.AddWithValue("@Username", txtUn.Text)
                .Parameters.AddWithValue("[@Password]", txtP.Text)
                .Parameters.AddWithValue("@AccessLevel", cboUl.Text)
                .Parameters.AddWithValue("@LastName", txtLn.Text)
                .Parameters.AddWithValue("@FirstName", txtFn.Text)
                .Parameters.AddWithValue("[@Position]", cboPos.Text)
                .Parameters.AddWithValue("@AccStatus", cboAS.Text)
                cmd.ExecuteNonQuery()

            End With

            MsgBox("Successfully Saved", MsgBoxStyle.Information)

        End If
        Call loadAccount()

    End Sub

    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadAccount()

    End Sub
    Private Sub loadAccount()
        sql = "Select * from qryUsers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("EmployeeID").ToString)
            x.SubItems.Add(dr("FirstName").ToString)
            x.SubItems.Add(dr("LastName").ToString)
            x.SubItems.Add(dr("Username").ToString)
            x.SubItems.Add(dr("Password").ToString)
            x.SubItems.Add(dr("AccessLevel").ToString)
            x.SubItems.Add(dr("Position").ToString)
            x.SubItems.Add(dr("AccStatus").ToString)



            ListView1.Items.Add(x)

        Loop

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If txtP.Text <> txtCp.Text Then
            MsgBox("Password Doesn't Match", MsgBoxStyle.Critical)
        Else
            Call UpdateData()
        End If

    End Sub
    Private Sub UpdateData()
        'Update Specific records from database'
        sql = "UPDATE qryUsers SET EmployeeID=@EmployeeID,LastName=@LastName,FirstName=@FirstName,Username=@Username,[Password]=[@Password],AccessLevel=@AccessLevel, [Position]=[@Position], AccStatus=@AccStatus where EmployeeID=@EmployeeID"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@EmployeeID", txtEmpNo.Text)
            .Parameters.AddWithValue("@LastName", txtLn.Text)
            .Parameters.AddWithValue("@FirstName", txtFn.Text)
            .Parameters.AddWithValue("@Username", txtUn.Text)
            .Parameters.AddWithValue("[@Password]", txtP.Text)
            .Parameters.AddWithValue("@AccessLevel", cboUl.Text)
            .Parameters.AddWithValue("[@Position]", cboPos.Text)
            .Parameters.AddWithValue("@AccStatus", cboAS.Text)
            .ExecuteNonQuery()

        End With
        MsgBox("Record Successfully Updated", MsgBoxStyle.Information)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtEmpNo.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim empId As Integer = 1001
        empId += 1
        txtEmpNo.Text = "EMP-" & empId.ToString()
    End Sub
    Private Sub reset()
        txtEmpNo.Text = ""
        txtLn.Text = ""
        txtFn.Text = ""
        txtP.Text = ""
        txtCp.Text = ""
        cboUl.Text = ""
        cboAS.Text = ""
        cboPos.Text = ""
    End Sub


    Private Sub checkAcc()
        sql = "Select EmployeeID from tblUsers where EmployeeID='" & txtEmpNo.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            MsgBox("Account is already Exist", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub txtEmpNo_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNo.TextChanged
        sql = "Select EmployeeID, FirstName, LastName, Username, [Password], AccessLevel,[Position],AccStatus from qryUsers where EmployeeID='" & txtEmpNo.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtEmpNo.Text = dr("EmployeeID").ToString
            txtFn.Text = dr("FirstName").ToString
            txtLn.Text = dr("LastName").ToString
            txtUn.Text = dr("Username").ToString
            txtP.Text = dr("Password").ToString
            cboUl.Text = dr("AccessLevel").ToString
            cboPos.Text = dr("Position").ToString
            cboAS.Text = dr("AccStatus").ToString
        End If
    End Sub

End Class