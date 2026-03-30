using System;
namespace OopDemo
{
    public class Stu
    {
        private int id;
        private string name;

        public void Setdata(int i, string n)
        {
            id = i;
            name = n;
        }
        public void DisplayData()
        {
            Console.WriteLine("Student Id: "+id);
            Console.WriteLine("Student name: "+name);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Stu s1 = new Stu();
            s1.Setdata(101,"sagar");
            s1.DisplayData();
            Console.ReadLine();
        }
    }
}