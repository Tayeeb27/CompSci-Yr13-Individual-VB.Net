Imports System.Data.SqlClient
Module SQLCommands
    Public Function SQLFillTable(strSql As String)
        Dim con As SqlConnection = New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
        con.Open()

        Dim DA As SqlDataAdapter
        Dim DT As New DataTable

        DA = New SqlDataAdapter(strSql, con)
        DA.Fill(DT)
        con.Close()
        Return DT
    End Function
End Module
