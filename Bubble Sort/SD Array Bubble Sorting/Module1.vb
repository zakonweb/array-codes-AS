Module Module1

    Sub Main()
        Dim NUM(5) As Integer
        Dim i, j, x, c As Integer
        Dim alreadySorted As Boolean

        c = 0
        i = 0
        j = 0
        x = 0
        alreadySorted = True

        'initialise an array
        For i = 1 To 5
            NUM(i) = 0
        Next

        'popuate an array
        For i = 1 To 5
            Console.Write("Enter Value." & i & " :")
            x = Console.ReadLine
            NUM(i) = x
        Next

        'bubble sort
        For j = 4 To 1 Step -1
            alreadySorted = True
            For i = 1 To j
                If NUM(i) > NUM(i + 1) Then
                    c = c + 1
                    x = NUM(i)
                    NUM(i) = NUM(i + 1)
                    NUM(i + 1) = x
                    alreadySorted = False
                End If
            Next
            If alreadySorted = True Then Exit For
        Next

        'output an array
        Console.WriteLine("Sorted array values.")
        For i = 1 To 5
            Console.WriteLine(NUM(i))
        Next

        Console.WriteLine("loop counts were = " & c)
        Console.ReadKey()
    End Sub
End Module
