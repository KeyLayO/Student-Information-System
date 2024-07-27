<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDeposit
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
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn50Deposit = New System.Windows.Forms.Button()
        Me.btn100Deposit = New System.Windows.Forms.Button()
        Me.btn200Deposit = New System.Windows.Forms.Button()
        Me.btn500Deposit = New System.Windows.Forms.Button()
        Me.btn1000Deposit = New System.Windows.Forms.Button()
        Me.btn2000Deposit = New System.Windows.Forms.Button()
        Me.btn5000Deposit = New System.Windows.Forms.Button()
        Me.btnCustomDeposit = New System.Windows.Forms.Button()
        Me.btn10000Deposit = New System.Windows.Forms.Button()
        Me.pBottom = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pLabel = New System.Windows.Forms.Panel()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        Me.pBottom.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pLabel.SuspendLayout()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDeposit
        '
        Me.txtDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.txtDeposit.Location = New System.Drawing.Point(355, 124)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.ReadOnly = True
        Me.txtDeposit.Size = New System.Drawing.Size(147, 26)
        Me.txtDeposit.TabIndex = 34
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDeposit.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Lime
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(439, 300)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(108, 48)
        Me.btnEnter.TabIndex = 33
        Me.btnEnter.Text = "ENTER"
        Me.btnEnter.UseVisualStyleBackColor = False
        Me.btnEnter.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(439, 246)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 48)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(439, 192)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(108, 48)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn0.Location = New System.Drawing.Point(309, 354)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(59, 48)
        Me.btn0.TabIndex = 30
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        Me.btn0.Visible = False
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn9.Location = New System.Drawing.Point(374, 300)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(59, 48)
        Me.btn9.TabIndex = 29
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        Me.btn9.Visible = False
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn8.Location = New System.Drawing.Point(309, 300)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(59, 48)
        Me.btn8.TabIndex = 28
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        Me.btn8.Visible = False
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn7.Location = New System.Drawing.Point(244, 300)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(59, 48)
        Me.btn7.TabIndex = 27
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        Me.btn7.Visible = False
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn6.Location = New System.Drawing.Point(374, 246)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(59, 48)
        Me.btn6.TabIndex = 26
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        Me.btn6.Visible = False
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn5.Location = New System.Drawing.Point(309, 246)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(59, 48)
        Me.btn5.TabIndex = 25
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        Me.btn5.Visible = False
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn4.Location = New System.Drawing.Point(244, 246)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(59, 48)
        Me.btn4.TabIndex = 24
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        Me.btn4.Visible = False
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn3.Location = New System.Drawing.Point(374, 192)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(59, 48)
        Me.btn3.TabIndex = 23
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        Me.btn3.Visible = False
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn2.Location = New System.Drawing.Point(309, 192)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(59, 48)
        Me.btn2.TabIndex = 22
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        Me.btn2.Visible = False
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.lblDeposit.Location = New System.Drawing.Point(288, 130)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(61, 16)
        Me.lblDeposit.TabIndex = 21
        Me.lblDeposit.Text = "Deposit"
        Me.lblDeposit.Visible = False
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn1.Location = New System.Drawing.Point(244, 192)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(59, 48)
        Me.btn1.TabIndex = 20
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        Me.btn1.Visible = False
        '
        'btn50Deposit
        '
        Me.btn50Deposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50Deposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn50Deposit.Location = New System.Drawing.Point(22, 131)
        Me.btn50Deposit.Name = "btn50Deposit"
        Me.btn50Deposit.Size = New System.Drawing.Size(91, 48)
        Me.btn50Deposit.TabIndex = 35
        Me.btn50Deposit.Text = "50"
        Me.btn50Deposit.UseVisualStyleBackColor = True
        '
        'btn100Deposit
        '
        Me.btn100Deposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100Deposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn100Deposit.Location = New System.Drawing.Point(119, 131)
        Me.btn100Deposit.Name = "btn100Deposit"
        Me.btn100Deposit.Size = New System.Drawing.Size(91, 48)
        Me.btn100Deposit.TabIndex = 36
        Me.btn100Deposit.Text = "100"
        Me.btn100Deposit.UseVisualStyleBackColor = True
        '
        'btn200Deposit
        '
        Me.btn200Deposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200Deposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn200Deposit.Location = New System.Drawing.Point(22, 185)
        Me.btn200Deposit.Name = "btn200Deposit"
        Me.btn200Deposit.Size = New System.Drawing.Size(91, 48)
        Me.btn200Deposit.TabIndex = 37
        Me.btn200Deposit.Text = "200"
        Me.btn200Deposit.UseVisualStyleBackColor = True
        '
        'btn500Deposit
        '
        Me.btn500Deposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn500Deposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn500Deposit.Location = New System.Drawing.Point(119, 185)
        Me.btn500Deposit.Name = "btn500Deposit"
        Me.btn500Deposit.Size = New System.Drawing.Size(91, 48)
        Me.btn500Deposit.TabIndex = 38
        Me.btn500Deposit.Text = "500"
        Me.btn500Deposit.UseVisualStyleBackColor = True
        '
        'btn1000Deposit
        '
        Me.btn1000Deposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000Deposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn1000Deposit.Location = New System.Drawing.Point(22, 239)
        Me.btn1000Deposit.Name = "btn1000Deposit"
        Me.btn1000Deposit.Size = New System.Drawing.Size(91, 48)
        Me.btn1000Deposit.TabIndex = 39
        Me.btn1000Deposit.Text = "1000"
        Me.btn1000Deposit.UseVisualStyleBackColor = True
        '
        'btn2000Deposit
        '
        Me.btn2000Deposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2000Deposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn2000Deposit.Location = New System.Drawing.Point(119, 239)
        Me.btn2000Deposit.Name = "btn2000Deposit"
        Me.btn2000Deposit.Size = New System.Drawing.Size(91, 48)
        Me.btn2000Deposit.TabIndex = 40
        Me.btn2000Deposit.Text = "2000"
        Me.btn2000Deposit.UseVisualStyleBackColor = True
        '
        'btn5000Deposit
        '
        Me.btn5000Deposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5000Deposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn5000Deposit.Location = New System.Drawing.Point(22, 293)
        Me.btn5000Deposit.Name = "btn5000Deposit"
        Me.btn5000Deposit.Size = New System.Drawing.Size(91, 48)
        Me.btn5000Deposit.TabIndex = 41
        Me.btn5000Deposit.Text = "5000"
        Me.btn5000Deposit.UseVisualStyleBackColor = True
        '
        'btnCustomDeposit
        '
        Me.btnCustomDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomDeposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnCustomDeposit.Location = New System.Drawing.Point(22, 347)
        Me.btnCustomDeposit.Name = "btnCustomDeposit"
        Me.btnCustomDeposit.Size = New System.Drawing.Size(91, 48)
        Me.btnCustomDeposit.TabIndex = 42
        Me.btnCustomDeposit.Text = "Custom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCustomDeposit.UseVisualStyleBackColor = True
        '
        'btn10000Deposit
        '
        Me.btn10000Deposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10000Deposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn10000Deposit.Location = New System.Drawing.Point(119, 293)
        Me.btn10000Deposit.Name = "btn10000Deposit"
        Me.btn10000Deposit.Size = New System.Drawing.Size(91, 48)
        Me.btn10000Deposit.TabIndex = 43
        Me.btn10000Deposit.Text = "10000"
        Me.btn10000Deposit.UseVisualStyleBackColor = True
        '
        'pBottom
        '
        Me.pBottom.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.pBottom.Controls.Add(Me.PictureBox1)
        Me.pBottom.Controls.Add(Me.lblAccountNumber)
        Me.pBottom.Controls.Add(Me.lblDate)
        Me.pBottom.Controls.Add(Me.Label1)
        Me.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pBottom.Location = New System.Drawing.Point(0, 447)
        Me.pBottom.Name = "pBottom"
        Me.pBottom.Size = New System.Drawing.Size(568, 80)
        Me.pBottom.TabIndex = 46
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Student_Information_System.My.Resources.Resources.atm_sign
        Me.PictureBox1.Location = New System.Drawing.Point(469, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNumber.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblAccountNumber.Location = New System.Drawing.Point(160, 18)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(45, 20)
        Me.lblAccountNumber.TabIndex = 7
        Me.lblAccountNumber.Text = "Num"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblDate.Location = New System.Drawing.Point(12, 51)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Account Number :"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.AliceBlue
        Me.lbl1.Location = New System.Drawing.Point(12, 43)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(306, 20)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "How much would you like to Deposit?"
        '
        'pLabel
        '
        Me.pLabel.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.pLabel.Controls.Add(Me.lbl1)
        Me.pLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pLabel.Location = New System.Drawing.Point(0, 0)
        Me.pLabel.Name = "pLabel"
        Me.pLabel.Size = New System.Drawing.Size(568, 66)
        Me.pLabel.TabIndex = 45
        '
        'pbBack
        '
        Me.pbBack.Image = Global.Student_Information_System.My.Resources.Resources.backtrue
        Me.pbBack.Location = New System.Drawing.Point(12, 72)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(59, 48)
        Me.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBack.TabIndex = 59
        Me.pbBack.TabStop = False
        '
        'FrmDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(568, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbBack)
        Me.Controls.Add(Me.pBottom)
        Me.Controls.Add(Me.pLabel)
        Me.Controls.Add(Me.btn10000Deposit)
        Me.Controls.Add(Me.btnCustomDeposit)
        Me.Controls.Add(Me.btn5000Deposit)
        Me.Controls.Add(Me.btn2000Deposit)
        Me.Controls.Add(Me.btn1000Deposit)
        Me.Controls.Add(Me.btn500Deposit)
        Me.Controls.Add(Me.btn200Deposit)
        Me.Controls.Add(Me.btn100Deposit)
        Me.Controls.Add(Me.btn50Deposit)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.btn1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDeposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pBottom.ResumeLayout(False)
        Me.pBottom.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pLabel.ResumeLayout(False)
        Me.pLabel.PerformLayout()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents lblDeposit As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn50Deposit As Button
    Friend WithEvents btn100Deposit As Button
    Friend WithEvents btn200Deposit As Button
    Friend WithEvents btn500Deposit As Button
    Friend WithEvents btn1000Deposit As Button
    Friend WithEvents btn2000Deposit As Button
    Friend WithEvents btn5000Deposit As Button
    Friend WithEvents btnCustomDeposit As Button
    Friend WithEvents btn10000Deposit As Button
    Friend WithEvents pBottom As Panel
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents pLabel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbBack As PictureBox
End Class
