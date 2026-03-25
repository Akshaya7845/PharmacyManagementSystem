<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseHistoryForm
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
        Me.lblHistoryTitle = New System.Windows.Forms.Label()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHistoryTitle
        '
        Me.lblHistoryTitle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHistoryTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistoryTitle.ForeColor = System.Drawing.Color.Black
        Me.lblHistoryTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHistoryTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblHistoryTitle.Name = "lblHistoryTitle"
        Me.lblHistoryTitle.Size = New System.Drawing.Size(800, 32)
        Me.lblHistoryTitle.TabIndex = 0
        Me.lblHistoryTitle.Text = "Purchase History"
        Me.lblHistoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvHistory
        '
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistory.Location = New System.Drawing.Point(0, 32)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.RowHeadersWidth = 62
        Me.dgvHistory.RowTemplate.Height = 28
        Me.dgvHistory.Size = New System.Drawing.Size(800, 418)
        Me.dgvHistory.TabIndex = 1
        '
        'PurchaseHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvHistory)
        Me.Controls.Add(Me.lblHistoryTitle)
        Me.Name = "PurchaseHistoryForm"
        Me.Text = "PurchaseHistoryForm"
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHistoryTitle As Windows.Forms.Label
    Friend WithEvents dgvHistory As Windows.Forms.DataGridView
End Class
