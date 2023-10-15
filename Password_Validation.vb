Module Module1

    Sub Main()
        Dim password As String
        Console.WriteLine("Enter Password")
        password = Console.ReadLine()
        Console.Write(ValidatePassword(password))
        Console.ReadKey()
    End Sub
    Function ValidatePassword(ByVal Pass As String) As Boolean
        Dim mychar As Char
        Dim flag As Boolean
        Dim x, ucount, lcount, num As Integer
        ucount = 0
        lcount = 0
        flag = True
        x = 1

        For x = 1 To Len(Pass)
            mychar = Mid(Pass, x, 1)
            If mychar >= "A" And mychar <= "Z" Then
                ucount = ucount + 1
            Else
                If mychar >= "a" And mychar <= "z" Then
                    lcount = lcount + 1
                Else
                    If mychar >= "0" And mychar <= "9" Then
                        num = num + 1
                    Else
                        Return False
                    End If
                End If
            End If
        Next
        If ucount >= 2 And lcount >= 2 And num >= 3 Then
            Return True
        End If
    End Function
End Module
