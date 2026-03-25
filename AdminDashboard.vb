Imports System.Windows.Forms

Public Class AdminDashboard
    Public AdminName As String

    ' ================= FORM LOAD =================
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Logout button position
        btnLogout.Top = panelSidebar.Height - btnLogout.Height - 20

        ' Welcome text
        lblWelcome.Text = "Welcome, " & AdminName

        ' LOAD DASHBOARD HOME 
        LoadFormInPanel(New AdminDashboardHome())

    End Sub

    ' ================= LOAD FORM FUNCTION =================
    Private Sub LoadFormInPanel(frm As Form)

        MainPanel.Controls.Clear()

        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        MainPanel.Controls.Add(frm)
        frm.Show()

    End Sub

    ' ================= BUTTON EVENTS =================

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadFormInPanel(New AdminDashboardHome())
    End Sub

    Private Sub btnViewRequests_Click(sender As Object, e As EventArgs) Handles btnViewRequests.Click
        LoadFormInPanel(New ViewRequestsForm())
    End Sub

    Private Sub btnManageMedicines_Click(sender As Object, e As EventArgs) Handles btnManageMedicines.Click
        LoadFormInPanel(New ManageMedicinesForm())
    End Sub

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        LoadFormInPanel(New AddAdminForm())
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        LoadFormInPanel(New HistoryForm())
    End Sub

    ' ================= LOGOUT =================
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        If MessageBox.Show("Are you sure you want to logout?", "Logout",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            If LoginForm.CurrentAdminID <> 0 Then
                LogHistory(LoginForm.CurrentAdminID, "Logout", "Admin logged out")
            End If
        Catch ex As Exception
            ' ignore
        End Try

        Dim login As New LoginForm()

        login.txtUsername.Text = ""
        login.txtPassword.Text = ""

        login.Show()

        Me.Close()

    End Sub

End Class