using System;
class Math
{
static void Main()
{
    Console.WriteLine("Enter the operation that you want to perform:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Product");
    Console.WriteLine("4. Division");
    int z = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter 1st Number:");
string a = Console.ReadLine();
int num1 = int.Parse(a);

Console.WriteLine("Enter 2nd Number:");
int num2 = int.Parse(Console.ReadLine());

    switch(z)
    {
        case 1:
        int sum = num1 + num2;
        Console.WriteLine("The sum of {0} & {1} is {2}",num1,num2,sum);
        break;

        case 2:
        int diff = num1 - num2;
        Console.WriteLine("The Difference of {0} & {1} is {2}",num1,num2,diff);
        break;

        case 3:
        int product = num1 * num2;
        Console.WriteLine("The product of {0} & {1} is {2}",num1,num2,product);
        break;

        case 4:
        int division = num1 / num2;
        Console.WriteLine("The division of {0} & {1} is {2}",num1,num2,division);
        break;

        default:
        Console.WriteLine("Invalid choice");
        break;
}
}
}