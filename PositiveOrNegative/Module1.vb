' This line declares a module named Module1
Module Module1

    ' This line defines the Main subroutine, which is the entry point of the program
    Sub Main()

        ' Set the foreground color of the console output to Cyan
        System.Console.ForegroundColor = ConsoleColor.Cyan

        ' Prompt the user to enter a number using a colored message
        System.Console.Write("Pls Enter Number: ")

        ' Set the foreground color of the user input prompt to Yellow
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read the user's input, convert it to an integer, and store it in the variable 'Number'
        Dim Number As Integer = Convert.ToInt32(Console.ReadLine())

        ' Add an empty line for better readability
        System.Console.WriteLine()

        ' Use an If-Else statement to check if the number is positive or negative
        If Number >= 0 Then
            ' Set the foreground color to Green
            System.Console.ForegroundColor = ConsoleColor.Green

            ' Display a message indicating the number is positive
            Console.WriteLine("Number Is Positive")
        Else
            ' Set the foreground color to Blue
            System.Console.ForegroundColor = ConsoleColor.Blue

            ' Display a message indicating the number is negative
            Console.WriteLine("Number Is Negative")
        End If

        ' Display a separator line with Magenta foreground color
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")

        ' Display programmer information with Red foreground color
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Pause the console window until the user presses any key
        Console.ReadKey()

    End Sub

End Module
