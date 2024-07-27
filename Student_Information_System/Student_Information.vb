Public Class Student_Information
    Private Sub Student_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtStudentNumber.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtAge.Enabled = False
        cbGender.Enabled = False
        cbCourse.Enabled = False
        cbYearLevel.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        btnExit.Text = "CANCEL"
        btnExit.BackColor = Color.Transparent
        btnExit.ForeColor = Color.Black
        txtStudentNumber.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtAge.Enabled = True
        cbGender.Enabled = True
        cbCourse.Enabled = True
        cbYearLevel.Enabled = True
        btnEdit.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If btnExit.Text = "CANCEL" Then
            btnExit.Text = "EXIT"
            btnExit.BackColor = Color.Red
            btnExit.ForeColor = Color.White
            txtStudentNumber.Enabled = False
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            txtAge.Enabled = False
            cbGender.Enabled = False
            cbCourse.Enabled = False
            cbYearLevel.Enabled = False
            btnEdit.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = False
            txtStudentNumber.Text = ""
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtAge.Text = ""
            cbGender.Text = ""
            cbCourse.Text = ""
            cbYearLevel.Text = ""
        Else
            Dim labas = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo)
            If labas = DialogResult.Yes Then
                Student_Information_System.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        txtStudentNumber.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAge.Text = ""
        cbGender.Text = ""
        cbCourse.Text = ""
        cbYearLevel.Text = ""

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtStudentNumber.Text = "" Then
            MsgBox("You must enter your Student Number", vbCritical, "Error")
        ElseIf txtFirstName.Text = "" Then
            MsgBox("You must enter your First Name", vbCritical, "Error")
        ElseIf txtLastName.Text = "" Then
            MsgBox("You must enter your Last Name", vbCritical, "Error")
        ElseIf txtAge.Text = "" Then
            MsgBox("You must enter your Age", vbCritical, "Error")
        ElseIf cbGender.Text = "" Then
            MsgBox("You must enter your Gender", vbCritical, "Error")
        ElseIf cbCourse.Text = "" Then
            MsgBox("You must enter your Course", vbCritical, "Error")
        ElseIf cbYearLevel.Text = "" Then
            MsgBox("You must enter your Year Level", vbCritical, "Error")

        Else
            Dim Filename As String = "E:\Kurt\Student_Information.txt"
            If System.IO.File.Exists(Filename) = True Then
                Dim objectwriter As New System.IO.StreamWriter(Filename, True)
                objectwriter.WriteLine("Student Number : " & txtStudentNumber.Text)
                objectwriter.WriteLine("First Name : " & txtFirstName.Text)
                objectwriter.WriteLine("Last Name : " & txtLastName.Text)
                objectwriter.WriteLine("Age : " & txtAge.Text)
                objectwriter.WriteLine("Gender : " & cbGender.Text)
                objectwriter.WriteLine("Course : " & cbCourse.Text)
                objectwriter.WriteLine("Year Level : " & cbYearLevel.Text)
                objectwriter.WriteLine("")
                objectwriter.Close()
                MessageBox.Show(txtLastName.Text & " " & txtFirstName.Text & " is already saved!")
            Else
                MessageBox.Show("File does not exist!")
            End If
        End If

    End Sub
End Class