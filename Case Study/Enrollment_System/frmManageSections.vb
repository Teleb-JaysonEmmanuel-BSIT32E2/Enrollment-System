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
            x.SubItems.Add(dr("GradeLevel").ToString)
            x.SubItems.Add(dr("SY").ToString)
            x.SubItems.Add(dr("Semester").ToString)
            x.SubItems.Add(dr("Track").ToString)
            x.SubItems.Add(dr("Strand").ToString)
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
        sql = "Select GradeLevel,SY,Semester,Track,Strand,FirstName,LastName from qrySections where SectionName='" & txtSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            cboGradeLevel.Text = dr("GradeLevel").ToString
            cboSchoolYear.Text = dr("SY").ToString
            cboSemester.Text = dr("Semester").ToString
            cboTrack.Text = dr("Track").ToString
            cboStrand.Text = dr("Strand").ToString
            txtFirstName.Text = dr("FirstName").ToString
            txtLastName.Text = dr("LastName").ToString
        End If
    End Sub

    Private Sub updateData()
        sql = "Update qrySections set SectionName=@SectionName,GradeLevel=@GradeLevel,SY=@SY,Semester=@Semester,Track=@Track,Strand=@Strand,FirstName=@FirstName,LastName=@LastName where SectionName=@SectionName"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@SectionName", txtSection.Text)
            .Parameters.AddWithValue("@GradeLevel", cboGradeLevel.Text)
            .Parameters.AddWithValue("@SY", cboSchoolYear.Text)
            .Parameters.AddWithValue("@Semester", cboSemester.Text)
            .Parameters.AddWithValue("@Track", cboTrack.Text)
            .Parameters.AddWithValue("@Strand", cboStrand.Text)
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Section Record Updated", MsgBoxStyle.Information)
        Call loadAccount()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call updateData()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'NewSection.ShowDialog()
    End Sub

End Class