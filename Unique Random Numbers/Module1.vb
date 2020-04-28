Module Module1

    Sub Main()
        Dim Counter, i, index As Integer
        Dim RT(50) As Boolean
        Dim RD As New Random

        For i = 1 To 50
            RT(i) = False
        Next

        For i = 1 To 50
            Do
                Counter += 1  'Counter=Counter + 1
                index = RD.Next(1, 51)
            Loop Until RT(index) = False
            RT(index) = True
        Next i
        Console.WriteLine("Number of times counter worked is = " & Counter)
        Console.ReadKey()
    End Sub
End Module
