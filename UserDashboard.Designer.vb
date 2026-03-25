<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboard
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
        Me.lblWelcomeUser = New System.Windows.Forms.Label()
        Me.btnViewMedicines = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcomeUser
        '
        Me.lblWelcomeUser.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblWelcomeUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWelcomeUser.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeUser.ForeColor = System.Drawing.Color.White
        Me.lblWelcomeUser.Location = New System.Drawing.Point(0, 0)
        Me.lblWelcomeUser.Name = "lblWelcomeUser"
        Me.lblWelcomeUser.Size = New System.Drawing.Size(800, 60)
        Me.lblWelcomeUser.TabIndex = 0
        Me.lblWelcomeUser.Text = "Welcome User"
        Me.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewMedicines
        '
        Me.btnViewMedicines.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnViewMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewMedicines.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewMedicines.ForeColor = System.Drawing.Color.White
        Me.btnViewMedicines.Location = New System.Drawing.Point(12, 102)
        Me.btnViewMedicines.Name = "btnViewMedicines"
        Me.btnViewMedicines.Size = New System.Drawing.Size(226, 55)
        Me.btnViewMedicines.TabIndex = 1
        Me.btnViewMedicines.Text = "View Medicines"
        Me.btnViewMedicines.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblWelcomeUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 60)
        Me.Panel1.TabIndex = 2
        '
        'PanelMenu
        '
        Me.PanelMenu.Controls.Add(Me.btnLogout)
        Me.PanelMenu.Controls.Add(Me.btnHistory)
        Me.PanelMenu.Controls.Add(Me.btnCart)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.btnViewMedicines)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 60)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(256, 390)
        Me.PanelMenu.TabIndex = 3
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 344)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(256, 46)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.Location = New System.Drawing.Point(12, 271)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(226, 55)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnCart
        '
        Me.btnCart.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCart.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCart.ForeColor = System.Drawing.Color.White
        Me.btnCart.Location = New System.Drawing.Point(12, 187)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(226, 55)
        Me.btnCart.TabIndex = 4
        Me.btnCart.Text = "Cart"
        Me.btnCart.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(12, 22)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(226, 55)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'PanelMain
        '
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(256, 60)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(544, 390)
        Me.PanelMain.TabIndex = 4
        '
        'UserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserDashboard"
        Me.Text = "User Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcomeUser As Windows.Forms.Label
    Friend WithEvents btnViewMedicines As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents PanelMenu As Windows.Forms.Panel
    Friend WithEvents btnDashboard As Windows.Forms.Button
    Friend WithEvents btnCart As Windows.Forms.Button
    Friend WithEvents btnLogout As Windows.Forms.Button
    Friend WithEvents btnHistory As Windows.Forms.Button
    Friend WithEvents PanelMain As Windows.Forms.Panel
End Class
