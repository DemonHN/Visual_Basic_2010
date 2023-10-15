Module Module1
    Dim MyArray = {"Milk", "Jam", "Bread", "Biscuit", "Chips", "Juice", "Eggs", "Cream", "Lolipops", "CornFlakes"}
    Sub Main()
        Call ArraySearch()
        Console.ReadKey()
    End Sub
    Sub ArraySearch()
        Dim SearchItem As String
        Dim flag As Boolean
        Dim x As Integer
        SearchItem = ""
        x = 1
        Console.WriteLine("Enter the Item to Search")
        SearchItem = Console.ReadLine()
        While x <= 10 And flag = False
            If SearchItem = MyArray(x) Then
                Console.WriteLine(SearchItem & " was found in the Array at index : " & x)
                flag = True
            End If
            x = x + 1
        End While
        If flag = False Then
            Console.WriteLine("Item NOT FOUND")
        End If
    End Sub
End Module
