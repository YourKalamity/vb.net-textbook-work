Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Mark As Integer
        Mark = InputBox("Enter an exam mark from 0 to 100")
        If Mark >= 60 Then
            MsgBox("Merit")
        ElseIf Mark Then >= 40 Then
            MsgBox("Pass")
        Else
            MsgBox("A mark of " & Mark & "is a fail")
        End If
    End Sub
End Class
