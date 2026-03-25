Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class LoginForm

    Public Shared CurrentAdminID As Integer = 0

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' ===== VALIDATION =====
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or cmbRole.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill all fields", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Connect()

            Dim role As String = cmbRole.SelectedItem.ToString()
            Dim query As String = ""

            ' ===== SET QUERY BASED ON ROLE =====
            If role = "Admin" Then
                query = "SELECT * FROM Admins WHERE Username=@username AND Password=@password"

            ElseIf role = "User" Then
                query = "SELECT * FROM Users WHERE Email=@username AND Password=@password"

            Else
                MessageBox.Show("Please select a role", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

                Using reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        ' ===== ADMIN LOGIN =====
                        If role = "Admin" Then

                            Dim status As String = reader("Status").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim adminName As String = reader("AdminName").ToString()
                            Dim adminID As Integer = Convert.ToInt32(reader("AdminID"))

                            ' Store Admin ID
                            CurrentAdminID = adminID

                            ' Super Admin Check
                            If username = "superadmin@gmail.com" Then
                                MessageBox.Show("Super Admin Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Dim dash As New AdminDashboard()
                                dash.AdminName = adminName
                                dash.Show()
                                Me.Hide()
                                Exit Sub
                            End If

                            ' Status Check
                            If status = "Pending" Then
                                MessageBox.Show("Your admin request is still Pending. Please wait for approval.", "Pending", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub

                            ElseIf status = "Rejected" Then
                                MessageBox.Show("Your admin request has been Rejected.", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub

                            ElseIf status = "Approved" Then
                                MessageBox.Show("Admin Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Dim dash As New AdminDashboard()
                                dash.AdminName = adminName
                                dash.Show()
                                Me.Hide()
                            End If

                            ' ===== USER LOGIN =====
                        Else

                            ' ✅ Get real UserID from database
                            Dim userID As Integer = Convert.ToInt32(reader("UserID"))

                            ' ✅ Get name from email (remove @gmail.com part)
                            Dim email As String = txtUsername.Text.Trim()
                            Dim nameOnly As String = email
                            If email.Contains("@") Then
                                nameOnly = email.Split("@"c)(0)
                            End If

                            MessageBox.Show("User Login Successful! Welcome " & nameOnly, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' ✅ Open Dashboard and pass UserID + UserName
                            Dim userDash As New UserDashboard()
                            userDash.LoggedInUserName = nameOnly
                            userDash.LoggedInUserID = userID  ' ✅ THIS IS THE KEY FIX

                            userDash.Show()
                            Me.Hide()

                        End If

                    Else
                        MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End Using
            End Using

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim frm As New SignupForm()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

End Class