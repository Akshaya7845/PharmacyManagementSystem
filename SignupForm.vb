Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class SignupForm

    ' ===== FORM LOAD =====
    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPhone.Visible = False
        lblPhone.Visible = False

        ' Optional: set default role (avoid null error)
        cmbRole.SelectedIndex = -1
    End Sub

    ' ===== REGISTER BUTTON =====
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        ' ===== VALIDATION =====
        If txtName.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or cmbRole.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill all fields")
            Exit Sub
        End If

        ' ===== EMAIL VALIDATION =====
        If Not txtEmail.Text.Contains("@") Or Not txtEmail.Text.Contains(".") Then
            MessageBox.Show("Enter valid email")
            Exit Sub
        End If

        ' ===== PASSWORD VALIDATION =====
        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters")
            Exit Sub
        End If

        ' ===== CONFIRM PASSWORD =====
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match")
            Exit Sub
        End If

        Dim role As String = cmbRole.SelectedItem.ToString()

        ' ===== ADMIN VALIDATION =====
        If role = "Admin" Then

            If txtPhone.Text.Trim() = "" Then
                MessageBox.Show("Please enter phone number")
                Exit Sub
            End If

            If txtPhone.Text.Length <> 10 Then
                MessageBox.Show("Phone number must be 10 digits")
                Exit Sub
            End If

            If Not txtEmail.Text.EndsWith("@adminpharmacist@gmail.com") Then
                MessageBox.Show("Admin must use official email format")
                Exit Sub
            End If

        End If

        Try
            Connect()

            ' ===== CHECK DUPLICATE EMAIL =====
            Dim checkQuery As String = ""

            If role = "Admin" Then
                checkQuery = "SELECT COUNT(*) FROM Admins WHERE Username=@email"
            Else
                checkQuery = "SELECT COUNT(*) FROM Users WHERE Email=@email"
            End If

            Dim checkCmd As New SqlCommand(checkQuery, con)
            checkCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())

            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Email already exists")
                Exit Sub
            End If

            ' ===== INSERT QUERY =====
            Dim query As String = ""

            If role = "Admin" Then

                query = "INSERT INTO Admins (AdminName, Username, Password, Phone, Status) 
                         VALUES (@name, @email, @password, @phone, 'Pending')"

            ElseIf role = "User" Then

                query = "INSERT INTO Users (UserName, Email, Password) 
                         VALUES (@name, @email, @password)"

            Else
                MessageBox.Show("Please select valid role")
                Exit Sub
            End If

            Dim cmd As New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
            cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

            If role = "Admin" Then
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim())
            End If

            cmd.ExecuteNonQuery()

            MessageBox.Show("Registration Successful")

            ClearFields()

            Dim login As New LoginForm()
            login.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    ' ===== CLEAR FIELDS =====
    Private Sub ClearFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        txtPhone.Clear()
        cmbRole.SelectedIndex = -1
    End Sub

    ' ===== SHOW PASSWORD =====
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirmPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    ' ===== ONLY NUMBERS FOR PHONE =====
    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' ===== ROLE CHANGE (FIXED ERROR HERE) =====
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged

        ' FIX: avoid null error
        If cmbRole.SelectedItem Is Nothing Then Exit Sub

        If cmbRole.SelectedItem.ToString() = "Admin" Then
            txtPhone.Visible = True
            lblPhone.Visible = True
        Else
            txtPhone.Visible = False
            lblPhone.Visible = False
        End If

    End Sub

End Class