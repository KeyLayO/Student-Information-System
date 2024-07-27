Imports System.Data.SqlClient
Public Class FrmDeposit
    Public Property Acc As String
    Public Property AccType As String
    Public Property AccAmount As String
    Public Property AccDate As String

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30")
    Dim MyAcc As Integer
    Dim OldBalance = 0
    Private Sub BtnCustomDeposit_Click(sender As Object, e As EventArgs) Handles btnCustomDeposit.Click

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
        txtDeposit.Visible = True
        lblDeposit.Visible = True

    End Sub

    Private Sub ButtonNumber_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

        Dim btnInput As String = DirectCast(sender, Button).Text
        If txtDeposit.Text.Length < 5 Then
            txtDeposit.Text &= btnInput
        End If

    End Sub

    Private Sub TxtDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtDeposit.TextChanged

        If txtDeposit.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        txtDeposit.Text = txtDeposit.Text.Substring(0, txtDeposit.Text.Length - 1)

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtDeposit.Text = ""

    End Sub

    Private Sub FrmDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = Date.Now.ToString("MMM dd yyyy hh:mm:ss")

        txtDeposit.BackColor = Color.White
        lblAccountNumber.Text = Acc
        MyAcc = Convert.ToInt32(Acc)
        GetBalance()

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If txtDeposit.Text = "" Or Convert.ToInt32(txtDeposit.Text) < 1 Then
            MsgBox("Please Enter the Amount you want to Deposit", vbCritical, "Error")
        ElseIf txtDeposit.Text > 25000 Then
            MsgBox("You can't Deposit higher than 25000", vbCritical, "Error")
            txtDeposit.Text = ""
            Exit Sub
        ElseIf Not (txtDeposit.Text Mod 50 = 0) Then
            MsgBox("Withdrawal amount not applicable", vbCritical, "Error")
            txtDeposit.Text = ""
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Deposit"
            Try
                Dim bal = 0
                Con.Open()
                Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtDeposit.Text & ",'" & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Deposit Successfull", vbInformation, "Success")
                Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If receipt = DialogResult.Yes Then
                    Dim obj1 As New FrmReceipt
                    obj1.Acc = lblAccountNumber.Text
                    obj1.AccType = "Deposit"
                    obj1.AccAmount = txtDeposit.Text
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
        Con.Open
        Dim cmd As SqlCommand
        Dim query = "Select Balance from TblAccount where AccNum=" & Acc & ""
        cmd = New SqlCommand(query, Con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        Con.Close()

    End Sub
    Private Sub UpdateBalance()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance + Convert.ToInt32(txtDeposit.Text)
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

    Private Sub btn50Deposit_Click(sender As Object, e As EventArgs) Handles btn50Deposit.Click

        txtDeposit.Text = "50"
        Dim Account = Convert.ToInt32(Acc)
        Dim TrType = "Deposit"
        Try
            Dim bal = 0
            Con.Open()
            Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtDeposit.Text & ",'" & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deposit Successfull", vbInformation, "Success")
            Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If receipt = DialogResult.Yes Then
                Dim obj1 As New FrmReceipt
                obj1.Acc = lblAccountNumber.Text
                obj1.AccType = "Deposit"
                obj1.AccAmount = txtDeposit.Text
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

    End Sub

    Private Sub btn100Deposit_Click(sender As Object, e As EventArgs) Handles btn100Deposit.Click

        txtDeposit.Text = "100"
        Dim Account = Convert.ToInt32(Acc)
        Dim TrType = "Deposit"
        Try
            Dim bal = 0
            Con.Open()
            Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtDeposit.Text & ",'" & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deposit Successfull", vbInformation, "Success")
            Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If receipt = DialogResult.Yes Then
                Dim obj1 As New FrmReceipt
                obj1.Acc = lblAccountNumber.Text
                obj1.AccType = "Deposit"
                obj1.AccAmount = txtDeposit.Text
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

    End Sub

    Private Sub btn200Deposit_Click(sender As Object, e As EventArgs) Handles btn200Deposit.Click

        txtDeposit.Text = "200"
        Dim Account = Convert.ToInt32(Acc)
        Dim TrType = "Deposit"
        Try
            Dim bal = 0
            Con.Open()
            Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtDeposit.Text & ",'" & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deposit Successfull", vbInformation, "Success")
            Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If receipt = DialogResult.Yes Then
                Dim obj1 As New FrmReceipt
                obj1.Acc = lblAccountNumber.Text
                obj1.AccType = "Deposit"
                obj1.AccAmount = txtDeposit.Text
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

    End Sub

    Private Sub btn500Deposit_Click(sender As Object, e As EventArgs) Handles btn500Deposit.Click

        txtDeposit.Text = "500"
        Dim Account = Convert.ToInt32(Acc)
        Dim TrType = "Deposit"
        Try
            Dim bal = 0
            Con.Open()
            Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtDeposit.Text & ",'" & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deposit Successfull", vbInformation, "Success")
            Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If receipt = DialogResult.Yes Then
                Dim obj1 As New FrmReceipt
                obj1.Acc = lblAccountNumber.Text
                obj1.AccType = "Deposit"
                obj1.AccAmount = txtDeposit.Text
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

    End Sub

    Private Sub btn1000Deposit_Click(sender As Object, e As EventArgs) Handles btn1000Deposit.Click

        txtDeposit.Text = "1000"
        Dim Account = Convert.ToInt32(Acc)
        Dim TrType = "Deposit"
        Try
            Dim bal = 0
            Con.Open()
            Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtDeposit.Text & ",'" & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deposit Successfull", vbInformation, "Success")
            Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If receipt = DialogResult.Yes Then
                Dim obj1 As New FrmReceipt
                obj1.Acc = lblAccountNumber.Text
                obj1.AccType = "Deposit"
                obj1.AccAmount = txtDeposit.Text
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

    End Sub

    Private Sub btn2000Deposit_Click(sender As Object, e As EventArgs) Handles btn2000Deposit.Click

        txtDeposit.Text = "2000"
        Dim Account = Convert.ToInt32(Acc)
        Dim TrType = "Deposit"
        Try
            Dim bal = 0
            Con.Open()
            Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtDeposit.Text & ",'" & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deposit Successfull", vbInformation, "Success")
            Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If receipt = DialogResult.Yes Then
                Dim obj1 As New FrmReceipt
                obj1.Acc = lblAccountNumber.Text
                obj1.AccType = "Deposit"
                obj1.AccAmount = txtDeposit.Text
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

    End Sub

    Private Sub btn5000Deposit_Click(sender As Object, e As EventArgs) Handles btn5000Deposit.Click

        txtDeposit.Text = "5000"
        Dim Account = Convert.ToInt32(Acc)
        Dim TrType = "Deposit"
        Try
            Dim bal = 0
            Con.Open()
            Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtDeposit.Text & ",'" & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deposit Successfull", vbInformation, "Success")
            Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If receipt = DialogResult.Yes Then
                Dim obj1 As New FrmReceipt
                obj1.Acc = lblAccountNumber.Text
                obj1.AccType = "Deposit"
                obj1.AccAmount = txtDeposit.Text
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

    End Sub

    Private Sub btn10000Deposit_Click(sender As Object, e As EventArgs) Handles btn10000Deposit.Click

        txtDeposit.Text = "10000"
        Dim Account = Convert.ToInt32(Acc)
        Dim TrType = "Deposit"
        Try
            Dim bal = 0
            Con.Open()
            Dim query = "insert into TblTransaction values(" & MyAcc & ",'" & TrType & "'," & txtDeposit.Text & ",'" & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deposit Successfull", vbInformation, "Success")
            Dim receipt = MessageBox.Show("Would you like to print out your receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If receipt = DialogResult.Yes Then
                Dim obj1 As New FrmReceipt
                obj1.Acc = lblAccountNumber.Text
                obj1.AccType = "Deposit"
                obj1.AccAmount = txtDeposit.Text
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