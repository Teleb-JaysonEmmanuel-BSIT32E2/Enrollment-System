Imports System.Data.OleDb

Public Class frmManageStudents
    Dim newDeptID As String
    Dim newCourseID As String
    Dim newSYID As String
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmStudentInfo_TrackCourses.Show()
        Me.TopMost = True
        frmStudentInfo_TrackCourses.txtAdmissionNumber.Visible = True
        btnSave.Enabled = True
        'frmStudentInfo_TrackCourses.TopLevel = False
        'Panel1.Controls.Add(frmStudentInfo_TrackCourses)
        'frmStudentInfo_TrackCourses.BringToFront()
        'frmStudentInfo_TrackCourses.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmStudentInfo_TrackCourses.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmStudentInfo_TrackCourses.btnEdit1.Enabled = False
        btnSave.Enabled = False
        'If frmStudentInfo_TrackCourses.txtFirstName.Text = "" Or frmStudentInfo_TrackCourses.txtLastName.Text = "" Or
        ''    frmStudentInfo_TrackCourses.txtMiddleName.Text = "" Or frmStudentInfo_TrackCourses.txtMotherContactNo.Text = "" Or frmStudentInfo_TrackCourses.txtMotherName.Text = "" Or
        ''    frmStudentInfo_TrackCourses.txtAge.Text = "" Or frmStudentInfo_TrackCourses.cboBrgy.Text = "" Or frmStudentInfo_TrackCourses.cboCity.Text = "" Or
        ''    frmStudentInfo_TrackCourses.cboC.Text = "" Or frmStudentInfo_TrackCourses.cboD.Text = "" Or frmStudentInfo_TrackCourses.cboSY.Text = "" Or frmStudentInfo_TrackCourses.cboC.Text = "" Or
        ''    frmStudentInfo_TrackCourses.cboY.Text = "" Or frmStudentInfo_TrackCourses.txtAddress.Text = "" Or frmStudentInfo_TrackCourses.txtFatherContactNo.Text = "" Or frmStudentInfo_TrackCourses.txtFatherName.Text = "" Or frmStudentInfo_TrackCourses.cboDD.Text = "" Or frmStudentInfo_TrackCourses.cboCD.Text = "" Then
        ''    MsgBox("Please fill up the fields", MsgBoxStyle.Exclamation)
        ''Else
        Dim filled As Boolean = True

        Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtFirstName", frmStudentInfo_TrackCourses.txtFirstName},
            {"txtLastName", frmStudentInfo_TrackCourses.txtLastName},
            {"txtMiddleName", frmStudentInfo_TrackCourses.txtMiddleName},
            {"txtMotherContactNo", frmStudentInfo_TrackCourses.txtMotherContactNo},
            {"txtMotherName", frmStudentInfo_TrackCourses.txtMotherName},
            {"txtAge", frmStudentInfo_TrackCourses.txtAge},
            {"cboBrgy", frmStudentInfo_TrackCourses.cboBrgy},
            {"cboCity", frmStudentInfo_TrackCourses.cboCity},
            {"txtAddress", frmStudentInfo_TrackCourses.txtAddress},
            {"txtFatherContactNo", frmStudentInfo_TrackCourses.txtFatherContactNo},
            {"txtFatherName", frmStudentInfo_TrackCourses.txtFatherName},
            {"datePicker", frmStudentInfo_TrackCourses.datePicker},
            {"txtContactNo", frmStudentInfo_TrackCourses.txtContactNo},
            {"txtAdmissionNumber", frmStudentInfo_TrackCourses.txtAdmissionNumber}
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
            Call insertThings()
            Call frmStudentInfo_TrackCourses.studentNumber()
            'End If
            frmStudentInfo_TrackCourses.Close()
        End If
    End Sub

    Private courseId As String
    Private deptId As String
    Private studId As String

    Private Sub insertThings()
        Call save()
        Call loadAccount()
    End Sub

    Private Sub save()
        Dim lastId As String = ""
        sql = "SELECT TOP 1 AdmissionID FROM tblStudents ORDER BY AdmissionID DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            lastId = dr("AdmissionID").ToString()
        Else
            lastId = "STUD-1000"
        End If

        Dim idNumber As Integer = Integer.Parse(lastId.Substring(5))
        idNumber += 1

        studId = "STUD-" & idNumber.ToString("D4")

        Dim convertedDate As DateTime = Convert.ToDateTime(frmStudentInfo_TrackCourses.datePicker.Text)
        sql = "Insert into tblStudents (AdmissionID, AdmissionNo,LastName,FirstName,MiddleName,Address,Brgy,City,ContactNo,Bdate,Age,MotherName,MotherContactNo,FatherName,FatherContactNo)Values
                (@AdmissionID,@AdmissionNo,@LastName,@FirstName,@MiddleName,@Address,@Brgy,@City,@ContactNo,@Bdate,@Age,@MotherName,@MotherContactNo,@FatherName,@FatherContactNo)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AdmissionID", studId)
            .Parameters.AddWithValue("@AdmissionNo", frmStudentInfo_TrackCourses.txtAdmissionNumber.Text)
            .Parameters.AddWithValue("@LastName", frmStudentInfo_TrackCourses.txtLastName.Text)
            .Parameters.AddWithValue("@FirstName", frmStudentInfo_TrackCourses.txtFirstName.Text)
            .Parameters.AddWithValue("@MiddleName", frmStudentInfo_TrackCourses.txtMiddleName.Text)
            .Parameters.AddWithValue("@Address", frmStudentInfo_TrackCourses.txtAddress.Text)
            .Parameters.AddWithValue("@Brgy", frmStudentInfo_TrackCourses.cboBrgy.Text)
            .Parameters.AddWithValue("@City", frmStudentInfo_TrackCourses.cboCity.Text)
            .Parameters.AddWithValue("@ContactNo", frmStudentInfo_TrackCourses.txtContactNo.Text)
            .Parameters.AddWithValue("@Bdate", convertedDate)
            .Parameters.AddWithValue("@Age", frmStudentInfo_TrackCourses.txtAge.Text)
            .Parameters.AddWithValue("@MotherName", frmStudentInfo_TrackCourses.txtMotherName.Text)
            .Parameters.AddWithValue("[@MotherContactNo]", frmStudentInfo_TrackCourses.txtMotherContactNo.Text)
            .Parameters.AddWithValue("@FatherName", frmStudentInfo_TrackCourses.txtFatherName.Text)
            .Parameters.AddWithValue("[@FatherContactNo]", frmStudentInfo_TrackCourses.txtFatherContactNo.Text)

            cmd.ExecuteNonQuery()

        End With
        MsgBox("Successfully Saved", MsgBoxStyle.Information)


    End Sub

    'Private Sub dept()
    '    sql = "INSERT into tblStudentRegistration(FirstName, MiddleName, LastName, SectionName, DeptID, CourseID, SYID) " &
    '        "VALUES(@FirstName, @MiddleName, @LastName, @SectionName, @DeptID, @CourseID, @SYID)"
    '    cmd = New OleDbCommand(sql, cn)
    '    With cmd
    '        .Parameters.AddWithValue("@FirstName", frmStudentInfo_TrackCourses.txtFirstName.Text)
    '        .Parameters.AddWithValue("@MiddleName", frmStudentInfo_TrackCourses.txtMiddleName.Text)
    '        .Parameters.AddWithValue("@LastName", frmStudentInfo_TrackCourses.txtLastName.Text)
    '        .Parameters.AddWithValue("@SectionName", frmStudentInfo_TrackCourses.cboSection.Text)
    '        .Parameters.AddWithValue("@DeptID", newDeptID)
    '        .Parameters.AddWithValue("@CourseID", newCourseID)
    '        .Parameters.AddWithValue("@SYID", newSYID)
    '        cmd.ExecuteNonQuery()
    '    End With
    '    MsgBox("Student Registration is registered!")
    'End Sub
    Public Sub loadAccount()
        sql = "Select * from qryStudents"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("AdmissionNo").ToString)
            x.SubItems.Add(dr("LastName").ToString)
            x.SubItems.Add(dr("FirstName").ToString)
            x.SubItems.Add(dr("MiddleName").ToString)
            x.SubItems.Add(dr("Address").ToString)
            x.SubItems.Add(dr("Brgy").ToString)
            x.SubItems.Add(dr("City").ToString)
            x.SubItems.Add(dr("ContactNo").ToString)
            x.SubItems.Add(dr("Bdate").ToString)
            x.SubItems.Add(dr("Age").ToString)
            x.SubItems.Add(dr("MotherName").ToString)
            x.SubItems.Add(dr("MotherContactNo").ToString)
            x.SubItems.Add(dr("FatherName").ToString)
            x.SubItems.Add(dr("FatherContactNo").ToString)
            ListView1.Items.Add(x)
        Loop


    End Sub
    Private Sub frmManageStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call connection()
        Call loadAccount()
        Call frmStudentInfo_TrackCourses.studentNumber()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            frmStudentInfo_TrackCourses.txtAdmissionNumber.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmStudentInfo_TrackCourses.txtAdmissionNumber.Enabled = False
        frmStudentInfo_TrackCourses.Show()
        frmStudentInfo_TrackCourses.btnEdit1.Enabled = True
    End Sub

    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged
        Dim dt As DataTable = SearchDatabase(txtSearchBar.Text)
        PopulateListView(dt)
    End Sub
    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select * from qryStudents where AdmissionNo LIKE ? OR LastName LIKE ? OR FirstName LIKE ?"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.Add(New OleDbParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New OleDbParameter("searchTerm2", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New OleDbParameter("searchTerm3", "%" & searchTerm & "%"))

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
End Class