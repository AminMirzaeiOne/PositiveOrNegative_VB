Module Module1

    Sub Main()
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Pls Enter Number : ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim Number As Integer = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine()
        If Number >= 0 Then
            System.Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Number Is Positive")

        Else
            System.Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("Number Is Negative")

        End If
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")
        Console.ReadKey()
    End Sub

End Module
