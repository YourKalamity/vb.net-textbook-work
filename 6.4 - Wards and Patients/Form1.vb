Public Class Form1
    Private Sub lstWards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWards.SelectedIndexChanged
        Dim Ward As String
        Ward = lstWards.Text
        lstPatients.Items.Clear()

        Select Case Ward
            Case "Fleming"
                lstPatients.Items.Add("Fred Jones")
                lstPatients.Items.Add("John Green")
                lstPatients.Items.Add("Imran Shah")
            Case "Harvey"
                lstPatients.Items.Add("Jane Young")
                lstPatients.Items.Add("Bhavini Bhatt")
                lstPatients.Items.Add("Dawn Peters")
            Case "Jenenr"
                lstPatients.Items.Add("William Black")
                lstPatients.Items.Add("Micheal Jones")
                lstPatients.Items.Add("Darren Campbell")
        End Select
    End Sub
End Class
