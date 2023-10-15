Module Module1
    Sub Main()
        'Elimination of Spaces in Whole String 
        Dim mystring, outstring, finalstring As String
        Dim mychar1, mychar2 As Char
        Dim x As Integer
        Console.WriteLine("Enter String to Concatenate")
        mystring = Console.ReadLine()
        outstring = ""
        finalstring = ""
        mychar1 = ""
        mychar2 = ""
        For x = 1 To Len(mystring)
            mychar1 = Mid(mystring, x, 1)
            If mychar1 <> " " Then
                outstring = outstring & mychar1
            End If
        Next
        Console.WriteLine(outstring)
        Console.ReadKey()
    End Sub
End Module
