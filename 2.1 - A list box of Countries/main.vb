Public Class main
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstCountries.Items.Add(txtCountry.Text)
        txtCountry.Text = ""
        txtCountry.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        lstCountries.Items.RemoveAt(lstCountries.SelectedIndex)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstCountries.Items.Clear()
    End Sub
End Class
