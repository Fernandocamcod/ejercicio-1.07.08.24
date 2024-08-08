using System;

public class Dog : Animal
{
    public string Breed { get; set; }

    // Constructor de Dog
    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} ladra: ¡Guau guau!");
    }
}
