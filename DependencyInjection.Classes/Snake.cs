using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Classes
{
    public class Snake : ISnake
    {
        public string Name { get; set; }
        public int Legs { get; set; } = 0;

        public List<IAnimal> Friends { get; private set; }

        public void MakeNewFriend(IAnimal animal)
        {
            Friends.Add(animal);
            Console.WriteLine($"{ Name } looks sssssussssspissssiousssssss...");
        }

        public void MakeNoise()
        {
            Console.WriteLine("Hiss.");
        }

        public void Slither()
        {
            Console.WriteLine("-it doesn't sound like anything but it's moving-");
        }

        public Snake(string name)
        {
            Name = name;
        }
    }
}
