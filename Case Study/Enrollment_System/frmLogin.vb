Imports System.Data.OleDb

Public Class frmLogin
    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Enter your username"
            txtUsername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Enter your username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Enter your password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Enter your password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "•"
            txtPassword.ForeColor = Color.Black
        End If
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
            sql = "Select Username, Password from tblUsers where Username = '" & txtUsername.Text & "' and Password = '" & txtPassword.Text & "'"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                MsgBox("Account successfully logged in!", MsgBoxStyle.Information)

                frmDashboard.lblUsername.Text = txtUsername.Text
                frmDashboard.Show()
                Me.Hide()
            Else
                MsgBox("Account does not exist!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
End Class