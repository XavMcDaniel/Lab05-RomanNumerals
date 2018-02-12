Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Try
            Select Case CInt(txtInput.Text)
                Case 1
                    lblOutput.Text = "I"
                Case 2
                    lblOutput.Text = "II"
                Case 3
                    lblOutput.Text = "III"
                Case 4
                    lblOutput.Text = "IV"
                Case 5
                    lblOutput.Text = "V"
                Case 6
                    lblOutput.Text = "VI"
                Case 7
                    lblOutput.Text = "VII"
                Case 8
                    lblOutput.Text = "VIII"
                Case 9
                    lblOutput.Text = "IX"
                Case 10
                    lblOutput.Text = "X"
                Case Is < 1
                    lblOutput.Text = "Must be greater than 1"
                Case Is > 10
                    lblOutput.Text = "Must be less than 10"
            End Select
        Catch
            lblOutput.Text = "Enter a numeric value"
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
