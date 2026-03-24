<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnExportPDF = New System.Windows.Forms.Button()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelTop.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(475, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(319, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Admin History Logs"
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"All", "", "Add", "", "Update", "", "Delete", "", "Login", "", "Logout"})
        Me.cmbFilter.Location = New System.Drawing.Point(903, 66)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 28)
        Me.cmbFilter.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(517, 70)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(232, 26)
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.Text = "Search by Admin Name"
        '
        'dtFrom
        '
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFrom.Location = New System.Drawing.Point(57, 25)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(140, 26)
        Me.dtFrom.TabIndex = 3
        '
        'dtTo
        '
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTo.Location = New System.Drawing.Point(59, 59)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(138, 26)
        Me.dtTo.TabIndex = 4
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(844, 109)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(130, 63)
        Me.btnFilter.TabIndex = 5
        Me.btnFilter.Text = "Apply Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(627, 112)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(135, 63)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnExportExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportExcel.Location = New System.Drawing.Point(239, 115)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(135, 63)
        Me.btnExportExcel.TabIndex = 7
        Me.btnExportExcel.Text = "Export Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'btnExportPDF
        '
        Me.btnExportPDF.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnExportPDF.ForeColor = System.Drawing.Color.White
        Me.btnExportPDF.Location = New System.Drawing.Point(427, 115)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(127, 63)
        Me.btnExportPDF.TabIndex = 8
        Me.btnExportPDF.Text = "Export PDF"
        Me.btnExportPDF.UseVisualStyleBackColor = False
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(3, 30)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(46, 20)
        Me.lblFrom.TabIndex = 9
        Me.lblFrom.Text = "From"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(12, 64)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(27, 20)
        Me.lblTo.TabIndex = 10
        Me.lblTo.Text = "To"
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(813, 70)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(58, 20)
        Me.lblFilter.TabIndex = 11
        Me.lblFilter.Text = "Action:"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(388, 76)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(113, 20)
        Me.lblSearch.TabIndex = 12
        Me.lblSearch.Text = "Search Admin:"
        '
        'panelTop
        '
        Me.panelTop.Controls.Add(Me.lblTitle)
        Me.panelTop.Controls.Add(Me.btnFilter)
        Me.panelTop.Controls.Add(Me.btnExportPDF)
        Me.panelTop.Controls.Add(Me.btnRefresh)
        Me.panelTop.Controls.Add(Me.lblFilter)
        Me.panelTop.Controls.Add(Me.btnExportExcel)
        Me.panelTop.Controls.Add(Me.lblSearch)
        Me.panelTop.Controls.Add(Me.lblFrom)
        Me.panelTop.Controls.Add(Me.dtTo)
        Me.panelTop.Controls.Add(Me.cmbFilter)
        Me.panelTop.Controls.Add(Me.lblTo)
        Me.panelTop.Controls.Add(Me.dtFrom)
        Me.panelTop.Controls.Add(Me.txtSearch)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1248, 178)
        Me.panelTop.TabIndex = 13
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToAddRows = False
        Me.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistory.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistory.Location = New System.Drawing.Point(0, 178)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.ReadOnly = True
        Me.dgvHistory.RowHeadersVisible = False
        Me.dgvHistory.RowHeadersWidth = 62
        Me.dgvHistory.RowTemplate.Height = 28
        Me.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistory.Size = New System.Drawing.Size(1248, 406)
        Me.dgvHistory.TabIndex = 14
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1248, 584)
        Me.Controls.Add(Me.dgvHistory)
        Me.Controls.Add(Me.panelTop)
        Me.Name = "HistoryForm"
        Me.Text = "HistoryForm"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents cmbFilter As Windows.Forms.ComboBox
    Friend WithEvents txtSearch As Windows.Forms.TextBox
    Friend WithEvents dtFrom As Windows.Forms.DateTimePicker
    Friend WithEvents dtTo As Windows.Forms.DateTimePicker
    Friend WithEvents btnFilter As Windows.Forms.Button
    Friend WithEvents btnRefresh As Windows.Forms.Button
    Friend WithEvents btnExportExcel As Windows.Forms.Button
    Friend WithEvents btnExportPDF As Windows.Forms.Button
    Friend WithEvents lblFrom As Windows.Forms.Label
    Friend WithEvents lblTo As Windows.Forms.Label
    Friend WithEvents lblFilter As Windows.Forms.Label
    Friend WithEvents lblSearch As Windows.Forms.Label
    Friend WithEvents panelTop As Windows.Forms.Panel
    Friend WithEvents dgvHistory As Windows.Forms.DataGridView
    Friend WithEvents Timer1 As Windows.Forms.Timer
End Class
