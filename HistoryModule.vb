Imports System.Data.SqlClient
Imports System.Windows.Forms

Module HistoryModule

    Public Sub LogHistory(adminID As Integer, actionType As String, description As String)

        Try
            Connect()

            Dim query As String = "INSERT INTO AdminHistory (AdminID, ActionType, Description) 
                                  VALUES (@adminID, @action, @desc)"

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@adminID", adminID)
            cmd.Parameters.AddWithValue("@action", actionType)
            cmd.Parameters.AddWithValue("@desc", description)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("History Error: " & ex.Message)
        End Try

    End Sub

End Module
