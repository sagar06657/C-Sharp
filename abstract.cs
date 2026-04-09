using System;
abstract class Men
{
    public int add(int a, int b)
    {
        return (a + b);
    }
}
class Men1 : Men
{
    public int mul(int a, int b)
    {
        return (a * b);
    }
}
class Test
{
    static void Main(string[]args)
    {
        Men1 ob = new Men1();
        int r = ob.add(10,20);
        Console.WriteLine("result={0}",r);
    }
}