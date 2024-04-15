<<<<<<< Updated upstream
﻿Imports Guna.UI2.Native.WinApi
Imports System.Data.OleDb
Imports System.Drawing.Text
Imports System.Reflection

Public Class frmManageUsers
    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs)
=======
﻿Imports System.Data.OleDb
Imports Guna.UI2.Native.WinApi
>>>>>>> Stashed changes

Public Class frmManageUsers
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtEmpNo.Text = "" Or 'Employee No
            txtLastName.Text = "" Or 'LastName
            txtFirstName.Text = "" Or 'FirstName
            txtUsername.Text = "" Or 'Username
            txtPassword.Text = "" Or 'Password
            txtConfirmPass.Text = "" Or 'Confirm Password
            cboAccStatus.Text = "" Or 'Account Status
            cboRole.Text = "" Then 'Role
            MsgBox("Please fill up the fields completely!", MsgBoxStyle.Exclamation)
        Else
            Call Save()
        End If
    End Sub

    Private Sub Save()
        If txtPassword.Text <> txtConfirmPass.Text Then
            MsgBox("Passwords do not match!", MsgBoxStyle.Critical)
        Else
            sql = "Insert into tblUsers (EmployeeID, Username, [Password], AccessLevel, LastName, FirstName,[Position], AccStatus) Values (@EmployeeID, @Username, [@Password], @AccessLevel, @LastName, @FirstName, [@Position], @AccStatus)"
            cmd = New OleDbCommand(sql, cn)

            With cmd
                .Parameters.AddWithValue("@EmployeeID", txtEmpNo.Text)
                .Parameters.AddWithValue("@Username", txtUsername.Text)
                .Parameters.AddWithValue("[@Password]", txtPassword.Text)
                '.Parameters.AddWithValue("@AccessLevel", cboUl.Text) 
                .Parameters.AddWithValue("@LastName", txtLastName.Text)
                .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                .Parameters.AddWithValue("[@Position]", cboRole.Text) 'change to Role from cboPosition
                .Parameters.AddWithValue("@AccStatus", cboAccStatus.Text)
                cmd.ExecuteNonQuery()

            End With
            MsgBox("Successfully Saved", MsgBoxStyle.Information) 'Save Account

        End If
        Call LoadAccount()
    End Sub

    Private Sub LoadAccount()
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

    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call LoadAccount()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtEmpNo.Text = "" Or 'Employee No
            txtLastName.Text = "" Or 'LastName
            txtFirstName.Text = "" Or 'FirstName
            txtUsername.Text = "" Or 'UserName
            txtPassword.Text = "" Or 'Password
            txtConfirmPass.Text = "" Or 'Confirm Password
            cboAccStatus.Text = "" Or 'Account Status
            cboRole.Text = "" Then 'Role
            MsgBox("Please fill up the fields completely!", MsgBoxStyle.Exclamation)
        ElseIf txtPassword.Text <> txtConfirmPass.Text Then
            MsgBox("Password Doesn't Match", MsgBoxStyle.Critical)
        Else
            Call UpdateData()
        End If
        Call LoadAccount()
        Call Reset()
    End Sub

    Private Sub UpdateData()
        'Update Specific records from database'
        sql = "UPDATE qryUsers SET EmployeeID=@EmployeeID,LastName=@LastName,FirstName=@FirstName,Username=@Username,[Password]=[@Password],AccessLevel=@AccessLevel, [Position]=[@Position], AccStatus=@AccStatus where EmployeeID=@EmployeeID"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@EmployeeID", txtEmpNo.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@Username", txtUsername.Text)
            .Parameters.AddWithValue("[@Password]", txtPassword.Text)
            '.Parameters.AddWithValue("@AccessLevel", cboUl.Text)
            .Parameters.AddWithValue("[@Position]", cboRole.Text)
            .Parameters.AddWithValue("@AccStatus", cboAccStatus.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Record Successfully Updated", MsgBoxStyle.Information)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtEmpNo.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub Reset()
        txtEmpNo.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtPassword.Clear()
        txtConfirmPass.Clear()
        'cboUl.SelectedIndex = -1
        cboAccStatus.SelectedIndex = -1
        cboRole.SelectedIndex = -1
    End Sub


    Private Sub CheckAcc()
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
            txtFirstName.Text = dr("FirstName").ToString
            txtLastName.Text = dr("LastName").ToString
            txtUsername.Text = dr("Username").ToString
            txtPassword.Text = dr("Password").ToString
            'cboUl.Text = dr("AccessLevel").ToString
            cboRole.Text = dr("Position").ToString
            cboAccStatus.Text = dr("AccStatus").ToString
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMonitorDashboard.Show()
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
            sql = "Insert into tblUsers (EmployeeID, Username, [Password], LastName, FirstName, AccStatus) Values (@EmployeeID, @Username, [@Password], @LastName, @FirstName, @AccStatus)"
            cmd = New OleDbCommand(sql, cn)

            With cmd
                .Parameters.AddWithValue("@EmployeeID", txtEmpNo.Text)
                .Parameters.AddWithValue("@Username", txtUn.Text)
                .Parameters.AddWithValue("[@Password]", txtP.Text)
                .Parameters.AddWithValue("@LastName", txtLn.Text)
                .Parameters.AddWithValue("@FirstName", txtFn.Text)
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
            x.SubItems.Add(dr("AccStatus").ToString)



            ListView1.Items.Add(x)

        Loop

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If txtEmpNo.Text = "" Or txtLn.Text = "" Or txtFn.Text = "" Or txtP.Text = "" Or txtCp.Text = "" Or cboAS.Text = "" Or cboPos.Text = "" Or cboUl.Text = "" Then
            MsgBox("Please fill up the fields", MsgBoxStyle.Exclamation)
        ElseIf txtP.Text <> txtCp.Text Then
            MsgBox("Password Doesn't Match", MsgBoxStyle.Critical)
        Else
            Call UpdateData()

        End If
        Call loadAccount()
        Call reset()
    End Sub
    Private Sub UpdateData()
        'Update Specific records from database'
        sql = "UPDATE qryUsers SET EmployeeID=@EmployeeID,LastName=@LastName,FirstName=@FirstName,Username=@Username,[Password]=[@Password], AccStatus=@AccStatus where EmployeeID=@EmployeeID"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@EmployeeID", txtEmpNo.Text)
            .Parameters.AddWithValue("@LastName", txtLn.Text)
            .Parameters.AddWithValue("@FirstName", txtFn.Text)
            .Parameters.AddWithValue("@Username", txtUn.Text)
            .Parameters.AddWithValue("[@Password]", txtP.Text)
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


    Private Sub reset()
        txtEmpNo.Clear()
        txtLn.Clear()
        txtFn.Clear()
        txtP.Clear()
        txtCp.Clear()
        cboUl.SelectedIndex = -1
        cboAS.SelectedIndex = -1
        cboPos.SelectedIndex = -1
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
        sql = "Select EmployeeID, FirstName, LastName, Username, [Password],AccStatus from qryUsers where EmployeeID='" & txtEmpNo.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtEmpNo.Text = dr("EmployeeID").ToString
            txtFn.Text = dr("FirstName").ToString
            txtLn.Text = dr("LastName").ToString
            txtUn.Text = dr("Username").ToString
            txtP.Text = dr("Password").ToString
            cboAS.Text = dr("AccStatus").ToString
        End If
    End Sub


End Class