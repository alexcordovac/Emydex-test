﻿using FarmSystem.Test1.Entities;
using FarmSystem.Test1.Events;
using FarmSystem.Test1.Interfaces;
using FarmSystem.Test2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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

        private FarmEmptyChangedEvent farmEmptyChanged = new FarmEmptyChangedEvent();
        public FarmEmptyChangedEvent FarmEmptyChanged
        {
            get { return farmEmptyChanged; }
            set { farmEmptyChanged = value; }
        }

        #endregion

        #region METHODS

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
            foreach (Animal animal in this.Animals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            var milkableAnimals = this.Animals.Where(animal => animal is IMilkableAnimal);

            foreach (IMilkableAnimal animal in milkableAnimals)
            {
                animal.ProduceMilk();
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            var animalsReleased = new Queue<Animal>(this.Animals);

            foreach (Animal animal in this.Animals)
            {
                Console.WriteLine($"{animal.GetType().Name} has left the farm");
            }

            this.Animals.Clear();
            this.FarmEmptyChanged.OnFarmEmptyChanged(this, new FarmEmptyChangedEventArgs(animalsReleased));
        }

        #endregion
    }
}