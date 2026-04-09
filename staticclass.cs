using System;

// static class classname{
// stastic data members
// static methods
// }
// class MyColl
// {
//     public static string collegename;
//     public static string address;

//     static MyColl()
//     {
//         collegename = "Lumbini ICT Campus";
//         address = "Gaindakot, Nawalpur";
//     }
// }
// class Pro
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(MyColl.collegename);
//         Console.WriteLine(MyColl.address);

//     }
// }
static class Author
{
    public static string fname = "Sagar";
    public static string lname = "Thapa Magar";
    public static int id = 001;
    public static void details()
    {
        Console.WriteLine("This details of Author:");
    }
}
public class GG
{
    static public void Main()
    {
        Author.details();
        Console.WriteLine("Author Fname:{0}",Author.fname);
        Console.WriteLine("Author Lname:{0}",Author.lname);
        Console.WriteLine("Author ID:{0}",Author.id);
    }
}