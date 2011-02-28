'Copyright by Mechi Community 2009-2011
'Do not remove this Copyright!

Imports System.Net.Sockets
Imports System.IO
Imports System.Net

Module server
    Dim scriptsconfiguration As scripts.configuration = New scripts.configuration()
    Dim scriptslog As scripts.log = New scripts.log()
    Dim time As String = Date.Now
    Dim port As String
    Dim _REVISION As String = My.Application.Info.Version.Revision.ToString
    Private server As TcpListener
    Private client As New TcpClient
    Private ipendpoint As IPEndPoint = New IPEndPoint(scriptsconfiguration.ReadLine("config.ini", 5), scriptsconfiguration.ReadLine("config.ini", 7)) ' eingestellt ist port 8000. dieser muss ggf. freigegeben sein!
    Private list As New List(Of Connection)
    Private config_admpwd As String = scriptsconfiguration.ReadLine("config.ini", 11)
    Private config_cmd As String = scriptsconfiguration.ReadLine("config.ini", 9)

    Private Structure Connection
        Dim stream As NetworkStream
        Dim streamw As StreamWriter
        Dim streamr As StreamReader
        Dim nick As String
        Dim pwd As String
        Dim announce As String
        Dim rev As String
    End Structure

    Private Sub SendToAllClients(ByVal s As String)
        For Each c As Connection In list
            Try
                c.streamw.WriteLine(s)
                c.streamw.Flush()
            Catch
            End Try
        Next
    End Sub

    Private Sub OnlineList(ByVal u As String)
        For Each c As Connection In list
            Try
                c.streamw.WriteLine()
                c.streamw.Flush()
            Catch
            End Try
        Next
    End Sub

    Sub Main()
        If My.Computer.FileSystem.FileExists("config.ini") = False Then
            MsgBox("Could not find the config.ini!")
            End
        End If
        If ConsoleSpecialKey.ControlC Then
            End
        End If
        Console.ForegroundColor = ConsoleColor.Green
        Console.Title = "ChatServ Server"
        Console.WriteLine("#Chat-Server Revision: " & _REVISION)
        scriptslog.LogMessage("#Chat-Server Revision: " + _REVISION, )
        Console.WriteLine("#<CTRL-C>")
        scriptslog.LogMessage("#<CTRL-C>")
        Console.WriteLine("#© Mechi Community")
        scriptslog.LogMessage("#© Mechi Community")
        Console.WriteLine("#Loaded at " & time)
        scriptslog.LogMessage("#Loaded at " & time)
        Console.WriteLine("#Listening on " & scriptsconfiguration.ReadLine("config.ini", 5) & ":" & scriptsconfiguration.ReadLine("config.ini", 7))
        scriptslog.LogMessage("#Listening on " & scriptsconfiguration.ReadLine("config.ini", 5) & ":" & scriptsconfiguration.ReadLine("config.ini", 7))
        Console.WriteLine("*******************************************************************************")
        scriptslog.LogMessage("*******************************************************************************")
        Console.ForegroundColor = ConsoleColor.Cyan
        server = New TcpListener(ipendpoint)
        server.Start()
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)

        While True
            client = server.AcceptTcpClient
            Dim c As New Connection
            c.stream = client.GetStream
            c.streamr = New StreamReader(c.stream)
            c.streamw = New StreamWriter(c.stream)

            c.nick = c.streamr.ReadLine
            c.rev = c.streamr.ReadLine
            list.Add(c)
            Console.ForegroundColor = ConsoleColor.Red
            SendToAllClients("Has joined: " & c.nick & ". Client Revision: " & c.rev)
            Console.WriteLine("#" & time & " " & c.nick & " has joined with Client Revision: " + c.rev)
            scriptslog.LogMessage("#" & time & " " & c.nick & " has joined with Client Revision: " + c.rev)
            Console.ForegroundColor = ConsoleColor.Cyan

            Dim t As New Threading.Thread(AddressOf ListenToConnection)
            t.Start(c)
        End While
    End Sub

    Private Sub ListenToConnection(ByVal con As Connection)
        Do
            Try
                Dim announce As String = con.announce
                Dim tmp As String = con.streamr.ReadLine
                If tmp.StartsWith(scriptsconfiguration.ReadLine("config.ini", 9) & "kick") And scriptsconfiguration.ReadLine("config.ini", 11) = con.pwd Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Dim Kickname As String = tmp.Remove(0, 6)
                    For Each Connection In list
                        If Connection.nick = Kickname Then
                            SendToAllClients("--> " & Kickname & " is kicked.")
                            Sendtoperson("/kicked", Kickname)
                            Console.WriteLine("*" & time & " " & Kickname & " is kicked!")
                            scriptslog.LogMessage("*" & time & " " & Kickname & " is kicked!")
                            list.Remove(Connection)
                            Exit For
                        End If
                    Next
                ElseIf tmp.StartsWith(scriptsconfiguration.ReadLine("config.ini", 9) & "shutdown") And scriptsconfiguration.ReadLine("config.ini", 11) = con.pwd Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    scriptslog.LogMessage("***Server shutdown by " + con.nick + "****")
                    End
                ElseIf tmp.StartsWith(scriptsconfiguration.ReadLine("config.ini", 9) + "announce") And scriptsconfiguration.ReadLine("config.ini", 11) = con.pwd Then
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.WriteLine("!" + time & " " & tmp.Replace(scriptsconfiguration.ReadLine("config.ini", 9) + "announce", "Announce by " + con.nick + ":"))
                    scriptslog.LogMessage("!" + time & " " & tmp.Replace(scriptsconfiguration.ReadLine("config.ini", 9) + "announce", "Announce by " + con.nick + ":"))
                    SendToAllClients(tmp.Replace(scriptsconfiguration.ReadLine("config.ini", 9) + "announce", "Announce by " + con.nick + ":"))
                ElseIf tmp.StartsWith("!afk") Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("#" & time & " " & con.nick & " is AFK right now")
                    scriptslog.LogMessage("#" + time + " " + con.nick + " is AFK right now")
                    SendToAllClients(con.nick & " is AFK right now")
                ElseIf tmp.StartsWith("!notafk") Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("#" & time & " " & con.nick & " is not longer AFK")
                    scriptslog.LogMessage("#" + time + " " + con.nick + " is not longer AFK")
                    SendToAllClients(con.nick & " is not longer AFK")
                ElseIf tmp.StartsWith("#admin") And Not tmp.Contains(" ") Then
                    con.pwd = con.streamr.ReadLine
                    If con.pwd = config_admpwd Then
                        Console.ForegroundColor = ConsoleColor.Yellow
                        Console.WriteLine(time & " " & con.nick & " has been identified as Admin")
                        scriptslog.LogMessage("*** " + time + " " + con.nick + " has been identified as Admin")
                        SendToAllClients(con.nick + " has been identified as Admin")
                    Else

                    End If
                ElseIf tmp.Contains(config_admpwd) Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    SendToAllClients("--> " & con.nick & " is kicked by Server.")
                    Sendtoperson("/kicked", con.nick)
                    Console.WriteLine("*" & time & " " & con.nick & " was kicked by Server!")
                    scriptslog.LogMessage("*" & time & " " & con.nick & " was kicked by Server!")
                ElseIf tmp.StartsWith(config_cmd + "w") Then
                    'Feature under Development
                ElseIf tmp.Contains("hure") Then
                    'Feature under Development
                ElseIf tmp.StartsWith(config_cmd + "online") Then
                    OnlineList("OnlineListe")
                    Console.WriteLine("Requested Onlinelist")
                Else
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.WriteLine(time & " " & con.nick & ": " & tmp)
                    scriptslog.LogMessage(time & " " & con.nick & ": " & tmp)
                    SendToAllClients(con.nick & ": " & tmp)
                End If
            Catch
                list.Remove(con)
                Console.ForegroundColor = ConsoleColor.Red
                SendToAllClients("Has exited: " & con.nick)
                Console.WriteLine("#" & time & " " & con.nick & " has exited.")
                scriptslog.LogMessage("#" & time & " " & con.nick & " has exited.")
                Exit Do
            End Try
        Loop
    End Sub

    Private Sub Sendtoperson(ByVal s As String, ByVal Nick As String)
        For Each Connection In list
            Try
                If Connection.nick = Nick Then
                    Connection.streamw.WriteLine(s)
                    Connection.streamw.Flush()
                End If
            Catch
            End Try
        Next
    End Sub
End Module
