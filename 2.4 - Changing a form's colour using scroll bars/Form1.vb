Public Class Form1
    Private Sub hsbRed_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbRed.Scroll
        Me.BackColor = ColorTranslator.FromOle(RGB(hsbRed.Value, hsbGreen.Value, hsbBlue.Value))
    End Sub

    Private Sub hsbGreen_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbGreen.Scroll
        Me.BackColor = ColorTranslator.FromOle(RGB(hsbRed.Value, hsbGreen.Value, hsbBlue.Value))
    End Sub

    Private Sub hsbBlue_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbBlue.Scroll
        Me.BackColor = ColorTranslator.FromOle(RGB(hsbRed.Value, hsbGreen.Value, hsbBlue.Value))
    End Sub
End Class
