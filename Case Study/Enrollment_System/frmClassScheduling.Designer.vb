<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClassScheduling
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cboTeacher = New System.Windows.Forms.ComboBox()
        Me.cboType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtUnits = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubjCode = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboDept = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboGrade = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSY = New System.Windows.Forms.ComboBox()
        Me.lblClassNo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.cboStatus)
        Me.Guna2GroupBox1.Controls.Add(Me.cboTeacher)
        Me.Guna2GroupBox1.Controls.Add(Me.cboType)
        Me.Guna2GroupBox1.Controls.Add(Me.txtDescription)
        Me.Guna2GroupBox1.Controls.Add(Me.Label11)
        Me.Guna2GroupBox1.Controls.Add(Me.Label15)
        Me.Guna2GroupBox1.Controls.Add(Me.Label13)
        Me.Guna2GroupBox1.Controls.Add(Me.txtUnits)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSubjCode)
        Me.Guna2GroupBox1.Controls.Add(Me.Label12)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.cboSection)
        Me.Guna2GroupBox1.Controls.Add(Me.Label10)
        Me.Guna2GroupBox1.Controls.Add(Me.cboDept)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.cboCourse)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.cboGrade)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.cboSem)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.cboSY)
        Me.Guna2GroupBox1.Controls.Add(Me.lblClassNo)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1189, 305)
        Me.Guna2GroupBox1.TabIndex = 26
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Enabled = False
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.ItemHeight = 26
        Me.cboStatus.Items.AddRange(New Object() {"Available", "Not Available"})
        Me.cboStatus.Location = New System.Drawing.Point(845, 252)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(329, 34)
        Me.cboStatus.TabIndex = 81
        '
        'cboTeacher
        '
        Me.cboTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeacher.Enabled = False
        Me.cboTeacher.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboTeacher.FormattingEnabled = True
        Me.cboTeacher.ItemHeight = 26
        Me.cboTeacher.Location = New System.Drawing.Point(501, 90)
        Me.cboTeacher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTeacher.Name = "cboTeacher"
        Me.cboTeacher.Size = New System.Drawing.Size(295, 34)
        Me.cboTeacher.TabIndex = 80
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.Transparent
        Me.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Enabled = False
        Me.cboType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboType.ItemHeight = 30
        Me.cboType.Items.AddRange(New Object() {"Major", "Minor"})
        Me.cboType.Location = New System.Drawing.Point(676, 252)
        Me.cboType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 36)
        Me.cboType.TabIndex = 78
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtDescription.Location = New System.Drawing.Point(845, 90)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(329, 110)
        Me.txtDescription.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label11.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(671, 224)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 26)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label15.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGray
        Me.Label15.Location = New System.Drawing.Point(841, 224)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 26)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Status"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label13.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(497, 224)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 26)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Units"
        '
        'txtUnits
        '
        Me.txtUnits.BorderColor = System.Drawing.Color.Black
        Me.txtUnits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnits.DefaultText = ""
        Me.txtUnits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUnits.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUnits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnits.Enabled = False
        Me.txtUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnits.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtUnits.ForeColor = System.Drawing.Color.Black
        Me.txtUnits.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnits.Location = New System.Drawing.Point(503, 254)
        Me.txtUnits.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUnits.PlaceholderText = ""
        Me.txtUnits.SelectedText = ""
        Me.txtUnits.Size = New System.Drawing.Size(123, 34)
        Me.txtUnits.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(841, 60)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 26)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Description"
        '
        'txtSubjCode
        '
        Me.txtSubjCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSubjCode.Enabled = False
        Me.txtSubjCode.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtSubjCode.FormattingEnabled = True
        Me.txtSubjCode.ItemHeight = 26
        Me.txtSubjCode.Location = New System.Drawing.Point(503, 166)
        Me.txtSubjCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSubjCode.Name = "txtSubjCode"
        Me.txtSubjCode.Size = New System.Drawing.Size(295, 34)
        Me.txtSubjCode.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label12.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(497, 137)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 26)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Subject Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(497, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 26)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Professor"
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.Enabled = False
        Me.cboSection.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.ItemHeight = 26
        Me.cboSection.Location = New System.Drawing.Point(237, 254)
        Me.cboSection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(219, 34)
        Me.cboSection.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label10.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(232, 224)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 26)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Section"
        '
        'cboDept
        '
        Me.cboDept.Enabled = False
        Me.cboDept.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.ItemHeight = 26
        Me.cboDept.Location = New System.Drawing.Point(237, 166)
        Me.cboDept.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(219, 34)
        Me.cboDept.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(232, 137)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Department"
        '
        'cboCourse
        '
        Me.cboCourse.Enabled = False
        Me.cboCourse.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.ItemHeight = 26
        Me.cboCourse.Location = New System.Drawing.Point(237, 90)
        Me.cboCourse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(219, 34)
        Me.cboCourse.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(232, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 26)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Course"
        '
        'cboGrade
        '
        Me.cboGrade.Enabled = False
        Me.cboGrade.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.ItemHeight = 26
        Me.cboGrade.Location = New System.Drawing.Point(15, 254)
        Me.cboGrade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(173, 34)
        Me.cboGrade.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(9, 224)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 26)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Grade Level"
        '
        'cboSem
        '
        Me.cboSem.Enabled = False
        Me.cboSem.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboSem.FormattingEnabled = True
        Me.cboSem.ItemHeight = 26
        Me.cboSem.Location = New System.Drawing.Point(15, 166)
        Me.cboSem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSem.Name = "cboSem"
        Me.cboSem.Size = New System.Drawing.Size(173, 34)
        Me.cboSem.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(8, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 26)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Semester"
        '
        'cboSY
        '
        Me.cboSY.Enabled = False
        Me.cboSY.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboSY.FormattingEnabled = True
        Me.cboSY.ItemHeight = 26
        Me.cboSY.Location = New System.Drawing.Point(15, 90)
        Me.cboSY.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(173, 34)
        Me.cboSY.TabIndex = 50
        '
        'lblClassNo
        '
        Me.lblClassNo.AutoSize = True
        Me.lblClassNo.BackColor = System.Drawing.Color.Transparent
        Me.lblClassNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblClassNo.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassNo.ForeColor = System.Drawing.Color.White
        Me.lblClassNo.Location = New System.Drawing.Point(1037, 11)
        Me.lblClassNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClassNo.Name = "lblClassNo"
        Me.lblClassNo.Size = New System.Drawing.Size(91, 27)
        Me.lblClassNo.TabIndex = 49
        Me.lblClassNo.Text = "CS-0001"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(841, 11)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 27)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Class Schedule No:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label8.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 27)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Class Scheduling"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label5.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(8, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 26)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "School Year"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.ListView1)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(9, 319)
        Me.Guna2GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1189, 305)
        Me.Guna2GroupBox2.TabIndex = 27
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Enabled = False
        Me.ListView1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(9, 10)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1167, 285)
        Me.ListView1.TabIndex = 23
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Subject Code"
        Me.ColumnHeader13.Width = 150
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Course Title"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Units"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Teacher"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.Maroon
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(12, 638)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnAdd.PressedDepth = 40
        Me.btnAdd.Size = New System.Drawing.Size(197, 65)
        Me.btnAdd.TabIndex = 41
        Me.btnAdd.Text = "Add  to List"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.Enabled = False
        Me.btnDelete.FillColor = System.Drawing.Color.Maroon
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(231, 638)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnDelete.PressedDepth = 40
        Me.btnDelete.Size = New System.Drawing.Size(219, 65)
        Me.btnDelete.TabIndex = 42
        Me.btnDelete.Text = "Remove to List"
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
        Me.btnSave.Location = New System.Drawing.Point(469, 638)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnSave.PressedDepth = 40
        Me.btnSave.Size = New System.Drawing.Size(219, 65)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save Schedule"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmClassScheduling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 724)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmClassScheduling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblClassNo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboGrade As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboSem As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSY As ComboBox
    Friend WithEvents cboSection As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboDept As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSubjCode As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtUnits As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cboType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboTeacher As ComboBox
    Friend WithEvents ColumnHeader13 As ColumnHeader
End Class
