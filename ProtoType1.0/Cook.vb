Imports System.Data.SqlClient
Public Class Cook
    ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
    Private Sub Cook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingDGVs()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MainMenu.Show()
    End Sub
    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        Checkboxes(DGV1, e, 0, sender)
    End Sub
    Private Sub DGV2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellContentClick
        Checkboxes(DGV2, e, 1, sender)
    End Sub
    Private Sub DGV3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV3.CellContentClick
        Checkboxes(DGV3, e, 2, sender)
    End Sub
    Private Sub DGV4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV4.CellContentClick
        Checkboxes(DGV4, e, 3, sender)
    End Sub
    Private Sub DGV5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV5.CellContentClick
        Checkboxes(DGV5, e, 4, sender)
    End Sub
    Private Sub DGV6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV6.CellContentClick
        Checkboxes(DGV6, e, 5, sender)
    End Sub

    Private Sub Checkboxes(DGV As DataGridView, e As DataGridViewCellEventArgs, n As Integer, sender As Object)
        Dim grid = DirectCast(sender, DataGridView)

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn Then
            If grid.Columns(e.ColumnIndex).Name = DGV.Name & "Column3" Then

                Dim Cooked As New SqlCommand("UPDATE ItemsOrdered SET ItemStatus = 'Cooked' where Item = @IS AND OrderID = @OID", connection)
                Cooked.Parameters.Add("@IS", SqlDbType.VarChar).Value = DGV.Rows(e.RowIndex).Cells(5).Value
                Cooked.Parameters.Add("@OID", SqlDbType.Int).Value = DGVOrders.Rows(n).Cells(0).Value

                connection.Open()
                If Cooked.ExecuteNonQuery() = 1 Then
                    DGV.CurrentCell = Nothing
                    DGV.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                    DGV.Refresh()
                Else
                End If
                connection.Close()

            ElseIf grid.Columns(e.ColumnIndex).Name = DGV.Name & "Column2" Then
                Dim InProgress As New SqlCommand("UPDATE OrderTable SET OrderStatus = 'In Progress' where OrderID = @OID", connection)
                InProgress.Parameters.Add("@OID", SqlDbType.Int).Value = DGVOrders.Rows(n).Cells(0).Value
                connection.Open()
                If InProgress.ExecuteNonQuery() = 1 Then

                    Dim InIProgress As New SqlCommand("UPDATE ItemsOrdered SET ItemStatus = 'Cooking' where Item = @IS AND OrderID = @OID", connection)
                    InIProgress.Parameters.Add("@IS", SqlDbType.VarChar).Value = DGV.Rows(e.RowIndex).Cells(5).Value
                    InIProgress.Parameters.Add("@OID", SqlDbType.Int).Value = DGVOrders.Rows(n).Cells(0).Value

                    If InProgress.ExecuteNonQuery() = 1 Then
                        DGV.CurrentCell = Nothing
                        DGV.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
                        DGV.Refresh()

                    Else
                    End If
                Else
                End If
                connection.Close()

            ElseIf grid.Columns(e.ColumnIndex).Name = DGV.Name & "Column1" Then
                Dim IReady As New SqlCommand("UPDATE ItemsOrdered SET ItemStatus = 'Ready' where Item = @I AND OrderID = @OID", connection)
                IReady.Parameters.Add("@I", SqlDbType.VarChar).Value = DGV.Rows(e.RowIndex).Cells(5).Value
                IReady.Parameters.Add("@OID", SqlDbType.Int).Value = DGVOrders.Rows(n).Cells(0).Value

                connection.Open()
                If IReady.ExecuteNonQuery() = 1 Then
                    DGV.CurrentCell = Nothing
                    DGV.Rows(e.RowIndex).Visible = False
                    DGV.Refresh()
                End If
                connection.Close()
            End If
        End If

    End Sub
    Private Sub ReadyUpdate(DGV As DataGridView, n As Integer)
        Dim match As Boolean

        For i As Integer = 0 To DGV.Rows.Count - 1
            If i = DGV.Rows.Count - 1 Then
                Exit For
            End If
            If DGV.Rows(i).Cells(3).Value.Equals("Ready") Then
                match = True
            End If
        Next
        If match = True Then
            Dim Ready As New SqlCommand("UPDATE OrderTable SET OrderStatus = 'Ready' where OrderID = @OID", connection)
            Ready.Parameters.Add("@OID", SqlDbType.VarChar).Value = DGVOrders.Rows(n).Cells(0).Value
            connection.Open()
            If Ready.ExecuteNonQuery() = 1 Then
                LoadingDGVs()
            Else
            End If
            connection.Close()
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReadyUpdate(DGV1, 0)
        ReadyUpdate(DGV2, 1)
        ReadyUpdate(DGV3, 2)
        ReadyUpdate(DGV4, 3)
        ReadyUpdate(DGV5, 4)
        ReadyUpdate(DGV6, 5)

        DGVOrders.Refresh()
        Me.Refresh()

    End Sub
    Private Sub LoadingOrders(DGV As DataGridView, n As Integer)
        DGV.DataSource = SQLCommands.SQLFillTable("SELECT ItemStatus, Quantity, Item FROM ItemsOrdered WHERE OrderID = '" & DGVOrders.Rows(n).Cells(0).Value & "'")
    End Sub
    Private Sub ColourCheck(DGV As DataGridView)
        For i As Integer = 0 To DGV.Rows.Count - 1
            If i = DGV.Rows.Count - 1 Then
                Exit For
            End If
            If DGV.Rows(i).Cells(3).Value.Equals("Cooking") Then
                DGV.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
            ElseIf DGV.Rows(i).Cells(3).Value.Equals("Cooked") Then
                DGV.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf DGV.Rows(i).Cells(3).Value.Equals("Cooking") Then
                DGV.Rows(i).Visible = False
            End If
        Next
    End Sub
    Private Sub LoadingDGVs()
        DGVOrders.DataSource = SQLCommands.SQLFillTable("SELECT OrderID FROM OrderTable WHERE OrderStatus NOT LIKE 'Ready'")
        If DGVOrders.Rows.Count <= 1 Then
            LoadingOrders(DGV1, 0)
        ElseIf DGVOrders.Rows.Count = 2 Then
            LoadingOrders(DGV1, 0)
            LoadingOrders(DGV2, 1)
        ElseIf DGVOrders.Rows.Count = 3 Then
            LoadingOrders(DGV1, 0)
            LoadingOrders(DGV2, 1)
            LoadingOrders(DGV3, 2)
        ElseIf DGVOrders.Rows.Count = 4 Then
            LoadingOrders(DGV1, 0)
            LoadingOrders(DGV2, 1)
            LoadingOrders(DGV3, 2)
            LoadingOrders(DGV4, 3)
        ElseIf DGVOrders.Rows.Count = 5 Then
            LoadingOrders(DGV1, 0)
            LoadingOrders(DGV2, 1)
            LoadingOrders(DGV3, 2)
            LoadingOrders(DGV4, 3)
            LoadingOrders(DGV5, 4)
        ElseIf DGVOrders.Rows.Count >= 6 Then
            LoadingOrders(DGV1, 0)
            LoadingOrders(DGV2, 1)
            LoadingOrders(DGV3, 2)
            LoadingOrders(DGV4, 3)
            LoadingOrders(DGV5, 4)
            LoadingOrders(DGV6, 5)
        End If

        ColourCheck(DGV1)
        ColourCheck(DGV2)
        ColourCheck(DGV3)
        ColourCheck(DGV4)
        ColourCheck(DGV5)
        ColourCheck(DGV6)
    End Sub

    Private Sub BtnMyAcc_Click(sender As Object, e As EventArgs) Handles BtnMyAcc.Click
        Me.Hide()
        My_Account.Show()
        Extras.MyAccountFill()
    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        Me.Hide()
        Login.Show()
        Login.TxtEmail.Clear()
        Login.TxtPassword.Clear()
    End Sub
End Class