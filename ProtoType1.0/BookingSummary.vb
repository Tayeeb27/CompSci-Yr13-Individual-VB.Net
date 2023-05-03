Imports System.Data.SqlClient
Public Class BookingSummary
    Private ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
    Private Sub BookingSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblName.Text = Login.DGVAccount.Rows(0).Cells(1).Value
        LblNOP.Text = Book.NudNoOfPpl.Value
        LblBD.Text = Book.DtpDate.Text
        LblBT.Text = Book.CmbTimeT.Text
        LblAI.Text = Book.TxtAddInfo.Text
    End Sub
    Private Sub BtnComplete_Click(sender As Object, e As EventArgs) Handles BtnComplete.Click

        'Insert the Booking Details into the booking table
        Dim Booking As New SqlCommand("UPDATE Booking SET ID = @CID, NumOfPpl = @NoP, BookingDate = @D, BookingTime = @T, AddInfo = @AI, TblsNeeded = @TN, BookingStatus = @BS  WHERE BookingID = " & Book.DGVBID.Rows(0).Cells(0).Value & "", connection)

        Booking.Parameters.Add("@NoP", SqlDbType.Int).Value = Book.NudNoOfPpl.Value
        Booking.Parameters.Add("@D", SqlDbType.Text).Value = Book.DtpDate.Text
        Booking.Parameters.Add("@T", SqlDbType.Text).Value = Book.CmbTimeT.Text
        Booking.Parameters.Add("@AI", SqlDbType.Text).Value = Book.TxtAddInfo.Text
        Booking.Parameters.Add("@TN", SqlDbType.Int).Value = Val(Book.TxtTableNeeded.Text)
        Booking.Parameters.Add("@CID", SqlDbType.Int).Value = Login.DGVAccount.Rows(0).Cells(0).Value
        Booking.Parameters.Add("@BS", SqlDbType.Text).Value = "Not Arrived"

        connection.Open()
        If Booking.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Booking Made")
            'Email.Main(Login.TxtEmail.Text, "A Booking Has Been Made", "Hello" & Login.DGVAccount.Rows(0).Cells(1).Value & vbNewLine & "Here's a summary of your booking" & vbNewLine & "Booking Name: " & vbNewLine & "Number of People Attending: " & vbNewLine & "Booking Date: " & vbNewLine & "Booking Time: " & vbNewLine & "Additional Information: " & vbNewLine & "If this isn't you please contact us" & vbNewLine & "Stay Blessed, The Curry Garden")
            Me.Hide()
            MainMenu.Show()
        Else
            MessageBox.Show("Booking Not Made")
        End If
        connection.Close()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        Book.Show()
    End Sub
End Class