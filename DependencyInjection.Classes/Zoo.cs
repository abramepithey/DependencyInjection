using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace DependencyInjection.Classes
{
    public class Zoo : IZoo
    {
        public List<IAnimal> Animals { get; private set; }

        public void CreateAnimal(string name)
        {

            Random rand = new Random();
            int coinToss = rand.Next(1, 3);
            if (coinToss == 1)
            {
                Animals.Add(new Snake(name));
            }
            else if (coinToss == 2)
            {
                Animals.Add(new Cat(name));
            }
        }

        public IAnimal GetAnimalByName(string name)
        {
            try
            {
                IAnimal animal = Animals.Single(e => e.Name == name);
                return animal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public void ShowAllAnimals()
        {
            foreach (IAnimal animal in Animals)
            {
                Console.WriteLine($"This is { animal.Name }.");
                animal.MakeNoise();
                if (animal is ISnake snake)
                {
                    snake.Slither();
                }
            }
        }

        public Zoo()
        {
            Animals = AnimalsList.AnimalsSeed();
        }
    }

    public static class AnimalsList
    {
        public static List<IAnimal> AnimalsSeed()
        {
            List<IAnimal> animals = new List<IAnimal>();

            Cat cat1 = new Cat("Stinky");
            Cat cat2 = new Cat("Lumpy");
            Cat cat3 = new Cat("Lana");
            Snake snake1 = new Snake("Simon");
            Snake snake2 = new Snake("Chester");

            animals.Add(cat1);
            animals.Add(cat2);
            animals.Add(cat3);
            animals.Add(snake1);
            animals.Add(snake2);

            return animals;
        }
    }
}
