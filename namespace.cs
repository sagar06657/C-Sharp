using System;

namespace First
{
    class Suru
{
    public void show()
    {
        Console.WriteLine("I am");
    }
}
}
namespace Second
    {
        using First;
        class Paxi
        {
            public void display()
            {
                Suru obj = new Suru();
                obj.show();
            }
        }
    }
// namespace Third
//     {
//         using First;
//         using Second;
//         class Tespaxi
//         {
//             public void test()
//             {
//                 Suru obj = new Suru();
//             }
//         }
//     }

class Program
{
    static void Main()
    {
        Second.Paxi p = new Second.Paxi();
        p.display();
    }
}
