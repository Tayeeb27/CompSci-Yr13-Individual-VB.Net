Imports System.Data.SqlClient
Public Class My_Account
    Private ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
    Private Sub My_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CmbAddresses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAddresses.SelectedIndexChanged
        DGVPC.DataSource = SQLCommands.SQLFillTable("SELECT Postcode FROM AAddress WHERE CustomerID = '" & Login.DGVAccount.Rows(0).Cells(0).Value & "' AND Address LIKE '" & CmbAddresses.Text & "'")
        TxtPostcode.Text = DGVPC.Rows(0).Cells(0).Value
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub BtnSaveChanges_Click(sender As Object, e As EventArgs) Handles BtnSaveChanges.Click
        Dim FullName As String = TxtName.Text
        Dim PhoneNumber As String = TxtPhoneNumber.Text
        Dim AEmail As String = TxtEmail.Text
        Dim APassword As String = TxtPassword.Text
        Dim RePassword As String = TxtRePassword.Text
        Dim Address As String = CmbAddresses.Text
        Dim Postcode As String = TxtPostCode.Text
        Dim ID As String = Login.DGVAccount.Rows(0).Cells(1).Value

        Dim UpdateAccount As New SqlCommand("UPDATE Account SET FullName = @FN, PhoneNumber = @PN, AEmail = @E, APassword = @PW WHERE ID = '" & ID & "'", connection)
        UpdateAccount.Parameters.Add("@FN", SqlDbType.Text).Value = FullName
        UpdateAccount.Parameters.Add("@PN", SqlDbType.Text).Value = PhoneNumber
        UpdateAccount.Parameters.Add("@E", SqlDbType.VarChar).Value = AEmail
        UpdateAccount.Parameters.Add("@PW", SqlDbType.VarChar).Value = APassword


        connection.Open()
        If UpdateAccount.ExecuteNonQuery() = 1 Then

            Try
                Email.Main(AEmail, "The Curry Garden", "Hello " & FullName & vbNewLine & "It looks like you have updated your account details," & vbNewLine & "If this was not you please contact us" & vbNewLine & "Stay Blessed, The Curry Garden")


            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try

        Else
        End If

        connection.Close()

        'Adding Account Addresses to their table
        Dim UpdateAddress As New SqlCommand("UPDATE AAddress SET Address = @A, Postcode = @PC WHERE CustomerID = '" & ID & "' AND Postcode LIKE '" & DGVPC.Rows(0).Cells(0).Value & "'", connection)

        UpdateAddress.Parameters.Add("@A", SqlDbType.Text).Value = Address
        UpdateAddress.Parameters.Add("@PC", SqlDbType.Text).Value = Postcode
        connection.Open()
        If UpdateAddress.ExecuteNonQuery() = 1 Then
        Else
            MessageBox.Show("Address Not Added")

        End If
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        If Login.DGVAccount.Rows(0).Cells(6).Value = "Cook" Then
            Me.Hide()
            Cook.Show()
        ElseIf Login.DGVAccount.Rows(0).Cells(6).Value = "Driver" Then
            Me.Hide()
            Driver.Show()
        Else
            Me.Hide()
            MainMenu.Show()

        End If
    End Sub
End Class