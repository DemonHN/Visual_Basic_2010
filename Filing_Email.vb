Module Module1

    Sub Main()
        Dim choice As Integer

        choice = 0

        While choice <> 5
            Console.Clear()
            Console.WriteLine("Enter 1 to APPEND Record in File")
            Console.WriteLine("Enter 2 to Create New File / Delete Existing File")
            Console.WriteLine("Enter 3 to SEARCH Record in File")
            Console.WriteLine("Enter 4 to READ File")
            Console.WriteLine("Enter 5 to EXIT")
            Console.Write("Please Enter Your Choice :")
            choice = Console.ReadLine()

            Select Case choice
                Case 1 : Append()
                Case 2 : Create()
                Case 3 : Search()
                Case 4 : Read()
                Case 5
                Case Else
                    Console.WriteLine("Wrong Choice, Please Choose from 1 Till 4 and Choose 5 to EXIT")
                    Console.ReadKey()
            End Select
        End While
    End Sub

    Sub Append()
        Dim email As String
        Console.WriteLine("Enter Email Address")
        email = Console.ReadLine()

        FileOpen(1, My.Application.Info.DirectoryPath & "\EmailAddresses.txt", OpenMode.Append)
        WriteLine(1, email)
        FileClose(1)
        Console.WriteLine("Email Saved")
        Console.ReadKey()
    End Sub

    Sub Create()
        Dim email As String
        Console.WriteLine("Enter Email Address")
        email = Console.ReadLine()

        FileOpen(1, My.Application.Info.DirectoryPath & "\EmailAddresses.txt", OpenMode.Output)
        WriteLine(1, email)
        FileClose(1)
        Console.WriteLine("The New File is Created or The old file with same name has been formatted")
        Console.ReadKey()
    End Sub
    Sub Read()
        Dim email As String
        email = ""
        FileOpen(1, My.Application.Info.DirectoryPath & "\EmailAddresses.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, email)
            Console.WriteLine(email)
        End While
        FileClose(1)
        Console.WriteLine("All Current Data In File")
        Console.ReadKey()
    End Sub

    Sub Search()
        Dim email As String
        email = ""
        Dim flag As Boolean
        flag = True
        Dim SEmail
        Console.Write("Enter Email to Search :")
        SEmail = Console.ReadLine()
        FileOpen(1, My.Application.Info.DirectoryPath & "\EmailAddresses.txt", OpenMode.Input)
        While Not EOF(1) And flag = True
            Input(1, email)
            If email = SEmail Then
                Console.WriteLine(SEmail)
                Console.WriteLine("Data Found")
                flag = True
            End If
        End While
        FileClose(1)
        If flag = False Then
            Console.WriteLine("Data Not Found")
        End If
    End Sub
End Module
