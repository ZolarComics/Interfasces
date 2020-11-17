using System;

namespace Interface
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            Dog d = new Dog("Bobik", new DateTime(2015,5,5));
            Console.WriteLine($"{d.Name} уже {d.Age}");
            //((IWalking)d).Walk();

            Butterfly but = new Butterfly("Babka", new DateTime(2010, 10, 10));
            Console.WriteLine($"{but.Name} уже {but.Age}");
            //((IFlying)but).Fly();

            Bird bid = new Bird("Kesha", new DateTime(2007, 7, 7));
            Console.WriteLine($"{bid.Name} уже {bid.Age}");
            //((IFlying)bid).Fly();

            Fish fis = new Fish("Nemo", new DateTime(2006, 6, 6));
            Console.WriteLine($"{fis.Name} уже {fis.Age}");
            //((ISwimming)fis).Swim();

            Gym gym = new Gym();
            gym.AddAnimal(d);
            gym.AddAnimal(but);
            gym.AddAnimal(bid);
            gym.AddAnimal(fis);
            gym.LetsMove();

            Console.ReadKey();
        }
    }
}
