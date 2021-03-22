Public Class main
    Private Sub radExpressionOne_CheckedChanged(sender As Object, e As EventArgs) Handles radExpressionOne.CheckedChanged
        lblOut.Text = CLng(txtA.Text) + CLng(txtB.Text) - CLng(txtC.Text)
    End Sub

    Private Sub radExpressionTwo_CheckedChanged(sender As Object, e As EventArgs) Handles radExpressionTwo.CheckedChanged
        lblOut.Text = CLng(txtA.Text) - CLng(txtC.Text) / CLng(txtB.Text)
    End Sub

    Private Sub radExpressionThree_CheckedChanged(sender As Object, e As EventArgs) Handles radExpressionThree.CheckedChanged
        lblOut.Text = CLng(txtB.Text) Mod CLng(txtC.Text)
    End Sub
End Class
