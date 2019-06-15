<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbHeader = New System.Windows.Forms.Label()
        Me.radFahrenheitToCelsius = New System.Windows.Forms.RadioButton()
        Me.radCelsiusToFahrenheit = New System.Windows.Forms.RadioButton()
        Me.lbInput = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.tbConvert = New System.Windows.Forms.TextBox()
        Me.lbConvert = New System.Windows.Forms.Label()
        Me.lbInputUnit = New System.Windows.Forms.Label()
        Me.lbConvertedUnit = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbHeader
        '
        Me.lbHeader.AutoSize = True
        Me.lbHeader.Location = New System.Drawing.Point(12, 9)
        Me.lbHeader.Name = "lbHeader"
        Me.lbHeader.Size = New System.Drawing.Size(70, 13)
        Me.lbHeader.TabIndex = 0
        Me.lbHeader.Text = "Convert from:"
        '
        'radFahrenheitToCelsius
        '
        Me.radFahrenheitToCelsius.AutoSize = True
        Me.radFahrenheitToCelsius.Checked = True
        Me.radFahrenheitToCelsius.Location = New System.Drawing.Point(15, 33)
        Me.radFahrenheitToCelsius.Name = "radFahrenheitToCelsius"
        Me.radFahrenheitToCelsius.Size = New System.Drawing.Size(123, 17)
        Me.radFahrenheitToCelsius.TabIndex = 1
        Me.radFahrenheitToCelsius.TabStop = True
        Me.radFahrenheitToCelsius.Text = "&Fahrenheit to Celsius"
        Me.radFahrenheitToCelsius.UseVisualStyleBackColor = True
        '
        'radCelsiusToFahrenheit
        '
        Me.radCelsiusToFahrenheit.AutoSize = True
        Me.radCelsiusToFahrenheit.Location = New System.Drawing.Point(15, 56)
        Me.radCelsiusToFahrenheit.Name = "radCelsiusToFahrenheit"
        Me.radCelsiusToFahrenheit.Size = New System.Drawing.Size(123, 17)
        Me.radCelsiusToFahrenheit.TabIndex = 2
        Me.radCelsiusToFahrenheit.Text = "&Celsius to Fahrenheit"
        Me.radCelsiusToFahrenheit.UseVisualStyleBackColor = True
        '
        'lbInput
        '
        Me.lbInput.AutoSize = True
        Me.lbInput.Location = New System.Drawing.Point(165, 9)
        Me.lbInput.Name = "lbInput"
        Me.lbInput.Size = New System.Drawing.Size(144, 13)
        Me.lbInput.TabIndex = 3
        Me.lbInput.Text = "&Input temperature to convert:"
        Me.lbInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbInput
        '
        Me.tbInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInput.Location = New System.Drawing.Point(168, 25)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(100, 22)
        Me.tbInput.TabIndex = 4
        '
        'tbConvert
        '
        Me.tbConvert.BackColor = System.Drawing.Color.White
        Me.tbConvert.Enabled = False
        Me.tbConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConvert.Location = New System.Drawing.Point(168, 64)
        Me.tbConvert.Name = "tbConvert"
        Me.tbConvert.Size = New System.Drawing.Size(100, 22)
        Me.tbConvert.TabIndex = 6
        '
        'lbConvert
        '
        Me.lbConvert.AutoSize = True
        Me.lbConvert.Location = New System.Drawing.Point(165, 48)
        Me.lbConvert.Name = "lbConvert"
        Me.lbConvert.Size = New System.Drawing.Size(118, 13)
        Me.lbConvert.TabIndex = 5
        Me.lbConvert.Text = "Converted temperature:"
        Me.lbConvert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbInputUnit
        '
        Me.lbInputUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInputUnit.Location = New System.Drawing.Point(269, 25)
        Me.lbInputUnit.Name = "lbInputUnit"
        Me.lbInputUnit.Size = New System.Drawing.Size(25, 20)
        Me.lbInputUnit.TabIndex = 7
        Me.lbInputUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbConvertedUnit
        '
        Me.lbConvertedUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConvertedUnit.Location = New System.Drawing.Point(269, 64)
        Me.lbConvertedUnit.Name = "lbConvertedUnit"
        Me.lbConvertedUnit.Size = New System.Drawing.Size(25, 20)
        Me.lbConvertedUnit.TabIndex = 8
        Me.lbConvertedUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(12, 126)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 9
        Me.btnConvert.Text = "C&onvert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(129, 126)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 126)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(334, 161)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lbConvertedUnit)
        Me.Controls.Add(Me.lbInputUnit)
        Me.Controls.Add(Me.tbConvert)
        Me.Controls.Add(Me.lbConvert)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.lbInput)
        Me.Controls.Add(Me.radCelsiusToFahrenheit)
        Me.Controls.Add(Me.radFahrenheitToCelsius)
        Me.Controls.Add(Me.lbHeader)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 400)
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbHeader As Label
    Friend WithEvents radFahrenheitToCelsius As RadioButton
    Friend WithEvents radCelsiusToFahrenheit As RadioButton
    Friend WithEvents lbInput As Label
    Friend WithEvents tbInput As TextBox
    Friend WithEvents tbConvert As TextBox
    Friend WithEvents lbConvert As Label
    Friend WithEvents lbInputUnit As Label
    Friend WithEvents lbConvertedUnit As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
