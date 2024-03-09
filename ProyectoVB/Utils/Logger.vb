Imports System.IO

Public Class Logger
    Private Shared ReadOnly logFilePath As String = "logfile.txt"

    Public Shared Sub LogException(ex As Exception)
        Using writer As New StreamWriter(logFilePath, True)
            writer.WriteLine($"[ERROR] {DateTime.Now}: {ex.Message}")
            writer.WriteLine($"StackTrace: {ex.StackTrace}")
            writer.WriteLine()
        End Using
    End Sub

    Public Shared Sub LogMessage(message As String)
        Using writer As New StreamWriter(logFilePath, True)
            writer.WriteLine($"[INFO] {DateTime.Now}: {message}")
            writer.WriteLine()
        End Using
    End Sub
End Class

