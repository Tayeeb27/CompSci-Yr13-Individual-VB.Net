Imports System.Net.Mail
Module Email
    Sub Main(Recipient As String, Subject As String, Body As String)

        Dim Smtp_Server As New SmtpClient
        Dim unused As New MailMessage()


        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("thecurrygarden27@gmail.com", "#Password27")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp.gmail.com"

        Dim e_mail As MailMessage = New MailMessage With {
            .From = New MailAddress("thecurrygarden27@gmail.com")
        }
        e_mail.To.Add(Recipient)
        e_mail.Subject = Subject
        e_mail.IsBodyHtml = False
        e_mail.Body = Body
        Smtp_Server.Send(e_mail)

    End Sub
End Module
