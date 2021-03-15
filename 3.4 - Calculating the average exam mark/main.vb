Option Strict On
Public Class txtMean
    Dim total As Integer
    Dim NumberOfMarks As Integer

    Private Sub txtMean_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total = 0
        NumberOfMarks = 0
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim Number As Integer
        Number = CInt(txtMark.Text)
        lstMarks.Items.Add(Number)
        total = total + 1
        NumberOfMarks = NumberOfMarks + 1
        btnShowMean.Visible = True
        txtMark.Text = ""
        txtMark.Focus()
    End Sub

    Private Sub btnShowMean_Click(sender As Object, e As EventArgs) Handles btnShowMean.Click
        Dim Mean As Double
        Mean = total / NumberOfMarks
        txtMeans.Text = CStr(Mean)
        txtMeans.Visible = True
        lblMean.Visible = True
        txtMark.Enabled = False
        btnOk.Enabled = False
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub txtMark_TextChanged(sender As Object, e As EventArgs) Handles txtMark.TextChanged
        btnOk.Enabled = True
    End Sub
End Class
