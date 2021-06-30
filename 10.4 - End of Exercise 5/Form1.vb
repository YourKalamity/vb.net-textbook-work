Public Class Form1
    Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function CheckAnswer(ByVal CityName As String, ByVal CountryName As String)
        Dim City_Names(6) As String
        Dim Country_Names(6) As String
        City_Names(0) = "London"
        City_Names(1) = "Paris"
        City_Names(2) = "Tokyo"
        City_Names(3) = "Beijing"
        City_Names(4) = "Manila"
        City_Names(5) = "Washington D.C"
        Country_Names(0) = "England"
        Country_Names(1) = "France"
        Country_Names(2) = "Japan"
        Country_Names(3) = "China"
        Country_Names(4) = "Phillipines"
        Country_Names(5) = "USA"
        Dim cityindex As Integer = Array.IndexOf(City_Names, CityName)
        If Country_Names(cityindex) = CountryName Then
            lblCheck.Text = "CORRECT"
            System.Threading.Thread.Sleep(1000)
            lst_City.SelectedIndex = -1
            lst_Countries.SelectedIndex = -1
            Return True
        Else
            lblCheck.Text = Country_Names(cityindex)
            lblAnswer.Text = CountryName & "'s capital city is " & Country_Names(cityindex)
            lst_City.SelectedIndex = -1
            lst_Countries.SelectedIndex = -1
            Return False
        End If
    End Function

    Private Sub lst_City_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_City.SelectedIndexChanged
        If lst_Countries.SelectedIndex >= 0 Then
            lblCheck.Text = lst_City.SelectedItem
            CheckAnswer(lst_City.SelectedItem, lst_Countries.SelectedItem)

        End If
    End Sub

    Private Sub lst_Countries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Countries.SelectedIndexChanged
        If lst_City.SelectedIndex >= 0 Then
            CheckAnswer(lst_City.SelectedItem, lst_Countries.SelectedItem)
        End If
    End Sub
End Class
