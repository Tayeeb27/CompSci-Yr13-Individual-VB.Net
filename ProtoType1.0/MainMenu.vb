Imports System.Data.SqlClient
Public Class MainMenu
    Private ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
    Private Sub CustomerMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This allows the user to know that they have successfully signed in
        Label1.Text = "Welcome Back " & vbNewLine & Login.DGVAccount.Rows(0).Cells(1).Value
        'These DGVs are what I need to be able to carry out some of my systems
        DGVBookingDiffDate.DataSource = SQLCommands.SQLFillTable("SELECT * FROM BookingDiffDate WHERE BookingDate LIKE '" & Date.Now.ToLongDateString & "'")
        DGVBooking.DataSource = SQLCommands.SQLFillTable("SELECT * FROM Booking")
        DGVOrder.DataSource = SQLCommands.SQLFillTable("SELECT * FROM OrderTable")
        DGVT.DataSource = SQLCommands.SQLFillTable("SELECT * From TableBooked where 
[17:00:00] is Null AND
[18:00:00] is Null AND
[19:00:00] is Null AND
[20:00:00] is Null AND
[21:00:00] is Null AND
[22:00:00] is Null AND
[23:00:00] is Null")
        'when someone logs in the system will refresh to update the current system of any bookings made previously to be into todays booking
        'If there is nothing to update it will do nothing
        If DGVBookingDiffDate.Rows.Count > 0 Then
            For i As Integer = 0 To DGVBookingDiffDate.Rows.Count - 1
                If i = DGVBookingDiffDate.Rows.Count - 1 Then
                    Exit For
                End If
                For j As Integer = 0 To (DGVBookingDiffDate.Rows(i).Cells(4).Value)
                    'This updates the TableBooked Table
                    Dim UID As New SqlCommand("UPDATE TableBooked SET [" & DGVBookingDiffDate.Rows(i).Cells(5).Value & "] = @UBN where TableNO = @UTID", connection)
                    UID.Parameters.Add("@UBN", SqlDbType.Text).Value = DGVBookingDiffDate.Rows(i).Cells(0).Value
                    UID.Parameters.Add("@UTID", SqlDbType.Int).Value = DGVT.Rows(j).Cells(0).Value

                    connection.Open()
                    If UID.ExecuteNonQuery() = 1 Then
                        For k As Integer = 0 To DGVBookingDiffDate.Rows.Count - 1
                            If k = DGVBookingDiffDate.Rows.Count - 1 Then
                                Exit For
                            End If
                            'This will delete the bookings that have just been updated to TableBooked and from the different date bookings
                            Dim DID As New SqlCommand("DELETE BookingDiffDate WHERE BookingID = " & DGVBookingDiffDate.Rows(k).Cells(1).Value & "", connection)
                            If DID.ExecuteNonQuery() = 1 Then

                            Else
                            End If
                        Next
                    End If
                    connection.Close()
                Next
            Next
        Else
            MsgBox("No Bookings")
        End If
    End Sub
    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnORDER.Click
        'This will allow any in housers to book a table before entering and allow them to check availibility
        Dim Msg = MsgBox("Are you sitting in?" & vbNewLine & "If you are, please book your seats by clicking Yes", vbYesNo)
        If Msg = MsgBoxResult.Yes Then
            Me.Hide()
            Book.Show()
        Else
            'This will create their OrderID
            Dim command As New SqlCommand("Insert into OrderTable(TableNo, AddInfo, LCR, CustomerID, OrderDate, OrderTime, TypeOfOrder, OrderDay, OrderStatus, Total, CAddress) values(@TN, @AI,@LCR,@CI,@OD,@OT,@ToO, @ODy,@OS,@OTT,@CA)", connection)

            command.Parameters.Add("@CI", SqlDbType.Int).Value = Login.DGVAccount.Rows(0).Cells(0).Value
            command.Parameters.Add("@TN", SqlDbType.Text).Value = 0
            command.Parameters.Add("@AI", SqlDbType.Text).Value = ""
            command.Parameters.Add("@LCR", SqlDbType.Text).Value = 0
            command.Parameters.Add("@OD", SqlDbType.Date).Value = Date.Now.ToShortDateString
            command.Parameters.Add("@OT", SqlDbType.VarChar).Value = ""
            command.Parameters.Add("@ToO", SqlDbType.Text).Value = ""
            command.Parameters.Add("@ODy", SqlDbType.VarChar).Value = ""
            command.Parameters.Add("@OS", SqlDbType.Text).Value = "Not Started"
            command.Parameters.Add("@CA", SqlDbType.VarChar).Value = ""
            command.Parameters.Add("@OTT", SqlDbType.Decimal).Value = 0.00
            connection.Open()
            If command.ExecuteNonQuery() = 1 Then
                'This will direct them to Order
                Me.Hide()
                PlaceOrder.Show()
            Else
            End If
            connection.Close()
        End If

    End Sub
    Private Sub BtnMyAcc_Click(sender As Object, e As EventArgs) Handles BtnMyAcc.Click
        'This directs them to view their Account Details
        Me.Hide()
        My_Account.Show()
        Extras.MyAccountFill()
    End Sub
    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        'This will sign them out
        Me.Hide()
        Login.Show()
        Login.TxtEmail.Clear()
        Login.TxtPassword.Clear()
    End Sub
    Private Sub BtnOrderStatus_Click(sender As Object, e As EventArgs) Handles BtnOrderStatus.Click
        'This will allow them to view the Booking/Order Status
        Me.Hide()
        Order_BookingStatus.Show()
    End Sub
    Private Sub BtnBO_Click(sender As Object, e As EventArgs) Handles BtnBook.Click

        'This creates their BookingID
        Dim BookingID As New SqlCommand("INSERT INTO Booking(ID,NumOfPpl, BookingDate, BookingTime, AddInfo, TblsNeeded, BookingStatus) values(@CID,@NoP,@D, @T, @AI, @TN, @BS)", connection)

        BookingID.Parameters.Add("@NoP", SqlDbType.Int).Value = 0
        BookingID.Parameters.Add("@D", SqlDbType.Text).Value = ""
        BookingID.Parameters.Add("@T", SqlDbType.Text).Value = ""
        BookingID.Parameters.Add("@AI", SqlDbType.Text).Value = ""
        BookingID.Parameters.Add("@TN", SqlDbType.Int).Value = 0
        BookingID.Parameters.Add("@CID", SqlDbType.Int).Value = Login.DGVAccount.Rows(0).Cells(0).Value
        BookingID.Parameters.Add("@BS", SqlDbType.Text).Value = ""

        connection.Open()
        If BookingID.ExecuteNonQuery() = 1 Then
            'This will direct them to Book
            Me.Hide()
            Book.Show()
        Else
        End If
        connection.Close()
    End Sub
    Private Sub BtnOrders_Click(sender As Object, e As EventArgs) Handles BtnOrders.Click
        Me.Hide()
        CustomersOrders.Show()
    End Sub
    Private Sub BtnInomeAnalysis_Click(sender As Object, e As EventArgs) Handles BtnInomeAnalysis.Click
        Me.Hide()
        Income_Analysis.Show()
    End Sub

    Private Sub BtnAddStaff_Click(sender As Object, e As EventArgs) Handles BtnAddStaff.Click
        Me.Hide()
        TCGSCA.Show()
    End Sub
    Private Sub BtnDataAnalysis_Click(sender As Object, e As EventArgs) Handles BtnDataAnalysis.Click
        Me.Hide()
        Data_Analysis.Show()
    End Sub

    Private Sub BtnBookings_Click(sender As Object, e As EventArgs) Handles BtnBookings.Click
        Me.Hide()
        Bookings_Orders.Show()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        If DGVBooking.Rows.Count > 1 Then
            Dim DID As New SqlCommand("DELETE Booking WHERE NumOfPpl = @NP  DBCC CHECKIDENT ('Booking', RESEED, " & DGVBooking.Rows.Count - 1 & ")", connection)
            DID.Parameters.Add("@NP", SqlDbType.Int).Value = 0

            connection.Open()
            If DID.ExecuteNonQuery() = 1 Then
            Else
            End If
            connection.Close()
        Else
        End If
        If DGVOrder.Rows.Count > 1 Then
            Dim DOID As New SqlCommand("DELETE OrderTable WHERE OrderTotal LIKE @OT DBCC CHECKIDENT ('Booking', RESEED, " & DGVOrder.Rows.Count - 1 & ")", connection)
            DOID.Parameters.Add("@OT", SqlDbType.Text).Value = 0

            connection.Open()
            If DOID.ExecuteNonQuery() = 1 Then
            Else
            End If
            connection.Close()
        Else
        End If
    End Sub
End Class