using System;
class Student
{
    public int id, age;
    public string name, sub;
    public Student(int id, string name, int age, string sub)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.sub = sub;
    }
    public void showInfo()
    {
        Console.WriteLine(id+""+name+""+age+""+sub);
    }
    class StudentDetails
    {
        public static void Main(string[] args)
        {
            Student std1 = new Student(001,"Sagar",25,"Dot NET");
            std1.showInfo();
        }
    }
}