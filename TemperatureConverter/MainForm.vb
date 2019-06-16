'Rogel SJ Corral
'14 June 2019

Public Class MainForm

    ''' <summary>
    ''' Variables Declaration
    ''' </summary>
    Dim inputTemp As Double = 0.0
    Dim convertedTemp As Double = 0.0

    ''' <summary>
    ''' Sub for the Exit button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Sub when the Fahrenheit to Celsius radio button is checked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub radFahrenheitToCelsius_CheckedChanged(sender As Object, e As EventArgs) Handles radFahrenheitToCelsius.CheckedChanged
        lbInputUnit.Text = "°F"
        lbConvertedUnit.Text = "°C"
    End Sub

    ''' <summary>
    ''' Sub when the Celsius to Fahrenheit radio button is checked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub radCelsiusToFahrenheit_CheckedChanged(sender As Object, e As EventArgs) Handles radCelsiusToFahrenheit.CheckedChanged
        lbInputUnit.Text = "°C"
        lbConvertedUnit.Text = "°F"
    End Sub

    ''' <summary>
    ''' Sub for the Convert button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        If tbInput.Text = "" Then
            MessageBox.Show("Please input a value", "",
                                MessageBoxButtons.OK)
            UnitsInputSelect()
        ElseIf Double.TryParse(tbInput.Text, inputTemp) Then
            If radFahrenheitToCelsius.Checked() = True Then
                If inputTemp < -459.67 Then
                    MessageBox.Show("Sorry, but you cannot go lower than absolute zero temperature! Please try again.", "",
                                MessageBoxButtons.OK)
                    UnitsInputSelect()
                Else
                    convertedTemp = (5 / 9) * (inputTemp - 32)
                    ConvertedTempOutput()
                End If
            ElseIf radCelsiusToFahrenheit.Checked() = True Then
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

    ''' <summary>
    ''' Sub to select the contents of the input text box when an invalid or
    ''' blank entry is detected
    ''' </summary>
    Private Sub UnitsInputSelect()
        tbInput.Select()
        tbInput.SelectionStart = 0
        tbInput.SelectionLength = tbInput.Text.Length
    End Sub

    ''' <summary>
    ''' Sub for the output (displaying the result)
    ''' </summary>
    Private Sub ConvertedTempOutput()
        tbConvert.Text = convertedTemp.ToString("N")
        tbInput.Enabled = False
        btnConvert.Enabled = False
        btnReset.Select()
    End Sub

    ''' <summary>
    ''' Sub for the Reset button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        radFahrenheitToCelsius.Checked() = True
        tbInput.Enabled = True
        tbInput.Clear()
        tbConvert.Clear()
        tbInput.Select()
        btnConvert.Enabled = True

        inputTemp = 0
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radFahrenheitToCelsius.Checked() = True
        tbInput.Select()
    End Sub
End Class
