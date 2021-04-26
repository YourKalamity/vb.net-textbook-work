Public Class main

    Private Sub chkFullSet_CheckedChanged(sender As Object, e As EventArgs) Handles chkFullSet.CheckedChanged
        If chkFullSet.Checked = True Then
            chkKnife.Checked = True
            chkFork.Checked = True
            chkSpoon.Checked = True
        Else
            chkKnife.Checked = False
            chkFork.Checked = False
            chkSpoon.Checked = False
        End If
    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        If lstBrands.Text = "" Then
            MsgBox("You must select a brand", , "Brand")
        ElseIf (chkKnife.Checked = False) And
                (chkFork.Checked = False) And
                (chkSpoon.Checked = False) Then
            MsgBox("You must select one or more items", , "Items")
        ElseIf (radOne.Checked = False) And
                (radTwo.Checked = False) And
                (radFour.Checked = False) And
                (radEight.Checked = False) Then
            MsgBox("You must select a quantity", , "Quantity")
        Else
            MsgBox("All 3 things have been selected!",, "Cutlery")
        End If
    End Sub
End Class
