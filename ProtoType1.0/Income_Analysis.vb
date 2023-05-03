Public Class Income_Analysis
    Private Sub Income_Analysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVIncome.DataSource = SQLCommands.SQLFillTable("SELECT OrderDate, SUM(Total) AS Total FROM OrderTable GROUP BY OrderDate ORDER BY OrderDate ASC ")
        Chart1.Series(0).Points.Clear()
        For Count As Integer = 0 To DGVIncome.Rows.Count - 2
            Chart1.Series(0).Points.AddXY(DGVIncome.Item(0, Count).Value, DGVIncome.Item(1, Count).Value)
        Next
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class