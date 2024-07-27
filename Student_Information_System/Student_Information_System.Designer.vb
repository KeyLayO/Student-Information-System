<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Information_System
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrelimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MidtermToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetricSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowerpointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YoutubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AppsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrelimToolStripMenuItem, Me.MidtermToolStripMenuItem, Me.FinalsToolStripMenuItem, Me.ToolStripMenuItem1, Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrelimToolStripMenuItem
        '
        Me.PrelimToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentInformationToolStripMenuItem})
        Me.PrelimToolStripMenuItem.Name = "PrelimToolStripMenuItem"
        Me.PrelimToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrelimToolStripMenuItem.Text = "&Prelim"
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.StudentInformationToolStripMenuItem.Text = "Student Information"
        '
        'MidtermToolStripMenuItem
        '
        Me.MidtermToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MetricSystemToolStripMenuItem})
        Me.MidtermToolStripMenuItem.Name = "MidtermToolStripMenuItem"
        Me.MidtermToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MidtermToolStripMenuItem.Text = "&Midterm"
        '
        'MetricSystemToolStripMenuItem
        '
        Me.MetricSystemToolStripMenuItem.Name = "MetricSystemToolStripMenuItem"
        Me.MetricSystemToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MetricSystemToolStripMenuItem.Text = "Metric System"
        '
        'FinalsToolStripMenuItem
        '
        Me.FinalsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ATMToolStripMenuItem})
        Me.FinalsToolStripMenuItem.Name = "FinalsToolStripMenuItem"
        Me.FinalsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FinalsToolStripMenuItem.Text = "&Finals"
        '
        'ATMToolStripMenuItem
        '
        Me.ATMToolStripMenuItem.Name = "ATMToolStripMenuItem"
        Me.ATMToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ATMToolStripMenuItem.Text = "ATM"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AppsToolStripMenuItem
        '
        Me.AppsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.ChessToolStripMenuItem, Me.FacebookToolStripMenuItem, Me.GoogleToolStripMenuItem, Me.MsWordToolStripMenuItem, Me.NotepadToolStripMenuItem, Me.PowerpointToolStripMenuItem, Me.YoutubeToolStripMenuItem})
        Me.AppsToolStripMenuItem.Name = "AppsToolStripMenuItem"
        Me.AppsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.AppsToolStripMenuItem.Text = "&Apps"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator&"
        '
        'ChessToolStripMenuItem
        '
        Me.ChessToolStripMenuItem.Name = "ChessToolStripMenuItem"
        Me.ChessToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ChessToolStripMenuItem.Text = "Chess"
        '
        'FacebookToolStripMenuItem
        '
        Me.FacebookToolStripMenuItem.Name = "FacebookToolStripMenuItem"
        Me.FacebookToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.FacebookToolStripMenuItem.Text = "Facebook"
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.GoogleToolStripMenuItem.Text = "Google"
        '
        'MsWordToolStripMenuItem
        '
        Me.MsWordToolStripMenuItem.Name = "MsWordToolStripMenuItem"
        Me.MsWordToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MsWordToolStripMenuItem.Text = "MsWord"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'PowerpointToolStripMenuItem
        '
        Me.PowerpointToolStripMenuItem.Name = "PowerpointToolStripMenuItem"
        Me.PowerpointToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PowerpointToolStripMenuItem.Text = "Powerpoint"
        '
        'YoutubeToolStripMenuItem
        '
        Me.YoutubeToolStripMenuItem.Name = "YoutubeToolStripMenuItem"
        Me.YoutubeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.YoutubeToolStripMenuItem.Text = "Youtube"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(207, 17)
        Me.ToolStripStatusLabel1.Text = "Programmed by : Kurt Jerald M. Emba"
        '
        'Student_Information_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Student_Information_System"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrelimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MidtermToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetricSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ATMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents AppsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacebookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoogleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YoutubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PowerpointToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChessToolStripMenuItem As ToolStripMenuItem
End Class
