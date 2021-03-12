Public Class main
    Private Sub btnGood_Click(sender As Object, e As EventArgs) Handles btnGood.Click
        lblMessage.Text = "I like Visual Basic .NET"
    End Sub

    Private Sub btnBad_Click(sender As Object, e As EventArgs) Handles btnBad.Click
        lblMessage.Text = "I hate Visual Basic .NET"
    End Sub
End Class
