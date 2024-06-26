﻿Imports System.Data.OleDb

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmMainLogin.Close()
    End Sub

    Private Sub chcboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chcboxShowPassword.CheckedChanged
        If chcboxShowPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        sql = "SELECT Role FROM qryUsers WHERE Username = '" & txtUsername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            lblRole.Text = dr("Role").ToString
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreateAccount.LinkClicked
        frmRegister.TopLevel = False
        frmMainLogin.Panel1.Controls.Add(frmRegister)
        frmRegister.BringToFront()
        frmRegister.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim filled As Boolean = True


        Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtUsername", txtUsername},
            {"txtPassword", txtPassword}
        }

        For Each fieldName_controlPair In requiredFields
            Dim control As Control = fieldName_controlPair.Value

            If control.Text.Trim = "" Then
                ErrorProvider1.SetError(control, "This field is required.")
                filled = False
                Exit For
            ElseIf control.Text.Trim = "Enter your username" Or control.Text.Trim = "Enter your password" Then
                ErrorProvider1.SetError(control, "Please enter a valid username or password.")
                filled = False
                Exit For
            Else
                ErrorProvider1.SetError(control, "")
            End If
        Next

        If filled Then
            sql = "Select Username, Password, Role from qryUsers where Username = '" & txtUsername.Text & "' and Password = '" & txtPassword.Text & "'"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                MsgBox("Account successfully logged in!", MsgBoxStyle.Information)

                frmDashboard.lblUsername.Text = txtUsername.Text
                frmDashboard.lblPos.Text = dr("Role").ToString
                Call byrole()
                frmDashboard.Show()
                Me.Hide()
                frmMainLogin.Hide()
            Else
                MsgBox("Account does not exist!", MsgBoxStyle.Critical)
            End If

        End If
    End Sub

    Private Sub byrole()
        If lblRole.Text = "Cashier" Then
            frmCashier.Enabled = True
            frmEnrollment.Enabled = False
            frmManageSections.Enabled = False
            frmManageStudents.Enabled = False
            frmClassScheduling.Enabled = False
            frmManageSubjects.Enabled = False
            frmManageTeachers.Enabled = False
            frmManageUsers.Enabled = False
        ElseIf lblRole.Text = "ITM" Then
            frmClassScheduling.Enabled = True
            frmCashier.Enabled = False
            frmManageSections.Enabled = False
            frmManageStudents.Enabled = False
            frmManageSubjects.Enabled = False
            frmManageTeachers.Enabled = False
            frmManageUsers.Enabled = False
            frmEnrollment.Enabled = False
        ElseIf lblRole.Text = "Registrar" Then
            frmClassScheduling.Enabled = False
            frmCashier.Enabled = False
            frmManageSections.Enabled = False
            frmManageStudents.Enabled = True
            frmManageSubjects.Enabled = False
            frmManageTeachers.Enabled = False
            frmManageUsers.Enabled = False
            frmEnrollment.Enabled = False
        ElseIf lblRole.Text = "Administrator" Then
            frmClassScheduling.Enabled = True
            frmCashier.Enabled = True
            frmManageSections.Enabled = True
            frmManageStudents.Enabled = True
            frmManageSubjects.Enabled = True
            frmManageTeachers.Enabled = True
            frmManageUsers.Enabled = True
            frmEnrollment.Enabled = True
        End If

    End Sub

End Class