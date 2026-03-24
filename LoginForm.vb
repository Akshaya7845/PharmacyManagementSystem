'Imports System.Data.SqlClient
'Imports System.Windows.Forms

'Public Class LoginForm

'    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

'        ' ===== VALIDATION =====
'        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or cmbRole.SelectedItem Is Nothing Then
'            MessageBox.Show("Please fill all fields")
'            Exit Sub
'        End If

'        Try
'            Connect()

'            Dim role As String = cmbRole.SelectedItem.ToString()
'            Dim query As String = ""

'            ' ===== ADMIN LOGIN =====
'            If role = "Admin" Then

'                query = "SELECT * FROM Admins WHERE Username=@username AND Password=@password"

'                ' ===== USER LOGIN =====
'            ElseIf role = "User" Then

'                query = "SELECT * FROM Users WHERE Email=@username AND Password=@password"

'            Else
'                MessageBox.Show("Please select role")
'                Exit Sub
'            End If

'            Dim cmd As New SqlCommand(query, con)
'            cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
'            cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

'            Dim reader As SqlDataReader = cmd.ExecuteReader()

'            If reader.HasRows Then

'                reader.Read()

'                ' ===== ADMIN LOGIN FLOW =====
'                If role = "Admin" Then

'                    Dim status As String = reader("Status").ToString()
'                    Dim username As String = reader("Username").ToString()

'                    ' 👑 SUPER ADMIN CHECK
'                    If username = "superadmin@gmail.com" Then
'                        MessageBox.Show("Super Admin Login Successful")

'                        Dim dash As New AdminDashboard()
'                        dash.AdminName = reader("AdminName").ToString()
'                        dash.Show()
'                        Me.Hide()

'                        reader.Close()
'                        Exit Sub
'                    End If

'                    ' ===== NORMAL ADMIN =====
'                    If status = "Pending" Then
'                        MessageBox.Show("Admin request is still Pending")
'                        reader.Close()
'                        Exit Sub

'                    ElseIf status = "Rejected" Then
'                        MessageBox.Show("Admin request is Rejected")
'                        reader.Close()
'                        Exit Sub

'                    ElseIf status = "Approved" Then
'                        MessageBox.Show("Admin Login Successful")

'                        Dim dash As New AdminDashboard()
'                        dash.AdminName = reader("AdminName").ToString()
'                        dash.Show()
'                        Me.Hide()
'                    End If

'                Else
'                    ' ===== USER LOGIN =====
'                    MessageBox.Show("User Login Successful")

'                    Dim userDash As New UserDashboard()
'                    userDash.Show()
'                    Me.Hide()
'                End If

'            Else
'                MessageBox.Show("Invalid Username or Password")
'            End If

'            reader.Close()

'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        End Try

'    End Sub

'    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
'        Dim frm As New SignupForm()
'        frm.Show()
'        Me.Hide()
'    End Sub

'    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
'        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
'    End Sub


'End Class

Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class LoginForm

    Public Shared CurrentAdminID As Integer = 0

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' ===== VALIDATION =====
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or cmbRole.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill all fields")
            Exit Sub
        End If

        Try
            Connect()

            Dim role As String = cmbRole.SelectedItem.ToString()
            Dim query As String = ""

            ' ===== ADMIN LOGIN =====
            If role = "Admin" Then
                query = "SELECT * FROM Admins WHERE Username=@username AND Password=@password"

                ' ===== USER LOGIN =====
            ElseIf role = "User" Then
                query = "SELECT * FROM Users WHERE Email=@username AND Password=@password"

            Else
                MessageBox.Show("Please select role")
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

                            '  STORE ADMIN ID
                            CurrentAdminID = adminID

                            ' SUPER ADMIN
                            If username = "superadmin@gmail.com" Then
                                MessageBox.Show("Super Admin Login Successful")

                                Dim dash As New AdminDashboard()
                                dash.AdminName = adminName
                                dash.Show()
                                Me.Hide()
                                Exit Sub
                            End If

                            ' ===== STATUS CHECK =====
                            If status = "Pending" Then
                                MessageBox.Show("Admin request is still Pending")
                                Exit Sub

                            ElseIf status = "Rejected" Then
                                MessageBox.Show("Admin request is Rejected")
                                Exit Sub

                            ElseIf status = "Approved" Then
                                MessageBox.Show("Admin Login Successful")

                                Dim dash As New AdminDashboard()
                                dash.AdminName = adminName
                                dash.Show()
                                Me.Hide()
                            End If

                        Else
                            ' ===== USER LOGIN =====
                            MessageBox.Show("User Login Successful")

                            Dim userDash As New UserDashboard()
                            userDash.Show()
                            Me.Hide()
                        End If

                    Else
                        MessageBox.Show("Invalid Username or Password")
                    End If

                End Using
            End Using

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
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