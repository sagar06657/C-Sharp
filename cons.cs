using System;
// Stastic constructor
class User
{
static User()   
    {
        Console.WriteLine("this is stastic  constructor");
    }
    public User()
    {
        Console.WriteLine("this is Defult");
        Console.ReadKey();
    }
    class Pro
    {
        static void Main(string[]args)
        {
            User obj1 = new User();
            User obj2 = new User();
            Console.WriteLine("Press Enter to exit:");
            Console.ReadLine();

        }
    }
}