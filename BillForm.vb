Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.IO

Public Class BillForm

    ' ================= GLOBAL VARIABLES =================
    Public currentUserID As Integer = 0
    Public currentUserName As String = ""

    Dim dt As New DataTable()
    Dim printDT As New DataTable()
    Dim paymentMethod As String = ""
    Dim grandTotal As Decimal = 0
    Dim paymentDone As Boolean = False  '  track if payment completed

    ' ================= FORM LOAD =================
    Private Sub BillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBill()

        lblUserID.Text = "Customer ID: " & currentUserID
        lblUserName.Text = "Customer Name: " & currentUserName
        lblDate.Text = "Date: " & DateTime.Now.ToString("dd-MM-yyyy HH:mm")
        lblPaymentMethod.Text = "Payment: Not Selected"

        btnCard.Visible = False
        btnCash.Visible = False
        btnUPI.Visible = False
    End Sub

    ' ================= LOAD BILL =================
    Public Sub LoadBill()
        Try
            Connect()

            Dim query As String = "SELECT MedicineName, Price, Quantity, Total 
                                   FROM Cart 
                                   WHERE UserID = @uid"

            Dim da As New SqlDataAdapter(query, con)
            da.SelectCommand.Parameters.AddWithValue("@uid", currentUserID)

            dt.Clear()
            da.Fill(dt)

            '  Save copy immediately for printing
            printDT = dt.Copy()
            grandTotal = 0
            For Each row As DataRow In printDT.Rows
                If Not IsDBNull(row("Total")) Then
                    grandTotal += Convert.ToDecimal(row("Total"))
                End If
            Next

            dgvBill.DataSource = dt
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dgvBill.DefaultCellStyle.ForeColor = Color.Black
            dgvBill.DefaultCellStyle.BackColor = Color.White
            dgvBill.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
            dgvBill.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
            dgvBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgvBill.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
            dgvBill.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            dgvBill.EnableHeadersVisualStyles = False
            dgvBill.RowHeadersVisible = False
            dgvBill.ReadOnly = True
            dgvBill.AllowUserToAddRows = False

            lblTotal.Text = "₹" & grandTotal.ToString("0.00")

        Catch ex As Exception
            MessageBox.Show("Load Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' ================= PROCEED =================
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If printDT.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty. Nothing to pay.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        btnCard.Visible = True
        btnCash.Visible = True
        btnUPI.Visible = True
    End Sub

    ' ================= PAYMENT BUTTONS =================
    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        ProcessPayment("Card")
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        ProcessPayment("Cash")
    End Sub

    Private Sub btnUPI_Click(sender As Object, e As EventArgs) Handles btnUPI.Click
        ProcessPayment("UPI")
    End Sub

    ' ================= PROCESS PAYMENT =================
    Private Sub ProcessPayment(method As String)
        paymentMethod = method
        lblPaymentMethod.Text = "Payment: " & method

        Dim result As DialogResult = MessageBox.Show(
            "Confirm " & method & " Payment?",
            "Payment Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Try
                Connect()

                '  Save grandTotal before anything is cleared
                grandTotal = Convert.ToDecimal(lblTotal.Text.Replace("₹", ""))

                '  printDT already has data from LoadBill - safe to use

                '  Reduce stock
                Dim updateStock As New SqlCommand("
                    UPDATE M
                    SET M.Quantity = M.Quantity - C.Quantity
                    FROM Medicines M
                    INNER JOIN Cart C ON M.MedicineID = C.MedicineID
                    WHERE C.UserID = @uid", con)
                updateStock.Parameters.AddWithValue("@uid", currentUserID)
                updateStock.ExecuteNonQuery()

                '  Save Bill
                Dim billID As Integer = SaveBill()

                '  Clear Cart
                Dim cmd As New SqlCommand("DELETE FROM Cart WHERE UserID = @uid", con)
                cmd.Parameters.AddWithValue("@uid", currentUserID)
                cmd.ExecuteNonQuery()

                '  Mark payment done
                paymentDone = True

                '  Hide payment buttons
                btnCard.Visible = False
                btnCash.Visible = False
                btnUPI.Visible = False

                lblPaymentMethod.Text = "Payment: " & method & " - Paid ✅"

                '  Show bill data in grid from printDT (NOT reloading from DB)
                dgvBill.DataSource = printDT
                lblTotal.Text = "₹" & grandTotal.ToString("0.00")

                MessageBox.Show("Payment Successful! Bill ID: " & billID & vbNewLine & "Click Print Bill to download PDF.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Payment Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    ' ================= SAVE BILL =================
    Private Function SaveBill() As Integer

        Dim billQuery As String = "
            INSERT INTO Bills(UserID, CustomerName, TotalAmount, PaymentMethod)
            OUTPUT INSERTED.BillID
            VALUES(@uid, @name, @total, @method)"

        Dim billCmd As New SqlCommand(billQuery, con)
        billCmd.Parameters.AddWithValue("@uid", currentUserID)
        billCmd.Parameters.AddWithValue("@name", currentUserName)
        billCmd.Parameters.AddWithValue("@total", grandTotal)
        billCmd.Parameters.AddWithValue("@method", paymentMethod)

        Dim billID As Integer = Convert.ToInt32(billCmd.ExecuteScalar())

        For Each row As DataRow In printDT.Rows
            Dim itemQuery As String = "
                INSERT INTO BillItems(BillID, MedicineName, Price, Quantity, Total)
                VALUES(@bid, @name, @price, @qty, @total)"

            Dim itemCmd As New SqlCommand(itemQuery, con)
            itemCmd.Parameters.AddWithValue("@bid", billID)
            itemCmd.Parameters.AddWithValue("@name", row("MedicineName"))
            itemCmd.Parameters.AddWithValue("@price", row("Price"))
            itemCmd.Parameters.AddWithValue("@qty", row("Quantity"))
            itemCmd.Parameters.AddWithValue("@total", row("Total"))
            itemCmd.ExecuteNonQuery()
        Next

        Dim payQuery As String = "
            INSERT INTO Payments(BillID, UserID, PaymentMethod, Amount)
            VALUES(@bid, @uid, @method, @amt)"

        Dim payCmd As New SqlCommand(payQuery, con)
        payCmd.Parameters.AddWithValue("@bid", billID)
        payCmd.Parameters.AddWithValue("@uid", currentUserID)
        payCmd.Parameters.AddWithValue("@method", paymentMethod)
        payCmd.Parameters.AddWithValue("@amt", grandTotal)
        payCmd.ExecuteNonQuery()

        Return billID
    End Function

    ' ================= PRINT BILL AS PDF =================
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If printDT.Rows.Count = 0 Then
            MessageBox.Show("No bill data. Please complete payment first.", "Nothing to Print", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        '  Save as PDF using SaveFileDialog
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Title = "Save Bill as PDF"
        saveDialog.Filter = "PDF File (*.pdf)|*.pdf"
        saveDialog.FileName = "PharmacyBill_" & currentUserName & "_" & DateTime.Now.ToString("ddMMyyyy_HHmm")

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Try
                '  Generate PDF using PrintDocument -> saved as PDF
                Dim pd As New PrintDocument()
                pd.DocumentName = saveDialog.FileName
                AddHandler pd.PrintPage, AddressOf PrintPage

                ' Use Microsoft Print to PDF printer
                pd.PrinterSettings.PrinterName = "Microsoft Print to PDF"
                pd.PrinterSettings.PrintToFile = True
                pd.PrinterSettings.PrintFileName = saveDialog.FileName

                pd.Print()

                MessageBox.Show("Bill saved as PDF successfully!" & vbNewLine & saveDialog.FileName, "PDF Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                '  Fallback to Print Preview if PDF fails
                MessageBox.Show("PDF save failed. Opening print preview instead." & vbNewLine & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim pd2 As New PrintDocument()
                AddHandler pd2.PrintPage, AddressOf PrintPage
                Dim preview As New PrintPreviewDialog()
                preview.Document = pd2
                preview.ShowDialog()
            End Try
        End If
    End Sub

    ' ================= PRINT PAGE LAYOUT =================
    Private Sub PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim y As Integer = 50

        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 11, FontStyle.Bold)
        Dim textFont As New Font("Arial", 10)

        '  Title
        e.Graphics.DrawString("PHARMACY BILL", titleFont, Brushes.Black, 180, y)
        y += 40

        e.Graphics.DrawLine(Pens.Black, 50, y, 520, y)
        y += 10

        '  Customer Info
        e.Graphics.DrawString("Customer ID   : " & currentUserID.ToString(), textFont, Brushes.Black, 50, y)
        y += 20
        e.Graphics.DrawString("Customer Name : " & currentUserName, textFont, Brushes.Black, 50, y)
        y += 20
        e.Graphics.DrawString("Date          : " & lblDate.Text.Replace("Date: ", ""), textFont, Brushes.Black, 50, y)
        y += 20
        e.Graphics.DrawString("Payment       : " & paymentMethod, textFont, Brushes.Black, 50, y)
        y += 15

        e.Graphics.DrawLine(Pens.Black, 50, y, 520, y)
        y += 10

        '  Table Headers
        e.Graphics.DrawString("Medicine Name", headerFont, Brushes.Black, 50, y)
        e.Graphics.DrawString("Price", headerFont, Brushes.Black, 230, y)
        e.Graphics.DrawString("Qty", headerFont, Brushes.Black, 320, y)
        e.Graphics.DrawString("Total", headerFont, Brushes.Black, 410, y)
        y += 20

        e.Graphics.DrawLine(Pens.Black, 50, y, 520, y)
        y += 8

        '  Medicine Rows from printDT
        For Each row As DataRow In printDT.Rows
            e.Graphics.DrawString(row("MedicineName").ToString(), textFont, Brushes.Black, 50, y)
            e.Graphics.DrawString("₹" & row("Price").ToString(), textFont, Brushes.Black, 230, y)
            e.Graphics.DrawString(row("Quantity").ToString(), textFont, Brushes.Black, 320, y)
            e.Graphics.DrawString("₹" & row("Total").ToString(), textFont, Brushes.Black, 410, y)
            y += 22
        Next

        y += 5
        e.Graphics.DrawLine(Pens.Black, 50, y, 520, y)
        y += 12

        '  Grand Total
        e.Graphics.DrawString("Total Amount:  ₹" & grandTotal.ToString("0.00"), titleFont, Brushes.Black, 230, y)
        y += 30

        e.Graphics.DrawLine(Pens.Black, 50, y, 520, y)
        y += 10

        '  Footer
        e.Graphics.DrawString("Thank you for your purchase!", New Font("Arial", 9, FontStyle.Italic), Brushes.Gray, 170, y)
    End Sub

End Class