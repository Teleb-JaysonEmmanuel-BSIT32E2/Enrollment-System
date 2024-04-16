<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class test
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
        Me.cboSubjectStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboSubjectType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtUnits = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubjectDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubjectCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboSubjectStatus
        '
        Me.cboSubjectStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboSubjectStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSubjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubjectStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSubjectStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSubjectStatus.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboSubjectStatus.ForeColor = System.Drawing.Color.Black
        Me.cboSubjectStatus.ItemHeight = 30
        Me.cboSubjectStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboSubjectStatus.Location = New System.Drawing.Point(793, 281)
        Me.cboSubjectStatus.Name = "cboSubjectStatus"
        Me.cboSubjectStatus.Size = New System.Drawing.Size(195, 36)
        Me.cboSubjectStatus.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label8.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(789, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 21)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Status"
        '
        'cboSubjectType
        '
        Me.cboSubjectType.BackColor = System.Drawing.Color.Transparent
        Me.cboSubjectType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSubjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubjectType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSubjectType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSubjectType.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.cboSubjectType.ForeColor = System.Drawing.Color.Black
        Me.cboSubjectType.ItemHeight = 30
        Me.cboSubjectType.Items.AddRange(New Object() {"Major", "Minor"})
        Me.cboSubjectType.Location = New System.Drawing.Point(81, 341)
        Me.cboSubjectType.Name = "cboSubjectType"
        Me.cboSubjectType.Size = New System.Drawing.Size(248, 36)
        Me.cboSubjectType.TabIndex = 21
        '
        'txtUnits
        '
        Me.txtUnits.BorderColor = System.Drawing.Color.DarkGray
        Me.txtUnits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnits.DefaultText = ""
        Me.txtUnits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUnits.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUnits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnits.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtUnits.ForeColor = System.Drawing.Color.Black
        Me.txtUnits.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnits.Location = New System.Drawing.Point(793, 345)
        Me.txtUnits.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUnits.PlaceholderText = ""
        Me.txtUnits.SelectedText = ""
        Me.txtUnits.Size = New System.Drawing.Size(73, 30)
        Me.txtUnits.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(77, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 21)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Subject Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(789, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 21)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Units"
        '
        'txtSubjectDescription
        '
        Me.txtSubjectDescription.BorderColor = System.Drawing.Color.DarkGray
        Me.txtSubjectDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubjectDescription.DefaultText = ""
        Me.txtSubjectDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubjectDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubjectDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubjectDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubjectDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubjectDescription.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtSubjectDescription.ForeColor = System.Drawing.Color.Black
        Me.txtSubjectDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubjectDescription.Location = New System.Drawing.Point(371, 283)
        Me.txtSubjectDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSubjectDescription.Name = "txtSubjectDescription"
        Me.txtSubjectDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubjectDescription.PlaceholderText = ""
        Me.txtSubjectDescription.SelectedText = ""
        Me.txtSubjectDescription.Size = New System.Drawing.Size(378, 92)
        Me.txtSubjectDescription.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(367, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Subject Desciption"
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.BorderColor = System.Drawing.Color.DarkGray
        Me.txtSubjectCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubjectCode.DefaultText = ""
        Me.txtSubjectCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubjectCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubjectCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubjectCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubjectCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubjectCode.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.txtSubjectCode.ForeColor = System.Drawing.Color.Black
        Me.txtSubjectCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubjectCode.Location = New System.Drawing.Point(81, 283)
        Me.txtSubjectCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubjectCode.PlaceholderText = ""
        Me.txtSubjectCode.SelectedText = ""
        Me.txtSubjectCode.Size = New System.Drawing.Size(248, 30)
        Me.txtSubjectCode.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(77, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Subject Code"
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1065, 635)
        Me.Controls.Add(Me.cboSubjectStatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboSubjectType)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSubjectDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSubjectCode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboSubjectStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboSubjectType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtUnits As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubjectDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSubjectCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
