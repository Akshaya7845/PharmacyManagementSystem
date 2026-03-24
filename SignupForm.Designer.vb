<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(235, 14)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(722, 60)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = " PHARMACY SIGNUP FORM"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(163, 45)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(74, 30)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(405, 38)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(250, 37)
        Me.txtName.TabIndex = 2
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(163, 114)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(69, 30)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(405, 114)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 37)
        Me.txtEmail.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(163, 187)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(112, 30)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(405, 198)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(250, 37)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblRole
        '
        Me.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRole.AutoSize = True
        Me.lblRole.ForeColor = System.Drawing.Color.Black
        Me.lblRole.Location = New System.Drawing.Point(163, 441)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(57, 30)
        Me.lblRole.TabIndex = 7
        Me.lblRole.Text = "Role"
        '
        'cmbRole
        '
        Me.cmbRole.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Items.AddRange(New Object() {"Admin", "User"})
        Me.cmbRole.Location = New System.Drawing.Point(408, 441)
        Me.cmbRole.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(250, 38)
        Me.cmbRole.TabIndex = 8
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegister.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(358, 513)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(140, 40)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(689, 267)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(200, 34)
        Me.chkShowPassword.TabIndex = 10
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(405, 355)
        Me.txtPhone.MaxLength = 10
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(250, 37)
        Me.txtPhone.TabIndex = 11
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(163, 355)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(169, 30)
        Me.lblPhone.TabIndex = 12
        Me.lblPhone.Text = "Phone Number"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(163, 271)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(201, 30)
        Me.lblConfirmPassword.TabIndex = 13
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(405, 271)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(253, 37)
        Me.txtConfirmPassword.TabIndex = 14
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.cmbRole)
        Me.Panel1.Controls.Add(Me.lblPhone)
        Me.Panel1.Controls.Add(Me.lblRole)
        Me.Panel1.Controls.Add(Me.txtConfirmPassword)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.lblConfirmPassword)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.chkShowPassword)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Location = New System.Drawing.Point(128, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(938, 584)
        Me.Panel1.TabIndex = 15
        '
        'SignupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1156, 675)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SignupForm"
        Me.Text = "SignupForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents lblName As Windows.Forms.Label
    Friend WithEvents txtName As Windows.Forms.TextBox
    Friend WithEvents lblEmail As Windows.Forms.Label
    Friend WithEvents txtEmail As Windows.Forms.TextBox
    Friend WithEvents lblPassword As Windows.Forms.Label
    Friend WithEvents txtPassword As Windows.Forms.TextBox
    Friend WithEvents lblRole As Windows.Forms.Label
    Friend WithEvents cmbRole As Windows.Forms.ComboBox
    Friend WithEvents btnRegister As Windows.Forms.Button
    Friend WithEvents chkShowPassword As Windows.Forms.CheckBox
    Friend WithEvents txtPhone As Windows.Forms.TextBox
    Friend WithEvents lblPhone As Windows.Forms.Label
    Friend WithEvents lblConfirmPassword As Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As Windows.Forms.TextBox
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
