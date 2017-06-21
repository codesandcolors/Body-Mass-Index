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
        Me.calcButton = New System.Windows.Forms.Button()
        Me.weightGroupBox = New System.Windows.Forms.GroupBox()
        Me.kiloRadioButton = New System.Windows.Forms.RadioButton()
        Me.poundsRadioButton = New System.Windows.Forms.RadioButton()
        Me.weightLabel = New System.Windows.Forms.Label()
        Me.BMIdisplay = New System.Windows.Forms.Label()
        Me.weightTextBox = New System.Windows.Forms.TextBox()
        Me.BMILabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.heightLabel = New System.Windows.Forms.Label()
        Me.heightFtTextbox = New System.Windows.Forms.TextBox()
        Me.heightInchTextbox = New System.Windows.Forms.TextBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.weightGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(39, 305)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(115, 35)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'weightGroupBox
        '
        Me.weightGroupBox.Controls.Add(Me.kiloRadioButton)
        Me.weightGroupBox.Controls.Add(Me.poundsRadioButton)
        Me.weightGroupBox.Location = New System.Drawing.Point(271, 42)
        Me.weightGroupBox.Name = "weightGroupBox"
        Me.weightGroupBox.Size = New System.Drawing.Size(136, 143)
        Me.weightGroupBox.TabIndex = 1
        Me.weightGroupBox.TabStop = False
        Me.weightGroupBox.Text = "Weight"
        '
        'kiloRadioButton
        '
        Me.kiloRadioButton.AutoSize = True
        Me.kiloRadioButton.Location = New System.Drawing.Point(7, 81)
        Me.kiloRadioButton.Name = "kiloRadioButton"
        Me.kiloRadioButton.Size = New System.Drawing.Size(124, 29)
        Me.kiloRadioButton.TabIndex = 1
        Me.kiloRadioButton.Text = "Kilograms"
        Me.kiloRadioButton.UseVisualStyleBackColor = True
        '
        'poundsRadioButton
        '
        Me.poundsRadioButton.AutoSize = True
        Me.poundsRadioButton.Checked = True
        Me.poundsRadioButton.Location = New System.Drawing.Point(7, 30)
        Me.poundsRadioButton.Name = "poundsRadioButton"
        Me.poundsRadioButton.Size = New System.Drawing.Size(104, 29)
        Me.poundsRadioButton.TabIndex = 0
        Me.poundsRadioButton.TabStop = True
        Me.poundsRadioButton.Text = "Pounds"
        Me.poundsRadioButton.UseVisualStyleBackColor = True
        '
        'weightLabel
        '
        Me.weightLabel.AutoSize = True
        Me.weightLabel.Location = New System.Drawing.Point(13, 29)
        Me.weightLabel.Name = "weightLabel"
        Me.weightLabel.Size = New System.Drawing.Size(125, 25)
        Me.weightLabel.TabIndex = 2
        Me.weightLabel.Text = "Enter weight:"
        '
        'BMIdisplay
        '
        Me.BMIdisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BMIdisplay.Location = New System.Drawing.Point(39, 199)
        Me.BMIdisplay.Name = "BMIdisplay"
        Me.BMIdisplay.Size = New System.Drawing.Size(225, 36)
        Me.BMIdisplay.TabIndex = 3
        Me.BMIdisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'weightTextBox
        '
        Me.weightTextBox.Location = New System.Drawing.Point(18, 57)
        Me.weightTextBox.Name = "weightTextBox"
        Me.weightTextBox.Size = New System.Drawing.Size(100, 30)
        Me.weightTextBox.TabIndex = 4
        '
        'BMILabel
        '
        Me.BMILabel.AutoSize = True
        Me.BMILabel.Location = New System.Drawing.Point(82, 160)
        Me.BMILabel.Name = "BMILabel"
        Me.BMILabel.Size = New System.Drawing.Size(118, 25)
        Me.BMILabel.TabIndex = 5
        Me.BMILabel.Text = "Your BMI is:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(318, 305)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(115, 35)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'statusLabel
        '
        Me.statusLabel.Location = New System.Drawing.Point(39, 248)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(225, 36)
        Me.statusLabel.TabIndex = 7
        Me.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'heightLabel
        '
        Me.heightLabel.AutoSize = True
        Me.heightLabel.Location = New System.Drawing.Point(18, 94)
        Me.heightLabel.Name = "heightLabel"
        Me.heightLabel.Size = New System.Drawing.Size(176, 25)
        Me.heightLabel.TabIndex = 8
        Me.heightLabel.Text = "Enter height (ft, in):"
        '
        'heightFtTextbox
        '
        Me.heightFtTextbox.Location = New System.Drawing.Point(23, 123)
        Me.heightFtTextbox.Name = "heightFtTextbox"
        Me.heightFtTextbox.Size = New System.Drawing.Size(51, 30)
        Me.heightFtTextbox.TabIndex = 9
        '
        'heightInchTextbox
        '
        Me.heightInchTextbox.Location = New System.Drawing.Point(87, 122)
        Me.heightInchTextbox.Name = "heightInchTextbox"
        Me.heightInchTextbox.Size = New System.Drawing.Size(51, 30)
        Me.heightInchTextbox.TabIndex = 10
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(174, 305)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(115, 35)
        Me.clearButton.TabIndex = 11
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 367)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.heightInchTextbox)
        Me.Controls.Add(Me.heightFtTextbox)
        Me.Controls.Add(Me.heightLabel)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.BMILabel)
        Me.Controls.Add(Me.weightTextBox)
        Me.Controls.Add(Me.BMIdisplay)
        Me.Controls.Add(Me.weightLabel)
        Me.Controls.Add(Me.weightGroupBox)
        Me.Controls.Add(Me.calcButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "Body Mass Index"
        Me.weightGroupBox.ResumeLayout(False)
        Me.weightGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcButton As Button
    Friend WithEvents weightGroupBox As GroupBox
    Friend WithEvents kiloRadioButton As RadioButton
    Friend WithEvents poundsRadioButton As RadioButton
    Friend WithEvents weightLabel As Label
    Friend WithEvents BMIdisplay As Label
    Friend WithEvents weightTextBox As TextBox
    Friend WithEvents BMILabel As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents statusLabel As Label
    Friend WithEvents heightLabel As Label
    Friend WithEvents heightFtTextbox As TextBox
    Friend WithEvents heightInchTextbox As TextBox
    Friend WithEvents clearButton As Button
End Class
