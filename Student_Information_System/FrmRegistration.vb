Imports System.Data.SqlClient
Public Class FrmRegistration
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Reset()
        txtAccNum.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        txtPIN.Text = ""
    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If txtAccNum.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtPIN.Text = "" Then
            MsgBox("Missing Information", vbCritical, "Error")
        Else
            Try
                Dim bal = 0
                con.Open()
                Dim query = "insert into TblAccount values(" & txtAccNum.Text & ",'" & txtFname.Text & "','" & txtLname.Text & "','" & txtPIN.Text & "','" & bal & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Account Added", vbInformation, "Success")
                con.close()
                FrmPIN.Show()
                Me.Close()
            Catch
                MsgBox("The Account Number is already taken", vbCritical, "Error")
                con.Close()
            End Try

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) 

        FrmPIN.Show()
        Me.Close()

    End Sub

    Private Sub FrmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("MMM dd yyyy hh:mm:ss")

        txtAccNum.BackColor = Color.White
        txtFname.BackColor = Color.White
        txtLname.BackColor = Color.White
        txtPIN.BackColor = Color.White

    End Sub
    Private Sub txtAccNum_Enter(sender As Object, e As EventArgs) Handles txtAccNum.Enter

        txtBuffer.Text = "txtAccNum"
        txtAccNum.Focus()
        If txtAccNum.Text = "" Then
            BtnDelete.Enabled = False
        Else
            BtnDelete.Enabled = True
        End If

        Btn1.Enabled = True
        Btn2.Enabled = True
        Btn3.Enabled = True
        Btn4.Enabled = True
        Btn5.Enabled = True
        Btn6.Enabled = True
        Btn7.Enabled = True
        Btn8.Enabled = True
        Btn9.Enabled = True
        Btn0.Enabled = True

        BtnQ.Enabled = False
        BtnW.Enabled = False
        BtnE.Enabled = False
        BtnR.Enabled = False
        BtnT.Enabled = False
        BtnY.Enabled = False
        BtnU.Enabled = False
        BtnI.Enabled = False
        BtnO.Enabled = False
        BtnP.Enabled = False
        BtnA.Enabled = False
        BtnS.Enabled = False
        BtnD.Enabled = False
        BtnF.Enabled = False
        BtnG.Enabled = False
        BtnH.Enabled = False
        BtnJ.Enabled = False
        BtnK.Enabled = False
        BtnL.Enabled = False
        BtnZ.Enabled = False
        BtnX.Enabled = False
        BtnC.Enabled = False
        BtnV.Enabled = False
        BtnB.Enabled = False
        BtnN.Enabled = False
        BtnM.Enabled = False
        btnSpace.Enabled = False
        btnShift.Enabled = False

    End Sub

    Private Sub txtFname_Enter(sender As Object, e As EventArgs) Handles txtFname.Enter

        txtBuffer.Text = "txtFname"
        txtFname.Focus()

        If txtFname.Text = "" Then
            BtnQ.Text = "Q"
            BtnW.Text = "W"
            BtnE.Text = "E"
            BtnR.Text = "R"
            BtnT.Text = "T"
            BtnY.Text = "Y"
            BtnU.Text = "U"
            BtnI.Text = "I"
            BtnO.Text = "O"
            BtnP.Text = "P"
            BtnA.Text = "A"
            BtnS.Text = "S"
            BtnD.Text = "D"
            BtnF.Text = "F"
            BtnG.Text = "G"
            BtnH.Text = "H"
            BtnJ.Text = "J"
            BtnK.Text = "K"
            BtnL.Text = "L"
            BtnZ.Text = "Z"
            BtnX.Text = "X"
            BtnC.Text = "C"
            BtnV.Text = "V"
            BtnB.Text = "B"
            BtnN.Text = "N"
            BtnM.Text = "M"
            btnShift.Text = "SHIFT"
            BtnDelete.Enabled = False
        Else
            BtnQ.Text = "q"
            BtnW.Text = "w"
            BtnE.Text = "e"
            BtnR.Text = "r"
            BtnT.Text = "t"
            BtnY.Text = "y"
            BtnU.Text = "u"
            BtnI.Text = "i"
            BtnO.Text = "o"
            BtnP.Text = "p"
            BtnA.Text = "a"
            BtnS.Text = "s"
            BtnD.Text = "d"
            BtnF.Text = "f"
            BtnG.Text = "g"
            BtnH.Text = "h"
            BtnJ.Text = "j"
            BtnK.Text = "k"
            BtnL.Text = "l"
            BtnZ.Text = "z"
            BtnX.Text = "x"
            BtnC.Text = "c"
            BtnV.Text = "v"
            BtnB.Text = "b"
            BtnN.Text = "n"
            BtnM.Text = "m"
            btnShift.Text = "shift"
            BtnDelete.Enabled = True
        End If

        Btn1.Enabled = False
        Btn2.Enabled = False
        Btn3.Enabled = False
        Btn4.Enabled = False
        Btn5.Enabled = False
        Btn6.Enabled = False
        Btn7.Enabled = False
        Btn8.Enabled = False
        Btn9.Enabled = False
        Btn0.Enabled = False

        BtnQ.Enabled = True
        BtnW.Enabled = True
        BtnE.Enabled = True
        BtnR.Enabled = True
        BtnT.Enabled = True
        BtnY.Enabled = True
        BtnU.Enabled = True
        BtnI.Enabled = True
        BtnO.Enabled = True
        BtnP.Enabled = True
        BtnA.Enabled = True
        BtnS.Enabled = True
        BtnD.Enabled = True
        BtnF.Enabled = True
        BtnG.Enabled = True
        BtnH.Enabled = True
        BtnJ.Enabled = True
        BtnK.Enabled = True
        BtnL.Enabled = True
        BtnZ.Enabled = True
        BtnX.Enabled = True
        BtnC.Enabled = True
        BtnV.Enabled = True
        BtnB.Enabled = True
        BtnN.Enabled = True
        BtnM.Enabled = True
        btnSpace.Enabled = True
        btnShift.Enabled = True

    End Sub

    Private Sub txtLname_Enter(sender As Object, e As EventArgs) Handles txtLname.Enter

        txtBuffer.Text = "txtLname"
        txtLname.Focus()

        If txtLname.Text = "" Then
            BtnQ.Text = "Q"
            BtnW.Text = "W"
            BtnE.Text = "E"
            BtnR.Text = "R"
            BtnT.Text = "T"
            BtnY.Text = "Y"
            BtnU.Text = "U"
            BtnI.Text = "I"
            BtnO.Text = "O"
            BtnP.Text = "P"
            BtnA.Text = "A"
            BtnS.Text = "S"
            BtnD.Text = "D"
            BtnF.Text = "F"
            BtnG.Text = "G"
            BtnH.Text = "H"
            BtnJ.Text = "J"
            BtnK.Text = "K"
            BtnL.Text = "L"
            BtnZ.Text = "Z"
            BtnX.Text = "X"
            BtnC.Text = "C"
            BtnV.Text = "V"
            BtnB.Text = "B"
            BtnN.Text = "N"
            BtnM.Text = "M"
            btnShift.Text = "SHIFT"
            BtnDelete.Enabled = False
        Else
            BtnQ.Text = "q"
            BtnW.Text = "w"
            BtnE.Text = "e"
            BtnR.Text = "r"
            BtnT.Text = "t"
            BtnY.Text = "y"
            BtnU.Text = "u"
            BtnI.Text = "i"
            BtnO.Text = "o"
            BtnP.Text = "p"
            BtnA.Text = "a"
            BtnS.Text = "s"
            BtnD.Text = "d"
            BtnF.Text = "f"
            BtnG.Text = "g"
            BtnH.Text = "h"
            BtnJ.Text = "j"
            BtnK.Text = "k"
            BtnL.Text = "l"
            BtnZ.Text = "z"
            BtnX.Text = "x"
            BtnC.Text = "c"
            BtnV.Text = "v"
            BtnB.Text = "b"
            BtnN.Text = "n"
            BtnM.Text = "m"
            btnShift.Text = "shift"
            BtnDelete.Enabled = True
        End If

        Btn1.Enabled = False
        Btn2.Enabled = False
        Btn3.Enabled = False
        Btn4.Enabled = False
        Btn5.Enabled = False
        Btn6.Enabled = False
        Btn7.Enabled = False
        Btn8.Enabled = False
        Btn9.Enabled = False
        Btn0.Enabled = False

        BtnQ.Enabled = True
        BtnW.Enabled = True
        BtnE.Enabled = True
        BtnR.Enabled = True
        BtnT.Enabled = True
        BtnY.Enabled = True
        BtnU.Enabled = True
        BtnI.Enabled = True
        BtnO.Enabled = True
        BtnP.Enabled = True
        BtnA.Enabled = True
        BtnS.Enabled = True
        BtnD.Enabled = True
        BtnF.Enabled = True
        BtnG.Enabled = True
        BtnH.Enabled = True
        BtnJ.Enabled = True
        BtnK.Enabled = True
        BtnL.Enabled = True
        BtnZ.Enabled = True
        BtnX.Enabled = True
        BtnC.Enabled = True
        BtnV.Enabled = True
        BtnB.Enabled = True
        BtnN.Enabled = True
        BtnM.Enabled = True
        btnSpace.Enabled = True
        btnShift.Enabled = True

    End Sub

    Private Sub txtPIN_Enter(sender As Object, e As EventArgs) Handles txtPIN.Enter

        txtBuffer.Text = "txtPIN"
        txtPIN.Focus()

        If txtPIN.Text = "" Then
            BtnDelete.Enabled = False
        Else
            BtnDelete.Enabled = True
        End If

        Btn1.Enabled = True
        Btn2.Enabled = True
        Btn3.Enabled = True
        Btn4.Enabled = True
        Btn5.Enabled = True
        Btn6.Enabled = True
        Btn7.Enabled = True
        Btn8.Enabled = True
        Btn9.Enabled = True
        Btn0.Enabled = True

        BtnQ.Enabled = False
        BtnW.Enabled = False
        BtnE.Enabled = False
        BtnR.Enabled = False
        BtnT.Enabled = False
        BtnY.Enabled = False
        BtnU.Enabled = False
        BtnI.Enabled = False
        BtnO.Enabled = False
        BtnP.Enabled = False
        BtnA.Enabled = False
        BtnS.Enabled = False
        BtnD.Enabled = False
        BtnF.Enabled = False
        BtnG.Enabled = False
        BtnH.Enabled = False
        BtnJ.Enabled = False
        BtnK.Enabled = False
        BtnL.Enabled = False
        BtnZ.Enabled = False
        BtnX.Enabled = False
        BtnC.Enabled = False
        BtnV.Enabled = False
        BtnB.Enabled = False
        BtnN.Enabled = False
        BtnM.Enabled = False
        btnSpace.Enabled = False
        btnShift.Enabled = False

    End Sub
    Private Sub txtAccNum_TextChanged(sender As Object, e As EventArgs) Handles txtAccNum.TextChanged

        If txtAccNum.Text = "" Then
            BtnDelete.Enabled = False
        Else
            BtnDelete.Enabled = True
        End If

    End Sub

    Private Sub txtFname_TextChanged(sender As Object, e As EventArgs) Handles txtFname.TextChanged

        If txtFname.Text = "" Then
            BtnQ.Text = "Q"
            BtnW.Text = "W"
            BtnE.Text = "E"
            BtnR.Text = "R"
            BtnT.Text = "T"
            BtnY.Text = "Y"
            BtnU.Text = "U"
            BtnI.Text = "I"
            BtnO.Text = "O"
            BtnP.Text = "P"
            BtnA.Text = "A"
            BtnS.Text = "S"
            BtnD.Text = "D"
            BtnF.Text = "F"
            BtnG.Text = "G"
            BtnH.Text = "H"
            BtnJ.Text = "J"
            BtnK.Text = "K"
            BtnL.Text = "L"
            BtnZ.Text = "Z"
            BtnX.Text = "X"
            BtnC.Text = "C"
            BtnV.Text = "V"
            BtnB.Text = "B"
            BtnN.Text = "N"
            BtnM.Text = "M"
            btnShift.Text = "SHIFT"
            BtnDelete.Enabled = False
        Else
            BtnQ.Text = "q"
            BtnW.Text = "w"
            BtnE.Text = "e"
            BtnR.Text = "r"
            BtnT.Text = "t"
            BtnY.Text = "y"
            BtnU.Text = "u"
            BtnI.Text = "i"
            BtnO.Text = "o"
            BtnP.Text = "p"
            BtnA.Text = "a"
            BtnS.Text = "s"
            BtnD.Text = "d"
            BtnF.Text = "f"
            BtnG.Text = "g"
            BtnH.Text = "h"
            BtnJ.Text = "j"
            BtnK.Text = "k"
            BtnL.Text = "l"
            BtnZ.Text = "z"
            BtnX.Text = "x"
            BtnC.Text = "c"
            BtnV.Text = "v"
            BtnB.Text = "b"
            BtnN.Text = "n"
            BtnM.Text = "m"
            btnShift.Text = "shift"
            BtnDelete.Enabled = True
        End If

    End Sub

    Private Sub txtLname_TextChanged(sender As Object, e As EventArgs) Handles txtLname.TextChanged

        If txtLname.Text = "" Then
            BtnQ.Text = "Q"
            BtnW.Text = "W"
            BtnE.Text = "E"
            BtnR.Text = "R"
            BtnT.Text = "T"
            BtnY.Text = "Y"
            BtnU.Text = "U"
            BtnI.Text = "I"
            BtnO.Text = "O"
            BtnP.Text = "P"
            BtnA.Text = "A"
            BtnS.Text = "S"
            BtnD.Text = "D"
            BtnF.Text = "F"
            BtnG.Text = "G"
            BtnH.Text = "H"
            BtnJ.Text = "J"
            BtnK.Text = "K"
            BtnL.Text = "L"
            BtnZ.Text = "Z"
            BtnX.Text = "X"
            BtnC.Text = "C"
            BtnV.Text = "V"
            BtnB.Text = "B"
            BtnN.Text = "N"
            BtnM.Text = "M"
            btnShift.Text = "SHIFT"
            BtnDelete.Enabled = False
        Else
            BtnQ.Text = "q"
            BtnW.Text = "w"
            BtnE.Text = "e"
            BtnR.Text = "r"
            BtnT.Text = "t"
            BtnY.Text = "y"
            BtnU.Text = "u"
            BtnI.Text = "i"
            BtnO.Text = "o"
            BtnP.Text = "p"
            BtnA.Text = "a"
            BtnS.Text = "s"
            BtnD.Text = "d"
            BtnF.Text = "f"
            BtnG.Text = "g"
            BtnH.Text = "h"
            BtnJ.Text = "j"
            BtnK.Text = "k"
            BtnL.Text = "l"
            BtnZ.Text = "z"
            BtnX.Text = "x"
            BtnC.Text = "c"
            BtnV.Text = "v"
            BtnB.Text = "b"
            BtnN.Text = "n"
            BtnM.Text = "m"
            btnShift.Text = "shift"
            BtnDelete.Enabled = True
        End If

    End Sub

    Private Sub txtPIN_TextChanged(sender As Object, e As EventArgs) Handles txtPIN.TextChanged

        If txtPIN.Text = "" Then
            BtnDelete.Enabled = False
        Else
            BtnDelete.Enabled = True
        End If

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click, Btn0.Click, BtnQ.Click, BtnW.Click, BtnE.Click, BtnR.Click, BtnT.Click, BtnY.Click, BtnU.Click, BtnI.Click, BtnO.Click, BtnP.Click, BtnA.Click, BtnS.Click, BtnD.Click, BtnF.Click, BtnG.Click, BtnH.Click, BtnJ.Click, BtnK.Click, BtnL.Click, BtnZ.Click, BtnX.Click, BtnC.Click, BtnV.Click, BtnB.Click, BtnN.Click, BtnM.Click, btnSpace.Click

        Dim tb As String = txtBuffer.Text
        CType(Controls(tb), TextBox).Text = CType(Controls(tb), TextBox).Text & Me.ActiveControl.Text

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Dim tb As String = txtBuffer.Text
        CType(Controls(tb), TextBox).Focus()
        CType(Controls(tb), TextBox).Text = CType(Controls(tb), TextBox).Text.Substring(0, CType(Controls(tb), TextBox).Text.Length - 1)

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        txtAccNum.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        txtPIN.Text = ""

    End Sub
    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShift.Click

        If btnShift.Text = "SHIFT" Then
            BtnQ.Text = "q"
            BtnW.Text = "w"
            BtnE.Text = "e"
            BtnR.Text = "r"
            BtnT.Text = "t"
            BtnY.Text = "y"
            BtnU.Text = "u"
            BtnI.Text = "i"
            BtnO.Text = "o"
            BtnP.Text = "p"
            BtnA.Text = "a"
            BtnS.Text = "s"
            BtnD.Text = "d"
            BtnF.Text = "f"
            BtnG.Text = "g"
            BtnH.Text = "h"
            BtnJ.Text = "j"
            BtnK.Text = "k"
            BtnL.Text = "l"
            BtnZ.Text = "z"
            BtnX.Text = "x"
            BtnC.Text = "c"
            BtnV.Text = "v"
            BtnB.Text = "b"
            BtnN.Text = "n"
            BtnM.Text = "m"
            btnShift.Text = "shift"
        ElseIf btnShift.Text = "shift" Then
            BtnQ.Text = "Q"
            BtnW.Text = "W"
            BtnE.Text = "E"
            BtnR.Text = "R"
            BtnT.Text = "T"
            BtnY.Text = "Y"
            BtnU.Text = "U"
            BtnI.Text = "I"
            BtnO.Text = "O"
            BtnP.Text = "P"
            BtnA.Text = "A"
            BtnS.Text = "S"
            BtnD.Text = "D"
            BtnF.Text = "F"
            BtnG.Text = "G"
            BtnH.Text = "H"
            BtnJ.Text = "J"
            BtnK.Text = "K"
            BtnL.Text = "L"
            BtnZ.Text = "Z"
            BtnX.Text = "X"
            BtnC.Text = "C"
            BtnV.Text = "V"
            BtnB.Text = "B"
            BtnN.Text = "N"
            BtnM.Text = "M"
            btnShift.Text = "SHIFT"
        End If

    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click

        MsgBox("Thank You", vbInformation, "Bye")
        Dim obj As New FrmPIN
        obj.Show()
        Me.Close()

    End Sub

End Class