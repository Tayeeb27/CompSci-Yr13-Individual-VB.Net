Imports System.Data.SqlClient
Imports System.IO
Public Class ForgotPassword
    Private ReadOnly connection As New SqlConnection("Server = DESKTOP-TAYEEB\SQLEXPRESS; Database = The_Curry_Garden; Trusted_Connection = true")
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub BtnSendEmail_Click(sender As Object, e As EventArgs) Handles BtnSendEmail.Click
        Dim CheckEmail As New SqlCommand("Select * from Account where AEmail = @Email", connection)

        CheckEmail.Parameters.Add("@Email", SqlDbType.VarChar).Value = TxtEmail.Text

        Dim Adapter As New SqlDataAdapter(CheckEmail)
        Dim Table As New DataTable()

        Adapter.Fill(Table)
        'Looks in table to see whether the Email is in there
        If Table.Rows.Count() <= 0 Then
            MessageBox.Show("Email is not recognised")
        Else
            DGVA.DataSource = SQLCommands.SQLFillTable("SELECT * from Account Where AEmail = '" & TxtEmail.Text & "'")
            Dim UP As New SqlCommand("UPDATE Account SET APassword = @AP where AEmail = @AE", connection)
            Dim RandomPassword As String = GetRandomString()
            UP.Parameters.Add("@AP", SqlDbType.VarChar).Value = RandomPassword
            UP.Parameters.Add("@AE", SqlDbType.VarChar).Value = TxtEmail.Text

            connection.Open()
            If UP.ExecuteNonQuery() = 1 Then
                Email.Main(TxtEmail.Text, "The Curry Garden", "Hello " & DGVA.Rows(0).Cells(1).Value & vbNewLine & "I’m sorry to hear that you forgot your password. Your Generated Password is " & RandomPassword & ". To change it please go into your account details." & vbNewLine & "Stay Blessed, The Curry Garden")
                MsgBox("An Email has been sent with your new password")
                Me.Hide()
                Login.Show()
            Else
                MessageBox.Show("Password Did Not Change")
            End If
            connection.Close()
        End If
    End Sub
    Public Function GetRandomString()
        Dim p As String = Path.GetRandomFileName()
        p = p.Replace(".", "")
        Return p
    End Function
End Class