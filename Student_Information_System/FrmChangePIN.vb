Imports System.Data.SqlClient

Public Class FrmChangePIN

    Public Property Acc As String
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30")
    Dim MyAcc As Integer

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

        txtNewPIN.Text = ""
        txtConfirmPIN.Text = ""

    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If txtNewPIN.Text = "" Or txtConfirmPIN.Text = "" Then
            MsgBox("Please Enter your new PIN", vbCritical, "Error")
        ElseIf txtNewPIN.Text = txtConfirmPIN.Text Then
            Try
                Dim bal = 0
                Con.Open()
                Dim query = "Update TblAccount set PIN= '" & txtNewPIN.Text & "' where AccNum =" & MyAcc & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("PIN Changed Successfull", vbInformation, "Success")
                Con.Close()
                Dim log = New FrmPIN
                log.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Confirm PIN doesn't Match your New PIN", vbCritical, "Error")
        End If

    End Sub

    Private Sub FrmPIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = Date.Now.ToString("MMM dd yyyy hh:mm:ss")

        txtNewPIN.BackColor = Color.White
        txtConfirmPIN.BackColor = Color.White
        lblAccountNumber.Text = Acc
        MyAcc = Convert.ToInt32(Acc)
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs)

        Dim close = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
    Private Sub txtNewPIN_Enter(sender As Object, e As EventArgs) Handles txtNewPIN.Enter

        txtBuffer.Text = "txtNewPIN"
        txtNewPIN.Focus()

        If txtNewPIN.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub

    Private Sub txtConfirmPIN_Enter(sender As Object, e As EventArgs) Handles txtConfirmPIN.Enter

        txtBuffer.Text = "txtConfirmPIN"
        txtConfirmPIN.Focus()

        If txtConfirmPIN.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub
    Private Sub txtNewPIN_TextChanged(sender As Object, e As EventArgs) Handles txtNewPIN.TextChanged

        If txtNewPIN.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub

    Private Sub txtConfirmPIN_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPIN.TextChanged

        If txtConfirmPIN.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
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