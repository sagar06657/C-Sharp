// abstract methods
using System;
abstract class Test1
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public abstract int mul(int a, int b);
}
class Test2 : Test1
{
    public override int mul(int a, int b)
    {
        return (a * b);
    }
}
class Test3 : Test1
{
    public override int mul(int a, int b)
    {
        return (a - b);
    }
}
class MyClass
{
    public static void Main(string[] args)
    {
        Test2 ob = new Test2();
        int a = ob.mul(5,4);
        Test3 ob = new Test3();
        int b = ob.mul(5,4);
        int c = ob.add(5,4);
        Console.WriteLine("{0},{1},{2}",a,b,c);
    }
}