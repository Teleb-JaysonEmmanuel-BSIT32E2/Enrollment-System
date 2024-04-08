<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.txtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.datePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chckboxActive = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.cboRole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.checkboxShowpassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(204, 68)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(133, 123)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 21
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(212, 194)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(114, 26)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add Picture"
        '
        'txtFirstname
        '
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
        Me.txtFirstname.Location = New System.Drawing.Point(17, 270)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.PlaceholderText = ""
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.Size = New System.Drawing.Size(240, 37)
        Me.txtFirstname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(12, 239)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 26)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "First Name"
        '
        'btnRegister
        '
        Me.btnRegister.BorderRadius = 15
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegister.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(16, 545)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.PressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnRegister.PressedDepth = 40
        Me.btnRegister.Size = New System.Drawing.Size(501, 55)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "Register"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BorderColor = System.Drawing.Color.Empty
        Me.btnBack.BorderRadius = 15
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.Transparent
        Me.btnBack.Font = New System.Drawing.Font("Microsoft New Tai Lue", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnBack.Location = New System.Drawing.Point(12, 10)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.PressedColor = System.Drawing.Color.LightGray
        Me.btnBack.PressedDepth = 100
        Me.btnBack.Size = New System.Drawing.Size(61, 57)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "<"
        Me.btnBack.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'txtLastname
        '
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.DefaultText = ""
        Me.txtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtLastname.ForeColor = System.Drawing.Color.Black
        Me.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastname.Location = New System.Drawing.Point(273, 270)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.PlaceholderText = ""
        Me.txtLastname.SelectedText = ""
        Me.txtLastname.Size = New System.Drawing.Size(240, 37)
        Me.txtLastname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(268, 239)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 26)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Last Name"
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(273, 357)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Padding = New System.Windows.Forms.Padding(0, 0, 27, 0)
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(240, 37)
        Me.txtPassword.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(268, 326)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 26)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(17, 357)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(240, 37)
        Me.txtUsername.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(12, 326)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 26)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(12, 402)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 26)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Birth Date"
        '
        'datePicker
        '
        Me.datePicker.Checked = True
        Me.datePicker.FillColor = System.Drawing.Color.White
        Me.datePicker.Font = New System.Drawing.Font("Microsoft New Tai Lue", 8.0!)
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datePicker.Location = New System.Drawing.Point(17, 432)
        Me.datePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(240, 44)
        Me.datePicker.TabIndex = 40
        Me.datePicker.Value = New Date(2024, 3, 21, 15, 40, 30, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(268, 409)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 26)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Role"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(171, 495)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 26)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Status:"
        '
        'chckboxActive
        '
        Me.chckboxActive.AutoSize = True
        Me.chckboxActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chckboxActive.CheckedState.BorderRadius = 0
        Me.chckboxActive.CheckedState.BorderThickness = 0
        Me.chckboxActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chckboxActive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chckboxActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chckboxActive.Location = New System.Drawing.Point(244, 500)
        Me.chckboxActive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chckboxActive.Name = "chckboxActive"
        Me.chckboxActive.Size = New System.Drawing.Size(18, 17)
        Me.chckboxActive.TabIndex = 45
        Me.chckboxActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chckboxActive.UncheckedState.BorderRadius = 0
        Me.chckboxActive.UncheckedState.BorderThickness = 0
        Me.chckboxActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActive.ForeColor = System.Drawing.Color.DarkGray
        Me.lblActive.Location = New System.Drawing.Point(264, 496)
        Me.lblActive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(66, 26)
        Me.lblActive.TabIndex = 46
        Me.lblActive.Text = "Active"
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
        Me.cboRole.Location = New System.Drawing.Point(272, 433)
        Me.cboRole.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(239, 36)
        Me.cboRole.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft New Tai Lue", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Location = New System.Drawing.Point(109, 11)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(326, 56)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Create Account"
        '
        'checkboxShowpassword
        '
        Me.checkboxShowpassword.AutoSize = True
        Me.checkboxShowpassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkboxShowpassword.CheckedState.BorderRadius = 0
        Me.checkboxShowpassword.CheckedState.BorderThickness = 0
        Me.checkboxShowpassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkboxShowpassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkboxShowpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkboxShowpassword.Location = New System.Drawing.Point(480, 367)
        Me.checkboxShowpassword.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.checkboxShowpassword.Name = "checkboxShowpassword"
        Me.checkboxShowpassword.Size = New System.Drawing.Size(18, 17)
        Me.checkboxShowpassword.TabIndex = 48
        Me.checkboxShowpassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkboxShowpassword.UncheckedState.BorderRadius = 0
        Me.checkboxShowpassword.UncheckedState.BorderThickness = 0
        Me.checkboxShowpassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataMember = ""
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 615)
        Me.Controls.Add(Me.checkboxShowpassword)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.chckboxActive)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboRole)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.datePicker)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents datePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chckboxActive As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents lblActive As Label
    Friend WithEvents cboRole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents checkboxShowpassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
