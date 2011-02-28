Public Class log
    Public Sub LogMessage(ByVal Message As String, Optional ByVal LogFileName As String = "")
        LogFileName = "server_" + Date.Today + ".log"

        Try
            Dim oStream As IO.StreamWriter = System.IO.File.AppendText(LogFileName)
            oStream.WriteLine(Message)

            oStream.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class
