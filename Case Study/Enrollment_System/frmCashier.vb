Imports System.Data.OleDb

Public Class frmCashier
    Dim majUnits As Integer
    Dim minUnits As Integer
    Dim labFee As Integer
    Dim miscFee As Integer
    Dim specialist As Integer
    Private Sub frmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSY()
    End Sub

    Private Sub loadSY()
        sql = "SELECT DISTINCT SchoolYear FROM tblSY"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        cboSY.Items.Clear()
        While dr.Read = True
            cboSY.Items.Add(dr("SchoolYear").ToString())
        End While
        dr.Close()
    End Sub

    Private Sub cboSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSY.SelectedIndexChanged
        sql = "SELECT * FROM qryClassSchedule WHERE SchoolYear ='" & cboSY.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            x = New ListViewItem(dr("Description").ToString())
            x.SubItems.Add(dr("Units").ToString())
            x.SubItems.Add(dr("FirstName").ToString() & " " & dr("LastName").ToString())
            ListView1.Items.Add(x)
        Loop

        btnSave.Enabled = True
    End Sub

    Private Sub txtMajor_TextChanged(sender As Object, e As EventArgs) Handles txtMajor.TextChanged
        If cboSY.SelectedIndex <> -1 Then
            sql = "SELECT SUM(Units) FROM qryClassSchedule WHERE SchoolYear = '" & cboSY.Text & "' AND SubjType = 'Major'"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                majUnits = CInt(dr(0)) * txtMajor.Text
            End If
        End If
    End Sub

    Private Sub txtMinor_TextChanged(sender As Object, e As EventArgs) Handles txtMinor.TextChanged
        If cboSY.SelectedIndex <> -1 Then
            sql = "SELECT SUM(Units) FROM qryClassSchedule WHERE SchoolYear = '" & cboSY.Text & "' AND SubjType = 'Minor'"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                minUnits = CInt(dr(0)) * txtMinor.Text
            End If
        End If
    End Sub

    Private Sub txtLab_TextChanged(sender As Object, e As EventArgs) Handles txtLab.TextChanged
        'needs laboratory on sections
        If txtLab.Text <> "" Then
            labFee = CInt(txtLab.Text)
            lblLFee.Text = txtLab.Text
        End If
    End Sub

    Private Sub txtMisc_TextChanged(sender As Object, e As EventArgs) Handles txtMisc.TextChanged
        If txtMisc.Text <> "" Then
            miscFee = CInt(txtMisc.Text)
            lblMFee.Text = txtMisc.Text
        End If
    End Sub

    Private Sub txtSpecialist_TextChanged(sender As Object, e As EventArgs) Handles txtSpecialist.TextChanged
        If txtSpecialist.Text <> "" Then
            specialist = CInt(txtSpecialist.Text)
            lblSpecialist.Text = txtSpecialist.Text
        End If
    End Sub
    Private Sub loadAllAssessment()
        Dim filled As Boolean = True

        Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtMajor", txtMajor},
            {"txtMinor", txtMinor}, '{"txtLab", txtLab},
            {"txtMisc", txtMisc},
            {"txtSpecialist", txtSpecialist}
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
            lblTFee.Text = majUnits + minUnits

            lblTotalPay.Text = majUnits + minUnits + miscFee + specialist

            sql = "INSERT INTO tblFees(SY, Major, Minor, Misc, Laboratory, Specialist) VALUES(@SY, @Major, @Minor, @Misc, @Laboratory, @Specialist)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@SY", cboSY.Text)
                .Parameters.AddWithValue("@Major", txtMajor.Text)
                .Parameters.AddWithValue("@Minor", txtMinor.Text)
                .Parameters.AddWithValue("@Misc", txtMisc.Text)
                .Parameters.AddWithValue("@Laboratory", txtLab.Text)
                .Parameters.AddWithValue("@Specialist", txtSpecialist.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Successfully saved!")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        sql = "SELECT SY FROM tblFees WHERE SY = '" & cboSY.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            MsgBox("ERRO! ERROR! School Year already has fees..", MsgBoxStyle.Critical)
            cboSY.SelectedIndex = -1
        Else
            Call loadAllAssessment()
        End If
    End Sub
End Class