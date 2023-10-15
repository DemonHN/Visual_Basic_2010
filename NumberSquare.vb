Module Module1

    Sub Main()
        Dim num As Integer
        Dim x As Integer

        Console.WriteLine("Please Enter a Number :")
        num = Console.ReadLine()

        If num = "1" Then
            Console.WriteLine("1")
        ElseIf num = "2" Then
            Console.WriteLine("22")
            Console.WriteLine("22")
        ElseIf num = "3" Then
            Console.WriteLine("333")
            Console.WriteLine("3*3")
            Console.WriteLine("333")
        ElseIf num = "4" Then
            Console.WriteLine("4444")
            For x = 1 To 2
                Console.WriteLine("4**4")
            Next
            Console.WriteLine("4444")
        ElseIf num = "5" Then
            Console.WriteLine("55555")
            For x = 1 To 3
                Console.WriteLine("5***5")
            Next
            Console.WriteLine("55555")
        ElseIf num = "6" Then
            Console.WriteLine("666666")
            For x = 1 To 4
                Console.WriteLine("6****6")
            Next
            Console.WriteLine("666666")
        ElseIf num = "7" Then
            Console.WriteLine("7777777")
            For x = 1 To 5
                Console.WriteLine("7*****7")
            Next
            Console.WriteLine("7777777")
        ElseIf num = "8" Then
            Console.WriteLine("88888888")
            For x = 1 To 6
                Console.WriteLine("8******8")
            Next
            Console.WriteLine("88888888")
        ElseIf num = "9" Then
            Console.WriteLine("999999999")
            For x = 1 To 6
                Console.WriteLine("9*******9")
            Next
            Console.WriteLine("999999999")
        Else : Console.WriteLine("Please Enter 1-9 ONLY")
        End If
        Console.ReadKey()
    End Sub
End Module
