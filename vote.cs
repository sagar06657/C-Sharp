using System;
class Pro
{
    static void Main()
    {
        Console.WriteLine("Enter your Age:");
        int age = int.Parse(Console.ReadLine());
        // int age=10;
        if (age < 18)
            throw new ArithmeticException("Not Elligile");
            else
            Console.WriteLine("elligible to vote");
         
    }
}