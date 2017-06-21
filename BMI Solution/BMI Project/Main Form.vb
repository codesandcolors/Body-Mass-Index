' Project name:             BMI Project
' Project purpose:          Calcualtes BMI and tells user if underweight, normal, overweight or obese
' Date created:             6/20/2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class MainForm
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        BMIdisplay.Text = String.Empty
        statusLabel.Text = String.Empty
        weightTextBox.Clear()
        heightFtTextbox.Clear()
        heightInchTextbox.Clear()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Function ConvertWeight(ByRef convertedWeight As Double) As Double
        'converts weight if in pounds
        Dim weight As Double

        Double.TryParse(weightTextBox.Text, weight)

        If poundsRadioButton.Checked Then
            convertedWeight = weight * 0.4535
        Else
            convertedWeight = weight
        End If

        Return convertedWeight
    End Function

    Private Function ConvertHeight(ByRef convertedHeight As Double) As Double
        'converts height from ft to cm


        Dim ftToM As Double
        Dim inchToM As Double
        Dim ftHeight As Double
        Dim inchHeight As Double

        'calculate ft to cm
        Double.TryParse(heightFtTextbox.Text, ftHeight)
        ftToM = ftHeight * 0.3048
        'calculate in to cm
        Double.TryParse(heightInchTextbox.Text, inchHeight)
        inchToM = inchHeight * 0.0254

        'calculate converted height
        convertedHeight = ftToM + inchToM
        Return convertedHeight
    End Function

    Private Function GetBMI(ByRef bmi As Double) As Double
        Dim weight As Double
        Dim height As Double

        ConvertWeight(weight)
        ConvertHeight(height)

        bmi = weight / (height ^ 2)

        'display bmi
        BMIdisplay.Text = bmi.ToString("N2")

        Return bmi
    End Function

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'identify if underweight, normal, overweight, or obese

        Dim bmi As Double

        GetBMI(bmi)

        If bmi < 18.5 Then
            statusLabel.Text = "Underweight"
            statusLabel.ForeColor = Color.Red
        ElseIf bmi >= 18.5 AndAlso bmi <= 24.9 Then
            statusLabel.Text = "Normal"
        ElseIf bmi >= 25 And bmi <= 29.9 Then
            statusLabel.Text = "Overweight"
            statusLabel.ForeColor = Color.Orange
        Else
            statusLabel.Text = "Obese"
            statusLabel.ForeColor = Color.Red
        End If
    End Sub

    Private Sub weightTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles weightTextBox.KeyPress, heightFtTextbox.KeyPress, heightInchTextbox.KeyPress
        'allow numeric inputs and backspace only

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
