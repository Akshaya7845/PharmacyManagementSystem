<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDashboardHome
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.pnlOrders = New System.Windows.Forms.Panel()
        Me.lblOrdersCount = New System.Windows.Forms.Label()
        Me.lblOrdersTitle = New System.Windows.Forms.Label()
        Me.pnlSpent = New System.Windows.Forms.Panel()
        Me.lblSpentAmount = New System.Windows.Forms.Label()
        Me.lblSpentTitle = New System.Windows.Forms.Label()
        Me.pnlLastPurchase = New System.Windows.Forms.Panel()
        Me.lblLastDate = New System.Windows.Forms.Label()
        Me.lblLastTitle = New System.Windows.Forms.Label()
        Me.pnlOrders.SuspendLayout()
        Me.pnlSpent.SuspendLayout()
        Me.pnlLastPurchase.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(0, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1257, 42)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome!"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.Location = New System.Drawing.Point(0, 42)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(1257, 37)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Here is your activity summary"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlOrders
        '
        Me.pnlOrders.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlOrders.Controls.Add(Me.lblOrdersCount)
        Me.pnlOrders.Controls.Add(Me.lblOrdersTitle)
        Me.pnlOrders.Location = New System.Drawing.Point(12, 199)
        Me.pnlOrders.Name = "pnlOrders"
        Me.pnlOrders.Size = New System.Drawing.Size(280, 200)
        Me.pnlOrders.TabIndex = 2
        '
        'lblOrdersCount
        '
        Me.lblOrdersCount.AutoSize = True
        Me.lblOrdersCount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdersCount.Location = New System.Drawing.Point(105, 125)
        Me.lblOrdersCount.Name = "lblOrdersCount"
        Me.lblOrdersCount.Size = New System.Drawing.Size(24, 28)
        Me.lblOrdersCount.TabIndex = 5
        Me.lblOrdersCount.Text = "0"
        '
        'lblOrdersTitle
        '
        Me.lblOrdersTitle.AutoSize = True
        Me.lblOrdersTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdersTitle.Location = New System.Drawing.Point(61, 46)
        Me.lblOrdersTitle.Name = "lblOrdersTitle"
        Me.lblOrdersTitle.Size = New System.Drawing.Size(128, 28)
        Me.lblOrdersTitle.TabIndex = 5
        Me.lblOrdersTitle.Text = "Total Orders"
        '
        'pnlSpent
        '
        Me.pnlSpent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSpent.Controls.Add(Me.lblSpentAmount)
        Me.pnlSpent.Controls.Add(Me.lblSpentTitle)
        Me.pnlSpent.Location = New System.Drawing.Point(402, 199)
        Me.pnlSpent.Name = "pnlSpent"
        Me.pnlSpent.Size = New System.Drawing.Size(280, 200)
        Me.pnlSpent.TabIndex = 3
        '
        'lblSpentAmount
        '
        Me.lblSpentAmount.AutoSize = True
        Me.lblSpentAmount.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpentAmount.Location = New System.Drawing.Point(102, 131)
        Me.lblSpentAmount.Name = "lblSpentAmount"
        Me.lblSpentAmount.Size = New System.Drawing.Size(50, 21)
        Me.lblSpentAmount.TabIndex = 1
        Me.lblSpentAmount.Text = "₹0.00"
        Me.lblSpentAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSpentTitle
        '
        Me.lblSpentTitle.AutoSize = True
        Me.lblSpentTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpentTitle.Location = New System.Drawing.Point(70, 46)
        Me.lblSpentTitle.Name = "lblSpentTitle"
        Me.lblSpentTitle.Size = New System.Drawing.Size(119, 28)
        Me.lblSpentTitle.TabIndex = 0
        Me.lblSpentTitle.Text = "Total Spent"
        Me.lblSpentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLastPurchase
        '
        Me.pnlLastPurchase.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlLastPurchase.Controls.Add(Me.lblLastDate)
        Me.pnlLastPurchase.Controls.Add(Me.lblLastTitle)
        Me.pnlLastPurchase.Location = New System.Drawing.Point(849, 199)
        Me.pnlLastPurchase.Name = "pnlLastPurchase"
        Me.pnlLastPurchase.Size = New System.Drawing.Size(280, 200)
        Me.pnlLastPurchase.TabIndex = 4
        '
        'lblLastDate
        '
        Me.lblLastDate.AutoSize = True
        Me.lblLastDate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastDate.Location = New System.Drawing.Point(130, 124)
        Me.lblLastDate.Name = "lblLastDate"
        Me.lblLastDate.Size = New System.Drawing.Size(20, 28)
        Me.lblLastDate.TabIndex = 1
        Me.lblLastDate.Text = "-"
        Me.lblLastDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastTitle
        '
        Me.lblLastTitle.AutoSize = True
        Me.lblLastTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastTitle.Location = New System.Drawing.Point(70, 46)
        Me.lblLastTitle.Name = "lblLastTitle"
        Me.lblLastTitle.Size = New System.Drawing.Size(141, 28)
        Me.lblLastTitle.TabIndex = 0
        Me.lblLastTitle.Text = "Last Purchase"
        Me.lblLastTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserDashboardHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1257, 634)
        Me.Controls.Add(Me.pnlLastPurchase)
        Me.Controls.Add(Me.pnlSpent)
        Me.Controls.Add(Me.pnlOrders)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "UserDashboardHome"
        Me.Text = "Dashboard"
        Me.pnlOrders.ResumeLayout(False)
        Me.pnlOrders.PerformLayout()
        Me.pnlSpent.ResumeLayout(False)
        Me.pnlSpent.PerformLayout()
        Me.pnlLastPurchase.ResumeLayout(False)
        Me.pnlLastPurchase.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcome As Windows.Forms.Label
    Friend WithEvents lblSubtitle As Windows.Forms.Label
    Friend WithEvents pnlOrders As Windows.Forms.Panel
    Friend WithEvents pnlSpent As Windows.Forms.Panel
    Friend WithEvents pnlLastPurchase As Windows.Forms.Panel
    Friend WithEvents lblOrdersTitle As Windows.Forms.Label
    Friend WithEvents lblOrdersCount As Windows.Forms.Label
    Friend WithEvents lblSpentAmount As Windows.Forms.Label
    Friend WithEvents lblSpentTitle As Windows.Forms.Label
    Friend WithEvents lblLastTitle As Windows.Forms.Label
    Friend WithEvents lblLastDate As Windows.Forms.Label
End Class
