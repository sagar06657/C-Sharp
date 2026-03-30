using System;
// /Method over loading
class Pro
{
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    static double Add(double a, double b)
    {
        return a + b;
    }
    static void Main()
    {
        Console.WriteLine("sum of 2 integer:"+Add(5,10));
        Console.WriteLine("sum of 3 integer:"+Add(5,10,2));
        Console.WriteLine("sum of 2 Floats:"+Add(5.5,9.3));
    }
}