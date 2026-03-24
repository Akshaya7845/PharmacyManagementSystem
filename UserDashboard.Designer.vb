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
        Me.SuspendLayout()
        '
        'lblWelcomeUser
        '
        Me.lblWelcomeUser.AutoSize = True
        Me.lblWelcomeUser.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeUser.Location = New System.Drawing.Point(275, 19)
        Me.lblWelcomeUser.Name = "lblWelcomeUser"
        Me.lblWelcomeUser.Size = New System.Drawing.Size(234, 45)
        Me.lblWelcomeUser.TabIndex = 0
        Me.lblWelcomeUser.Text = "Welcome User"
        Me.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewMedicines
        '
        Me.btnViewMedicines.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnViewMedicines.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewMedicines.ForeColor = System.Drawing.Color.White
        Me.btnViewMedicines.Location = New System.Drawing.Point(12, 80)
        Me.btnViewMedicines.Name = "btnViewMedicines"
        Me.btnViewMedicines.Size = New System.Drawing.Size(150, 47)
        Me.btnViewMedicines.TabIndex = 1
        Me.btnViewMedicines.Text = "View Medicines"
        Me.btnViewMedicines.UseVisualStyleBackColor = False
        '
        'UserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnViewMedicines)
        Me.Controls.Add(Me.lblWelcomeUser)
        Me.Name = "UserDashboard"
        Me.Text = "User Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeUser As Windows.Forms.Label
    Friend WithEvents btnViewMedicines As Windows.Forms.Button
End Class
