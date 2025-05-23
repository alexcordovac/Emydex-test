using System;

namespace FarmSystem.Test1.Entities
{
    class Hen : Animal
    {
        public Hen()
        {
            this.NoOfLegs = 4;
        }

        #region METHODS
        public override void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public override void Run()
        {
            Console.WriteLine("Hen is running");
        }
        #endregion
    }
}