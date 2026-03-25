'Imports System.Data.SqlClient
'Imports System.Drawing
'Imports System.Windows.Forms
'Imports System.IO

'Public Class ViewMedicinesForm

'    Private Sub ViewMedicinesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        LoadMedicines()
'    End Sub

'    Public Sub LoadMedicines()
'        FlowLayoutPanel1.Controls.Clear()

'        Try
'            Connect()

'            Dim query As String = "SELECT * FROM Medicines"
'            Dim cmd As New SqlCommand(query, con)
'            Dim reader As SqlDataReader = cmd.ExecuteReader()

'            While reader.Read()

'                ' 🔥 STORE VALUES FIRST
'                Dim medID As Integer = Convert.ToInt32(reader("MedicineID"))
'                Dim medName As String = reader("MedicineName").ToString()
'                Dim price As Decimal = Convert.ToDecimal(reader("Price"))
'                Dim qty As Integer = Convert.ToInt32(reader("Quantity"))
'                Dim imgFile As String = reader("ImagePath").ToString()

'                ' 🔹 Create Card Panel
'                Dim card As New Panel
'                card.Width = 200
'                card.Height = 220
'                card.BorderStyle = BorderStyle.FixedSingle
'                card.BackColor = Color.White

'                ' 🔹 IMAGE
'                Dim pic As New PictureBox
'                pic.Width = 100
'                pic.Height = 70
'                pic.Top = 5
'                pic.Left = 50
'                pic.SizeMode = PictureBoxSizeMode.StretchImage

'                Try
'                    Dim fullPath As String = Application.StartupPath & "\Images\" & imgFile

'                    If File.Exists(fullPath) Then
'                        pic.Image = Image.FromFile(fullPath)
'                    Else
'                        pic.Image = Nothing
'                    End If
'                Catch ex As Exception
'                    pic.Image = Nothing
'                End Try

'                ' 🔹 Medicine Name
'                Dim lblName As New Label
'                lblName.Text = medName
'                lblName.Top = 80
'                lblName.Left = 10
'                lblName.Width = 180
'                lblName.Font = New Font("Segoe UI", 10, FontStyle.Bold)

'                ' 🔹 Price
'                Dim lblPrice As New Label
'                lblPrice.Text = "Price: ₹" & price.ToString()
'                lblPrice.Top = 110
'                lblPrice.Left = 10

'                ' 🔹 Quantity
'                Dim lblQty As New Label
'                lblQty.Top = 135
'                lblQty.Left = 10

'                If qty = 0 Then
'                    lblQty.Text = "Out of Stock"
'                    lblQty.ForeColor = Color.Red
'                ElseIf qty <= 20 Then
'                    lblQty.Text = "Low Stock: " & qty
'                    lblQty.ForeColor = Color.Orange
'                Else
'                    lblQty.Text = "Available: " & qty
'                    lblQty.ForeColor = Color.Green
'                End If

'                ' 🔹 Add to Cart Button
'                Dim btnAdd As New Button
'                btnAdd.Text = "Add to Cart"
'                btnAdd.Width = 150
'                btnAdd.Top = 165
'                btnAdd.Left = 20
'                btnAdd.BackColor = Color.RoyalBlue
'                btnAdd.ForeColor = Color.White

'                ' Disable if out of stock
'                If qty = 0 Then
'                    btnAdd.Enabled = False
'                    btnAdd.Text = "Out of Stock"
'                End If

'                ' 🔥 SAFE CLICK EVENT
'                AddHandler btnAdd.Click, Sub()
'                                             AddToCart(medID, medName, price)
'                                         End Sub

'                ' 🔹 Add controls
'                card.Controls.Add(pic)
'                card.Controls.Add(lblName)
'                card.Controls.Add(lblPrice)
'                card.Controls.Add(lblQty)
'                card.Controls.Add(btnAdd)

'                FlowLayoutPanel1.Controls.Add(card)

'            End While

'            reader.Close()
'            con.Close()

'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        End Try
'    End Sub

'    ' 🔹 ADD TO CART FUNCTION
'    Public Sub AddToCart(medID As Integer, medName As String, price As Decimal)

'        Try
'            Connect()

'            Dim query As String = "INSERT INTO Cart(UserID, MedicineID, MedicineName, Price, Quantity, Total)
'                                  VALUES(@uid, @mid, @name, @price, 1, @price)"

'            Dim cmd As New SqlCommand(query, con)

'            ' ⚠️ Replace later with actual logged user
'            cmd.Parameters.AddWithValue("@uid", 1)

'            cmd.Parameters.AddWithValue("@mid", medID)
'            cmd.Parameters.AddWithValue("@name", medName)
'            cmd.Parameters.AddWithValue("@price", price)

'            cmd.ExecuteNonQuery()

'            MessageBox.Show("Added to Cart")

'            con.Close()

'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        End Try

'    End Sub

'End Class

Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Public Class ViewMedicinesForm

    Public currentUserID As Integer = 0  ' ✅ ADD THIS

    Private Sub ViewMedicinesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedicines()
    End Sub

    Public Sub LoadMedicines()
        FlowLayoutPanel1.Controls.Clear()

        Try
            Connect()

            Dim query As String = "SELECT * FROM Medicines"
            Dim cmd As New SqlCommand(query, con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()

                Dim medID As Integer = Convert.ToInt32(reader("MedicineID"))
                Dim medName As String = reader("MedicineName").ToString()
                Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                Dim qty As Integer = Convert.ToInt32(reader("Quantity"))
                Dim imgFile As String = reader("ImagePath").ToString()

                Dim card As New Panel
                card.Width = 200
                card.Height = 220
                card.BorderStyle = BorderStyle.FixedSingle
                card.BackColor = Color.White

                Dim pic As New PictureBox
                pic.Width = 100
                pic.Height = 70
                pic.Top = 5
                pic.Left = 50
                pic.SizeMode = PictureBoxSizeMode.StretchImage

                Try
                    Dim fullPath As String = Application.StartupPath & "\Images\" & imgFile
                    If File.Exists(fullPath) Then
                        pic.Image = Image.FromFile(fullPath)
                    Else
                        pic.Image = Nothing
                    End If
                Catch ex As Exception
                    pic.Image = Nothing
                End Try

                Dim lblName As New Label
                lblName.Text = medName
                lblName.Top = 80
                lblName.Left = 10
                lblName.Width = 180
                lblName.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                Dim lblPrice As New Label
                lblPrice.Text = "Price: ₹" & price.ToString()
                lblPrice.Top = 110
                lblPrice.Left = 10

                Dim lblQty As New Label
                lblQty.Top = 135
                lblQty.Left = 10

                If qty = 0 Then
                    lblQty.Text = "Out of Stock"
                    lblQty.ForeColor = Color.Red
                ElseIf qty <= 20 Then
                    lblQty.Text = "Low Stock: " & qty
                    lblQty.ForeColor = Color.Orange
                Else
                    lblQty.Text = "Available: " & qty
                    lblQty.ForeColor = Color.Green
                End If

                Dim btnAdd As New Button
                btnAdd.Text = "Add to Cart"
                btnAdd.Width = 150
                btnAdd.Top = 165
                btnAdd.Left = 20
                btnAdd.BackColor = Color.RoyalBlue
                btnAdd.ForeColor = Color.White

                If qty = 0 Then
                    btnAdd.Enabled = False
                    btnAdd.Text = "Out of Stock"
                End If

                AddHandler btnAdd.Click, Sub()
                                             AddToCart(medID, medName, price)
                                         End Sub

                card.Controls.Add(pic)
                card.Controls.Add(lblName)
                card.Controls.Add(lblPrice)
                card.Controls.Add(lblQty)
                card.Controls.Add(btnAdd)

                FlowLayoutPanel1.Controls.Add(card)

            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub AddToCart(medID As Integer, medName As String, price As Decimal)
        Try
            Connect()

            ' ✅ Check if item already exists in cart for this user
            Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Cart WHERE UserID=@uid AND MedicineID=@mid", con)
            checkCmd.Parameters.AddWithValue("@uid", currentUserID)
            checkCmd.Parameters.AddWithValue("@mid", medID)
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                ' ✅ Already in cart — just increase quantity
                Dim updateCmd As New SqlCommand("
                    UPDATE Cart 
                    SET Quantity = Quantity + 1,
                        Total = Price * (Quantity + 1)
                    WHERE UserID=@uid AND MedicineID=@mid", con)
                updateCmd.Parameters.AddWithValue("@uid", currentUserID)
                updateCmd.Parameters.AddWithValue("@mid", medID)
                updateCmd.ExecuteNonQuery()
                MessageBox.Show("Quantity updated in Cart!", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' ✅ New item — insert into cart
                Dim insertCmd As New SqlCommand("
                    INSERT INTO Cart(UserID, MedicineID, MedicineName, Price, Quantity, Total)
                    VALUES(@uid, @mid, @name, @price, 1, @price)", con)
                insertCmd.Parameters.AddWithValue("@uid", currentUserID)  ' ✅ REAL USER ID
                insertCmd.Parameters.AddWithValue("@mid", medID)
                insertCmd.Parameters.AddWithValue("@name", medName)
                insertCmd.Parameters.AddWithValue("@price", price)
                insertCmd.ExecuteNonQuery()
                MessageBox.Show("Added to Cart!", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class