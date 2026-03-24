<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.btnViewRequests = New System.Windows.Forms.Button()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.panelSidebar = New System.Windows.Forms.Panel()
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLogs = New System.Windows.Forms.Button()
        Me.btnManageMedicines = New System.Windows.Forms.Button()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.TextBox()
        Me.panelMain.SuspendLayout()
        Me.panelSidebar.SuspendLayout()
        Me.panelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnViewRequests
        '
        Me.btnViewRequests.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewRequests.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnViewRequests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewRequests.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRequests.ForeColor = System.Drawing.Color.White
        Me.btnViewRequests.Location = New System.Drawing.Point(6, 84)
        Me.btnViewRequests.Name = "btnViewRequests"
        Me.btnViewRequests.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnViewRequests.Size = New System.Drawing.Size(188, 52)
        Me.btnViewRequests.TabIndex = 1
        Me.btnViewRequests.Text = "View Requests"
        Me.btnViewRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewRequests.UseVisualStyleBackColor = False
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.MainPanel)
        Me.panelMain.Controls.Add(Me.panelSidebar)
        Me.panelMain.Controls.Add(Me.panelHeader)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(800, 450)
        Me.panelMain.TabIndex = 2
        '
        'MainPanel
        '
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(200, 47)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(600, 403)
        Me.MainPanel.TabIndex = 4
        '
        'panelSidebar
        '
        Me.panelSidebar.BackColor = System.Drawing.Color.SteelBlue
        Me.panelSidebar.Controls.Add(Me.btnAddAdmin)
        Me.panelSidebar.Controls.Add(Me.btnDashboard)
        Me.panelSidebar.Controls.Add(Me.btnLogout)
        Me.panelSidebar.Controls.Add(Me.btnLogs)
        Me.panelSidebar.Controls.Add(Me.btnManageMedicines)
        Me.panelSidebar.Controls.Add(Me.btnViewRequests)
        Me.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSidebar.Location = New System.Drawing.Point(0, 47)
        Me.panelSidebar.Name = "panelSidebar"
        Me.panelSidebar.Size = New System.Drawing.Size(200, 403)
        Me.panelSidebar.TabIndex = 3
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAdmin.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAddAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAdmin.Location = New System.Drawing.Point(6, 204)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAddAdmin.Size = New System.Drawing.Size(188, 48)
        Me.btnAddAdmin.TabIndex = 0
        Me.btnAddAdmin.Text = "Add Admin"
        Me.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAdmin.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDashboard.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(6, 24)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(188, 54)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(12, 342)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(182, 49)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnLogs
        '
        Me.btnLogs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogs.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogs.ForeColor = System.Drawing.Color.White
        Me.btnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogs.Location = New System.Drawing.Point(6, 258)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogs.Size = New System.Drawing.Size(188, 52)
        Me.btnLogs.TabIndex = 0
        Me.btnLogs.Text = "History Logs"
        Me.btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogs.UseVisualStyleBackColor = False
        '
        'btnManageMedicines
        '
        Me.btnManageMedicines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManageMedicines.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnManageMedicines.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageMedicines.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageMedicines.ForeColor = System.Drawing.Color.White
        Me.btnManageMedicines.Location = New System.Drawing.Point(6, 142)
        Me.btnManageMedicines.Name = "btnManageMedicines"
        Me.btnManageMedicines.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnManageMedicines.Size = New System.Drawing.Size(188, 56)
        Me.btnManageMedicines.TabIndex = 0
        Me.btnManageMedicines.Text = "Manage Medicines"
        Me.btnManageMedicines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageMedicines.UseVisualStyleBackColor = False
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.DodgerBlue
        Me.panelHeader.Controls.Add(Me.lblWelcome)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(800, 47)
        Me.panelHeader.TabIndex = 2
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(0, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(800, 45)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome Admin"
        Me.lblWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelMain)
        Me.Name = "AdminDashboard"
        Me.Text = "Admin Dashboard"
        Me.panelMain.ResumeLayout(False)
        Me.panelSidebar.ResumeLayout(False)
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnViewRequests As Windows.Forms.Button
    Friend WithEvents panelMain As Windows.Forms.Panel
    Friend WithEvents panelHeader As Windows.Forms.Panel
    Friend WithEvents lblWelcome As Windows.Forms.TextBox
    Friend WithEvents panelSidebar As Windows.Forms.Panel
    Friend WithEvents MainPanel As Windows.Forms.Panel
    Friend WithEvents btnManageMedicines As Windows.Forms.Button
    Friend WithEvents btnLogout As Windows.Forms.Button
    Friend WithEvents btnLogs As Windows.Forms.Button
    Friend WithEvents btnDashboard As Windows.Forms.Button
    Friend WithEvents btnAddAdmin As Windows.Forms.Button
End Class
