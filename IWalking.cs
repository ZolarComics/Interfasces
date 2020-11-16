using System;
namespace Interface
{
    public interface IWalking
    {
        public void Walk()
        {
            Console.WriteLine(this + " идет в новую точку");
        }

    }
}
