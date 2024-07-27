Imports System.Data.SqlClient
Public Class FrmBalance
    Public Property Acc As String
    Dim Account As Integer
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FrmBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = Date.Now.ToString("MMM dd yyyy hh:mm:ss")

        Account = Convert.ToInt32(Acc)
        lblAccountNumber.Text = Acc
        GetBalance()

    End Sub

    Private Sub GetBalance()
        con.open
        Dim cmd As SqlCommand
        Dim query = "select Balance from TblAccount where AccNum=" & Account & ""
        cmd = New SqlCommand(query, con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt = New DataTable
        sda.Fill(dt)
        lblBalance.Text = Convert.ToInt32(dt.Rows(0)(0).ToString())
        con.close
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