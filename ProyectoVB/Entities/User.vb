Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text

Namespace Entities
    Public Class User
        Public Property Id As Integer
        Public Property Name As String

        Private _email As String
        Public Property Email As String
            Get
                Return _email
            End Get
            Set(value As String)
                If IsValidEmail(value) Then
                    _email = value
                Else
                    Throw New ArgumentException("La dirección de correo electrónico no es válida.")
                End If
            End Set
        End Property
        Public Property Password As String
        Public Property Payment As DateTime?
        Public Property LastConnection As DateTime?
        Public Property FirstLogin As Boolean
        Public Property RoleId As Integer
        Public Property CreatedAt As DateTime
        Public Property Role As Role

        Public Sub New()
        End Sub

        Public Sub New(id As Integer, name As String, email As String, password As String, payment As DateTime?, lastConnection As DateTime?, firstLogin As Boolean, roleId As Integer, createdAt As DateTime)
            Me.Id = id
            Me.Name = name
            Me.Email = email
            Me.Password = password
            Me.Payment = payment
            Me.LastConnection = lastConnection
            Me.FirstLogin = firstLogin
            Me.RoleId = roleId
            Me.CreatedAt = createdAt
        End Sub

        Public Shared Function IsValidEmail(value As String) As Boolean
            ' Método para validar la dirección de correo electrónico.
            Return Regex.IsMatch(value, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        End Function

        Public Shared Function HashPassword(password As String) As String
            ' Método para hashear la contraseña.
            Dim sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Function

        Public Function VerifyPassword(plainTextPassword As String) As Boolean
            ' Método para verificar la contraseña.
            Dim hashedPassword As String = HashPassword(plainTextPassword)
            Return String.Equals(hashedPassword, Password)
        End Function

    End Class

End Namespace