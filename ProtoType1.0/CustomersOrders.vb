Imports System.Data.SqlClient

Public Class CustomersOrders
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVOrders.DataSource = SQLCommands.SQLFillTable("SELECT OrderID, OrderDate FROM OrderTable where CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "' ORDER BY OrderID DESC")


    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        MainMenu.Show()

    End Sub

    Private Sub DGVOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrders.CellClick
        DGVItemsOrdered.DataSource = SQLCommands.SQLFillTable("SELECT Item, Quantity FROM ItemsOrdered WHERE OrderID = " & DGVOrders.SelectedRows(0).Cells(0).Value & "")
    End Sub
End Class