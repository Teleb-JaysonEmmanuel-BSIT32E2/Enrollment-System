Imports System.Data.OleDb

Public Class frmManageSections

    Private Sub frmManageSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadAccount()
    End Sub

    Private Sub loadAccount()
        sql = "Select * from qrySections"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("SectionName").ToString)
            x.SubItems.Add(dr("YearLevel").ToString)
            x.SubItems.Add(dr("SchoolYear").ToString)
            x.SubItems.Add(dr("Semester").ToString)
            x.SubItems.Add(dr("Department").ToString)
            x.SubItems.Add(dr("Course").ToString)
            x.SubItems.Add(dr("FirstName").ToString & " " & dr("LastName").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtSection.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub txtSection_TextChanged(sender As Object, e As EventArgs) Handles txtSection.TextChanged
        sql = "Select YearLevel,SchoolYear,Semester,Department,Course,FirstName,LastName from qrySections where SectionName='" & txtSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            cboYearLevel.Text = dr("YearLevel").ToString
            cboSchoolYear.Text = dr("SchoolYear").ToString
            cboSemester.Text = dr("Semester").ToString
            cboDepartment.Text = dr("Department").ToString
            cboCourse.Text = dr("Course").ToString
            txtFirstName.Text = dr("FirstName").ToString
            txtLastName.Text = dr("LastName").ToString
        End If
    End Sub

    Private Sub updateData()
        sql = "Update qrySections set SectionName=@SectionName,YearLevel=@YearLevel,SchoolYear=@SchoolYear,Semester=@Semester,Department=@Department,Course=@Course,FirstName=@FirstName,LastName=@LastName where SectionName=@SectionName"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@SectionName", txtSection.Text)
            .Parameters.AddWithValue("@YearLevel", cboYearLevel.Text)
            .Parameters.AddWithValue("@SchoolYear", cboSchoolYear.Text)
            .Parameters.AddWithValue("@Semester", cboSemester.Text)
            .Parameters.AddWithValue("@Course", cboDepartment.Text)
            .Parameters.AddWithValue("@Department", cboCourse.Text)
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Section Record Updated", MsgBoxStyle.Information)
        Call loadAccount()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Call updateData()
    End Sub

    Private Sub frmManageSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class