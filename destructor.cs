using System;
// /Method over loading
class ConDes
{
    public ConDes(string msg)
    {
        Console.WriteLine(msg);
    }
    public void Test()
    {
        Console.WriteLine("this is simple method");
    }
    ~ConDes()
    {
        Console.WriteLine("this is Destructor");
        Console.ReadKey();
    }
    class Construct
    {
        static void Main()
        {
            string m = "This is constructor";
            ConDes obj = new ConDes(m);
            obj.Test();
        }
    }
}