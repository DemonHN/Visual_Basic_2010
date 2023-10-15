Module Module1
    Sub Main()
        Dim sign As String
        Dim a, b As Single
        Dim equals As Single
        
        Console.WriteLine("Enter Sign (+) (-) (*) (/) (!) (^2) (^3) (^x)")     'sign input 
        sign = Console.ReadLine()

        If sign = "+" Then     'sign compare, call function
            equals = Add(a, b)
        ElseIf sign = "-" Then
            equals = Subtract(a, b)
        ElseIf sign = "*" Then
            equals = Multiply(a, b)
        ElseIf sign = "/" Then
            equals = Divide(a, b)
        ElseIf sign = "!" Then
            equals = Factorial(a)
        ElseIf sign = "^2" Then
            equals = Square(a)
        ElseIf sign = "^3" Then
            equals = Cube(a)
        Else
            Console.WriteLine("Please Enter a Valid Sign")     'sign validation
        End If
        Console.WriteLine()
        Console.WriteLine(equals)
        Console.ReadKey()
    End Sub
    Function Add(ByVal a As Integer, ByVal b As Integer) As Single
        Dim equals As Single
        a = 0
        b = 0
        Console.WriteLine("Enter Number 1: ")
        a = Console.ReadLine()
        Console.WriteLine("Enter Number 2: ")
        b = Console.ReadLine()
        equals = a + b     'add two numbers
        Return equals
    End Function
    Function Subtract(ByVal a As Integer, ByVal b As Integer) As Single
        Dim equals As Single
        a = 0
        b = 0
        Console.WriteLine("Enter Number 1: ")
        a = Console.ReadLine()
        Console.WriteLine("Enter Number 2: ")
        b = Console.ReadLine()
        equals = a - b
        Return equals
    End Function
    Function Multiply(ByVal a As Integer, ByVal b As Integer) As Single
        Dim equals As Single
        a = 0
        b = 0
        Console.WriteLine("Enter Number 1: ")
        a = Console.ReadLine()
        Console.WriteLine("Enter Number 2: ")
        b = Console.ReadLine()
        equals = a * b
        Return equals
    End Function
    Function Divide(ByVal a As Integer, ByVal b As Integer) As Single
        Dim equals As Single
        a = 0
        b = 0
        Console.WriteLine("Enter Number 1: ")
        a = Console.ReadLine()
        Console.WriteLine("Enter Number 2: ")
        b = Console.ReadLine()
        equals = a / b
        Return equals
    End Function
    Function Factorial(ByVal a As Integer) As Integer
        Dim num As Integer
        Dim ans As Integer
        Dim index As Integer
        Console.WriteLine("Enter Number: ")
        num = Console.ReadLine()
        ans = 1
        index = 1
        Dim x As Integer
        x = 1 '2
        For x = 1 To num  '1\2\3\4\5
            ans = ans * x
        Next
        Return ans
    End Function
    Function Square(ByVal a As Integer) As Integer
        Dim num As Integer
        Dim equals As Integer
        Console.WriteLine("Enter Number: ")
        num = Console.ReadLine()
        equals = num * num
        Return equals
    End Function
    Function Cube(ByVal a As Integer) As Integer
        Dim num As Integer
        Dim equals As Integer
        Console.WriteLine("Enter Number: ")
        num = Console.ReadLine()
        equals = num * num * num
        Return equals
    End Function
End Module


