Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim Number As Integer
        Dim Index As Integer
        Dim Result As Integer
        Number = txtNumber.Text
        For Index = 2 To 12
            Result = Index * Number
            lstOutput.Items.Add(Number & " x " & Index & " = " & Result)
        Next Index

    End Sub
End Class
