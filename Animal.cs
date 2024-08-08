using System;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor de Animal
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void MakeSound()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}
