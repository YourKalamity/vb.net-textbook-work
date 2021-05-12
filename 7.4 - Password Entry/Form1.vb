Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Password, InputPassword As String
        Dim Attempt As Integer
        Password = "secret"
        Attempt = 0
        Do
            Attempt = Attempt + 1
            InputPassword = InputBox("Enter Password. This is attempt number :" & Attempt)
        Loop Until (Attempt = 3) Or (InputPassword = Password)
        If InputPassword = Password Then
            MsgBox("This password is valid")
        Else
            MsgBox("This password is invalid")
        End If
    End Sub
End Class
