Imports System.Windows.Forms

Public Class AdminDashboard
    Public AdminName As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click

    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogout.Top = panelSidebar.Height - btnLogout.Height - 20
        lblWelcome.Text = "Welcome, " & AdminName

    End Sub

    Private Sub LoadFormInPanel(frm As Form)

        MainPanel.Controls.Clear()

        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        MainPanel.Controls.Add(frm)
        frm.Show()

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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If


        Try
            If LoginForm.CurrentAdminID <> 0 Then
                LogHistory(LoginForm.CurrentAdminID, "Logout", "Admin logged out")
            End If
        Catch ex As Exception

        End Try


        Dim login As New LoginForm()


        login.txtUsername.Text = ""
        login.txtPassword.Text = ""

        login.Show()


        Me.Close()

    End Sub
End Class
