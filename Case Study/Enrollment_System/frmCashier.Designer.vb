<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashier
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtSemester = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAcadYear = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtYearLvl = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStudentName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchBar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTuitionFee = New System.Windows.Forms.Label()
        Me.lblMiscFee = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lvlTotal = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.btnCancel)
        Me.Guna2GroupBox1.Controls.Add(Me.btnSave)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.ListView1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSemester)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSearchBar)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.txtAcadYear)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.txtYearLvl)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.txtCourse)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.txtStudentName)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(955, 580)
        Me.Guna2GroupBox1.TabIndex = 1
        '
        'txtSemester
        '
        Me.txtSemester.BorderColor = System.Drawing.Color.DarkGray
        Me.txtSemester.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSemester.DefaultText = ""
        Me.txtSemester.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSemester.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSemester.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSemester.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSemester.Enabled = False
        Me.txtSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSemester.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtSemester.ForeColor = System.Drawing.Color.Black
        Me.txtSemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSemester.Location = New System.Drawing.Point(301, 145)
        Me.txtSemester.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSemester.Name = "txtSemester"
        Me.txtSemester.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSemester.PlaceholderText = ""
        Me.txtSemester.SelectedText = ""
        Me.txtSemester.Size = New System.Drawing.Size(263, 30)
        Me.txtSemester.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(297, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 21)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Semester"
        '
        'txtAcadYear
        '
        Me.txtAcadYear.BorderColor = System.Drawing.Color.DarkGray
        Me.txtAcadYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAcadYear.DefaultText = ""
        Me.txtAcadYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAcadYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAcadYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAcadYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAcadYear.Enabled = False
        Me.txtAcadYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAcadYear.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtAcadYear.ForeColor = System.Drawing.Color.Black
        Me.txtAcadYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAcadYear.Location = New System.Drawing.Point(301, 77)
        Me.txtAcadYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAcadYear.Name = "txtAcadYear"
        Me.txtAcadYear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAcadYear.PlaceholderText = ""
        Me.txtAcadYear.SelectedText = ""
        Me.txtAcadYear.Size = New System.Drawing.Size(263, 30)
        Me.txtAcadYear.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(297, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 21)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Academic Year"
        '
        'txtYearLvl
        '
        Me.txtYearLvl.BorderColor = System.Drawing.Color.DarkGray
        Me.txtYearLvl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYearLvl.DefaultText = ""
        Me.txtYearLvl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtYearLvl.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtYearLvl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYearLvl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYearLvl.Enabled = False
        Me.txtYearLvl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYearLvl.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtYearLvl.ForeColor = System.Drawing.Color.Black
        Me.txtYearLvl.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYearLvl.Location = New System.Drawing.Point(15, 214)
        Me.txtYearLvl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtYearLvl.Name = "txtYearLvl"
        Me.txtYearLvl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYearLvl.PlaceholderText = ""
        Me.txtYearLvl.SelectedText = ""
        Me.txtYearLvl.Size = New System.Drawing.Size(263, 30)
        Me.txtYearLvl.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(11, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Year Level"
        '
        'txtCourse
        '
        Me.txtCourse.BorderColor = System.Drawing.Color.DarkGray
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourse.DefaultText = ""
        Me.txtCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourse.Enabled = False
        Me.txtCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourse.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtCourse.ForeColor = System.Drawing.Color.Black
        Me.txtCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourse.Location = New System.Drawing.Point(15, 145)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCourse.PlaceholderText = ""
        Me.txtCourse.SelectedText = ""
        Me.txtCourse.Size = New System.Drawing.Size(263, 30)
        Me.txtCourse.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(11, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Course"
        '
        'txtStudentName
        '
        Me.txtStudentName.BorderColor = System.Drawing.Color.DarkGray
        Me.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentName.DefaultText = ""
        Me.txtStudentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentName.Enabled = False
        Me.txtStudentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentName.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtStudentName.ForeColor = System.Drawing.Color.Black
        Me.txtStudentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentName.Location = New System.Drawing.Point(15, 77)
        Me.txtStudentName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentName.PlaceholderText = ""
        Me.txtStudentName.SelectedText = ""
        Me.txtStudentName.Size = New System.Drawing.Size(263, 30)
        Me.txtStudentName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(11, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Student Name"
        '
        'txtSearchBar
        '
        Me.txtSearchBar.BorderColor = System.Drawing.Color.DarkGray
        Me.txtSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchBar.DefaultText = ""
        Me.txtSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBar.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtSearchBar.ForeColor = System.Drawing.Color.Black
        Me.txtSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBar.Location = New System.Drawing.Point(148, 6)
        Me.txtSearchBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBar.PlaceholderText = ""
        Me.txtSearchBar.SelectedText = ""
        Me.txtSearchBar.Size = New System.Drawing.Size(258, 28)
        Me.txtSearchBar.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label5.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 21)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Enter Student ID:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Enabled = False
        Me.ListView1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 260)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(553, 308)
        Me.ListView1.TabIndex = 105
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Section"
        Me.ColumnHeader1.Width = 130
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "SubjCode"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Subject Title"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Units"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 50
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.lvlTotal)
        Me.Guna2GroupBox2.Controls.Add(Me.Label12)
        Me.Guna2GroupBox2.Controls.Add(Me.lblDiscount)
        Me.Guna2GroupBox2.Controls.Add(Me.Label10)
        Me.Guna2GroupBox2.Controls.Add(Me.lblMiscFee)
        Me.Guna2GroupBox2.Controls.Add(Me.lblTuitionFee)
        Me.Guna2GroupBox2.Controls.Add(Me.Label8)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(581, 47)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(367, 274)
        Me.Guna2GroupBox2.TabIndex = 106
        Me.Guna2GroupBox2.Text = "Payment"
        Me.Guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(6, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 21)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Tuition Fee:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label8.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(22, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 21)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Misc Fee:"
        '
        'lblTuitionFee
        '
        Me.lblTuitionFee.AutoSize = True
        Me.lblTuitionFee.BackColor = System.Drawing.Color.Transparent
        Me.lblTuitionFee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblTuitionFee.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTuitionFee.ForeColor = System.Drawing.Color.Black
        Me.lblTuitionFee.Location = New System.Drawing.Point(99, 51)
        Me.lblTuitionFee.Name = "lblTuitionFee"
        Me.lblTuitionFee.Size = New System.Drawing.Size(28, 21)
        Me.lblTuitionFee.TabIndex = 110
        Me.lblTuitionFee.Text = "---"
        '
        'lblMiscFee
        '
        Me.lblMiscFee.AutoSize = True
        Me.lblMiscFee.BackColor = System.Drawing.Color.Transparent
        Me.lblMiscFee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblMiscFee.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiscFee.ForeColor = System.Drawing.Color.Black
        Me.lblMiscFee.Location = New System.Drawing.Point(99, 101)
        Me.lblMiscFee.Name = "lblMiscFee"
        Me.lblMiscFee.Size = New System.Drawing.Size(28, 21)
        Me.lblMiscFee.TabIndex = 111
        Me.lblMiscFee.Text = "---"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label10.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(22, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 21)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Discount:"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.Black
        Me.lblDiscount.Location = New System.Drawing.Point(99, 166)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(28, 21)
        Me.lblDiscount.TabIndex = 113
        Me.lblDiscount.Text = "---"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label12.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(48, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 21)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Total:"
        '
        'lvlTotal
        '
        Me.lvlTotal.AutoSize = True
        Me.lvlTotal.BackColor = System.Drawing.Color.Transparent
        Me.lvlTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lvlTotal.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlTotal.ForeColor = System.Drawing.Color.Black
        Me.lvlTotal.Location = New System.Drawing.Point(99, 231)
        Me.lvlTotal.Name = "lvlTotal"
        Me.lvlTotal.Size = New System.Drawing.Size(28, 21)
        Me.lvlTotal.TabIndex = 115
        Me.lvlTotal.Text = "---"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.Maroon
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(831, 528)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnCancel.PressedDepth = 40
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 108
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Enabled = False
        Me.btnSave.FillColor = System.Drawing.Color.Maroon
        Me.btnSave.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(703, 528)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnSave.PressedDepth = 40
        Me.btnSave.Size = New System.Drawing.Size(104, 40)
        Me.btnSave.TabIndex = 107
        Me.btnSave.Text = "Save"
        '
        'frmCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 588)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCashier"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtSemester As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAcadYear As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtYearLvl As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStudentName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearchBar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblMiscFee As Label
    Friend WithEvents lblTuitionFee As Label
    Friend WithEvents lvlTotal As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
End Class
