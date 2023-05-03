Module Validation

    Public Function PresenceCheck(Txt As String, Var As String)
        Dim ErrorCheck As Boolean
        If String.IsNullOrWhiteSpace(Txt) Then
            MessageBox.Show("Please Enter Your " & Var)
            Return ErrorCheck = True
        Else
            Return ErrorCheck = False
        End If

    End Function

    Public Function EmailFormatCheck(Txt As String)
        Dim ErrorCheck As Boolean
        If Txt.Contains("@") = False Or Txt.Contains(".") = False Then
            MessageBox.Show("Invalid Email")
            Return ErrorCheck = True
        Else
            Return ErrorCheck = False
        End If
    End Function
    Public Function LengthCheck(Txt As String, No1 As Integer, No2 As Integer, Msg As String)

        Dim ErrorCheck As Boolean
        If Txt.Length < No1 And Txt.Length > No2 Then
            MessageBox.Show(Msg)
            Return ErrorCheck = True
        Else
            Return ErrorCheck = False
        End If
    End Function

    Public Function DataTypeCheck(Txt As String, Bool As Boolean, Var1 As String, Var As String)
        Dim ErrorCheck As Boolean
        If IsNumeric(Txt) = Bool Then
            MessageBox.Show("Please ensure your" & Var1 & "only contains" & Var)
            Return ErrorCheck = True
        Else
            Return ErrorCheck = False
        End If
    End Function

    Public Function Password(Txt As String)
        Dim ErrorCheck As Boolean
        Dim re As New Text.RegularExpressions.Regex("\d")

        If Txt.Length < 6 Then
            MessageBox.Show("Minimum 6 characters needed")
            Return ErrorCheck = True
        ElseIf Txt <> UCase$(Txt) Then 'the textbox contains capitals
            Return ErrorCheck = True
        ElseIf Txt <> LCase$(Txt) Then 'the textbox contains lower cases
            Return ErrorCheck = True
        ElseIf Not re.IsMatch(Txt) Then
            MsgBox("Password must contain at least one digit")
            Return ErrorCheck = True
        ElseIf Txt.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1 Then
            Return ErrorCheck = False
        Else
            Return ErrorCheck = False
        End If

    End Function

    Public Function DoubleKeying(Txt As String, Txt2 As String, Msg As String)
        Dim ErrorCheck As Boolean

        If Txt <> Txt2 Then
            MessageBox.Show(Msg)
            Return ErrorCheck = True
        Else
            Return ErrorCheck = False
        End If
    End Function

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