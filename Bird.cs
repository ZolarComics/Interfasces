using System;
namespace Interface
{
    public class Bird : Animal, IFlying
    {
        public string Name
        { get; set; }

        public override string ToString() => Name;

        public Bird(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
