<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImportant
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
        Me.pLabel = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pLabel
        '
        Me.pLabel.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.pLabel.Controls.Add(Me.lbl1)
        Me.pLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pLabel.Location = New System.Drawing.Point(0, 0)
        Me.pLabel.Name = "pLabel"
        Me.pLabel.Size = New System.Drawing.Size(568, 66)
        Me.pLabel.TabIndex = 22
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.AliceBlue
        Me.lbl1.Location = New System.Drawing.Point(12, 43)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(68, 20)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Whistle"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 461)
        Me.Panel1.TabIndex = 24
        '
        'FrmImportant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(568, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmImportant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pLabel.ResumeLayout(False)
        Me.pLabel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pLabel As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents Panel1 As Panel
End Class
