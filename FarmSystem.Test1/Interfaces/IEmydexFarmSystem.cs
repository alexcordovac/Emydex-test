using FarmSystem.Test1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FarmSystem.Test1.FarmSystem.EmydexFarmSystem;

namespace FarmSystem.Test1.Interfaces
{
    public interface IEmydexFarmSystem
    {
        event FarmEmptyChangedHandler FarmEmptyChanged;
        void Enter(Animal animal);
        void MakeNoise();
        void MilkAnimals();
        void ReleaseAllAnimals();
    }
}
