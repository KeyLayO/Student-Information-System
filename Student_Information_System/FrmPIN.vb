Imports System.Data.SqlClient
Public Class FrmPIN
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30")
    Dim Myacc As Integer
    Private Sub ButtonNumber_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

        Dim tb As String = txtBuffer.Text
        Dim targetTextBox As TextBox = CType(Controls(tb), TextBox)

        If targetTextBox.Text.Length < 6 Then
            targetTextBox.Text = targetTextBox.Text & Me.ActiveControl.Text
        End If

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim tb As String = txtBuffer.Text
        CType(Controls(tb), TextBox).Focus()
        CType(Controls(tb), TextBox).Text = CType(Controls(tb), TextBox).Text.Substring(0, CType(Controls(tb), TextBox).Text.Length - 1)

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtAccNum.Text = ""
        txtPIN.Text = ""

    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If txtAccNum.Text = "" Then
            MsgBox("Please Enter your Account Number", vbCritical, "Error")
        ElseIf txtPIN.Text = "" Then
            MsgBox("Please Enter your PIN", vbCritical, "Error")
        ElseIf txtAccNum.Text = "123456" Then
            Dim obj = New FrmAdmin
            obj.Show()
            Me.Close()
        ElseIf txtAccNum.Text = "654321" Then
            Dim obj As New FrmImportant
            obj.Show()
            Me.Close()
        Else
            con.open()
            Dim query = "select * from TblAccount where AccNum='" & txtAccNum.Text & "' and PIN='" & txtPIN.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            con.close
            If a = 0 Then
                MsgBox("Wrong Account Number or PIN", vbCritical, "Error")
            Else
                Dim obj = New FrmChoose
                obj.Acc = txtAccNum.Text
                obj.Show()
                Me.Close()
            End If

        End If

    End Sub

    Private Sub FrmPIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = Date.Now.ToString("MMM dd yyyy hh:mm:ss")

        txtAccNum.BackColor = Color.White
        txtPIN.BackColor = Color.White

    End Sub
    Private Sub linklblRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblRegister.LinkClicked

        Dim obj As New FrmRegistration
        obj.Show()
        Me.Close()

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim close = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = DialogResult.Yes Then
            Student_Information_System.Show()
            Me.Close()
        End If

    End Sub
    Private Sub txtAccNum_Enter(sender As Object, e As EventArgs) Handles txtAccNum.Enter

        txtBuffer.Text = "txtAccNum"
        txtAccNum.Focus()

        If txtAccNum.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub
    Private Sub txtPIN_Enter(sender As Object, e As EventArgs) Handles txtPIN.Enter

        txtBuffer.Text = "txtPIN"
        txtPIN.Focus()

        If txtPIN.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
    End Sub
    Private Sub txtAccNum_TextChanged(sender As Object, e As EventArgs) Handles txtAccNum.TextChanged

        If txtAccNum.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub

    Private Sub txtPIN_TextChanged(sender As Object, e As EventArgs) Handles txtPIN.TextChanged

        If txtPIN.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub

End Class