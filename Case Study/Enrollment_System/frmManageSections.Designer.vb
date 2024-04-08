<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageSections
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
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2ComboBox5 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox4 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboRole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.ListView1)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(6, 219)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(951, 288)
        Me.Guna2GroupBox2.TabIndex = 23
        Me.Guna2GroupBox2.Text = "CLASS SECTIONS"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(10, 48)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(930, 230)
        Me.ListView1.TabIndex = 23
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SectionName"
        Me.ColumnHeader1.Width = 130
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "GradeLevel"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "S.Y."
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Semester"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Track"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Strand"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Desciption"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ClassAdviser"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 150
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2ComboBox5)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2ComboBox4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2ComboBox3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2ComboBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.cboRole)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.txtFirstname)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(951, 207)
        Me.Guna2GroupBox1.TabIndex = 24
        Me.Guna2GroupBox1.Text = "SUBJECT INFORMATION"
        '
        'Guna2ComboBox5
        '
        Me.Guna2ComboBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox5.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox5.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.Guna2ComboBox5.ForeColor = System.Drawing.Color.Black
        Me.Guna2ComboBox5.ItemHeight = 30
        Me.Guna2ComboBox5.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.Guna2ComboBox5.Location = New System.Drawing.Point(717, 76)
        Me.Guna2ComboBox5.Name = "Guna2ComboBox5"
        Me.Guna2ComboBox5.Size = New System.Drawing.Size(223, 36)
        Me.Guna2ComboBox5.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(713, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 21)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Class Adviser"
        '
        'Guna2ComboBox4
        '
        Me.Guna2ComboBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox4.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.Guna2ComboBox4.ForeColor = System.Drawing.Color.Black
        Me.Guna2ComboBox4.ItemHeight = 30
        Me.Guna2ComboBox4.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.Guna2ComboBox4.Location = New System.Drawing.Point(474, 143)
        Me.Guna2ComboBox4.Name = "Guna2ComboBox4"
        Me.Guna2ComboBox4.Size = New System.Drawing.Size(230, 36)
        Me.Guna2ComboBox4.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label5.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(470, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 21)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Strand"
        '
        'Guna2ComboBox3
        '
        Me.Guna2ComboBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.Guna2ComboBox3.ForeColor = System.Drawing.Color.Black
        Me.Guna2ComboBox3.ItemHeight = 30
        Me.Guna2ComboBox3.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.Guna2ComboBox3.Location = New System.Drawing.Point(254, 143)
        Me.Guna2ComboBox3.Name = "Guna2ComboBox3"
        Me.Guna2ComboBox3.Size = New System.Drawing.Size(208, 36)
        Me.Guna2ComboBox3.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(250, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Track"
        '
        'Guna2ComboBox2
        '
        Me.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.Guna2ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2ComboBox2.ItemHeight = 30
        Me.Guna2ComboBox2.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.Guna2ComboBox2.Location = New System.Drawing.Point(12, 143)
        Me.Guna2ComboBox2.Name = "Guna2ComboBox2"
        Me.Guna2ComboBox2.Size = New System.Drawing.Size(230, 36)
        Me.Guna2ComboBox2.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(8, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Semester"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(474, 76)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(230, 36)
        Me.Guna2ComboBox1.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(470, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "School Year"
        '
        'cboRole
        '
        Me.cboRole.BackColor = System.Drawing.Color.Transparent
        Me.cboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboRole.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboRole.ForeColor = System.Drawing.Color.Black
        Me.cboRole.ItemHeight = 30
        Me.cboRole.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.cboRole.Location = New System.Drawing.Point(254, 76)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(208, 36)
        Me.cboRole.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(250, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Grade Level"
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderColor = System.Drawing.Color.DarkGray
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.DefaultText = ""
        Me.txtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtFirstname.ForeColor = System.Drawing.Color.Black
        Me.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Location = New System.Drawing.Point(12, 77)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.PlaceholderText = ""
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.Size = New System.Drawing.Size(230, 36)
        Me.txtFirstname.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(8, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Class Section"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Guna2Button4.Location = New System.Drawing.Point(842, 528)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2Button4.PressedDepth = 40
        Me.Guna2Button4.Size = New System.Drawing.Size(104, 40)
        Me.Guna2Button4.TabIndex = 31
        Me.Guna2Button4.Text = "Back"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Guna2Button3.Location = New System.Drawing.Point(721, 528)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2Button3.PressedDepth = 40
        Me.Guna2Button3.Size = New System.Drawing.Size(104, 40)
        Me.Guna2Button3.TabIndex = 30
        Me.Guna2Button3.Text = "Edit"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Guna2Button2.Location = New System.Drawing.Point(144, 528)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2Button2.PressedDepth = 40
        Me.Guna2Button2.Size = New System.Drawing.Size(104, 40)
        Me.Guna2Button2.TabIndex = 29
        Me.Guna2Button2.Text = "New"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(21, 528)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2Button1.PressedDepth = 40
        Me.Guna2Button1.Size = New System.Drawing.Size(104, 40)
        Me.Guna2Button1.TabIndex = 28
        Me.Guna2Button1.Text = "Save"
        '
        'frmManageSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 588)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageSections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cboRole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2ComboBox5 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2ComboBox4 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2ComboBox3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2ComboBox2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
