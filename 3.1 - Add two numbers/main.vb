Public Class main
    Dim first_number As Integer
    Dim second_number As Integer
    Dim total As Integer

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        first_number = InputBox("Enter your first number")
        second_number = InputBox("Enter your second number")
        total = first_number + second_number
        lblOutput.Text = total
    End Sub
End Class
