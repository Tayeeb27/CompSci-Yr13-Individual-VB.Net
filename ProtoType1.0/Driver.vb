Imports System.Data.SqlClient
Public Class Driver
    ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
    Private Sub Driver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVOrders.DataSource = SQLCommands.SQLFillTable("SELECT OrderTable.OrderID,Account.FullName  FROM OrderTable 
JOIN Account
ON OrderTable.CustomerID = Account.ID
Where OrderTable.TypeOfOrder LIKE 'Delivery'
AND OrderTable.OrderStatus LIKE 'Not Started'")

    End Sub
    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        Me.Hide()
        Login.Show()
        Login.TxtEmail.Clear()
        Login.TxtPassword.Clear()
    End Sub

    Private Sub BtnMyAcc_Click(sender As Object, e As EventArgs) Handles BtnMyAcc.Click
        Me.Hide()
        My_Account.Show()
        Extras.MyAccountFill()
    End Sub

    Private Sub DGVOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrders.CellClick
        DGVOtherInfo.DataSource = SQLCommands.SQLFillTable("SELECT OrderTable.OrderTotal, OrderTable.CAddress, AAddress.Postcode FROM OrderTable
JOIN AAddress
ON OrderTable.CAddress = AAddress.Address
WHERE OrderID = '" & DGVOrders.Rows(e.RowIndex).Cells(2).Value & "'")

        DGVOrder.DataSource = SQLCommands.SQLFillTable("SELECT Item, Quantity FROM ItemsOrdered WHERE OrderID = " & DGVOrders.Rows(e.RowIndex).Cells(2).Value & " AND CustomerID = (SELECT ID FROM Account WHERE FullName LIKE '" & DGVOrders.Rows(e.RowIndex).Cells(3).Value & "')")
    End Sub

    Private Sub DGVOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrders.CellContentClick
        Dim grid = DirectCast(sender, DataGridView)

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn Then
            If grid.Columns(e.ColumnIndex).Name = "DeliveryFinished" Then
                Dim IReady As New SqlCommand("UPDATE OrderTable SET OrderStatus = 'Done' where OrderID = @OID", connection)
                IReady.Parameters.Add("@OID", SqlDbType.Int).Value = DGVOrders.Rows(e.RowIndex).Cells(0).Value

                connection.Open()
                If IReady.ExecuteNonQuery() = 1 Then
                    DGVOrders.CurrentCell = Nothing
                    DGVOrders.Rows(e.RowIndex).Visible = False
                    DGVOrders.Refresh()
                End If
                connection.Close()
            End If
        End If
        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewComboBoxColumn Then
            If grid.Columns(e.ColumnIndex).Name = "DeliveryStatus" Then
                Dim IReady As New SqlCommand("UPDATE OrderTable SET OrderStatus = @OS  where OrderID = @OID", connection)
                IReady.Parameters.Add("@OID", SqlDbType.Int).Value = DGVOrders.Rows(e.RowIndex).Cells(0).Value
                IReady.Parameters.Add("@OS", SqlDbType.Text).Value = DGVOrders.Rows(e.RowIndex).Cells(1).Value

                connection.Open()
                If IReady.ExecuteNonQuery() = 1 Then
                    DGVOrders.CurrentCell = Nothing
                    DGVOrders.Rows(e.RowIndex).Visible = False
                    DGVOrders.Refresh()
                End If
                connection.Close()
            End If
        End If

    End Sub
End Class