using FarmSystem.Test2.Interfaces;
using System;

namespace FarmSystem.Test1.Entities
{
    class Cow : Animal, IMilkableAnimal
    {
        public Cow()
        {
            this.NoOfLegs = 4;
        }

        #region METHODS
        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }
        #endregion
    }
}