Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ViewRequestsForm

    Private Sub ViewRequestsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRequests()
    End Sub

    Private Sub LoadRequests()

        Try
            Connect()

            Dim query As String = "SELECT AdminID, AdminName, Username, Phone, Status 
                                  FROM Admins WHERE Status='Pending'"

            Dim da As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()

            da.Fill(dt)
            dgvRequests.DataSource = dt

            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRequests.MultiSelect = False
            dgvRequests.ReadOnly = True

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' ================= APPROVE =================
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        If dgvRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a request first")
            Exit Sub
        End If

        Dim id As Integer = dgvRequests.SelectedRows(0).Cells("AdminID").Value
        Dim name As String = dgvRequests.SelectedRows(0).Cells("AdminName").Value.ToString()

        Try
            Connect()

            Dim query As String = "UPDATE Admins SET Status='Approved' WHERE AdminID=@id"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()

            '  HISTORY LOG
            LogHistory(LoginForm.CurrentAdminID, "Approve Admin",
                       "Approved Admin: " & name & " (ID: " & id & ")")

            MessageBox.Show("Admin Approved")

            con.Close()
            LoadRequests()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' ================= REJECT =================
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click

        If dgvRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a request first")
            Exit Sub
        End If

        Dim id As Integer = dgvRequests.SelectedRows(0).Cells("AdminID").Value
        Dim name As String = dgvRequests.SelectedRows(0).Cells("AdminName").Value.ToString()

        Try
            Connect()

            Dim query As String = "UPDATE Admins SET Status='Rejected' WHERE AdminID=@id"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()

            ' HISTORY LOG
            LogHistory(LoginForm.CurrentAdminID, "Reject Admin",
                       "Rejected Admin: " & name & " (ID: " & id & ")")

            MessageBox.Show("Admin Rejected")

            con.Close()
            LoadRequests()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class