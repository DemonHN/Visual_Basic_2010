Module Module1
    'Bubble Sort in a defined Array'
    Sub Main()
        Dim Chars(0 To 9) As Integer
        Chars = {"11", "32", "95", "50", "72", "27", "44", "68", "01", "89"}
        Call displayarray(Chars)
        Console.WriteLine()
        Call BubbleSort(Chars)
        Call displayarray(Chars)
        Console.WriteLine()
        Console.ReadKey()
    End Sub
    Sub BubbleSort(ByVal NewArray As Array)
        Dim swap As Boolean
        Dim temp As String
        swap = True
        While swap = True
            swap = False
            For index = 0 To 8
                If NewArray(index + 1) < NewArray(index) Then
                    temp = NewArray(index + 1)
                    NewArray(index + 1) = NewArray(index)
                    NewArray(index) = temp
                    swap = True
                End If
            Next
        End While
    End Sub
    Sub displayarray(ByVal newarray As Array)
        For x = 0 To 9
            Console.Write(" " & newarray(x))
        Next
        Console.WriteLine()
    End Sub
End Module
