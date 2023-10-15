Module Module1
    'User Defined Datatype\UDT
    Structure studentdata
        Dim name As String
        Dim age As Integer
        Dim status As Boolean
    End Structure
    Sub Main()
        Dim student(0 To 4) As studentdata
        For x = 0 To 4
            Console.WriteLine("Enter Student Name") : student(x).name = Console.ReadLine()
            Console.WriteLine("Enter Student Age") : student(x).age = Console.ReadLine()
            Console.WriteLine("Enter Student Status") : student(x).status = Console.ReadLine()
        Next
    End Sub

End Module
