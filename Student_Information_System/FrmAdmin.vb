Imports System.Data.SqlClient
Public Class FrmAdmin
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30")

    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim sql As String
    Dim cmd As New SqlCommand
    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click

        Dim obj As New FrmPIN
        obj.Show()
        Me.Close()

    End Sub
    Private Sub btnLoadRecord_Click(sender As Object, e As EventArgs) Handles btnLoadRecord.Click

        Try
            Dim sql As String
            Dim cmd As New SqlCommand
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            con.Open()
            sql = "select * from TblAccount"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click

        If txtAccNum.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtPIN.Text = "" Or txtBalance.Text = "" Then
            MsgBox("Missing Information", vbCritical, "Error")
        Else
            Try
                Dim sql, i As String
                Dim cmd As New SqlCommand
                con.Open()
                sql = "insert into TblAccount (AccNum, Fname, Lname, PIN, Balance) values ('" & txtAccNum.Text & "','" & txtFname.Text & "','" & txtLname.Text & "','" & txtPIN.Text & "','" & txtBalance.Text & "');"
                cmd.Connection = con
                cmd.CommandText = sql
                i = cmd.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("New record inserted", vbInformation, "Success")
                Else
                    MsgBox("No record inserted", vbInformation, "Error")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
            txtAccNum.Text = ""
            txtPIN.Text = ""
            txtFname.Text = ""
            txtLname.Text = ""
            txtBalance.Text = ""
        End If
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click

        Try
            Dim sql, i As String
            Dim cmd As New SqlCommand
            con.Open()
            sql = "update TblAccount set AccNum='" & txtAccNum.Text & "', Fname='" & txtFname.Text & "', Lname='" & txtLname.Text & "', PIN='" & txtPIN.Text & "', Balance='" & txtBalance.Text & "'"
            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("New record inserted", vbInformation, "Success")
            Else
                MsgBox("No record inserted", vbInformation, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        txtAccNum.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtFname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtLname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtPIN.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtBalance.Text = DataGridView1.CurrentRow.Cells(4).Value

    End Sub
    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click

        Dim sql, i As String
        Dim cmd As New SqlCommand
        Try
            con.Open()
            sql = "Delete * from TblAccount where AccNum = " & Text & ""
            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record deleted successfully", vbInformation, "Success")
            Else
                MsgBox("No record deleted", vbCritical, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

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
        txtBalance.Text = ""
        txtFnameSearch.Text = ""
        txtLnameSearch.Text = ""

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        sql = "SELECT * FROM TblAccount where Fname='" & txtFnameSearch.Text & "'" & "and Lname= '" & txtLnameSearch.Text & "'"
        Try
            con.Open()
            da = New SqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con.Close()
        txtFnameSearch.Text = ""
        txtLnameSearch.Text = ""

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
    Private Sub txtAccNum_Enter(sender As Object, e As EventArgs) Handles txtAccNum.Enter

        txtBuffer.Text = "txtAccNum"
        txtAccNum.Focus()
        If txtAccNum.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
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
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
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
    Private Sub txtBalance_Enter(sender As Object, e As EventArgs) Handles txtBalance.Enter

        txtBuffer.Text = "txtBalance"
        txtBalance.Focus()

        If txtBalance.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
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
    Private Sub txtFnameSearch_Enter(sender As Object, e As EventArgs) Handles txtFnameSearch.Enter

        txtBuffer.Text = "txtFnameSearch"
        txtFnameSearch.Focus()

        If txtFnameSearch.Text = "" Then
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

    Private Sub txtLnameSearch_Enter(sender As Object, e As EventArgs) Handles txtLnameSearch.Enter

        txtBuffer.Text = "txtLnameSearch"
        txtLnameSearch.Focus()

        If txtLnameSearch.Text = "" Then
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

    Private Sub txtAccNum_TextChanged(sender As Object, e As EventArgs) Handles txtAccNum.TextChanged

        If txtAccNum.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
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
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub
    Private Sub txtBalance_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged

        If txtBalance.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub
    Private Sub txtFnameSearch_TextChanged(sender As Object, e As EventArgs) Handles txtFnameSearch.TextChanged

        If txtFnameSearch.Text = "" Then
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

    Private Sub txtLnameSearch_TextChanged(sender As Object, e As EventArgs) Handles txtLnameSearch.TextChanged

        If txtLnameSearch.Text = "" Then
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

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = Date.Now.ToString("MMM dd yyyy hh:mm:ss")

        txtAccNum.BackColor = Color.White
        txtFname.BackColor = Color.White
        txtLname.BackColor = Color.White
        txtPIN.BackColor = Color.White
        txtBalance.BackColor = Color.White
        txtFnameSearch.BackColor = Color.White
        txtLnameSearch.BackColor = Color.White

    End Sub
End Class
