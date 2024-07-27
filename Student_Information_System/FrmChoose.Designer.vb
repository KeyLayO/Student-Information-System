<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmChoose
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
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pLabel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnChangePIN = New System.Windows.Forms.Button()
        Me.pBottom = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pLabel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pBottom.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBalance
        '
        Me.btnBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalance.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnBalance.Location = New System.Drawing.Point(32, 103)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(183, 97)
        Me.btnBalance.TabIndex = 0
        Me.btnBalance.Text = "Balance"
        Me.btnBalance.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnWithdraw.Location = New System.Drawing.Point(32, 309)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(183, 97)
        Me.btnWithdraw.TabIndex = 1
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnDeposit.Location = New System.Drawing.Point(32, 206)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(183, 97)
        Me.btnDeposit.TabIndex = 2
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnBack.Location = New System.Drawing.Point(351, 206)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(183, 97)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Logout"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'pLabel
        '
        Me.pLabel.BackColor = System.Drawing.Color.DarkRed
        Me.pLabel.Controls.Add(Me.Panel1)
        Me.pLabel.Controls.Add(Me.lbl1)
        Me.pLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pLabel.Location = New System.Drawing.Point(0, 0)
        Me.pLabel.Name = "pLabel"
        Me.pLabel.Size = New System.Drawing.Size(568, 66)
        Me.pLabel.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 66)
        Me.Panel1.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "What would you like to do?"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(12, 43)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(223, 20)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "What would you like to do?"
        '
        'btnChangePIN
        '
        Me.btnChangePIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePIN.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnChangePIN.Location = New System.Drawing.Point(353, 103)
        Me.btnChangePIN.Name = "btnChangePIN"
        Me.btnChangePIN.Size = New System.Drawing.Size(183, 97)
        Me.btnChangePIN.TabIndex = 6
        Me.btnChangePIN.Text = "Change PIN"
        Me.btnChangePIN.UseVisualStyleBackColor = True
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
        Me.pBottom.TabIndex = 47
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
        'FrmChoose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(568, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.pBottom)
        Me.Controls.Add(Me.btnChangePIN)
        Me.Controls.Add(Me.pLabel)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnBalance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmChoose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pLabel.ResumeLayout(False)
        Me.pLabel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pBottom.ResumeLayout(False)
        Me.pBottom.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBalance As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pLabel As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnChangePIN As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pBottom As Panel
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
