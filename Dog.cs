using System;
namespace Interface
{
    public class Dog : Animal, IWalking
    {
        public string Name
        { get; set; }

        public override string ToString() => Name;

        public Dog(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }  
    }
}
