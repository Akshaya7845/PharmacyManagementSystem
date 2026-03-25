Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing

Public Class CartForm

    ' ================= CURRENT USER =================
    Public currentUserID As Integer = 0
    Public currentUserName As String = ""

    ' ================= FORM LOAD =================
    Private Sub CartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleGrid()
        LoadCart()
    End Sub

    ' ================= STYLE DATAGRIDVIEW =================
    Private Sub StyleGrid()
        dgvCart.DefaultCellStyle.ForeColor = Color.Black
        dgvCart.DefaultCellStyle.BackColor = Color.White
        dgvCart.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        dgvCart.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        dgvCart.RowsDefaultCellStyle.ForeColor = Color.Black
        dgvCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
        dgvCart.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvCart.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgvCart.GridColor = Color.SteelBlue
        dgvCart.BorderStyle = BorderStyle.Fixed3D
        dgvCart.RowHeadersVisible = False
        dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCart.ReadOnly = True
        dgvCart.AllowUserToAddRows = False
        dgvCart.EnableHeadersVisualStyles = False
    End Sub

    ' ================= LOAD CART =================
    Public Sub LoadCart()
        Try
            Connect() '  uses shared Module Connect()

            Dim query As String = "SELECT CartID, MedicineID, MedicineName, Price, Quantity, Total 
                                   FROM Cart 
                                   WHERE UserID = @uid"

            Dim da As New SqlDataAdapter(query, con) '  uses shared Module con
            da.SelectCommand.Parameters.AddWithValue("@uid", currentUserID)

            Dim dt As New DataTable()
            da.Fill(dt)

            dgvCart.DataSource = dt
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            CalculateTotal()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Load Error: " & ex.Message)
        End Try
    End Sub

    ' ================= CALCULATE TOTAL =================
    Private Sub CalculateTotal()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow AndAlso row.Cells("Total").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("Total").Value)
            End If
        Next

        lblTotal.Text = "₹" & total.ToString("0.00")
    End Sub

    ' ================= INCREASE (+) =================
    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        If dgvCart.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim cartID As Integer = dgvCart.SelectedRows(0).Cells("CartID").Value
        Dim medID As Integer = dgvCart.SelectedRows(0).Cells("MedicineID").Value
        Dim qty As Integer = dgvCart.SelectedRows(0).Cells("Quantity").Value

        Try
            Connect()

            ' Check stock before increasing
            Dim stockCmd As New SqlCommand("SELECT Quantity FROM Medicines WHERE MedicineID = @id", con)
            stockCmd.Parameters.AddWithValue("@id", medID)
            Dim stock As Integer = Convert.ToInt32(stockCmd.ExecuteScalar())

            If qty >= stock Then
                MessageBox.Show("No more stock available.", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                con.Close()
                Exit Sub
            End If

            Dim updateCmd As New SqlCommand("
                UPDATE Cart 
                SET Quantity = Quantity + 1,
                    Total = Price * (Quantity + 1)
                WHERE CartID = @id", con)
            updateCmd.Parameters.AddWithValue("@id", cartID)
            updateCmd.ExecuteNonQuery()

            con.Close()
            LoadCart()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ================= DECREASE (-) =================
    Private Sub btnDecrease_Click(sender As Object, e As EventArgs) Handles btnDecrease.Click
        If dgvCart.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim cartID As Integer = dgvCart.SelectedRows(0).Cells("CartID").Value
        Dim qty As Integer = dgvCart.SelectedRows(0).Cells("Quantity").Value

        Try
            Connect()

            If qty <= 1 Then
                '  Remove item if quantity reaches 1
                Dim delCmd As New SqlCommand("DELETE FROM Cart WHERE CartID = @id", con)
                delCmd.Parameters.AddWithValue("@id", cartID)
                delCmd.ExecuteNonQuery()
            Else
                Dim decCmd As New SqlCommand("
                    UPDATE Cart 
                    SET Quantity = Quantity - 1,
                        Total = Price * (Quantity - 1)
                    WHERE CartID = @id", con)
                decCmd.Parameters.AddWithValue("@id", cartID)
                decCmd.ExecuteNonQuery()
            End If

            con.Close()
            LoadCart()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ================= REMOVE ITEM =================
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvCart.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim cartID As Integer = dgvCart.SelectedRows(0).Cells("CartID").Value

        Dim confirm As DialogResult = MessageBox.Show("Remove this item from cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Exit Sub

        Try
            Connect()

            Dim cmd As New SqlCommand("DELETE FROM Cart WHERE CartID = @id", con)
            cmd.Parameters.AddWithValue("@id", cartID)
            cmd.ExecuteNonQuery()

            con.Close()
            MessageBox.Show("Item removed successfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCart()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' ================= CLEAR CART =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to clear the entire cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Exit Sub

        Try
            Connect()

            Dim cmd As New SqlCommand("DELETE FROM Cart WHERE UserID = @uid", con)
            cmd.Parameters.AddWithValue("@uid", currentUserID)
            cmd.ExecuteNonQuery()

            con.Close()
            MessageBox.Show("Cart cleared successfully.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCart()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If dgvCart.Rows.Count = 0 Then
            MessageBox.Show("Your cart is empty.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show("Confirm checkout?", "Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Exit Sub

        '  Just open BillForm - BillForm handles stock reduction, payment and cart clearing
        Dim bill As New BillForm()
        bill.currentUserID = currentUserID
        bill.currentUserName = currentUserName
        bill.Show()
    End Sub
End Class