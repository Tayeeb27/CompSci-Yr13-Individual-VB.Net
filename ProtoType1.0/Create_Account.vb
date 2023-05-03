Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class Create_Account
    'Providing the SQL connection
    Private ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")

    Private Sub BtnComplete_Click(sender As Object, e As EventArgs) Handles BtnComplete.Click
        Dim FullName As String = TxtName.Text
        Dim PhoneNumber As String = TxtPhoneNumber.Text
        Dim AEmail As String = TxtEmail.Text
        Dim APassword As String = TxtPassword.Text
        Dim RePassword As String = TxtRePassword.Text
        Dim Address As String = TxtAddress.Text
        Dim Postcode As String = TxtPostCode.Text
        'Dim ErrorCheck As Boolean

        'Validation 
        'Validation.PresenceCheck(FullName, "Name")
        'Validation.PresenceCheck(PhoneNumber, "PhoneNumber")
        'Validation.PresenceCheck(AEmail, "Email")
        'Validation.PresenceCheck(APassword, "Password")
        'Validation.PresenceCheck(Address, "Address")
        'Validation.PresenceCheck(Postcode, "Postcode")
        'Validation.EmailFormatCheck(AEmail)
        'Validation.LengthCheck(PhoneNumber, 12, 10, "Must be 11 Numbers")
        'Validation.DataTypeCheck(PhoneNumber, False, "PhoneNumber", "Numbers")
        'Validation.LengthCheck(APassword, 20,6,"Must contain more than 6 characters")
        'Validation.DoubleKeying(APassword,RePassword,"Must Match")





        'Adding Account to table
        Dim AddAccount As New SqlCommand("Insert into Account(FullName, PhoneNumber, AEmail, APassword, AccessLvl) values(@FN,@PN,@E, @PW,@AL)", connection)
            AddAccount.Parameters.Add("@FN", SqlDbType.Text).Value = FullName
            AddAccount.Parameters.Add("@PN", SqlDbType.Text).Value = PhoneNumber
            AddAccount.Parameters.Add("@E", SqlDbType.VarChar).Value = AEmail
            AddAccount.Parameters.Add("@PW", SqlDbType.VarChar).Value = APassword
            AddAccount.Parameters.Add("@AL", SqlDbType.Text).Value = "Customer"


            connection.Open()
            If AddAccount.ExecuteNonQuery() = 1 Then

                MessageBox.Show("New Customer Account Created")
                Try
                    Email.Main(AEmail, "The Curry Garden", "Hello " & FullName & vbNewLine & "Welcome to The Curry Garden Family. Thank you for creating an account with us," & vbNewLine & "Stay Blessed, The Curry Garden")
                DGVNewAccount.DataSource = SQLCommands.SQLFillTable("SELECT ID from Account Where AEmail = '" & AEmail & "'")


            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try

        Else

            MessageBox.Show("Customer Account Not Created")

        End If

        connection.Close()

        'Adding Account Addresses to their table
        Dim AddAddress As New SqlCommand("insert into AAddress(Address, Postcode, CustomerID) values(@A, @PC,@CID)", connection)

        AddAddress.Parameters.Add("@A", SqlDbType.VarChar).Value = Address
        AddAddress.Parameters.Add("@PC", SqlDbType.VarChar).Value = Postcode
        AddAddress.Parameters.Add("@CID", SqlDbType.Int).Value = DGVNewAccount.Rows(0).Cells(0).Value
        connection.Open()
            If AddAddress.ExecuteNonQuery() = 1 Then
            Else
                MessageBox.Show("Address Not Added")

            End If
            connection.Close()
        Dim LoyaltyCard As New SqlCommand("INSERT INTO LoyaltyCard(CustomerID,[1],[2],[3],[4],[5],[6],[7],[8]) VALUES (@CID,@1,@2,@3,@4,@5,@6,@7,@8)", connection)
        LoyaltyCard.Parameters.Add("@CID", SqlDbType.Int).Value = DGVNewAccount.Rows(0).Cells(0).Value
        LoyaltyCard.Parameters.Add("@1", SqlDbType.VarChar).Value = "Null"
        LoyaltyCard.Parameters.Add("@2", SqlDbType.VarChar).Value = "Null"
        LoyaltyCard.Parameters.Add("@3", SqlDbType.VarChar).Value = "Null"
        LoyaltyCard.Parameters.Add("@4", SqlDbType.VarChar).Value = "Null"
        LoyaltyCard.Parameters.Add("@5", SqlDbType.VarChar).Value = "Null"
        LoyaltyCard.Parameters.Add("@6", SqlDbType.VarChar).Value = "Null"
        LoyaltyCard.Parameters.Add("@7", SqlDbType.VarChar).Value = "Null"
        LoyaltyCard.Parameters.Add("@8", SqlDbType.VarChar).Value = "Null"
        connection.Open()
        If AddAddress.ExecuteNonQuery() = 1 Then
        Else
            MessageBox.Show("LoyaltyCard Not Added")

        End If
        connection.Close()
    End Sub

    Private Sub Btni_Click(sender As Object, e As EventArgs) Handles Btni.Click
        MsgBox(" Password must contain uppercase, lowercase, numbers and special characters and a minimum of 6 characters", vbExclamation)
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub PbShow_Click(sender As Object, e As EventArgs) Handles PbShow.Click
        'Shows Password Text
        TxtPassword.UseSystemPasswordChar = False
        TxtRePassword.UseSystemPasswordChar = False
        PbShow.Hide()
        PbHide.Show()
    End Sub

    Private Sub PbHide_Click(sender As Object, e As EventArgs) Handles PbHide.Click
        'Hides Password Text again
        TxtPassword.UseSystemPasswordChar = True
        TxtRePassword.UseSystemPasswordChar = True
        PbHide.Hide()
        PbShow.Show()

    End Sub
End Class