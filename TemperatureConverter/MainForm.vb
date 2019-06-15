'Rogel SJ Corral
'14 June 2019

Public Class MainForm

    Dim inputTemp As Double = 0.0
    Dim convertedTemp As Double = 0.0

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub radFahrenheitToCelsius_CheckedChanged(sender As Object, e As EventArgs) Handles radFahrenheitToCelsius.CheckedChanged
        lbInputUnit.Text = "°F"
        lbConvertedUnit.Text = "°C"
    End Sub

    Private Sub radCelsiusToFahrenheit_CheckedChanged(sender As Object, e As EventArgs) Handles radCelsiusToFahrenheit.CheckedChanged
        lbInputUnit.Text = "°C"
        lbConvertedUnit.Text = "°F"
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        If tbInput.Text = "" Then
            MessageBox.Show("Please input a value", "",
                                MessageBoxButtons.OK)
            UnitsInputSelect()
        ElseIf Double.TryParse(tbInput.Text, inputTemp) Then
            If radFahrenheitToCelsius.Focus() = True Then
                If inputTemp < -459.67 Then
                    MessageBox.Show("Sorry, but you cannot go lower than absolute zero temperature! Please try again.", "",
                                MessageBoxButtons.OK)
                    UnitsInputSelect()
                Else
                    convertedTemp = (5 / 9) * (inputTemp - 32)
                    ConvertedTempOutput()
                End If
            Else
                If inputTemp < -273.15 Then
                    MessageBox.Show("Sorry, but you cannot go lower than absolute zero temperature! Please try again.", "",
                                MessageBoxButtons.OK)
                    UnitsInputSelect()
                Else
                    convertedTemp = (9 / 5 * inputTemp) + 32
                    ConvertedTempOutput()
                End If
            End If
        Else
            MessageBox.Show("Please enter numeric values only.", "",
                                MessageBoxButtons.OK)
            UnitsInputSelect()
        End If

    End Sub

    Private Sub UnitsInputSelect()
        tbInput.Select()
        tbInput.SelectionStart = 0
        tbInput.SelectionLength = tbInput.Text.Length
    End Sub

    Private Sub ConvertedTempOutput()
        tbConvert.Text = convertedTemp.ToString("N")
        tbInput.Enabled = False
        btnConvert.Enabled = False
        btnReset.Select()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        radFahrenheitToCelsius.Select()
        tbInput.Enabled = True
        tbInput.Clear()
        tbConvert.Clear()
        tbInput.Select()
        btnConvert.Enabled = True

        inputTemp = 0
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'radFahrenheitToCelsius.Select()
        tbInput.Select()
    End Sub
End Class
