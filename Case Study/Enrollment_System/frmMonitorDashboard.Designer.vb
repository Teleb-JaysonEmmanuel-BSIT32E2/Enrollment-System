<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitorDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNumberUser = New System.Windows.Forms.Label()
        Me.lblNumberSubject = New System.Windows.Forms.Label()
        Me.lblNumberStudent = New System.Windows.Forms.Label()
        Me.lblAcademicYear = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel7.Controls.Add(Me.lblNumberUser)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Location = New System.Drawing.Point(56, 46)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(20, 10, 0, 0)
        Me.Panel7.Size = New System.Drawing.Size(300, 120)
        Me.Panel7.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkBlue
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(20, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "No. of Users"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel8.Controls.Add(Me.lblNumberStudent)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Location = New System.Drawing.Point(403, 46)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(20, 10, 0, 0)
        Me.Panel8.Size = New System.Drawing.Size(300, 120)
        Me.Panel8.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.ForestGreen
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(20, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(251, 25)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "No. of Registered Students"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel9.Controls.Add(Me.lblNumberSubject)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(56, 206)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(20, 10, 0, 0)
        Me.Panel9.Size = New System.Drawing.Size(300, 120)
        Me.Panel9.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Goldenrod
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(20, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "No. of Subjects"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel10.Controls.Add(Me.lblSemester)
        Me.Panel10.Controls.Add(Me.lblAcademicYear)
        Me.Panel10.Controls.Add(Me.Label11)
        Me.Panel10.Location = New System.Drawing.Point(403, 206)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(20, 10, 0, 0)
        Me.Panel10.Size = New System.Drawing.Size(300, 120)
        Me.Panel10.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(20, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(207, 25)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Academic School Year"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumberUser
        '
        Me.lblNumberUser.AutoSize = True
        Me.lblNumberUser.Font = New System.Drawing.Font("Microsoft New Tai Lue", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberUser.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNumberUser.Location = New System.Drawing.Point(30, 60)
        Me.lblNumberUser.Name = "lblNumberUser"
        Me.lblNumberUser.Size = New System.Drawing.Size(31, 35)
        Me.lblNumberUser.TabIndex = 22
        Me.lblNumberUser.Text = "0"
        '
        'lblNumberSubject
        '
        Me.lblNumberSubject.AutoSize = True
        Me.lblNumberSubject.Font = New System.Drawing.Font("Microsoft New Tai Lue", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberSubject.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNumberSubject.Location = New System.Drawing.Point(30, 60)
        Me.lblNumberSubject.Name = "lblNumberSubject"
        Me.lblNumberSubject.Size = New System.Drawing.Size(31, 35)
        Me.lblNumberSubject.TabIndex = 22
        Me.lblNumberSubject.Text = "0"
        '
        'lblNumberStudent
        '
        Me.lblNumberStudent.AutoSize = True
        Me.lblNumberStudent.Font = New System.Drawing.Font("Microsoft New Tai Lue", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberStudent.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNumberStudent.Location = New System.Drawing.Point(30, 60)
        Me.lblNumberStudent.Name = "lblNumberStudent"
        Me.lblNumberStudent.Size = New System.Drawing.Size(31, 35)
        Me.lblNumberStudent.TabIndex = 23
        Me.lblNumberStudent.Text = "0"
        '
        'lblAcademicYear
        '
        Me.lblAcademicYear.AutoSize = True
        Me.lblAcademicYear.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcademicYear.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAcademicYear.Location = New System.Drawing.Point(30, 60)
        Me.lblAcademicYear.Name = "lblAcademicYear"
        Me.lblAcademicYear.Size = New System.Drawing.Size(24, 28)
        Me.lblAcademicYear.TabIndex = 24
        Me.lblAcademicYear.Text = "0"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSemester.Location = New System.Drawing.Point(150, 60)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(24, 28)
        Me.lblSemester.TabIndex = 25
        Me.lblSemester.Text = "0"
        '
        'frmMonitorDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 588)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMonitorDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMonitorDashboard"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNumberUser As Label
    Friend WithEvents lblNumberStudent As Label
    Friend WithEvents lblNumberSubject As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblAcademicYear As Label
End Class
