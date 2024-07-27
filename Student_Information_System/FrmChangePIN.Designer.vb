<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmChangePIN
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewPIN = New System.Windows.Forms.TextBox()
        Me.txtConfirmPIN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBuffer = New System.Windows.Forms.TextBox()
        Me.pBottom = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pLabel = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        Me.pBottom.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pLabel.SuspendLayout()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Lime
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(328, 290)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(108, 48)
        Me.btnEnter.TabIndex = 28
        Me.btnEnter.TabStop = False
        Me.btnEnter.Text = "ENTER"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(328, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 48)
        Me.btnClear.TabIndex = 27
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(328, 182)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(108, 48)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn0.Location = New System.Drawing.Point(198, 344)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(59, 48)
        Me.btn0.TabIndex = 25
        Me.btn0.TabStop = False
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn9.Location = New System.Drawing.Point(263, 290)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(59, 48)
        Me.btn9.TabIndex = 24
        Me.btn9.TabStop = False
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn8.Location = New System.Drawing.Point(198, 290)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(59, 48)
        Me.btn8.TabIndex = 23
        Me.btn8.TabStop = False
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn7.Location = New System.Drawing.Point(133, 290)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(59, 48)
        Me.btn7.TabIndex = 22
        Me.btn7.TabStop = False
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn6.Location = New System.Drawing.Point(263, 236)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(59, 48)
        Me.btn6.TabIndex = 21
        Me.btn6.TabStop = False
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn5.Location = New System.Drawing.Point(198, 236)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(59, 48)
        Me.btn5.TabIndex = 20
        Me.btn5.TabStop = False
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn4.Location = New System.Drawing.Point(133, 236)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(59, 48)
        Me.btn4.TabIndex = 19
        Me.btn4.TabStop = False
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn3.Location = New System.Drawing.Point(263, 182)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(59, 48)
        Me.btn3.TabIndex = 18
        Me.btn3.TabStop = False
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn2.Location = New System.Drawing.Point(198, 182)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(59, 48)
        Me.btn2.TabIndex = 17
        Me.btn2.TabStop = False
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btn1.Location = New System.Drawing.Point(133, 182)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(59, 48)
        Me.btn1.TabIndex = 16
        Me.btn1.TabStop = False
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label2.Location = New System.Drawing.Point(177, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "New PIN :"
        '
        'txtNewPIN
        '
        Me.txtNewPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPIN.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.txtNewPIN.Location = New System.Drawing.Point(257, 93)
        Me.txtNewPIN.Name = "txtNewPIN"
        Me.txtNewPIN.ReadOnly = True
        Me.txtNewPIN.Size = New System.Drawing.Size(147, 26)
        Me.txtNewPIN.TabIndex = 1
        Me.txtNewPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNewPIN.UseSystemPasswordChar = True
        '
        'txtConfirmPIN
        '
        Me.txtConfirmPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPIN.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.txtConfirmPIN.Location = New System.Drawing.Point(257, 137)
        Me.txtConfirmPIN.Name = "txtConfirmPIN"
        Me.txtConfirmPIN.ReadOnly = True
        Me.txtConfirmPIN.Size = New System.Drawing.Size(147, 26)
        Me.txtConfirmPIN.TabIndex = 2
        Me.txtConfirmPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtConfirmPIN.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label3.Location = New System.Drawing.Point(155, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Confirm PIN :"
        '
        'txtBuffer
        '
        Me.txtBuffer.Location = New System.Drawing.Point(456, 72)
        Me.txtBuffer.Name = "txtBuffer"
        Me.txtBuffer.Size = New System.Drawing.Size(100, 20)
        Me.txtBuffer.TabIndex = 33
        Me.txtBuffer.TabStop = False
        Me.txtBuffer.Visible = False
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
        Me.pBottom.TabIndex = 55
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
        'pLabel
        '
        Me.pLabel.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.pLabel.Controls.Add(Me.lbl1)
        Me.pLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pLabel.Location = New System.Drawing.Point(0, 0)
        Me.pLabel.Name = "pLabel"
        Me.pLabel.Size = New System.Drawing.Size(568, 66)
        Me.pLabel.TabIndex = 56
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.AliceBlue
        Me.lbl1.Location = New System.Drawing.Point(12, 43)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(105, 20)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Change PIN"
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
        'FrmChangePIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(568, 527)
        Me.Controls.Add(Me.pbBack)
        Me.Controls.Add(Me.pLabel)
        Me.Controls.Add(Me.pBottom)
        Me.Controls.Add(Me.txtBuffer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNewPIN)
        Me.Controls.Add(Me.txtConfirmPIN)
        Me.Controls.Add(Me.Label3)
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
        Me.Controls.Add(Me.btn1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmChangePIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmChangePIN"
        Me.pBottom.ResumeLayout(False)
        Me.pBottom.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pLabel.ResumeLayout(False)
        Me.pLabel.PerformLayout()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents btn1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewPIN As TextBox
    Friend WithEvents txtConfirmPIN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBuffer As TextBox
    Friend WithEvents pBottom As Panel
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pLabel As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbBack As PictureBox
End Class
