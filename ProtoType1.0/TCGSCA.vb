Imports System.Data.SqlClient
Public Class TCGSCA

    Private ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
    ReadOnly FullName As String = TxtName.Text
    ReadOnly PhoneNumber As String = TxtPhoneNumber.Text
    ReadOnly AEmail As String = TxtEmail.Text
    ReadOnly Password As String = TxtPassword.Text
    ReadOnly Address As String = TxtAddress.Text
    ReadOnly Postcode As String = TxtPostCode.Text
    ReadOnly AccessLvl As String = CmbAccessLvl.Text
    Private Sub BtnComplete_Click(sender As Object, e As EventArgs)
        Dim AddAccount As New SqlCommand("Insert into Account(FullName, PhoneNumber, AEmail, APassword, AccessLvl) values(@FN,@PN,@E, @PW @AL", connection)

        AddAccount.Parameters.Add("@FN", SqlDbType.Text).Value = FullName
        AddAccount.Parameters.Add("@PN", SqlDbType.Text).Value = PhoneNumber
        AddAccount.Parameters.Add("@E", SqlDbType.VarChar).Value = AEmail
        AddAccount.Parameters.Add("@PW", SqlDbType.VarChar).Value = Password
        AddAccount.Parameters.Add("@AL", SqlDbType.Text).Value = AccessLvl


        Dim AddAddress As New SqlCommand("insert into AAddress(AAddress, Postcode) values(@AA,@PC)", connection)

        AddAddress.Parameters.Add("@AA", SqlDbType.Text).Value = Address
        AddAddress.Parameters.Add("@PC", SqlDbType.Text).Value = Postcode

        connection.Open()
        If AddAccount.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New Staff Account Created")
            Try
                Email.Main(AEmail, "The Curry Garden", "Hello " & FullName & vbNewLine & "Your Account with The Curry Garden as a " & FullName & "has been created.")


            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try

        Else

            MessageBox.Show("Customer Account Not Created")

        End If

        connection.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        If RadioButton1.Checked And TxtPassword.UseSystemPasswordChar = False Then
            TxtPassword.UseSystemPasswordChar = True
        Else
            TxtPassword.UseSystemPasswordChar = False
        End If

        If RadioButton1.Checked And TxtRePassword.UseSystemPasswordChar = False Then
            TxtRePassword.UseSystemPasswordChar = True
        Else
            TxtRePassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs)
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub TxtRePassword_TextChanged(sender As Object, e As EventArgs)
        TxtRePassword.UseSystemPasswordChar = True

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class