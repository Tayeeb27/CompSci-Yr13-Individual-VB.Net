Module Extras
    Public Function RoundedHour() As DateTime
        Dim dt As DateTime
        dt = Date.Now.ToShortTimeString

        Return DateTime.Parse(String.Format("{0:yyyy-MM-dd HH:00}", IIf(dt.Minute > 30, dt.AddHours(1), dt)))
    End Function

    Public Sub MyAccountFill()
        My_Account.DGVAddress.DataSource = SQLCommands.SQLFillTable("select Address, Postcode from AAddress where CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "'")
        My_Account.CmbAddresses.DataSource = SQLCommands.SQLFillTable("SELECT Address FROM AAddress WHERE CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "'")
        My_Account.CmbAddresses.DisplayMember = "Address"
        My_Account.TxtName.Text = Login.DGVAccount.Rows(0).Cells(1).Value
        My_Account.TxtPhoneNumber.Text = Login.DGVAccount.Rows(0).Cells(2).Value
        My_Account.TxtPassword.Text = Login.DGVAccount.Rows(0).Cells(4).Value
        My_Account.TxtEmail.Text = Login.DGVAccount.Rows(0).Cells(5).Value
    End Sub

End Module
