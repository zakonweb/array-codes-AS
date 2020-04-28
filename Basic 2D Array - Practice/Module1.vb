Module Module1

    Sub Main()
        Dim marks(5, 10) As Integer

        'Initialisation
        For row = 1 To 5
            For col = 1 To 10
                marks(row, col) = 0
            Next
        Next

        'populate
        'For row = 1 To 5
        'For col = 1 To 10
        'marks(row, col) = Console.ReadLine
        'Next
        'Next

        'Process
        For row = 1 To 5
            For col = 1 To 10
                marks(row, col) = row * col
            Next
        Next

        'output
        For row = 1 To 5
            For col = 1 To 10
                Console.Write(marks(row, col) & " ")
            Next
            Console.WriteLine()
        Next

        Console.ReadKey()
    End Sub

End Module
