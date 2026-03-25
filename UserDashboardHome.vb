Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class UserDashboardHome

    Public currentUserID As Integer = 0
    Public currentUserName As String = ""

    ' ================= FORM LOAD =================
    Private Sub UserDashboardHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleAll()
        LoadDashboard()
    End Sub

    ' ================= STYLE ALL =================
    Private Sub StyleAll()

        ' Form background
        Me.BackColor = Color.FromArgb(235, 240, 245)

        ' Welcome label
        lblWelcome.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(30, 30, 30)
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter
        lblWelcome.Dock = DockStyle.None
        lblWelcome.AutoSize = False
        lblWelcome.Width = Me.Width - 220
        lblWelcome.Height = 50
        lblWelcome.Top = 20
        lblWelcome.Left = 10

        ' Subtitle label
        lblSubtitle.Font = New Font("Segoe UI", 11)
        lblSubtitle.ForeColor = Color.FromArgb(120, 120, 120)
        lblSubtitle.BackColor = Color.Transparent
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter
        lblSubtitle.AutoSize = False
        lblSubtitle.Width = Me.Width - 220
        lblSubtitle.Height = 30
        lblSubtitle.Top = 70
        lblSubtitle.Left = 10

        ' Panel positions and sizes
        Dim cardTop As Integer = 130
        Dim cardHeight As Integer = 200
        Dim cardWidth As Integer = 280
        Dim gap As Integer = 30
        Dim startLeft As Integer = 30

        pnlOrders.Size = New Size(cardWidth, cardHeight)
        pnlOrders.Location = New Point(startLeft, cardTop)

        pnlSpent.Size = New Size(cardWidth, cardHeight)
        pnlSpent.Location = New Point(startLeft + cardWidth + gap, cardTop)

        pnlLastPurchase.Size = New Size(cardWidth, cardHeight)
        pnlLastPurchase.Location = New Point(startLeft + (cardWidth + gap) * 2, cardTop)

        '  Orders Card labels
        lblOrdersTitle.ForeColor = Color.FromArgb(220, 240, 255)
        lblOrdersTitle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblOrdersTitle.TextAlign = ContentAlignment.MiddleCenter
        lblOrdersTitle.Dock = DockStyle.Top
        lblOrdersTitle.Height = 50
        lblOrdersTitle.BackColor = Color.Transparent

        lblOrdersCount.ForeColor = Color.White
        lblOrdersCount.Font = New Font("Segoe UI", 40, FontStyle.Bold)
        lblOrdersCount.TextAlign = ContentAlignment.MiddleCenter
        lblOrdersCount.Dock = DockStyle.Fill
        lblOrdersCount.BackColor = Color.Transparent

        ' Spent Card labels
        lblSpentTitle.ForeColor = Color.FromArgb(200, 255, 220)
        lblSpentTitle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblSpentTitle.TextAlign = ContentAlignment.MiddleCenter
        lblSpentTitle.Dock = DockStyle.Top
        lblSpentTitle.Height = 50
        lblSpentTitle.BackColor = Color.Transparent

        lblSpentAmount.ForeColor = Color.White
        lblSpentAmount.Font = New Font("Segoe UI", 24, FontStyle.Bold)
        lblSpentAmount.TextAlign = ContentAlignment.MiddleCenter
        lblSpentAmount.Dock = DockStyle.Fill
        lblSpentAmount.BackColor = Color.Transparent

        '  Last Purchase Card labels
        lblLastTitle.ForeColor = Color.FromArgb(255, 220, 210)
        lblLastTitle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblLastTitle.TextAlign = ContentAlignment.MiddleCenter
        lblLastTitle.Dock = DockStyle.Top
        lblLastTitle.Height = 50
        lblLastTitle.BackColor = Color.Transparent

        lblLastDate.ForeColor = Color.White
        lblLastDate.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        lblLastDate.TextAlign = ContentAlignment.MiddleCenter
        lblLastDate.Dock = DockStyle.Fill
        lblLastDate.BackColor = Color.Transparent

    End Sub

    ' ================= ROUNDED PANELS =================
    Private Sub pnlOrders_Paint(sender As Object, e As PaintEventArgs) Handles pnlOrders.Paint
        DrawRoundedPanel(sender, e, Color.FromArgb(52, 152, 219))
    End Sub

    Private Sub pnlSpent_Paint(sender As Object, e As PaintEventArgs) Handles pnlSpent.Paint
        DrawRoundedPanel(sender, e, Color.FromArgb(39, 174, 96))
    End Sub

    Private Sub pnlLastPurchase_Paint(sender As Object, e As PaintEventArgs) Handles pnlLastPurchase.Paint
        DrawRoundedPanel(sender, e, Color.FromArgb(231, 76, 60))
    End Sub

    Private Sub DrawRoundedPanel(sender As Object, e As PaintEventArgs, color As Color)
        Dim pnl As Panel = CType(sender, Panel)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim rect As New Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1)
        Dim radius As Integer = 25

        Dim path As New GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        pnl.Region = New Region(path)
        e.Graphics.FillPath(New SolidBrush(color), path)
    End Sub

    ' ================= LOAD DASHBOARD =================
    Public Sub LoadDashboard()
        Try
            lblWelcome.Text = "Welcome, " & currentUserName & "! 👋"
            lblSubtitle.Text = "Here is your activity summary"

            Connect()

            '  Total Orders
            Dim ordersCmd As New SqlCommand("
                SELECT COUNT(*) FROM Bills 
                WHERE UserID = @uid", con)
            ordersCmd.Parameters.AddWithValue("@uid", currentUserID)
            lblOrdersCount.Text = Convert.ToInt32(ordersCmd.ExecuteScalar()).ToString()

            ' Total Spent
            Dim spentCmd As New SqlCommand("
                SELECT ISNULL(SUM(TotalAmount), 0) FROM Bills 
                WHERE UserID = @uid", con)
            spentCmd.Parameters.AddWithValue("@uid", currentUserID)
            Dim totalSpent As Decimal = Convert.ToDecimal(spentCmd.ExecuteScalar())
            lblSpentAmount.Text = "₹" & totalSpent.ToString("0.00")

            '  Last Purchase Date
            Dim lastCmd As New SqlCommand("
                SELECT TOP 1 BillDate FROM Bills 
                WHERE UserID = @uid 
                ORDER BY BillDate DESC", con)
            lastCmd.Parameters.AddWithValue("@uid", currentUserID)
            Dim lastDate As Object = lastCmd.ExecuteScalar()

            If lastDate IsNot Nothing AndAlso lastDate IsNot DBNull.Value Then
                lblLastDate.Text = Convert.ToDateTime(lastDate).ToString("dd-MM-yyyy")
            Else
                lblLastDate.Text = "No purchases yet"
            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Dashboard Error: " & ex.Message)
        End Try
    End Sub

    Private Sub lblOrdersTitle_Click(sender As Object, e As EventArgs) Handles lblOrdersTitle.Click
    End Sub

End Class
