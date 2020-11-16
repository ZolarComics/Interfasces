using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Bobik", new DateTime(2015,5,5));
            Console.WriteLine(d.Age);
            ((IWalking)d).Walk();

            Butterfly but = new Butterfly("Babka", new DateTime(2010, 10, 10));
            ((IFlying)but).Fly();

            Bird bid = new Bird("Kesha", new DateTime(2007, 7, 7));
            ((IFlying)bid).Fly();

            Fish fis = new Fish("Nemo", new DateTime(2006, 6, 6));
            ((ISwimming)fis).Swim();

            Console.ReadKey();
        }
    }
}
