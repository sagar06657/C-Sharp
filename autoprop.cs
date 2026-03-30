using System;
class Auto
{
    public int a{get; set;}
    public int b{get; set;}
    public int sum
    {
        get { return a+b;}
    }
}

class Test
{
    static void Main()
    {
        Auto obj = new Auto();
        obj.a = 10;
        obj.b = 30;
        Console.WriteLine("sum of "+obj.a+"and"+obj.b+"="+obj.sum);
        Console.ReadKey();

    }
}