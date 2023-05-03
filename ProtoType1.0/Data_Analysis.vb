Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Data_Analysis
    Private Sub Data_Analysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVOrders.DataSource = SQLCommands.SQLFillTable("SELECT * FROM OrderTable")
        LblTotalCustomer.Text = "Total Customers Entered: " & (DGVOrders.RowCount)

        LblMPD.Text = "Most Popular Dish: " & Startup.DGVMPD.Rows(0).Cells(0).Value

        LblDWLC.Text = "Day With Least Customers: " & Startup.DGVDay.Rows(0).Cells(0).Value
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        MainMenu.Show()

    End Sub
    Private Sub BtnHideMPD_Click(sender As Object, e As EventArgs) Handles BtnHideMPD.Click
        ChartMPD.Hide()
        BtnShowMPD.Show()

    End Sub

    Private Sub BtnShowMPD_Click(sender As Object, e As EventArgs) Handles BtnShowMPD.Click
        ChartMPD.Show()
        BtnShowMPD.Hide()
        ChartMPD.Series(0).Points.Clear()
        For Count As Integer = 0 To DGVMPD.Rows.Count - 2
            ChartMPD.Series(0).Points.AddXY(DGVMPD.Item(0, Count).Value, DGVMPD.Item(2, Count).Value)
        Next
    End Sub

    Private Sub BtnChart_Click(sender As Object, e As EventArgs) Handles BtnChartShow.Click
        Dim TodaysDate As Date = Now.Year & "-" & Now.Month.ToString("D2") & "-" & Now.Day.ToString("D2")
        Dim LastWeeksDate As Date = GetDayBefore()
        Dim dt As DataTable = SQLCommands.SQLFillTable("SELECT OrderDay, OrderTime, COUNT(OrderDay) AS TimeOccurence, OrderDate  FROM OrderTable WHERE OrderDate BETWEEN '2020-04-06' AND '2020-04-12' 
GROUP BY OrderDay, OrderTime, OrderDate
ORDER BY OrderDate ASC ")
        '" & TodaysDate & "' AND '" & LastWeeksDate & "'
        'This is the stack part of the stacked column chart.
        Dim Orders As List(Of String) = (From p In dt.AsEnumerable()
                                         Select p.Field(Of String)("OrderTime")).Distinct().ToList()

        'This will remove the Default Series.
        If ChartCTD.Series.Count() = 1 Then
            ChartCTD.Series.Remove(ChartCTD.Series(0))
        End If

        'This will Loop through the Orders.
        For Each Order As String In Orders

            'This will get the Day for each Order.
            Dim x As String() = (From p In dt.AsEnumerable()
                                 Where p.Field(Of String)("OrderTime") = Order
                                 Order By p.Field(Of Date)("OrderDate")
                                 Select p.Field(Of String)("OrderDay")).ToArray

            'This will get the total number of Orders.
            Dim y As Integer() = (From p In dt.AsEnumerable()
                                  Where p.Field(Of String)("OrderTime") = Order
                                  Order By p.Field(Of String)("OrderDay")
                                  Select p.Field(Of Integer)("TimeOccurence")).ToArray

            'Adding a Series to the Chart.
            ChartCTD.Series.Add(New Series(Order))
            ChartCTD.Series(Order).IsValueShownAsLabel = True
            ChartCTD.Series(Order).ChartType = SeriesChartType.StackedColumn
            ChartCTD.Series(Order).Points.DataBindXY(x, y)
        Next

        ChartCTD.Legends(0).Enabled = True
        BtnChartShow.Hide()
        ChartCTD.Show()
    End Sub
    Private Function GetDayBefore() As String
        Dim Start As Date = Date.Now
        Dim EndS As Date = Start.AddDays(-7)
        Dim Final As String = EndS.Year & "-" & EndS.Month.ToString("D2") & "-" & EndS.Day.ToString("D2")
        Return Final
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnChartHide.Click
        ChartCTD.Hide()
        BtnChartShow.Show()
    End Sub
End Class