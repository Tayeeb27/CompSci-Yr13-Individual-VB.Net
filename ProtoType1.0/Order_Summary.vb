Imports System.Data.SqlClient
Public Class Order_Summary
    Private ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")

    Private Sub Order_Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblTotal.Text = PlaceOrder.LblOverallTotal.Text

        DGVA.DataSource = SQLCommands.SQLFillTable("SELECT * FROM AAddress WHERE CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "'")
        DGVOrders.DataSource = SQLCommands.SQLFillTable("SELECT * FROM OrderTable WHERE CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "'ORDER BY OrderID DESC")



    End Sub


    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Dim time As DateTime = Validation.RoundedHour()
        Dim OrderDate As String = Now.Year & "-" & Now.Month.ToString("D2") & "-" & Now.Day.ToString("D2")


        Dim command As New SqlCommand("UPDATE OrderTable SET TableNo = @TN, AddInfo = @AI, LCR = @LCR, CustomerID = @CI, OrderDate = @OD, OrderTime = @OT, TypeOfOrder = @ToO, OrderDay = @ODy, OrderStatus = @OS, Total = @OTT, CAddress = @CA WHERE CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "'AND OrderID = '" & DGVOrders.Rows(0).Cells(0).Value & "'", connection)

        Dim format As String =
        command.Parameters.Add("@CI", SqlDbType.Int).Value = Login.DGVAccount.Rows(0).Cells(0).Value
        command.Parameters.Add("@TN", SqlDbType.Text).Value = Val(TxtChoice.Text)
        command.Parameters.Add("@AI", SqlDbType.Text).Value = (RichTextBox1.Text)
        command.Parameters.Add("@LCR", SqlDbType.Text).Value = 0
        command.Parameters.Add("@OD", SqlDbType.Date).Value = OrderDate
        command.Parameters.Add("@OT", SqlDbType.VarChar).Value = time.ToLongTimeString
        command.Parameters.Add("@ToO", SqlDbType.Text).Value = CmbChoice.Text
        command.Parameters.Add("@ODy", SqlDbType.VarChar).Value = Today.DayOfWeek.ToString
        command.Parameters.Add("@OS", SqlDbType.Text).Value = "Not Started"
        command.Parameters.Add("@OTT", SqlDbType.Decimal).Value = Val(LblOverallTotal.Text)
        command.Parameters.Add("@CA", SqlDbType.VarChar).Value = CmbAddresses.Text



        connection.Open()
            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Order has been made")
                Try


                Catch error_t As Exception
                    MsgBox(error_t.ToString)
                End Try

            Else

                MessageBox.Show("Order has not been added")

            End If


        connection.Close()
        Me.Hide()
        MainMenu.Show()

    End Sub

    Private Sub CmbChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbChoice.SelectedIndexChanged
        If CmbChoice.Text = "In House" Then
            CmbAddresses.Hide()
            TxtPC.Hide()
            LblChoice.Show()
            TxtChoice.Show()
            TxtChoice.Clear()
            LblNewAdd.Text = ""
            BtnAdd.Hide()
            LblChoice.Text = "Table No."
            DGVT.DataSource = SQLCommands.SQLFillTable("SELECT TableNO FROM TableBooked
WHERE [17:00:00] LIKE '" & Login.DGVAccount.Rows(0).Cells(1).Value & "'
   OR [18:00:00] LIKE '" & Login.DGVAccount.Rows(0).Cells(1).Value & "'
   OR [19:00:00] LIKE '" & Login.DGVAccount.Rows(0).Cells(1).Value & "'
   OR [20:00:00] LIKE '" & Login.DGVAccount.Rows(0).Cells(1).Value & "'
   OR [21:00:00] LIKE '" & Login.DGVAccount.Rows(0).Cells(1).Value & "'
   OR [22:00:00] LIKE '" & Login.DGVAccount.Rows(0).Cells(1).Value & "'
   OR [23:00:00] LIKE '" & Login.DGVAccount.Rows(0).Cells(1).Value & "'")
            Dim array As String() = New String(DGVT.Rows.Count - 1) {}

            For i As Integer = 0 To DGVT.Rows.Count - 1
                If i = DGVT.Rows.Count - 1 Then
                    Exit For
                End If
                array(i) = DGVT.Rows(i).Cells(0).Value
            Next
            TxtChoice.Text = String.Join(" ", array)
        ElseIf CmbChoice.Text = "Delivery" Then
            LblChoice.Show()
            TxtChoice.Clear()
            TxtChoice.Hide()
            LblChoice.Text = "Address"
            CmbAddresses.Show()
            TxtPC.Show()
            BtnAdd.Show()
            CmbAddresses.DataSource = SQLCommands.SQLFillTable("SELECT Address FROM AAddress WHERE CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "'")
            CmbAddresses.DisplayMember = "Address"
            LblNewAdd.Text = "To Add/Use a New Address Simply type the Address in the first box and Postcode in the second"

        ElseIf CmbChoice.Text = "Takeaway" Then
            LblChoice.Hide()
            TxtChoice.Hide()
            CmbAddresses.Hide()
            TxtPC.Hide()
            BtnAdd.Hide()
            LblNewAdd.Text = ""



        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        PlaceOrder.Show()

    End Sub

    Private Sub CmbAddresses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAddresses.SelectedIndexChanged
        DGVPC.DataSource = SQLCommands.SQLFillTable("SELECT Postcode FROM AAddress WHERE CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "' AND Address = '" & CmbAddresses.Text & "'")
        TxtPC.Text = DGVPC.Rows(0).Cells(0).Value
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim AddAddress As New SqlCommand("insert into AAddress(Address, Postcode, CustomerID) values(@A, @PC,@CID)", connection)

        AddAddress.Parameters.Add("@A", SqlDbType.VarChar).Value = CmbAddresses.Text
        AddAddress.Parameters.Add("@PC", SqlDbType.VarChar).Value = TxtPC.Text
        AddAddress.Parameters.Add("@CID", SqlDbType.Int).Value = Login.DGVAccount.Rows(0).Cells(0).Value
        connection.Open()
        If AddAddress.ExecuteNonQuery() = 1 Then
        Else
            MessageBox.Show("Address Not Added")

        End If
        connection.Close()
    End Sub


End Class