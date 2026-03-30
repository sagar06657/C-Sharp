using System;
class Pro
{
    static void Main()
    {
        char grade;
        Console.WriteLine("Enter your grade(A|B|C|D|E):");
        grade = Convert.ToChar(Console.ReadLine().ToUpper());
        switch(grade)
        {
            case 'A':
            Console.WriteLine("Excellent");
            break;
            case 'B':
            Console.WriteLine("Very Good");
            break;
            case 'C':
            Console.WriteLine("Good");
            break;
            case 'D':
            Console.WriteLine("Needs Improvements");
            break;
            case 'E':
            Console.WriteLine("Fail");
            break;
            default:
            Console.WriteLine("Invalid Grade");
            break;
        }
    }
}