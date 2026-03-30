using System;

class Pre
{
    static void Main()
    {
        string message = "Hello World";
        string upperMessage = message.ToUpper();
        Console.WriteLine(upperMessage);

        int x = 2026;
        message = message + x.ToString();
        Console.WriteLine(message);
    }
}