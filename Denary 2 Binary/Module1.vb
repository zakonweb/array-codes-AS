﻿Module Module1

    Sub Main()
        Dim binArr(8) As Integer
        Dim i, remainder, Denary As Integer

        'Input and validate
        Do
            Console.Write("Enter a denary number (0-255): ")
            Denary = Console.ReadLine
            If Denary > 255 Or Denary < 0 Then Console.WriteLine("Invalid number. Enter between 0 and 255: ")
        Loop Until Denary >= 0 And Denary <= 255

        'Initialise Array
        For i = 1 To 8
            binArr(i) = 0
        Next

        'calculate and collect in array
        i = 0
        While Denary > 0
            i = i + 1
            remainder = Denary Mod 2
            binArr(i) = remainder
            Denary = Denary \ 2
        End While

        'output array to show binary
        For i = 8 To 1 Step -1
            Console.Write(binArr(i))
        Next

        Console.ReadKey()
    End Sub

End Module
