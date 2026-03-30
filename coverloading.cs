// 
using System;
class Employee
{
    public string Name;
    public int Age;
    public double Salary;

    // Default constructor
    public Employee()
    {
        Name : "Pawan";
        Age : 20;
        Salary : 12000;
    }
    
    // Constructor with 2 parameter
    public Employee(string name, int age)
    {
        Name : name;
        Age : age;
        Salary : 0.0;
    }

    // Constructor with 3 parameter
    public Employee(string name, int age, double salary)
    {
        Name : name;
        Age : age;
        Salary : salary;
    }

    public void display()
    {
        Console.WriteLine($"Name.{Name}, Age.{Age}, Salary.{Salary}");
    }
}
class Pro
{
    static void Main()
    {
        Employee emp1 = new Employee();
        Employee emp2 = new Employee("Sushant",20);
        Employee emp3 = new Employee("Buddha",20,50000);

        emp1.display();
        emp2.display();
        emp3.display();
    }
}