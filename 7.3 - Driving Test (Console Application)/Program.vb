Imports System

Module Program
    Sub Main(args As String())
        Dim TotalNumber, NumberPassed As Integer
        Dim Response As String
        TotalNumber = 0
        NumberPassed = 0
        Console.WriteLine("Has person passed driving test?. Y/N or Q to Quit")
        Response = Console.ReadLine()
        Do While (Response = "Y") Or (Response = "N")
            TotalNumber = TotalNumber + 1
            If Response = "Y" Then
                NumberPassed = NumberPassed + 1
            End If
            Console.WriteLine("Has person passed driving test?. Y/N or Q to Quit")
            Response = Console.ReadLine()
        Loop
        Console.WriteLine("Total number of people: {0}", TotalNumber)
        Console.WriteLine("Percentage who passed: {0}", Format(NumberPassed / TotalNumber * 100, "###.00"))
        Console.ReadLine()
    End Sub
End Module
