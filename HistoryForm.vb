Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class HistoryForm

    ' ================= FORM LOAD =================
    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbFilter.Items.Clear()
        cmbFilter.Items.AddRange(New String() {"All", "Add", "Update", "Delete", "Login", "Logout", "Approve"})
        cmbFilter.SelectedIndex = 0

        dtFrom.Value = DateTime.Now.AddDays(-7)
        dtTo.Value = DateTime.Now

        LoadHistory()

        Timer1.Interval = 5000
        Timer1.Start()

    End Sub

    ' ================= LOAD HISTORY =================
    Private Sub LoadHistory()

        Try
            Connect()

            Dim query As String = "
            SELECT 
                A.AdminName,
                H.ActionType,
                H.Description,
                H.ActionDateTime
            FROM AdminHistory H
            INNER JOIN Admins A ON H.AdminID = A.AdminID
            ORDER BY H.ActionDateTime DESC"

            Dim da As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvHistory.DataSource = dt
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' ================= FILTER =================
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        Try
            Connect()

            Dim query As String = "
            SELECT 
                A.AdminName,
                H.ActionType,
                H.Description,
                H.ActionDateTime
            FROM AdminHistory H
            INNER JOIN Admins A ON H.AdminID = A.AdminID
            WHERE 1=1"

            ' 🔍 DATE FILTER
            query &= " AND H.ActionDateTime >= @from AND H.ActionDateTime < @to"

            ' 🔍 ACTION FILTER
            If cmbFilter.Text <> "All" Then
                query &= " AND H.ActionType=@type"
            End If

            ' 🔍 NAME FILTER
            If txtSearch.Text.Trim() <> "" Then
                query &= " AND A.AdminName LIKE @name"
            End If

            query &= " ORDER BY H.ActionDateTime DESC"

            Dim cmd As New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@from", dtFrom.Value.Date)
            cmd.Parameters.AddWithValue("@to", dtTo.Value.Date.AddDays(1))

            If cmbFilter.Text <> "All" Then
                cmd.Parameters.AddWithValue("@type", cmbFilter.Text)
            End If

            If txtSearch.Text.Trim() <> "" Then
                cmd.Parameters.AddWithValue("@name", "%" & txtSearch.Text.Trim() & "%")
            End If

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvHistory.DataSource = dt

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' ================= REFRESH =================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        txtSearch.Clear()
        cmbFilter.SelectedIndex = 0
        dtFrom.Value = DateTime.Now.AddDays(-7)
        dtTo.Value = DateTime.Now

        LoadHistory()

    End Sub

    ' ================= AUTO REFRESH =================
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadHistory()
    End Sub

    ' ================= ROW COLOR =================
    Private Sub dgvHistory_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvHistory.CellFormatting

        If dgvHistory.Columns(e.ColumnIndex).Name <> "ActionType" Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub

        If dgvHistory.Rows(e.RowIndex).Cells("ActionType").Value Is Nothing Then Exit Sub

        Dim action As String = dgvHistory.Rows(e.RowIndex).Cells("ActionType").Value.ToString()

        Select Case action
            Case "Add"
                dgvHistory.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen

            Case "Delete"
                dgvHistory.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral

            Case "Update"
                dgvHistory.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow

            Case "Login"
                dgvHistory.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightBlue

            Case "Logout"
                dgvHistory.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray

            Case "Approve"
                dgvHistory.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightPink
        End Select

    End Sub

    ' ================= EXPORT TO EXCEL =================
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click

        Try
            If dgvHistory.Rows.Count = 0 Then
                MessageBox.Show("No data to export!")
                Exit Sub
            End If

            Dim sfd As New SaveFileDialog()
            sfd.Filter = "Excel Files (*.csv)|*.csv"
            sfd.FileName = "AdminHistory.csv"

            If sfd.ShowDialog() = DialogResult.OK Then

                Using sw As New StreamWriter(sfd.FileName)

                    ' Headers
                    For i As Integer = 0 To dgvHistory.Columns.Count - 1
                        sw.Write(dgvHistory.Columns(i).HeaderText & ",")
                    Next
                    sw.WriteLine()

                    ' Data
                    For Each row As DataGridViewRow In dgvHistory.Rows
                        If Not row.IsNewRow Then
                            For Each cell As DataGridViewCell In row.Cells
                                sw.Write(If(cell.Value, "").ToString() & ",")
                            Next
                            sw.WriteLine()
                        End If
                    Next

                End Using

                MessageBox.Show("Excel Exported Successfully!")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' ================= EXPORT TO PDF =================
    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click

        Try
            If dgvHistory.Rows.Count = 0 Then
                MessageBox.Show("No data to export!")
                Exit Sub
            End If

            Dim sfd As New SaveFileDialog()
            sfd.Filter = "PDF Files (*.pdf)|*.pdf"
            sfd.FileName = "AdminHistory.pdf"

            If sfd.ShowDialog() = DialogResult.OK Then

                Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
                PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))

                doc.Open()

                Dim title As New Paragraph("Admin History Logs")
                title.Alignment = Element.ALIGN_CENTER
                title.SpacingAfter = 10
                doc.Add(title)

                Dim table As New PdfPTable(dgvHistory.Columns.Count)
                table.WidthPercentage = 100

                ' Headers
                For Each col As DataGridViewColumn In dgvHistory.Columns
                    table.AddCell(New Phrase(col.HeaderText))
                Next

                ' Data
                For Each row As DataGridViewRow In dgvHistory.Rows
                    If Not row.IsNewRow Then
                        For Each cell As DataGridViewCell In row.Cells
                            table.AddCell(If(cell.Value, "").ToString())
                        Next
                    End If
                Next

                doc.Add(table)
                doc.Close()

                MessageBox.Show("PDF Exported Successfully!")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class