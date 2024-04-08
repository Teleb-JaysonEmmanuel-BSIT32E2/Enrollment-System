Public Class frmRegister
    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub checkboxShowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxShowpassword.CheckedChanged
        If checkboxShowpassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub chckboxActive_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxActive.CheckedChanged
        If chckboxActive.Checked = True Then
            lblActive.ForeColor = Color.Green
        Else
            lblActive.ForeColor = Color.DarkGray
        End If
    End Sub
End Class