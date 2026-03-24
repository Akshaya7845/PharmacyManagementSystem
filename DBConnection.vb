Imports System.Data.SqlClient

Module DBConnection

    Public con As SqlConnection

    Public Sub Connect()
        con = New SqlConnection("Data Source=PSILENL097;Initial Catalog=PharmacyDB;Integrated Security=True")
        con.Open()
    End Sub

End Module
