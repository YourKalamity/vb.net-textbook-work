Public Class main
    Dim FirstNum, SecondNum As Single
    Dim Message As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblOutput.Text = ""
        FirstNum = txtFirstNumber.Text
        SecondNum = txtSecondNumber.Text
        Message = "The results are as follows:" & vbNewLine
        Message = Message & "Addition: " & FirstNum + SecondNum & vbNewLine
        Message = Message & "Subtraction: " & FirstNum - SecondNum & vbNewLine
        Message = Message & "Multiplication: " & FirstNum * SecondNum & vbNewLine
        Message = Message & "Division: " & FirstNum / SecondNum & vbNewLine
        txtOutput.Text = Message

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblOutput.Text = ""
        FirstNum = txtFirstNumber.Text
        SecondNum = txtSecondNumber.Text
        Message = "The results are as follows:"
        Message = Message & "Addition: " & FirstNum + SecondNum & vbNewLine
        Message = Message & "Subtraction: " & FirstNum - SecondNum & vbNewLine
        Message = Message & "Multiplication: " & FirstNum * SecondNum & vbNewLine
        Message = Message & "Division: " & FirstNum / SecondNum & vbNewLine
        MsgBox(Message)
    End Sub

    Private Sub btnLabel_Click(sender As Object, e As EventArgs) Handles btnLabel.Click
        lblOutput.Text = ""
        FirstNum = txtFirstNumber.Text
        SecondNum = txtSecondNumber.Text
        Message = "The results are as follows:"
        Message = Message & "Addition: " & FirstNum + SecondNum & vbNewLine
        Message = Message & "Subtraction: " & FirstNum - SecondNum & vbNewLine
        Message = Message & "Multiplication: " & FirstNum * SecondNum & vbNewLine
        Message = Message & "Division: " & FirstNum / SecondNum & vbNewLine
        lblOutput.Text = Message
    End Sub
End Class
