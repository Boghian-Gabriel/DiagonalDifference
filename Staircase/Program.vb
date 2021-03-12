Imports System

Module Program
    Sub Main(args As String())

        Console.Write("Please enter value of n: ")
        Dim n = Integer.Parse(Console.ReadLine())
        Console.WriteLine("The value of n is: {0} ", n)

        Staircase(n)

    End Sub

    Private Sub Staircase(number As Integer)
        For i = 0 To number - 1 Step 1
            Console.WriteLine(New String("#", i + 1).PadLeft(number, " "))
        Next
    End Sub
End Module
