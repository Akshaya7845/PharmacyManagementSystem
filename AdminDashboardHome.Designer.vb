<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboardHome
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelRevenue = New System.Windows.Forms.Panel()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.panelOrders = New System.Windows.Forms.Panel()
        Me.lblOrders = New System.Windows.Forms.Label()
        Me.panelMedicines = New System.Windows.Forms.Panel()
        Me.lblMedicines = New System.Windows.Forms.Label()
        Me.panelLowStock = New System.Windows.Forms.Panel()
        Me.lblLowStock = New System.Windows.Forms.Label()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.chartSales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartMedicines = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblPrediction = New System.Windows.Forms.Label()
        Me.chartLowStock = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartPayment = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblRevenueTitle = New System.Windows.Forms.Label()
        Me.lblOrdersTitle = New System.Windows.Forms.Label()
        Me.lblMedicinesTitle = New System.Windows.Forms.Label()
        Me.lblLowStockTitle = New System.Windows.Forms.Label()
        Me.panelRevenue.SuspendLayout()
        Me.panelOrders.SuspendLayout()
        Me.panelMedicines.SuspendLayout()
        Me.panelLowStock.SuspendLayout()
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartMedicines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartLowStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1771, 50)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Pharmacy Insights Dashboard"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelRevenue
        '
        Me.panelRevenue.BackColor = System.Drawing.Color.LightGreen
        Me.panelRevenue.Controls.Add(Me.lblRevenueTitle)
        Me.panelRevenue.Controls.Add(Me.lblRevenue)
        Me.panelRevenue.Location = New System.Drawing.Point(50, 80)
        Me.panelRevenue.Name = "panelRevenue"
        Me.panelRevenue.Size = New System.Drawing.Size(376, 100)
        Me.panelRevenue.TabIndex = 1
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.Location = New System.Drawing.Point(195, 38)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(49, 38)
        Me.lblRevenue.TabIndex = 2
        Me.lblRevenue.Text = "₹0"
        '
        'panelOrders
        '
        Me.panelOrders.BackColor = System.Drawing.Color.PowderBlue
        Me.panelOrders.Controls.Add(Me.lblOrdersTitle)
        Me.panelOrders.Controls.Add(Me.lblOrders)
        Me.panelOrders.Location = New System.Drawing.Point(501, 80)
        Me.panelOrders.Name = "panelOrders"
        Me.panelOrders.Size = New System.Drawing.Size(354, 100)
        Me.panelOrders.TabIndex = 2
        '
        'lblOrders
        '
        Me.lblOrders.AutoSize = True
        Me.lblOrders.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrders.Location = New System.Drawing.Point(163, 38)
        Me.lblOrders.Name = "lblOrders"
        Me.lblOrders.Size = New System.Drawing.Size(49, 38)
        Me.lblOrders.TabIndex = 0
        Me.lblOrders.Text = "₹0"
        '
        'panelMedicines
        '
        Me.panelMedicines.BackColor = System.Drawing.Color.MistyRose
        Me.panelMedicines.Controls.Add(Me.lblMedicinesTitle)
        Me.panelMedicines.Controls.Add(Me.lblMedicines)
        Me.panelMedicines.Location = New System.Drawing.Point(924, 80)
        Me.panelMedicines.Name = "panelMedicines"
        Me.panelMedicines.Size = New System.Drawing.Size(364, 100)
        Me.panelMedicines.TabIndex = 3
        '
        'lblMedicines
        '
        Me.lblMedicines.AutoSize = True
        Me.lblMedicines.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicines.Location = New System.Drawing.Point(176, 38)
        Me.lblMedicines.Name = "lblMedicines"
        Me.lblMedicines.Size = New System.Drawing.Size(49, 38)
        Me.lblMedicines.TabIndex = 0
        Me.lblMedicines.Text = "₹0"
        '
        'panelLowStock
        '
        Me.panelLowStock.BackColor = System.Drawing.Color.Tomato
        Me.panelLowStock.Controls.Add(Me.lblLowStockTitle)
        Me.panelLowStock.Controls.Add(Me.lblLowStock)
        Me.panelLowStock.Location = New System.Drawing.Point(1356, 80)
        Me.panelLowStock.Name = "panelLowStock"
        Me.panelLowStock.Size = New System.Drawing.Size(383, 100)
        Me.panelLowStock.TabIndex = 4
        '
        'lblLowStock
        '
        Me.lblLowStock.AutoSize = True
        Me.lblLowStock.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowStock.Location = New System.Drawing.Point(179, 38)
        Me.lblLowStock.Name = "lblLowStock"
        Me.lblLowStock.Size = New System.Drawing.Size(49, 38)
        Me.lblLowStock.TabIndex = 0
        Me.lblLowStock.Text = "₹0"
        '
        'dtFrom
        '
        Me.dtFrom.CalendarFont = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFrom.Location = New System.Drawing.Point(12, 212)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(121, 26)
        Me.dtFrom.TabIndex = 5
        '
        'dtTo
        '
        Me.dtTo.CalendarFont = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTo.Location = New System.Drawing.Point(158, 212)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(126, 26)
        Me.dtTo.TabIndex = 6
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(320, 205)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(127, 38)
        Me.btnFilter.TabIndex = 7
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'chartSales
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartSales.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartSales.Legends.Add(Legend1)
        Me.chartSales.Location = New System.Drawing.Point(50, 250)
        Me.chartSales.Name = "chartSales"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartSales.Series.Add(Series1)
        Me.chartSales.Size = New System.Drawing.Size(500, 300)
        Me.chartSales.TabIndex = 8
        Me.chartSales.Text = "Chart1"
        '
        'chartMedicines
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartMedicines.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartMedicines.Legends.Add(Legend2)
        Me.chartMedicines.Location = New System.Drawing.Point(600, 250)
        Me.chartMedicines.Name = "chartMedicines"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartMedicines.Series.Add(Series2)
        Me.chartMedicines.Size = New System.Drawing.Size(500, 300)
        Me.chartMedicines.TabIndex = 9
        Me.chartMedicines.Text = "Medicines"
        '
        'lblPrediction
        '
        Me.lblPrediction.AutoSize = True
        Me.lblPrediction.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrediction.Location = New System.Drawing.Point(50, 580)
        Me.lblPrediction.Name = "lblPrediction"
        Me.lblPrediction.Size = New System.Drawing.Size(174, 32)
        Me.lblPrediction.TabIndex = 10
        Me.lblPrediction.Text = "Prediction: ₹0"
        '
        'chartLowStock
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartLowStock.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartLowStock.Legends.Add(Legend3)
        Me.chartLowStock.Location = New System.Drawing.Point(1201, 252)
        Me.chartLowStock.Name = "chartLowStock"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chartLowStock.Series.Add(Series3)
        Me.chartLowStock.Size = New System.Drawing.Size(538, 298)
        Me.chartLowStock.TabIndex = 11
        Me.chartLowStock.Text = "Chart1"
        '
        'chartPayment
        '
        ChartArea4.Name = "ChartArea1"
        Me.chartPayment.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.chartPayment.Legends.Add(Legend4)
        Me.chartPayment.Location = New System.Drawing.Point(431, 667)
        Me.chartPayment.Name = "chartPayment"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.chartPayment.Series.Add(Series4)
        Me.chartPayment.Size = New System.Drawing.Size(820, 300)
        Me.chartPayment.TabIndex = 12
        Me.chartPayment.Text = "Chart1"
        '
        'lblRevenueTitle
        '
        Me.lblRevenueTitle.AutoSize = True
        Me.lblRevenueTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenueTitle.ForeColor = System.Drawing.Color.Black
        Me.lblRevenueTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblRevenueTitle.Name = "lblRevenueTitle"
        Me.lblRevenueTitle.Size = New System.Drawing.Size(146, 28)
        Me.lblRevenueTitle.TabIndex = 3
        Me.lblRevenueTitle.Text = "Total Revenue"
        '
        'lblOrdersTitle
        '
        Me.lblOrdersTitle.AutoSize = True
        Me.lblOrdersTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdersTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblOrdersTitle.Name = "lblOrdersTitle"
        Me.lblOrdersTitle.Size = New System.Drawing.Size(128, 28)
        Me.lblOrdersTitle.TabIndex = 4
        Me.lblOrdersTitle.Text = "Total Orders"
        '
        'lblMedicinesTitle
        '
        Me.lblMedicinesTitle.AutoSize = True
        Me.lblMedicinesTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicinesTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblMedicinesTitle.Name = "lblMedicinesTitle"
        Me.lblMedicinesTitle.Size = New System.Drawing.Size(161, 28)
        Me.lblMedicinesTitle.TabIndex = 1
        Me.lblMedicinesTitle.Text = "Total Medicines"
        '
        'lblLowStockTitle
        '
        Me.lblLowStockTitle.AutoSize = True
        Me.lblLowStockTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowStockTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblLowStockTitle.Name = "lblLowStockTitle"
        Me.lblLowStockTitle.Size = New System.Drawing.Size(108, 28)
        Me.lblLowStockTitle.TabIndex = 1
        Me.lblLowStockTitle.Text = "Low Stock"
        '
        'AdminDashboardHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1771, 976)
        Me.Controls.Add(Me.chartPayment)
        Me.Controls.Add(Me.chartLowStock)
        Me.Controls.Add(Me.lblPrediction)
        Me.Controls.Add(Me.chartMedicines)
        Me.Controls.Add(Me.chartSales)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtFrom)
        Me.Controls.Add(Me.panelLowStock)
        Me.Controls.Add(Me.panelMedicines)
        Me.Controls.Add(Me.panelOrders)
        Me.Controls.Add(Me.panelRevenue)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AdminDashboardHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmacy Insights Dashboard"
        Me.panelRevenue.ResumeLayout(False)
        Me.panelRevenue.PerformLayout()
        Me.panelOrders.ResumeLayout(False)
        Me.panelOrders.PerformLayout()
        Me.panelMedicines.ResumeLayout(False)
        Me.panelMedicines.PerformLayout()
        Me.panelLowStock.ResumeLayout(False)
        Me.panelLowStock.PerformLayout()
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartMedicines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartLowStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents panelRevenue As Windows.Forms.Panel
    Friend WithEvents lblRevenue As Windows.Forms.Label
    Friend WithEvents panelOrders As Windows.Forms.Panel
    Friend WithEvents lblOrders As Windows.Forms.Label
    Friend WithEvents panelMedicines As Windows.Forms.Panel
    Friend WithEvents lblMedicines As Windows.Forms.Label
    Friend WithEvents panelLowStock As Windows.Forms.Panel
    Friend WithEvents lblLowStock As Windows.Forms.Label
    Friend WithEvents dtFrom As Windows.Forms.DateTimePicker
    Friend WithEvents dtTo As Windows.Forms.DateTimePicker
    Friend WithEvents btnFilter As Windows.Forms.Button
    Friend WithEvents chartSales As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chartMedicines As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblPrediction As Windows.Forms.Label
    Friend WithEvents chartLowStock As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chartPayment As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblRevenueTitle As Windows.Forms.Label
    Friend WithEvents lblOrdersTitle As Windows.Forms.Label
    Friend WithEvents lblMedicinesTitle As Windows.Forms.Label
    Friend WithEvents lblLowStockTitle As Windows.Forms.Label
End Class
