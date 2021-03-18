Public Class main
    Dim MyFormat As String = "{0,-5}{1,-20}{2,-20}{3,-7}"

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOutput.Items.Add(String.Format(MyFormat, "No.", "Name", "Club", "Time"))

    End Sub

    Private Sub btnMethod1_Click(sender As Object, e As EventArgs) Handles btnMethod1.Click
        Dim Number, Name, Club, OneRunnerDetails As String
        Dim Time As String
        Number = txtNumber.Text
        Name = txtName.Text
        Club = txtClub.Text
        Time = txtTime.Text
        lstOutput.Items.Add(String.Format(MyFormat, Number, Name, Club, Time))
        txtNumber.Clear()
        txtName.Clear()
        txtClub.Clear()
        txtTime.Clear()
        txtNumber.Focus()
    End Sub

    Private Sub btnMethod2_Click(sender As Object, e As EventArgs) Handles btnMethod2.Click
        Dim Number, Name, Club, OneRunnerDetails As String
        Dim Time As String
        Number = txtNumber.Text
        Name = txtName.Text
        Club = txtClub.Text
        Time = txtTime.Text

        Number = Number & Space(5 - Len(Number))
        Name = Name & Space(20 - Len(Name))
        Club = Club & Space(20 - Len(Club))
        OneRunnerDetails = Number & Name & Club & Time
        lstOutput.Items.Add(OneRunnerDetails)
        txtNumber.Clear()
        txtName.Clear()
        txtClub.Clear()
        txtTime.Clear()
        txtNumber.Focus()
    End Sub
End Class
