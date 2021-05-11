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
            Console.WriteLine("Nr of lines is {0} and nr of coll is {1}.", line, col)
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

#Region "The amount on the secondary diagonal"
    Private Function SecondaryDiagonalOfMatrix(l As Integer, c As Integer)
        Console.WriteLine("Secondary Diagonal od Matrix:")
        Dim sumR As Integer = 0
        For i = 0 To l - 1 Step 1
            For j = 0 To c - 1 Step 1
'For example  nr of lines is 3, nr of columns is 3:
' index line       0 , 1, 2
'                  -   -  -
'index columns 0 | 2   3  4
'              1 | 5   6  8
'              2 | 6   5  10
'  secondary diagonal is calculated as follows: i+j  that index of i and j i=0, j=0 and  index of l (l means the index of line) => l=0
'afte firs iteration we wil have: i=0, j=0, l=3 (nr of lines) => 0+0 = 3-1 (F)  
' next i=1, j=0 => 1+0 = 3-1 => 1=2(F)
'next i=2 , j=0 => 2+0 = 3-1 (A) => arr(2,0) = 4  the first element of secondary column

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
