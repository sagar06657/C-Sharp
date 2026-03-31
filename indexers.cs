using System;
class Pro
{
    class Ind
    {
        public string[] names = new string[5];
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }
    static void Main(string[] args)
    {
        Ind team = new Ind();
        team[0] = "Sagar";
        team[1] = "Sushant";
        team[2] = "Buddha";
        team[3] = "Pawan";
        team[4] = "Keeper";
        for(int i=0; i<5; i++)
        {
            Console.WriteLine(team[i]);
        }
        Console.ReadKey();
    }
}