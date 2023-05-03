Imports System.Data.SqlClient
Public Class PlaceOrder
    Private ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
    ReadOnly CurrentOrder As New DataTable



    Private Sub PlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVOID.DataSource = SQLCommands.SQLFillTable("SELECT OrderID FROM OrderTable WHERE CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "' ORDER BY OrderID DESC")
        DGVMenu.DataSource = SQLCommands.SQLFillTable("SELECT ItemDescription, ItemPrice FROM Items")
        If CurrentOrder.Columns.Count = 0 Then
            CurrentOrder.Columns.Add("Dish", GetType(String))
            CurrentOrder.Columns.Add("Qty", GetType(Integer))
            CurrentOrder.Columns.Add("Current Total", GetType(Decimal))
        End If
        DGVCurrentOrder.DataSource = CurrentOrder
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        'Deletes OrderID created
        Dim DID As New SqlCommand("DELETE OrderTable WHERE OrderID = " & DGVOID.Rows(0).Cells(0).Value & "")
        connection.Open()
        If DID.ExecuteNonQuery() = 1 Then
            Me.Hide()
            MainMenu.Show()
        Else
            MessageBox.Show("ID did not delete")
        End If
        connection.Close()

    End Sub
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        For i = 0 To DGVCurrentOrder.Rows.Count - 1
            Dim IO As New SqlCommand("Insert into ItemsOrdered(Item, Quantity, CustomerID, OrderID, ItemStatus) VALUES (@Item, @Qty, @CID, @OID, @IS)", connection)
            If i = DGVCurrentOrder.Rows.Count - 1 Then
                Exit For
            End If

            IO.Parameters.Add("@Item", SqlDbType.Text).Value = DGVCurrentOrder.Rows(i).Cells(0).Value
            IO.Parameters.Add("@Qty", SqlDbType.Int).Value = DGVCurrentOrder.Rows(i).Cells(1).Value
            IO.Parameters.Add("@CID", SqlDbType.Int).Value = Login.DGVAccount.Rows(0).Cells(0).Value
            IO.Parameters.Add("@OID", SqlDbType.Int).Value = DGVOID.Rows(0).Cells(0).Value
            IO.Parameters.Add("@IS", SqlDbType.VarChar).Value = "Not Started"
            connection.Open()

            If IO.ExecuteNonQuery() = 1 Then
                Me.Hide()
                Order_Summary.Show()

            Else

                MessageBox.Show("Item has not been added")

            End If
            connection.Close()


        Next


        If Order_Summary.DGVSummary.Columns.Count = 0 Then
            For Each dgvc As DataGridViewColumn In DGVCurrentOrder.Columns
                Order_Summary.DGVSummary.Columns.Add(TryCast(dgvc.Clone(), DataGridViewColumn))
            Next
        End If

        Dim row As New DataGridViewRow()



        For i As Integer = 0 To DGVCurrentOrder.Rows.Count - 1
            row = DirectCast(DGVCurrentOrder.Rows(i).Clone(), DataGridViewRow)
            Dim intColIndex As Integer = 0
            For Each cell As DataGridViewCell In DGVCurrentOrder.Rows(i).Cells
                row.Cells(intColIndex).Value = cell.Value
                intColIndex += 1
            Next
            Order_Summary.DGVSummary.Rows.Add(row)
        Next

    End Sub




    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim R As DataRow
            Dim Exists As Boolean = False
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim Quantity As Integer = 0
            Dim CurrentTotal As Decimal = 0

            If DGVMenu.SelectedRows.Count > 0 Then
                If CurrentOrder.Rows.Count = 0 Then
                Else
                    For i = 0 To CurrentOrder.Rows.Count - 1
                        If DGVMenu.SelectedRows(0).Cells(0).Value = CurrentOrder(i)(0) Then
                            Exists = True
                        End If
                    Next
                End If


                If Exists = False Then
                    R = CurrentOrder.NewRow
                    R("Dish") = DGVMenu.SelectedRows(0).Cells(0).Value
                    R("Qty") = "1"
                    R("Current Total") = DGVMenu.SelectedRows(0).Cells(1).Value
                    CurrentOrder.Rows.Add(R)
                Else
                    For j = 0 To CurrentOrder.Rows.Count - 1
                        If DGVMenu.SelectedRows(0).Cells(0).Value = CurrentOrder(j)(0) Then
                            Quantity = CurrentOrder(j)(1)
                            Quantity += 1
                            CurrentOrder(j)(1) = Quantity
                            CurrentTotal = CurrentOrder(j)(2)
                            CurrentTotal += DGVMenu.SelectedRows(0).Cells(1).Value
                            CurrentOrder(j)(2) = CurrentTotal
                        End If
                    Next
                End If
            Else
                MsgBox("No Dish Selected")
                Exit Sub
            End If


        Catch
            MsgBox("Please have a dish from menu selected")

        End Try
        Dim totalO As Decimal
        totalO = 0.00
        For i As Integer = 0 To DGVCurrentOrder.Rows.Count - 1
            totalO += DGVCurrentOrder.Rows(i).Cells(2).Value
        Next
        LblOverallTotal.Text = totalO

    End Sub

    Private Sub BtnSub_Click(sender As Object, e As EventArgs) Handles BtnSub.Click
        Try
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim Quantity As Integer = 0
            Dim TotalBefore As Decimal = 0
            Dim TotalAfter As Decimal = 0

            If DGVCurrentOrder.SelectedRows(0).Cells(1).Value > 1 Then
                Quantity = DGVCurrentOrder.SelectedRows(0).Cells(1).Value
                TotalBefore = DGVCurrentOrder.SelectedRows(0).Cells(2).Value
                TotalAfter = (TotalBefore / Quantity) * (Quantity - 1)
                Quantity -= 1
                For i = 0 To CurrentOrder.Rows.Count - 1
                    If DGVCurrentOrder.SelectedRows(0).Cells(0).Value = CurrentOrder(i)(0) Then
                        CurrentOrder(i)(1) = Quantity
                        CurrentOrder(i)(2) = TotalAfter
                    End If

                Next
            Else
                For j = 0 To CurrentOrder.Rows.Count - 1
                    If DGVCurrentOrder.SelectedRows(0).Cells(0).Value = CurrentOrder(j)(0) Then
                        CurrentOrder(j).Delete()
                    End If
                Next
            End If
        Catch
            MsgBox("Select an Dish to be deleted")

        End Try
        Dim totalO As Decimal
        totalO = 0.00
        For i As Integer = 0 To DGVCurrentOrder.Rows.Count - 1
            totalO -= DGVCurrentOrder.Rows(i).Cells(2).Value
        Next
        LblOverallTotal.Text = totalO

    End Sub

    Private Sub CmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFilter.SelectedIndexChanged
        DGVMenu.DataSource = SQLCommands.SQLFillTable("SELECT ItemDescription, ItemPrice FROM Items WHERE ItemCategory LIKE '" & CmbFilter.Text & "'")
    End Sub

    Private Sub ChckVegan_CheckedChanged(sender As Object, e As EventArgs) Handles ChckVegan.CheckedChanged

        If CmbFilter.Text = "" Then
            DGVMenu.DataSource = SQLCommands.SQLFillTable("SELECT ItemDescription, ItemPrice FROM Items WHERE ItemDietary LIKE 'Vegan'")
        Else
            DGVMenu.DataSource = SQLCommands.SQLFillTable("SELECT ItemDescription, ItemPrice FROM Items WHERE ItemCategory LIKE '" & CmbFilter.Text & "' AND ItemDietary LIKE 'Vegan'")
        End If
        If ChckVegan.Checked = False Then
            DGVMenu.DataSource = SQLCommands.SQLFillTable("SELECT ItemDescription, ItemPrice FROM Items WHERE ItemCategory LIKE '" & CmbFilter.Text & "'")
        End If
    End Sub

    Private Sub CmbAllergy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAllergy.SelectedIndexChanged
        DGVMenu.DataSource = SQLCommands.SQLFillTable("SELECT ItemDescription, ItemPrice FROM Items WHERE ItemCategory LIKE '" & CmbFilter.Text & "' AND ItemAllergy NOT LIKE '" & CmbAllergy.Text & "' ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CmbFilter.ResetText()
        CmbAllergy.ResetText()
        ChckVegan.Checked = False

    End Sub
End Class