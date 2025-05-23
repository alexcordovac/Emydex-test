using System;

namespace FarmSystem.Test1.Entities
{
    class Horse : Animal
    {
        public Horse()
        {
            this.NoOfLegs = 4;
        }

        #region METHODS
        public override void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public override void Run()
        {
            Console.WriteLine("Horse is running");
        }
        #endregion
    }
}