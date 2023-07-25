Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Get the values from TextBox1 and TextBox2
        Dim number1 As Double = Val(TextBox1.Text)
        Dim number2 As Double = Val(TextBox2.Text)

        ' Add the numbers and store the result in a variable
        Dim result As Double = number1 + number2

        ' Display the result in TextBox3
        TextBox3.Text = result.ToString()
    End Sub

End Class
