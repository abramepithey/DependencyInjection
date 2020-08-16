using System;
using System.Collections.Generic;

namespace DependencyInjection.Classes
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public int Legs { get; set; } = 4;

        public List<IAnimal> Friends { get; private set; }

        public void MakeNewFriend(IAnimal animal)
        {
            Friends.Add(animal);
        }

        public void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }

        public Cat(string name)
        {
            Name = name;
        }
    }
}
