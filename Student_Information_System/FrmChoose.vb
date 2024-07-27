Public Class FrmChoose
    Public Property Acc As String

    Private Sub BtnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click

        Dim obj As New FrmBalance
        obj.Acc = lblAccountNumber.Text
        obj.Show()
        Me.Close()

    End Sub

    Private Sub BtnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

        Dim obj As New FrmDeposit
        obj.Acc = lblAccountNumber.Text
        obj.Show()
        Me.Close()

    End Sub

    Private Sub BtnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        Dim obj As New FrmWithdraw
        obj.Acc = lblAccountNumber.Text
        obj.Show()
        Me.Close()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        MsgBox("Thank You", vbInformation, "Bye")
        Dim obj As New FrmPIN
        obj.Show()
        Me.Close()

    End Sub

    Private Sub FrmChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = Date.Now.ToString("MMM dd yyyy hh:mm:ss")

        lblAccountNumber.Text = Acc

    End Sub

    Private Sub btnChangePIN_Click(sender As Object, e As EventArgs) Handles btnChangePIN.Click

        Dim obj As New FrmChangePIN
        obj.Acc = lblAccountNumber.Text
        obj.Show()
        Me.Close()

    End Sub

End Class