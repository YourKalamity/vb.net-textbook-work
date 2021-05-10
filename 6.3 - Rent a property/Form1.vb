Public Class Form1
    Dim PropType As String
    Dim Bedrooms As Integer

    Private Sub btnIncorrect_Click(sender As Object, e As EventArgs) Handles btnIncorrect.Click
        PropType = lstTypes.Text
        Bedrooms = lstBedrooms.Text
        If (PropType = "Cottage") Or (PropType = "Detached") _
            And (Bedrooms >= 4) Then
            MsgBox("Rent it")
        Else
            MsgBox("Don't rent it")
        End If
    End Sub

    Private Sub btnCorrect_Click(sender As Object, e As EventArgs) Handles btnCorrect.Click
        PropType = lstTypes.Text
        Bedrooms = lstBedrooms.Text
        If (PropType = "Cottage") And (Bedrooms >= 4) _
            Or (PropType = "Detached") And (Bedrooms >= 4) Then
            MsgBox("Rent it")
        Else
            MsgBox("Don't rent it")
        End If
    End Sub
End Class
