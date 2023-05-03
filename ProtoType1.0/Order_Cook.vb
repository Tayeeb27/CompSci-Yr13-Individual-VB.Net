Imports System.Data.SqlClient

Public Class Order_Cook


    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        Cook.Show()
    End Sub

    Private Sub Order_Cook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DGVOrders.DataSource = SQLCommands.SQLFillTable("SELECT Items.ItemDescription, Quantity, Items.ItemID, ID, Order.OrderID, Order.OrderDay
        'From ItemsOrdered 
        'Join Items 
        'On Items.ItemID = ItemsOrdered.ItemID 
        'Join Order 
        'On Order.CustomerID = ItemsOrdered.ID 
        'Where Order.OrderID = '" '& Val(Cook.TextBox1.Text) & "' AND Order.OrderDay = '" & Today.DayOfWeek.ToString & "'")

    End Sub

    Private Sub DGVOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrders.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

            'Reference the GridView Row.
            Dim row As DataGridViewRow = DGVOrders.Rows(e.RowIndex)

            'Set the CheckBox selection.
            row.Cells("Column1").Value = Convert.ToBoolean(row.Cells("Column1").EditedFormattedValue)

            'If CheckBox is checked, display Message Box.
            If Convert.ToBoolean(row.Cells("Column1").Value) Then
                Me.DGVOrders.CurrentCell = Nothing
                Me.DGVOrders.Rows(e.RowIndex).Visible = False

            End If

        End If

        'TextBox1.Text = DGVOrders.CurrentRow.Cells(1).Value
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then


            Dim row As DataGridViewRow = DGVOrders.Rows(e.RowIndex)


            row.Cells("Column1").Value = Convert.ToBoolean(row.Cells("Column1").EditedFormattedValue)


            If Convert.ToBoolean(row.Cells("Column1").Value) Then


                Me.DGVOrders.CurrentCell = Nothing

                Me.DGVOrders.Rows(e.RowIndex).Visible = False
                Dim connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")

                Dim cmd As New SqlCommand("UPDATE Order SET OrderStatus = 'Ready' where OrderID = @OID", connection)
                cmd.Parameters.Add("@OID", SqlDbType.Int).Value = DGVOrders.Rows(e.RowIndex).Cells(1).Value
                connection.Open()
                If cmd.ExecuteNonQuery() = 1 Then



                Else



                End If
                connection.Close()
            End If

        End If
    End Sub

End Class