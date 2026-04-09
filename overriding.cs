using System;
class Vir
{
    public virtual void message()
    {
        Console.WriteLine("This is test");
    }
}
class Vir1 : Vir
{
    public override void message()
    {
        Console.WriteLine("This is test2");
    }
}
class Pro
{
    static void Main(string[] args)
    {
        Vir1 ob = new Vir1();
        ob.message();
    }
}