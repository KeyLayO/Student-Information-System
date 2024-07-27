Public Class Student_Information_System
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Dim labas = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo)
        If labas = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub StudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentInformationToolStripMenuItem.Click

        Student_Information.Show()
        Me.Close()

    End Sub

    Private Sub MetricSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MetricSystemToolStripMenuItem.Click

        Metric_System.Show()
        Me.Close()

    End Sub
    Private Sub ATMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATMToolStripMenuItem.Click

        FrmPIN.Show()
        Me.Close()

    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click

        Process.Start("calc.exe")

    End Sub

    Private Sub ChessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChessToolStripMenuItem.Click

        Process.Start("www.chess.com")

    End Sub

    Private Sub FacebookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacebookToolStripMenuItem.Click

        Process.Start("www.facebook.com")

    End Sub

    Private Sub GoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleToolStripMenuItem.Click

        Process.Start("www.google.com")

    End Sub

    Private Sub MsWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsWordToolStripMenuItem.Click

        Process.Start("WINWORD.EXE")

    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click

        Process.Start("notepad")

    End Sub

    Private Sub PowerpointToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerpointToolStripMenuItem.Click

        Process.Start("POWERPNT.EXE")

    End Sub

    Private Sub YoutubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YoutubeToolStripMenuItem.Click

        Process.Start("www.youtube.com")

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        Dim logout = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo)
        If logout = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

        MsgBox("Ayaw ko nga", vbCritical, "Hmmp")

    End Sub

End Class