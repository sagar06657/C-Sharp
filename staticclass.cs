using System;

// static class classname{
// stastic data members
// static methods
// }
class MyColl
{
    public static string collegename;
    public static string address;

    static MyColl()
    {
        collegename = "Lumbini ICT Campus";
        address = "Gaindakot, Nawalpur";
    }
}
class Pro
{
    static void Main(string[] args)
    {
        Console.WriteLine(MyColl.collegename);
        Console.WriteLine(MyColl.address);

    }
}