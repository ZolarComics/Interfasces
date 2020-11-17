using System;
using System.Collections.Generic;

namespace Interface
{
    public class Gym
    {
        List<Animal> animals = new List<Animal>();

        public Gym()
        {
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void LetsMove()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] is IWalking)
                {
                    IWalking iDog = animals[i] as IWalking;
                    iDog.Walk();
                }
                else if (animals[i] is IFlying)
                {
                    IFlying iFly = animals[i] as IFlying;
                    iFly.Fly();
                }
                else if (animals[i] is ISwimming)
                {
                    ISwimming iFish = animals[i] as ISwimming;
                    iFish.Swim();
                }
            }
        }
    }
}
