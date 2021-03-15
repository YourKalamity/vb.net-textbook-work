Public Class Form1
    Dim surname As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        surname = "Green"
        lblGlobal.Text = surname
    End Sub

    Private Sub btnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        Dim surname As String
        surname = "Brown"
        lblLocal.Text = surname
    End Sub
End Class
