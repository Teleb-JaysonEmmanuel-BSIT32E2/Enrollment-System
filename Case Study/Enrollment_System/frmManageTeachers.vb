Imports System.Data.OleDb
Public Class frmManageTeachers
    Private Sub frmManageTeachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadTeacher()
        Call clear()
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
            txtTeachID.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtMiddleName.Enabled = True
        txtEmpNo.Enabled = True
        cboStatus.Enabled = True

        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnEdit.Enabled = False

        Call clear()

        txtTeachID.Text = GetNextTeacherId()
    End Sub

    Private Function GetNextTeacherId() As String
        Dim nextID As String = Nothing
        sql = "SELECT TOP 1 TeacherID FROM tblTeachers ORDER BY TeacherID DESC"
        cmd = New OleDbCommand(sql, cn)
        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            Dim lastEmployeeID As String = result.ToString()
            Dim lastNumber As Integer
            If Integer.TryParse(lastEmployeeID.Substring(4), lastNumber) Then
                nextID = "TCH-" & (lastNumber + 1).ToString("D4")
            End If
        Else
            nextID = "TCH-0001"
        End If
        Return nextID
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If btnNew.Enabled = True And btnEdit.Enabled = False Then
            Dim input As String = txtEmpNo.Text
            Dim existingEmpNos = GetExistingEmpNos()

            If input.StartsWith("EPLY-") AndAlso IsNumeric(input.Substring(4)) Then
                Dim filled As Boolean = True

                Dim requiredFields As New Dictionary(Of String, Control) From {
                    {"txtFirstname", txtFirstName},
                    {"txtLastname", txtLastName},
                    {"txtMiddleName", txtMiddleName},
                    {"txtEmpNo", txtEmpNo},
                    {"cboStatus", cboStatus}
                }

                For Each fieldName_controlPair In requiredFields
                    Dim control As Control = fieldName_controlPair.Value

                    If control.Text.Trim = "" Then
                        ErrorProvider1.SetError(control, "This field is required.")
                        filled = False
                        Exit For
                    Else
                        ErrorProvider1.SetError(control, "")
                    End If
                Next

                If filled Then
                    If txtEmpNo.Text <> "" Then
                        If Not existingEmpNos.Contains(txtEmpNo.Text) Then
                            sql = "INSERT INTO tblTeachers(TeacherID, EmployeeNo, FirstName, LastName, MiddleName, Status) VALUES(@TeacherID, @EmployeeNo, @FirstName, @LastName, @MiddleName, @Status)"
                            cmd = New OleDbCommand(sql, cn)
                            With cmd
                                .Parameters.AddWithValue("@TeacherID", txtTeachID.Text)
                                .Parameters.AddWithValue("@EmployeeNo", txtEmpNo.Text)
                                .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                .Parameters.AddWithValue("@LastName", txtLastName.Text)
                                .Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                .Parameters.AddWithValue("@Status", cboStatus.Text)
                                .ExecuteNonQuery()
                            End With

                            MsgBox("Account successfully created!", MsgBoxStyle.Information)
                            Call loadTeacher()
                            Call clear()
                            txtTeachID.Text = GetNextTeacherId()
                        Else
                            MsgBox("Employee Number already exists!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Employee Number must not be empty!", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        ElseIf btnEdit.Enabled = True And btnNew.Enabled = False Then

        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtMiddleName.Enabled = True
        cboStatus.Enabled = True

        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = True
        btnNew.Enabled = False
    End Sub

    Private Sub clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleName.Clear()
        txtEmpNo.Text = "EPLY-"
        cboStatus.SelectedIndex = -1
        txtTeachID.Clear()
    End Sub

    Private Sub txtTeachID_TextChanged(sender As Object, e As EventArgs) Handles txtTeachID.TextChanged
        sql = "Select * from tblTeachers where TeacherID = '" & txtTeachID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            txtFirstName.Text = dr("FirstName").ToString
            txtLastName.Text = dr("LastName").ToString
            txtMiddleName.Text = dr("MiddleName").ToString
            cboStatus.Text = dr("Status").ToString
            txtEmpNo.Text = dr("EmployeeNo").ToString
        Else
            txtLastName.Clear()
            txtMiddleName.Clear()
            txtEmpNo.Text = "EPLY-"
            cboStatus.SelectedIndex = -1
            txtTeachID.Text = GetNextTeacherId()
        End If
    End Sub

    Private Function GetExistingEmpNos() As List(Of String)
        Dim existingEmpNos As New List(Of String)
        sql = "SELECT DISTINCT EmployeeNo FROM tblTeachers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        While dr.Read = True
            existingEmpNos.Add(dr("EmployeeNo").ToString)
        End While
        dr.Close()
        Return existingEmpNos
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clear()

        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtMiddleName.Enabled = False
        cboStatus.Enabled = False

        btnCancel.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = True
        btnNew.Enabled = True
    End Sub
End Class