using FarmSystem.Test1.Entities;
using FarmSystem.Test1.Interfaces;
using System;
using System.Collections.Generic;

namespace FarmSystem.Test1.FarmSystem
{
    public class EmydexFarmSystem : IEmydexFarmSystem
    {
        public EmydexFarmSystem()
        {
            this.Animals = new Queue<Animal>();
        }

        #region PROPERTIES
        private Queue<Animal> animals;

        public Queue<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }
        #endregion

        //TEST 1
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            this.Animals.Enqueue(animal);
            Console.WriteLine($"{animal.GetType().Name} has entered the farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            Console.WriteLine("There are no animals in the farm");
        }

        //TEST 3
        public void MilkAnimals()
        {
            Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
           Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}