using System;
class My
{
    private int x;
    public void SetX(int i)
    {
        x = i;
    }
    public int GetX()
    {
        return x;
    }
    class Client
    {
        public static void Main()
        {
            My e = new My();
            e.SetX(10);
            int val = e.GetX();
            Console.WriteLine($"value={val}");
        }
    }
}