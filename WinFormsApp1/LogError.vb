Imports System.IO

Public Class LogError
    Private Shared LogFilePath As String = "C:\LogErros\File_log.txt" '

    Public Shared Sub LogError(Message As String)
        Try
            ' Creates or opens the log file in append mode
            Using writer As New StreamWriter(LogFilePath, True)
                ' Gets the current date and time.
                Dim currentTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

                ' Writes the error message to the log file with the date and time
                writer.WriteLine(currentTime & ": " & Message)
            End Using
        Catch ex As Exception
            MsgBox("Erro:" & Err.Description)
        End Try
    End Sub

End Class

