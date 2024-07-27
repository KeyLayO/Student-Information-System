Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkShow.Enabled = False

    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "Kurt" Then
            If txtPassword.Text = "123" Then
                MsgBox("Welcome " & txtUsername.Text, vbInformation, "Welcome")
                Student_Information_System.Show()
                Me.Close()
            Else
                MsgBox("Password is incorrect", vbCritical, "Error")
            End If

        ElseIf txtUsername.Text = "Jerald" Then
            If txtPassword.Text = "456" Then
                MsgBox("Welcome " & txtUsername.Text, vbInformation, "Welcome")
                Student_Information_System.Show()
                Me.Close()
            Else
                MsgBox("Password is incorrect", vbCritical, "Error")
            End If
        Else
            MsgBox("Username not found", vbCritical, "Error")
        End If

    End Sub

    Private Sub ChkShow_CheckedChange(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TCloud1.Tick

        pbCloud1.Left = pbCloud1.Left + 5
        If pbCloud1.Left = 520 Then
            pbCloud1.Left = -150
        End If

    End Sub

    Private Sub TCloud2_Tick(sender As Object, e As EventArgs) Handles TCloud2.Tick

        pbCloud2.Left = pbCloud2.Left + 5
        If pbCloud2.Left = 520 Then
            pbCloud2.Left = -150
        End If

    End Sub

    Private Sub TCloud3_Tick(sender As Object, e As EventArgs) Handles TCloud3.Tick

        pbCloud3.Left = pbCloud3.Left + 5
        If pbCloud3.Left = 520 Then
            pbCloud3.Left = -150
        End If

    End Sub

    Private Sub TSun_Tick(sender As Object, e As EventArgs) Handles TSun.Tick

        pbSun.Left = pbSun.Left + 2
        If pbSun.Left = 520 Then
            pbSun.Left = -150
            TSun.Enabled = False
            Panel2.BackColor = Color.MidnightBlue
            TMoon.Enabled = True
        End If

    End Sub

    Private Sub TMoon_Tick(sender As Object, e As EventArgs) Handles TMoon.Tick

        If TSun.Enabled = False Then
            PbMoon.Left = PbMoon.Left + 2
        End If

        If PbMoon.Left = 520 Then
            PbMoon.Left = -150
            TMoon.Enabled = False
            Panel2.BackColor = Color.SkyBlue
            TSun.Enabled = True
        End If

    End Sub

    Private Sub TxtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter

        If txtUsername.Text = "Username" Then
            If txtUsername.ForeColor = Color.Silver Then
                txtUsername.Text = ""
                txtUsername.ForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub TxtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave

        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Silver
        End If

    End Sub

    Private Sub TxtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter

        If txtPassword.Text = "Password" Then
            If txtPassword.ForeColor = Color.Silver Then
                txtPassword.Text = ""
                txtPassword.ForeColor = Color.Black
                txtPassword.UseSystemPasswordChar = True
            End If
        End If

    End Sub

    Private Sub TxtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave

        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Silver
            txtPassword.UseSystemPasswordChar = False
            chkShow.Enabled = False
        End If

    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        If txtPassword.Text = "" Then
            chkShow.Enabled = False
        Else
            chkShow.Enabled = True
        End If

    End Sub
End Class