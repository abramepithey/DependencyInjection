using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Classes
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Legs { get; set; }
        List<IAnimal> Friends { get; }
        void MakeNewFriend(IAnimal animal);
        void MakeNoise();
    }
}
