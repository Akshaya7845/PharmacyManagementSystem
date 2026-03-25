<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillForm
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
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.dgvBill = New System.Windows.Forms.DataGridView()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnCard = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnUPI = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(800, 55)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "PHARMACY BILL"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(12, 15)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(103, 20)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "Customer ID:"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(12, 51)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(128, 20)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "Customer Name:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(12, 86)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPaymentMethod.Location = New System.Drawing.Point(502, 24)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(171, 20)
        Me.lblPaymentMethod.TabIndex = 4
        Me.lblPaymentMethod.Text = "Payment: Not Selected"
        '
        'dgvBill
        '
        Me.dgvBill.AllowUserToAddRows = False
        Me.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBill.Location = New System.Drawing.Point(30, 221)
        Me.dgvBill.Name = "dgvBill"
        Me.dgvBill.ReadOnly = True
        Me.dgvBill.RowHeadersVisible = False
        Me.dgvBill.RowHeadersWidth = 62
        Me.dgvBill.RowTemplate.Height = 28
        Me.dgvBill.Size = New System.Drawing.Size(741, 229)
        Me.dgvBill.TabIndex = 5
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(25, 9)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(133, 25)
        Me.LabelTotal.TabIndex = 6
        Me.LabelTotal.Text = "Total Amount:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTotal.Location = New System.Drawing.Point(182, 13)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(27, 20)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "₹0"
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.ForestGreen
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(46, 41)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(102, 48)
        Me.btnProceed.TabIndex = 8
        Me.btnProceed.Text = "Proceed to Payment"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnCard
        '
        Me.btnCard.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCard.ForeColor = System.Drawing.Color.White
        Me.btnCard.Location = New System.Drawing.Point(323, 41)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(85, 48)
        Me.btnCard.TabIndex = 9
        Me.btnCard.Text = "Card"
        Me.btnCard.UseVisualStyleBackColor = False
        Me.btnCard.Visible = False
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.Color.Orange
        Me.btnCash.ForeColor = System.Drawing.Color.White
        Me.btnCash.Location = New System.Drawing.Point(200, 41)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(76, 48)
        Me.btnCash.TabIndex = 10
        Me.btnCash.Text = "Cash"
        Me.btnCash.UseVisualStyleBackColor = False
        Me.btnCash.Visible = False
        '
        'btnUPI
        '
        Me.btnUPI.BackColor = System.Drawing.Color.Purple
        Me.btnUPI.ForeColor = System.Drawing.Color.White
        Me.btnUPI.Location = New System.Drawing.Point(453, 41)
        Me.btnUPI.Name = "btnUPI"
        Me.btnUPI.Size = New System.Drawing.Size(69, 48)
        Me.btnUPI.TabIndex = 11
        Me.btnUPI.Text = "UPI"
        Me.btnUPI.UseVisualStyleBackColor = False
        Me.btnUPI.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Gray
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(570, 41)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(81, 48)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "Print Bill"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.btnProceed)
        Me.Panel1.Controls.Add(Me.LabelTotal)
        Me.Panel1.Controls.Add(Me.btnCard)
        Me.Panel1.Controls.Add(Me.btnCash)
        Me.Panel1.Controls.Add(Me.btnUPI)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 490)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 92)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblUserID)
        Me.Panel2.Controls.Add(Me.lblUserName)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.lblPaymentMethod)
        Me.Panel2.Location = New System.Drawing.Point(30, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 138)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblTitle)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 55)
        Me.Panel3.TabIndex = 15
        '
        'BillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 582)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvBill)
        Me.Name = "BillForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice / Bill"
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents lblUserID As Windows.Forms.Label
    Friend WithEvents lblUserName As Windows.Forms.Label
    Friend WithEvents lblDate As Windows.Forms.Label
    Friend WithEvents lblPaymentMethod As Windows.Forms.Label
    Friend WithEvents dgvBill As Windows.Forms.DataGridView
    Friend WithEvents LabelTotal As Windows.Forms.Label
    Friend WithEvents lblTotal As Windows.Forms.Label
    Friend WithEvents btnProceed As Windows.Forms.Button
    Friend WithEvents btnCard As Windows.Forms.Button
    Friend WithEvents btnCash As Windows.Forms.Button
    Friend WithEvents btnUPI As Windows.Forms.Button
    Friend WithEvents btnPrint As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
End Class
