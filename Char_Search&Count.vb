Module Module1
    Function GetChar(ByVal InString As String, ByVal SearchChar As Char) As Integer
        Dim x, count As Integer
        Dim mychar As Char
        For x = 1 To Len(InString)
            mychar = Mid(InString, x, 1)
            If mychar = SearchChar Then
                count = count + 1
            End If
        Next x
        Return count
    End Function
    Sub Main()
        Dim instring As String
        Dim inchar As Char
        Dim count As Integer
        Console.WriteLine("Enter a Sentence...")
        instring = Console.Readline
        Console.WriteLine("Enter a Character to Search...")
        inchar = Console.ReadLine
        count = GetChar(instring, inchar)
        Console.WriteLine()
        Console.WriteLine(count)
        Console.ReadKey()
    End Sub
End Module
