Imports System.Data.SqlClient
Public Class Bookings_Orders
    Dim connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")

    Private Sub Bookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub DGVBooking_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBooking.CellContentClick
        Dim grid = DirectCast(sender, DataGridView)
        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn Then
            If grid.Columns(e.ColumnIndex).Name = "BookingComplete" Then
                Dim cmd As New SqlCommand("UPDATE Booking SET BookingStatus = 'Done' where BookingID = @BID", connection)
                cmd.Parameters.Add("@BID", SqlDbType.Int).Value = DGVBooking.Rows(e.RowIndex).Cells(1).Value
                connection.Open()
                If cmd.ExecuteNonQuery() = 1 Then
                    Me.DGVBooking.CurrentCell = Nothing
                    Me.DGVBooking.Rows(e.RowIndex).Visible = False
                Else
                End If
                connection.Close()
            End If
        End If

    End Sub
    Private Sub DGVOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrders.CellContentClick
        Dim grid = DirectCast(sender, DataGridView)
        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn Then
            If grid.Columns(e.ColumnIndex).Name = "OrderComplete" Then

                Dim cmd As New SqlCommand("UPDATE OrderTable SET OrderStatus = 'Done' where OrderID = @OID", connection)
                cmd.Parameters.Add("@OID", SqlDbType.Int).Value = DGVOrders.Rows(e.RowIndex).Cells(1).Value
                connection.Open()
                If cmd.ExecuteNonQuery() = 1 Then

                    Me.DGVOrders.CurrentCell = Nothing
                    Me.DGVOrders.Rows(e.RowIndex).Visible = False
                Else
                End If
                connection.Close()
            End If
        End If
    End Sub

    Private Sub CmbChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbChoice.SelectedIndexChanged
        If CmbChoice.Text = "Bookings" Then
            DGVBooking.DataSource = SQLCommands.SQLFillTable("SELECT Account.FullName, Booking.TblsNeeded,Booking.AddInfo fROM Booking JOIN Account ON Booking.ID = Account.ID WHERE BookingStatus NOT LIKE 'Done'")
            DGVBooking.Show()
            DGVOrders.Hide()
        ElseIf CmbChoice.Text = "Orders" Then
            DGVOrders.DataSource = SQLCommands.SQLFillTable("SELECT OrderTable.OrderID, Account.FullName, OrderTable.TableNo, OrderTable.AddInfo fROM OrderTable JOIN Account ON OrderTable.CustomerID = Account.ID WHERE OrderStatus NOT LIKE 'Done'")
            DGVOrders.Show()
            DGVBooking.Hide()
        End If

    End Sub
End Class