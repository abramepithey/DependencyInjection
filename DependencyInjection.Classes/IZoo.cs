using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Classes
{
    public interface IZoo
    {
        List<IAnimal> Animals { get; }
        void CreateAnimal(string name);
        IAnimal GetAnimalByName(string name);
        void ShowAllAnimals();
    }
}
