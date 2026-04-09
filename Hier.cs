using System;
class Polygon
{
    public int dim1, dim2;
    public void ReadDimension(int dim1, int dim2)
    {
        this.dim1 = dim1;
        this.dim2 = dim2;
    }
}
class Rectangle : Polygon
{
    public void AreaRe()
    {
        int area = dim1 * dim2;
        Console.WriteLine("area of rectangel:"+area);
    }
}
class Triangle : Polygon
{
    public void AreaTri()
    {
        double area = 0.5 * dim1 * dim2;
        Console.WriteLine("area of Triangle:"+area);
    }
}
class Hier
{
    static void Main()
    {
        Triangle tri = new Triangle();
        tri.ReadDimension(10,5);
        tri.AreaTri();

        Rectangle rec = new Rectangle();
        rec.ReadDimension(7, 10);
        rec.AreaRe();
        Console.ReadLine();
    }
}