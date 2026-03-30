using System;
// class Prog
// {
//     static void Main()
//     {
//         int[] a = {10,5,20,15,20,25};
//         foreach(int val in a)
//         {
//             Console.WriteLine(val);
//         }
//         Console.ReadKey();
//     }
// }

class Proga
{
    static void Main()
    {
        int i, j;
        for(i=0; i<10; i++)
        {
            for(j=i; j<10; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}