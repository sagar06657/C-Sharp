// Multiple Inheritance
using System;
interface IA
{
    int CalculateArea();
    int CalculatePerimeter();
}
class CA
{
    public int l, b;
    public void ReadData(int l, int b)
    {
        this.l = l;
        this.b = b;
    }
}
class BB: CA, IA
{
    public int CalculateArea()
    {
        ReadData(10, 5);
        int area = l * b;
        return area;
    }

    public int CalculatePerimeter()
    {
        ReadData(5, 15);
        int per = 2 * (l+b);
        return per;
    }
}
class Inter
{
    static void Main(string[] args)
    {
        BB obj = new BB();
        Console.WriteLine("Area of Rectngle:"+obj.CalculateArea());
        Console.WriteLine("Perimetr of Rectange:"+obj.CalculatePerimeter());
        Console.ReadKey();
    }
    
}