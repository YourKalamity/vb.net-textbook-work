Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim TotalSales As Integer
        Dim Bonus As Integer

        TotalSales = txtTotal.Text

        If (TotalSales >= 100000) Then
            Bonus = 10000
        ElseIf (TotalSales >= 70000) Then
            Bonus = 7000
        ElseIf (TotalSales >= 50000) Then
            Bonus = 4000
        Else
            Bonus = 0
        End If


        MsgBox("The bonus you earned this year : £" + CStr(Bonus))

    End Sub
End Class
