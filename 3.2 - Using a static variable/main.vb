Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Static number As Integer
        number += 1
        lstOutput.Items.Add("Number of clicks = " & number)
    End Sub
End Class
