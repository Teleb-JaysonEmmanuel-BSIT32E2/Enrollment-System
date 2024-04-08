Public Class frmLogin
    Private Sub frmLoginConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtPassword.Text = "" And txtUsername.Text = "" Then
            txtUsername.Text = "Enter your username"
            txtPassword.Text = "Enter your password"
            txtUsername.ForeColor = Color.DarkGray
            txtPassword.ForeColor = Color.DarkGray
        End If
    End Sub

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

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreateAccount.LinkClicked
        frmRegister.TopLevel = False
        frmMainLogin.Panel1.Controls.Add(frmRegister)
        frmRegister.BringToFront()
        frmRegister.Show()
    End Sub
End Class