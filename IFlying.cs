using System;
namespace Interface
{
    public interface IFlying
    {
        public void Fly()
        {
            Console.WriteLine(this + " летит в новую точку");
        }
    }
}
