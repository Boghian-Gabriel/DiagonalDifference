Imports System
Imports System.Math
Module Program

#Region "Create variable"
    Dim line As Integer
    Dim col As Integer
    Dim arr(,) As Integer
#End Region

    Sub Main(args As String())
        Console.WriteLine("Application Diagonal difference!")

        Console.Write("Enter nr of lines: ")
        line = Integer.Parse(Console.ReadLine())
        Console.Write("Enter nr of columns: ")
        col = Integer.Parse(Console.ReadLine())

        If line = col Then
            Console.WriteLine("Nr of lines is {0} adn nr of coll is {1}.", line, col)
            EnterMatrixEl(line, col)
            MatrixIs(line, col)
            Console.WriteLine()
            Dim sumOfMainDiagonal = MainDiagonalOfMatrix(line, col)
            Console.WriteLine()
            Dim sumOfSecondaryDiagonals = SecondaryDiagonalOfMatrix(line, col)
            Dim rez = sumOfMainDiagonal - sumOfSecondaryDiagonals
            Console.WriteLine()
            Console.Write("Difference | {0} - {1} | = {2}", sumOfMainDiagonal, sumOfSecondaryDiagonals, Math.Abs(rez))
        Else
            Console.WriteLine("You need to enter a quadratic matrix <=> nr rows = nr columns")
        End If
    End Sub

#Region "Enter elements in Matrix"
    Private Sub EnterMatrixEl(l As Integer, c As Integer)

        'trebuie initizata matricea aici, nu sus

        arr = New Integer(l, c) {}
        Console.WriteLine("Enter Matrix elements: ")
        For i = 0 To l - 1 Step 1
            For j = 0 To c - 1 Step 1
                Console.Write("Enter element [{0}][{1}]: ", i, j)
                arr(i, j) = Integer.Parse(Console.ReadLine())
            Next
            Console.WriteLine()
        Next
    End Sub
#End Region

#Region "Display Matrix"
    Private Sub MatrixIs(l As Integer, c As Integer)
        Console.WriteLine("Matrix: ")
        For i = 0 To l - 1 Step 1
            For j = 0 To c - 1 Step 1
                Console.Write("{0} ", arr(i, j))
            Next
            Console.WriteLine()
        Next
    End Sub
#End Region

#Region "The amount on the main diagonal"
    Private Function MainDiagonalOfMatrix(l As Integer, c As Integer)
        Console.WriteLine("Main Diagonal of Matrix:")
        Dim sumL As Integer = 0
        For i = 0 To l - 1 Step 1
            For j = 0 To c - 1 Step 1
                If i = j Then
                    Console.Write("{0}", arr(i, j))
                    sumL += arr(i, j)
                Else
                    Console.Write("  ")
                End If
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("Sum LeftDiagonalOfMatrix is {0}: ", sumL)
        Return sumL
    End Function
#End Region

#Region "The amount on the secondary secondary"
    Private Function SecondaryDiagonalOfMatrix(l As Integer, c As Integer)
        Console.WriteLine("Secondary Diagonal od Matrix:")
        Dim sumR As Integer = 0
        For i = 0 To l - 1 Step 1
            For j = 0 To c - 1 Step 1
                If i + j = l - 1 Then
                    Console.Write("{0}", arr(i, j))
                    sumR += arr(i, j)
                Else
                    Console.Write("  ")
                End If
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("Sum LeftDiagonalOfMatrix is {0}: ", sumR)
        Return sumR
    End Function
#End Region

End Module
