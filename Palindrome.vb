Module Module1

    Sub Main()
        Dim instring, outstring1, outstring2, str As String
        Dim index As Integer

        Console.WriteLine("Enter a word to check PALINDROME") 'madam 123321
        instring = Console.ReadLine
        outstring1 = ""
        outstring2 = ""
        index = 1

        For index = 1 To Len(instring)
            str = Mid(instring, index, 1)
            outstring1 = outstring1 & str
        Next

        For index = Len(instring) To 1 Step -1
            str = Mid(instring, index, 1)
            outstring2 = outstring2 & str
        Next

        If outstring1 <> outstring2 Then
            Console.WriteLine("This is not a Palindrome")
        Else : Console.WriteLine("This is a Palindrome")
        End If
        Console.WriteLine()
        Console.ReadKey()

    End Sub

End Module
