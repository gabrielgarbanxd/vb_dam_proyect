Imports System.Net.Mail

Namespace Services

    Public Class MailService

        Private ReadOnly _gmailAccount As String = "gabriel@gmail.com"
        Private ReadOnly _gmailPassword As String = "password"

        Private ReadOnly _smtpClient As SmtpClient
        Private ReadOnly _mailAddress As MailAddress

        Public Sub New()
            _smtpClient = New SmtpClient("smtp.gmail.com") With {
            .Port = 587,
            .Credentials = New Net.NetworkCredential(_gmailAccount, _gmailPassword),
            .EnableSsl = True
        }
            _mailAddress = New MailAddress(_gmailAccount)
        End Sub

        Public Async Function SendRecoverPasswordEmailAsync(email As String, password As String) As Task
            Dim msg As New MailMessage(_mailAddress, New MailAddress(email)) With {
            .Subject = "Recuperación de contraseña",
            .Body = "Su contraseña es: " & password,
            .IsBodyHtml = False
        }

            Try

                Await _smtpClient.SendMailAsync(msg)

            Catch ex As Exception

                Logger.LogException(ex)

                Throw New ServiceException("Error al enviar el correo")

            End Try
        End Function
    End Class

End Namespace
