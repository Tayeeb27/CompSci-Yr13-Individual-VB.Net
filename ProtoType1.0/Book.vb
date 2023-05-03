Imports System.Data.SqlClient
Public Class Book
    Private ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
    Private Sub BookOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Displays The Account ID From Account Table
        DGVBID.DataSource = SQLCommands.SQLFillTable("SELECT BookingID FROM Booking WHERE ID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "' ORDER BY BookingID DESC")


    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs)

        'Deletes BookingID created
        Dim DID As New SqlCommand("DELETE Booking WHERE BookingID = " & DGVBID.Rows(0).Cells(0).Value & "", connection)
        connection.Open()
        If DID.ExecuteNonQuery() = 1 Then
            Me.Hide()
            MainMenu.Show()
        Else
        End If
        connection.Close()
    End Sub
    Private Sub NudNoOfPpl_ValueChanged(sender As Object, e As EventArgs) Handles NudNoOfPpl.ValueChanged
        'Calculates the TableNeeded
        TxtTableNeeded.Text = Math.Round((NudNoOfPpl.Value / 1.99), 0)
    End Sub
    Private Sub BtnComplete_Click(sender As Object, e As EventArgs) Handles BtnComplete.Click
        Dim TimeT As String = CmbTimeT.Text
        'Checks if the table is available and if available it will book the table using their bookingID
        If DtpDate.Value = Date.Now.ToLongDateString Then
            For i = 0 To Val(TxtTableNeeded.Text)
                Dim UID As New SqlCommand("UPDATE TableBooked SET [" & TimeT & "] = @UBN where TableNO = @UTID", connection)
                UID.Parameters.Add("@UBN", SqlDbType.Text).Value = Login.DGVAccount.Rows(0).Cells(1).Value
                UID.Parameters.Add("@UTID", SqlDbType.Int).Value = DGVT.Rows(i).Cells(0).Value

                connection.Open()
                If UID.ExecuteNonQuery() = 1 Then
                    Me.Hide()
                    BookingSummary.Show()
                Else
                    MessageBox.Show("Table Not Available")
                End If
                connection.Close()
            Next

        Else
            'If the booking is for a different date then the system will log it down and on that day it will book the table first thing
            Dim BookingDiffDate As New SqlCommand("INSERT INTO BookingDiffDate(FullName, BookingID, BookingDate,  CustomerID, TablesNeeded, BookingTime) Values(@FN, @BID, @BD, @CID, @TN, @BT)", connection)

            BookingDiffDate.Parameters.Add("@FN", SqlDbType.Text).Value = Login.DGVAccount.Rows(0).Cells(1).Value
            BookingDiffDate.Parameters.Add("@BID", SqlDbType.Int).Value = DGVBID.Rows(0).Cells(0).Value
            BookingDiffDate.Parameters.Add("@BD", SqlDbType.Text).Value = DtpDate.Text
            BookingDiffDate.Parameters.Add("@CID", SqlDbType.Int).Value = Login.DGVAccount.Rows(0).Cells(0).Value
            BookingDiffDate.Parameters.Add("@TN", SqlDbType.Int).Value = Val(TxtTableNeeded.Text)
            BookingDiffDate.Parameters.Add("@BT", SqlDbType.Text).Value = TimeT

            connection.Open()
            If BookingDiffDate.ExecuteNonQuery() = 1 Then
                Me.Hide()
                BookingSummary.Show()
            Else
            End If
            connection.Close()
        End If




    End Sub

    Private Sub BtnBack_Click_1(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
    Private Sub CmbTimeT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTimeT.SelectedIndexChanged
        'It will display the Available Table
        DGVT.DataSource = SQLCommands.SQLFillTable("SELECT TableNO, [" & CmbTimeT.Text & "] From TableBooked where [" & CmbTimeT.Text & "] is Null")

    End Sub

    Private Sub ChckRightNow_CheckedChanged(sender As Object, e As EventArgs) Handles ChckRightNow.CheckedChanged
        'Right Now Checkbox allows the customer to be booked in for the time right now but in the correct time
        Dim KeyValue As String
        For i = CmbTimeT.Items.Count - 1 To 0 Step -1
            CmbTimeT.SelectedIndex = i
            'it will match the the rounded time to the times 
            KeyValue = Validation.RoundedHour()
        Next
        If ChckRightNow.Checked = False Then
            CmbTimeT.Text = ""
        End If

    End Sub
End Class