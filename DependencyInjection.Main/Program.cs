using DependencyInjection.Classes;
using Microsoft.Win32.SafeHandles;
using System;

namespace DependencyInjection.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            IZoo zoo = new Zoo();
            zoo.ShowAllAnimals();
            IAnimal animal = zoo.GetAnimalByName("Simon");
            Console.WriteLine(animal.Name);
        }
    }
}
