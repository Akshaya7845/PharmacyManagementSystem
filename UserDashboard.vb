Imports System.Windows.Forms

Public Class UserDashboard

    Public LoggedInUserName As String
    Public LoggedInUserID As Integer  ' ADD THIS

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcomeUser.Text = "Welcome " & LoggedInUserName
    End Sub

    Public Sub LoadForm(ByVal frm As Form)
        PanelMain.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        PanelMain.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnViewMedicines_Click(sender As Object, e As EventArgs) Handles btnViewMedicines.Click
        Dim frm As New ViewMedicinesForm()
        frm.currentUserID = LoggedInUserID  ' PASS USER ID
        LoadForm(frm)
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Dim frm As New CartForm()
        frm.currentUserID = LoggedInUserID  ' PASS USER ID
        frm.currentUserName = LoggedInUserName
        LoadForm(frm)
    End Sub



    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim frm As New PurchaseHistoryForm()
        frm.currentUserID = LoggedInUserID
        frm.currentUserName = LoggedInUserName
        LoadForm(frm)
    End Sub


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim frm As New UserDashboardHome()
        frm.currentUserID = LoggedInUserID
        frm.currentUserName = LoggedInUserName
        LoadForm(frm)
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Close()
    End Sub

    Private Sub lblWelcomeUser_Click(sender As Object, e As EventArgs) Handles lblWelcomeUser.Click
    End Sub

End Class