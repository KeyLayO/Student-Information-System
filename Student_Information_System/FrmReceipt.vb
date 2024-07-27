Public Class FrmReceipt

    Public Property Acc As String
    Public Property AccType As String
    Public Property AccAmount As String
    Public Property AccDate As String

    Private Sub FrmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblAccountNumber.Text = Acc
        lblType.Text = AccType
        lblAmount.Text = AccAmount
        lblDate.Text = AccDate

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub tReceipt_Tick(sender As Object, e As EventArgs) Handles tReceipt.Tick

        Me.Left = Me.Left + 20

        If Me.Left >= 1000 Then
            tReceipt.Enabled = False
        End If

    End Sub
End Class