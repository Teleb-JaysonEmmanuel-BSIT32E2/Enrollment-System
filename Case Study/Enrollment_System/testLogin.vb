Public Class testLogin
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        'IF THE USERNAME ARE NOT NULL THEN IT WILL DISPLAY THE INPUT BY USER
        If txtUsername.Text = "Enter your username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        'IF THE USERNAME ARE NULL THEN IT WILL DISPLAY THE DEFAULT VALUE
        If txtUsername.Text = "" Then
            txtUsername.Text = "Enter your username"
            txtUsername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        'IF THE PASSWORD ARE NOT NULL THEN IT WILL DISPLAY THE INPUT BY USER
        If txtPassword.Text = "Enter your password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "•"
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        'IF THE PASSWORD ARE NULL THEN IT WILL DISPLAY THE DEFAULT VALUE
        If txtPassword.Text = "" Then
            txtPassword.Text = "Enter your password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DEFAULT VALUE LOAD FORMS
        If txtPassword.Text = "" And txtUsername.Text = "" Then
            txtUsername.Text = "Enter your username"
            txtPassword.Text = "Enter your password"
            txtUsername.ForeColor = Color.DarkGray
            txtPassword.ForeColor = Color.DarkGray
        End If
    End Sub
End Class
