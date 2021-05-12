Public Class Form1

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        GlobalVariables.Total += 1
        If chkHoliday.Checked Then
            GlobalVariables.Holidayers += 1
            If radGB.Checked Then
                GlobalVariables.InGB += 1
            Else
                GlobalVariables.Abroad += 1
            End If
            If radUpTo2Weeks.Checked Then
                GlobalVariables.UpTo2Weeks += 1
            Else
                GlobalVariables.GreaterThan2Weeks += 1
            End If
        End If
        lblNumber.Text = "Number Entered : " & GlobalVariables.Total

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpGB.Enabled = False
        grpWeeks.Enabled = False
        GlobalVariables.Total = 0
        GlobalVariables.Holidayers = 0
        GlobalVariables.InGB = 0
        GlobalVariables.Abroad = 0
        GlobalVariables.GreaterThan2Weeks = 0
        GlobalVariables.UpTo2Weeks = 0
    End Sub

    Private Sub chkHoliday_CheckedChanged(sender As Object, e As EventArgs) Handles chkHoliday.CheckedChanged
        If chkHoliday.Checked Then

            grpGB.Enabled = True
            grpWeeks.Enabled = True
        Else
            grpGB.Enabled = False
            grpWeeks.Enabled = False
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Message As String
        Message = "Number of people who did not take a holiady " & GlobalVariables.Total - GlobalVariables.Abroad & vbNewLine
        Message = Message & "Percantage of people who did not take a holiday " & (GlobalVariables.Abroad / GlobalVariables.Total) * 100 & "%" & vbNewLine
        Message = Message & "Number of people who took a holiday in Britain of up to 2 weeks " & GlobalVariables.UpTo2Weeks & vbNewLine
        Message = Message & "Percantage of people who took a holiday in Britain of up to 2 weeks " & (GlobalVariables.UpTo2Weeks / GlobalVariables.Total) * 100 & "%" & vbNewLine
        Message = Message & "Number of people who took a holiday in Britain of over 2 weeks " & GlobalVariables.GreaterThan2Weeks & vbNewLine
        Message = Message & "Percantage of people who took a holiday in Britain of over 2 weeks " & (GlobalVariables.GreaterThan2Weeks / GlobalVariables.Total) * 100 & "%" & vbNewLine
        Message = Message & "Number of people who took a holiday Abraod of up to 2 weeks " & GlobalVariables.UpTo2Weeks & vbNewLine
        Message = Message & "Percantage of people who took a holiday Abroad of up to 2 weeks " & (GlobalVariables.UpTo2Weeks / GlobalVariables.Total) * 100 & "%" & vbNewLine
        Message = Message & "Number of people who took a holiday Abroad of over 2 weeks " & GlobalVariables.GreaterThan2Weeks & vbNewLine
        Message = Message & "Percantage of people who took a holiday Abroad of over 2 weeks " & (GlobalVariables.GreaterThan2Weeks / GlobalVariables.Total) * 100 & "%" & vbNewLine


    End Sub
End Class

Public Class GlobalVariables
    Public Shared Total, Holidayers, InGB, Abroad, GreaterThan2Weeks, UpTo2Weeks As Integer
End Class