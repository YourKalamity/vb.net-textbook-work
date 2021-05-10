Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const Max = 5
        Dim ColNumber, RowNumber, Sum As Integer
        Dim Message As String

        Message = "+" & Space(11)
        For ColNumber = 0 To Max
            Message = Message & ColNumber & Space(8)
        Next ColNumber
        Message = Message & vbNewLine & vbNewLine
        For RowNumber = 0 To Max
            Message = Message & RowNumber & Space(12)
            For ColNumber = 0 To Max
                Sum = ColNumber + RowNumber
                Message = Message & Sum & Space(8)
            Next ColNumber
            Message = Message & vbNewLine
        Next RowNumber
        MsgBox(Message, , "Addition table using a nested For Loop")
    End Sub
End Class
