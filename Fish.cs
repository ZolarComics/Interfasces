using System;
namespace Interface
{
    public class Fish : Animal, ISwimming
    {
        public string Name
        { get; set; }

        public override string ToString() => Name;

        public Fish(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
