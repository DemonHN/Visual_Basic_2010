Module Module1
    'Char Replace 
    Sub Main()
        Dim instring, outstring As String
        Dim OWord, NWord As String
        outstring = ""
        Console.WriteLine("Please Enter a Sentence...")
        instring = Console.ReadLine()
        Console.WriteLine("Please Enter Word to Replace...")
        OWord = Console.ReadLine()
        Console.WriteLine("Please Enter New Word...")
        NWord = Console.ReadLine()
        outstring = ReplaceChar(instring, OWord, NWord)
        Console.WriteLine()
        Console.WriteLine(outstring)
        Console.ReadKey()
    End Sub
    Function ReplaceChar(ByVal InString As String, ByVal OWord As String, ByVal NWord As String) As String
        Dim mychar As Char
        Dim x As Integer
        Dim outstring As String
        outstring = ""
        x = 1
        For x = 1 To Len(InString)
            mychar = Mid(InString, x, 1)
            If mychar = OWord Then
                outstring = outstring & NWord
            Else
                outstring = outstring & mychar
            End If
        Next
        Return outstring
    End Function
End Module
