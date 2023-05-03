Public Class Order_BookingStatus
    Private Sub Order_BookingStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVOrders.DataSource = SQLCommands.SQLFillTable("SELECT OrderID, OrderStatus FROM OrderTable WHERE CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "' AND OrderDate = '" & Date.Now.ToLongDateString & "' AND OrderDATE NOT LIKE 'Completed' ORDER BY OrderID DESC")
        DGVBooking.DataSource = SQLCommands.SQLFillTable("SELECT BookingID, BookingStatus FROM Booking WHERE ID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "' AND BookingDate LIKE '" & Date.Now.ToLongDateString & "' AND BookingDATE NOT LIKE 'Completed' ORDER BY BookingID DESC")

        If DGVOrders.Rows.Count <= 1 Then
            Label2.Text = "You Currently Have No Orders in Place"
        Else
            Label2.Text = "Your Order Is " & DGVOrders.Rows(0).Cells(1).Value
            DGVItems.DataSource = SQLCommands.SQLFillTable("SELECT Item, ItemStatus WHERE OrderID = '" & DGVOrders.Rows(0).Cells(1).Value & "' AND OrderStatus NOT LIKE 'Done'")
        End If

        If DGVBooking.Rows.Count <= 1 Then
            Label3.Text = "You Currently Have No Bookings in Place"
        Else
            Label3.Text = "Your Booking Is " & DGVBooking.Rows(0).Cells(1).Value
        End If
    End Sub

    Private Sub BtnBack_Click_1(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        MainMenu.Show()

    End Sub


End Class