'Copyright by Mechi Community 2009-2011
'Do not remove this Copyright!

Imports System.Net.Sockets
Imports System.IO

Public Class chat
    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Private t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)
    Private nick As String = "unknown"
    Private ip As String = "unknown"
    Private port As String = "unknown"
    Private rev As String = My.Application.Info.Version.Build.ToString
    Private pwd As String = ""

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            client.Connect(ip, port)
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)

                streamw.WriteLine(nick)
                streamw.WriteLine(rev)
                streamw.Flush()

                t.Start()
            Else
                client.Close()
                stream.Close()
                streamw.Close()
                streamr.Close()
                MessageBox.Show("connection failed")
                Application.Exit()
            End If
        Catch ex As Exception
            client.Close()
            stream.Close()
            streamw.Close()
            streamr.Close()
            MessageBox.Show("connection failed")
            Application.Exit()
        End Try
    End Sub

    Private Sub AddItem(ByVal s As String)
        If s.StartsWith("/kicked") Then
            client.Close()
            stream.Close()
            streamw.Close()
            streamr.Close()
            MessageBox.Show("you were kicked")
            Application.Exit()
        End If
        ListBox1.Items.Add(s)
        With ListBox1
            .TopIndex += 1
        End With
    End Sub

    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), streamr.ReadLine)
            Catch ex As Exception
                client.Close()
                stream.Close()
                streamw.Close()
                streamr.Close()
                MsgBox("connection lost/closed")
                Application.Exit()
            End Try
        End While
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox1.Text = " " Then

        ElseIf TextBox1.Text = "#admin" Then
            pwd = InputBox("Password: ", "Administrationpassword")
            streamw.WriteLine(TextBox1.Text)
            streamw.WriteLine(pwd)
            streamw.Flush()
            TextBox1.Clear()
        ElseIf TextBox1.Text = "#info" Then
            MessageBox.Show("ChatServ Chatclient by Mechi Community Revision ID: " + My.Application.Info.Version.Revision.ToString + " Build ID: " + My.Application.Info.Version.Build.ToString, "Info", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            streamw.WriteLine(TextBox1.Text)
            streamw.Flush()
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ip = InputBox("IP: ", "IP of the Server", "")
        If ip = "" Then
            ip = "localhost"
        End If
        port = InputBox("Port: (default = 8000)", "Port of Server", "")
        If port = "" Then
            port = "8000"
        End If
        nick = InputBox("Nickname: ", "Choose nickname", "")
        If nick = "" Then
            nick = "Guest"
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = 13 Then
            Call Button1_Click(Button1, e)
        End If
    End Sub

    Private Sub Form1_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        client.Close()
        stream.Close()
        streamw.Close()
        streamr.Close()
        Application.Exit()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        NotifyIcon1.Visible = False
        Timer2.Enabled = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
        Timer2.Enabled = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip("10")
            Timer2.Enabled = False
        End If
    End Sub
End Class
