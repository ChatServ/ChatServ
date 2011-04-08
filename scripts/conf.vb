Public Class conf
    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" ( _
    ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, _
    ByVal lpDefault As String, _
    ByVal lpReturnedString As String, _
    ByVal nSize As Integer, _
    ByVal lpFileName As String) _
As Integer

    Public Function load(ByVal Section As String, ByVal Key As String, Optional ByVal DefaultValue As String = "", Optional ByVal BufferSize As Integer = 1024) As String
        Dim sTemp As String = Space(BufferSize)
        Dim Length As Integer = GetPrivateProfileString(Section, Key, DefaultValue, sTemp, BufferSize, ".\config.ini")
        Return Left(sTemp, Length)
    End Function
End Class