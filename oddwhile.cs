using System;
class Odd
{
    static void Main()
    {
        int i = 1;
        while (i <= 50)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Even");
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("odd");
                Console.WriteLine(i);
            }
            i++;
        }

    }
}