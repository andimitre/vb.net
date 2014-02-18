Public Class GradeCalculator

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function findMean() As Double
        Dim Int1, Int2, Int3, Int4, Int5, Int6, holdMean As Double


        Try
            Int1 = TextBox1.Text
            Int2 = TextBox2.Text
            Int3 = TextBox3.Text
            Int4 = TextBox4.Text
            Int5 = TextBox5.Text
            Int6 = TextBox6.Text

        Catch valueAsString As InvalidCastException
            MessageBox.Show("Please make sure all the grades entered are numbers" & "        " & valueAsString.ToString)
            Me.Close()
        End Try


        Dim numArray(5) As Double

        numArray(0) = Int1
        numArray(1) = Int2
        numArray(2) = Int3
        numArray(3) = Int4
        numArray(4) = Int5
        numArray(5) = Int6

        holdMean = (numArray(0) + numArray(1) + numArray(2) + numArray(3) + numArray(4) + numArray(5)) / 6
        Return holdMean

    End Function

    Public Sub Mean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mean.Click
        Dim holdMean As Double
        Dim stringMean As String
        holdMean = (findMean())
        stringMean = holdMean.ToString()
        'Utilizing the substring method to only display the first five characters
        TextBox7.Text = stringMean.Substring(0, 5)


        'Assuming that the professor will round up or round down the grade just as in ceiling or floor
        If holdMean >= 93.5 Then
            TextBox10.Text = "A"
        ElseIf holdMean >= 87.5 And holdMean <= 93.4 Then
            TextBox10.Text = "B+"
        ElseIf holdMean >= 81.5 And holdMean <= 87.4 Then
            TextBox10.Text = "B"
        ElseIf holdMean >= 75.5 And holdMean <= 81.4 Then
            TextBox10.Text = "C+"
        ElseIf holdMean >= 69.5 And holdMean <= 75.4 Then
            TextBox10.Text = "C"
        ElseIf holdMean >= 63.5 And holdMean <= 69.4 Then
            TextBox10.Text = "D"
        ElseIf holdMean <= 63.4 Then
            TextBox10.Text = "F"
        End If

    End Sub

    Private Function findVariance() As Double
        Dim Int1, Int2, Int3, Int4, Int5, Int6 As Double
        Int1 = TextBox1.Text
        Int2 = TextBox2.Text
        Int3 = TextBox3.Text
        Int4 = TextBox4.Text
        Int5 = TextBox5.Text
        Int6 = TextBox6.Text

        Dim numArray(5) As Double

        numArray(0) = Int1
        numArray(1) = Int2
        numArray(2) = Int3
        numArray(3) = Int4
        numArray(4) = Int5
        numArray(5) = Int6

        Dim average As Double = (numArray(0) + numArray(1) + numArray(2) + numArray(3) + numArray(4) + numArray(5)) / 6

        Return ((numArray(0) - average) ^ 2 + (numArray(1) - average) ^ 2 + (numArray(2) - average) ^ 2 + (numArray(3) - average) ^ 2 + (numArray(4) - average) ^ 2 + (numArray(5) - average) ^ 2)

    End Function

    Private Sub Variance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Variance.Click
        Dim holdVariance As Double
        Dim answer As String
        holdVariance = (findVariance())
        answer = holdVariance.ToString()
        'Used substring to only display the first 5 characters of the value
        TextBox8.Text = answer.Substring(0, 5)

    End Sub

    Private Function findStdVariation() As Double
        Dim stdAverage, stdAverageSquared As Double
        Dim Int1, Int2, Int3, Int4, Int5, Int6 As Double
        Dim newValue1, newValue2, newValue3, newValue4, newValue5, newValue6 As Double

        Int1 = TextBox1.Text
        Int2 = TextBox2.Text
        Int3 = TextBox3.Text
        Int4 = TextBox4.Text
        Int5 = TextBox5.Text
        Int6 = TextBox6.Text

        Dim numArray(5) As Double

        numArray(0) = Int1
        numArray(1) = Int2
        numArray(2) = Int3
        numArray(3) = Int4
        numArray(4) = Int5
        numArray(5) = Int6

        stdAverage = (numArray(0) + numArray(1) + numArray(2) + numArray(3) + numArray(4) + numArray(5)) / 6
        newValue1 = (numArray(0) - stdAverage) ^ 2
        newValue2 = (numArray(1) - stdAverage) ^ 2
        newValue3 = (numArray(2) - stdAverage) ^ 2
        newValue4 = (numArray(3) - stdAverage) ^ 2
        newValue5 = (numArray(4) - stdAverage) ^ 2
        newValue6 = (numArray(5) - stdAverage) ^ 2

        stdAverageSquared = ((newValue1 + newValue2 + newValue3 + newValue4 + newValue5 + newValue6) / 6) ^ (1 / 2)

        Return stdAverageSquared

    End Function


    Private Sub Deviation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deviation.Click
        Dim holdStdVariation As Double
        Dim variationValue As String
        holdStdVariation = (findStdVariation())
        'Converting value to string
        variationValue = holdStdVariation.ToString()
        'Utilizing the substring method to only display the first five characters of the value
        TextBox9.Text = variationValue.Substring(0, 5)
    End Sub
End Class
