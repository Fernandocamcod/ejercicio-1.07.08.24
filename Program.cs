using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase Animal usando el constructor
        Animal animal = new Animal("Animal Genérico", 5);
        animal.MakeSound();

        // Crear una instancia de la clase Dog usando el constructor
        Dog myDog = new Dog("Buddy", 3, "Golden Retriever");
        myDog.MakeSound(); // Heredado de Animal
        myDog.Bark();      // Método específico de Dog

        Console.WriteLine($"{myDog.Name} es un {myDog.Breed} y tiene {myDog.Age} años.");

        // Esperar a que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
