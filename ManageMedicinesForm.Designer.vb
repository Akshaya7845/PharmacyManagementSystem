<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageMedicinesForm
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
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBrowseImage = New System.Windows.Forms.Button()
        Me.txtImage = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblImage = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelGrid = New System.Windows.Forms.Panel()
        Me.dgvMedicines = New System.Windows.Forms.DataGridView()
        Me.panelForm.SuspendLayout()
        Me.panelGrid.SuspendLayout()
        CType(Me.dgvMedicines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelForm
        '
        Me.panelForm.Controls.Add(Me.btnClear)
        Me.panelForm.Controls.Add(Me.btnDelete)
        Me.panelForm.Controls.Add(Me.btnUpdate)
        Me.panelForm.Controls.Add(Me.btnAdd)
        Me.panelForm.Controls.Add(Me.btnBrowseImage)
        Me.panelForm.Controls.Add(Me.txtImage)
        Me.panelForm.Controls.Add(Me.txtQuantity)
        Me.panelForm.Controls.Add(Me.txtPrice)
        Me.panelForm.Controls.Add(Me.lblImage)
        Me.panelForm.Controls.Add(Me.lblQuantity)
        Me.panelForm.Controls.Add(Me.lblPrice)
        Me.panelForm.Controls.Add(Me.txtCategory)
        Me.panelForm.Controls.Add(Me.lblCategory)
        Me.panelForm.Controls.Add(Me.txtName)
        Me.panelForm.Controls.Add(Me.lblName)
        Me.panelForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelForm.Location = New System.Drawing.Point(0, 0)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(308, 450)
        Me.panelForm.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(0, 424)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(308, 26)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(155, 353)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 50)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Orange
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(7, 353)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 50)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Green
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(155, 295)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 52)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBrowseImage.ForeColor = System.Drawing.Color.White
        Me.btnBrowseImage.Location = New System.Drawing.Point(7, 295)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(92, 52)
        Me.btnBrowseImage.TabIndex = 2
        Me.btnBrowseImage.Text = "Browse"
        Me.btnBrowseImage.UseVisualStyleBackColor = False
        '
        'txtImage
        '
        Me.txtImage.Location = New System.Drawing.Point(155, 241)
        Me.txtImage.Name = "txtImage"
        Me.txtImage.Size = New System.Drawing.Size(100, 26)
        Me.txtImage.TabIndex = 2
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(155, 197)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 26)
        Me.txtQuantity.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(155, 145)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtPrice.TabIndex = 2
        '
        'lblImage
        '
        Me.lblImage.AutoSize = True
        Me.lblImage.Location = New System.Drawing.Point(7, 247)
        Me.lblImage.Name = "lblImage"
        Me.lblImage.Size = New System.Drawing.Size(54, 20)
        Me.lblImage.TabIndex = 2
        Me.lblImage.Text = "Image"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(12, 203)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(68, 20)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(12, 151)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(155, 94)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(100, 26)
        Me.txtCategory.TabIndex = 2
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(7, 94)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(73, 20)
        Me.lblCategory.TabIndex = 2
        Me.lblCategory.Text = "Category"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(155, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 34)
        Me.txtName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(3, 47)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(122, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Medicine Name "
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.DarkBlue
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(308, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(301, 45)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Manage Medicines"
        '
        'panelGrid
        '
        Me.panelGrid.Controls.Add(Me.dgvMedicines)
        Me.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelGrid.Location = New System.Drawing.Point(308, 45)
        Me.panelGrid.Name = "panelGrid"
        Me.panelGrid.Size = New System.Drawing.Size(492, 405)
        Me.panelGrid.TabIndex = 2
        '
        'dgvMedicines
        '
        Me.dgvMedicines.AllowUserToAddRows = False
        Me.dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMedicines.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMedicines.Location = New System.Drawing.Point(0, 0)
        Me.dgvMedicines.MultiSelect = False
        Me.dgvMedicines.Name = "dgvMedicines"
        Me.dgvMedicines.ReadOnly = True
        Me.dgvMedicines.RowHeadersWidth = 62
        Me.dgvMedicines.RowTemplate.Height = 28
        Me.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicines.Size = New System.Drawing.Size(492, 405)
        Me.dgvMedicines.TabIndex = 0
        '
        'ManageMedicinesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelGrid)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.panelForm)
        Me.Name = "ManageMedicinesForm"
        Me.Text = "ManageMedicinesForm"
        Me.panelForm.ResumeLayout(False)
        Me.panelForm.PerformLayout()
        Me.panelGrid.ResumeLayout(False)
        CType(Me.dgvMedicines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelForm As Windows.Forms.Panel
    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents lblName As Windows.Forms.Label
    Friend WithEvents lblCategory As Windows.Forms.Label
    Friend WithEvents txtName As Windows.Forms.TextBox
    Friend WithEvents txtPrice As Windows.Forms.TextBox
    Friend WithEvents lblImage As Windows.Forms.Label
    Friend WithEvents lblQuantity As Windows.Forms.Label
    Friend WithEvents lblPrice As Windows.Forms.Label
    Friend WithEvents txtCategory As Windows.Forms.TextBox
    Friend WithEvents txtImage As Windows.Forms.TextBox
    Friend WithEvents txtQuantity As Windows.Forms.TextBox
    Friend WithEvents btnDelete As Windows.Forms.Button
    Friend WithEvents btnUpdate As Windows.Forms.Button
    Friend WithEvents btnAdd As Windows.Forms.Button
    Friend WithEvents btnBrowseImage As Windows.Forms.Button
    Friend WithEvents panelGrid As Windows.Forms.Panel
    Friend WithEvents dgvMedicines As Windows.Forms.DataGridView
    Friend WithEvents btnClear As Windows.Forms.Button
End Class
