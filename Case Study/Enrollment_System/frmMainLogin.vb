Public Class frmMainLogin

    Private Sub frmLoginV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        frmLogin.TopLevel = False
        Panel1.Controls.Add(frmLogin)
        frmLogin.BringToFront()
        frmLogin.Show()
    End Sub
End Class