Imports System.Net.Mail

Namespace Services

    Public Class MailService

        Private ReadOnly _outlookAccount As String = "G.A.VB@outlook.es"
        Private ReadOnly _outlookPassword As String = "password123**"

        Private ReadOnly _smtpClient As SmtpClient
        Private ReadOnly _mailAddress As MailAddress

        Public Sub New()
            _smtpClient = New SmtpClient("smtp.office365.com") With {
            .Port = 587,
            .Credentials = New Net.NetworkCredential(_outlookAccount, _outlookPassword),
            .EnableSsl = True
        }
            _mailAddress = New MailAddress(_outlookAccount)
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
