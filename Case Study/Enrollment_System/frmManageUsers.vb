Imports Guna.UI2.Native.WinApi
Imports System.Data.OleDb
Imports System.Drawing.Text
Imports System.Reflection

Public Class frmManageUsers
    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Close()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtEmpNo.Text = "" Or txtLn.Text = "" Or txtFn.Text = "" Or txtP.Text = "" Or txtCp.Text = "" Or cboAS.Text = "" Or cboR.Text = "" Then
            MsgBox("Please fill up the fields", MsgBoxStyle.Exclamation)
        Else
            sql = "Select EmployeeID from tblUsers where EmployeeID='" & txtEmpNo.Text & "'"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Account is already Exist", MsgBoxStyle.Exclamation)
            Else
                Call save()
            End If
            Call reset()
        End If
    End Sub



    Private Sub save()

        If txtP.Text <> txtCp.Text Then
            MsgBox("Passwords do not match!", MsgBoxStyle.Critical)
   
        Else
            sql = "Insert into tblUsers (EmployeeID, Username, [Password], LastName, FirstName,Role, AccStatus) Values (@EmployeeID, @Username, [@Password], @LastName, @FirstName,[@Role], @AccStatus)"
            cmd = New OleDbCommand(sql, cn)

            With cmd
                .Parameters.AddWithValue("@EmployeeID", txtEmpNo.Text)
                .Parameters.AddWithValue("@Username", txtUn.Text)
                .Parameters.AddWithValue("[@Password]", txtP.Text)
                .Parameters.AddWithValue("@LastName", txtLn.Text)
                .Parameters.AddWithValue("@FirstName", txtFn.Text)
                .Parameters.AddWithValue("[@Role]", cboR.Text)
                .Parameters.AddWithValue("@AccStatus", cboAS.Text)
                cmd.ExecuteNonQuery()

            End With

            MsgBox("Successfully Saved", MsgBoxStyle.Information)

        End If
        Call loadAccount()

    End Sub

    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadAccount()

    End Sub
    Private Sub loadAccount()
        sql = "Select * from qryUsers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("EmployeeID").ToString)
            x.SubItems.Add(dr("FirstName").ToString)
            x.SubItems.Add(dr("LastName").ToString)
            x.SubItems.Add(dr("Username").ToString)
            x.SubItems.Add(dr("Password").ToString)
            x.SubItems.Add(dr("Role").ToString)
            x.SubItems.Add(dr("AccStatus").ToString)
            ListView1.Items.Add(x)

        Loop

    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtEmpNo.Text = "" Or txtLn.Text = "" Or txtFn.Text = "" Or txtP.Text = "" Or txtCp.Text = "" Or cboAS.Text = "" Or cboR.Text = "" Then
            MsgBox("Please fill up the fields", MsgBoxStyle.Exclamation)
        ElseIf txtP.Text <> txtCp.Text Then
            MsgBox("Password Doesn't Match", MsgBoxStyle.Critical)
        Else
            Call UpdateData()
        End If
        Call loadAccount()

    End Sub
    Private Sub UpdateData()
        'Update Specific records from database'
        sql = "UPDATE qryUsers SET EmployeeID=@EmployeeID,LastName=@LastName,FirstName=@FirstName,Username=@Username,[Password]=[@Password],[Role]=[@Role], AccStatus=@AccStatus where EmployeeID=@EmployeeID"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@EmployeeID", txtEmpNo.Text)
            .Parameters.AddWithValue("@LastName", txtLn.Text)
            .Parameters.AddWithValue("@FirstName", txtFn.Text)
            .Parameters.AddWithValue("@Username", txtUn.Text)
            .Parameters.AddWithValue("[@Password]", txtP.Text)
            .Parameters.AddWithValue("[@Role]", cboR.Text)
            .Parameters.AddWithValue("@AccStatus", cboAS.Text)
            .ExecuteNonQuery()

        End With
        MsgBox("Record Successfully Updated", MsgBoxStyle.Information)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtEmpNo.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub


    Private Sub reset()
        txtEmpNo.Clear()
        txtUn.Clear()
        txtLn.Clear()
        txtFn.Clear()
        txtP.Clear()
        txtCp.Clear()
        cboR.SelectedIndex = -1

    End Sub

    Private Sub txtEmpNo_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNo.TextChanged
        sql = "Select EmployeeID, FirstName, LastName, Username, [Password],Role,AccStatus from qryUsers where EmployeeID='" & txtEmpNo.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtEmpNo.Text = dr("EmployeeID").ToString
            txtFn.Text = dr("FirstName").ToString
            txtLn.Text = dr("LastName").ToString
            txtUn.Text = dr("Username").ToString
            txtP.Text = dr("Password").ToString
            cboR.Text = dr("Role").ToString
            cboAS.Text = dr("AccStatus").ToString
        End If
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub cboAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAS.SelectedIndexChanged

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        txtFn.Enabled = True
        txtLn.Enabled = True
        txtP.Enabled = True
        txtCp.Enabled = True
        txtUn.Enabled = True
        cboR.Enabled = True
        btnSave.Enabled = True
        btnEdit.Enabled = True
        ListView1.Enabled = True

        Dim employeeId As String = GetNextEmployeeID()
        txtEmpNo.Text = employeeId
        cboAS.SelectedIndex = 0
    End Sub

    Private Sub Guna2TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As DataTable = SearchDatabase(txtSearch.Text)
        PopulateListView(dt)
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select * from qryUsers where EmployeeID LIKE ? OR LastName LIKE ?"
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
    Private Function GetNextEmployeeID() As String
        Dim nextID As String = Nothing
        sql = "SELECT TOP 1 EmployeeID FROM tblUsers ORDER BY EmployeeID DESC"
        cmd = New OleDbCommand(sql, cn)
        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            Dim lastEmployeeID As String = result.ToString()
            Dim lastNumber As Integer
            If Integer.TryParse(lastEmployeeID.Substring(4), lastNumber) Then
                nextID = "EMP-" & (lastNumber + 1).ToString("D4")
            End If
        Else
            nextID = "EMP-1001"
        End If
        Return nextID
    End Function
End Class