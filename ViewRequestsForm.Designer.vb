<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewRequestsForm
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
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.dgvRequests = New System.Windows.Forms.DataGridView()
        Me.panelTop.SuspendLayout()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.Controls.Add(Me.btnReject)
        Me.panelTop.Controls.Add(Me.btnApprove)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(800, 60)
        Me.panelTop.TabIndex = 0
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.Red
        Me.btnReject.ForeColor = System.Drawing.Color.White
        Me.btnReject.Location = New System.Drawing.Point(678, 3)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(110, 51)
        Me.btnReject.TabIndex = 1
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'btnApprove
        '
        Me.btnApprove.AutoEllipsis = True
        Me.btnApprove.BackColor = System.Drawing.Color.Green
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(529, 1)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(115, 54)
        Me.btnApprove.TabIndex = 0
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'dgvRequests
        '
        Me.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRequests.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRequests.Location = New System.Drawing.Point(0, 60)
        Me.dgvRequests.MultiSelect = False
        Me.dgvRequests.Name = "dgvRequests"
        Me.dgvRequests.ReadOnly = True
        Me.dgvRequests.RowHeadersWidth = 62
        Me.dgvRequests.RowTemplate.Height = 28
        Me.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequests.Size = New System.Drawing.Size(800, 390)
        Me.dgvRequests.TabIndex = 1
        '
        'ViewRequestsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvRequests)
        Me.Controls.Add(Me.panelTop)
        Me.Name = "ViewRequestsForm"
        Me.Text = "ViewRequestsForm"
        Me.panelTop.ResumeLayout(False)
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Windows.Forms.Panel
    Friend WithEvents dgvRequests As Windows.Forms.DataGridView
    Friend WithEvents btnReject As Windows.Forms.Button
    Friend WithEvents btnApprove As Windows.Forms.Button
End Class
