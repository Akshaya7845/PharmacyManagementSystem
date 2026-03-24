'Imports System.Data.SqlClient
'Imports System.Windows.Forms

'Public Class AddAdminForm

'    ' ================= FORM LOAD =================
'    Private Sub AddAdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        ' Load roles
'        cmbRole.Items.Clear()
'        cmbRole.Items.Add("Admin")
'        cmbRole.Items.Add("SuperAdmin")
'        cmbRole.SelectedIndex = 0

'        ' 🔒 Password hidden by default
'        txtPassword.UseSystemPasswordChar = True

'        ' ✅ Checkbox default
'        chkShowPassword.Checked = False

'    End Sub

'    ' ================= SHOW PASSWORD =================
'    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

'        ' 🔥 ONE LINE BEST LOGIC
'        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked

'    End Sub

'    ' ================= ADD ADMIN =================
'    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

'        ' 🔴 VALIDATION
'        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or txtPhone.Text.Trim() = "" Then
'            MessageBox.Show("Please fill all fields")
'            Exit Sub
'        End If

'        ' Phone validation (10 digits)
'        If Not IsNumeric(txtPhone.Text) Or txtPhone.Text.Length <> 10 Then
'            MessageBox.Show("Enter valid 10-digit phone number")
'            Exit Sub
'        End If

'        Try
'            Connect()

'            Dim query As String = "INSERT INTO Admins (AdminName, Username, Password, Status, Phone) 
'                                  VALUES (@name,@user,@pass,'Pending',@phone)"

'            Dim cmd As New SqlCommand(query, con)

'            cmd.Parameters.AddWithValue("@name", txtUsername.Text.Trim())
'            cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
'            cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())
'            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim())

'            cmd.ExecuteNonQuery()

'            MessageBox.Show("Admin Added Successfully (Waiting for Approval)")

'            ClearFields()

'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        End Try

'    End Sub

'    ' ================= CLEAR =================
'    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
'        ClearFields()
'    End Sub

'    ' ================= CLEAR FUNCTION =================
'    Private Sub ClearFields()
'        txtUsername.Clear()
'        txtPassword.Clear()
'        txtPhone.Clear()
'        cmbRole.SelectedIndex = 0

'        ' 🔄 Reset password visibility
'        chkShowPassword.Checked = False

'        txtUsername.Focus()
'    End Sub

'End Class

Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class AddAdminForm

    ' ================= FORM LOAD =================
    Private Sub AddAdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbRole.Items.Clear()
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("SuperAdmin")
        cmbRole.SelectedIndex = 0

        txtPassword.UseSystemPasswordChar = True
        chkShowPassword.Checked = False

    End Sub

    ' ================= SHOW PASSWORD =================
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    ' ================= ADD ADMIN =================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        '  VALIDATION
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or txtPhone.Text.Trim() = "" Then
            MessageBox.Show("Please fill all fields")
            Exit Sub
        End If

        If Not IsNumeric(txtPhone.Text) Or txtPhone.Text.Length <> 10 Then
            MessageBox.Show("Enter valid 10-digit phone number")
            Exit Sub
        End If

        Try
            Connect()

            ' CHECK DUPLICATE USERNAME
            Dim checkQuery As String = "SELECT COUNT(*) FROM Admins WHERE Username=@user"
            Dim checkCmd As New SqlCommand(checkQuery, con)
            checkCmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())

            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                MessageBox.Show("Username already exists")
                Exit Sub
            End If

            ' INSERT ADMIN
            Dim query As String = "INSERT INTO Admins (AdminName, Username, Password, Status, Phone) 
                                  VALUES (@name,@user,@pass,'Pending',@phone);
                                  SELECT SCOPE_IDENTITY();"

            Dim cmd As New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@name", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim())


            Dim newAdminID As Integer = Convert.ToInt32(cmd.ExecuteScalar())


            LogHistory(LoginForm.CurrentAdminID, "Add Admin",
                       "Added new admin: " & txtUsername.Text)

            MessageBox.Show("Admin Added Successfully (Waiting for Approval)")

            ClearFields()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' ================= CLEAR FUNCTION =================
    Private Sub ClearFields()
        txtUsername.Clear()
        txtPassword.Clear()
        txtPhone.Clear()
        cmbRole.SelectedIndex = 0
        chkShowPassword.Checked = False
        txtUsername.Focus()
    End Sub

End Class