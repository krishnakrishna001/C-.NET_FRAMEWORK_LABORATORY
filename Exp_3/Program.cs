using System;

// Single Inheritance
class Person
{
    public void ShowPerson()
    {
        Console.WriteLine("I am a Person");
    }
}

class Student : Person
{
    public void ShowStudent()
    {
        Console.WriteLine("I am a Student");
    }
}

// Multiple Inheritance using Interfaces
interface ISports
{
    void Play();
}

interface IMusic
{
    void Sing();
}

class Talent : ISports, IMusic
{
    public void Play()
    {
        Console.WriteLine("I play Cricket");
    }

    public void Sing()
    {
        Console.WriteLine("I can Sing");
    }
}

// Multilevel Inheritance
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eats food");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class Puppy : Dog
{
    public void Weep()
    {
        Console.WriteLine("Puppy weeps");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Single Inheritance");
        Student s = new Student();
        s.ShowPerson();
        s.ShowStudent();

        Console.WriteLine("\nMultiple Inheritance");
        Talent t = new Talent();
        t.Play();
        t.Sing();

        Console.WriteLine("\nMultilevel Inheritance");
        Puppy p = new Puppy();
        p.Eat();
        p.Bark();
        p.Weep();
    }
}

