using System;
class Pro
{
    static void Main()
    {
        for(int i=0; i<100; i++)
        {
            if (i == 9)
            {
                break;
            }

                Console.WriteLine("i:"+i);
        }
        Console.WriteLine("Loop Completed");
    }
}