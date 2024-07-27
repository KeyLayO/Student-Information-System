Imports System.Data.SqlClient
Public Class FrmWithdraw
    Public Property Acc As String
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30")
    Dim MyAcc As Integer
    Dim OldBalance = 0
    Dim amount As Integer
    Private Sub BtnCustomWithdraw_Click(sender As Object, e As EventArgs) Handles btnCustomWithdraw.Click

        btn1.Visible = True
        btn2.Visible = True
        btn3.Visible = True
        btn4.Visible = True
        btn5.Visible = True
        btn6.Visible = True
        btn7.Visible = True
        btn8.Visible = True
        btn9.Visible = True
        btn0.Visible = True
        btnDelete.Visible = True
        btnClear.Visible = True
        btnEnter.Visible = True
        txtWithdraw.Visible = True
        lblWithdraw.Visible = True

    End Sub

    Private Sub ButtonNumber_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

        Dim btnInput As String = DirectCast(sender, Button).Text
        If txtWithdraw.Text.Length < 5 Then
            txtWithdraw.Text &= btnInput
        End If

    End Sub

    Private Sub TxtWithdraw_TextChanged(sender As Object, e As EventArgs) Handles txtWithdraw.TextChanged

        If txtWithdraw.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        txtWithdraw.Text = txtWithdraw.Text.Substring(0, txtWithdraw.Text.Length - 1)

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtWithdraw.Text = ""

    End Sub

    Private Sub FrmWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = Date.Now.ToString("MMM dd yyyy hh:mm:ss")
        GetBalance()

        txtWithdraw.BackColor = Color.White
        lblAccountNumber.Text = Acc
        MyAcc = Convert.ToInt32(Acc)
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If txtWithdraw.Text = "" Then
            MsgBox("Please Enter the Amount you want to Withdraw", vbCritical, "Error")
        ElseIf Convert.ToInt32(txtWithdraw.Text) > OldBalance Then
            MsgBox("Not enough balance", vbCritical, "Error")
        ElseIf txtWithdraw.Text > 25000 Then
            MsgBox("You can't Withdraw higher than 25000", vbCritical, "Error")
            txtWithdraw.Text = ""
            Exit Sub
        ElseIf Not (txtWithdraw.Text Mod 50 = 0) Then
            MsgBox("Withdrawal amount not applicable", vbCritical, "Error")
            txtWithdraw.Text = ""
        Else
                Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim bal = 0
                con.Open()
                Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtWithdraw.Text & ",'" & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull", vbInformation, "Success")
                Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If receipt = DialogResult.Yes Then
                    Dim obj1 As New FrmReceipt
                    obj1.SendToBack()
                    obj1.Acc = lblAccountNumber.Text
                    obj1.AccType = "Withdraw"
                    obj1.AccAmount = txtWithdraw.Text
                    obj1.AccDate = lblDate.Text
                    obj1.Show()
                End If
                Con.Close()
                UpdateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim close = MessageBox.Show("Do you want to make another transaction?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If close = DialogResult.Yes Then
                Dim obj As New FrmChoose
                obj.Acc = lblAccountNumber.Text
                obj.Show()
                Me.Close()
            Else
                MsgBox("Thank You", vbInformation, "Bye")
                Dim obj As New FrmPIN
                obj.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub GetBalance()
        con.Open
        Dim cmd As SqlCommand
        Dim query = "select Balance from TblAccount where AccNum=" & Acc & ""
        cmd = New SqlCommand(query, con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        con.Close()

    End Sub

    Private Sub UpdateBalance()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance - Convert.ToInt32(txtWithdraw.Text)
        Try
            Con.Open()
            Dim query = "Update TblAccount set Balance =" & NewBal & " where AccNum= " & Acc & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn50Withdraw_Click(sender As Object, e As EventArgs) Handles btn50Withdraw.Click

        txtWithdraw.Text = "50"
        If Convert.ToInt32(txtWithdraw.Text) > OldBalance Then
            MsgBox("Not enough balance", vbCritical, "Error")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim bal = 0
                Con.Open()
                Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtWithdraw.Text & ",'" & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull", vbInformation, "Success")
                Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If receipt = DialogResult.Yes Then
                    Dim obj1 As New FrmReceipt
                    obj1.Acc = lblAccountNumber.Text
                    obj1.AccType = "Withdraw"
                    obj1.AccAmount = txtWithdraw.Text
                    obj1.AccDate = lblDate.Text
                    obj1.Show()
                End If
                Con.Close()
                UpdateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim close = MessageBox.Show("Do you want to make another transaction?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If close = DialogResult.Yes Then
                Dim obj As New FrmChoose
                obj.Acc = lblAccountNumber.Text
                obj.Show()
                Me.Close()
            Else
                MsgBox("Thank You", vbInformation, "Bye")
                Dim obj As New FrmPIN
                obj.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btn100Withdraw_Click(sender As Object, e As EventArgs) Handles btn100Withdraw.Click

        txtWithdraw.Text = "100"
        If Convert.ToInt32(txtWithdraw.Text) > OldBalance Then
            MsgBox("Not enough balance", vbCritical, "Error")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim bal = 0
                Con.Open()
                Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtWithdraw.Text & ",'" & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull", vbInformation, "Success")
                Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If receipt = DialogResult.Yes Then
                    Dim obj1 As New FrmReceipt
                    obj1.Acc = lblAccountNumber.Text
                    obj1.AccType = "Withdraw"
                    obj1.AccAmount = txtWithdraw.Text
                    obj1.AccDate = lblDate.Text
                    obj1.Show()
                End If
                Con.Close()
                UpdateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim close = MessageBox.Show("Do you want to make another transaction?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If close = DialogResult.Yes Then
                Dim obj As New FrmChoose
                obj.Acc = lblAccountNumber.Text
                obj.Show()
                Me.Close()
            Else
                MsgBox("Thank You", vbInformation, "Bye")
                Dim obj As New FrmPIN
                obj.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btn200Withdraw_Click(sender As Object, e As EventArgs) Handles btn200Withdraw.Click

        txtWithdraw.Text = "200"
        If Convert.ToInt32(txtWithdraw.Text) > OldBalance Then
            MsgBox("Not enough balance", vbCritical, "Error")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim bal = 0
                Con.Open()
                Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtWithdraw.Text & ",'" & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull", vbInformation, "Success")
                Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If receipt = DialogResult.Yes Then
                    Dim obj1 As New FrmReceipt
                    obj1.Acc = lblAccountNumber.Text
                    obj1.AccType = "Withdraw"
                    obj1.AccAmount = txtWithdraw.Text
                    obj1.AccDate = lblDate.Text
                    obj1.Show()
                End If
                Con.Close()
                UpdateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim close = MessageBox.Show("Do you want to make another transaction?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If close = DialogResult.Yes Then
                Dim obj As New FrmChoose
                obj.Acc = lblAccountNumber.Text
                obj.Show()
                Me.Close()
            Else
                MsgBox("Thank You", vbInformation, "Bye")
                Dim obj As New FrmPIN
                obj.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btn500Withdraw_Click(sender As Object, e As EventArgs) Handles btn500Withdraw.Click

        txtWithdraw.Text = "500"
        If Convert.ToInt32(txtWithdraw.Text) > OldBalance Then
            MsgBox("Not enough balance", vbCritical, "Error")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim bal = 0
                Con.Open()
                Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtWithdraw.Text & ",'" & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull", vbInformation, "Success")
                Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If receipt = DialogResult.Yes Then
                    Dim obj1 As New FrmReceipt
                    obj1.Acc = lblAccountNumber.Text
                    obj1.AccType = "Withdraw"
                    obj1.AccAmount = txtWithdraw.Text
                    obj1.AccDate = lblDate.Text
                    obj1.Show()
                End If
                Con.Close()
                UpdateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim close = MessageBox.Show("Do you want to make another transaction?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If close = DialogResult.Yes Then
                Dim obj As New FrmChoose
                obj.Acc = lblAccountNumber.Text
                obj.Show()
                Me.Close()
            Else
                MsgBox("Thank You", vbInformation, "Bye")
                Dim obj As New FrmPIN
                obj.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btn1000Withdraw_Click(sender As Object, e As EventArgs) Handles btn1000Withdraw.Click

        txtWithdraw.Text = "1000"
        If Convert.ToInt32(txtWithdraw.Text) > OldBalance Then
            MsgBox("Not enough balance", vbCritical, "Error")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim bal = 0
                Con.Open()
                Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtWithdraw.Text & ",'" & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull", vbInformation, "Success")
                Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If receipt = DialogResult.Yes Then
                    Dim obj1 As New FrmReceipt
                    obj1.Acc = lblAccountNumber.Text
                    obj1.AccType = "Withdraw"
                    obj1.AccAmount = txtWithdraw.Text
                    obj1.AccDate = lblDate.Text
                    obj1.Show()
                End If
                Con.Close()
                UpdateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim close = MessageBox.Show("Do you want to make another transaction?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If close = DialogResult.Yes Then
                Dim obj As New FrmChoose
                obj.Acc = lblAccountNumber.Text
                obj.Show()
                Me.Close()
            Else
                MsgBox("Thank You", vbInformation, "Bye")
                Dim obj As New FrmPIN
                obj.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btn2000Withdraw_Click(sender As Object, e As EventArgs) Handles btn2000Withdraw.Click

        txtWithdraw.Text = "2000"
        If Convert.ToInt32(txtWithdraw.Text) > OldBalance Then
            MsgBox("Not enough balance", vbCritical, "Error")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim bal = 0
                Con.Open()
                Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtWithdraw.Text & ",'" & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull", vbInformation, "Success")
                Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If receipt = DialogResult.Yes Then
                    Dim obj1 As New FrmReceipt
                    obj1.Acc = lblAccountNumber.Text
                    obj1.AccType = "Withdraw"
                    obj1.AccAmount = txtWithdraw.Text
                    obj1.AccDate = lblDate.Text
                    obj1.Show()
                End If
                Con.Close()
                UpdateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim close = MessageBox.Show("Do you want to make another transaction?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If close = DialogResult.Yes Then
                Dim obj As New FrmChoose
                obj.Acc = lblAccountNumber.Text
                obj.Show()
                Me.Close()
            Else
                MsgBox("Thank You", vbInformation, "Bye")
                Dim obj As New FrmPIN
                obj.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btn5000Withdraw_Click(sender As Object, e As EventArgs) Handles btn5000Withdraw.Click

        txtWithdraw.Text = "5000"
        If Convert.ToInt32(txtWithdraw.Text) > OldBalance Then
            MsgBox("Not enough balance", vbCritical, "Error")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim bal = 0
                Con.Open()
                Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtWithdraw.Text & ",'" & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull", vbInformation, "Success")
                Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If receipt = DialogResult.Yes Then
                    Dim obj1 As New FrmReceipt
                    obj1.Acc = lblAccountNumber.Text
                    obj1.AccType = "Withdraw"
                    obj1.AccAmount = txtWithdraw.Text
                    obj1.AccDate = lblDate.Text
                    obj1.Show()
                End If
                Con.Close()
                UpdateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim close = MessageBox.Show("Do you want to make another transaction?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If close = DialogResult.Yes Then
                Dim obj As New FrmChoose
                obj.Acc = lblAccountNumber.Text
                obj.Show()
                Me.Close()
            Else
                MsgBox("Thank You", vbInformation, "Bye")
                Dim obj As New FrmPIN
                obj.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btn10000Withdraw_Click(sender As Object, e As EventArgs) Handles btn10000Withdraw.Click

        txtWithdraw.Text = "10000"
        If Convert.ToInt32(txtWithdraw.Text) > OldBalance Then
            MsgBox("Not enough balance", vbCritical, "Error")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim bal = 0
                Con.Open()
                Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtWithdraw.Text & ",'" & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull", vbInformation, "Success")
                Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If receipt = DialogResult.Yes Then
                    Dim obj1 As New FrmReceipt
                    obj1.Acc = lblAccountNumber.Text
                    obj1.AccType = "Withdraw"
                    obj1.AccAmount = txtWithdraw.Text
                    obj1.AccDate = lblDate.Text
                    obj1.Show()
                End If
                Con.Close()
                UpdateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim close = MessageBox.Show("Do you want to make another transaction?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If close = DialogResult.Yes Then
                Dim obj As New FrmChoose
                obj.Acc = lblAccountNumber.Text
                obj.Show()
                Me.Close()
            Else
                MsgBox("Thank You", vbInformation, "Bye")
                Dim obj As New FrmPIN
                obj.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click

        Dim close = MessageBox.Show("Do you want to make another transaction?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = DialogResult.Yes Then
            Dim obj As New FrmChoose
            obj.Acc = lblAccountNumber.Text
            obj.Show()
            Me.Close()
        Else
            MsgBox("Thank You", vbInformation, "Bye")
            Dim obj As New FrmPIN
            obj.Show()
            Me.Close()
        End If

    End Sub

End Class