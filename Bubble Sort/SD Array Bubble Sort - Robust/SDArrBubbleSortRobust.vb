Module Module1
    Sub Main()
        Dim Array(10), count As Integer
        For count = 1 To 10
            Array(count) = Console.ReadLine()
        Next
        Call Bubblesort(Array, 10)

        For count = 1 To 10
            Console.WriteLine(Array(count))
        Next
        Console.ReadKey()
    End Sub
    Sub Bubblesort(ByVal Array() As Integer, ByVal Length As Integer)
        Dim isSorted As Boolean
        Dim I As Integer
        Dim J As Integer
        Dim Temp As Integer
        isSorted = True
        For I = Length - 1 To 1 Step -1 'last element of array does'nt get sorted.
            isSorted = True
            For J = 0 To I '- 1
                If Array(J) > Array(J + 1) Then ' Compare neighboring elements 
                    Temp = Array(J)
                    Array(J) = Array(J + 1)
                    Array(J + 1) = Temp
                    isSorted = False
                End If
            Next
            If isSorted = True Then Exit For
        Next
    End Sub
End Module
