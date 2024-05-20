Imports System.Data.OleDb

Public Class frmRegister

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
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

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim filled As Boolean = True

        Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtFirstname", txtFirstname},
            {"txtLastname", txtLastname},
            {"txtUsername", txtUsername},
            {"txtPassword", txtPassword},
            {"cboRole", cboRole}
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
            Dim nextEmployeeID As String = GetNextEmployeeID()
            If nextEmployeeID IsNot Nothing Then
                sql = "INSERT INTO tblUsers(EmployeeID, FirstName, LastName, Username, [Password], AccStatus) VALUES(@EmployeeID, @FirstName, @LastName, @Username, [@Password], @AccStatus)"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@EmployeeID", nextEmployeeID)
                    .Parameters.AddWithValue("@FirstName", txtFirstname.Text)
                    .Parameters.AddWithValue("@LastName", txtLastname.Text)
                    .Parameters.AddWithValue("@Username", txtUsername.Text)
                    .Parameters.AddWithValue("[@Password]", txtPassword.Text)
                    .Parameters.AddWithValue("@AccessLevel", cboRole.Text)
                    .Parameters.AddWithValue("@AccStatus", "Active")
                    .ExecuteNonQuery()
                End With

                MsgBox("Account successfully created!", MsgBoxStyle.Information)
            Else
                MsgBox("Failed to generate EmployeeID. Please try again.", MsgBoxStyle.Exclamation)
            End If
        End If
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