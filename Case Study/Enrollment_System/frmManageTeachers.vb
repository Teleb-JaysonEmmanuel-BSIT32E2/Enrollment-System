Imports System.Data.OleDb
Public Class frmManageTeachers
    Private Sub frmManageTeachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadTeacher()
    End Sub

    Private Sub loadTeacher()
        sql = "Select * from tblTeachers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("TeacherID").ToString)
            x.SubItems.Add(dr("EmployeeNo").ToString)
            x.SubItems.Add(dr("LastName").ToString)
            x.SubItems.Add(dr("FirstName").ToString)
            x.SubItems.Add(dr("MiddleName").ToString)
            x.SubItems.Add(dr("Status").ToString)

            ListView1.Items.Add(x)

        Loop

    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtFirstName.Text = ListView1.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        sql = "Select * from tblTeachers where "
    End Sub
End Class