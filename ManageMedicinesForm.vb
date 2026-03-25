'Imports System.Data.SqlClient
'Imports System.Windows.Forms
'Imports System.IO
'Imports System.Drawing

'Public Class ManageMedicinesForm

'    ' ================= FORM LOAD =================
'    Private Sub ManageMedicinesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        LoadMedicines()
'    End Sub

'    ' ================= BROWSE IMAGE =================
'    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
'        Dim ofd As New OpenFileDialog()
'        ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg"

'        If ofd.ShowDialog() = DialogResult.OK Then
'            txtImage.Text = ofd.FileName
'        End If
'    End Sub

'    ' ================= LOAD MEDICINES =================
'    Private Sub LoadMedicines()
'        Try
'            Connect()

'            Dim query As String = "SELECT * FROM Medicines"
'            Dim da As New SqlDataAdapter(query, con)
'            Dim dt As New DataTable()

'            da.Fill(dt)
'            dgvMedicines.DataSource = dt

'            If Not dgvMedicines.Columns.Contains("ImagePreview") Then
'                Dim imgCol As New DataGridViewImageColumn()
'                imgCol.Name = "ImagePreview"
'                imgCol.HeaderText = "Image"
'                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
'                dgvMedicines.Columns.Add(imgCol)
'            End If

'            For Each row As DataGridViewRow In dgvMedicines.Rows
'                If row.Cells("ImagePath").Value IsNot Nothing Then
'                    Dim path As String = row.Cells("ImagePath").Value.ToString()

'                    If File.Exists(path) Then
'                        Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
'                            row.Cells("ImagePreview").Value = Image.FromStream(fs)
'                        End Using
'                    End If
'                End If
'            Next

'            dgvMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
'            dgvMedicines.RowTemplate.Height = 60

'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        End Try
'    End Sub

'    ' ================= ADD =================
'    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
'        Try
'            Connect()

'            Dim query As String = "INSERT INTO Medicines (MedicineName, Category, Price, Quantity, ImagePath) 
'                                  VALUES (@name,@cat,@price,@qty,@img)"

'            Dim cmd As New SqlCommand(query, con)
'            cmd.Parameters.AddWithValue("@name", txtName.Text)
'            cmd.Parameters.AddWithValue("@cat", txtCategory.Text)
'            cmd.Parameters.AddWithValue("@price", txtPrice.Text)
'            cmd.Parameters.AddWithValue("@qty", txtQuantity.Text)
'            cmd.Parameters.AddWithValue("@img", txtImage.Text)

'            cmd.ExecuteNonQuery()

'            '  HISTORY LOG
'            LogHistory(LoginForm.CurrentAdminID, "Add", "Added Medicine: " & txtName.Text)

'            MessageBox.Show("Medicine Added Successfully")
'            LoadMedicines()

'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        End Try
'    End Sub

'    ' ================= GRID CLICK =================
'    Private Sub dgvMedicines_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicines.CellClick
'        If e.RowIndex >= 0 Then
'            Dim row As DataGridViewRow = dgvMedicines.Rows(e.RowIndex)

'            txtName.Text = row.Cells("MedicineName").Value.ToString()
'            txtCategory.Text = row.Cells("Category").Value.ToString()
'            txtPrice.Text = row.Cells("Price").Value.ToString()
'            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
'            txtImage.Text = row.Cells("ImagePath").Value.ToString()
'        End If
'    End Sub

'    ' ================= UPDATE =================
'    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

'        If dgvMedicines.SelectedRows.Count = 0 Then
'            MessageBox.Show("Select a row first")
'            Exit Sub
'        End If

'        Dim id As Integer = dgvMedicines.SelectedRows(0).Cells("MedicineID").Value

'        Try
'            Connect()

'            Dim query As String = "UPDATE Medicines 
'                                  SET MedicineName=@name, Category=@cat, Price=@price, Quantity=@qty, ImagePath=@img 
'                                  WHERE MedicineID=@id"

'            Dim cmd As New SqlCommand(query, con)
'            cmd.Parameters.AddWithValue("@name", txtName.Text)
'            cmd.Parameters.AddWithValue("@cat", txtCategory.Text)
'            cmd.Parameters.AddWithValue("@price", txtPrice.Text)
'            cmd.Parameters.AddWithValue("@qty", txtQuantity.Text)
'            cmd.Parameters.AddWithValue("@img", txtImage.Text)
'            cmd.Parameters.AddWithValue("@id", id)

'            cmd.ExecuteNonQuery()

'            ' 🔥 HISTORY LOG
'            LogHistory(LoginForm.CurrentAdminID, "Update", "Updated Medicine: " & txtName.Text)

'            MessageBox.Show("Medicine Updated")
'            LoadMedicines()

'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        End Try
'    End Sub

'    ' ================= DELETE =================
'    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

'        If dgvMedicines.SelectedRows.Count = 0 Then
'            MessageBox.Show("Select a row first")
'            Exit Sub
'        End If

'        Dim id As Integer = dgvMedicines.SelectedRows(0).Cells("MedicineID").Value

'        Try
'            Connect()

'            Dim query As String = "DELETE FROM Medicines WHERE MedicineID=@id"

'            Dim cmd As New SqlCommand(query, con)
'            cmd.Parameters.AddWithValue("@id", id)

'            cmd.ExecuteNonQuery()

'            '  HISTORY LOG
'            LogHistory(LoginForm.CurrentAdminID, "Delete", "Deleted Medicine ID: " & id)

'            MessageBox.Show("Medicine Deleted")
'            LoadMedicines()

'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        End Try
'    End Sub

'    ' ================= CLEAR =================
'    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
'        txtName.Clear()
'        txtCategory.Clear()
'        txtPrice.Clear()
'        txtQuantity.Clear()
'        txtImage.Clear()
'        txtName.Focus()
'    End Sub

'End Class

Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing

Public Class ManageMedicinesForm

    ' ================= FORM LOAD =================
    Private Sub ManageMedicinesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedicines()
    End Sub

    ' ================= BROWSE IMAGE =================
    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If ofd.ShowDialog() = DialogResult.OK Then

            Dim fileName As String = Path.GetFileName(ofd.FileName)
            Dim imagesFolder As String = Application.StartupPath & "\Images\"

            ' Create folder if not exists
            If Not Directory.Exists(imagesFolder) Then
                Directory.CreateDirectory(imagesFolder)
            End If

            Dim destPath As String = imagesFolder & fileName

            ' Copy image into project folder
            File.Copy(ofd.FileName, destPath, True)

            ' Store ONLY filename
            txtImage.Text = fileName

        End If
    End Sub

    ' ================= LOAD MEDICINES =================
    Private Sub LoadMedicines()
        Try
            Connect()

            Dim query As String = "SELECT * FROM Medicines"
            Dim da As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()

            da.Fill(dt)
            dgvMedicines.DataSource = dt

            ' Add image column if not exists
            If Not dgvMedicines.Columns.Contains("ImagePreview") Then
                Dim imgCol As New DataGridViewImageColumn()
                imgCol.Name = "ImagePreview"
                imgCol.HeaderText = "Image"
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                dgvMedicines.Columns.Add(imgCol)
            End If

            ' Load images
            For Each row As DataGridViewRow In dgvMedicines.Rows

                If Not row.IsNewRow AndAlso row.Cells("ImagePath").Value IsNot Nothing Then

                    Dim imgFile As String = row.Cells("ImagePath").Value.ToString()
                    Dim fullPath As String = Application.StartupPath & "\Images\" & imgFile

                    If File.Exists(fullPath) Then
                        Using fs As New FileStream(fullPath, FileMode.Open, FileAccess.Read)
                            row.Cells("ImagePreview").Value = Image.FromStream(fs)
                        End Using
                    End If

                End If
            Next

            dgvMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvMedicines.RowTemplate.Height = 60

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' ================= ADD =================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Connect()

            Dim query As String = "INSERT INTO Medicines (MedicineName, Category, Price, Quantity, ImagePath) 
                                  VALUES (@name,@cat,@price,@qty,@img)"

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@cat", txtCategory.Text)
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@img", txtImage.Text)

            cmd.ExecuteNonQuery()

            ' HISTORY LOG
            LogHistory(LoginForm.CurrentAdminID, "Add", "Added Medicine: " & txtName.Text)

            MessageBox.Show("Medicine Added Successfully")
            LoadMedicines()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' ================= GRID CLICK =================
    Private Sub dgvMedicines_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicines.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMedicines.Rows(e.RowIndex)

            txtName.Text = row.Cells("MedicineName").Value.ToString()
            txtCategory.Text = row.Cells("Category").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            txtImage.Text = row.Cells("ImagePath").Value.ToString()
        End If
    End Sub

    ' ================= UPDATE =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If dgvMedicines.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a row first")
            Exit Sub
        End If

        Dim id As Integer = dgvMedicines.SelectedRows(0).Cells("MedicineID").Value

        Try
            Connect()

            Dim query As String = "UPDATE Medicines 
                                  SET MedicineName=@name, Category=@cat, Price=@price, Quantity=@qty, ImagePath=@img 
                                  WHERE MedicineID=@id"

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@cat", txtCategory.Text)
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@img", txtImage.Text)
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()

            ' HISTORY LOG
            LogHistory(LoginForm.CurrentAdminID, "Update", "Updated Medicine: " & txtName.Text)

            MessageBox.Show("Medicine Updated")
            LoadMedicines()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' ================= DELETE =================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvMedicines.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a row first")
            Exit Sub
        End If

        Dim id As Integer = dgvMedicines.SelectedRows(0).Cells("MedicineID").Value

        Try
            Connect()

            Dim query As String = "DELETE FROM Medicines WHERE MedicineID=@id"

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()

            ' HISTORY LOG
            LogHistory(LoginForm.CurrentAdminID, "Delete", "Deleted Medicine ID: " & id)

            MessageBox.Show("Medicine Deleted")
            LoadMedicines()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtImage.Clear()
        txtName.Focus()
    End Sub

End Class