using System;
namespace Interface
{
    public interface ISwimming
    {
        public void Swim()
        {
            Console.WriteLine(this + " плывет в новую точку");
        }
    }
}
