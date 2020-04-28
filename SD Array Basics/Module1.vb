Module Module1

    Sub Main()
        Dim namesArr(5) As String
        Dim sName As String
        Dim a As Integer
        Dim isFound As Boolean
        isFound = False

        'Initialisation
        For a = 1 To 5
            namesArr(a) = ""
        Next

        'populate
        For a = 1 To 5
            Console.Write("Enter name:" & a & " ")
            sName = Console.ReadLine
            namesArr(a) = sName
        Next

        'output all
        For a = 1 To 5
            Console.WriteLine(namesArr(a))
        Next

        'linear or simple searching()
        Console.Write("Enter Name to search for: ")
        sName = Console.ReadLine
        For a = 1 To 5
            If namesArr(a) = sName Then
                Console.WriteLine(a)
                isFound = True
            End If
        Next
        If isFound = False Then
            Console.WriteLine("Name was not found.")
        End If
        Console.ReadKey()

    End Sub

End Module
