Imports System.Data.SqlClient
Public Class Login
    'Declaring the connection
    ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
    Private Sub BtnCA_Click(sender As Object, e As EventArgs) Handles BtnCA.Click
        'It will direct them to the Create Account Form
        Me.Hide()
        Create_Account.Show()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim AEmail As String = TxtEmail.Text
        Dim APassword As String = TxtPassword.Text

        'Validation
        'Dim ErrorCheck As Boolean
        Validation.PresenceCheck(AEmail, "Email")
        Validation.PresenceCheck(APassword, "Password")
        Validation.EmailFormatCheck(AEmail)

        'If ErrorCheck = False Then

        'Login SQL Command
        Dim Login As New SqlCommand("Select * from Account where AEmail = @Email and APassword = @Password", connection)

        Login.Parameters.Add("@Email", SqlDbType.VarChar).Value = AEmail
        Login.Parameters.Add("@Password", SqlDbType.VarChar).Value = APassword

        Dim Adapter As New SqlDataAdapter(Login)
        Dim Table As New DataTable()

        Adapter.Fill(Table)
        'Looks in table to see whether the Email and Password are in there
        If Table.Rows.Count() <= 0 Then
            MessageBox.Show("Email is not recognised")
        Else
            'If successful it will direct them to their assocciated menu
            DGVAccount.DataSource = SQLCommands.SQLFillTable("Select * From Account Where AEmail = '" + AEmail + "'")
            If DGVAccount.Rows(0).Cells(6).Value = "Customer" Then
                MainMenu.BtnBookings.Hide()
                MainMenu.BtnDataAnalysis.Hide()
                MainMenu.BtnAddStaff.Hide()
                MainMenu.BtnInomeAnalysis.Hide()
                MainMenu.BtnRefresh.Hide()
                MainMenu.BtnOrderStatus.Show()
                MainMenu.BtnOrders.Show()

                Me.Hide()
                MainMenu.Show()
            ElseIf DGVAccount.Rows(0).Cells(6).Value = "Waiter" Then
                MainMenu.BtnOrderStatus.Hide()
                MainMenu.BtnOrders.Hide()
                MainMenu.BtnAddStaff.Hide()
                MainMenu.BtnInomeAnalysis.Hide()
                MainMenu.BtnBookings.Show()
                MainMenu.BtnDataAnalysis.Show()
                MainMenu.BtnRefresh.Show()
                MainMenu.BtnMyAcc.Location = New Point(122, 497)
                Me.Hide()
                MainMenu.Show()
            ElseIf DGVAccount.Rows(0).Cells(6).Value = "Cook" Then
                Me.Hide()
                Cook.Show()
            ElseIf DGVAccount.Rows(0).Cells(6).Value = "Owner" Then
                MainMenu.BtnOrderStatus.Hide()
                MainMenu.BtnOrders.Hide()
                MainMenu.BtnBookings.Show()
                MainMenu.BtnDataAnalysis.Show()
                MainMenu.BtnAddStaff.Show()
                MainMenu.BtnInomeAnalysis.Show()
                MainMenu.BtnRefresh.Show()
                MainMenu.BtnMyAcc.Size = New Size(144, 76)
                MainMenu.BtnMyAcc.Location = New Point(0, 598)

                Me.Hide()
                MainMenu.Show()
            ElseIf DGVAccount.Rows(0).Cells(6).Value = "Driver" Then
                Me.Hide()
                Driver.Show()
            End If

        End If
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        'Back to Startup Form
        Me.Hide()
        Startup.Show()
    End Sub
    Private Sub PbShow_Click(sender As Object, e As EventArgs) Handles PbShow.Click
        'Shows Password Text
        TxtPassword.UseSystemPasswordChar = False
        PbShow.Hide()
        PbHide.Show()
    End Sub
    Private Sub PbHide_Click(sender As Object, e As EventArgs) Handles PbHide.Click
        'Hides Password Text again
        TxtPassword.UseSystemPasswordChar = True
        PbHide.Hide()
        PbShow.Show()
    End Sub
    Private Sub BtnForgotPassword_Click(sender As Object, e As EventArgs) Handles BtnForgotPassword.Click
        Me.Hide()
        ForgotPassword.Show()
    End Sub
End Class