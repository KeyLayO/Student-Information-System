Public Class Metric_System
    Private Sub RbLength_CheckedChanged(sender As Object, e As EventArgs) Handles rbLength.CheckedChanged
        'Length
        txtMiles.Enabled = True
        txtKilometers.Enabled = True
        txtMeters.Enabled = True
        txtCentimeters.Enabled = True
        txtFeet.Enabled = True
        txtYards.Enabled = True

        'Weight
        txtTonne.Enabled = False
        txtKilograms.Enabled = False
        txtGrams.Enabled = False
        txtMiligrams.Enabled = False
        txtPounds.Enabled = False
        txtOunce.Enabled = False

        'Temperature
        txtCelsius.Enabled = False
        txtFahrenheit.Enabled = False
        txtKelvin.Enabled = False

        txtMiles.Text = ""
        txtKilometers.Text = ""
        txtMeters.Text = ""
        txtCentimeters.Text = ""
        txtFeet.Text = ""
        txtYards.Text = ""

        txtTonne.BackColor = SystemColors.Window
        txtKilograms.BackColor = SystemColors.Window
        txtGrams.BackColor = SystemColors.Window
        txtMiligrams.BackColor = SystemColors.Window
        txtPounds.BackColor = SystemColors.Window
        txtOunce.BackColor = SystemColors.Window

        txtCelsius.BackColor = SystemColors.Window
        txtFahrenheit.BackColor = SystemColors.Window
        txtKelvin.BackColor = SystemColors.Window


    End Sub

    Private Sub RbWeight_CheckedChanged(sender As Object, e As EventArgs) Handles rbWeight.CheckedChanged
        'Length
        txtMiles.Enabled = False
        txtKilometers.Enabled = False
        txtMeters.Enabled = False
        txtCentimeters.Enabled = False
        txtFeet.Enabled = False
        txtYards.Enabled = False

        'Weight
        txtTonne.Enabled = True
        txtKilograms.Enabled = True
        txtGrams.Enabled = True
        txtMiligrams.Enabled = True
        txtPounds.Enabled = True
        txtOunce.Enabled = True

        'Temperature
        txtCelsius.Enabled = False
        txtFahrenheit.Enabled = False
        txtKelvin.Enabled = False

        txtTonne.Text = ""
        txtKilograms.Text = ""
        txtGrams.Text = ""
        txtMiligrams.Text = ""
        txtPounds.Text = ""
        txtOunce.Text = ""

        txtMiles.BackColor = SystemColors.Window
        txtKilometers.BackColor = SystemColors.Window
        txtMeters.BackColor = SystemColors.Window
        txtCentimeters.BackColor = SystemColors.Window
        txtFeet.BackColor = SystemColors.Window
        txtYards.BackColor = SystemColors.Window


        txtCelsius.BackColor = SystemColors.Window
        txtFahrenheit.BackColor = SystemColors.Window
        txtKelvin.BackColor = SystemColors.Window


    End Sub

    Private Sub RbTemperature_CheckedChanged(sender As Object, e As EventArgs) Handles rbTemperature.CheckedChanged
        'Length
        txtMiles.Enabled = False
        txtKilometers.Enabled = False
        txtMeters.Enabled = False
        txtCentimeters.Enabled = False
        txtFeet.Enabled = False
        txtYards.Enabled = False

        'Weight
        txtTonne.Enabled = False
        txtKilograms.Enabled = False
        txtGrams.Enabled = False
        txtMiligrams.Enabled = False
        txtPounds.Enabled = False
        txtOunce.Enabled = False

        'Temperature
        txtCelsius.Enabled = True
        txtFahrenheit.Enabled = True
        txtKelvin.Enabled = True

        txtCelsius.Text = ""
        txtFahrenheit.Text = ""
        txtKelvin.Text = ""

        txtMiles.BackColor = SystemColors.Window
        txtKilometers.BackColor = SystemColors.Window
        txtMeters.BackColor = SystemColors.Window
        txtCentimeters.BackColor = SystemColors.Window
        txtFeet.BackColor = SystemColors.Window
        txtYards.BackColor = SystemColors.Window

        txtTonne.BackColor = SystemColors.Window
        txtKilograms.BackColor = SystemColors.Window
        txtGrams.BackColor = SystemColors.Window
        txtMiligrams.BackColor = SystemColors.Window
        txtPounds.BackColor = SystemColors.Window
        txtOunce.BackColor = SystemColors.Window

    End Sub

    Private Sub BtnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        Dim DMiles As Double
        Dim DKilometers As Double
        Dim DMeters As Double
        Dim DCentimeters As Double
        Dim DFeet As Double
        Dim DYards As Double

        Dim DTonne As Double
        Dim DKilograms As Double
        Dim DGrams As Double
        Dim DMiligrams As Double
        Dim DPounds As Double
        Dim DOunce As Double

        Dim DCelsius As Double
        Dim DFahrenheit As Double
        Dim DKelvin As Double

        'Length
        If IsNumeric(txtMiles.Text) = True Then
            DMiles = txtMiles.Text
        ElseIf IsNumeric(txtKilometers.Text) = True Then
            DKilometers = txtKilometers.Text
        ElseIf IsNumeric(txtCentimeters.Text) = True Then
            DCentimeters = txtCentimeters.Text
        ElseIf IsNumeric(txtMeters.Text) = True Then
            DMeters = txtMeters.Text
        ElseIf IsNumeric(txtFeet.Text) = True Then
            DFeet = txtFeet.Text
        ElseIf IsNumeric(txtYards.Text) = True Then
            DYards = txtYards.Text

            'Weight
        ElseIf IsNumeric(txtTonne.Text) = True Then
            DTonne = txtTonne.Text
        ElseIf IsNumeric(txtKilograms.Text) = True Then
            DKilograms = txtKilograms.Text
        ElseIf IsNumeric(txtGrams.Text) = True Then
            DGrams = txtGrams.Text
        ElseIf IsNumeric(txtMiligrams.Text) = True Then
            DMiligrams = txtMiligrams.Text
        ElseIf IsNumeric(txtPounds.Text) = True Then
            DPounds = txtPounds.Text
        ElseIf IsNumeric(txtOunce.Text) = True Then
            DOunce = txtOunce.Text

            'Temperature
        ElseIf IsNumeric(txtCelsius.Text) = True Then
            DCelsius = txtCelsius.Text
        ElseIf IsNumeric(txtFahrenheit.Text) = True Then
            DFahrenheit = txtFahrenheit.Text
        ElseIf IsNumeric(txtKelvin.Text) = True Then
            DKelvin = txtKelvin.Text
        Else
            MsgBox("You can only enter a number", vbCritical, "Error")
            Exit Sub
        End If

        'Length
        If txtMiles.Modified Then
            If txtMiles.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtKilometers.Text = txtMiles.Text * 1.60934
            txtMeters.Text = txtMiles.Text * 1609.34
            txtCentimeters.Text = txtMiles.Text * 160934
            txtFeet.Text = txtMiles.Text * 5280
            txtYards.Text = txtMiles.Text * 1760
            txtMiles.Modified = False
            TClearBlink.Enabled = True

        ElseIf txtKilometers.Modified Then
            If txtKilometers.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtMiles.Text = txtKilometers.Text * 0.621371
            txtMeters.Text = txtKilometers.Text * 1000
            txtCentimeters.Text = txtKilometers.Text * 100000
            txtFeet.Text = txtKilometers.Text * 3280.84
            txtYards.Text = txtKilometers.Text * 1093.61
            txtKilometers.Modified = False
            TClearBlink.Enabled = True

        ElseIf txtMeters.Modified Then
            If txtMeters.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtMiles.Text = txtMeters.Text * 0.000621371
            txtKilometers.Text = txtMeters.Text * 0.001
            txtCentimeters.Text = txtMeters.Text * 100
            txtFeet.Text = txtMeters.Text * 3.28084
            txtYards.Text = txtMeters.Text * 1.09361
            txtMeters.Modified = False
            TClearBlink.Enabled = True

        ElseIf txtCentimeters.Modified Then
            If txtCentimeters.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtMiles.Text = txtCentimeters.Text * 0.0000062137
            txtKilometers.Text = txtCentimeters.Text * 0.00001
            txtMeters.Text = txtCentimeters.Text * 0.01
            txtFeet.Text = txtCentimeters.Text * 0.0328084
            txtYards.Text = txtCentimeters.Text * 0.0109361
            txtCentimeters.Modified = False
            TClearBlink.Enabled = True

        ElseIf txtFeet.Modified Then
            If txtFeet.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtMiles.Text = txtFeet.Text * 0.000189394
            txtKilometers.Text = txtFeet.Text * 0.0003048
            txtMeters.Text = txtFeet.Text * 0.3048
            txtCentimeters.Text = txtFeet.Text * 30.48
            txtYards.Text = txtFeet.Text * 0.333333
            txtFeet.Modified = False
            TClearBlink.Enabled = True

        ElseIf txtYards.Modified Then
            If txtYards.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtMiles.Text = txtYards.Text * 0.000568182
            txtKilometers.Text = txtYards.Text * 0.0009144
            txtMeters.Text = txtYards.Text * 0.9144
            txtCentimeters.Text = txtYards.Text * 91.44
            txtFeet.Text = txtYards.Text * 3
            txtYards.Modified = False
            TClearBlink.Enabled = True

            'Weight
        ElseIf txtTonne.Modified Then
            If txtTonne.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtKilograms.Text = txtTonne.Text * 1000
            txtGrams.Text = txtTonne.Text * 1000000.0
            txtMiligrams.Text = txtTonne.Text * 1000000000.0
            txtPounds.Text = txtTonne.Text * 2204.62
            txtOunce.Text = txtTonne.Text * 35274
            txtTonne.Modified = False
            TClearBlink.Enabled = True

        ElseIf txtKilograms.Modified Then
            If txtKilograms.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtTonne.Text = txtKilograms.Text * 0.001
            txtGrams.Text = txtKilograms.Text * 1000
            txtMiligrams.Text = txtKilograms.Text * 1000000.0
            txtPounds.Text = txtKilograms.Text * 2.20462
            txtOunce.Text = txtKilograms.Text * 35.274
            txtKilograms.Modified = False
            TClearBlink.Enabled = True

        ElseIf txtGrams.Modified Then
            If txtGrams.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtTonne.Text = txtGrams.Text * 0.000001
            txtKilograms.Text = txtGrams.Text * 0.001
            txtMiligrams.Text = txtGrams.Text * 1000
            txtPounds.Text = txtGrams.Text * 0.00220462
            txtOunce.Text = txtGrams.Text * 0.035274
            txtGrams.Modified = False
            TClearBlink.Enabled = True

        ElseIf txtMiligrams.Modified Then
            If txtMiligrams.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtTonne.Text = txtMiligrams.Text * 0.000000001
            txtKilograms.Text = txtMiligrams.Text * 0.000001
            txtGrams.Text = txtMiligrams.Text * 0.001
            txtPounds.Text = txtMiligrams.Text * 0.0000022046
            txtOunce.Text = txtMiligrams.Text * 0.000035274
            txtMiligrams.Modified = False
            TClearBlink.Enabled = True

        ElseIf txtPounds.Modified Then
            If txtPounds.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtTonne.Text = txtPounds.Text * 0.000453592
            txtKilograms.Text = txtPounds.Text * 0.453592
            txtGrams.Text = txtPounds.Text * 453.592
            txtMiligrams.Text = txtPounds.Text * 453592
            txtOunce.Text = txtPounds.Text * 16
            txtPounds.Modified = False
            TClearBlink.Enabled = True

        ElseIf txtOunce.Modified Then
            If txtOunce.Text < 0 Then
                MsgBox("You can't enter a number below 0", vbCritical, "Error")
                Exit Sub
            End If
            txtTonne.Text = txtOunce.Text * 0.00002835
            txtKilograms.Text = txtOunce.Text * 0.0283495
            txtGrams.Text = txtOunce.Text * 28.3495
            txtMiligrams.Text = txtOunce.Text * 28349.5
            txtPounds.Text = txtOunce.Text * 0.0625
            txtOunce.Modified = False
            TClearBlink.Enabled = True

            'Temperature
        ElseIf txtCelsius.Modified Then
            txtFahrenheit.Text = (txtCelsius.Text * 9 / 5) + 32
            txtKelvin.Text = txtCelsius.Text + 273.15
            txtCelsius.Modified = False
            TClearBlink.Enabled = True
        ElseIf txtFahrenheit.Modified Then
            txtCelsius.Text = (txtFahrenheit.Text - 32) * 5 / 9
            txtKelvin.Text = (txtFahrenheit.Text - 32) * 5 / 9 + 273.15
            txtFahrenheit.Modified = False
            TClearBlink.Enabled = True
        ElseIf txtKelvin.Modified Then
            txtCelsius.Text = txtKelvin.Text - 273.15
            txtFahrenheit.Text = (txtKelvin.Text - 273.15) * 9 / 5 + 32
            txtKelvin.Modified = False
            TClearBlink.Enabled = True
        End If

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtMiles.Text = ""
        txtKilometers.Text = ""
        txtMeters.Text = ""
        txtMeters.Text = ""
        txtFeet.Text = ""
        txtYards.Text = ""
        txtCentimeters.Text = ""

        txtKilograms.Text = ""
        txtGrams.Text = ""
        txtMiligrams.Text = ""
        txtPounds.Text = ""
        txtOunce.Text = ""
        txtTonne.Text = ""

        txtCelsius.Text = ""
        txtFahrenheit.Text = ""
        txtKelvin.Text = ""

        TClearBlink.Enabled = False
        btnClear.BackColor = Color.White

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim labas = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo)
        If labas = DialogResult.Yes Then
            Student_Information_System.Show()
            Me.Close()
        End If

    End Sub

    Private Sub TxtMiles_TextChanged(sender As Object, e As EventArgs) Handles txtMiles.TextChanged

        txtKilometers.ReadOnly = True
        txtMeters.ReadOnly = True
        txtCentimeters.ReadOnly = True
        txtFeet.ReadOnly = True
        txtYards.ReadOnly = True

        txtMiles.BackColor = Color.White
        txtKilometers.BackColor = Color.White
        txtMeters.BackColor = Color.White
        txtCentimeters.BackColor = Color.White
        txtFeet.BackColor = Color.White
        txtYards.BackColor = Color.White
        If txtMiles.Text = "" Then
            txtKilometers.ReadOnly = False
            txtMeters.ReadOnly = False
            txtCentimeters.ReadOnly = False
            txtFeet.ReadOnly = False
            txtYards.ReadOnly = False
        End If

    End Sub

    Private Sub TxtKilometers_TextChanged(sender As Object, e As EventArgs) Handles txtKilometers.TextChanged

        txtMiles.ReadOnly = True
        txtMeters.ReadOnly = True
        txtCentimeters.ReadOnly = True
        txtFeet.ReadOnly = True
        txtYards.ReadOnly = True

        txtMiles.BackColor = Color.White
        txtKilometers.BackColor = Color.White
        txtMeters.BackColor = Color.White
        txtCentimeters.BackColor = Color.White
        txtFeet.BackColor = Color.White
        txtYards.BackColor = Color.White
        If txtKilometers.Text = "" Then
            txtMiles.ReadOnly = False
            txtMeters.ReadOnly = False
            txtCentimeters.ReadOnly = False
            txtFeet.ReadOnly = False
            txtYards.ReadOnly = False
        End If

    End Sub

    Private Sub TxtMeters_TextChanged(sender As Object, e As EventArgs) Handles txtMeters.TextChanged

        txtMiles.ReadOnly = True
        txtKilometers.ReadOnly = True
        txtCentimeters.ReadOnly = True
        txtFeet.ReadOnly = True
        txtYards.ReadOnly = True

        txtMiles.BackColor = Color.White
        txtKilometers.BackColor = Color.White
        txtMeters.BackColor = Color.White
        txtCentimeters.BackColor = Color.White
        txtFeet.BackColor = Color.White
        txtYards.BackColor = Color.White
        If txtMeters.Text = "" Then
            txtMiles.ReadOnly = False
            txtKilometers.ReadOnly = False
            txtCentimeters.ReadOnly = False
            txtFeet.ReadOnly = False
            txtYards.ReadOnly = False
        End If

    End Sub

    Private Sub TxtCentimeters_TextChanged(sender As Object, e As EventArgs) Handles txtCentimeters.TextChanged

        txtMiles.ReadOnly = True
        txtKilometers.ReadOnly = True
        txtMeters.ReadOnly = True
        txtFeet.ReadOnly = True
        txtYards.ReadOnly = True

        txtMiles.BackColor = Color.White
        txtKilometers.BackColor = Color.White
        txtMeters.BackColor = Color.White
        txtCentimeters.BackColor = Color.White
        txtFeet.BackColor = Color.White
        txtYards.BackColor = Color.White
        If txtCentimeters.Text = "" Then
            txtMiles.ReadOnly = False
            txtKilometers.ReadOnly = False
            txtMeters.ReadOnly = False
            txtFeet.ReadOnly = False
            txtYards.ReadOnly = False
        End If

    End Sub

    Private Sub TxtFeet_TextChanged(sender As Object, e As EventArgs) Handles txtFeet.TextChanged

        txtMiles.ReadOnly = True
        txtKilometers.ReadOnly = True
        txtMeters.ReadOnly = True
        txtCentimeters.ReadOnly = True
        txtYards.ReadOnly = True

        txtMiles.BackColor = Color.White
        txtKilometers.BackColor = Color.White
        txtMeters.BackColor = Color.White
        txtCentimeters.BackColor = Color.White
        txtFeet.BackColor = Color.White
        txtYards.BackColor = Color.White
        If txtFeet.Text = "" Then
            txtMiles.ReadOnly = False
            txtKilometers.ReadOnly = False
            txtMeters.ReadOnly = False
            txtCentimeters.ReadOnly = False
            txtYards.ReadOnly = False
        End If

    End Sub

    Private Sub TxtYards_TextChanged(sender As Object, e As EventArgs) Handles txtYards.TextChanged

        txtMiles.ReadOnly = True
        txtKilometers.ReadOnly = True
        txtMeters.ReadOnly = True
        txtCentimeters.ReadOnly = True
        txtFeet.ReadOnly = True

        txtMiles.BackColor = Color.White
        txtKilometers.BackColor = Color.White
        txtMeters.BackColor = Color.White
        txtCentimeters.BackColor = Color.White
        txtFeet.BackColor = Color.White
        txtYards.BackColor = Color.White
        If txtYards.Text = "" Then
            txtMiles.ReadOnly = False
            txtKilometers.ReadOnly = False
            txtMeters.ReadOnly = False
            txtCentimeters.ReadOnly = False
            txtFeet.ReadOnly = False
        End If

    End Sub

    Private Sub TxtTonne_TextChanged(sender As Object, e As EventArgs) Handles txtTonne.TextChanged

        txtKilograms.ReadOnly = True
        txtGrams.ReadOnly = True
        txtMiligrams.ReadOnly = True
        txtPounds.ReadOnly = True
        txtOunce.ReadOnly = True

        txtTonne.BackColor = Color.White
        txtKilograms.BackColor = Color.White
        txtGrams.BackColor = Color.White
        txtMiligrams.BackColor = Color.White
        txtPounds.BackColor = Color.White
        txtOunce.BackColor = Color.White
        If txtTonne.Text = "" Then
            txtKilograms.ReadOnly = False
            txtGrams.ReadOnly = False
            txtMiligrams.ReadOnly = False
            txtPounds.ReadOnly = False
            txtOunce.ReadOnly = False
        End If

    End Sub

    Private Sub TxtKilograms_TextChanged(sender As Object, e As EventArgs) Handles txtKilograms.TextChanged

        txtTonne.ReadOnly = True
        txtGrams.ReadOnly = True
        txtMiligrams.ReadOnly = True
        txtPounds.ReadOnly = True
        txtOunce.ReadOnly = True

        txtTonne.BackColor = Color.White
        txtKilograms.BackColor = Color.White
        txtGrams.BackColor = Color.White
        txtMiligrams.BackColor = Color.White
        txtPounds.BackColor = Color.White
        txtOunce.BackColor = Color.White
        If txtKilograms.Text = "" Then
            txtTonne.ReadOnly = False
            txtGrams.ReadOnly = False
            txtMiligrams.ReadOnly = False
            txtPounds.ReadOnly = False
            txtOunce.ReadOnly = False
        End If

    End Sub

    Private Sub TxtGrams_TextChanged(sender As Object, e As EventArgs) Handles txtGrams.TextChanged

        txtTonne.ReadOnly = True
        txtKilograms.ReadOnly = True
        txtMiligrams.ReadOnly = True
        txtPounds.ReadOnly = True
        txtOunce.ReadOnly = True

        txtTonne.BackColor = Color.White
        txtKilograms.BackColor = Color.White
        txtGrams.BackColor = Color.White
        txtMiligrams.BackColor = Color.White
        txtPounds.BackColor = Color.White
        txtOunce.BackColor = Color.White
        If txtGrams.Text = "" Then
            txtTonne.ReadOnly = False
            txtKilograms.ReadOnly = False
            txtMiligrams.ReadOnly = False
            txtPounds.ReadOnly = False
            txtOunce.ReadOnly = False
        End If

    End Sub

    Private Sub TxtMiligrams_TextChanged(sender As Object, e As EventArgs) Handles txtMiligrams.TextChanged

        txtTonne.ReadOnly = True
        txtKilograms.ReadOnly = True
        txtGrams.ReadOnly = True
        txtPounds.ReadOnly = True
        txtOunce.ReadOnly = True

        txtTonne.BackColor = Color.White
        txtKilograms.BackColor = Color.White
        txtGrams.BackColor = Color.White
        txtMiligrams.BackColor = Color.White
        txtPounds.BackColor = Color.White
        txtOunce.BackColor = Color.White
        If txtMiligrams.Text = "" Then
            txtTonne.ReadOnly = False
            txtKilograms.ReadOnly = False
            txtGrams.ReadOnly = False
            txtPounds.ReadOnly = False
            txtOunce.ReadOnly = False
        End If

    End Sub

    Private Sub TxtPounds_TextChanged(sender As Object, e As EventArgs) Handles txtPounds.TextChanged

        txtTonne.ReadOnly = False
        txtKilograms.ReadOnly = False
        txtGrams.ReadOnly = False
        txtMiligrams.ReadOnly = False
        txtOunce.ReadOnly = False

        txtTonne.BackColor = Color.White
        txtKilograms.BackColor = Color.White
        txtGrams.BackColor = Color.White
        txtMiligrams.BackColor = Color.White
        txtPounds.BackColor = Color.White
        txtOunce.BackColor = Color.White
        If txtPounds.Text = "" Then
            txtTonne.ReadOnly = False
            txtKilograms.ReadOnly = False
            txtGrams.ReadOnly = False
            txtMiligrams.ReadOnly = False
            txtOunce.ReadOnly = False
        End If

    End Sub

    Private Sub TxtOunce_TextChanged(sender As Object, e As EventArgs) Handles txtOunce.TextChanged

        txtTonne.ReadOnly = True
        txtKilograms.ReadOnly = True
        txtGrams.ReadOnly = True
        txtMiligrams.ReadOnly = True
        txtPounds.ReadOnly = True

        txtTonne.BackColor = Color.White
        txtKilograms.BackColor = Color.White
        txtGrams.BackColor = Color.White
        txtMiligrams.BackColor = Color.White
        txtPounds.BackColor = Color.White
        txtOunce.BackColor = Color.White
        If txtOunce.Text = "" Then
            txtTonne.ReadOnly = False
            txtKilograms.ReadOnly = False
            txtGrams.ReadOnly = False
            txtMiligrams.ReadOnly = False
            txtPounds.ReadOnly = False
        End If

    End Sub

    Private Sub TxtCelsius_TextChanged(sender As Object, e As EventArgs) Handles txtCelsius.TextChanged

        txtFahrenheit.ReadOnly = True
        txtKelvin.ReadOnly = True

        txtCelsius.BackColor = Color.White
        txtFahrenheit.BackColor = Color.White
        txtKelvin.BackColor = Color.White
        If txtCelsius.Text = "" Then
            txtFahrenheit.ReadOnly = False
            txtKelvin.ReadOnly = False
        End If

    End Sub

    Private Sub TxtFahrenheit_TextChanged(sender As Object, e As EventArgs) Handles txtFahrenheit.TextChanged

        txtCelsius.ReadOnly = True
        txtKelvin.ReadOnly = True

        txtCelsius.BackColor = Color.White
        txtFahrenheit.BackColor = Color.White
        txtKelvin.BackColor = Color.White
        If txtFahrenheit.Text = "" Then
            txtCelsius.ReadOnly = False
            txtKelvin.ReadOnly = False
        End If

    End Sub

    Private Sub TxtKelvin_TextChanged(sender As Object, e As EventArgs) Handles txtKelvin.TextChanged

        txtCelsius.ReadOnly = True
        txtFahrenheit.ReadOnly = True

        txtCelsius.BackColor = Color.White
        txtFahrenheit.BackColor = Color.White
        txtKelvin.BackColor = Color.White
        If txtKelvin.Text = "" Then
            txtCelsius.ReadOnly = False
            txtFahrenheit.ReadOnly = False
        End If

    End Sub

    Private Sub TClearBlink_Tick(sender As Object, e As EventArgs) Handles TClearBlink.Tick

        If btnClear.BackColor = Color.White Then
            btnClear.BackColor = Color.Yellow
        Else
            btnClear.BackColor = Color.White
        End If

    End Sub
End Class