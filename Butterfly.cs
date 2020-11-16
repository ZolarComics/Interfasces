using System;
namespace Interface
{
    public class Butterfly : Animal, IFlying
    {
        public string Name
        { get; set; }

        public override string ToString() => Name;

        public Butterfly(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
