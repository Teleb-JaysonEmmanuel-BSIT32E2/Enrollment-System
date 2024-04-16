Imports System.Data.OleDb
Public Class frmManageTeachers
    Private Sub frmManageTeachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtFirstName.Text = ListView1.SelectedItems(0).SubItems(2).Text
        End If
    End Sub
End Class