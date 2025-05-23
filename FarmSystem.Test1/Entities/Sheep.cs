using System;

namespace FarmSystem.Test1.Entities
{
    class Sheep : Animal
    {
        public Sheep()
        {
            this.NoOfLegs = 4;
        }

        #region METHODS
        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }

        public override void Run()
        {
            Console.WriteLine("Sheep is running");
        }
        #endregion
    }

}