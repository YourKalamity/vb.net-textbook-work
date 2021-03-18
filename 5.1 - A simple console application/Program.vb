Imports System

Module Program
    Sub Main(args As String())
        Dim FivePoundTickets, TenPoundTickets As Integer
        Dim CostOfBand, CostOfFood, OtherCosts As Decimal
        Dim Income, Expenditure, Profit As Decimal
        Console.Write("How many £5 tickets sold? ")
        FivePoundTickets = Console.ReadLine()
        Console.Write("How many £10 tickets sold? ")
        TenPoundTickets = Console.ReadLine()
        Console.Write("Cost of band? ")
        CostOfBand = Console.ReadLine()
        Console.Write("Cost of food? ")
        CostOfFood = Console.ReadLine()
        Console.Write("Other costs ")
        OtherCosts = Console.ReadLine()
        Console.WriteLine()
        Income = (FivePoundTickets * 5) + (TenPoundTickets * 10)
        Expenditure = CostOfBand + CostOfFood + OtherCosts
        Profit = Income - Expenditure
        Console.WriteLine("Total income is {0}", Format(Income, "Currency"))
        Console.WriteLine("Total expenditure is {0}", Format(Expenditure, "Currency"))
        Console.WriteLine("Profit is {0}", String.Format("{0:C}", Profit))
        Console.ReadLine()
    End Sub
End Module
