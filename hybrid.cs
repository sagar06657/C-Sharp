using System;

// Interface
interface IAnimal
{
    void sound();
}

// Base Class implementing interface
class Animal : IAnimal
{
    public void sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

// First Subclass
class Dog : Animal
{
    public void bark()
    {
        Console.WriteLine("Dog barks");
    }
}

// Second Subclass
class Cat : Animal
{
    public void meow()
    {
        Console.WriteLine("Cat meows");
    }
}

// Main Class
class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.sound();
        d.bark();

        Cat c = new Cat();
        c.sound();
        c.meow();
    }
}