Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms

Public Class PurchaseHistoryForm

    Public currentUserID As Integer = 0
    Public currentUserName As String = ""

    ' ================= FORM LOAD =================
    Private Sub PurchaseHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleGrid()
        LoadHistory()
    End Sub

    ' ================= STYLE GRID =================
    Private Sub StyleGrid()
        dgvHistory.DefaultCellStyle.ForeColor = Color.Black
        dgvHistory.DefaultCellStyle.BackColor = Color.White
        dgvHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        dgvHistory.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        dgvHistory.RowsDefaultCellStyle.ForeColor = Color.Black
        dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
        dgvHistory.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvHistory.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgvHistory.GridColor = Color.SteelBlue
        dgvHistory.BorderStyle = BorderStyle.Fixed3D
        dgvHistory.RowHeadersVisible = False
        dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHistory.ReadOnly = True
        dgvHistory.AllowUserToAddRows = False
        dgvHistory.EnableHeadersVisualStyles = False
    End Sub

    ' ================= LOAD HISTORY =================
    Public Sub LoadHistory()
        Try
            Connect()

            Dim query As String = "
                SELECT 
                    B.BillID        AS [Bill ID],
                    BI.MedicineName AS [Medicine Name],
                    BI.Price        AS [Price],
                    BI.Quantity     AS [Quantity],
                    BI.Total        AS [Item Total],
                    B.TotalAmount   AS [Bill Total],
                    B.PaymentMethod AS [Payment],
                    B.BillDate      AS [Date]
                FROM Bills B
                INNER JOIN BillItems BI ON B.BillID = BI.BillID
                WHERE B.UserID = @uid
                ORDER BY B.BillDate DESC"

            Dim da As New SqlDataAdapter(query, con)
            da.SelectCommand.Parameters.AddWithValue("@uid", currentUserID)

            Dim dt As New DataTable()
            da.Fill(dt)

            dgvHistory.DataSource = dt
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' ✅ Update title with record count
            If dt.Rows.Count = 0 Then
                lblHistoryTitle.Text = "Purchase History - " & currentUserName & " (No records found)"
            Else
                lblHistoryTitle.Text = "Purchase History - " & currentUserName & " (" & dt.Rows.Count & " records)"
            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Load Error: " & ex.Message)
        End Try
    End Sub

End Class