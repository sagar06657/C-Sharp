using System;
class Pro
{
    static void Main()
    {
        for(int i=1; i<50; i++)
        {
            if (i %2 != 0)
            {
                continue;
            }

                Console.WriteLine("i:"+i);
        }
        Console.WriteLine("Loop Completed");
    }
}