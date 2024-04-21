<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentInfo_TrackCourses
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Manage = New System.Windows.Forms.TabPage()
        Me.btnEdit1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtFatherName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFatherContactNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMotherContactNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMotherName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtContactNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboBrgy = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboCD = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboDD = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboY = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboC = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboD = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboSem = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboSY = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblStudentNumber = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Manage.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Manage)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(951, 447)
        Me.TabControl1.TabIndex = 30
        '
        'Manage
        '
        Me.Manage.Controls.Add(Me.Label23)
        Me.Manage.Controls.Add(Me.lblStudentNumber)
        Me.Manage.Controls.Add(Me.btnClose)
        Me.Manage.Controls.Add(Me.btnEdit1)
        Me.Manage.Controls.Add(Me.txtFatherName)
        Me.Manage.Controls.Add(Me.Label14)
        Me.Manage.Controls.Add(Me.txtFatherContactNo)
        Me.Manage.Controls.Add(Me.Label13)
        Me.Manage.Controls.Add(Me.txtMotherContactNo)
        Me.Manage.Controls.Add(Me.Label12)
        Me.Manage.Controls.Add(Me.txtMotherName)
        Me.Manage.Controls.Add(Me.Label11)
        Me.Manage.Controls.Add(Me.txtAge)
        Me.Manage.Controls.Add(Me.Label10)
        Me.Manage.Controls.Add(Me.datePicker)
        Me.Manage.Controls.Add(Me.Label9)
        Me.Manage.Controls.Add(Me.txtContactNo)
        Me.Manage.Controls.Add(Me.Label8)
        Me.Manage.Controls.Add(Me.cboBrgy)
        Me.Manage.Controls.Add(Me.Label7)
        Me.Manage.Controls.Add(Me.cboCity)
        Me.Manage.Controls.Add(Me.Label5)
        Me.Manage.Controls.Add(Me.txtAddress)
        Me.Manage.Controls.Add(Me.Label4)
        Me.Manage.Controls.Add(Me.txtLastName)
        Me.Manage.Controls.Add(Me.Label3)
        Me.Manage.Controls.Add(Me.txtMiddleName)
        Me.Manage.Controls.Add(Me.Label2)
        Me.Manage.Controls.Add(Me.txtFirstName)
        Me.Manage.Controls.Add(Me.Label1)
        Me.Manage.Controls.Add(Me.txtStudentNo)
        Me.Manage.Controls.Add(Me.Label6)
        Me.Manage.Location = New System.Drawing.Point(4, 30)
        Me.Manage.Name = "Manage"
        Me.Manage.Padding = New System.Windows.Forms.Padding(3)
        Me.Manage.Size = New System.Drawing.Size(943, 413)
        Me.Manage.TabIndex = 0
        Me.Manage.Text = "Student Information"
        Me.Manage.UseVisualStyleBackColor = True
        '
        'btnEdit1
        '
        Me.btnEdit1.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit1.Enabled = False
        Me.btnEdit1.FillColor = System.Drawing.Color.Maroon
        Me.btnEdit1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit1.ForeColor = System.Drawing.Color.White
        Me.btnEdit1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnEdit1.Location = New System.Drawing.Point(473, 347)
        Me.btnEdit1.Name = "btnEdit1"
        Me.btnEdit1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnEdit1.PressedDepth = 40
        Me.btnEdit1.Size = New System.Drawing.Size(104, 40)
        Me.btnEdit1.TabIndex = 99
        Me.btnEdit1.Text = "Edit"
        '
        'txtFatherName
        '
        Me.txtFatherName.BorderColor = System.Drawing.Color.DarkGray
        Me.txtFatherName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFatherName.DefaultText = ""
        Me.txtFatherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFatherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFatherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherName.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtFatherName.ForeColor = System.Drawing.Color.Black
        Me.txtFatherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherName.Location = New System.Drawing.Point(611, 262)
        Me.txtFatherName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFatherName.PlaceholderText = ""
        Me.txtFatherName.SelectedText = ""
        Me.txtFatherName.Size = New System.Drawing.Size(304, 36)
        Me.txtFatherName.TabIndex = 98
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label14.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkGray
        Me.Label14.Location = New System.Drawing.Point(607, 238)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 21)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Father's Name"
        '
        'txtFatherContactNo
        '
        Me.txtFatherContactNo.BorderColor = System.Drawing.Color.DarkGray
        Me.txtFatherContactNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFatherContactNo.DefaultText = ""
        Me.txtFatherContactNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFatherContactNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFatherContactNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherContactNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherContactNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherContactNo.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtFatherContactNo.ForeColor = System.Drawing.Color.Black
        Me.txtFatherContactNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherContactNo.Location = New System.Drawing.Point(611, 347)
        Me.txtFatherContactNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFatherContactNo.Name = "txtFatherContactNo"
        Me.txtFatherContactNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFatherContactNo.PlaceholderText = ""
        Me.txtFatherContactNo.SelectedText = ""
        Me.txtFatherContactNo.Size = New System.Drawing.Size(304, 36)
        Me.txtFatherContactNo.TabIndex = 96
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label13.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(607, 323)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 21)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "Father's Contact Number"
        '
        'txtMotherContactNo
        '
        Me.txtMotherContactNo.BorderColor = System.Drawing.Color.DarkGray
        Me.txtMotherContactNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMotherContactNo.DefaultText = ""
        Me.txtMotherContactNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMotherContactNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMotherContactNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherContactNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherContactNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherContactNo.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtMotherContactNo.ForeColor = System.Drawing.Color.Black
        Me.txtMotherContactNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherContactNo.Location = New System.Drawing.Point(611, 180)
        Me.txtMotherContactNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMotherContactNo.Name = "txtMotherContactNo"
        Me.txtMotherContactNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotherContactNo.PlaceholderText = ""
        Me.txtMotherContactNo.SelectedText = ""
        Me.txtMotherContactNo.Size = New System.Drawing.Size(304, 36)
        Me.txtMotherContactNo.TabIndex = 94
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label12.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(607, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(191, 21)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Mother's Contact Number"
        '
        'txtMotherName
        '
        Me.txtMotherName.BorderColor = System.Drawing.Color.DarkGray
        Me.txtMotherName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMotherName.DefaultText = ""
        Me.txtMotherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMotherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMotherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherName.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtMotherName.ForeColor = System.Drawing.Color.Black
        Me.txtMotherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherName.Location = New System.Drawing.Point(611, 107)
        Me.txtMotherName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMotherName.Name = "txtMotherName"
        Me.txtMotherName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotherName.PlaceholderText = ""
        Me.txtMotherName.SelectedText = ""
        Me.txtMotherName.Size = New System.Drawing.Size(304, 36)
        Me.txtMotherName.TabIndex = 92
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label11.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(607, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 21)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Mother's Name"
        '
        'txtAge
        '
        Me.txtAge.BorderColor = System.Drawing.Color.DarkGray
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAge.DefaultText = ""
        Me.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Location = New System.Drawing.Point(247, 262)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAge.PlaceholderText = ""
        Me.txtAge.SelectedText = ""
        Me.txtAge.Size = New System.Drawing.Size(99, 36)
        Me.txtAge.TabIndex = 90
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label10.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(243, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 21)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Age"
        '
        'datePicker
        '
        Me.datePicker.Checked = True
        Me.datePicker.FillColor = System.Drawing.Color.DimGray
        Me.datePicker.Font = New System.Drawing.Font("Microsoft New Tai Lue", 8.0!)
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datePicker.Location = New System.Drawing.Point(365, 262)
        Me.datePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(222, 36)
        Me.datePicker.TabIndex = 88
        Me.datePicker.Value = New Date(2024, 3, 21, 15, 40, 30, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(361, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 21)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Birth Date"
        '
        'txtContactNo
        '
        Me.txtContactNo.BorderColor = System.Drawing.Color.DarkGray
        Me.txtContactNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactNo.DefaultText = ""
        Me.txtContactNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContactNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContactNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNo.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtContactNo.ForeColor = System.Drawing.Color.Black
        Me.txtContactNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNo.Location = New System.Drawing.Point(611, 32)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactNo.PlaceholderText = ""
        Me.txtContactNo.SelectedText = ""
        Me.txtContactNo.Size = New System.Drawing.Size(304, 36)
        Me.txtContactNo.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label8.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(607, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 21)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Contact Number"
        '
        'cboBrgy
        '
        Me.cboBrgy.FormattingEnabled = True
        Me.cboBrgy.Items.AddRange(New Object() {"Tunasan"})
        Me.cboBrgy.Location = New System.Drawing.Point(247, 187)
        Me.cboBrgy.Margin = New System.Windows.Forms.Padding(2)
        Me.cboBrgy.Name = "cboBrgy"
        Me.cboBrgy.Size = New System.Drawing.Size(340, 29)
        Me.cboBrgy.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(243, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 21)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Barangay"
        '
        'cboCity
        '
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Items.AddRange(New Object() {"Muntinlupa"})
        Me.cboCity.Location = New System.Drawing.Point(247, 109)
        Me.cboCity.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(340, 29)
        Me.cboCity.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label5.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(243, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 21)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "City"
        '
        'txtAddress
        '
        Me.txtAddress.BorderColor = System.Drawing.Color.DarkGray
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(247, 32)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(340, 36)
        Me.txtAddress.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(243, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 21)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Address"
        '
        'txtLastName
        '
        Me.txtLastName.BorderColor = System.Drawing.Color.DarkGray
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(7, 262)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(220, 36)
        Me.txtLastName.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(3, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 21)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Last Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BorderColor = System.Drawing.Color.DarkGray
        Me.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddleName.DefaultText = ""
        Me.txtMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtMiddleName.ForeColor = System.Drawing.Color.Black
        Me.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.Location = New System.Drawing.Point(7, 183)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddleName.PlaceholderText = ""
        Me.txtMiddleName.SelectedText = ""
        Me.txtMiddleName.Size = New System.Drawing.Size(220, 36)
        Me.txtMiddleName.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(3, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColor = System.Drawing.Color.DarkGray
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(7, 105)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(220, 36)
        Me.txtFirstName.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(3, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "First Name"
        '
        'txtStudentNo
        '
        Me.txtStudentNo.BorderColor = System.Drawing.Color.DarkGray
        Me.txtStudentNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentNo.DefaultText = ""
        Me.txtStudentNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentNo.Enabled = False
        Me.txtStudentNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentNo.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtStudentNo.ForeColor = System.Drawing.Color.Black
        Me.txtStudentNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentNo.Location = New System.Drawing.Point(7, 32)
        Me.txtStudentNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentNo.PlaceholderText = ""
        Me.txtStudentNo.SelectedText = ""
        Me.txtStudentNo.Size = New System.Drawing.Size(220, 36)
        Me.txtStudentNo.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(3, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 21)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Student Number"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.cboCD)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.cboDD)
        Me.TabPage2.Controls.Add(Me.cboStatus)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.cboY)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.cboC)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.cboD)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.cboSem)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.cboSY)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(943, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Department/Courses"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label22.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkGray
        Me.Label22.Location = New System.Drawing.Point(429, 287)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(142, 21)
        Me.Label22.TabIndex = 96
        Me.Label22.Text = "Course Description"
        '
        'cboCD
        '
        Me.cboCD.FormattingEnabled = True
        Me.cboCD.Items.AddRange(New Object() {"College of Computer Studies", "College of Criminal Justice"})
        Me.cboCD.Location = New System.Drawing.Point(433, 310)
        Me.cboCD.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCD.Name = "cboCD"
        Me.cboCD.Size = New System.Drawing.Size(340, 29)
        Me.cboCD.TabIndex = 95
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label21.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkGray
        Me.Label21.Location = New System.Drawing.Point(429, 180)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(176, 21)
        Me.Label21.TabIndex = 94
        Me.Label21.Text = "Department Description"
        '
        'cboDD
        '
        Me.cboDD.FormattingEnabled = True
        Me.cboDD.Items.AddRange(New Object() {"Bachelor of Science in Information Technology", "Bachelor of Science in Gunning"})
        Me.cboDD.Location = New System.Drawing.Point(433, 216)
        Me.cboDD.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDD.Name = "cboDD"
        Me.cboDD.Size = New System.Drawing.Size(340, 29)
        Me.cboDD.TabIndex = 93
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Available"})
        Me.cboStatus.Location = New System.Drawing.Point(433, 124)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(340, 29)
        Me.cboStatus.TabIndex = 92
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label20.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(429, 101)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 21)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = "Status"
        '
        'cboY
        '
        Me.cboY.FormattingEnabled = True
        Me.cboY.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cboY.Location = New System.Drawing.Point(433, 37)
        Me.cboY.Margin = New System.Windows.Forms.Padding(2)
        Me.cboY.Name = "cboY"
        Me.cboY.Size = New System.Drawing.Size(340, 29)
        Me.cboY.TabIndex = 90
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label19.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkGray
        Me.Label19.Location = New System.Drawing.Point(429, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 21)
        Me.Label19.TabIndex = 89
        Me.Label19.Text = "Year Level"
        '
        'cboC
        '
        Me.cboC.FormattingEnabled = True
        Me.cboC.Items.AddRange(New Object() {"BSIT", "BSG"})
        Me.cboC.Location = New System.Drawing.Point(10, 310)
        Me.cboC.Margin = New System.Windows.Forms.Padding(2)
        Me.cboC.Name = "cboC"
        Me.cboC.Size = New System.Drawing.Size(340, 29)
        Me.cboC.TabIndex = 88
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label18.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkGray
        Me.Label18.Location = New System.Drawing.Point(6, 287)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 21)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "Course"
        '
        'cboD
        '
        Me.cboD.FormattingEnabled = True
        Me.cboD.Items.AddRange(New Object() {"CCJ", "CCS"})
        Me.cboD.Location = New System.Drawing.Point(10, 216)
        Me.cboD.Margin = New System.Windows.Forms.Padding(2)
        Me.cboD.Name = "cboD"
        Me.cboD.Size = New System.Drawing.Size(340, 29)
        Me.cboD.TabIndex = 86
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label17.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkGray
        Me.Label17.Location = New System.Drawing.Point(6, 193)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 21)
        Me.Label17.TabIndex = 85
        Me.Label17.Text = "Department"
        '
        'cboSem
        '
        Me.cboSem.FormattingEnabled = True
        Me.cboSem.Items.AddRange(New Object() {"1st Semester", "2nd Semester"})
        Me.cboSem.Location = New System.Drawing.Point(10, 124)
        Me.cboSem.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSem.Name = "cboSem"
        Me.cboSem.Size = New System.Drawing.Size(340, 29)
        Me.cboSem.TabIndex = 84
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label16.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGray
        Me.Label16.Location = New System.Drawing.Point(6, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 21)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Semester"
        '
        'cboSY
        '
        Me.cboSY.FormattingEnabled = True
        Me.cboSY.Items.AddRange(New Object() {"2022-2023", "2023-2024"})
        Me.cboSY.Location = New System.Drawing.Point(10, 37)
        Me.cboSY.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(340, 29)
        Me.cboSY.TabIndex = 82
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label15.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGray
        Me.Label15.Location = New System.Drawing.Point(6, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 21)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "School Year"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Maroon
        Me.btnClose.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(351, 347)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnClose.PressedDepth = 40
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 100
        Me.btnClose.Text = "Close"
        '
        'lblStudentNumber
        '
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.Location = New System.Drawing.Point(140, 323)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(19, 21)
        Me.lblStudentNumber.TabIndex = 101
        Me.lblStudentNumber.Text = "1"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label23.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DarkGray
        Me.Label23.Location = New System.Drawing.Point(8, 323)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(126, 21)
        Me.Label23.TabIndex = 102
        Me.Label23.Text = "Student Number"
        '
        'frmStudentInfo_TrackCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(951, 447)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudentInfo_TrackCourses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl1.ResumeLayout(False)
        Me.Manage.ResumeLayout(False)
        Me.Manage.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Manage As TabPage
    Friend WithEvents txtFatherName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFatherContactNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMotherContactNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMotherName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents datePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txtContactNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboBrgy As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboCity As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMiddleName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cboSY As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cboY As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cboC As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cboD As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cboSem As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cboCD As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cboDD As ComboBox
    Friend WithEvents btnEdit1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label23 As Label
    Friend WithEvents lblStudentNumber As Label
End Class
