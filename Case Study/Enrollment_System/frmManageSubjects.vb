Imports System.Data.OleDb

Public Class frmManageSubjects
    Private Sub frmManageSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadAccount()
    End Sub

    Private Sub loadAccount()
        sql = "Select * from qrySubjects"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("SubjCode").ToString)
            x.SubItems.Add(dr("Description").ToString)
            x.SubItems.Add(dr("Units").ToString)
            x.SubItems.Add(dr("SubjType").ToString)
            x.SubItems.Add(dr("Status").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtSubjectCode.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub txtSubjectCode_TextChanged(sender As Object, e As EventArgs) Handles txtSubjectCode.TextChanged
        sql = "Select Description,Units,SubjType,Status from qrySubjects where SubjCode='" & txtSubjectCode.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtSubjectDescription.Text = dr("Description").ToString
            txtUnits.Text = dr("Units").ToString
            cboSubjectType.Text = dr("SubjType").ToString
            cboSubjectStatus.Text = dr("Status").ToString
        End If
    End Sub

    Private Sub updateData()
        sql = "Update qrySubjects set SubjCode=@SubjCode,Description=@Description,Units=@Units,SubjType=@SubjType,Status=@Status where SubjCode=@SubjCode"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@SubjCode", txtSubjectCode.Text)
            .Parameters.AddWithValue("Description", txtSubjectDescription.Text)
            .Parameters.AddWithValue("Units", txtUnits.Text)
            .Parameters.AddWithValue("SubjType", cboSubjectType.Text)
            .Parameters.AddWithValue("Status", cboSubjectStatus.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Subject Record Updated", MsgBoxStyle.Information)
        Call loadAccount()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Call updateData()
    End Sub
End Class