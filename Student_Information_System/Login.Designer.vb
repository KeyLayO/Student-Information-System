<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Me.TCloud1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TCloud2 = New System.Windows.Forms.Timer(Me.components)
        Me.TCloud3 = New System.Windows.Forms.Timer(Me.components)
        Me.TSun = New System.Windows.Forms.Timer(Me.components)
        Me.TMoon = New System.Windows.Forms.Timer(Me.components)
        Me.PbMoon = New System.Windows.Forms.PictureBox()
        Me.pbCloud3 = New System.Windows.Forms.PictureBox()
        Me.pbCloud2 = New System.Windows.Forms.PictureBox()
        Me.pbCloud1 = New System.Windows.Forms.PictureBox()
        Me.pbSun = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PbMoon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCloud3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCloud2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCloud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCloud1
        '
        Me.TCloud1.Enabled = True
        Me.TCloud1.Interval = 50
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Controls.Add(Me.PbMoon)
        Me.Panel2.Controls.Add(Me.pbCloud3)
        Me.Panel2.Controls.Add(Me.pbCloud2)
        Me.Panel2.Controls.Add(Me.pbCloud1)
        Me.Panel2.Controls.Add(Me.pbSun)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(510, 427)
        Me.Panel2.TabIndex = 7
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(85, 172)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.BackColor = System.Drawing.Color.Transparent
        Me.chkShow.Location = New System.Drawing.Point(188, 135)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(53, 17)
        Me.chkShow.TabIndex = 5
        Me.chkShow.Text = "Show"
        Me.chkShow.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(82, 212)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(81, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create Account"
        '
        'txtUsername
        '
        Me.txtUsername.ForeColor = System.Drawing.Color.Silver
        Me.txtUsername.Location = New System.Drawing.Point(60, 93)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(125, 20)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.Text = "Username"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.Color.Silver
        Me.txtPassword.Location = New System.Drawing.Point(60, 133)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(125, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Javanese Text", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(33, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(178, 62)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "WELCOME"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblWelcome)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.chkShow)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Location = New System.Drawing.Point(132, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 245)
        Me.Panel1.TabIndex = 6
        '
        'TCloud2
        '
        Me.TCloud2.Enabled = True
        Me.TCloud2.Interval = 10
        '
        'TCloud3
        '
        Me.TCloud3.Enabled = True
        Me.TCloud3.Interval = 25
        '
        'TSun
        '
        Me.TSun.Enabled = True
        Me.TSun.Interval = 1
        '
        'TMoon
        '
        Me.TMoon.Enabled = True
        Me.TMoon.Interval = 1
        '
        'PbMoon
        '
        Me.PbMoon.BackColor = System.Drawing.Color.Transparent
        Me.PbMoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbMoon.Image = Global.Student_Information_System.My.Resources.Resources.moon
        Me.PbMoon.Location = New System.Drawing.Point(-150, 12)
        Me.PbMoon.Name = "PbMoon"
        Me.PbMoon.Size = New System.Drawing.Size(104, 103)
        Me.PbMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbMoon.TabIndex = 4
        Me.PbMoon.TabStop = False
        '
        'pbCloud3
        '
        Me.pbCloud3.BackColor = System.Drawing.Color.Transparent
        Me.pbCloud3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbCloud3.Image = Global.Student_Information_System.My.Resources.Resources.cloud
        Me.pbCloud3.Location = New System.Drawing.Point(100, 326)
        Me.pbCloud3.Name = "pbCloud3"
        Me.pbCloud3.Size = New System.Drawing.Size(145, 83)
        Me.pbCloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCloud3.TabIndex = 2
        Me.pbCloud3.TabStop = False
        '
        'pbCloud2
        '
        Me.pbCloud2.BackColor = System.Drawing.Color.Transparent
        Me.pbCloud2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbCloud2.Image = Global.Student_Information_System.My.Resources.Resources.cloud
        Me.pbCloud2.Location = New System.Drawing.Point(240, 233)
        Me.pbCloud2.Name = "pbCloud2"
        Me.pbCloud2.Size = New System.Drawing.Size(145, 83)
        Me.pbCloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCloud2.TabIndex = 1
        Me.pbCloud2.TabStop = False
        '
        'pbCloud1
        '
        Me.pbCloud1.BackColor = System.Drawing.Color.Transparent
        Me.pbCloud1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbCloud1.Image = Global.Student_Information_System.My.Resources.Resources.cloud
        Me.pbCloud1.Location = New System.Drawing.Point(-10, 131)
        Me.pbCloud1.Name = "pbCloud1"
        Me.pbCloud1.Size = New System.Drawing.Size(145, 83)
        Me.pbCloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCloud1.TabIndex = 0
        Me.pbCloud1.TabStop = False
        '
        'pbSun
        '
        Me.pbSun.BackColor = System.Drawing.Color.Transparent
        Me.pbSun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSun.Image = Global.Student_Information_System.My.Resources.Resources.sun
        Me.pbSun.Location = New System.Drawing.Point(120, 10)
        Me.pbSun.Name = "pbSun"
        Me.pbSun.Size = New System.Drawing.Size(174, 103)
        Me.pbSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSun.TabIndex = 3
        Me.pbSun.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(509, 427)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbMoon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCloud3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCloud2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCloud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TCloud1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbCloud3 As PictureBox
    Friend WithEvents pbCloud2 As PictureBox
    Friend WithEvents pbCloud1 As PictureBox
    Friend WithEvents TCloud2 As Timer
    Friend WithEvents TCloud3 As Timer
    Friend WithEvents pbSun As PictureBox
    Friend WithEvents TSun As Timer
    Friend WithEvents PbMoon As PictureBox
    Friend WithEvents TMoon As Timer
End Class
