Module Module1
    Sub Main()
        Dim count, sum, avg, x As Integer
        Dim mychar As Char
        Dim NumStr, instring As String
        NumStr = ""
        mychar = ""
        count = 0
        sum = 0
        avg = 0
        x = 1
        Console.WriteLine("Enter a STRING...example: 24,12,16,8,10")
        instring = Console.ReadLine()
        Const Comma = ","
        For x = 1 To Len(instring)
            mychar = Mid(instring, x, 1)
            If mychar = Comma Then
                sum = sum + Val(NumStr)
                count = count + 1
                NumStr = ""
            Else
                NumStr = NumStr & mychar
            End If
        Next
        sum = sum + Val(NumStr)
        count = count + 1
        avg = sum / count
        Console.WriteLine("The sum of String was:" & sum)
        Console.WriteLine("The avg of String was:" & avg)
        Console.ReadKey()
    End Sub
End Module
