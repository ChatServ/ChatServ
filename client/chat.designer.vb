<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chat
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chat))
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.BackgroundcolorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CyanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ForegroundcolorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BlackToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BlueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.WhiteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GrayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CyanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CyanToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.GreenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TransparencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.HideToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.SystemColors.MenuText
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 81)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(551, 299)
        Me.ListBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(12, 398)
        Me.TextBox1.MaxLength = 100
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(480, 13)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Type your Message here"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(498, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "The ChatServ-Client is now hided. Click here to restore the window."
        Me.NotifyIcon1.BalloonTipTitle = "ChatServ-Client"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ChatServ-Client"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(112, 26)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundcolorToolStripMenuItem, Me.ForegroundcolorToolStripMenuItem, Me.TransparencyToolStripMenuItem})
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripButton1.Text = "Chatbox"
        '
        'BackgroundcolorToolStripMenuItem
        '
        Me.BackgroundcolorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackToolStripMenuItem, Me.BlueToolStripMenuItem, Me.RedToolStripMenuItem, Me.WhiteToolStripMenuItem, Me.GrayToolStripMenuItem, Me.CyanToolStripMenuItem, Me.GreenToolStripMenuItem})
        Me.BackgroundcolorToolStripMenuItem.Name = "BackgroundcolorToolStripMenuItem"
        Me.BackgroundcolorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BackgroundcolorToolStripMenuItem.Text = "Backgroundcolor"
        '
        'BlackToolStripMenuItem
        '
        Me.BlackToolStripMenuItem.Name = "BlackToolStripMenuItem"
        Me.BlackToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.BlackToolStripMenuItem.Text = "Black"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'GrayToolStripMenuItem
        '
        Me.GrayToolStripMenuItem.Name = "GrayToolStripMenuItem"
        Me.GrayToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.GrayToolStripMenuItem.Text = "Gray"
        '
        'CyanToolStripMenuItem
        '
        Me.CyanToolStripMenuItem.Name = "CyanToolStripMenuItem"
        Me.CyanToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.CyanToolStripMenuItem.Text = "Cyan"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'ForegroundcolorToolStripMenuItem
        '
        Me.ForegroundcolorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackToolStripMenuItem1, Me.BlueToolStripMenuItem1, Me.WhiteToolStripMenuItem1, Me.GrayToolStripMenuItem1, Me.CyanToolStripMenuItem1, Me.CyanToolStripMenuItem2, Me.GreenToolStripMenuItem1})
        Me.ForegroundcolorToolStripMenuItem.Name = "ForegroundcolorToolStripMenuItem"
        Me.ForegroundcolorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ForegroundcolorToolStripMenuItem.Text = "Foregroundcolor"
        '
        'BlackToolStripMenuItem1
        '
        Me.BlackToolStripMenuItem1.Name = "BlackToolStripMenuItem1"
        Me.BlackToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.BlackToolStripMenuItem1.Text = "Black"
        '
        'BlueToolStripMenuItem1
        '
        Me.BlueToolStripMenuItem1.Name = "BlueToolStripMenuItem1"
        Me.BlueToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.BlueToolStripMenuItem1.Text = "Blue"
        '
        'WhiteToolStripMenuItem1
        '
        Me.WhiteToolStripMenuItem1.Name = "WhiteToolStripMenuItem1"
        Me.WhiteToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.WhiteToolStripMenuItem1.Text = "Red"
        '
        'GrayToolStripMenuItem1
        '
        Me.GrayToolStripMenuItem1.Name = "GrayToolStripMenuItem1"
        Me.GrayToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.GrayToolStripMenuItem1.Text = "White"
        '
        'CyanToolStripMenuItem1
        '
        Me.CyanToolStripMenuItem1.Name = "CyanToolStripMenuItem1"
        Me.CyanToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.CyanToolStripMenuItem1.Text = "Gray"
        '
        'CyanToolStripMenuItem2
        '
        Me.CyanToolStripMenuItem2.Name = "CyanToolStripMenuItem2"
        Me.CyanToolStripMenuItem2.Size = New System.Drawing.Size(114, 22)
        Me.CyanToolStripMenuItem2.Text = "Cyan"
        '
        'GreenToolStripMenuItem1
        '
        Me.GreenToolStripMenuItem1.Name = "GreenToolStripMenuItem1"
        Me.GreenToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.GreenToolStripMenuItem1.Text = "Green"
        '
        'TransparencyToolStripMenuItem
        '
        Me.TransparencyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.TransparencyToolStripMenuItem.Name = "TransparencyToolStripMenuItem"
        Me.TransparencyToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TransparencyToolStripMenuItem.Text = "Transparency"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripMenuItem2.Text = "5%"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripMenuItem3.Text = "10%"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripMenuItem4.Text = "15%"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripMenuItem5.Text = "20%"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripMenuItem6.Text = "25%"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideToolStripMenuItem1})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripDropDownButton1.Text = "Extras"
        '
        'HideToolStripMenuItem1
        '
        Me.HideToolStripMenuItem1.Name = "HideToolStripMenuItem1"
        Me.HideToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.HideToolStripMenuItem1.Text = "Hide"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Client.My.Resources.Resources.banner
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(571, 73)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(575, 428)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "ChatServ-Client"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BackgroundcolorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CyanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForegroundcolorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrayToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CyanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CyanToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents HideToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransparencyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
