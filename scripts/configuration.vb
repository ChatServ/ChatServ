Public Class configuration
    Public Function ReadLine(ByVal sFile As String, _
  Optional ByVal nLine As Long = 1) As String

        Dim sLines() As String
        Dim oFSO As Object
        Dim oFile As Object

        On Error GoTo ErrHandler

        oFSO = CreateObject("Scripting.FileSystemObject")

        If oFSO.FileExists(sFile) Then
            oFile = oFSO.OpenTextFile(sFile)

            sLines = Split(oFile.ReadAll, vbCrLf)

            oFile.Close()

            Select Case Math.Sign(nLine)
                Case 1
                    ReadLine = sLines(nLine - 1)

                Case -1
                    ReadLine = sLines(UBound(sLines) + nLine + 1)
            End Select
        End If

ErrHandler:
        oFile = Nothing
        oFSO = Nothing
    End Function
End Class
