<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartForm
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
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Location = New System.Drawing.Point(38, 104)
        Me.dgvCart.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCart.MultiSelect = False
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.ReadOnly = True
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.RowHeadersWidth = 62
        Me.dgvCart.RowTemplate.Height = 28
        Me.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New System.Drawing.Size(1069, 312)
        Me.dgvCart.TabIndex = 0
        '
        'btnIncrease
        '
        Me.btnIncrease.BackColor = System.Drawing.Color.LightGreen
        Me.btnIncrease.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncrease.Location = New System.Drawing.Point(38, 449)
        Me.btnIncrease.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(87, 45)
        Me.btnIncrease.TabIndex = 1
        Me.btnIncrease.Text = "+"
        Me.btnIncrease.UseVisualStyleBackColor = False
        '
        'btnDecrease
        '
        Me.btnDecrease.BackColor = System.Drawing.Color.Coral
        Me.btnDecrease.Location = New System.Drawing.Point(168, 449)
        Me.btnDecrease.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(91, 45)
        Me.btnDecrease.TabIndex = 2
        Me.btnDecrease.Text = "-"
        Me.btnDecrease.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.OrangeRed
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(318, 449)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(124, 45)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.Location = New System.Drawing.Point(489, 449)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 45)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear Cart"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCheckout.Location = New System.Drawing.Point(670, 449)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(136, 45)
        Me.btnCheckout.TabIndex = 5
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(564, 513)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total Amount:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTotal.Location = New System.Drawing.Point(740, 516)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(36, 25)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "₹0"
        '
        'CartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1124, 555)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnDecrease)
        Me.Controls.Add(Me.btnIncrease)
        Me.Controls.Add(Me.dgvCart)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " My Cart"
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCart As Windows.Forms.DataGridView
    Friend WithEvents btnIncrease As Windows.Forms.Button
    Friend WithEvents btnDecrease As Windows.Forms.Button
    Friend WithEvents btnRemove As Windows.Forms.Button
    Friend WithEvents btnClear As Windows.Forms.Button
    Friend WithEvents btnCheckout As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lblTotal As Windows.Forms.Label
End Class
