Imports System.Data.OleDb
Imports System.Globalization

Public Class frmManageSubjects
    Private Sub frmManageSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadAccount()
        Call callThings()
        txtSubjectDescription.Multiline = True
        txtSubjectDescription.ScrollBars = ScrollBars.Vertical
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call updateData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As DataTable = SearchDatabase(txtSearch.Text)
        PopulateListView(dt)
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select * from qrySubjects where SubjCode LIKE ? OR Description LIKE ?"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.Add(New OleDbParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New OleDbParameter("searchTerm2", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function

    Private Sub PopulateListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    Private Sub getSubjectType()
        sql = "SELECT DISTINCT SubjType FROM tblSubjects"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboSubjectType.Items.Clear()
        While dr.Read = True
            cboSubjectType.Items.Add(dr("SubjType").ToString())
        End While
        dr.Close()
    End Sub
    Private Sub getSubjectStatus()
        sql = "SELECT DISTINCT Status FROM tblSubjects"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboSubjectStatus.Items.Clear()
        While dr.Read = True
            cboSubjectStatus.Items.Add(dr("Status").ToString())
        End While
        dr.Close()
    End Sub

    Private Sub callThings()
        Call getSubjectStatus()
        Call getSubjectType()
    End Sub

    Private Sub enableThings()
        btnSave.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        txtSubjectCode.Enabled = True
        cboSubjectType.Enabled = True
        cboSubjectStatus.Enabled = True
        txtSubjectDescription.Enabled = True
        txtUnits.Enabled = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call enableThings()
    End Sub

    Private Sub clear()
        txtSubjectCode.Text = ""
        cboSubjectType.Text = ""
        cboSubjectStatus.Text = ""
        txtSubjectDescription.Text = ""
        txtUnits.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clear()
    End Sub

    Private Sub insertSubject()
        Dim lastId As String = ""
        sql = "SELECT TOP 1 SubjID FROM tblSubjects ORDER BY SubjID DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            lastId = dr("SubjID").ToString()
        Else
            lastId = "SUB-1000"
        End If

        Dim idNumber As Integer = Integer.Parse(lastId.Substring(4))
        idNumber += 1

        Dim newId As String = "SUB-" & idNumber.ToString("D4")

        sql = "Insert into tblSubjects ([SubjID],[SubjCode],[Description],[Units],[SubjType],[Status])values([@SubjID],[@SubjCode],[@Description],[@Units],[@SubjType],[@Status])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("SubjID", newId)
            .Parameters.AddWithValue("SubjCode", txtSubjectCode.Text)
            .Parameters.AddWithValue("Description", txtSubjectDescription.Text)
            .Parameters.AddWithValue("Units", txtUnits.Text)
            .Parameters.AddWithValue("SubjType", cboSubjectType.Text)
            .Parameters.AddWithValue("Status", cboSubjectStatus.Text)
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtSubjectCode.Text = "" Or txtUnits.Text = "" Or txtSubjectDescription.Text = "" Or cboSubjectStatus.Text = "" Or cboSubjectType.Text = "" Then
            MsgBox("Please fill all the fields", MsgBoxStyle.Exclamation)
        Else
            Call insertSubject()
            Call callThings()
            Call loadAccount()
            MsgBox("Record Inserted", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub deleteThings()
        Call deleteSubject()
    End Sub

    Private Sub deleteSubject()
        If txtSubjectCode.Text IsNot Nothing Then
            sql = "DELETE FROM tblSubjects WHERE SubjCode = @item"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@item", txtSubjectCode.Text)
                .ExecuteNonQuery()
            End With
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call deleteThings()
        Call callThings()
        Call loadAccount()
        Call clear()
        MsgBox("Record Deleted", MsgBoxStyle.Information)
    End Sub
End Class