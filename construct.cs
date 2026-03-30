using System;
    public class Stu
    {
        public readonly int id;

        public Stu(int i)
        {
            id = i;
        }
        public void show()
        {
            // id = 200;
            Console.WriteLine("Student Id: "+id);
            
        }
    }
    class Program
    {
        static void Main()
        {
            Stu s1 = new Stu(44);
            s1.show();
            Console.ReadLine();
        }
    }