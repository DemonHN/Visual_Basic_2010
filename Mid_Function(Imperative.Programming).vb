Module Module1
    'Imperitive Programming (MID FUNCTION)
    Sub Main()
        Dim Str As String
        Dim start, count As Integer
        Dim outstring As String
        outstring = ""
        Str = ""
        start = 0
        count = 0
        Console.WriteLine("Enter a Sentence...")
        Str = Console.ReadLine()
        Console.WriteLine("Enter the Start Point...(2nd Parameter)")
        start = Console.ReadLine()
        Console.WriteLine("Enter the number of value to be extracted...")
        count = Console.ReadLine()
        outstring = MIDFunc(Str, start, count)
        Console.WriteLine()
        Console.WriteLine(outstring)
        Console.ReadKey()
    End Sub
    Function MIDFunc(ByRef Instring As String, ByRef Start As Integer, ByRef Count As Integer) As String
        Dim lenStr As Integer
        Dim outstring As String
        lenStr = Len(Instring)
        outstring = ""
        outstring = Left(Instring, Start + Count - 1)
        outstring = Right(outstring, Count)
        Return outstring
    End Function
End Module
