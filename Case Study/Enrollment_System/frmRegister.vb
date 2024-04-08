Imports System.Data.OleDb

Public Class frmRegister
    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

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
            {"datePicker", datePicker},
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
            sql = "Insert into tblEmployeeUser(FirstName, LastName, Username, [Password], Birthdate, Role, Status) Values(@FirstName, @LastName, @Username, [@Password], @Birthdate, @Role, @Status)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@FirstName", txtFirstname.Text)
                .Parameters.AddWithValue("@LastName", txtLastname.Text)
                .Parameters.AddWithValue("@Username", txtUsername.Text)
                .Parameters.AddWithValue("@Password", txtPassword.Text)
                .Parameters.AddWithValue("@Birthdate", datePicker.Text)
                .Parameters.AddWithValue("@Role", cboRole.Text)
                .Parameters.AddWithValue("@Status", "Active")
                .ExecuteNonQuery()
            End With
            MsgBox("Account successfully created!", MsgBoxStyle.Information)
        End If
    End Sub
End Class