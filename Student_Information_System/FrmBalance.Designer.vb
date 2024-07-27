<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBalance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.pLabel = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.pBottom = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pLabel.SuspendLayout()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBottom.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label1.Location = New System.Drawing.Point(181, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Your Balance :"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.lblBalance.Location = New System.Drawing.Point(314, 253)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(74, 20)
        Me.lblBalance.TabIndex = 7
        Me.lblBalance.Text = "Balance"
        '
        'pLabel
        '
        Me.pLabel.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.pLabel.Controls.Add(Me.lbl1)
        Me.pLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pLabel.Location = New System.Drawing.Point(0, 0)
        Me.pLabel.Name = "pLabel"
        Me.pLabel.Size = New System.Drawing.Size(568, 66)
        Me.pLabel.TabIndex = 57
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.AliceBlue
        Me.lbl1.Location = New System.Drawing.Point(12, 43)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(74, 20)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Balance"
        '
        'pbBack
        '
        Me.pbBack.Image = Global.Student_Information_System.My.Resources.Resources.backtrue
        Me.pbBack.Location = New System.Drawing.Point(12, 72)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(59, 48)
        Me.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBack.TabIndex = 58
        Me.pbBack.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Account Number :"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(12, 51)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date"
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNumber.ForeColor = System.Drawing.Color.White
        Me.lblAccountNumber.Location = New System.Drawing.Point(160, 18)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(45, 20)
        Me.lblAccountNumber.TabIndex = 7
        Me.lblAccountNumber.Text = "Num"
        '
        'pBottom
        '
        Me.pBottom.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.pBottom.Controls.Add(Me.PictureBox1)
        Me.pBottom.Controls.Add(Me.lblAccountNumber)
        Me.pBottom.Controls.Add(Me.lblDate)
        Me.pBottom.Controls.Add(Me.Label4)
        Me.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pBottom.Location = New System.Drawing.Point(0, 447)
        Me.pBottom.Name = "pBottom"
        Me.pBottom.Size = New System.Drawing.Size(568, 80)
        Me.pBottom.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Student_Information_System.My.Resources.Resources.atm_sign
        Me.PictureBox1.Location = New System.Drawing.Point(469, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'FrmBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(568, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbBack)
        Me.Controls.Add(Me.pLabel)
        Me.Controls.Add(Me.pBottom)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pLabel.ResumeLayout(False)
        Me.pLabel.PerformLayout()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBottom.ResumeLayout(False)
        Me.pBottom.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents pLabel As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents pBottom As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
