Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class AdminDashboardHome

    Dim conStr As String = "Data Source=.;Initial Catalog=PharmacyDB;Integrated Security=True"

    ' ================= FORM LOAD =================
    Private Sub AdminDashboardHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFrom.Value = DateTime.Now.AddDays(-7)
        dtTo.Value = DateTime.Now
        StyleCards()
        LoadDashboard()
    End Sub
    '============== STYLE CARDS ==============
    Private Sub StyleCards()
        Me.BackColor = Color.FromArgb(235, 240, 245)

        panelRevenue.BackColor = Color.FromArgb(39, 174, 96)
        panelOrders.BackColor = Color.FromArgb(52, 152, 219)
        panelMedicines.BackColor = Color.FromArgb(230, 126, 34)
        panelLowStock.BackColor = Color.FromArgb(231, 76, 60)

        lblRevenue.ForeColor = Color.White
        lblOrders.ForeColor = Color.White
        lblMedicines.ForeColor = Color.White
        lblLowStock.ForeColor = Color.White

        lblRevenue.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblOrders.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblMedicines.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblLowStock.Font = New Font("Segoe UI", 16, FontStyle.Bold)

        'Fix visibility
        lblRevenue.BackColor = panelRevenue.BackColor
        lblOrders.BackColor = panelOrders.BackColor
        lblMedicines.BackColor = panelMedicines.BackColor
        lblLowStock.BackColor = panelLowStock.BackColor

        lblRevenue.Location = New Point(10, 30)
        lblOrders.Location = New Point(10, 30)
        lblMedicines.Location = New Point(10, 30)
        lblLowStock.Location = New Point(10, 30)

        lblRevenue.AutoSize = True
        lblOrders.AutoSize = True
        lblMedicines.AutoSize = True
        lblLowStock.AutoSize = True

        lblRevenue.BringToFront()
        lblOrders.BringToFront()
        lblMedicines.BringToFront()
        lblLowStock.BringToFront()

        lblPrediction.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblPrediction.ForeColor = Color.FromArgb(39, 174, 96)
    End Sub


    ' ================= ROUNDED PANELS =================
    Private Sub panelRevenue_Paint(sender As Object, e As PaintEventArgs) Handles panelRevenue.Paint
        DrawRounded(sender, e, Color.FromArgb(39, 174, 96))
    End Sub

    Private Sub panelOrders_Paint(sender As Object, e As PaintEventArgs) Handles panelOrders.Paint
        DrawRounded(sender, e, Color.FromArgb(52, 152, 219))
    End Sub

    Private Sub panelMedicines_Paint(sender As Object, e As PaintEventArgs) Handles panelMedicines.Paint
        DrawRounded(sender, e, Color.FromArgb(230, 126, 34))
    End Sub

    Private Sub panelLowStock_Paint(sender As Object, e As PaintEventArgs) Handles panelLowStock.Paint
        DrawRounded(sender, e, Color.FromArgb(231, 76, 60))
    End Sub

    Private Sub DrawRounded(sender As Object, e As PaintEventArgs, color As Color)
        Dim pnl As Panel = CType(sender, Panel)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim rect As New Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1)
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()
        pnl.Region = New Region(path)
        e.Graphics.FillPath(New SolidBrush(color), path)
    End Sub

    ' ================= MAIN LOAD =================
    Private Sub LoadDashboard()
        Try
            Using con As New SqlConnection(conStr)
                con.Open()

                ' ✅ Total Revenue from Bills
                Dim cmd1 As New SqlCommand("SELECT ISNULL(SUM(TotalAmount),0) FROM Bills", con)
                Dim revenue As Decimal = Convert.ToDecimal(cmd1.ExecuteScalar())
                lblRevenue.Text = "₹" & revenue.ToString("0.00")

                ' ✅ Total Orders from Bills
                Dim cmd2 As New SqlCommand("SELECT COUNT(*) FROM Bills", con)
                lblOrders.Text = cmd2.ExecuteScalar().ToString()

                ' ✅ Total Medicines
                Dim cmd3 As New SqlCommand("SELECT COUNT(*) FROM Medicines", con)
                lblMedicines.Text = cmd3.ExecuteScalar().ToString()

                ' ✅ Low Stock count
                Dim cmd4 As New SqlCommand("SELECT COUNT(*) FROM Medicines WHERE Quantity < 20", con)
                lblLowStock.Text = cmd4.ExecuteScalar().ToString()
            End Using

            LoadSalesChart()
            LoadMedicineChart()
            LoadLowStockChart()
            LoadPaymentChart()
            PredictRevenue()

        Catch ex As Exception
            MessageBox.Show("Dashboard Error: " & ex.Message)
        End Try
    End Sub

    ' ================= SALES LINE CHART =================
    Private Sub LoadSalesChart()
        chartSales.Series.Clear()
        chartSales.ChartAreas.Clear()
        chartSales.Titles.Clear()

        Dim area As New ChartArea("Area1")
        area.BackColor = Color.FromArgb(245, 248, 252)
        area.AxisX.LabelStyle.Format = "MM/dd"
        area.AxisX.LabelStyle.Angle = -45
        area.AxisY.Title = "Revenue (₹)"
        area.AxisX.Title = "Date"
        area.AxisX.MajorGrid.LineColor = Color.FromArgb(200, 200, 200)
        area.AxisY.MajorGrid.LineColor = Color.FromArgb(200, 200, 200)
        chartSales.ChartAreas.Add(area)

        Dim title As New Title("Daily Sales Revenue")
        title.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        title.ForeColor = Color.FromArgb(50, 50, 50)
        chartSales.Titles.Add(title)

        Dim series As New Series("Sales")
        series.ChartType = SeriesChartType.Line
        series.Color = Color.FromArgb(52, 152, 219)
        series.BorderWidth = 3
        series.MarkerStyle = MarkerStyle.Circle
        series.MarkerSize = 8
        series.MarkerColor = Color.FromArgb(52, 152, 219)
        chartSales.Series.Add(series)

        Try
            Using con As New SqlConnection(conStr)
                con.Open()
                Dim cmd As New SqlCommand("
                    SELECT CAST(BillDate AS DATE) AS SaleDate,
                           SUM(TotalAmount) AS Total
                    FROM Bills
                    GROUP BY CAST(BillDate AS DATE)
                    ORDER BY SaleDate", con)

                Dim dr As SqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    chartSales.Series("Sales").Points.AddXY(dr("SaleDate"), dr("Total"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Sales Chart Error: " & ex.Message)
        End Try
    End Sub

    ' ================= MEDICINE PIE CHART =================
    Private Sub LoadMedicineChart()
        chartMedicines.Series.Clear()
        chartMedicines.ChartAreas.Clear()

        Dim area As New ChartArea("Area1")
        chartMedicines.ChartAreas.Add(area)

        Dim series As New Series("Medicines")
        series.ChartType = SeriesChartType.Pie
        chartMedicines.Series.Add(series)

        Using con As New SqlConnection(conStr)
            con.Open()
            Dim cmd As New SqlCommand("SELECT TOP 5 MedicineName, SUM(Quantity) FROM BillItems GROUP BY MedicineName ORDER BY SUM(Quantity) DESC", con)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                chartMedicines.Series("Medicines").Points.AddXY(dr(0), dr(1))
            End While
        End Using
    End Sub


    ' ================= LOW STOCK BAR CHART =================
    Private Sub LoadLowStockChart()
        chartLowStock.Series.Clear()
        chartLowStock.ChartAreas.Clear()
        chartLowStock.Titles.Clear()

        Dim area As New ChartArea("Area1")
        area.BackColor = Color.FromArgb(245, 248, 252)
        area.AxisX.LabelStyle.Angle = -45
        area.AxisY.Title = "Stock Quantity"
        area.AxisX.MajorGrid.LineColor = Color.FromArgb(200, 200, 200)
        area.AxisY.MajorGrid.LineColor = Color.FromArgb(200, 200, 200)
        chartLowStock.ChartAreas.Add(area)

        Dim title As New Title("Low Stock Medicines")
        title.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        title.ForeColor = Color.FromArgb(231, 76, 60)
        chartLowStock.Titles.Add(title)

        Dim series As New Series("LowStock")
        series.ChartType = SeriesChartType.Bar
        series.Color = Color.FromArgb(231, 76, 60)
        series.Label = "#VAL"
        chartLowStock.Series.Add(series)

        Try
            Using con As New SqlConnection(conStr)
                con.Open()
                Dim cmd As New SqlCommand("
                    SELECT TOP 10 MedicineName, Quantity
                    FROM Medicines
                    WHERE Quantity < 20
                    ORDER BY Quantity ASC", con)

                Dim dr As SqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    chartLowStock.Series("LowStock").Points.AddXY(
                        dr("MedicineName"), dr("Quantity"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Low Stock Chart Error: " & ex.Message)
        End Try
    End Sub

    ' ================= PAYMENT METHOD CHART =================
    Private Sub LoadPaymentChart()
        chartPayment.Series.Clear()
        chartPayment.ChartAreas.Clear()
        chartPayment.Titles.Clear()

        Dim area As New ChartArea("Area1")
        area.BackColor = Color.FromArgb(245, 248, 252)
        chartPayment.ChartAreas.Add(area)

        Dim title As New Title("Payment Methods")
        title.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        title.ForeColor = Color.FromArgb(50, 50, 50)
        chartPayment.Titles.Add(title)

        Dim series As New Series("Payment")
        series.ChartType = SeriesChartType.Doughnut
        series.Label = "#VALX (#PERCENT{P0})"
        chartPayment.Series.Add(series)

        Try
            Using con As New SqlConnection(conStr)
                con.Open()
                Dim cmd As New SqlCommand("
                    SELECT PaymentMethod, COUNT(*) AS Count
                    FROM Bills
                    GROUP BY PaymentMethod", con)

                Dim dr As SqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    chartPayment.Series("Payment").Points.AddXY(
                        dr("PaymentMethod"), dr("Count"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Payment Chart Error: " & ex.Message)
        End Try
    End Sub

    ' ================= FILTER BUTTON =================
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        chartSales.Series("Sales").Points.Clear()

        Try
            Using con As New SqlConnection(conStr)
                con.Open()
                Dim cmd As New SqlCommand("
                    SELECT CAST(BillDate AS DATE) AS SaleDate,
                           SUM(TotalAmount) AS Total
                    FROM Bills
                    WHERE CAST(BillDate AS DATE) BETWEEN @from AND @to
                    GROUP BY CAST(BillDate AS DATE)
                    ORDER BY SaleDate", con)

                cmd.Parameters.AddWithValue("@from", dtFrom.Value.Date)
                cmd.Parameters.AddWithValue("@to", dtTo.Value.Date)

                Dim dr As SqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    chartSales.Series("Sales").Points.AddXY(dr("SaleDate"), dr("Total"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Filter Error: " & ex.Message)
        End Try
    End Sub

    ' ================= REVENUE PREDICTION =================
    Private Sub PredictRevenue()
        Try
            Using con As New SqlConnection(conStr)
                con.Open()

                ' ✅ Get average daily revenue from Bills
                Dim cmd As New SqlCommand("
                    SELECT ISNULL(AVG(DailyTotal), 0)
                    FROM (
                        SELECT SUM(TotalAmount) AS DailyTotal
                        FROM Bills
                        GROUP BY CAST(BillDate AS DATE)
                    ) t", con)

                Dim avg As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                Dim nextMonth As Decimal = avg * 30
                Dim nextWeek As Decimal = avg * 7

                lblPrediction.Text = "📈 Predicted Next Week: ₹" & nextWeek.ToString("0.00") &
                                     "     |     📊 Predicted Next Month: ₹" & nextMonth.ToString("0.00")

                ' =====Load prediction chart====
                LoadPredictionChart(avg)
            End Using
        Catch ex As Exception
            MessageBox.Show("Prediction Error: " & ex.Message)
        End Try
    End Sub

    ' ================= PREDICTION CHART =================
    Private Sub LoadPredictionChart(avgDaily As Decimal)
        chartSales.Titles.Clear()

        ' =====Add prediction series to sales chart=====
        If chartSales.Series.IsUniqueName("Prediction") Then
            Dim predSeries As New Series("Prediction")
            predSeries.ChartType = SeriesChartType.Line
            predSeries.Color = Color.FromArgb(231, 76, 60)
            predSeries.BorderWidth = 2
            predSeries.BorderDashStyle = ChartDashStyle.Dash
            predSeries.MarkerStyle = MarkerStyle.Diamond
            predSeries.MarkerSize = 6
            chartSales.Series.Add(predSeries)

            '=======Add next 7 days prediction points=======
            For i As Integer = 1 To 7
                Dim futureDate As DateTime = DateTime.Now.AddDays(i)
                chartSales.Series("Prediction").Points.AddXY(futureDate, avgDaily)
            Next
        End If

        Dim title As New Title("Daily Sales + 7 Day Forecast")
        title.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        title.ForeColor = Color.FromArgb(50, 50, 50)
        chartSales.Titles.Add(title)
    End Sub

End Class
